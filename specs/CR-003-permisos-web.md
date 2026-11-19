# CR-003 / CR-006: permisos del piloto en web

- Estado: implementación local; revisión, recorrido visual y despliegue pendientes.
- Línea base: `f496a90`, depende del PR de guardado transaccional de escritorio.
- Responsable: Jorge Enrique Cano Asto. Revisión ajena pendiente.

## Diagnóstico y diseño previo

El host web no expone RF-03/RF-06. Se reutilizará `GuardarPermiso`, sin
copiar reglas en JavaScript ni realizar escrituras mediante el mapper.
Se agrega una consulta tipada por empleado/número para cargar la edición.

Mantenimiento principal perfectivo: adaptar a web el caso de uso disponible.
Repository y composición existentes: Application desconoce ASP.NET/Npgsql;
CompositionRoot conecta consulta y guardado. Se conserva numeración por
empleado, reglas inclusivas, estados y grupo anual del repositorio común.

Flujo: sesión → rol explícito de gestión de permisos → carga o formulario
→ CSRF → caso de uso común → transacción PostgreSQL → número confirmado.

## Aceptación

- GET/POST de permisos requieren la política explícita `RRHH_WEB_ROLES_PERMISOS`.
- Sin sesión 401; con sesión sin rol 403; POST sin CSRF 400 y sin escritura.
- Crear solicitado, bloquear solapamiento, anular y volver a usar las fechas.
- Grupo anual impide dos motivos distintos en el mismo año.
- Carga para editar conserva empleado/número y todos los campos editables.
- No existe un rol habilitado por defecto; el administrador configura el piloto.
- Las salidas autorizadas por horas (tipo 2) se rechazan en este adaptador
  hasta migrar sus comprobaciones de marcación; siguen en escritorio.
  Día completo y retorno simultáneos se rechazan en el caso de uso común.

## Verificación y reversión

Regresión local ejecutada: 362/362 pruebas net48 sin omisiones, host web
0 errores/0 advertencias y smoke HTTP correcto. Recorrido en navegador:
login, alta, rechazo de solapamiento, carga y anulación confirmados en UI.
Resultados en [QA web](../Software/RRHH.Web/qa/RESULTADOS.md).
Retirar este adaptador revierte los endpoints y UI; los permisos se conservan
en la misma tabla. No retirar la migración si perdería estados explícitos.
No aplicar cambios a la base compartida. No declarar completos los 18 RF.

Asistencia material de IA en implementación y pruebas; revisión humana pendiente.
