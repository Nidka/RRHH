# CR-016: reportar quiénes realizan teletrabajo total o parcial

- Estado: Implementado en la rama `feature/rf-16-teletrabajo-total-parcial` (T3); en pruebas: suite completa en net8 correcta; faltan la compilación del WinForms y el recorrido de la pantalla en Windows.
- Tarea / RF / CR: RF-16 (complementario) / CR-016.
- Autor responsable / revisor: Francisco Kadin Valera Lizarraga (implementación) / Jorge Enrique Cano Asto (autor de RF-13 y RF-14, de los que depende).
- Versión/commit analizado: `5d5976d` (`origin/main` con v1.4.0 y el PR #29).
- Evidencias / PR: pruebas en `Software/RRHH.Tests/Teletrabajo/ClasificacionTeletrabajoTests.cs`; ejecución en `docs/t3/evidencias/RF-16/`; casos CP-16-01 a CP-16-17 en `docs/t3/casos_prueba/kadin.csv`.
- Versión propuesta: MINOR (capacidad nueva, 1.5.0).

## Problema y alcance

El sistema recibido no tiene teletrabajo. RF-13 registra periodos con modalidad total o parcial y RF-14 cuenta los días remotos de cada persona, pero ningún reporte dice **quién** teletrabaja de forma total y quién de forma parcial en un periodo.

## Resultado esperado

Una pantalla «Mantenimientos > Personal en teletrabajo (total o parcial)» que recibe un periodo y un filtro (total y parcial, solo total o solo parcial) y lista a cada persona que teletrabaja, con su clasificación, sus días remotos y los días laborables del periodo, más un resumen («N personas en teletrabajo: X total y Y parcial»).

**Criterio de clasificación (hipótesis a confirmar con el área usuaria).** El criterio es el **de cobertura del periodo consultado**, no el de la modalidad con que se registró cada periodo:

| Clasificación | Condición |
|---|---|
| Total | La persona teletrabaja **todos** los días laborables del periodo (100 %) |
| Parcial | Teletrabaja al menos un día laborable, pero no todos |
| No figura | No teletrabaja ningún día laborable del periodo |

Un día laborable es de lunes a viernes y no feriado (`CalendarioLaboral`, igual que RF-14 y RF-17). Un periodo registrado como «total» que cubre solo parte del periodo consultado se informa como parcial para ese periodo. Si el periodo consultado no tiene días laborables (por ejemplo, un fin de semana), no se clasifica a nadie.

**Fuera de alcance.** No concilia marcaciones, ausencias ni horarios; no exporta ni imprime; no muestra el detalle de periodos de cada persona (eso lo hace `FrmTeletrabajo`).

## Criterios de aceptación

- Un periodo total que cubre todo el consultado clasifica como Total con N de N días.
- Un patrón parcial (por ejemplo lunes, miércoles y viernes) clasifica como Parcial con 3 de 5 días.
- Un feriado dentro del periodo no impide el Total (se descuenta de los días laborables).
- Un periodo total que cubre solo parte del consultado clasifica como Parcial.
- Dos periodos consecutivos que juntos cubren el consultado clasifican como Total.
- Sin periodos, o con un periodo solo en un feriado, nadie figura; un periodo consultado sin días laborables devuelve lista vacía.
- El filtro devuelve solo la clase elegida; hay una fila por persona, ordenada por código, aunque existan periodos repetidos.
- Un periodo invertido muestra el mensaje de la regla y no consulta la base.

## Impacto y diseño

- Tipo de mantenimiento: perfectivo. Capacidad nueva que **no modifica** el código de RF-13 ni de RF-14 (SRP/OCP): reutiliza `ReportarDiasTeletrabajo` para los días remotos y `CalendarioLaboral` para los laborables. Sin migración ni consultas nuevas.
- Patrones: MVP de vista pasiva, Repository (ya existente) y composición de casos de uso.

| Capa/archivo | Cambio |
|---|---|
| `RRHH.Application/Teletrabajo/ReportarTeletrabajoTotalOParcial.cs` y `ClasificacionTeletrabajoDto.cs` | Caso de uso y fila de resultado. |
| `RRHH.Presentation/Teletrabajo/ClasificacionTeletrabajoPresenter.cs` | Vista pasiva `IClasificacionTeletrabajoView` y presenter con resumen y mensajes de error. |
| `RecursosHumanos/FrmClasificacionTeletrabajo.cs` | Formulario nuevo con controles estándar. |
| `RecursosHumanos/CompositionRoot.cs`, `MainMDI.cs` | `CrearClasificacionTeletrabajo()` y entrada de menú junto a las de teletrabajo de RF-13 y RF-14. |

## Verificación

| Caso / comando | Resultado esperado | Resultado real / entorno |
|---|---|---|
| Suite completa en net8 con PostgreSQL local desechable (12/11/2026) | Sin fallas | **342 de 342 superadas** (325 anteriores + 17 de RF-16) |
| Mutación de la regla (`>=` por `>` en la condición de Total) | Las pruebas fallan | 6 de 17 fallan; al restaurarla, 17 superadas |
| `Software\scripts\build.cmd` y recorrido de `FrmClasificacionTeletrabajo` en Windows | Compila; muestra filas y resumen | No ejecutado (requiere Windows y las DLL licenciadas) |

## Ficha del RF

| Campo | Valor |
|---|---|
| Código | RF-16 |
| Descripción | Reportar quiénes realizan teletrabajo total o parcial |
| Módulo | Reportes / Teletrabajo |
| Pantalla / clase | `FrmClasificacionTeletrabajo`, `ClasificacionTeletrabajoPresenter`, `ReportarTeletrabajoTotalOParcial` |
| Regla aplicada | Total = teletrabaja todos los días laborables del periodo; Parcial = algunos |
| Evidencia | Suite net8 342/342; prueba de mutación |
| Estado | En pruebas |
| Casos de prueba | CP-16-01 a CP-16-17 |

## Reversión

Revertir el commit `feat(RF-16)`: elimina los archivos nuevos y la entrada de menú. No cambia esquema ni datos; RF-13 y RF-14 no se tocan.

## Uso de IA y decisiones humanas

El análisis, el código y las pruebas se prepararon con un asistente de IA a partir de la lectura de RF-13 y RF-14. El criterio de clasificación es una hipótesis que debe confirmar el responsable con el área usuaria, y la compilación y el recorrido en Windows deben hacerlos personas.
