# Despliegue gratuito del host web de RRHH

Guía para publicar `Software/RRHH.Web` como una página accesible desde el navegador y el celular, sin costo.
Combina **Render** (el servicio web, desde el `Dockerfile` del repositorio) con **Neon** (PostgreSQL).

> Alcance: piloto académico. La web maneja permisos, asistencia y vacaciones de personas. Antes de cargar datos reales
> lea la sección [Antes de usar datos reales](#antes-de-usar-datos-reales).

## Arquitectura

```
Navegador / celular (PWA)  ──HTTPS──►  Render (contenedor RRHH.Web, .NET 8)  ──TLS──►  Neon (PostgreSQL)
```

- El navegador solo ve la API del host (`/api/...`). Las reglas viven en los casos de uso de T3; el SQL va parametrizado.
- Sesión por cookie `HttpOnly`, `SameSite=Strict`, `Secure`; escrituras protegidas con token antifalsificación; límite de 10 intentos de login por minuto por IP.
- `/salud` responde si el proceso está vivo. `/salud/lista` además comprueba la base (503 si no responde; el registro dice solo el tipo de error, nunca el mensaje, porque el de Npgsql puede incluir la cadena de conexión).
- HTTPS: el contenedor escucha HTTP; **Render termina TLS en su borde** y reenvía `X-Forwarded-Proto`. La cookie de sesión es `Secure`, así que la web solo inicia sesión por HTTPS.

## Qué es gratis y qué limitaciones tiene

| Pieza | Plan | Límites relevantes (verifique en la página oficial antes de depender de ellos) |
|---|---|---|
| Render | Web service gratuito, ejecución desde Docker | 512 MB de RAM; **se duerme tras unos 15 min sin visitas** y la primera visita tarda ~30–60 s en despertarlo; horas mensuales limitadas |
| Neon | Plan Free | 1 GB por proyecto; horas de cómputo limitadas; el cómputo se suspende cuando no se usa; sin cobro por exceso (las escrituras fallan al llenarse) |

Consecuencias: la primera pantalla puede tardar al despertar; **al reiniciarse el contenedor las sesiones se cierran** (las claves de la sesión no se persisten) y
hay que volver a iniciar sesión. Para un piloto es aceptable. Para uso continuo, un plan de pago o un VPS evitan ambas cosas.

## Paso a paso

Versión resumida para marcar: [CHECKLIST.md](CHECKLIST.md). Antes de empezar, `deploy/verificar-listo.sh` (o con `--con-docker`) comprueba que todo está en orden.

### 1. Probar todo localmente (sin Neon, sin Render)

```bash
DEMO_PASSWORD='elija-una-clave' docker compose -f docker-compose.demo.yml up --build
# Nota: en macOS, Docker Desktop puede negar montar carpetas dentro de ~/Downloads; copie el repo a otra ruta (p. ej. /tmp) si ve «operation not permitted».
# en otra terminal:
DEMO_PASSWORD='elija-una-clave' deploy/smoke.sh http://127.0.0.1:8080
```

Abra `http://127.0.0.1:8080`, usuario `operador` y la clave elegida. La base de la demo tiene solo datos ficticios.

### 2. Crear la base en Neon

1. Cree un proyecto en [Neon](https://neon.com) (región cercana a la de Render).
2. **Recomendado:** use una base **separada** de la compartida del equipo (otro proyecto, o una rama de Neon). La web escribe permisos, motivos y turnos.
3. Si es una base nueva y vacía, el paso 3 puede restaurar el esquema base con `--restaurar-esquema` (BD/schema.sql se exportó con PostgreSQL 18; el script quita las líneas que versiones menores no entienden).
4. Si es una copia de la base compartida, **cree antes una rama de respaldo en Neon**.

### 3. Aplicar las migraciones

```bash
export DATABASE_URL='postgresql://USUARIO:CLAVE@HOST/BASE?sslmode=require'
deploy/aplicar-migraciones.sh                                  # solo muestra el plan y comprueba la conexión
deploy/aplicar-migraciones.sh --aplicar --confirmo-respaldo    # aplica (base ya restaurada)
deploy/aplicar-migraciones.sh --aplicar --confirmo-respaldo --restaurar-esquema   # base nueva y vacía
```

Aplica `BD/password-auth.sql` y las migraciones de teletrabajo, licencia anual, grupo anual, estados de permiso y vacaciones. Son idempotentes.
**Dependencia importante:** la migración `20261119_01` exige la clave primaria de `Motivo_Perm`, que crea la migración de integridad (TEC-002).
- Base nueva y vacía: use `--restaurar-esquema` (incluye TEC-002 automáticamente; sin datos no hay duplicados).
- Copia de la base compartida: tiene filas duplicadas (Horario, RRHH_Feriado, TipoPermiso y Motivo_Perm). **Primero sanee una copia** (`BD/tests/sanear_copias_exactas_qa.sql`, ver `BD/tests/README.md`), compruebe, y luego aplique con `--incluir-integridad`. Si la base ya tiene esas claves, no hace falta.

### 4. Crear las claves de los usuarios

```bash
python3 deploy/generar-hash-password.py NOMBRE_DE_USUARIO | psql "$DATABASE_URL"
```

Pide la clave por teclado (mínimo 12 caracteres) y actualiza `public."Usuario"`. El usuario ya debe existir con su rol (`Usuario_Rol`) y su empleado.

### 5. Desplegar en Render

1. En Render: **New → Blueprint** y elija este repositorio. Lee `render.yaml`.
2. Cuando pida los valores secretos, copie los de `deploy/web.env.example`:
   - `RRHH_WEB_POSTGRES`: cadena de Neon en formato Npgsql, con `SSL Mode=Require;Trust Server Certificate=true`.
   - `RRHH_WEB_ROLES` y las variables por módulo: los `IdRol` autorizados.
3. Espere a que termine el build (primera vez ~5–10 min) y abra la URL `https://rrhh-web-XXXX.onrender.com`.

### 6. Verificar

```bash
deploy/smoke.sh https://rrhh-web-XXXX.onrender.com --solo-salud
```

Comprueba salud, base de datos, rechazo sin sesión y encabezados de seguridad. Luego inicie sesión desde el navegador y recorra un módulo.

### 6.1. Cargar datos de demostración (opcional)

Una base nueva no tiene empleados, así que las pantallas se ven vacías. Para la demostración se cargan datos **ficticios**:

```bash
deploy/cargar-datos-demo.sh                                   # muestra qué hay y qué haría
deploy/cargar-datos-demo.sh --aplicar --confirmo-respaldo     # carga los datos
```

Carga [deploy/demo/datos-demo-despliegue.sql](../../deploy/demo/datos-demo-despliegue.sql):
- 12 empleados ficticios (códigos 9101 a 9112, documentos `DEMO-…`) en 4 áreas;
- 3 horarios, turnos por periodo con histórico, 6 motivos y 13 permisos en sus cuatro estados, incluida una media jornada;
- 4 periodos de teletrabajo (1 total y 3 parciales);
- feriados nacionales de 2008 y 2026, si no existen;
- marcaciones de octubre y noviembre de 2026, y de febrero y marzo de 2008 para la consulta histórica.

Es idempotente: solo borra y recrea sus propias filas (rango 9101 a 9199) y no toca usuarios ni claves. Se niega a cargar si la base
tiene más de 20 empleados ajenos a la demo, porque probablemente son datos reales. Para que un usuario de autoconsulta vea sus
vacaciones, vincúlelo a uno de estos empleados (`Usuario.IdEmpleado`) y dele una clave con el paso 4.

### 7. Instalarla como aplicación

En Chrome/Edge (escritorio o Android) aparece «Instalar». En iPhone: Compartir → «Añadir a pantalla de inicio». La instalación guarda solo la estructura
de la página; los datos se piden siempre al servidor y no se guardan sin conexión.

## Integración continua

Las plantillas están en `deploy/ci/` (no en `.github/workflows/`, porque subirlas exige el permiso `workflow` del token). Para activarlas:
`gh auth refresh -h github.com -s workflow && mkdir -p .github/workflows && cp deploy/ci/*.yml .github/workflows/`. Nunca se han ejecutado en GitHub.

- `ci.yml` en cada PR: pruebas de escritorio (net48) en Windows, y en Ubuntu compila la imagen, levanta la demo y ejecuta `deploy/smoke.sh`.
- `imagen.yml` al crear una etiqueta `vX.Y.Z`: publica `ghcr.io/<usuario>/rrhh-web:X.Y.Z`.

## Antes de usar datos reales

- El repositorio es público; ninguna cadena de conexión ni clave está en él. No las agregue.
- Use HTTPS siempre (Render lo ofrece) y mantenga `RRHH_WEB_TRUST_PROXY=true` solo detrás del proxy de la plataforma.
- No dé rol de operador a cuentas de autoservicio: pueden gestionar datos de otros empleados.
- Las reglas del piloto (régimen de vacaciones, criterio de teletrabajo total/parcial) son decisiones académicas; confírmelas con el área usuaria antes de operar.
- Configure copias de seguridad (ramas/restauración a un punto en Neon) y revise quién tiene acceso a la base.
