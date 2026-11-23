#!/usr/bin/env bash
# Prueba de humo del host web desplegado (contenedor o plataforma).
#   DEMO_PASSWORD='<clave>' deploy/smoke.sh [URL]            # recorrido completo con la base de demostración
#   deploy/smoke.sh [URL] --solo-salud                      # solo salud y rechazo sin sesión (sirve contra producción)
# Con la demo, el usuario ficticio es «operador». Sale con código distinto de 0 al primer fallo.
set -uo pipefail
URL="${1:-http://127.0.0.1:8080}"; URL="${URL%/}"
SOLO_SALUD=0; [[ "${2:-}" == "--solo-salud" || "${1:-}" == "--solo-salud" ]] && SOLO_SALUD=1
[[ "$URL" == "--solo-salud" ]] && URL="http://127.0.0.1:8080"
JAR="$(mktemp)"; trap 'rm -f "$JAR"' EXIT
fallos=0
codigo() { curl -s -o /dev/null -w '%{http_code}' "$@"; }
verificar() { # descripción, esperado, obtenido
    if [[ "$2" == "$3" ]]; then echo "  ok   $1 ($3)"; else echo "  FALLA $1: se esperaba $2 y se obtuvo $3"; fallos=$((fallos+1)); fi
}

echo "Esperando a $URL ..."
for _ in $(seq 1 60); do [[ "$(codigo "$URL/salud")" == "200" ]] && break; sleep 2; done

echo "Salud y protección sin sesión"
verificar "/salud (proceso vivo)" 200 "$(codigo "$URL/salud")"
verificar "/salud/lista (base de datos)" 200 "$(codigo "$URL/salud/lista")"
verificar "página principal" 200 "$(codigo "$URL/")"
verificar "manifiesto PWA" 200 "$(codigo "$URL/manifest.webmanifest")"
verificar "service worker" 200 "$(codigo "$URL/service-worker.js")"
verificar "/api/sesion sin iniciar sesión" 401 "$(codigo "$URL/api/sesion")"
verificar "/api/periodos sin iniciar sesión" 401 "$(codigo "$URL/api/periodos?empleado=101")"
encabezados="$(curl -s -D - -o /dev/null "$URL/")"
grep -qi '^content-security-policy:' <<<"$encabezados" && echo "  ok   encabezado Content-Security-Policy" || { echo "  FALLA falta Content-Security-Policy"; fallos=$((fallos+1)); }
grep -qi '^x-content-type-options: *nosniff' <<<"$encabezados" && echo "  ok   encabezado X-Content-Type-Options" || { echo "  FALLA falta X-Content-Type-Options"; fallos=$((fallos+1)); }

if [[ $SOLO_SALUD -eq 0 ]]; then
    : "${DEMO_PASSWORD:?Defina DEMO_PASSWORD para el recorrido completo}"
    token() { curl -s -b "$JAR" -c "$JAR" "$URL/api/token" | sed -E 's/.*"token":"([^"]+)".*/\1/'; }
    post() { curl -s -o /dev/null -w '%{http_code}' -b "$JAR" -c "$JAR" -H "X-RRHH-CSRF: $(token)" \
        -H 'Content-Type: application/json' -X POST "$URL/api/$1" -d "$2"; }

    # El cuerpo se arma con printf para no depender del manejo de comillas anidadas de cada versión de bash.
    entrar() { post login "$(printf '{"Login":"%s","Password":"%s"}' "$1" "$2")"; }

    echo "Sesión"
    verificar "login con clave errónea" 401 "$(entrar operador incorrecta-xyz)"
    verificar "login sin token antifalsificación" 400 \
        "$(curl -s -o /dev/null -w '%{http_code}' -H 'Content-Type: application/json' -X POST "$URL/api/login" -d '{"Login":"operador","Password":"x"}')"
    verificar "login de usuario sin rol habilitado" 401 "$(entrar sin_permiso "$DEMO_PASSWORD")"
    verificar "login del operador" 204 "$(entrar operador "$DEMO_PASSWORD")"
    verificar "/api/sesion con sesión" 200 "$(codigo -b "$JAR" "$URL/api/sesion")"

    echo "Teletrabajo (RF-13, RF-14)"
    alta='{"Empleado":101,"Desde":"2026-12-07","Hasta":"2026-12-11","Modalidad":"T","DiasRemotos":31,"Autorizacion":"HUMO"}'
    verificar "alta de periodo" 201 "$(post periodos "$alta")"
    verificar "alta repetida rechazada por solapamiento" 400 "$(post periodos "$alta")"
    listado="$(curl -s -b "$JAR" "$URL/api/periodos?empleado=101")"
    [[ "$listado" == *'"modalidad"'* || "$listado" == *'HUMO'* ]] && echo "  ok   el listado devuelve el periodo" || { echo "  FALLA el listado no devolvió el periodo: $listado"; fallos=$((fallos+1)); }
    verificar "reporte de días" 200 "$(codigo -b "$JAR" "$URL/api/reporte?desde=2026-12-07&hasta=2026-12-11")"
    verificar "clasificación total/parcial (RF-16)" 200 "$(codigo -b "$JAR" "$URL/api/clasificacion-teletrabajo?desde=2026-12-07&hasta=2026-12-11")"
    verificar "reporte de ausencias (RF-18)" 200 "$(codigo -b "$JAR" "$URL/api/ausencias?desde=2026-11-01&hasta=2026-11-30")"

    echo "Cierre de sesión"
    verificar "salir" 204 "$(post salir '{}')"
    verificar "/api/sesion tras salir" 401 "$(codigo -b "$JAR" "$URL/api/sesion")"
fi

echo
if [[ $fallos -eq 0 ]]; then echo "PRUEBA DE HUMO CORRECTA"; else echo "PRUEBA DE HUMO CON $fallos FALLO(S)"; exit 1; fi
