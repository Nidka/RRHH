# CR-012: autoconsulta de vacaciones por identidad autenticada

- RF-12, depende de RF-08 a RF-11. Responsable: Jorge Enrique Cano Asto;
  revisión ajena pendiente. Mantenimiento perfectivo; sin nuevos permisos por defecto.

## Diseño previo

El empleado ve solo saldo y consumos propios. ConsultarMisVacaciones recibe
IdUsuario autenticado, nunca un empleado elegido por el cliente; resuelve
Usuario.IdEmpleado en cada consulta y rechaza usuario inactivo, sin vínculo
o duplicado. No elige arbitrariamente entre copias del mismo usuario.

Web: rol académico separado mediante RRHH_WEB_ROLES_AUTOCONSULTA, disjunto
de RRHH_WEB_ROLES. Cookie con rol Empleado, sin OperadorTeletrabajo; endpoint
GET /api/mi/vacaciones protegido. No habilita APIs operativas aunque se
manipule la interfaz o se agregue empleado en la URL.

Escritorio: RRHH_AUTOCONSULTA_ROLES explícito; el login conserva su identidad
tipada por instancia. La sesión de empleado abre una vista independiente
de solo lectura y no accede a los menús operativos de MainMDI. Sin nuevo
estado global en Module1. MVP; CompositionRoot compone casos y repositorios.
El cliente escritorio sigue usando credenciales de BD del host: este flujo
no equivale a restricciones PostgreSQL por usuario ni sustituye las del despliegue.

Aceptación: dos cuentas ficticias con saldos propios, intento de consultar
otro empleado sin efecto, operaciones RRHH denegadas, sin vínculo o duplicado
rechazado. Revocación del vínculo se refleja en la siguiente consulta.

Probar SQL local, HTTP 401/403, build y UI. Configuración de rol real y
asignaciones se coordinan con Kadin; el rol 20 solo se crea en la fixture.
Reversión retira adaptadores y configuración sin borrar usuarios. IA material
en código/pruebas/documentación; revisión humana pendiente.

Ejecutado en PostgreSQL 18 local: 373/373 pruebas net48 sin omisiones;
HTTP con dos cuentas ficticias confirma identidad propia incluso agregando
empleado ajeno a la URL; APIs operativas y saldo de terceros devuelven 403;
logout funciona. SQL rechaza cuenta inactiva, vínculo nulo y duplicado real.
Build web 0 errores/0 advertencias; WinForms completo x86 0 errores/26
advertencias heredadas. Recorrido visual de la vista propia pendiente.
