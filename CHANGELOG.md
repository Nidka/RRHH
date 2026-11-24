# Changelog

Todos los cambios relevantes del sistema RRHH se documentan en este archivo.

El formato se basa en [Keep a Changelog](https://keepachangelog.com/es-ES/1.1.0/)
y el proyecto usa [Versionado Semántico](https://semver.org/lang/es/).

## [Sin publicar]

## [1.7.0] - 2026-11-23

### Agregado
- Despliegue gratuito del host web (TEC-005): `Dockerfile`, demo local con `docker-compose.demo.yml`, configuración de Render (`render.yaml`), guía en `docs/despliegue/DESPLIEGUE.md` y flujos de CI.
- `/salud` y `/salud/lista` para las sondas de la plataforma; soporte de proxy con `RRHH_WEB_TRUST_PROXY`.
- PWA instalable: manifiesto, service worker (no guarda `/api`) e íconos.
- `deploy/smoke.sh`, `deploy/aplicar-migraciones.sh` (simulación por defecto) y `deploy/generar-hash-password.py`.
- CR-019: navegación web por módulos (Gestión de turnos, Permisos y licencias, Vacaciones, Teletrabajo y presencialidad, Reportes generales y Mi cuenta), con los RF de cada pantalla visibles.
- CR-019: búsqueda de empleados por apellidos, nombres o documento (`GET /api/empleados`); reemplaza el ingreso del código interno en los formularios web. Incluye cesados, marcados como tales.
- CR-019: `GET /api/modulos`, que devuelve los módulos y pantallas habilitados para la sesión desde un catálogo único (`CatalogoModulos`).
- CR-019: `GET /api/empleados/nombres` (`ObtenerNombresEmpleados`): los reportes de teletrabajo y vacaciones muestran nombres en lugar de códigos.
- CR-019: inicio tipo panel según el rol (indicadores y gráficos de teletrabajo, ausencias y vacaciones, o el saldo propio del empleado), búsqueda rápida de pantallas (Ctrl K) y modo oscuro.
- Demo: usuario de autoconsulta `empleado` y motivo de vacaciones marcado, para mostrar RF-08, RF-10 y RF-12 con datos ficticios.

### Cambiado
- CR-019: la API web se organiza en un archivo de endpoints por módulo (`Program.cs` pasa de 301 a 57 líneas), sin cambiar rutas, contratos ni permisos.
- CR-019: la interfaz web pasa de una página con 13 secciones apiladas a módulos ES con componentes compartidos y una pantalla por archivo. Se retiran los títulos «piloto». El service worker pasa a `rrhh-web-v2` para que los navegadores reciban la interfaz nueva.
- CR-019: rediseño visual de la web: menú lateral con íconos, acceso en pantalla dividida, tarjetas, indicadores, gráficos (dona, barras, calendario y línea de tiempo), etiquetas de estado, avisos flotantes y diseño adaptable al celular. Service worker `rrhh-web-v3`.

Versión de la evaluación final: la web queda organizada por módulos, con diseño moderno para los tres roles, desplegada en Render y con trazabilidad completa (matriz de 19 CR, 147 casos y 5 refactorizaciones). Suite net8 427/427; prueba de humo correcta en producción.

## [1.6.0] - 2026-11-20

### Agregado
- Piloto web de RRHH con horarios, motivos, permisos, vacaciones, teletrabajo y reportes.
- RF-07 a RF-12: generación y saldo vacacional, truncas, media jornada, reporte y autoconsulta.
- RF-15: asistencia consolidada con una categoría por día e indicador de inconsistencias.

### Corregido
- RF-03 y RF-06: permisos por estado, salidas autorizadas y restricción anual por grupo.
- RF-17: asistencia por fecha sin duplicar el conteo.
- RF-18: exclusión de permisos anulados del reporte de ausencias, conservando el historial.

Entrega estable para el piloto de escritorio y web con datos ficticios.

## [1.5.0] - 2026-11-12

### Agregado
- RF-16: reporte «Personal en teletrabajo (total o parcial)». Clasifica a cada persona por cobertura de los días laborables del periodo (Total si teletrabaja todos, Parcial si algunos) con sus días remotos y filtro por clase (CR-016). PR #31. Completa los tres complementarios de la T3 junto con RF-17 y RF-18.

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
La v1.5.0 fue probada manualmente en Windows sobre la aplicación en ejecución, con resultado
satisfactorio, y su suite completa pasa en net8 (342 de 342 con PostgreSQL local). Las versiones
1.0.2 a 1.4.0 se etiquetaron sobre los commits de integración en el orden real de `main` y no se probaron una por una en
Windows; sus publicaciones de GitHub se marcan como pre-lanzamiento. RF-04 y RF-05 (PR #29) solo agregan pruebas y
documentación y no cambian la versión.

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

[Sin publicar]: https://github.com/Nidka/RRHH/compare/v1.7.0...HEAD
[1.7.0]: https://github.com/Nidka/RRHH/releases/tag/v1.7.0
[1.6.0]: https://github.com/Nidka/RRHH/releases/tag/v1.6.0
[1.5.0]: https://github.com/Nidka/RRHH/releases/tag/v1.5.0
[1.4.0]: https://github.com/Nidka/RRHH/releases/tag/v1.4.0
[1.3.0]: https://github.com/Nidka/RRHH/releases/tag/v1.3.0
[1.2.0]: https://github.com/Nidka/RRHH/releases/tag/v1.2.0
[1.1.0]: https://github.com/Nidka/RRHH/releases/tag/v1.1.0
[1.0.3]: https://github.com/Nidka/RRHH/releases/tag/v1.0.3
[1.0.2]: https://github.com/Nidka/RRHH/releases/tag/v1.0.2
[1.0.1]: https://github.com/Nidka/RRHH/releases/tag/v1.0.1
[1.0.0]: https://github.com/Nidka/RRHH/releases/tag/v1.0.0
