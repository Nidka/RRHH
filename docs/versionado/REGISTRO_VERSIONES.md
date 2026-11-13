# Registro de versiones

Plan de versiones de la evaluación T3. El número definitivo sigue el orden real de integración y se confirma al crear la etiqueta;
las fechas se completan al publicar cada versión.

| Versión | Fecha | Tipo de cambio | Descripción | Responsable del contenido | Estado |
|---------|-------|----------------|-------------|---------------------------|--------|
| 1.0.0 | 18/10/2026 | Versión inicial | Línea base recuperada sobre PostgreSQL; incluye TEC-003 y TEC-004 (PR #1, #2) | Equipo | Publicada |
| 1.0.1 | 19/10/2026 | Corrección | Horarios a capas (TEC-001, `138dbce`), integridad e IDs de BD (TEC-002, PR #8) y catálogo de áreas (`dde37f7`) | Kadin | Publicada (pre-lanzamiento) |
| 1.0.2 | 11/11/2026 | Corrección | RF-03: impedir permisos solapados (CR-003, PR #19) y base `RangoFechas`/`CalendarioLaboral` (PR #18) | Frank Piero Mantilla Arqueros | Publicada (pre-lanzamiento) |
| 1.0.3 | 11/11/2026 | Corrección | RF-17: feriados en el reporte general (CR-017, PR #20) | Frank Piero Mantilla Arqueros | Publicada (pre-lanzamiento) |
| 1.1.0 | 11/11/2026 | Mejora menor | RF-06: licencia que se otorga una vez al año (CR-006, PR #17 y #21) | Frank Piero Mantilla Arqueros / Kadin | Publicada (pre-lanzamiento) |
| 1.2.0 | 11/11/2026 | Mejora menor | RF-18: ausencias por periodo (CR-018, PR #22) | Francisco Kadin Valera Lizarraga | Publicada (pre-lanzamiento) |
| 1.3.0 | 11/11/2026 | Mejora menor | RF-13 y RF-14: teletrabajo (CR-013, CR-014, PR #23 y #25). La tabla llega con PR #26 | Jorge Enrique Cano Asto | Publicada (pre-lanzamiento) |
| 1.4.0 | 12/11/2026 | Mejora menor | RF-01 y RF-02: turnos por periodos e histórico (CR-001, CR-002, PR #27 y #28). **Versión intermedia de T3** | Evelyn Victoria Rodriguez Cardozo | Publicada (pre-lanzamiento) |
| 1.5.0 | 12/11/2026 | Mejora menor | RF-16: personal en teletrabajo total o parcial (CR-016, PR #31). Completa los tres complementarios de T3 | Francisco Kadin Valera Lizarraga | Publicada (pre-lanzamiento) |
| 2.0.0 | Entrega final | Cambio mayor | Retiro de TableAdapters de SQL Server y migración completa a MVP | Por asignar | Pendiente |

Los números siguen el **orden real de integración** en `main`, no el plan inicial (que asignaba 1.1.0 a RF-01/02 y 1.4.0 a RF-18).

Pre-versiones de QA: `vX.Y.Z-rc.N`. La coordinación de los releases está a cargo de Francisco Kadin Valera Lizarraga.

## Matriz cambios ↔ versiones

| Código | Descripción | Tipo | Versión asociada | Estado |
|--------|-------------|------|------------------|--------|
| TEC-003 | Refactor de feriados | Línea base | 1.0.0 | Integrado (PR #1) |
| TEC-004 | Motivos de permiso | Línea base | 1.0.0 | Integrado (PR #2) |
| TEC-001 | Horarios a capas y repositorio PostgreSQL | Refactor | 1.0.1 | Integrado (`138dbce`, vía PR #8) |
| TEC-002 | Integridad e identificadores de BD | Corrección | 1.0.1 | Integrado (PR #8); saneamiento de duplicados y QA pendientes |
| CR-003 | Permisos solapados (RF-03) | Corrección | 1.0.2 | Integrado (PR #19); QA en Windows pendiente |
| CR-017 | Feriados en el reporte general (RF-17) | Corrección | 1.0.3 | Integrado (PR #20); QA en Windows pendiente |
| CR-006 | Licencia una vez al año (RF-06) | Mejora | 1.1.0 | Integrado (PR #17, #21); marca sin activar en ningún motivo |
| CR-018 | Ausencias por periodo (RF-18) | Mejora | 1.2.0 | Integrado (PR #22); QA en Windows pendiente |
| CR-013 / CR-014 | Teletrabajo (RF-13, RF-14) | Mejora | 1.3.0 | Integrado (PR #23, #25); tabla en PR #26, sin aplicar en la base compartida |
| CR-001 / CR-002 | Turnos por periodos e histórico (RF-01, RF-02) | Mejora | 1.4.0 | Integrado (PR #27, #28); QA en Windows pendiente |
| CR-004 / CR-005 | Cierre de agregar y eliminar motivos (RF-04/05) | Pruebas y documentación | — | Integrado (PR #29); no cambia la versión |
| CR-016 | Teletrabajo total/parcial (RF-16) | Mejora | 1.5.0 | Integrado (PR #31); QA en Windows pendiente |
| SC-001 / SC-002 / SC-003 | Documentos de análisis y planes de aceptación | Documentación | — | No cambian la versión |
| Por asignar | Retiro de TableAdapters y SQL Server | Cambio mayor | 2.0.0 | Pendiente |
