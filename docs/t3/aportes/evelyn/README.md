# Aporte local de Evelyn para T3

Fecha 12/11/2026, America/Lima. Responsable: Evelyn Victoria Rodriguez Cardozo. Codex asistió análisis, código, pruebas y documentos; Evelyn comprueba y sustenta. No hay aprobación humana ni publicación remota.

| Tarea | Rama / commit local | Entregable | Pendiente real |
|---|---|---|---|
| RF-01 | feature/rf-01-turnos-por-periodo / 5e91030 | [Spec](../../../../specs/CR-001-turnos-por-periodo.md), editor MVP, guardado atómico, tests | Windows/QA y revisión Kadin |
| RF-02 | feature/rf-02-historico-turnos / 45752cb, depende de RF-01 | [Spec](../../../../specs/CR-002-historico-turnos.md), filtro/histórico MVP, tests | Windows, Excel COM y revisión Kadin |
| RF-04/RF-05 | fix/rf-04-05-cierre-motivos / f1796af, desde main | [Spec de cierre](../../../../specs/CR-004-005-cierre-motivos.md), regresión de motivos, REF/informe | Capturas/recorridos Windows y revisión Frank |

`revision/evelyn-t3-local` reúne los tres aportes para revisión conjunta; **no es main** ni sustituye los PR individuales. El único conflicto al reunirlos fue evelyn.csv: se conservaron sus 30 casos sin duplicar IDs. La rama RF-02 contiene RF-01: integrar/rebasar conforme al orden de dependencia cuando Kadin revise; no presentar los mismos cambios como dos aportes distintos.

[REF-003](../../refactorizaciones/REF-003.md), [REF-004](../../refactorizaciones/REF-004.md), [informe §9](../../informe/evelyn-09-refactorizaciones.md), [informe §12](../../informe/evelyn-12-casos-prueba.md) y [casos](../../casos_prueba/evelyn.csv).

Se preparan tres borradores de PR en esta carpeta. No se enviaron mensajes, no se subieron ramas y no se publicaron PR/releases. La revisión técnica de IA detectó y permitió corregir un orden de bloqueos en RF-01; no representa la revisión de Kadin/Frank.

## Verificación que falta en Windows

1. Instalar las dependencias heredadas/licenciadas por el procedimiento del equipo; no agregarlas a Git.
2. Usar una BD QA ficticia y alcance acordado con Kadin. Ejecutar build.cmd y la suite net48 reales.
3. Ejecutar los CP-W1 y recorridos de casos propios: editor de periodos, histórico y exportación, alta/duplicado/edición/baja libre y en uso de motivos, cancelación y roles. Capturar solo datos ficticios.
4. Completar resultado obtenido/evidencia de esos casos y solicitar las revisiones indicadas. No marcar cierre funcional con la sola compilación o el arnés net8.

[Validación conjunta y arnés reproducible](../../evidencias/EVELYN_VALIDACION_CONJUNTA.md): 325/325 pruebas complementarias; compilación de capas/tests net48 con 0 errores y advertencias. [Notas para la revisión de RF-18](REVISION-RF18.md), preparadas para que Evelyn compruebe y comente; no publicadas.
