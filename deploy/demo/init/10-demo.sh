#!/bin/bash
# Se ejecuta una sola vez al crear el volumen de la base de demostración (docker-entrypoint-initdb.d).
# Carga datos ficticios y aplica las migraciones del piloto. Nunca usar con datos reales.
set -euo pipefail
: "${DEMO_PASSWORD:?Defina DEMO_PASSWORD (clave de los usuarios ficticios)}"

salt_b64="$(openssl rand -base64 16)"
salt_hex="$(printf '%s' "$salt_b64" | base64 -d | od -An -tx1 | tr -d ' \n')"
hash_b64="$(openssl kdf -keylen 32 -kdfopt digest:SHA256 -kdfopt "pass:${DEMO_PASSWORD}" \
    -kdfopt "hexsalt:${salt_hex}" -kdfopt iter:210000 -binary PBKDF2 | base64 -w0)"

psql -X -v ON_ERROR_STOP=1 -v hash="$hash_b64" -v salt="$salt_b64" \
    --username "$POSTGRES_USER" --dbname "$POSTGRES_DB" -f /deploy/fixture.sql

for migracion in 20261112_03_teletrabajo 20261111_01_licencia_una_vez_anio 20261119_01_grupo_licencia_anual \
    20261119_02_estados_permiso 20261119_03_vacaciones_piloto; do
    psql -X -v ON_ERROR_STOP=1 --username "$POSTGRES_USER" --dbname "$POSTGRES_DB" -f "/migraciones/${migracion}.sql"
done
echo "Demo lista: usuarios ficticios operador, sin_permiso, solo_teletrabajo y empleado (autoconsulta)."
