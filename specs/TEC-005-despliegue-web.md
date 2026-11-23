# TEC-005: despliegue gratuito del host web

- Estado: implementado en la rama `feature/web-despliegue`; probado localmente con Docker (ver «Verificación»). Falta publicarlo en Render y Neon, que requieren las cuentas del equipo.
- Tarea: infraestructura de la versión web (`RRHH.Web`, v1.6.0). Sin cambio de reglas de negocio.
- Versión propuesta: MINOR (1.7.0): agrega capacidad de despliegue y PWA instalable.

## Problema

La web solo se ejecutaba con `dotnet run` y una base local de QA. No había imagen de contenedor, comprobación de salud, manejo de proxy, PWA instalable, ni forma repetible de aplicar migraciones o crear claves en una base remota.

## Alcance

| Archivo | Cambio |
|---|---|
| `Dockerfile`, `.dockerignore` | Imagen multi-etapa con solo los proyectos que compila la web; usuario sin privilegios; puerto desde `PORT`. |
| `Software/RRHH.Web/Program.cs`, `CompositionRoot.cs` | `/salud` y `/salud/lista`; cabeceras reenviadas con `RRHH_WEB_TRUST_PROXY`; sin redirección HTTPS en las sondas; `no-cache` para service worker y manifiesto. |
| `wwwroot/manifest.webmanifest`, `service-worker.js`, `pwa.js`, íconos, `index.html` | PWA instalable. El service worker no guarda `/api` ni `/salud`. |
| `docker-compose.demo.yml`, `deploy/demo/*` | Demo local completa con datos ficticios y clave elegida por quien la levanta. |
| `deploy/smoke.sh` | Recorrido HTTP: salud, protección sin sesión, login (incluidos rechazos), alta y rechazo de solapamiento, reportes, cierre de sesión. |
| `deploy/aplicar-migraciones.sh`, `deploy/generar-hash-password.py` | Migraciones con modo simulación por defecto y confirmación de respaldo; hash PBKDF2 sin guardar la clave. |
| `render.yaml`, `deploy/web.env.example`, `docs/despliegue/DESPLIEGUE.md` | Configuración de Render y guía. |
| `deploy/ci/ci.yml`, `imagen.yml` | Plantillas de CI y de publicación de imagen (se copian a `.github/workflows/`; no se subieron ahí por falta de permiso `workflow`). Nunca ejecutadas. |
| `deploy/verificar-listo.sh`, `docs/despliegue/CHECKLIST.md` | Verificación previa en un comando y lista de despliegue. |

## Decisiones

- **Render + Neon** por ser la combinación gratuita que ejecuta Docker/.NET sin tarjeta según las fuentes consultadas el 23/11/2026; los límites cambian y deben revisarse en las páginas oficiales.
- La sonda de Render usa `/salud` (sin base) para que un corte de Neon no reinicie el servicio.
- Las sesiones no sobreviven a un reinicio (claves de protección de datos en memoria). Se acepta en el piloto y se documenta.
- Ninguna migración se aplica a la base compartida desde este cambio; el script exige `--aplicar --confirmo-respaldo`.

## Verificación

Ejecutado el 23/11/2026 en Docker Desktop (arm64) con la imagen final y PostgreSQL 16 con datos ficticios:

| Prueba | Resultado |
|---|---|
| `deploy/smoke.sh` completo (22 comprobaciones) | Correcto |
| Imagen en `Production` + `RRHH_WEB_TRUST_PROXY=true` + `PORT=10000`, `--solo-salud` | Correcto; contenedor `healthy`; usuario `app` sin privilegios |
| Cookie de sesión tras proxy HTTPS | `secure; samesite=strict; httponly` |
| Base detenida | `/salud` 200 y `/salud/lista` 503 con el motivo en el registro |
| `deploy/verificar-listo.sh --con-docker` | Correcto (incluye prueba negativa del detector de secretos) |
| Base vacía → `aplicar-migraciones.sh --restaurar-esquema` → repetir | 105 tablas y 7 migraciones, idempotente; sin `--confirmo-respaldo` se niega; sin esquema aborta |
| Usuario nuevo → `generar-hash-password.py` → login web | Clave mala 401, clave nueva 204; rechaza claves de menos de 12 caracteres |
| Hallazgo | `BD/schema.sql` trae `transaction_timeout` de PostgreSQL 18: el script lo filtra para 14 a 18 |
| Hallazgo | `20261119_01` exige la PK de `Motivo_Perm` (TEC-002): el script la incluye con `--restaurar-esquema` |
| Hallazgo | El primer intento de la demo tomó `DB_PASSWORD` del entorno del equipo; se separó a `DEMO_DB_PASSWORD` |

**No ejecutado:** despliegue real en Render ni conexión a Neon (requieren las cuentas del equipo); los flujos de GitHub Actions (solo se validó su YAML); la suite de escritorio (este cambio no toca esos proyectos).

## Reversión

Revertir el PR: elimina archivos nuevos y los tres cambios pequeños de `Program.cs`, `CompositionRoot.cs` e `index.html`. No cambia esquema ni datos.
