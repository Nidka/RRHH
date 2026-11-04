# Changelog

Todos los cambios relevantes del sistema RRHH se documentan en este archivo.

El formato se basa en [Keep a Changelog](https://keepachangelog.com/es-ES/1.1.0/)
y el proyecto usa [Versionado Semántico](https://semver.org/lang/es/).

## [Sin publicar]

### Corregido
- Integridad e identificadores de BD (TEC-002 / SC-002). PR #12
- Ajustes de motivos de permiso según plan de aceptación (SC-003). PR #13

### Cambiado
- Análisis y refactorización de horarios (TEC-001 / SC-001). PR #11

## [1.0.0] - 2026-10-18

### Agregado
- Solución editable .NET Framework 4.8 recuperada de los ensamblados originales.
- Acceso a datos en PostgreSQL (Neon) mediante variables de entorno o `.env` local.
- Contraseñas de usuarios RRHH con hash PBKDF2-SHA256 y salt aleatorio.
- Suite automática con 65 pruebas.

### Cambiado
- Refactor de feriados (TEC-003). PR #1
- Motivos de permiso (TEC-004). PR #2
- La importación biométrica escribe asistencia y marcaciones en PostgreSQL dentro de una transacción.

[Sin publicar]: https://github.com/Nidka/RRHH/compare/v1.0.0...HEAD
[1.0.0]: https://github.com/Nidka/RRHH/releases/tag/v1.0.0
