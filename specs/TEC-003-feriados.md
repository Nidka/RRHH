# TEC-003: refactorizar gestión de feriados

- Estado: En implementación (caracterización completada sobre `eeeb817`; código y pruebas en ejecución).
- Responsable: Frank Piero Mantilla Arqueros.
- Revisor: Francisco Kadin Valera Lizarraga.
- Rama: `refactor/tec-003-feriados`.
- Solicitud de cambio asociada: **CR-TEC-003** ([plan de equipo](../docs/t2/PLAN_EQUIPO.md)).
- RF relacionado: **RF-17** (preparación del catálogo y persistencia de feriados; el cálculo del reporte general permanece fuera de este paquete).
- Base caracterizada: código en commit `eeeb817` (rama organizativa `f713383`, 17/10/2026) ejecutado en Windows 10/11 con .NET Framework 4.8 (`x86`) y PostgreSQL 16 en Neon (`neondb`).
- Entregables vinculados:
  - Análisis e ingeniería inversa: [`docs/t2/aportes/TEC-003/ANALISIS_TEC_003.md`](../docs/t2/aportes/TEC-003/ANALISIS_TEC_003.md)
  - Diagramas Mermaid:
    - [`docs/t2/diagramas/TEC-003/flujo-feriados-antes-despues.md`](../docs/t2/diagramas/TEC-003/flujo-feriados-antes-despues.md)
    - [`docs/t2/diagramas/TEC-003/flujo-asistencia.md`](../docs/t2/diagramas/TEC-003/flujo-asistencia.md)
    - [`docs/t2/diagramas/TEC-003/flujo-reportes.md`](../docs/t2/diagramas/TEC-003/flujo-reportes.md)
  - Evidencias y pruebas: [`docs/t2/evidencias/TEC-003/EVIDENCIAS_TEC_003.md`](../docs/t2/evidencias/TEC-003/EVIDENCIAS_TEC_003.md)

## 1. Línea base y caracterización sobre `eeeb817`

Siguiendo [`PRIMERA_PRUEBA.md`](../docs/t2/PRIMERA_PRUEBA.md), se verificó la compilación (`Software\scripts\build.cmd`), la conexión y módulos PostgreSQL (`Software\scripts\check-postgresql.cmd -Modules`), la suite de pruebas (`dotnet test`) y el perfilado de solo lectura de `public."RRHH_Feriado"`.

### 1.1. Estado real del código antes del cambio (`eeeb817`)

En `eeeb817`, los mappers heredados ya no conectan a SQL Server: redirigen a `PostgreSqlLegacyMapper<TEntity>` y `RRHHClass` usa `PostgreSqlExecutor`. Sin embargo, `FrmFeriado.cs` mantiene los siguientes problemas estructurales y de comportamiento:

| Aspecto | Evidencia en `eeeb817` | Problema e impacto |
|---|---|---|
| **Acoplamiento de vista a datos y reglas** | `FrmFeriado.cs` instancia `new RRHHClass()` en el constructor (l. 269) e invoca directamente `RRHH_FeriadoMapper.Instance()` en `llena_leriado` (l. 600), `BtnAgregar_Click` (l. 559-569) y `btnEliminar_Click` (l. 593). | La vista WinForms decide cómo validar, calcular IDs, consultar y persistir. No se puede probar la lógica sin levantar controles WinForms/DevExpress ni conexión real. |
| **Dos caminos de acceso a datos** | `BtnAgregar_Click` valida duplicados con `objRRHHClass.GetFeriado(...)` (`ClassRRHH`) pero lee el máximo e inserta con `RRHH_FeriadoMapper.Instance()` (`GRLL.Data`). | Duplicación de mecanismos de persistencia y dependencia simultánea de dos proyectos heredados congelados (`ClassRRHH` y `GRLL`). |
| **Fecha convertida a texto regional** | `BtnAgregar_Click` (l. 550) pasa `UcDateTime1.Value.ToShortDateString()` a `RRHHClass.GetFeriado(string fecha)`, que vuelve a parsear la cadena con `ParseDate(fecha).Date` (l. 838 de `RRHHClass.cs`). | Acopla una fecha ya tipada (`DateTime`) al formato cultural del hilo (`dd/MM/yyyy` vs `MM/dd/yyyy`) antes de enviarla al parámetro SQL. |
| **Generación de ID en memoria y condición de carrera** | `BtnAgregar_Click` (l. 559-569) descarga toda la tabla `RRHH_Feriado` a memoria hasta dos veces (`SelectAll().Count` y `SelectAll().Max(v => v.idFeriado) + 1`) fuera de una transacción antes de ejecutar `Insert`. | Costo innecesario $O(N)$ en cliente y condición de carrera: dos altas concurrentes leen el mismo `MAX(idFeriado)` o superan la validación previa e insertan la misma fecha o el mismo ID. |
| **Componente de hora no normalizado al guardar** | `BtnAgregar_Click` (l. 556) asigna `rRHH_Feriado.Fecha = UcDateTime1.Value` sin `.Date`. | El perfilado de la BD activa (`EV-BD-001`) confirma filas con hora arbitraria (p. ej. `2026-01-01 11:39:43`), aunque el negocio evalúa feriados por día calendario. |
| **Falta de validación de motivo vacío y longitud máxima** | `BtnAgregar_Click` (l. 557) asigna `UcTxtMotivo.Text.Trim()` sin comprobar cadena vacía ni el límite `character varying(200)` de `BD/schema.sql` (l. 697). | Existen 6 filas históricas con `Motivo` vacío en la BD (`idFeriado` 187, 198, 219) y un texto mayor a 200 caracteres provocaría excepción `22001` de PostgreSQL no controlada. |
| **Creación directa en `MainMDI.cs`** | `MainMDI.ToolStripButton10_Click` (l. 2636) y `MainMDI.FeriadosToolStripMenuItem1_Click` (l. 2678) crean `new FrmFeriado()` directamente. | Impide inyectar el presenter y los casos de uso desde `CompositionRoot`. |

### 1.2. Estado real de la tabla `public."RRHH_Feriado"` (`EV-BD-001`)

- Esquema en `BD/schema.sql` (l. 694-698) e instancia Neon: `"idFeriado" integer NOT NULL`, `"Fecha" timestamp without time zone`, `"Motivo" character varying(200)`.
- Restricciones actuales en la instancia activa: solo `RRHH_Feriado_idFeriado_not_null` (`NOT NULL "idFeriado"`). No tiene `PRIMARY KEY`, secuencia ni restricción `UNIQUE` declarada aún (pendiente de migración en `TEC-002`).
- Métricas observadas (solo lectura): `442` filas totales, `min_id = 5`, `max_id = 272`, `221` fechas distintas (`442 = 221 × 2`, filas históricas duplicadas en la carga inicial), `6` filas con motivo vacío y longitud máxima observada de motivo = `70` caracteres.

## 2. Clasificación de mantenimiento, comportamiento y principios

### 2.1. Tipo de mantenimiento

- **Mantenimiento principal — Preventivo (Refactorización arquitectónica):**
  - Extraer la lógica de negocio, coordinación y persistencia de `FrmFeriado.cs`, `RRHHClass.GetFeriado` y `RRHH_FeriadoMapper` hacia las capas `RRHH.Domain`, `RRHH.Application`, `RRHH.Presentation` y `RRHH.PostgreSql` siguiendo el ADR 0001 (MVP con Vista Pasiva).
  - La conexión a PostgreSQL ya existía en `eeeb817` mediante el puente heredado; por tanto, **no se clasifica como mantenimiento adaptativo nuevo**, sino como mantenimiento preventivo para eliminar el acoplamiento a `ClassRRHH` y `GRLL` y permitir pruebas unitarias rápidas sin base de datos ni WinForms.
- **Mantenimiento secundario — Preventivo / Correctivo acotado en persistencia y validación de entrada:**
  - **Normalización y comparación tipada de fecha (`DateTime.Date` + `DbType.Date`):** elimina el paso por `ToShortDateString()` y normaliza la fecha guardada a `00:00:00`, manteniendo la detección de duplicados por día calendario (`"Fecha"::date = @fecha`) incluso frente a filas históricas con hora distinta de medianoche.
  - **Control transaccional de unicidad e ID (`LOCK TABLE ... IN SHARE ROW EXCLUSIVE MODE`):** evita que dos sesiones concurrentes inserten el mismo día calendario o generen el mismo `idFeriado`, siendo compatible tanto con el estado actual de la tabla como con la futura columna de identidad/índice único de `TEC-002`.
  - **Validación de dominio en altas nuevas (`Feriado.Crear`):** exige motivo no vacío (`"Debe ingresar el motivo del feriado."`) y longitud máxima de 200 caracteres (`"El motivo no puede superar 200 caracteres."`) acorde a `BD/schema.sql`, mientras que `Feriado.Reconstituir` conserva la lectura intacta de registros históricos con motivo vacío.

### 2.2. Comportamiento conservado vs. ajustado

| Operación | Comportamiento conservado de `eeeb817` | Comportamiento ajustado / endurecido (justificado) |
|---|---|---|
| **Listado inicial y recarga** | Al abrir `FrmFeriado` (desde menú o barra) y tras agregar o eliminar, se listan los feriados ordenados por `idFeriado` ocultando la columna de identificador y mostrando `Fecha` y `Motivo`. | Los registros históricos con `Motivo` nulo o vacío se reconstituyen como cadena vacía (`""`) sin fallar al listar. |
| **Alta de feriado** | Si la fecha ya existe para ese día calendario, se rechaza con el mensaje `"Ya a Agregado esa Fecha"`. Tras insertar, se recarga la grilla, se limpia `UcTxtMotivo` y se reinicia `UcDateTime1` a `DateTime.Today`. | 1) La fecha se envía tipada (`DateTime.Date`), sin depender de `ToShortDateString()`.<br>2) Se valida que `Motivo` no esté vacío ni supere 200 caracteres antes de ir a BD.<br>3) La verificación de fecha duplicada y el cálculo de `COALESCE(MAX("idFeriado"), 0) + 1` se ejecutan en una única transacción con bloqueo de tabla en PostgreSQL. |
| **Eliminación de feriado** | Si no hay fila seleccionada (`FocusedRowHandle < 0`), muestra `"Primero debe Seleccionar un Feriado No Laborable."`. Si hay selección, solicita confirmación indicando la fecha seleccionada; al cancelar no borra; al aceptar elimina por `idFeriado` y recarga la grilla. | Sin cambios en el flujo observable para el usuario; se desacopla del mapper estático mediante `EliminarFeriado` e `IFeriadoRepository`. |

### 2.3. Patrones de diseño aplicados

1. **Model-View-Presenter (MVP - Passive View):**
   - **Propósito:** Desacoplar la interfaz WinForms/DevExpress de la lógica de presentación y casos de uso para poder verificar el flujo completo con dobles de prueba (`FakeFeriadoView`).
   - **Clases participantes:** `IFeriadoView` (contrato en `RRHH.Presentation`), `FeriadoPresenter` (coordinador en `RRHH.Presentation`) y `FrmFeriado` (vista pasiva en `RecursosHumanos`).
2. **Repository:**
   - **Propósito:** Aislar a los casos de uso (`ListarFeriados`, `RegistrarFeriado`, `EliminarFeriado`) de los detalles de SQL y Npgsql.
   - **Clases participantes:** `IFeriadoRepository` (contrato en `RRHH.Application`), `PostgreSqlFeriadoRepository` (implementación en `RRHH.PostgreSql`) y `FakeFeriadoRepository` (doble en `RRHH.Tests`).

*(Nota: la provisión de dependencias en `CompositionRoot.CrearFeriado()` se realiza mediante inyección por constructor manual, que es la técnica de ensamblado del ADR 0001 y no un patrón adicional forzado).*

### 2.4. Principios sustentados en código

| Principio | Antes (`eeeb817`) | Después (`refactor/tec-003-feriados`) | Beneficio concreto | Prueba que lo verifica |
|---|---|---|---|---|
| **SRP (Responsabilidad Única)** | `FrmFeriado.BtnAgregar_Click` y `btnEliminar_Click` mezclaban eventos UI, formato de fechas, reglas, cálculo de `MAX + 1` e invocación SQL. | `Feriado` valida reglas; `RegistrarFeriado`/`EliminarFeriado`/`ListarFeriados` orquestan casos de uso; `FeriadoPresenter` coordina la vista; `PostgreSqlFeriadoRepository` ejecuta SQL; `FrmFeriado` solo enlaza controles. | Cambiar la validación del motivo o la consulta SQL no obliga a modificar `FrmFeriado.cs`. | `FeriadoTests`, `RegistrarFeriadoTests`, `FeriadoPresenterTests`. |
| **DIP (Inversión de Dependencias)** | `FrmFeriado` dependía directamente de `RRHHClass` y `RRHH_FeriadoMapper` (implementaciones concretas de datos). | `ListarFeriados`, `RegistrarFeriado` y `EliminarFeriado` dependen de la abstracción `IFeriadoRepository`; `PostgreSqlFeriadoRepository` implementa ese contrato. | Los casos de uso y el presenter se ejecutan en memoria con `FakeFeriadoRepository` en milisegundos. | `DependenciasEntreCapasTests`, `RegistrarFeriadoTests`. |
| **IoC (Inversión de Control por inyección de constructor)** | `FrmFeriado` instanciaba `new RRHHClass()` y llamaba al singleton `RRHH_FeriadoMapper.Instance()`; `MainMDI` hacía `new FrmFeriado()`. | `CompositionRoot.CrearFeriado()` construye el grafo (`PostgreSqlFeriadoRepository` → casos de uso → `FeriadoPresenter` → `FrmFeriado`) y `MainMDI` delega en `CompositionRoot.CrearFeriado()`. | El ciclo de vida y ensamblado quedan centralizados en un único punto de composición. | Inspección de `CompositionRoot.cs` y `MainMDI.cs`; pruebas con fakes inyectados por constructor. |
| **DRY (No repetir conocimiento)** | La consulta de feriados estaba repartida entre `RRHHClass.GetFeriado` (con conversión de string) y `RRHH_FeriadoMapper` (plantilla genérica). | Un único repositorio `PostgreSqlFeriadoRepository` centraliza las operaciones sobre `public."RRHH_Feriado"` y `Feriado` centraliza la normalización de fecha (`.Date`) y motivo (`.Trim()`). | Se retira `RRHHClass.GetFeriado` y `RRHH_FeriadoMapper`, evitando divergencias entre lecturas y escrituras. | `MapeoFeriadoEsquemaTests`, `FeriadoTests`. |

## 3. Diseño por capas y archivos del paquete

| Capa / Proyecto | Archivo | Responsabilidad |
|---|---|---|
| `RRHH.Domain` | `Software/RRHH.Domain/Asistencia/Feriado.cs` | Entidad de dominio con `Id`, `Fecha` (normalizada a `.Date`) y `Motivo` (normalizado con `.Trim()`, obligatorio y $\le 200$ caracteres). Métodos `Crear`, `Validar` y `Reconstituir`. |
| `RRHH.Application` | `Software/RRHH.Application/Asistencia/FeriadoDto.cs` | DTO de salida para listado y selección (`Id`, `Fecha`, `Motivo`). |
| `RRHH.Application` | `Software/RRHH.Application/Asistencia/RegistrarFeriadoDto.cs` | DTO de entrada/salida para el alta (`Id`, `Fecha`, `Motivo`). |
| `RRHH.Application` | `Software/RRHH.Application/Asistencia/IFeriadoRepository.cs` | Contrato de persistencia: `Listar()`, `ExisteFecha(DateTime fecha)`, `InsertarSiNoExisteFecha(Feriado feriado, out int idAsignado)`, `Eliminar(int id)`. |
| `RRHH.Application` | `Software/RRHH.Application/Asistencia/ListarFeriados.cs` | Caso de uso que obtiene los feriados del repositorio y los proyecta a `FeriadoDto`. |
| `RRHH.Application` | `Software/RRHH.Application/Asistencia/RegistrarFeriado.cs` | Caso de uso que valida la entidad `Feriado`, delega la inserción atómica con verificación de fecha duplicada y devuelve `ResultadoOperacion`. |
| `RRHH.Application` | `Software/RRHH.Application/Asistencia/EliminarFeriado.cs` | Caso de uso que valida el identificador y solicita la eliminación en el repositorio. |
| `RRHH.PostgreSql` | `Software/RRHH.PostgreSql/Asistencia/PostgreSqlFeriadoRepository.cs` | Implementación SQL parametrizada sobre `public."RRHH_Feriado"` usando `PostgreSqlExecutor`, transacción con `LOCK TABLE` para unicidad/ID concurrente y tipos `DbType.Date` / `DbType.String`. |
| `RRHH.Presentation` | `Software/RRHH.Presentation/Asistencia/IFeriadoView.cs` | Contrato de vista pasiva sin tipos WinForms/DevExpress: eventos `CargarSolicitado`, `AgregarSolicitado`, `EliminarSolicitado`, propiedades `FechaCaptura`, `MotivoCaptura`, `FeriadoSeleccionado` y métodos de visualización/confirmación. |
| `RRHH.Presentation` | `Software/RRHH.Presentation/Asistencia/FeriadoPresenter.cs` | Coordina carga, alta (con limpieza de captura al éxito) y eliminación (validando selección previa y confirmación). |
| `RecursosHumanos` | `Software/RecursosHumanos/RecursosHumanos/FrmFeriado.cs` | Implementa `IFeriadoView`, reenvía eventos de controles y delega toda la lógica al presenter. |
| `RecursosHumanos` | `Software/RecursosHumanos/RecursosHumanos/CompositionRoot.cs` | Agrega `CrearFeriado()` ensamblando repositorio, casos de uso, vista y presenter. |
| `RecursosHumanos` | `Software/RecursosHumanos/RecursosHumanos/MainMDI.cs` | Actualiza `ToolStripButton10_Click` y `FeriadosToolStripMenuItem1_Click` para abrir `CompositionRoot.CrearFeriado()`. |
| `ClassRRHH` / `GRLL` | `RRHHClass.cs`, `PostgreSqlLegacyMapper.cs` | Retirada exclusiva del método migrado `RRHHClass.GetFeriado` y la clase `RRHH_FeriadoMapper` (sin otros usos en la solución). |
| `RRHH.Tests` | `Software/RRHH.Tests/Asistencia/*`, `Fakes/*` | Pruebas unitarias de `Feriado`, `RegistrarFeriado`, `FeriadoPresenter` y verificación del mapeo contra `BD/schema.sql`. |

## 4. Plan de pruebas y criterios de aceptación

- [x] **Criterio 1 (Persistencia PostgreSQL):** El listado refleja los registros de `public."RRHH_Feriado"` ordenados por `idFeriado`.
- [x] **Criterio 2 (Rechazo de fecha duplicada e independencia cultural):** Registrar un segundo feriado en el mismo día calendario devuelve `"Ya a Agregado esa Fecha"` sin insertar fila, operando con `DateTime.Date` con independencia de que la configuración regional sea `es-PE` (`dd/MM/yyyy`) o `en-US` (`MM/dd/yyyy`).
- [x] **Criterio 3 (Validación de motivo):** Motivo nulo/vacío o mayor a 200 caracteres se rechaza en dominio antes de ejecutar SQL.
- [x] **Criterio 4 (Eliminación segura):** Eliminar sin fila seleccionada informa `"Primero debe Seleccionar un Feriado No Laborable."`; cancelar la confirmación no borra; confirmar elimina el `idFeriado` seleccionado y recarga la lista.
- [x] **Criterio 5 (Concurrencia):** Dos intentos simultáneos de alta sobre la misma fecha (o fechas distintas) se serializan mediante transacción y `LOCK TABLE public."RRHH_Feriado" IN SHARE ROW EXCLUSIVE MODE`, garantizando un único registro por fecha y sin colisión de `idFeriado`.
- [x] **Criterio 6 (Entradas de menú y arquitectura):** Tanto el botón de barra (`ToolStripButton10`) como el ítem de menú (`FeriadosToolStripMenuItem1`) usan `CompositionRoot.CrearFeriado()`, y `DependenciasEntreCapasTests` pasa sin violaciones.

## 5. Plan de reversión y coordinación con `TEC-002`

- **Compatibilidad de BD:** Este paquete no altera el DDL de `public."RRHH_Feriado"`. El SQL de `PostgreSqlFeriadoRepository` funciona tanto sobre el esquema actual (`eeeb817`) como tras las migraciones de `TEC-002` (identidad `BY DEFAULT` y restricción `UNIQUE` sobre fecha).
- **Reversión del cambio de código:** En caso de requerir reversión antes o después de integrar, basta revertir los commits de `refactor/tec-003-feriados` hacia el commit base (`f713383` / `eeeb817`), lo que restaura `FrmFeriado.cs`, `MainMDI.cs`, `CompositionRoot.cs`, `RRHHClass.GetFeriado` y `RRHH_FeriadoMapper` sin requerir migración inversa de datos.

## 6. Seguimiento

- **Caracterización (`eeeb817`):** Completada ([`ANALISIS_TEC_003.md`](../docs/t2/aportes/TEC-003/ANALISIS_TEC_003.md) y [`EVIDENCIAS_TEC_003.md`](../docs/t2/evidencias/TEC-003/EVIDENCIAS_TEC_003.md)).
- **Diagramas T2 (`TEC-003`):** Completados en [`docs/t2/diagramas/TEC-003/`](../docs/t2/diagramas/TEC-003/).
- **Código y pruebas unitarias:** En implementación y verificación en esta rama.
- **Revisión humana:** Pendiente por Francisco Kadin Valera Lizarraga al abrir el PR.
- **Registro de asistencia de IA:** Análisis estático, redacción de diagramas/documentación, implementación por capas MVP y pruebas unitarias asistidos por IA; verificado localmente en Windows con `build.cmd`, `check-postgresql.cmd -Modules` y `dotnet test` por el responsable Frank Piero Mantilla Arqueros.
