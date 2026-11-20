# Semana 14 y evaluación final

**Corte integrado del 20/11/2026.** El PR #67 está en main (7b90c45). Consultar la [matriz de los 18 RF](MATRIZ_ACEPTACION_RF.md) y la [evidencia local](../../specs/CR-QA-018-aceptacion-local.md). El resto de esta página conserva el alcance histórico del primer corte.

Base de comparación: T3, etiqueta `v1.5.0` y consolidación `bb5add4`. La entrega de T3 es una reconstrucción de escritorio con PostgreSQL. La propuesta final expone un flujo de esa reconstrucción en una web para el navegador. El ejecutable original sirve de referencia de ingeniería inversa.

## Alcance propuesto

El operador autorizado de RRHH necesita registrar y consultar periodos remotos desde un navegador de escritorio. El primer corte abarca inicio de sesión, alta y listado de periodos (RF-13) y reporte de días (RF-14). Se conserva el calendario laboral y la comprobación transaccional del solapamiento. El equipo debe confirmar si la rúbrica complementaria exige módulos adicionales. RF-07 a RF-12 y RF-15 permanecen en el backlog de la evaluación final.

| Pauta | Evidencia de partida | Cierre esperado |
|---|---|---|
| Diagnóstico e ingeniería inversa | [Análisis T2](../t2/ANALISIS_Y_PREPARACION_T2.md), [matriz RF](../t2/MATRIZ_REQUERIMIENTOS.csv), [flujos](../t2/diagramas) | Explicar actores, flujos y reglas observadas con su origen y versión. |
| Visión, alcance y evolución | Este alcance y [arquitectura de T3](../../Software/docs/ARQUITECTURA.md) | Validar módulos y roles, anexar el ADR de la rama de plataforma. |
| Versión funcional | [RRHH.Web](../../Software/RRHH.Web/README.md), rama de revisión RamaW+M | Demostrar inicio de sesión, registro válido, rechazo de solape y reporte en el navegador. |
| Control del cambio y versiones | [Matriz CR](../t2/CONTROL_CAMBIOS.csv), [changelog](../../CHANGELOG.md), [política de versiones](../versionado/POLITICA_VERSIONADO.md) | Relacionar Issue, spec, commits, PR, SHA probado y versión si se publica. |
| Pruebas | [Casos y evidencias T3](../t3/evidencias) | Repetir aceptación en PostgreSQL ficticio y registrar navegador, pantalla, esquema y resultado. |

[Selección, mapa y análisis crítico de herramientas](HERRAMIENTAS_DEL_PROYECTO.md).

## Cierre del alcance web

La entrega para revisión incluye inicio de sesión de operador, registro y consulta de periodos (RF-13) y reporte de días remotos (RF-14). La instalación móvil se evaluará por separado. La [spec de aceptación](../../specs/CR-013-014-web-movil.md) conserva hipótesis, pruebas y reversión. La integración depende de la revisión del equipo.

El navegador llama a la API del host ASP.NET Core. El host valida sesión, rol y protección de las escrituras, y llama a los casos de uso de T3. Los repositorios mantienen la validación transaccional y las consultas parametrizadas contra PostgreSQL. El [ADR del host](../../Software/docs/adr/0002-web-y-pwa.md) explica esta adaptación.

## Guion de demostración

1. Arrancar la [demo local](../../Software/RRHH.Web/README.md#demostración-y-qa) e iniciar sesión con el operador ficticio indicado en la consola.
2. Registrar para el empleado 101 un periodo del 9 al 13 de noviembre de 2026 con lunes, miércoles y viernes remotos. Consultar el periodo y mostrar el ID y el patrón.
3. Repetir el registro y comprobar que el navegador muestra el rechazo por solapamiento.
4. Consultar del 9 al 15 de noviembre. El resultado esperado es dos días porque el 11 es feriado ficticio. Cerrar sesión y comprobar que se vuelve al acceso.
5. Mostrar la spec, el diff y la [evidencia de verificación](../../Software/RRHH.Web/qa/RESULTADOS.md). Antes de la exposición, anotar el SHA y la versión del entorno utilizado.

El build WinForms acredita que el ejecutable de escritorio se genera. Su recorrido visual pendiente debe registrarse por separado. La evaluación de este corte usa la demo del navegador.

[Guía, simulador y evidencias de v1.6.0](../../qa/evidencias/v1.6.0/README.md).
