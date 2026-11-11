# Registro de versiones

Plan de versiones de la evaluación T3. El número definitivo sigue el orden real de integración y se confirma al crear la etiqueta;
las fechas se completan al publicar cada versión.

| Versión | Fecha | Tipo de cambio | Descripción | Responsable del contenido | Estado |
|---------|-------|----------------|-------------|---------------------------|--------|
| 1.0.0 | 18/10/2026 | Versión inicial | Línea base recuperada sobre PostgreSQL; incluye TEC-003 y TEC-004 (PR #1, #2) | Equipo | Publicada |
| 1.0.1 | Por definir | Corrección | Horarios a capas (TEC-001, `138dbce`), integridad e IDs de BD (TEC-002, PR #8) y cierre de RF-04/05 | Kadin / Evelyn | Planificada; TEC-001 y TEC-002 ya están en main |
| 1.1.0 | Por definir | Mejora menor | RF-01 y RF-02: turnos por periodos e histórico | Evelyn Victoria Rodriguez Cardozo | Planificada |
| 1.1.1 | Por definir | Corrección | RF-03: impedir permisos solapados (CR-003) | Frank Piero Mantilla Arqueros | Planificada |
| 1.2.0 | Por definir | Mejora menor | RF-06: licencia que se otorga una vez al año | Frank Piero Mantilla Arqueros | Planificada |
| 1.2.1 | Por definir | Corrección | RF-17: feriados en el reporte general | Frank Piero Mantilla Arqueros | Planificada |
| 1.3.0 | Por definir | Mejora menor | RF-13, RF-14 y RF-16: teletrabajo | Jorge Enrique Cano Asto | Planificada |
| 1.4.0 | Por definir | Mejora menor | RF-18: ausencias por periodo. **Versión intermedia de T3** | Francisco Kadin Valera Lizarraga | Planificada |
| 2.0.0 | Entrega final | Cambio mayor | Retiro de TableAdapters de SQL Server y migración completa a MVP | Por asignar | Pendiente |

Pre-versiones de QA: `vX.Y.Z-rc.N`. La coordinación de los releases está a cargo de Francisco Kadin Valera Lizarraga.

## Matriz cambios ↔ versiones

| Código | Descripción | Tipo | Versión asociada | Estado |
|--------|-------------|------|------------------|--------|
| TEC-003 | Refactor de feriados | Línea base | 1.0.0 | Integrado (PR #1) |
| TEC-004 | Motivos de permiso | Línea base | 1.0.0 | Integrado (PR #2) |
| TEC-001 | Horarios a capas y repositorio PostgreSQL | Refactor | 1.0.1 | Integrado en main (`138dbce`, vía PR #8) |
| TEC-002 | Integridad e identificadores de BD | Corrección | 1.0.1 | Integrado (PR #8); saneamiento de duplicados y QA pendientes |
| CR-004 / CR-005 | Cierre de agregar y eliminar motivos (RF-04/05) | Corrección | 1.0.1 | Planificado |
| CR-001 / CR-002 | Turnos por periodos e histórico (RF-01/02) | Mejora | 1.1.0 | Planificado |
| CR-003 | Permisos solapados (RF-03) | Corrección | 1.1.1 | Planificado |
| CR-006 | Licencia una vez al año (RF-06) | Mejora | 1.2.0 | Planificado |
| CR-017 | Feriados en el reporte general (RF-17) | Corrección | 1.2.1 | Planificado |
| CR-013 / CR-014 / CR-016 | Teletrabajo (RF-13, RF-14, RF-16) | Mejora | 1.3.0 | Planificado |
| CR-018 | Ausencias por periodo (RF-18) | Mejora | 1.4.0 | Planificado |
| SC-001 / SC-002 / SC-003 | Documentos de análisis y planes de aceptación | Documentación | — | No cambian la versión |
| Por asignar | Retiro de TableAdapters y SQL Server | Cambio mayor | 2.0.0 | Pendiente |
