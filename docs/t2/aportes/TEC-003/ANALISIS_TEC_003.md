# Análisis Funcional, Ingeniería Inversa y Diagnóstico — Paquete `TEC-003`

- **Paquete / Solicitud:** `TEC-003` / `CR-TEC-003` (Gestión de feriados por capas y coordinación de flujos `T2-04`).
- **Responsable:** Frank Piero Mantilla Arqueros.
- **Revisor asignado:** Francisco Kadin Valera Lizarraga (`TEC-003`) / Jorge Enrique Cano Asto (`T2-04`).
- **Rama:** `refactor/tec-003-feriados`.
- **Fecha:** 17/10/2026.
- **Línea base analizada:** Commit `eeeb817` (rama de equipo `f713383`) sobre Windows 10/11, .NET Framework 4.8 (`x86`) y PostgreSQL 16 (Neon `neondb`).

---

## 1. Ingeniería inversa funcional y técnica de `FrmFeriado` (`eeeb817`)

### 1.1. Inventario de entradas de menú, métodos y tablas

| Elemento | Ubicación en `eeeb817` | Función observada | Tablas / Componentes invocados |
|---|---|---|---|
| **Acceso desde barra principal** | `MainMDI.ToolStripButton10_Click` (`MainMDI.cs` l. 2636) | Abre el formulario de feriados como ventana hija MDI (`MdiParent = this`). | `new FrmFeriado()` (sin `CompositionRoot`). |
| **Acceso desde menú principal** | `MainMDI.FeriadosToolStripMenuItem1_Click` (`MainMDI.cs` l. 2678) | Abre el formulario de feriados desde el menú superior. | `new FrmFeriado()` (sin `CompositionRoot`). |
| **Carga de feriados** | `FrmFeriado.FrmFeriado_Load` (l. 575) → `llena_leriado` (l. 598) | Consulta todos los registros de feriados, los asigna a `GridControlFeriado.DataSource` y oculta la columna `"idFeriado"`. | `RRHH_FeriadoMapper.Instance().SelectAll()` → `SELECT * FROM public."RRHH_Feriado" ORDER BY "idFeriado"`. |
| **Alta de feriado** | `FrmFeriado.BtnAgregar_Click` (l. 548) | Verifica si la fecha ya fue registrada; si no existe, calcula `idFeriado = MAX + 1` en memoria, inserta, recarga la grilla y limpia controles. | 1) `RRHHClass.GetFeriado(string)` (`RRHHClass.cs` l. 835)<br>2) `RRHH_FeriadoMapper.Instance().SelectAll()` (2 veces)<br>3) `RRHH_FeriadoMapper.Instance().Insert(RRHH_Feriado)` |
| **Eliminación de feriado** | `FrmFeriado.btnEliminar_Click` (l. 581) | Valida que exista una fila enfocada (`FocusedRowHandle >= 0`), pide confirmación con la fecha y elimina por `idFeriado`. | `RRHH_FeriadoMapper.Instance().Delete(RRHH_Feriado)` → `DELETE FROM public."RRHH_Feriado" WHERE "idFeriado" = @idFeriado`. |

### 1.2. Distinción entre ejecutable original, adaptación `eeeb817` y refactor `TEC-003`

1. **Código recuperado original (`e725cd6`):** `FrmFeriado` utilizaba `RRHHClass.GetFeriado` con `SqlClient` (`spRRHH_GetFeriado`) y `RRHH_FeriadoMapper` generado para SQL Server.
2. **Adaptación de plataforma en `eeeb817`:** Sustituyó el interior de `RRHHClass` y `PostgreSqlLegacyMapper` para ejecutar consultas sobre PostgreSQL (`public."RRHH_Feriado"`), pero mantuvo intacto el código acoplado dentro de `FrmFeriado.cs`.
3. **Refactorización en `TEC-003` (`refactor/tec-003-feriados`):** Extrae el dominio (`Feriado`), los casos de uso (`ListarFeriados`, `RegistrarFeriado`, `EliminarFeriado`), el contrato `IFeriadoRepository`, el repositorio `PostgreSqlFeriadoRepository` y el presenter `FeriadoPresenter` (`IFeriadoView`), convirtiendo a `FrmFeriado` en vista pasiva conectada por `CompositionRoot.CrearFeriado()` y retirando `RRHHClass.GetFeriado` y `RRHH_FeriadoMapper`.

---

## 2. Diagnóstico sustentado del módulo (`Evidencia → Problema → Impacto → Recomendación`)

| ID Hallazgo | Evidencia (archivo / línea / BD) | Problema identificado | Impacto en mantenibilidad / operación | Recomendación implementada en `TEC-003` |
|---|---|---|---|---|
| **D-TEC-003-01** | `FrmFeriado.cs` l. 269, 548–601 | **Violación de SRP y acoplamiento a dos puentes heredados:** La vista instancia `RRHHClass` e invoca `RRHH_FeriadoMapper.Instance()` directamente. | Imposibilita probar reglas de negocio o flujos de presentación sin levantar WinForms/DevExpress y una base PostgreSQL activa; duplica rutas de acceso a la misma tabla. | Extraer `Feriado` (`RRHH.Domain`), casos de uso e `IFeriadoRepository` (`RRHH.Application`), `FeriadoPresenter` (`RRHH.Presentation`) y `PostgreSqlFeriadoRepository` (`RRHH.PostgreSql`). |
| **D-TEC-003-02** | `FrmFeriado.cs` l. 550 y `RRHHClass.cs` l. 835–842 | **Conversión innecesaria de `DateTime` a cadena regional:** Se pasa `UcDateTime1.Value.ToShortDateString()` y luego se re-parsea con `ParseDate(fecha).Date`. | Fragilidad ante diferencias de configuración regional (`dd/MM/yyyy` vs `MM/dd/yyyy`) y pérdida de tipado entre capas. | Pasar `DateTime` tipado de extremo a extremo, normalizar a `fecha.Date` en la entidad `Feriado` y usar `DbType.Date` en el parámetro SQL `@fecha`. |
| **D-TEC-003-03** | `FrmFeriado.cs` l. 559–569 y `EV-BD-001` (`public."RRHH_Feriado"` sin PK/UNIQUE) | **Cálculo de `MAX(idFeriado) + 1` en cliente con doble lectura completa y sin transacción:** Descarga toda la tabla dos veces fuera de transacción antes del `INSERT`. | Condición de carrera en altas simultáneas (pueden insertar el mismo día calendario o generar el mismo `idFeriado`) y tráfico innecesario de red/memoria. | Ejecutar la validación de existencia (`"Fecha"::date = @fecha`) y el `INSERT ... SELECT COALESCE(MAX("idFeriado"), 0) + 1 ... RETURNING "idFeriado"` dentro de `_database.InTransaction` con `LOCK TABLE public."RRHH_Feriado" IN SHARE ROW EXCLUSIVE MODE`. |
| **D-TEC-003-04** | `FrmFeriado.cs` l. 556–557, `BD/schema.sql` l. 694–698 y `EV-BD-001` | **Ausencia de validación de motivo y hora residual en `Fecha`:** Se insertaban motivos vacíos (`6` filas en BD activa) y horas no truncadas (`11:39:43`), sin validar el límite `varchar(200)`. | Datos inconsistentes en `public."RRHH_Feriado"` y riesgo de excepción SQL no controlada si el motivo supera 200 caracteres. | En `Feriado.Crear`, truncar `Fecha` a `.Date`, exigir motivo no vacío tras `.Trim()` y validar longitud $\le 200$; en `Feriado.Reconstituir`, permitir lectura de filas históricas sin error. |
| **D-TEC-003-05** | `FrmConsultaAsistencias.cs` l. 742–762, 862–895 y `PostgreSqlLegacyContext.cs` l. 82 | **Los feriados de `RRHH_Feriado` no se descuentan en el reporte general de asistencias (`RF-17`):** Solo se cuentan sábados y domingos (`num`) en memoria y `spRRHH_GetReporteAsistencia` es un stub que devuelve `0`. | Los feriados en días de semana figuran como inasistencia o no se suman a días asistidos en el reporte general. | Documentado como causa raíz de **RF-17**. `TEC-003` deja listo el contrato `IFeriadoRepository` y los datos normalizados en `public."RRHH_Feriado"` para que el paquete de `RF-17` consuma los feriados del rango. |

---

## 3. Coordinación de diagramas y flujos funcionales para `T2-04`

Conforme al [plan de equipo](../../PLAN_EQUIPO.md) y [prompts por integrante](../../PROMPTS_POR_INTEGRANTE.md), se enlazan los diagramas producidos en esta rama y los puntos de integración con los demás paquetes del equipo:

| Bloque de diagramas (`T2-04`) | Responsable | Estado y ruta en el repositorio |
|---|---|---|
| **Flujo de feriados (antes/después y capas)** | Frank Piero Mantilla Arqueros (`TEC-003`) | **Completado en esta rama:** [`docs/t2/diagramas/TEC-003/flujo-feriados-antes-despues.md`](../../diagramas/TEC-003/flujo-feriados-antes-despues.md) |
| **Flujo de registro/importación y consulta de asistencia** | Frank Piero Mantilla Arqueros (`TEC-003`) | **Completado en esta rama:** [`docs/t2/diagramas/TEC-003/flujo-asistencia.md`](../../diagramas/TEC-003/flujo-asistencia.md) |
| **Flujo de generación y exportación de reportes** | Frank Piero Mantilla Arqueros (`TEC-003`) | **Completado en esta rama:** [`docs/t2/diagramas/TEC-003/flujo-reportes.md`](../../diagramas/TEC-003/flujo-reportes.md) |
| **Mapa general del sistema, módulos, arquitectura y flujo de horarios** | Jorge Enrique Cano Asto (`TEC-001`) | Pendiente de integración desde la rama `refactor/tec-001-horarios` (`docs/t2/diagramas/TEC-001/`). |
| **Diagrama Entidad-Relación (ER) y despliegue de BD** | Francisco Kadin Valera Lizarraga (`TEC-002`) | Pendiente de integración desde la rama `infra/tec-002-integridad-bd` (`docs/t2/diagramas/TEC-002/`). |
| **Flujo de motivos antes/después, permisos, licencias y vacaciones** | Evelyn Victoria Rodriguez Cardozo (`TEC-004`) | Pendiente de integración desde la rama `refactor/tec-004-motivos-permiso` (`docs/t2/diagramas/TEC-004/`). |

---

## 4. Síntesis para la exposición de 20 minutos (Bloque de Frank — `TEC-003`)

1. **Problema y evidencia anterior (`eeeb817`):** `FrmFeriado.cs` validaba fechas duplicadas convirtiendo `DateTime` a texto regional (`ToShortDateString()`) hacia `RRHHClass.GetFeriado`, y luego descargaba toda la tabla dos veces con `RRHH_FeriadoMapper.Instance().SelectAll()` para calcular `MAX(idFeriado) + 1` en memoria sin transacción ni validación de longitud/vacío del motivo.
2. **Cambio realizado:** Se extrajo la entidad `Feriado` (`RRHH.Domain`), los casos `ListarFeriados`, `RegistrarFeriado` y `EliminarFeriado` más el contrato `IFeriadoRepository` (`RRHH.Application`), el repositorio transaccional `PostgreSqlFeriadoRepository` (`RRHH.PostgreSql`) y el coordinador `FeriadoPresenter` con `IFeriadoView` (`RRHH.Presentation`). `FrmFeriado` quedó como vista pasiva ensamblada en `CompositionRoot.CrearFeriado()`.
3. **Principios y patrones:** Patrones **MVP (Vista Pasiva)** y **Repository**; principios **SRP** (separar UI, validación, coordinación y SQL), **DIP** (casos de uso dependen de `IFeriadoRepository`), **IoC** (inyección por constructor en `CompositionRoot`) y **DRY** (un único punto de acceso a `RRHH_Feriado`, retirando `RRHHClass.GetFeriado` y `RRHH_FeriadoMapper`).
4. **Tipo de mantenimiento:** **Preventivo** como categoría principal por reestructuración en capas y control transaccional de concurrencia (`LOCK TABLE`), con validación preventiva/correctiva acotada en el alta de motivos vacíos/largos y normalización de fechas a `.Date`.
5. **Pruebas y límite pendiente:** Cubierto por pruebas unitarias de dominio, caso de uso, presenter, arquitectura y verificación de esquema (`BD/schema.sql`), más comprobación de conexión y tabla en PostgreSQL. Queda pendiente como tarea separada (`RF-17`) que `FrmConsultaAsistencias` consuma `IFeriadoRepository` para descontar feriados en el reporte general.
