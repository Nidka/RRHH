# CR-019: evidencias

Todas las pruebas usan solo datos ficticios: PostgreSQL 18 local desechable con la base de demostración (`deploy/demo/fixture.sql` y migraciones del piloto). Entorno: macOS arm64 y .NET SDK 8.0. Fecha: 23/11/2026.

**Método común.** Antes de cada corrida se recrea la base y se arranca el servidor desde cero. Si se recrea la base con el servidor en marcha, la primera consulta usa una conexión ya cerrada del pool y responde 500; esto ocurre igual en `7731ca2` y no es efecto del cambio. En las comparaciones se normaliza solo `fechaRegistro`, que depende de la hora.

## Entrega 2: diseño moderno, nombres en reportes y rol de empleado (rama `feature/cr-019-diseno-moderno`)

### Caracterización de la API frente a `main` (`78cedba`)

Las dos versiones se recorrieron con [caracterizar.sh](caracterizar.sh) sobre la misma base de demostración actualizada. El recorrido cubre el operador, `sin_permiso`, `solo_teletrabajo` y el nuevo usuario `empleado`.

| Archivo | Contenido |
|---|---|
| [api-diseno-antes-78cedba.txt](api-diseno-antes-78cedba.txt) | Respuestas de `main` en `78cedba` |
| [api-diseno-despues.txt](api-diseno-despues.txt) | Respuestas con esta entrega |
| [api-diseno-diferencias.txt](api-diseno-diferencias.txt) | `diff` entre ambas |

**Resultado: 73 de 77 respuestas idénticas.** Las 4 diferencias son solo de la ruta nueva `GET /api/empleados/nombres`:
- sin sesión responde 401;
- con sesión de operador devuelve los nombres;
- omite los códigos que no existen;
- rechaza un código no numérico con 400 y un mensaje claro.

También pasaron `deploy/smoke.sh` completo (**PRUEBA DE HUMO CORRECTA**), `deploy/verificar-listo.sh` y la suite net8 (**424/424**).

### Recorrido de la interfaz en Chrome

Se ejecutó [recorrido-web.mjs](recorrido-web.mjs) con Playwright y Google Chrome sin interfaz. Resultado completo en [recorrido-web-resultado.txt](recorrido-web-resultado.txt).

**Resultado: 61 de 61 verificaciones correctas y ningún error de JavaScript ni de la política de seguridad de contenido.** Cubre:
- **Acceso:** rechazo de credenciales erróneas, ruta inexistente y cierre de sesión.
- **Operador:**
  - ve cinco módulos en el orden del enunciado y sus 14 pantallas, que abren sin error;
  - el inicio muestra 3 indicadores y 2 gráficos;
  - ningún texto dice «piloto».
- **Reglas en pantalla:**
  - RF-01: alta, línea de tiempo, edición y rechazo por solapamiento.
  - RF-02: histórico.
  - RF-03: rechazo de dos permisos el mismo día.
  - RF-04 y RF-05: alta y baja de motivo.
  - RF-07: 60 días generados.
  - RF-08: 59,5 pendientes después de la media jornada.
  - RF-09: 21,67 días truncos.
  - RF-10: media jornada aprobada.
  - RF-11: reporte con nombres.
  - RF-13: patrón Lun, Mié y rechazo por solapamiento.
  - RF-14: un día, porque el 11/11 es feriado.
  - RF-15: calendario de 30 días.
  - RF-16: Parcial, con 1 de 4 días.
  - RF-17: total computado.
  - RF-18: ausencias con nombre.
- **`solo_teletrabajo`:** ve solo sus 3 pantallas y un indicador en el inicio, y no abre vacaciones ni por enlace directo.
- **`empleado` (autoconsulta):**
  - entra directo a «Mis vacaciones» y ve solo «Mi cuenta»;
  - ve su propia media jornada usada (RF-12);
  - no abre pantallas de operador.
- **Búsqueda rápida y tema:** Ctrl+K abre una pantalla; el modo oscuro se conserva al recargar.
- **Celular (390 px):** el menú empieza oculto, el botón lo abre y elegir una pantalla lo cierra.

Capturas en [capturas-web/](capturas-web/), incluidas el modo oscuro, el rol empleado y el celular.

## Entrega 1: API y navegación por módulos (PR #76)

### Caracterización de la API frente a `7731ca2`

| Archivo | Contenido |
|---|---|
| [api-antes-7731ca2.txt](api-antes-7731ca2.txt) | Respuestas de `main` en `7731ca2`, antes del cambio |
| [api-despues.txt](api-despues.txt) | Respuestas con los endpoints reorganizados por módulo |
| [api-diferencias.txt](api-diferencias.txt) | `diff` entre ambas |

**Resultado: 61 de 67 respuestas idénticas.** Las 6 diferencias son solo de las rutas nuevas `GET /api/modulos` y `GET /api/empleados`:
- sin sesión, antes daban 404 y ahora 401;
- con `operador`, devuelven sus cinco módulos y los empleados ficticios;
- con `solo_teletrabajo`, `/api/modulos` devuelve solo Teletrabajo y presencialidad.

`deploy/smoke.sh` completo: correcto.

### Recorrido de la interfaz (diseño anterior)

En aquella entrega fueron 44 de 44 verificaciones.

**Corrección:** esta ficha decía que «se abren las 15 pantallas». En realidad el operador abrió sus 14 pantallas; la 15.ª, «Mis vacaciones», pertenece al rol de empleado y no se recorrió en esa entrega. La entrega 2 sí la recorre con el usuario `empleado`. El script y las capturas de esa versión quedan en el historial de Git (`9516ec6`).
