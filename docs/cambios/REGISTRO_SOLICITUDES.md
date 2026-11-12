# Registro de solicitudes de cambio

Fecha de preparación: 29/10/2026. Línea base local inspeccionada: `694a658`.
Estado de esta preparación: documentación local revisable. Tres ramas y PR en borrador publicados para revisión; sin merge.

## Solicitudes registradas

| ID | Solicitud | Equivalencia | Mantenimiento principal | Prioridad | Justificación | Situación técnica documentada |
|---|---|---|---|---|---|---|
| SC-001 | Completar la aceptación del flujo de horarios migrado a capas | CR-TEC-001 / TEC-001 | Preventivo | Alta | Disminuir acoplamiento y comprobar un flujo delimitado antes de aceptar su uso | Código integrado en 138dbce, autoría de Evelyn; evidencia local histórica; QA Windows y revisión humana pendientes |
| SC-002 | Consolidar integridad e identificadores de BD | CR-TEC-002 / TEC-002 | Preventivo | Alta | Prevenir colisiones y referencias inválidas también ante escritores externos | Scripts integrados mediante PR #8 según historial local; saneamiento autorizado, restauración del destino, despliegue y QA pendientes |
| SC-003 | Completar la aceptación del mantenimiento de motivos de permiso | CR-TEC-004 / TEC-004 | Preventivo | Alta | Comprobar filtros, cancelación sin escritura, campos conservados y protección del histórico | Código integrado mediante PR #2 según historial local; QA Windows, revisión y reglas pendientes de confirmar |

Se conserva prioridad alta para SC-003 conforme al plan técnico. Esto resuelve la diferencia del borrador académico anterior, que sugería media para exposición. Es una prioridad de análisis, no una aprobación emitida.

Las tres solicitudes cubren avances existentes y su aceptación restante. Las correcciones concretas tienen criterios separados del refactor preventivo. La adaptación PostgreSQL previa se reconoce como antecedente y no se atribuye nuevamente a estos cambios.

## Solicitud principal

Se propone **SC-001**, porque tiene alcance delimitado, spec, diff y evidencia histórica que permiten explicar el control de extremo a extremo. Su selección académica queda pendiente de confirmación del equipo.

SC-002 es una dependencia técnica importante: seleccionar horarios no autoriza obviar integridad, saneamiento o compatibilidad del destino. SC-003 mantiene su análisis propio. Los códigos SC conservan su vínculo con CR-TEC y no sustituyen las 18 solicitudes funcionales.

## Organización de la revisión

| Rama solicitada | Entregable principal | Decisión técnica recomendada | Decisión humana |
|---|---|---|---|
| SC-001 | Registro consolidado, análisis de horarios y control actualizado | Aprobar continuación/aceptación con condiciones | Pendiente |
| SC-002 | Análisis y plan de integridad/IDs | Aprobar preparación y ensayos aislados con condiciones; bloquear intervención del destino hasta autorización | Pendiente |
| SC-003 | Análisis y plan de motivos de permiso | Aprobar continuación/aceptación con condiciones | Pendiente |

Estos nombres son los solicitados para publicación. Las tres ramas se publicaron y sus PR en borrador se crearon el 29/10 bajo KikeCano03; enlaces reales en el control de trazabilidad.

## Fuentes

- [Plan técnico](../t2/PLAN_EQUIPO.md).
- [Spec de horarios](../../specs/TEC-001-horarios.md).
- [Spec de integridad](../../specs/TEC-002-integridad-bd.md).
- [Spec de motivos](../../specs/TEC-004-motivos-permiso.md).
- [Control actualizado](CONTROL_Y_TRAZABILIDAD.md).

Preparación asistida por Codex. Revisión humana pendiente. Esta documentación no reasigna autoría del código ni registra aceptaciones no emitidas.

## Cobertura de los seis puntos

| Punto | Evidencia documental para revisión |
|---|---|
| 1. Registro | Tabla de tres SC, clasificación, prioridad, justificación y selección en este documento |
| 2. Solicitud principal | SC-001: origen, necesidad, beneficios, límites y riesgo de no completar aceptación |
| 3. Impacto | SC-001: funcionalidades, clases/capas, tablas, pruebas, mantenibilidad y riesgos técnicos |
| 4. Evaluación | SC-001: recomendación técnica de aprobación con condiciones; decisión humana pendiente |
| 5. Planificación | SC-001: actividades, responsables propuestos, horas, dependencias, archivos y evidencia esperada |
| 6. Control | Control y trazabilidad: mecanismo, registro, plantilla de aprobación, implementación, Git y conclusiones |

Análisis complementarios en sus ramas independientes:
[SC-002: integridad e IDs](https://github.com/Nidka/RRHH/blob/SC-002/docs/cambios/SC-002.md)
y [SC-003: motivos de permiso](https://github.com/Nidka/RRHH/blob/SC-003/docs/cambios/SC-003.md).
Los enlaces remotos permiten revisar cada documento antes de integrar sus PR.
No se deduce aprobación humana de su publicación.
## Ramas y PR para revisión

| SC / rama | Commit documental inicial | PR hacia main | Estado de publicación |
|---|---|---|---|
| SC-001 | `279d8b6c049be1c0648327fbbd985cdacf5b9af2` | [PR #11](https://github.com/Nidka/RRHH/pull/11) | Abierto en borrador, sin merge; revisión humana pendiente |
| SC-002 | `591b05b0df01cfdbc8da35913ae0d44571899afe` | [PR #12](https://github.com/Nidka/RRHH/pull/12) | Abierto en borrador, sin merge; revisión humana pendiente |
| SC-003 | `f51c21fa5d5c85c49020080297f4703dcfd6a85d` | [PR #13](https://github.com/Nidka/RRHH/pull/13) | Abierto en borrador, sin merge; revisión humana pendiente |

Los tres PR se dejan abiertos por solicitud del usuario. Revisión y decisiones humanas pendientes; la publicación no acredita aceptación funcional.
