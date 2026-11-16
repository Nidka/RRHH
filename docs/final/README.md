# Semana 14 y evaluación final

Base de comparación: T3, etiqueta `v1.5.0` y consolidación `bb5add4`. La entrega de T3 es una reconstrucción de escritorio con PostgreSQL. La propuesta final expone un flujo de esa reconstrucción en una web adaptable e instalable como PWA. El ejecutable original sirve de referencia de ingeniería inversa.

## Alcance propuesto

El operador autorizado de RRHH necesita registrar y consultar periodos remotos desde un navegador de escritorio o teléfono. El primer corte abarca inicio de sesión, alta y listado de periodos (RF-13) y reporte de días (RF-14). Se conserva el calendario laboral y la comprobación transaccional del solapamiento. El equipo debe confirmar si la rúbrica complementaria exige módulos adicionales. RF-07 a RF-12 y RF-15 permanecen en el backlog de la evaluación final.

| Pauta | Evidencia de partida | Cierre esperado |
|---|---|---|
| Diagnóstico e ingeniería inversa | [Análisis T2](../t2/ANALISIS_Y_PREPARACION_T2.md), [matriz RF](../t2/MATRIZ_REQUERIMIENTOS.csv), [flujos](../t2/diagramas) | Explicar actores, flujos y reglas observadas con su origen y versión. |
| Visión, alcance y evolución | Este alcance y [arquitectura de T3](../../Software/docs/ARQUITECTURA.md) | Validar módulos y roles, anexar el ADR de la rama de plataforma. |
| Versión funcional | Prototipo de revisión en RamaW+M | Demostrar inicio de sesión, registro válido, rechazo de solape y reporte en escritorio y teléfono. |
| Control del cambio y versiones | [Matriz CR](../t2/CONTROL_CAMBIOS.csv), [changelog](../../CHANGELOG.md), [política de versiones](../versionado/POLITICA_VERSIONADO.md) | Relacionar Issue, spec, commits, PR, SHA probado y versión si se publica. |
| Pruebas | [Casos y evidencias T3](../t3/evidencias) | Repetir aceptación en PostgreSQL ficticio y registrar navegador, pantalla, esquema y resultado. |

[Selección, mapa y análisis crítico de herramientas](HERRAMIENTAS_DEL_PROYECTO.md).
