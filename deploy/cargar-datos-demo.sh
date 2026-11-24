#!/usr/bin/env bash
# Carga los datos FICTICIOS de demostración (deploy/demo/datos-demo-despliegue.sql) en la base de la web desplegada.
# Por defecto solo MUESTRA lo que hay y lo que haría. Para ejecutar hace falta --aplicar y --confirmo-respaldo.
#
#   DATABASE_URL='postgresql://usuario:clave@host/base?sslmode=require' deploy/cargar-datos-demo.sh
#   DATABASE_URL=... deploy/cargar-datos-demo.sh --aplicar --confirmo-respaldo
#
# Requisitos: la base ya tiene el esquema y las migraciones (deploy/aplicar-migraciones.sh).
# Seguridad: se niega a cargar si la base parece tener datos reales (más de 20 empleados fuera del rango 9101-9199),
# salvo que se agregue --base-con-datos. Solo escribe y borra filas propias del rango 9101-9199; no toca usuarios ni claves.
# Es idempotente: ejecutarlo de nuevo deja los mismos datos. La clave de DATABASE_URL nunca se imprime.
set -euo pipefail
cd "$(dirname "$0")/.."

APLICAR=0; RESPALDO=0; CON_DATOS=0
for arg in "$@"; do
    case "$arg" in
        --aplicar) APLICAR=1 ;;
        --confirmo-respaldo) RESPALDO=1 ;;
        --base-con-datos) CON_DATOS=1 ;;
        *) echo "Opción desconocida: $arg" >&2; exit 2 ;;
    esac
done
: "${DATABASE_URL:?Defina DATABASE_URL con la cadena de conexión de la base destino}"
command -v psql >/dev/null || { echo "Falta psql (cliente de PostgreSQL)." >&2; exit 2; }

destino="$(sed -E 's#^[a-z]+://([^:@/]+)(:[^@]*)?@#\1@#' <<<"$DATABASE_URL")"
consulta() { psql "$DATABASE_URL" -X -q -t -A -v ON_ERROR_STOP=1 -c "$1"; }

echo "Destino: $destino"
faltan="$(consulta "SELECT string_agg(x, ', ') FROM (VALUES
  ('Teletrabajo', to_regclass('public.\"Teletrabajo\"') IS NOT NULL),
  ('EsVacacionesPiloto', EXISTS (SELECT 1 FROM information_schema.columns WHERE table_schema='public' AND table_name='Motivo_Perm' AND column_name='EsVacacionesPiloto')),
  ('EstadoSolicitud', EXISTS (SELECT 1 FROM information_schema.columns WHERE table_schema='public' AND table_name='Permiso' AND column_name='EstadoSolicitud'))
) AS t(x, ok) WHERE NOT ok;")"
if [[ -n "$faltan" ]]; then
    echo "Faltan migraciones ($faltan). Ejecute antes deploy/aplicar-migraciones.sh." >&2; exit 1
fi

ajenos="$(consulta 'SELECT COUNT(DISTINCT "IdEmpleado") FROM public."Empleado" WHERE "IdEmpleado" NOT BETWEEN 9101 AND 9199;')"
propios="$(consulta 'SELECT COUNT(DISTINCT "IdEmpleado") FROM public."Empleado" WHERE "IdEmpleado" BETWEEN 9101 AND 9199;')"
echo "Empleados existentes fuera de la demo: $ajenos · empleados de la demo ya cargados: $propios"
if [[ "$ajenos" -gt 20 && $CON_DATOS -eq 0 ]]; then
    echo "La base parece tener datos reales. No se cargan datos ficticios ahí. Use una base separada para la demo," >&2
    echo "o, si está seguro, repita con --base-con-datos." >&2; exit 1
fi

if [[ $APLICAR -eq 0 ]]; then
    echo "Plan: cargar 12 empleados ficticios (9101-9112), áreas, horarios, turnos, motivos, permisos, teletrabajo,"
    echo "feriados de 2008 y 2026 que falten y marcaciones. Repita con --aplicar --confirmo-respaldo para ejecutarlo."
    exit 0
fi
[[ $RESPALDO -eq 1 ]] || { echo "Confirme que tiene un respaldo o una rama de Neon con --confirmo-respaldo." >&2; exit 2; }

psql "$DATABASE_URL" -X -q -v ON_ERROR_STOP=1 -f deploy/demo/datos-demo-despliegue.sql
consulta 'SELECT format($$Cargado: %s empleados, %s permisos, %s periodos de teletrabajo, %s marcaciones, %s feriados en total.$$,
  (SELECT COUNT(*) FROM public."Empleado" WHERE "IdEmpleado" BETWEEN 9101 AND 9199),
  (SELECT COUNT(*) FROM public."Permiso" WHERE "IdEmpleado" BETWEEN 9101 AND 9199),
  (SELECT COUNT(*) FROM public."Teletrabajo" WHERE "IdEmpleado" BETWEEN 9101 AND 9199),
  (SELECT COUNT(*) FROM public."Asistencia" WHERE "IdEmpleado" BETWEEN 9101 AND 9199),
  (SELECT COUNT(*) FROM public."RRHH_Feriado"));'
