# CR-017: sumar correctamente los feriados en el reporte general

- Estado: Implementado en la rama `fix/rf-17-feriados-reporte` (T3); en pruebas: faltan QA en la aplicación con datos ficticios y la revisión de Jorge.
- Tarea / RF / CR: RF-17 (complementario) / CR-017. Continúa el catálogo de feriados de [TEC-003](TEC-003-feriados.md), que no tocó el cómputo del reporte.
- Autor responsable / revisor: Frank Piero Mantilla Arqueros / Jorge Enrique Cano Asto.
- Versión/commit analizado: `d4f9345` (`origin/main` con el PR #16).
- Evidencias / PR: pruebas automáticas en `Software/RRHH.Tests/Asistencia/CalcularDiasNoLaborablesTests.cs`; capturas de la aplicación y PR pendientes.
- Versión propuesta: PATCH (corrección).

## Problema y comportamiento actual

**Hallazgo (lectura de código, sin ejecutar el original).** El «reporte general» al que se refiere el RF es la consulta de `FrmConsultaAsistencias` (botón Generar, `FrmConsultaAsistencias.cs`, ~línea 742 antes del cambio). No existe otro reporte único que sume feriados: `RRHHClass.LlenarPlanillaAsistencia` arma la planilla de marcaciones y `PostgreSqlLegacyContext.spRRHH_GetReporteAsistencia` es un stub que devuelve 0 (su resultado se descarta).

La columna «Total Dias Asistidos» se calcula así:

| Modo (`RadioGroupTipo`) | Fórmula antes del cambio |
|---|---|
| «Asistencias» (`A`) | `DiasAsistidos = (sábados y domingos del rango) + Dias_Asistidos` |
| «Productividad» (`P`) | `DiasAsistidos = Dias_Asistidos` (sin cambios) |

`Dias_Asistidos` viene de `PostgreSqlLegacyContext.spRRHH_GetDiasAsistidos`: `COUNT(DISTINCT Fecha)` de marcaciones del empleado en el rango. El conteo de sábados y domingos se hacía en el formulario con un bucle sobre el rango. **Los feriados de `public."RRHH_Feriado"` no participaban**: un feriado entre semana no se sumaba aunque nadie marcara ese día.

Ejemplo ficticio: semana del lunes 9 al domingo 15 de noviembre de 2026 con feriado el miércoles 11. Antes se sumaban 2 días no laborables (sábado y domingo); lo esperado son 3.

## Resultado esperado y alcance

En el modo «Asistencias», los días no laborables del rango se suman a los días asistidos. Un día no laborable es un fin de semana o un feriado, contado una sola vez.

**Hipótesis (a confirmar con el docente o el área usuaria):**

1. En «Asistencias» los días no laborables se acreditan automáticamente, como ya se hacía con sábados y domingos; el RF no lo contradice.
2. «Productividad» no acredita días no laborables; no se modifica.
3. Un día laborable según `CalendarioLaboral` es lunes a viernes y no feriado. Sábado y domingo siguen sin ser laborables.
4. La tabla `RRHH_Feriado` tiene filas históricas duplicadas (442 filas para 221 fechas, ver TEC-003): se cuenta una sola vez cada fecha, ignorando la hora.

**Fuera de alcance.** Si un empleado marca asistencia en un día no laborable, `Dias_Asistidos` ya lo cuenta y la suma lo cuenta otra vez. Ese doble conteo ya existía con los sábados y domingos y no se corrige aquí; se registra como hallazgo para decidir con el área usuaria. Tampoco se migra `FrmConsultaAsistencias` completo ni se retira `RRHHClass.LlenarPlanillaAsistencia`.

## Criterios de aceptación

- Dado un rango de lunes a domingo sin feriados, el conteo es 2.
- Dado el mismo rango con un feriado el miércoles, el conteo es 3.
- Dado un feriado en sábado, el conteo sigue siendo 2 (sin doble conteo).
- Un feriado repetido en la tabla, o con hora distinta de medianoche, cuenta una vez.
- Un feriado fuera del rango no cambia el conteo.
- Un rango invertido lanza `ReglaNegocioException`.

## Impacto y diseño

- Tipo de mantenimiento principal: correctivo. Técnica: extraer el conteo del formulario a un caso de uso y reutilizar `CalendarioLaboral` y `RangoFechas`. Comportamiento conservado: modo «Productividad», `Dias_Asistidos` y el resto del formulario.
- Patrón: Repository (`IFeriadoRepository` de TEC-003, sin cambios). Principio: DRY, porque la definición de día laborable queda en un único lugar (`CalendarioLaboral`), que también usarán RF-14 y RF-13.

| Capa/archivo | Cambio | Riesgo y mitigación |
|---|---|---|
| `RRHH.Application/Asistencia/CalcularDiasNoLaborables.cs` | Caso de uso nuevo: `rango.Dias - calendario.DiasLaborables(rango)` con los feriados de `IFeriadoRepository.Listar()`. | Lee toda la tabla de feriados (cientos de filas) en cada consulta; es aceptable por el tamaño. |
| `RecursosHumanos/CompositionRoot.cs` | `CrearCalcularDiasNoLaborables()`. | Aditivo. |
| `RecursosHumanos/FrmConsultaAsistencias.cs` | Se elimina el bucle de sábados y domingos y se usa el caso de uso para inicializar `num`. | El cálculo ahora consulta la BD; si falla la conexión, la excepción sale del botón igual que las demás consultas del formulario. |

## Pasos de implementación

1. Caracterizar la fórmula heredada (hecho; ver arriba).
2. Caso de uso y pruebas con repositorio falso (hecho).
3. Conectar en `CompositionRoot` y reemplazar el conteo del formulario (hecho).
4. QA en la aplicación con datos ficticios (pendiente).

## Verificación

| Caso / comando | Resultado esperado | Resultado real / entorno / evidencia |
|---|---|---|
| `Software\scripts\build.cmd` | 0 errores | 0 errores (Windows, 26 advertencias) |
| `dotnet test Software\RRHH.Tests\RRHH.Tests.csproj` | Sin fallas | 191 correctas, 0 con error, 28 omitidas (integración PostgreSQL) |
| Pruebas `CalcularDiasNoLaborablesTests` (CP-17-01 a CP-17-07) | Ver criterios de aceptación | Correctas. La prueba `FeriadoEntreSemana_SeSumaAlFinDeSemana` compara el conteo anterior (2) con el nuevo (3) sobre el mismo ejemplo ficticio |
| Generar el reporte en `FrmConsultaAsistencias` con un feriado ficticio entre semana, antes y después | «Total Dias Asistidos» sube en 1 solo en el modo «Asistencias» | **Pendiente** (captura real antes/después en `docs/t3/evidencias/RF-17/`) |

## Ficha del RF

| Campo | Valor |
|---|---|
| Código | RF-17 |
| Descripción | Validar que los feriados se sumen correctamente en el reporte general |
| Módulo | Calendario / reportes |
| Pantalla / clase | `FrmConsultaAsistencias`, `CalcularDiasNoLaborables`, `CalendarioLaboral` |
| Regla aplicada | Día no laborable = fin de semana o feriado, contado una vez; se suma a los días asistidos en modo «Asistencias» |
| Evidencia | Pruebas automáticas ejecutadas; captura en la aplicación pendiente |
| Estado | En pruebas |
| Commits | Ver `git log fix/rf-17-feriados-reporte` (pie `Refs: RF-17, CR-017`) |
| Casos de prueba | CP-17-01 a CP-17-07 en `docs/t3/casos_prueba/frank.csv` |

## Reversión

Revertir el commit `fix(RF-17)`: restaura el bucle original en el formulario. No cambia esquema ni datos.

## Uso de IA y decisiones humanas

La caracterización del reporte, el caso de uso y las pruebas se prepararon con un asistente de IA a partir de la lectura del código. Las hipótesis anteriores las debe confirmar el responsable con el área usuaria antes de dar el RF por validado.
