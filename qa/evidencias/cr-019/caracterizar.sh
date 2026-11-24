#!/usr/bin/env bash
# Recorre la API con datos ficticios de rrhh_demo y escribe "MÉTODO ruta -> estado cuerpo" por línea.
# Uso: DEMO_PASSWORD='<clave>' caracterizar.sh <url-base>
# Recrear la BD de demostración y arrancar el servidor desde cero antes de cada corrida, para comparar
# desde el mismo estado (las altas cambian los datos). Nunca usar contra la base compartida.
set -uo pipefail
: "${DEMO_PASSWORD:?Defina DEMO_PASSWORD (clave de los usuarios ficticios)}"
U=$1; JAR=$(mktemp); PASS=$DEMO_PASSWORD
tok() { curl -s -b "$JAR" -c "$JAR" "$U/api/token" | sed -E 's/.*"token":"([^"]+)".*/\1/'; }
get() { printf 'GET %s -> ' "$1"; curl -s -b "$JAR" -c "$JAR" -w ' [%{http_code}]' "$U$1"; echo; }
post() { printf 'POST %s %s -> ' "$1" "$2"; curl -s -b "$JAR" -c "$JAR" -H "X-RRHH-CSRF: $(tok)" -H 'Content-Type: application/json' \
  -X POST -w ' [%{http_code}]' "$U$1" -d "$2"; echo; }
entrar() { rm -f "$JAR"; post /api/login "{\"Login\":\"$1\",\"Password\":\"$2\"}" | sed "s/$PASS/***/"; }

echo "== sin sesión"
get /api/sesion; get "/api/periodos?empleado=101"; get /api/modulos; get "/api/empleados?texto=fic"
post /api/salir '{}'
echo "== logins"
entrar sin_permiso "$PASS"; entrar operador incorrecta
echo "== operador"
entrar operador "$PASS"
get /api/sesion
get "/api/periodos?empleado=101"
post /api/periodos '{"Empleado":101,"Desde":"2026-11-09","Hasta":"2026-11-13","Modalidad":"P","DiasRemotos":21,"Autorizacion":"QA"}'
post /api/periodos '{"Empleado":101,"Desde":"2026-11-10","Hasta":"2026-11-12","Modalidad":"T","DiasRemotos":31,"Autorizacion":"QA"}'
post /api/periodos '{"Empleado":101,"Desde":"2026-12-01","Hasta":"2026-12-05","Modalidad":"X","DiasRemotos":1,"Autorizacion":""}'
get "/api/periodos?empleado=101"
get "/api/reporte?empleado=101&desde=2026-11-09&hasta=2026-11-15"
get "/api/reporte?desde=2026-11-09&hasta=2026-11-15"
get "/api/reporte?desde=2025-01-01&hasta=2026-11-15"
get "/api/clasificacion-teletrabajo?desde=2026-11-09&hasta=2026-11-13"
get "/api/clasificacion-teletrabajo?desde=2026-11-09&hasta=2026-11-13&clase=P"
get "/api/clasificacion-teletrabajo?desde=2026-11-09&hasta=2026-11-13&clase=X"
get /api/ausencias/motivos
get "/api/ausencias?desde=2026-11-01&hasta=2026-11-30"
get "/api/ausencias?desde=2026-11-01&hasta=2026-11-30&motivo=10"
get "/api/ausencias?desde=2026-11-01&hasta=2026-11-30&motivo=-1"
get "/api/ausencias?desde=2026-11-31&hasta=2026-11-30"
get /api/horarios/catalogo
get "/api/horarios/historico?empleado=101"
get "/api/horarios/historico?empleado=101&desde=2026-01-01&hasta=2026-12-31"
post /api/horarios/asignaciones '{"Empleado":101,"Numero":0,"Horario":1,"Desde":"2026-12-01","Hasta":"2026-12-15","Documento":"QA","Sisgedo":""}'
post /api/horarios/asignaciones '{"Empleado":101,"Numero":0,"Horario":1,"Desde":"2026-12-20","Hasta":"2026-12-10","Documento":"QA","Sisgedo":""}'
get /api/horarios/asignaciones/101/1
get /api/horarios/asignaciones/101/99
get /api/horarios/asignaciones/0/1
get "/api/horarios/historico?empleado=101"
get /api/motivos-permiso/tipos
get "/api/motivos-permiso?tipo=1"
post /api/motivos-permiso '{"Tipo":1,"Descripcion":"Motivo QA ficticio","Abreviatura":"MQA","Salario":false}'
post /api/motivos-permiso '{"Tipo":1,"Descripcion":"Motivo QA ficticio","Abreviatura":"MQA","Salario":false}'
get "/api/motivos-permiso?tipo=1"
post /api/motivos-permiso/9999/eliminar '{}'
get "/api/asistencia?empleado=101&desde=2026-11-01&hasta=2026-11-30&modo=A"
get "/api/asistencia?empleado=101&desde=2026-11-01&hasta=2026-11-30&modo=P"
get "/api/asistencia?empleado=101&desde=2026-11-01&hasta=2026-11-30&modo=X"
get "/api/asistencia/consolidada?empleado=101&desde=2026-11-01&hasta=2026-11-30"
get "/api/vacaciones/generadas?empleado=101&corte=2026-11-20"
get "/api/vacaciones/saldo?empleado=101&corte=2026-11-20"
get "/api/vacaciones/truncas?empleado=101&cese=2026-11-20"
get "/api/vacaciones/reporte?anio=2026&corte=2026-11-20"
get "/api/vacaciones/reporte?anio=2026&corte=2026-11-20&empleado=101"
get "/api/permisos?empleado=101&numero=1"
post /api/permisos '{}'
get "/api/mi/vacaciones?corte=2026-11-20"
get /api/modulos
get "/api/empleados?texto=fic"
post /api/salir '{}'
get /api/sesion
echo "== solo_teletrabajo"
entrar solo_teletrabajo "$PASS"
get /api/sesion
get "/api/periodos?empleado=102"
get "/api/vacaciones/saldo?empleado=101&corte=2026-11-20"
get /api/horarios/catalogo
get /api/modulos
get "/api/empleados?texto=fic"
rm -f "$JAR"
