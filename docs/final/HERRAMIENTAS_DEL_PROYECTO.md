# Herramientas del proyecto Semana 14

| Herramienta y tipo | Motivo y actividad | Beneficio | Uso o propuesta |
|---|---|---|---|
| GitHub Issues y Projects, seguimiento | Identificar tarea, responsable, bloqueo y aceptación | Coordinar dependencias de código y BD | [Issue real](https://github.com/Nidka/RRHH/issues/7). Projects es una propuesta de tablero con estados Pendiente, En curso, En revisión, En QA y Cerrado. |
| Git y GitHub, versiones | Ramas por tarea, commits, tags y releases | Reproducir una entrega y rastrear qué cambió | [T3 v1.5.0](https://github.com/Nidka/RRHH/tree/v1.5.0). |
| GitHub Issues y matriz CR, incidencias | Registrar pasos, entorno, esperado, obtenido y decisión | Hacer reproducible el problema y enlazarlo al arreglo | [Matriz CR](../t2/CONTROL_CAMBIOS.csv). Se proponen plantillas de incidencia y mejora. |
| Markdown y Word, documentación | Mantener specs y ADR cerca del código y consolidar la entrega académica | Distinguir hipótesis, reglas y evidencias | [Spec RF-13](../../specs/CR-013-registro-teletrabajo.md) e [informe T3](../t3/informe/INFORME_T3.docx). |
| GitHub PR y pruebas de arquitectura, calidad | Revisar diff, dependencias y aceptación con otra persona | Detectar regresiones y acoplamiento | [Plantilla de PR](../../.github/pull_request_template.md), [prueba de capas](../../Software/RRHH.Tests/Arquitectura/DependenciasEntreCapasTests.cs). |
| xUnit, SQL, QA y matriz CSV, validación | Verificar reglas, persistencia y recorridos con datos ficticios | Asociar cada resultado a un caso y versión | [Matriz T3](../t3/CASOS_DE_PRUEBA.csv), [concurrencia RF-13](../t3/evidencias/RF-13/concurrencia.txt). Propuesta: ampliar los recorridos a navegador y teléfono. |

## Mapa de trabajo

Issue o incidencia → CR y spec → rama y commits con referencias → PR y revisión ajena → pruebas y evidencia por SHA → cierre y versión.

El Issue es el registro operativo. La spec fija el contrato. El PR muestra el diff y la discusión. La matriz asocia requisitos con pruebas y estados. Un tablero presenta los mismos Issues por estado y el tag identifica el código entregado. Ejemplo real: RF-13 → CR-013 → PR #25 y migración #26 → CP-13-09 y evidencia SQL.

## Análisis crítico

1. **Organización.** Un Issue con dueño y dependencias evita duplicar trabajo. El módulo RF-13 necesitó tanto código como migración y ambos resultados deben estar visibles.
2. **Herramienta principal.** GitHub con Git conecta la versión del código con su tarea, revisión y evidencia. Esa relación permite reproducir qué se entregó.
3. **Riesgos.** Sin seguimiento se omiten bloqueos. Sin Git se pierde la versión exacta. Sin specs se pueden cambiar reglas como la exclusión de feriados sin evaluar sus consecuencias.
4. **Participación.** El Issue, el diff, la revisión ajena y las pruebas acreditan aportes individuales. Los PR integrados, la matriz y la versión muestran la entrega grupal.
5. **Antes del final.** Pilotear el tablero con un flujo real, revisar los PR con criterios verificables y registrar SHA, esquema, entorno, fecha, esperado y obtenido. Configurar verificaciones obligatorias cuando su ejecución sea reproducible.
