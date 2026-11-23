#!/usr/bin/env bash
# Aplica a una base PostgreSQL (Neon u otra) las migraciones que necesita el host web.
# Por defecto solo MUESTRA el plan. Para ejecutar hace falta --aplicar y --confirmo-respaldo.
#
#   DATABASE_URL='postgresql://usuario:clave@host/base?sslmode=require' deploy/aplicar-migraciones.sh
#   DATABASE_URL=... deploy/aplicar-migraciones.sh --aplicar --confirmo-respaldo
#
# Opciones:
#   --restaurar-esquema    si la base está vacía, restaura primero BD/schema.sql (105 tablas). Quita las líneas que solo
#                          entiende PostgreSQL 18 (transaction_timeout, \restrict) para que funcione en 14 a 18.
#   --incluir-integridad   agrega TEC-002 (lo implica --restaurar-esquema). OBLIGATORIO si la base aún no tiene la clave primaria
#                          de Motivo_Perm: la migración 20261119_01 la exige. En la base compartida, que tiene filas duplicadas,
#                          primero hay que sanear una COPIA (BD/tests/sanear_copias_exactas_qa.sql); agrega TEC-002 (claves, identidades y FK). Requiere haber saneado antes los duplicados
#                          (BD/tests/sanear_copias_exactas_qa.sql) en una copia: aborta si encuentra duplicados.
# Todas las migraciones son idempotentes y transaccionales. La clave de DATABASE_URL nunca se imprime.
set -euo pipefail
cd "$(dirname "$0")/.."

APLICAR=0; RESPALDO=0; INTEGRIDAD=0; ESQUEMA=0
for arg in "$@"; do
    case "$arg" in
        --aplicar) APLICAR=1 ;;
        --confirmo-respaldo) RESPALDO=1 ;;
        --incluir-integridad) INTEGRIDAD=1 ;;
        --restaurar-esquema) ESQUEMA=1 ;;
        *) echo "Opción desconocida: $arg" >&2; exit 2 ;;
    esac
done
: "${DATABASE_URL:?Defina DATABASE_URL con la cadena de conexión de la base destino}"
command -v psql >/dev/null || { echo "Falta psql (cliente de PostgreSQL)." >&2; exit 2; }

destino="$(sed -E 's#^[a-z]+://([^:@/]+)(:[^@]*)?@#\1@#' <<<"$DATABASE_URL")"
[[ $ESQUEMA -eq 1 ]] && INTEGRIDAD=1
archivos=(BD/password-auth.sql)
[[ $INTEGRIDAD -eq 1 ]] && archivos+=(BD/migrations/20261018_02_integrity_ids.sql)
archivos+=(
    BD/migrations/20261112_03_teletrabajo.sql
    BD/migrations/20261111_01_licencia_una_vez_anio.sql
    BD/migrations/20261119_01_grupo_licencia_anual.sql
    BD/migrations/20261119_02_estados_permiso.sql
    BD/migrations/20261119_03_vacaciones_piloto.sql
)

echo "Destino: $destino"
echo "Plan (en este orden):"; printf '  - %s\n' "${archivos[@]}"
psql "$DATABASE_URL" -X -At -c "SELECT 'Conexión correcta a la base «' || current_database() || '», PostgreSQL ' || current_setting('server_version')" \
    || { echo "No se pudo conectar. Revise DATABASE_URL (en Neon: sslmode=require)." >&2; exit 1; }
tiene_esquema() { [[ "$(psql "$DATABASE_URL" -X -At -c "SELECT to_regclass('public.\"Usuario\"') IS NOT NULL")" == "t" ]]; }
if tiene_esquema; then echo "Esquema base presente (public.\"Usuario\")."
elif [[ $ESQUEMA -eq 1 ]]; then echo "Esquema base ausente: se restaurará BD/schema.sql (--restaurar-esquema)."
else echo "ATENCIÓN: la base no tiene el esquema base. Use --restaurar-esquema (base nueva y vacía) o restaure BD/schema.sql." ; FALTA_ESQUEMA=1; fi

if [[ $APLICAR -eq 0 ]]; then echo; echo "Simulación: no se aplicó nada. Agregue --aplicar --confirmo-respaldo para ejecutar."; exit 0; fi
if [[ $RESPALDO -eq 0 ]]; then echo "Falta --confirmo-respaldo: confirme que existe un respaldo o una rama de Neon antes de modificar la base." >&2; exit 3; fi

if ! tiene_esquema; then
    if [[ $ESQUEMA -eq 1 ]]; then
        echo ">> BD/schema.sql (compatible con PostgreSQL 14 a 18)"
        sed -E '/^SET transaction_timeout/d;/^\\(un)?restrict /d' BD/schema.sql | psql "$DATABASE_URL" -X -q -v ON_ERROR_STOP=1 >/dev/null
    else
        echo "No se aplicó nada: falta el esquema base. Reintente con --restaurar-esquema si la base es nueva." >&2; exit 4
    fi
fi
for archivo in "${archivos[@]}"; do
    echo ">> $archivo"
    psql "$DATABASE_URL" -X -v ON_ERROR_STOP=1 -q -f "$archivo"
done
echo "Migraciones aplicadas."
