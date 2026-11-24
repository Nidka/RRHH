# Refactorizaciones ejecutadas

Cada ficha muestra el problema inicial, el código antes y después extraído de Git, el principio aplicado, el beneficio con su comprobación, y el commit y la persona responsable.

| Código | Problema | Refactorización aplicada | Principio aplicado | Beneficio | Responsable y commit |
|---|---|---|---|---|---|
| [REF-001](REF-001.md) | 10 formularios de catálogo con la misma lógica de alta, código `Max()+1` y mapper heredado | Componente MVP genérico: `CatalogoPresenter`, casos de uso y `PostgreSqlCatalogoRepository` definidos por datos | DRY · Abierto/Cerrado · Inversión de dependencias | Una sola implementación para 10 catálogos, probada sin WinForms | Frank Piero Mantilla Arqueros, `0a4b6a8` |
| [REF-002](REF-002.md) | `FrmFeriado` validaba, generaba códigos y persistía en el evento del botón, con la fecha como texto | Entidad `Feriado`, casos de uso, `FeriadoPresenter` y repositorio con transacción y bloqueo | Responsabilidad única · Separación de capas · Inversión de dependencias | Regla de duplicados probada y feriados reutilizados por RF-14, RF-16 y RF-17 | Frank Piero Mantilla Arqueros, `cc74aa0`, `f39f4b1` (PR #1) |
| [REF-003](REF-003.md) | `FrmMantMotivo` actualizaba la base al cargar y mezclaba controles con consultas | Vista pasiva, presenter, casos de uso y repositorio de motivos | Responsabilidad única · Inversión de dependencias | Cargar o cancelar ya no escribe; la edición conserva los campos | Evelyn Victoria Rodriguez Cardozo, `01db40b` (TEC-004) |
| [REF-004](REF-004.md) | `FrmMantHorarios` validaba y guardaba con `HorarioMapper` y asignaba `MAX+1` desde el evento | Horarios a MVP con repositorio PostgreSQL | Separación de capas · Inversión de dependencias | Comportamiento conservado con pruebas y una sola ruta de datos | Evelyn Victoria Rodriguez Cardozo, `138dbce` (TEC-001) |
| [REF-005](REF-005.md) | Pantallas web apiladas sin navegación, todo en `app.js` y `Program.cs` | Catálogo único de módulos, API por módulo e interfaz con componentes | Abierto/Cerrado · Responsabilidad única · DRY · Inversión de dependencias | Una pantalla nueva = una entrada y un archivo; nombres en lugar de códigos | Evelyn Victoria Rodriguez Cardozo, PR #76 y #77 (CR-019) |

**Numeración.** El análisis de T2 ([ANALISIS_Y_PREPARACION_T2.md](../../t2/ANALISIS_Y_PREPARACION_T2.md), sección 5) usaba REF-001 a REF-006 para **propuestas**. El plan T3 reasignó REF-001 a REF-004 a refactorizaciones ya ejecutadas, y REF-005 se agregó con CR-019. Las propuestas de T2 sobre importación y vacaciones no se presentan aquí como ejecutadas.

**Comprobación común.** Todas las pruebas citadas en las fichas aparecen superadas en [ejecucion-net8-c79949b.txt](../evidencias/SUITE/ejecucion-net8-c79949b.txt) (427/427, 23/11/2026). Las fichas REF-001 y REF-002 las redactó Evelyn a partir de los commits de Frank; la revisión de Frank está pendiente.
