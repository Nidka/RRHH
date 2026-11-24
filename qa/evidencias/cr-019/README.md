# CR-019: evidencias

## Caracterización de la API web (reorganización por módulos)

Fecha: 23/11/2026. Entorno: macOS arm64, .NET SDK 8.0, PostgreSQL 18 local desechable con la base de demostración (`deploy/demo/fixture.sql` y migraciones del piloto). Solo datos ficticios.

**Método.** Se recorrieron las rutas de la API con [caracterizar.sh](caracterizar.sh): casos válidos, errores de validación, rutas protegidas sin sesión y los roles `operador`, `sin_permiso` y `solo_teletrabajo`. Antes de cada corrida se recreó la base y se arrancó el servidor desde cero. Se normalizó solo `fechaRegistro`, que depende de la hora.

| Archivo | Contenido |
|---|---|
| [api-antes-7731ca2.txt](api-antes-7731ca2.txt) | Respuestas de `main` en `7731ca2`, antes del cambio |
| [api-despues.txt](api-despues.txt) | Respuestas con los endpoints reorganizados por módulo |
| [api-diferencias.txt](api-diferencias.txt) | `diff` entre ambas |

**Resultado.** 61 de 67 respuestas son idénticas. Las 6 diferencias corresponden solo a las rutas nuevas:

- `GET /api/modulos` y `GET /api/empleados` sin sesión: antes 404 (no existían), ahora 401.
- Con `operador`: `/api/modulos` devuelve sus cinco módulos y `/api/empleados?texto=fic` devuelve los empleados ficticios.
- Con `solo_teletrabajo`: `/api/modulos` devuelve solo Teletrabajo y presencialidad, sin la pantalla de presencialidad (no tiene el permiso de asistencia).

Además, `deploy/smoke.sh` completo contra la versión nueva: **PRUEBA DE HUMO CORRECTA**.

**Observación del procedimiento.** Si se recrea la base con el servidor en marcha, la primera consulta usa una conexión ya cerrada del pool y responde 500. Ocurre igual en `7731ca2`, así que no es efecto del cambio; por eso el método arranca el servidor después de recrear la base.
