# 4 Actualización del diagnóstico T2

Base inspeccionada: `30e4c70` (11/11/2026), actualizada a `fb307e6` antes de publicar. Fuentes: [matriz RF](../../t2/MATRIZ_REQUERIMIENTOS.csv), [avance T2](../../t2/AVANCE_CODIGO_Y_SUSTENTACION.md) y [arquitectura](../../../Software/docs/ARQUITECTURA.md).

| Tema | Lo observado en la reconstrucción | Pendiente de contraste |
|---|---|---|
| Horarios y motivos | Los refactors TEC-001 y TEC-004 separan formulario, presenter, casos y repositorio. Los RF relacionados conservan sus propios criterios. | QA visual y funcional donde la spec lo indique. |
| Permisos | RF-03 incorpora la detección de contención y RF-06 agrega la regla anual configurable. | QA de pantalla y ejecución SQL en destino autorizado según las fichas. |
| Calendario | RangoFechas centraliza extremos inclusivos. CalendarioLaboral reutiliza feriados y días de semana. RF-17 lo usa en reportes de asistencia. | Confirmar el tratamiento de sábados y calendarios especiales. |
| Ausencias | El PR #22 incorpora RF-18 en `fb307e6`. Reutiliza solapamiento inclusivo para el filtro de fechas. | La [spec de ausencias](../../../specs/CR-018-ausencias-por-periodo.md) distingue las comprobaciones SQL del recorrido en la aplicación. |
| Teletrabajo | La línea base carece de tabla, flujo de registro y reportes de teletrabajo. El contrato nuevo se propone en CR-013. | Confirmar patrón parcial, autorización, anulación, permisos y calendario con el equipo. |

RF-13 incorpora una capacidad nueva en la reconstrucción. No hay evidencia de esa capacidad en el ejecutable original. RF-14 parte de periodos registrados por RF-13 y cuenta días computables. RF-16 depende de la integración de RF-13. La condición de integración sigue abierta al preparar este documento.

Los riesgos principales son la definición del patrón parcial, la disponibilidad de una migración compatible, la validez de códigos de empleado y la concurrencia. Las comprobaciones de SQL y recorrido Windows requieren datos ficticios y registrar la versión exacta.
