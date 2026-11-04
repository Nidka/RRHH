# Registro de versiones

| Versión | Fecha | Tipo de cambio | Descripción | Responsable | Estado |
|---------|-------|----------------|-------------|-------------|--------|
| 1.0.0 | 18/10/2026 | Versión inicial | Línea base recuperada sobre PostgreSQL; incluye TEC-003 y TEC-004 (PR #1, #2) | Equipo | Publicada |
| 1.0.1 | 20/11/2026 (est.) | Corrección | Integridad e identificadores de BD (TEC-002 / SC-002) | Francisco Kadin Valera Lizarraga | En revisión |
| 1.0.2 | 24/11/2026 (est.) | Corrección | Ajustes de motivos de permiso (SC-003) | Evelyn Victoria Rodriguez Cardozo | En revisión |
| 1.1.0 | 01/12/2026 (est.) | Mejora menor | Refactorización y validación de horarios (TEC-001 / SC-001) | Evelyn Victoria Rodriguez Cardozo | En revisión |
| 1.1.1 | 05/12/2026 (est.) | Corrección | Impedir permisos solapados (CR-003) | Frank Piero Mantilla Arqueros | Propuesto |
| 2.0.0 | Entrega final | Cambio mayor | Retiro de TableAdapters de SQL Server y migración a MVP | Jorge Enrique Cano Asto | Pendiente |

## Matriz cambios ↔ versiones

| Código | Descripción | Tipo | Versión asociada | Estado |
|--------|-------------|------|------------------|--------|
| TEC-003 | Refactor de feriados | Línea base | 1.0.0 | Integrado (PR #1) |
| TEC-004 | Motivos de permiso | Línea base | 1.0.0 | Integrado (PR #2) |
| SC-002 | Integridad e identificadores de BD | Corrección | 1.0.1 | En revisión (PR #12) |
| SC-003 | Plan de aceptación de motivos de permiso | Corrección | 1.0.2 | En revisión (PR #13) |
| SC-001 | Análisis y mejora de horarios | Mejora | 1.1.0 | En revisión (PR #10, #11) |
| CR-003 | Permisos solapados | Corrección | 1.1.1 | Propuesto |
| Por asignar | Retiro de TableAdapters y SQL Server | Cambio mayor | 2.0.0 | Pendiente |
