# Lista de despliegue (marcar al hacerlo)

Todo lo que se podía preparar y probar sin cuentas ya está hecho (`deploy/verificar-listo.sh --con-docker` pasa). Lo que sigue
requiere tus cuentas. Detalle de cada paso: [DESPLIEGUE.md](DESPLIEGUE.md).

## Antes de empezar (5 min)
- [ ] Cuenta en [Neon](https://neon.com) y en [Render](https://render.com) (ambas pueden crearse con GitHub, sin tarjeta).
- [ ] Equipo con `psql` y `python3` (para migraciones y claves). `psql` viene con PostgreSQL o `brew install libpq`.
- [ ] `deploy/verificar-listo.sh` en verde.

## Base de datos (Neon)
- [ ] Proyecto **nuevo y separado** de la base compartida del equipo. Región cercana a la de Render.
- [ ] Copiar la cadena de conexión de Neon (la guarda solo en tu terminal: `export DATABASE_URL='postgresql://...sslmode=require'`).
- [ ] `deploy/aplicar-migraciones.sh` (simulación) → debe conectar y mostrar el plan.
- [ ] Rama de respaldo en Neon (aunque la base sea nueva).
- [ ] `deploy/aplicar-migraciones.sh --aplicar --confirmo-respaldo --restaurar-esquema` (base vacía).
- [ ] Crear los usuarios y sus roles en `Persona`/`Empleado`/`Rol`/`Usuario`/`Usuario_Rol` y fijar cada clave con
      `python3 deploy/generar-hash-password.py LOGIN | psql "$DATABASE_URL"`.

## Servicio web (Render)
- [ ] **New → Blueprint** → este repositorio → lee `render.yaml`.
- [ ] Pegar los valores secretos (ver `deploy/web.env.example`):

| Variable | Valor |
|---|---|
| `RRHH_WEB_POSTGRES` | `Host=<host de Neon>;Port=5432;Database=<base>;Username=<usuario>;Password=<clave>;SSL Mode=Require;Trust Server Certificate=true` |
| `RRHH_WEB_ROLES` | IDs de rol de los operadores, por ejemplo `10` |
| `RRHH_WEB_ROLES_AUSENCIAS`, `_HORARIOS`, `_MOTIVOS`, `_ASISTENCIA`, `_VACACIONES`, `_PERMISOS` | los mismos IDs (deben estar en `RRHH_WEB_ROLES`); vacío = módulo apagado |

- [ ] Esperar el primer build (5 a 10 min) hasta «Live».

## Verificación y cierre
- [ ] `deploy/smoke.sh https://<tu-servicio>.onrender.com --solo-salud` → «PRUEBA DE HUMO CORRECTA».
- [ ] Abrir la URL, iniciar sesión y recorrer un módulo (teletrabajo, permisos).
- [ ] Probar «Instalar» en Chrome o en el celular.
- [ ] Anotar la URL y la versión desplegada (SHA) en el informe de la evaluación final.

## Opcional
- [ ] Integración continua: con `gh auth refresh -h github.com -s workflow`, copiar las plantillas:
      `mkdir -p .github/workflows && cp deploy/ci/*.yml .github/workflows/` y abrir un PR.
- [ ] Activar `autoDeploy: true` en `render.yaml` si quieres que cada merge a `main` redespliegue.

## Límites que conviene recordar
- Render gratis se duerme a los ~15 min sin visitas (la primera visita tarda 30 a 60 s) y las sesiones se pierden al reiniciar.
- Neon gratis: 1 GB; cómputo suspendido cuando no se usa.
- Antes de datos reales: ver «Antes de usar datos reales» en DESPLIEGUE.md.
