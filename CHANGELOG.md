# Changelog

Todos los cambios relevantes del sistema RRHH se documentan en este archivo.

El formato se basa en [Keep a Changelog](https://keepachangelog.com/es-ES/1.1.0/)
y el proyecto usa [Versionado Semántico](https://semver.org/lang/es/).

## [Sin publicar]

Pendiente de integrar tras la v1.4.0: RF-16 (teletrabajo total/parcial) y el retiro de TableAdapters (2.0.0).

## [1.4.0] - 2026-11-12

### Agregado
- RF-01: asignación de horarios por periodos con MVP (CR-001). PR #27
- RF-02: consulta del histórico de horarios por empleado y periodo (CR-002). PR #28

## [1.3.0] - 2026-11-11

### Agregado
- RF-14: reporte de días de teletrabajo (CR-014). PR #23
- RF-13: registro de periodos de teletrabajo (CR-013). PR #25, incluido en #23
- La tabla `public."Teletrabajo"` se crea con `BD/migrations/20261112_03_teletrabajo.sql` (PR #26, posterior a esta etiqueta): hasta aplicarla, RF-13 y RF-14 no pueden escribir ni consultar.

## [1.2.0] - 2026-11-11

### Agregado
- RF-18: reporte «Ausencias por periodo» con solapamiento inclusivo de fechas y filtro por motivo (CR-018). PR #22

## [1.1.0] - 2026-11-11

### Agregado
- RF-06: la licencia marcada «una vez por año» se rechaza si la persona ya tiene una del mismo motivo en el año (CR-006). PR #21
- Columna `Motivo_Perm."UnaVezPorAnio"` (migración `20261111_01`). PR #17. Ningún motivo queda marcado: activarla es un paso manual.

## [1.0.3] - 2026-11-11

### Corregido
- RF-17: los feriados se suman en el reporte general sin doble conteo (CR-017). PR #20

## [1.0.2] - 2026-11-11

### Corregido
- RF-03: no se aceptan permisos que se solapan con otro del mismo empleado, incluido el que contiene a uno existente (CR-003). PR #19
- Base compartida `RangoFechas` y `CalendarioLaboral`. PR #18

## [1.0.1] - 2026-10-19

### Corregido
- Integridad e identificadores de BD (TEC-002). PR #8
- Personal migrado visible y catálogo de áreas completo (commit `dde37f7`).

### Cambiado
- Horarios migrados a MVP y repositorio PostgreSQL, con el comportamiento conservado (TEC-001, commit `138dbce`). Integrado mediante PR #8

### Nota sobre la verificación
Las versiones 1.0.2 a 1.4.0 se etiquetaron sobre los commits de integración en el orden real de `main`.
Ninguna se compiló con `build.cmd` ni se probó con `dotnet test` sobre net48 en Windows; las pruebas de
Evelyn (RF-01/02/04/05) se ejecutaron en un arnés net8 en macOS y el resto solo con SQL en bases locales
desechables. Por eso las publicaciones de GitHub se marcan como pre-lanzamiento hasta ese QA.
RF-04 y RF-05 (PR #29) solo agregan pruebas y documentación y no cambian la versión.

## [1.0.0] - 2026-10-18

### Agregado
- Solución editable .NET Framework 4.8 recuperada de los ensamblados originales.
- Acceso a datos en PostgreSQL (Neon) mediante variables de entorno o `.env` local.
- Contraseñas de usuarios RRHH con hash PBKDF2-SHA256 y salt aleatorio.
- Suite automática con 74 métodos de prueba declarados (`[Fact]`/`[Theory]`) en `Software/RRHH.Tests`.

### Cambiado
- Refactor de feriados (TEC-003). PR #1
- Motivos de permiso (TEC-004). PR #2
- La importación biométrica escribe asistencia y marcaciones en PostgreSQL dentro de una transacción.

[Sin publicar]: https://github.com/Nidka/RRHH/compare/v1.4.0...HEAD
[1.4.0]: https://github.com/Nidka/RRHH/releases/tag/v1.4.0
[1.3.0]: https://github.com/Nidka/RRHH/releases/tag/v1.3.0
[1.2.0]: https://github.com/Nidka/RRHH/releases/tag/v1.2.0
[1.1.0]: https://github.com/Nidka/RRHH/releases/tag/v1.1.0
[1.0.3]: https://github.com/Nidka/RRHH/releases/tag/v1.0.3
[1.0.2]: https://github.com/Nidka/RRHH/releases/tag/v1.0.2
[1.0.1]: https://github.com/Nidka/RRHH/releases/tag/v1.0.1
[1.0.0]: https://github.com/Nidka/RRHH/releases/tag/v1.0.0
