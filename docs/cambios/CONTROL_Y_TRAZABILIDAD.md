# Control del cambio y trazabilidad de solicitudes

Actualización documental: 29/10/2026. Base local: `694a658`.
Estado: preparado para revisión. Tres ramas publicadas y PR en borrador creados bajo KikeCano03 por autorización expresa del usuario; SHA y enlaces reales en el apartado 5. El PR #10 fue consultado por API el 29/10: abierto, sin merge, rama RamaKike. Se conserva como antecedente y no se modifica.

## 1 Mecanismo de control

Mantener un registro versionado que relacione SC, CR-TEC, spec, decisión, código, resultados y aceptación. El [registro consolidado](REGISTRO_SOLICITUDES.md) fija identificadores y prioridad; cada análisis describe alcance, impacto, riesgos y plan. Las specs técnicas conservan contratos y evidencia de implementación.

Estados propuestos: registrada, en análisis, pendiente de decisión, autorizada con o sin condiciones, en ejecución, en revisión y cerrada. Una decisión también puede ser rechazo o postergación. Ante bloqueo, registrar causa, responsable y siguiente acción; no cambiar a cerrado por tener un merge.

Separar estado del análisis documental, estado de implementación y estado de aceptación. Una solicitud de mantenimiento puede tener código previo integrado y aceptación pendiente. Los nuevos PR previstos proponen documentos y no simulan una implementación nueva.

## 2 Registro de solicitudes y prioridad

| ID | Equivalencia | Prioridad actual del análisis | Estado documental nuevo | Aceptación técnica |
|---|---|---|---|---|
| SC-001 | CR-TEC-001 / TEC-001 | Alta | Publicado para revisión | QA Windows y revisión humana pendientes |
| SC-002 | CR-TEC-002 / TEC-002 | Alta | Publicado para revisión | Copia/destino, saneamiento autorizado, restauración, despliegue y QA pendientes |
| SC-003 | CR-TEC-004 / TEC-004 | Alta | Publicado para revisión | Reglas/QA Windows/integridad y revisión pendientes |

Se propone SC-001 como solicitud principal. La decisión del equipo sigue pendiente. La prioridad alta de SC-003 reemplaza la media del borrador académico para mantener coherencia con el plan técnico. No modifica retroactivamente sus registros históricos.

SC-002 condiciona compatibilidad e integridad de las demás; no es una tarea accesoria por no ser el ejemplo principal. Los 18 CR funcionales y los RF parciales conservan su alcance y seguimiento.

## 3 Cómo documentar una aprobación

La tabla siguiente es un modelo sin firma ni aprobación emitida. Completar cada solicitud después de una decisión real.

| Campo | SC-001 | SC-002 | SC-003 |
|---|---|---|---|
| Recomendación técnica | Aprobar continuación/aceptación con condiciones | Aprobar preparación/ensayos aislados con condiciones | Aprobar continuación/aceptación con condiciones |
| Decisión humana | Pendiente | Pendiente | Pendiente |
| Persona con autoridad / fecha | Pendiente | Pendiente | Pendiente |
| Versión evaluada | SHA real por registrar al revisar | SHA y migración/destino por registrar | SHA real por registrar al revisar |
| Condiciones | QA Windows, esquema compatible y revisión ajena | Copia QA, respaldo/restauración, política de saneamiento y autorización del destino | Reglas/filtros, QA Windows, contrato de IDs y revisión ajena |
| Evidencia de cumplimiento | Pendiente | Pendiente | Pendiente |
| Aceptación / cierre / versión | Pendiente | Pendiente | Pendiente |

Modelo de asiento: «SC-NNN, revisión de alcance y SHA [real]. Persona que decide [real], fecha [real], decisión [real], justificación, condiciones con responsable y evidencia. Aceptación [real o pendiente]». Los corchetes son campos de plantilla, no hechos.

La decisión de alcance, la revisión técnica y la aceptación final son actos distintos. La publicación de un PR no emite ninguno automáticamente. Confirmar quién decide cada aspecto y mantener revisión por una persona distinta de quien elaboró el cambio.

## 4 Demostración de implementación y resultados

Mostrar código y diff identificables, luego resultados de la misma versión. Para cada caso: entorno, esquema, ejecutable, datos ficticios, pasos, esperado, obtenido, fecha y fuente. Los documentos de análisis enlazan la evidencia existente y señalan qué falta ejecutar.

| Solicitud | Evidencia de código/datos existente | Resultado histórico y límite | Evidencia nueva requerida |
|---|---|---|---|
| SC-001 | Base fd12b80 y refactor 138dbce | 167 pruebas en arnés net8 del 18/10; build de capas/tests net48. No prueba QA WinForms | Build/suite/recorrido Windows, esquema compatible y revisión |
| SC-002 | Aporte c7b2c08 y scripts de migración/fixture | 14 comprobaciones SQL locales del 18/10 en validación de integración. No certifica destino actual | Perfilado actual autorizado, copia/restauración, ensayo, compatibilidad y decisión de despliegue |
| SC-003 | Implementación 01db40b y merge histórico 06ca7f6 | 130 pruebas de suite combinada en arnés net8 del 18/10. No sumarlas a 167: comparten pruebas | Casos de roles, apertura/cancelación, alta/edición/borrado, build/suite/QA y revisión |

La preparación del 29/10 solo inspecciona documentos e historial y verifica coherencia documental. No se ejecutaron pruebas funcionales nuevas, compilación, SQL ni operaciones contra BD. La existencia de scripts o tests no constituye prueba de ejecución nueva.

## 5 Ramas, commits, PR y versiones

### Antecedentes existentes

| Referencia | Qué acredita | Límite |
|---|---|---|
| 138dbce | Refactor de horarios, autoría de Evelyn | Integración directa documentada como excepción; no hay PR del refactor acreditado |
| c7b2c08 / daba5e0 / PR #8 | Aporte BD y su integración histórica en el historial local | No equivale a despliegue de integridad aceptado |
| 01db40b / 06ca7f6 / PR #2 | Implementación e integración histórica de motivos | No equivale a QA o revisión humana aprobada |
| RamaKike, 4af9f2b y a4034d7 | Publicación documental realizada el 27/10 bajo KikeCano03 | No reasigna autoría de código |
| PR #10 | Propuesta documental hacia main creada el 27/10, sin merge en aquella sesión | Consultado por API el 29/10: abierto y sin merge, rama RamaKike; no sustituye revisión del refactor |

Enlaces de antecedentes: [PR #2](https://github.com/Nidka/RRHH/pull/2), [PR #8](https://github.com/Nidka/RRHH/pull/8), [PR #10](https://github.com/Nidka/RRHH/pull/10).

### Publicación nueva solicitada

| SC / rama | Commit documental inicial | PR hacia main | Estado de publicación |
|---|---|---|---|
| SC-001 | `279d8b6c049be1c0648327fbbd985cdacf5b9af2` | [PR #11](https://github.com/Nidka/RRHH/pull/11) | Abierto en borrador, sin merge; revisión humana pendiente |
| SC-002 | `591b05b0df01cfdbc8da35913ae0d44571899afe` | [PR #12](https://github.com/Nidka/RRHH/pull/12) | Abierto en borrador, sin merge; revisión humana pendiente |
| SC-003 | `f51c21fa5d5c85c49020080297f4703dcfd6a85d` | [PR #13](https://github.com/Nidka/RRHH/pull/13) | Abierto en borrador, sin merge; revisión humana pendiente |

Las tres ramas parten independientemente de main 694a6586f32ed979d40a5010cd36682fcbf111d8. Los commits iniciales registran el contenido; los posteriores registran los enlaces ya creados. Consultar la pestaña Commits de cada PR para obtener su última revisión. No se modificó el PR #10. Publicación exclusivamente documental; no incluye output/tmp ni altera la implementación existente. Los análisis SC-002 y SC-003 se revisan en sus PR independientes; este control consolida los tres.

Un commit identifica contenido; una rama delimita el trabajo; un PR permite revisión; una versión aceptada relaciona código, esquema, ejecutable y resultados. No se crea tag/release ni se hace merge en esta preparación.

## 6 Cierre, reversión y conclusiones

Cerrar una SC solo después de verificar alcance, condiciones, revisión ajena, compatibilidad de datos y aceptación real de una versión identificada. Si hay regresión, registrar impacto, corrección y nueva comprobación. La aprobación técnica documental no acepta automáticamente el aplicativo.

La reversión documental se hace con un cambio inverso revisable. Para código, conservar historial y comprobar dependencias. En BD, Kadin coordina el alcance del rollback y la restauración ensayada; revertir C# no revierte datos.

Conclusiones:

1. El registro, los análisis y el control usan las mismas equivalencias y prioridad técnica.
2. La evidencia local permite sustentar avances existentes sin presentarlos como trabajo nuevo.
3. Los antecedentes de RamaKike y PR #10 fortalecen la trazabilidad documental, con fecha y límites.
4. Las tres ramas y los PR #11, #12 y #13 están publicados para revisión; no se realizaron merges, revisiones simuladas ni releases.
5. El cierre requiere resultados y aceptación reales. RF-01/02 y RF-04/05 mantienen criterios pendientes.

## Fuentes

- [Registro de solicitudes](REGISTRO_SOLICITUDES.md).
- [Spec TEC-001](../../specs/TEC-001-horarios.md) y [validación local](../t2/evidencias/TEC-001/validacion-local.txt).
- [Spec TEC-002](../../specs/TEC-002-integridad-bd.md) y [validación de integración](../t2/evidencias/TEC-002/VALIDACION_INTEGRACION.md).
- [Spec TEC-004](../../specs/TEC-004-motivos-permiso.md) y [resultado portable](../t2/evidencias/TEC-004/resultado-portable.txt).

Preparación asistida por Codex. La revisión humana de este control y las decisiones del equipo siguen pendientes. Los nuevos documentos organizan el trabajo; no simulan contribuciones, revisiones ni autorías.
