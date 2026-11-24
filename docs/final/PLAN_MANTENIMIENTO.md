# Plan de mantenimiento del sistema RRHH

Documento consolidado para la evaluación final. Reúne en un solo lugar el plan que estaba repartido entre [ANALISIS_Y_PREPARACION_T2.md](../t2/ANALISIS_Y_PREPARACION_T2.md), [PLAN_EQUIPO.md](../t2/PLAN_EQUIPO.md) y [CHECKLIST_T3.md](../t3/CHECKLIST_T3.md), y lo contrasta con lo ejecutado según el historial de Git. Corte: `main` en `d4c8b32` (23/11/2026).

## 1. Objetivo

Evolucionar el sistema heredado de gestión de asistencias (WinForms, .NET Framework, SQL Server 2008 R2) para atender los 18 requerimientos del área usuaria, sin romper el comportamiento que ya funcionaba. Para lograrlo, el trabajo:
- reduce la deuda técnica que impedía cambiarlo con seguridad (lógica en eventos de botón, SQL incrustado, código duplicado, ausencia de pruebas);
- deja trazabilidad entre requerimiento, solicitud de cambio, implementación, commit, prueba y evidencia;
- publica versiones identificables.

## 2. Alcance

**Incluido:**
- Recuperación del código desde los ensamblados originales.
- Migración del acceso a datos a PostgreSQL con SQL parametrizado.
- Arquitectura por capas con MVP de vista pasiva: [ARQUITECTURA.md](../../Software/docs/ARQUITECTURA.md) y [ADR 0001](../../Software/docs/adr/0001-mvp-sobre-capas.md).
- Los 18 RF en escritorio (WinForms) y en una versión web que reutiliza los mismos casos de uso ([ADR 0002](../../Software/docs/adr/0002-web-y-pwa.md)).
- Pruebas automatizadas, control de cambios (CR-001 a CR-019), versionado semántico y despliegue de la web.

**Excluido o pendiente**, con su motivo:
- **Migración total de los formularios heredados:** solo se migran los casos de uso que tocan los RF; los proyectos heredados quedan congelados (regla 5 de la arquitectura).
- **Interpretación legal de vacaciones y licencias:** se usa un régimen académico parametrizable (`RegimenVacacionesPiloto`, 30 días por defecto). La «licencia una vez por año» se activa por motivo, sin asumir una ley concreta.
- **Menú por módulos en escritorio (parte de CR-019):** requiere Windows para compilar y probar.

## 3. Requerimientos priorizados

Prioridad: P1 = primero (base o defecto), P2 = después de las bases, P3 = requiere cálculo y acceso previos. La prioridad y el tipo vienen del análisis de T2; la versión, del [CHANGELOG](../../CHANGELOG.md). El detalle por CR está en la [matriz de control de cambios](../t2/CONTROL_CAMBIOS.csv).

| Módulo | RF | Solicitud | Tipo | Prioridad | Versión |
|---|---|---|---|---|---|
| A. Turnos | RF-01 | Turnos por periodo de fechas | Adaptativo | P1 | 1.4.0 |
| | RF-02 | Histórico de turnos | Perfectivo | P2 | 1.4.0 |
| B. Permisos y licencias | RF-03 | Sin dos permisos el mismo día | Correctivo | P1 | 1.0.2 · 1.6.0 |
| | RF-04 | Agregar motivos de permiso | Preventivo | P1 | TEC-004 (1.0.0) |
| | RF-05 | Eliminar motivos de permiso | Preventivo | P1 | TEC-004 (1.0.0) |
| | RF-06 | Licencia que se otorga una vez al año | Adaptativo | P1 | 1.1.0 · 1.6.0 |
| C. Vacaciones | RF-07 | Vacaciones generadas | Perfectivo | P1 | 1.6.0 |
| | RF-08 | Vacaciones pendientes de goce | Perfectivo | P2 | 1.6.0 |
| | RF-09 | Vacaciones truncas | Perfectivo | P2 | 1.6.0 |
| | RF-10 | Consumo desde media jornada | Adaptativo | P1 | 1.6.0 |
| | RF-11 | Reporte de vacaciones | Perfectivo | P2 | 1.6.0 |
| | RF-12 | Autoconsulta del usuario final | Perfectivo | P3 | 1.6.0 |
| D. Teletrabajo y presencialidad | RF-13 | Registrar periodos de teletrabajo | Adaptativo | P1 | 1.3.0 |
| | RF-14 | Reporte de días de teletrabajo | Perfectivo | P2 | 1.3.0 |
| | RF-15 | Presencialidad y teletrabajo por persona | Perfectivo | P2 | 1.6.0 |
| | RF-16 | Teletrabajo total o parcial | Perfectivo | P2 | 1.5.0 |
| E. Reportes generales | RF-17 | Feriados sumados en el reporte general | Correctivo | P1 | 1.0.3 · 1.6.0 |
| | RF-18 | Personas ausentes por motivo y periodo | Perfectivo | P2 | 1.2.0 · 1.6.0 |
| Transversal | CR-019 | Navegación por módulos y diseño de la web | Perfectivo | P1 | 1.7.0 (propuesta) |

**Orden aplicado:**
1. Bases: TEC-001 a TEC-004 y la base compartida `RangoFechas`/`CalendarioLaboral` (PR #18).
2. Defectos y reglas P1: RF-03, RF-06, RF-17.
3. Turnos y teletrabajo.
4. Vacaciones, que dependen del cálculo de saldo.
5. Autoconsulta, que depende de la identidad del usuario.

## 4. Tipos de mantenimiento aplicados

| Tipo | Dónde se aplicó | Ejemplo concreto |
|---|---|---|
| **Correctivo** | RF-03, RF-17, RF-18 (anulados), TEC-002 | `RRHHClass.ExistePermiso` no detectaba un permiso nuevo que contenía al existente (D-02). Se reemplazó por `ValidarPermisoSinSolapamiento`, que usa `RangoFechas.Solapa` (PR #19). |
| **Adaptativo** | Plataforma SQL Server → PostgreSQL; RF-01, RF-06, RF-10, RF-13; web y despliegue (TEC-005) | Repositorios PostgreSQL con SQL parametrizado; migraciones `BD/migrations/` (`Teletrabajo`, `UnaVezPorAnio`, vacaciones del piloto). |
| **Perfectivo** | RF-02, RF-07 a RF-09, RF-11, RF-12, RF-14 a RF-16, CR-019 | Reportes nuevos, autoconsulta, navegación por módulos y búsqueda de empleados por nombre. |
| **Preventivo** | TEC-001, TEC-003, TEC-004, REF-001 a REF-005, pruebas automatizadas | Catálogos, feriados, motivos y horarios pasaron de eventos de formulario a capas con pruebas. Se ejecutan 427 pruebas sin abrir la aplicación. |

## 5. Riesgos técnicos

| Riesgo | Impacto | Mitigación aplicada | Estado al 23/11/2026 |
|---|---|---|---|
| Diferencias entre el ejecutable original y la reconstrucción | Corregir un defecto que no existía en el original | Hipótesis registradas como tales en las specs y casos etiquetados por origen | Abierto: el recorrido comparativo del original no está completo |
| Validar en un motor y escribir en otro (D-01) | Resultados incoherentes | Un solo motor por caso de uso migrado; regla escrita en AGENTS.md | Mitigado en los flujos migrados |
| Códigos `MAX+1` con escritores concurrentes (D-09) | Duplicados | Transacciones con bloqueo e identidad (TEC-002); pruebas concurrentes de RF-10 y RF-13 | Mitigado en los flujos migrados |
| Esquema sin PK/FK declaradas (D-04) | Datos inconsistentes | Diagnóstico de duplicados y migraciones verificadas (TEC-002) | Parcial: se resolvió en las tablas tocadas |
| Reglas de vacaciones y licencias sin confirmar con el área usuaria | Cálculos discutibles | Régimen parametrizable, marcas explícitas por motivo y casos con datos ficticios | Abierto: requiere validación del área usuaria |
| Dependencias licenciadas (DevExpress 11.2, GRLL) solo en Windows | No se compila ni prueba el escritorio fuera de Windows | Capas sin WinForms, probadas en net8; QA de escritorio en Windows | Abierto para la parte de escritorio de CR-019 |
| Revisión cruzada insuficiente | Defectos sin detectar | PR por tarea y pruebas automatizadas | Materializado: solo los PR #20 y #21 tienen aprobación formal (ver la matriz) |
| Despliegue manual de la web | La versión publicada queda atrás de `main` | Lista de despliegue y prueba de humo en `deploy/` | Abierto: `autoDeploy: false` en `render.yaml` |
| Datos personales en evidencias | Exposición de información | Solo datos ficticios en pruebas, capturas y demo; `.env` fuera de Git | Controlado |

## 6. Estrategia de refactorización

- **Migración por caso de uso completo, no por archivo.** Cada caso pasa de un formulario con mapper o SQL a vista pasiva, presenter, caso de uso, repositorio PostgreSQL y `CompositionRoot`. No se valida en un motor y se escribe en otro dentro del mismo flujo.
- **Caracterizar antes de cambiar.** Primero se registra el comportamiento actual en la spec del CR o TEC y se escriben las pruebas; luego se refactoriza. En CR-019 se compararon 67 y 77 respuestas de la API antes y después.
- **Comportamiento conservado separado de la corrección.** Cada spec separa lo que se conserva de lo que se corrige, por ejemplo el mensaje «Ya a Agregado esa Fecha» en feriados.
- **Proyectos heredados congelados.** No reciben código nuevo y solo se modifican para retirar lo migrado.
- **Refactorizaciones documentadas.** Cinco, en [docs/t3/refactorizaciones](../t3/refactorizaciones/README.md):
  - REF-001: catálogos genéricos (DRY, Abierto/Cerrado).
  - REF-002: feriados por capas (Responsabilidad única).
  - REF-003: motivos (Responsabilidad única, Inversión de dependencias).
  - REF-004: horarios (Separación de capas).
  - REF-005: navegación por módulos (Abierto/Cerrado, DRY).

## 7. Estrategia de pruebas

| Nivel | Qué comprueba | Herramienta | Resultado actual |
|---|---|---|---|
| Unitarias | Reglas de dominio y casos de uso con repositorios falsos | xUnit (`Software/RRHH.Tests`) | Parte de 427/427 |
| Integración | Repositorios contra PostgreSQL local desechable, incluida la concurrencia | xUnit + `RRHH_TEST_POSTGRES_CONNECTION` | Parte de 427/427 ([ejecución](../t3/evidencias/SUITE/ejecucion-net8-c79949b.txt)) |
| Arquitectura | Que Domain, Application y Presentation no dependan de WinForms, Npgsql ni de los proyectos heredados | `DependenciasEntreCapasTests` | Superadas |
| Caracterización de la API | Que una refactorización no cambie las respuestas | [caracterizar.sh](../../qa/evidencias/cr-019/caracterizar.sh) | 73/77 idénticas; solo difiere la ruta nueva |
| Extremo a extremo web | Pantallas, reglas, roles y celular en Chrome | [recorrido-web.mjs](../../qa/evidencias/cr-019/recorrido-web.mjs) | 61/61 |
| Humo | Salud, base de datos, PWA, rechazo sin sesión y flujo de teletrabajo | `deploy/smoke.sh` | Correcta en local y en producción (9/9, solo salud) |
| QA manual de escritorio | Recorrido visual en WinForms | Capturas en `qa/evidencias/20261120-winforms/` y `qa/evidencias/20261119-final/` | Realizado por Jorge el 19 y 20/11 con datos ficticios |

**Reglas comunes:**
- Solo datos ficticios.
- Cada caso registra datos, resultado esperado, resultado obtenido, estado y evidencia ([CASOS_DE_PRUEBA.csv](../t3/CASOS_DE_PRUEBA.csv), 147 casos).
- Una prueba escrita no se presenta como ejecutada.

## 8. Responsables

Según los autores de los commits y PR del historial (detalle en la matriz):

| Integrante | Responsabilidad ejecutada |
|---|---|
| **Evelyn Victoria Rodriguez Cardozo** | RF-01, RF-02 (escritorio), RF-04/05 (TEC-004 y cierre), REF-003, REF-004, CR-019 (web por módulos y diseño), consolidación de la evaluación final |
| **Jorge Enrique Cano Asto** | RF-07 a RF-12, RF-13, RF-14, RF-15, versión web de los RF, transacción y estados de RF-03, grupo anual de RF-06, QA de aceptación |
| **Frank Piero Mantilla Arqueros** | RF-03, RF-06, RF-17, base `RangoFechas`/`CalendarioLaboral`, TEC-003 (feriados), REF-001, REF-002 |
| **Francisco Kadin Valera Lizarraga** | RF-16, RF-18, migraciones de base de datos, TEC-002 (integridad), versionado y releases, despliegue de la web (TEC-005) |

## 9. Cronograma

Fechas reales tomadas de las etiquetas y commits de `main`.

| Fase | Fechas | Hitos verificables |
|---|---|---|
| Recuperación y arquitectura | 13–18/10/2026 | Solución editable, MVP por capas (`0a4b6a8`), **v1.0.0** (18/10) |
| T2: diagnóstico y paquetes técnicos | 17–29/10/2026 | TEC-001 a TEC-004, análisis T2 (PR #9), solicitudes SC-001 a SC-003 |
| T3: implementación base | 11–13/11/2026 | RF-01 a RF-06, RF-13, RF-14, RF-16, RF-17, RF-18; **v1.0.1 a v1.5.0** |
| Versión web y vacaciones | 17–20/11/2026 | RF-07 a RF-12, RF-15, web de los 18 RF, QA de aceptación; **v1.6.0** (20/11) |
| Evaluación final | 23–24/11/2026 | Despliegue (PR #74, #75), CR-019 (PR #76, #77), trazabilidad y refactorizaciones (PR #78, #79); **v1.7.0** pendiente de publicar |

## 10. Criterios de aceptación

**De cada cambio** (definición de terminado):
1. Spec del CR o TEC con el comportamiento conservado y el corregido.
2. Pruebas automatizadas y suite sin fallas.
3. Arquitectura respetada (`DependenciasEntreCapasTests`).
4. Commit con `tipo(ALCANCE)` y `Refs`.
5. PR con el uso de IA declarado.
6. Fila en la matriz de cambios y casos en `CASOS_DE_PRUEBA.csv`.
7. Entrada en el CHANGELOG.

**De cada RF:** el caso de aceptación de [MATRIZ_ACEPTACION_RF.md](MATRIZ_ACEPTACION_RF.md), con evidencia de escritorio, web o ambas. Por ejemplo:
- RF-03 rechaza un segundo permiso que se cruza con otro.
- RF-07 genera 60 días por dos aniversarios.
- RF-17 cuenta cada fecha una sola vez.

**De la versión:** etiqueta anotada, release publicado, CHANGELOG sin `[Sin publicar]` pendiente y prueba de humo correcta en el entorno desplegado.
