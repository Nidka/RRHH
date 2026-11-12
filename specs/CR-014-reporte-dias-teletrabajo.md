# CR-014 Reporte de días de teletrabajo

- RF-14 / CR-014. Responsable: Jorge Enrique Cano Asto. Revisor: Francisco Kadin Valera Lizarraga.
- Base: `30e4c70` y rama RF-13. Rama `feature/rf-14-reporte-dias-teletrabajo`.
- Estado: código preparado. QA, revisión y aceptación pendientes.

## Problema y alcance

En la reconstrucción base no hay reporte de teletrabajo. El nuevo reporte consulta uno o todos los empleados, en un rango inclusivo. **Hipótesis:** se cuentan días laborables de lunes a viernes, excluidos feriados de RRHH_Feriado. Para modalidad parcial solo cuentan los días remotos del patrón registrado por RF-13. No concilia marcaciones, ausencias ni horarios de cada empleado.

## Aceptación

- Recorta periodos que cruzan el rango. Los extremos son inclusivos.
- No cuenta feriados, sábados, domingos ni días presenciales del patrón parcial.
- Cuenta una vez cada día por empleado aunque existan filas duplicadas o solapadas.
- Sin periodos devuelve una grilla vacía. Rango invertido y código no positivo se rechazan.

## Diseño e impacto

Mantenimiento perfectivo. Reporte nuevo, sin reemplazo de consulta o procedimiento y sin refactorizar el reporte general. MVP y Repository aíslan UI, cómputo y lectura. DIP permite probar con un lector falso. Reutiliza `RangoFechas`, `CalendarioLaboral` e `IFeriadoRepository`. La grilla recibe DTO tipados.

`FrmReporteTeletrabajo → ReporteTeletrabajoPresenter → ReportarDiasTeletrabajo → IConsultaTeletrabajo / IFeriadoRepository`. PostgreSQL filtra periodos activos con fechas tipadas. Sin escrituras ni migración adicional.

## Pasos y verificación

1. Confirmar RF-13 y el calendario. Acordar la hipótesis de días computables.
2. Consultar periodos solapados, recortar y contar. Conectar la grilla al menú.
3. Ejecutar CP-14-01 a CP-14-05, suite y recorrido WinForms en QA ficticia.

| Caso | Esperado | Evidencia |
|---|---|---|
| Intervalo que cruza límites y feriado | Días remotos dentro del rango, sin feriado | Pruebas escritas. QA pendiente |
| Patrón parcial y datos repetidos | Solo días remotos, una vez por empleado | Pruebas escritas. QA pendiente |
| Sin datos o rango invertido | Sin filas o mensaje de rango inválido | Pruebas escritas. QA pendiente |

## Reversión y uso de IA

Revertir el PR de reporte conserva la tabla y las altas de RF-13. Codex apoyó spec, código y pruebas. Jorge comprueba el resultado, Kadin revisa y el equipo confirma el criterio de calendario.

## Ficha del RF

| Campo | Valor |
|---|---|
| Código | RF-14 / CR-014 |
| Descripción y módulo | Reporte de días remotos, teletrabajo |
| Pantalla y clase | FrmReporteTeletrabajo, ReportarDiasTeletrabajo |
| Regla | Recorte inclusivo, calendario laboral y patrón semanal |
| Evidencia y estado | [Casos de prueba](../docs/t3/casos_prueba/jorge.csv). Validación pendiente |
| Commits | Rama feature/rf-14-reporte-dias-teletrabajo con pie Refs |
| Casos | CP-14-01 a CP-14-05 |
