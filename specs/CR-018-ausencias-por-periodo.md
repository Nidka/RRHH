# CR-018: reportar quiénes están ausentes entre dos fechas

- Estado: Implementado en la rama `feature/rf-18-ausencias-por-periodo` (T3); en pruebas: faltan compilar y ejecutar `dotnet test` en Windows, el QA en la aplicación con datos ficticios y la revisión de Evelyn.
- Tarea / RF / CR: RF-18 (complementario) / CR-018.
- Autor responsable / revisor: Francisco Kadin Valera Lizarraga / Evelyn Victoria Rodriguez Cardozo.
- Versión/commit analizado: `30e4c70` (`origin/main` con los PR #10 a #13, #17, #20 y #21).
- Evidencias / PR: pruebas automáticas en `Software/RRHH.Tests/Permisos/ReportarAusenciasPorPeriodoTests.cs` y `RepAusenciasPresenterTests.cs`; prueba SQL en `BD/tests/rf18_ausencias.sql`; capturas de la aplicación y PR pendientes.
- Versión propuesta: MINOR (capacidad nueva).

## Problema y comportamiento actual

**Hallazgo (lectura de código, sin ejecutar el original).** El único reporte que lista permisos por fechas es `FrmRepPermisos`, que alimenta `XtraRepPermiso` con `RRHHClass.spRRHH_RepPermisos`. Esa consulta filtra con `"FechaInicio"::date BETWEEN @fechaInicio AND @fechaFin`: solo mira la **fecha de inicio** del permiso. Por eso omite al que ya estaba ausente cuando empieza el periodo (empezó antes) y al que lo contiene por completo. Tampoco tiene un resultado por persona y motivo pensado para responder «quién está ausente entre estas fechas»: es un listado imprimible de permisos.

Ejemplo ficticio con el periodo del 10 al 12 de noviembre de 2026 (datos de `BD/tests/rf18_ausencias.sql`): hay 5 personas/permisos que cumplen el requisito y el criterio heredado devuelve 3; el permiso del 1 al 30 de noviembre (que contiene el periodo) no aparece.

## Resultado esperado y alcance

Una pantalla nueva «Ausencias por periodo» (menú «Reportes», bajo «Permisos») que recibe un periodo y, opcionalmente, un motivo, y lista cada permiso que comparte al menos un día con el periodo: persona, motivo, inicio y fin del permiso completo y los días del permiso que caen dentro del periodo.

**Hipótesis (a confirmar con el docente o el área usuaria):**

1. La única fuente de ausencias es `public."Permiso"`. Vacaciones, licencias y enfermedad son motivos del catálogo `public."Motivo_Perm"`; no se ha encontrado otra tabla de vacaciones en `BD/schema.sql`.
2. «Cualquier solapamiento» sigue la regla de `RangoFechas.Solapa` (RF-03): fechas inclusivas, con igualdad, solapamiento parcial y contención en ambos sentidos. Un permiso que termina el día previo o empieza el día siguiente no se incluye.
3. Los «días en el periodo» son días calendario del permiso dentro del periodo, no días laborables.
4. Se informan también los permisos de personas con estado distinto de activo: una persona que estuvo ausente en el periodo sigue siendo parte de la historia. No se filtra por `Empleado."Estado"`.
5. Un permiso sin fecha inicial o final no se informa (igual que en `PostgreSqlPermisoRepository.ExisteSolapamiento`); un permiso con el motivo ausente del catálogo se informa con motivo vacío.
6. No se filtra por `public."Permiso"."Autorizado"`. El requisito pide quiénes «se encuentran» ausentes, no quiénes tienen autorización completa; se deja la decisión al área usuaria.

**Fuera de alcance.** No reemplaza a `FrmRepPermisos` ni a `XtraRepPermiso` (reporte imprimible); no filtra por oficina ni por tipo de trabajador; no exporta ni imprime; no integra el teletrabajo de RF-13 (modalidad distinta de ausencia).

## Criterios de aceptación

- La consulta incluye el permiso que empieza antes del periodo, el que termina después, el que lo contiene y el que está dentro.
- La consulta excluye el permiso que termina el día previo y el que empieza el día siguiente.
- Un permiso que toca solo un extremo del periodo cuenta 1 día.
- Un periodo de un solo día incluye los permisos que lo cubren.
- Con un motivo elegido solo aparecen permisos de ese motivo; sin motivo (o motivo 0) aparecen todos.
- Una persona con dos motivos en el periodo aparece en dos filas, una por motivo.
- El resultado se ordena por persona y luego por fecha de inicio.
- Un periodo invertido muestra «La fecha final no puede ser anterior a la fecha inicial.» y no consulta la BD.
- Un periodo sin ausencias muestra «Nadie se ausenta en el periodo consultado.».

## Impacto y diseño

- Tipo de mantenimiento principal: perfectivo. Se agrega una capacidad nueva sin modificar el reporte existente. Reutiliza `RangoFechas` de la base compartida.
- Patrones y principios: Repository (`IAusenciasRepository`), vista pasiva MVP (`IRepAusenciasView` / `RepAusenciasPresenter`) y SRP: el caso de uso decide qué es una ausencia, el repositorio solo recupera filas y la pantalla solo muestra.

| Capa/archivo | Cambio | Riesgo y mitigación |
|---|---|---|
| `RRHH.Application/Permisos/ReportarAusenciasPorPeriodo.cs` | Caso de uso: valida el periodo con `RangoFechas`, vuelve a aplicar solapamiento y motivo (no confía en el repositorio), calcula los días dentro del periodo y ordena. | Omite permisos con fechas invertidas en los datos en lugar de abortar el reporte. |
| `RRHH.Application/Permisos/IAusenciasRepository.cs` y DTO | Contrato y objetos de intercambio. | Aditivo. |
| `RRHH.PostgreSql/Permisos/PostgreSqlAusenciasRepository.cs` | SQL parametrizado con fechas `DbType.Date`: `inicio <= fin_periodo AND fin >= inicio_periodo`. Reemplaza el criterio de `RRHHClass.spRRHH_RepPermisos`. | `Empleado` se une solo por `IdEmpleado`, como el reporte heredado; si hubiera filas duplicadas por año se duplicarían permisos. Verificar con datos reales. |
| `RRHH.Presentation/Permisos/IRepAusenciasView.cs` y `RepAusenciasPresenter.cs` | Vista pasiva y presenter con resumen «N personas ausentes (M permisos)». | Sin referencias a WinForms ni DevExpress (lo comprueba `DependenciasEntreCapasTests`). |
| `RecursosHumanos/FrmRepAusencias.cs` | Formulario nuevo escrito a mano con controles estándar. | No se pudo compilar en este equipo; es la parte con más riesgo de error de compilación. |
| `RecursosHumanos/CompositionRoot.cs`, `MainMDI.cs` | `CrearRepAusencias()` y entrada de menú bajo «Permisos», con la misma visibilidad por rol. | La entrada se crea por código (no en el diseñador) para no tocar `InitializeComponent`. |

## Pasos de implementación

1. Caracterizar el criterio heredado y definir el contrato (hecho; ver arriba).
2. Caso de uso, presenter y pruebas con repositorio y vista falsos (hecho, sin ejecutar).
3. Repositorio PostgreSQL y prueba SQL en base desechable (hecho).
4. Formulario, `CompositionRoot` y menú (hecho, sin compilar).
5. Compilar, `dotnet test` y QA en la aplicación con datos ficticios (pendiente, en Windows).

## Verificación

| Caso / comando | Resultado esperado | Resultado real / entorno / evidencia |
|---|---|---|
| `psql -f BD/tests/rf18_ausencias.sql` en BD local desechable (PostgreSQL 16) | «RF-18: aserciones SQL correctas» | Correcto. Además aborta si la base ya tiene `Permiso`/`Empleado` |
| Criterio heredado sobre los mismos datos ficticios | Omite el permiso que contiene el periodo | Heredado: 3 filas y 0 del permiso que contiene el periodo; nuevo: 5 filas |
| `Software\scripts\build.cmd` | 0 errores | **Pendiente** (no hay Windows ni `dotnet` en este equipo) |
| `dotnet test Software\RRHH.Tests\RRHH.Tests.csproj` | Sin fallas | **Pendiente**: 17 pruebas del caso de uso y 10 del presenter escritas, no ejecutadas |
| Abrir «Reportes > Ausencias por periodo» y consultar con datos ficticios | Resultado y resumen según los criterios | **Pendiente** (captura en `docs/t3/evidencias/RF-18/`) |

## Ficha del RF

| Campo | Valor |
|---|---|
| Código | RF-18 |
| Descripción | Reportar quiénes se encuentran de vacaciones, licencia, enfermedad u otros motivos entre periodos de fechas |
| Módulo | Permisos / reportes |
| Pantalla / clase | `FrmRepAusencias`, `RepAusenciasPresenter`, `ReportarAusenciasPorPeriodo`, `PostgreSqlAusenciasRepository` |
| Regla aplicada | Un permiso es ausencia en el periodo si comparte al menos un día con él (fechas inclusivas); se distingue por persona y motivo |
| Evidencia | Prueba SQL ejecutada en base desechable; pruebas automáticas escritas, ejecución y captura pendientes |
| Estado | En pruebas |
| Commits | Ver `git log feature/rf-18-ausencias-por-periodo` (pie `Refs: RF-18, CR-018`) |
| Casos de prueba | CP-18-01 a CP-18-19, CP-18-S1 y CP-18-S2 en `docs/t3/casos_prueba/kadin.csv` |

## Reversión

Revertir el commit `feat(RF-18)`: elimina los archivos nuevos y la entrada de menú. No cambia esquema ni datos; `FrmRepPermisos` no se toca.

## Uso de IA y decisiones humanas

El análisis, el código y las pruebas se prepararon con un asistente de IA a partir de la lectura del repositorio. Las hipótesis anteriores las debe confirmar el responsable con el área usuaria, y los resultados pendientes (compilación, `dotnet test` y QA en la aplicación) los debe ejecutar una persona en Windows antes de dar el RF por validado.
