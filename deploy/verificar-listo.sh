#!/usr/bin/env bash
# Comprueba que el repositorio está listo para desplegar el host web. No toca Render ni Neon.
#   deploy/verificar-listo.sh              # estático: archivos, sintaxis, secretos (segundos)
#   deploy/verificar-listo.sh --con-docker # además construye la imagen, levanta la demo y corre la prueba de humo
# Con --con-docker, si el repo está en ~/Downloads y Docker Desktop niega montar la carpeta, copie el repo a /tmp.
set -uo pipefail
cd "$(dirname "$0")/.."
fallos=0
ok() { echo "  ok    $1"; }
mal() { echo "  FALLA $1"; fallos=$((fallos+1)); }

echo "Archivos requeridos"
for f in Dockerfile .dockerignore render.yaml docker-compose.demo.yml deploy/smoke.sh deploy/aplicar-migraciones.sh \
         deploy/generar-hash-password.py deploy/web.env.example deploy/demo/fixture.sql deploy/demo/init/10-demo.sh \
         Software/RRHH.Web/wwwroot/manifest.webmanifest Software/RRHH.Web/wwwroot/service-worker.js \
         Software/RRHH.Web/wwwroot/icon-192.png Software/RRHH.Web/wwwroot/icon-512.png \
         BD/password-auth.sql BD/migrations/20261112_03_teletrabajo.sql BD/migrations/20261119_03_vacaciones_piloto.sql \
         docs/despliegue/DESPLIEGUE.md; do
    [[ -f "$f" ]] && ok "$f" || mal "falta $f"
done

echo "Sintaxis"
for s in deploy/smoke.sh deploy/aplicar-migraciones.sh deploy/demo/init/10-demo.sh deploy/verificar-listo.sh; do
    bash -n "$s" 2>/dev/null && ok "bash $s" || mal "sintaxis de $s"
done
python3 -m py_compile deploy/generar-hash-password.py 2>/dev/null && ok "python deploy/generar-hash-password.py" || mal "sintaxis de generar-hash-password.py"
node_ok=0; command -v node >/dev/null && node --check Software/RRHH.Web/wwwroot/service-worker.js 2>/dev/null && node --check Software/RRHH.Web/wwwroot/pwa.js 2>/dev/null && node_ok=1
[[ $node_ok -eq 1 ]] && ok "javascript del service worker y pwa.js" || echo "  omitido javascript (node no está instalado)"
python3 - <<'PY' 2>/dev/null && ok "render.yaml, compose y plantillas de CI son YAML válido" || echo "  omitido YAML (falta PyYAML: pip install pyyaml)"
import yaml
for f in ["render.yaml", "docker-compose.demo.yml", "deploy/ci/ci.yml", "deploy/ci/imagen.yml"]:
    yaml.safe_load(open(f, encoding="utf-8"))
PY
python3 - <<'PY' && ok "manifiesto PWA es JSON válido con íconos" || mal "manifiesto PWA inválido"
import json
m = json.load(open("Software/RRHH.Web/wwwroot/manifest.webmanifest", encoding="utf-8"))
assert m["display"] == "standalone" and m["start_url"] == "/" and len(m["icons"]) >= 3
PY
grep -q 'healthCheckPath: /salud' render.yaml && ok "render.yaml usa /salud (no depende de la base)" || mal "render.yaml sin healthCheckPath /salud"
grep -q 'plan: free' render.yaml && ok "render.yaml en plan free" || mal "render.yaml no está en plan free"

echo "Secretos en archivos versionados"
patron='npg_[A-Za-z0-9]{8,}|postgres(ql)?://[^:@/ ]+:[^@ ]{6,}@[A-Za-z0-9.-]+\.[a-z]|Password=[^;<$ ]{6,};.*Host=ep-'
if git ls-files -z | xargs -0 grep -IlE "$patron" 2>/dev/null | grep -vE '^(deploy/web.env.example|deploy/aplicar-migraciones.sh|docs/despliegue/DESPLIEGUE.md)$' | grep -q .; then
    mal "hay posibles credenciales en: $(git ls-files -z | xargs -0 grep -IlE "$patron" 2>/dev/null | grep -vE '^(deploy/web.env.example|deploy/aplicar-migraciones.sh|docs/despliegue/DESPLIEGUE.md)$' | tr '\n' ' ')"
else ok "sin credenciales en el repositorio (los ejemplos usan marcadores)"; fi
git ls-files --error-unmatch .env >/dev/null 2>&1 && mal ".env está versionado" || ok ".env no está versionado"

if [[ "${1:-}" == "--con-docker" ]]; then
    echo "Contenedor y demo (puede tardar varios minutos la primera vez)"
    command -v docker >/dev/null && docker info >/dev/null 2>&1 || { mal "Docker no está disponible o no está encendido"; echo; echo "VERIFICACIÓN CON $fallos FALLO(S)"; exit 1; }
    clave="$(openssl rand -hex 10)"
    export DEMO_PASSWORD="$clave"
    unset DB_PASSWORD DB_USER DB_HOST DEMO_DB_PASSWORD
    if docker compose -f docker-compose.demo.yml up -d --build --wait >/tmp/verificar-listo.log 2>&1; then ok "imagen construida y demo saludable"
    else mal "la demo no levantó (ver /tmp/verificar-listo.log)"; tail -5 /tmp/verificar-listo.log; fi
    if deploy/smoke.sh http://127.0.0.1:8080 >/tmp/verificar-smoke.log 2>&1; then ok "prueba de humo completa"
    else mal "prueba de humo (ver /tmp/verificar-smoke.log)"; grep FALLA /tmp/verificar-smoke.log | head -5; fi
    docker compose -f docker-compose.demo.yml down -v >/dev/null 2>&1
fi

echo
if [[ $fallos -eq 0 ]]; then echo "LISTO PARA DESPLEGAR: siga docs/despliegue/DESPLIEGUE.md desde el paso 2 (Neon)."; else echo "VERIFICACIÓN CON $fallos FALLO(S)"; exit 1; fi
