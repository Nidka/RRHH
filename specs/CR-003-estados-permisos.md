# CR-003: estados explícitos y liberación de fechas de permisos

- Estado: en implementación; despliegue compartido y recorrido visual pendientes.
- RF / CR: RF-03, RF-06 / CR-003, CR-006.
- Línea base: `3eb62af`.
- Responsable de esta continuación: Jorge Enrique Cano Asto. Revisión ajena pendiente; despliegue coordinado por Francisco Kadin Valera Lizarraga.

## Diagnóstico y alcance

La lectura de `PostgreSqlPermisoRepository` muestra que las consultas de
solapamiento y licencia anual cuentan todos los permisos. `Autorizado = false`
no permite distinguir una solicitud pendiente de una rechazada. El formulario
heredado añade otro bloqueo mediante `PermisoMapper.SelectBy`, independiente
de RF-03. Esta continuación introduce el estado explícito y caracteriza su
compatibilidad; no acredita por sí sola el cumplimiento completo de RF-03/06.

Regla del piloto proporcionada por el equipo: Solicitado y Aprobado ocupan
fechas y cupo anual; Rechazado y Anulado los liberan. Los datos históricos
autorizados se interpretan como Aprobado y los restantes como Solicitado,
sin inventar rechazos históricos. Un estado desconocido bloquea por seguridad.

## Diseño antes de implementar

- Mantenimiento principal correctivo: liberar fechas y cupos de solicitudes
  anuladas/rechazadas. Capacidad nueva: registrar cuatro estados distintos.
- Técnica: extraer el predicado SQL de ocupación y reutilizarlo en las dos
  consultas existentes. Se conservan fechas inclusivas, exclusión del propio
  número y agrupación anual configurable.
- Repository: `IPermisoRepository` sigue separando Application de PostgreSQL.
  DRY: un predicado privado común evita diferencias entre RF-03 y RF-06.
- No cambia la arquitectura ni se introduce un patrón de presentación nuevo.
- Migración transaccional e idempotente; sincroniza `Autorizado` con el estado
  explícito para conservar lectores heredados. No activa motivos reales.
- Compatibilidad de lectura con esquemas anteriores mediante `to_jsonb`.
  La migración no elimina duplicados ni protege escritores externos por sí sola.
- `GuardarPermiso` valida los datos y depende de `IPermisoEscrituraRepository`
  (DIP). El repositorio serializa comprobaciones y escritura en una sola
  transacción mediante bloqueo de Permiso/Motivo_Perm. El formulario retira
  Insert/Update y la asignación de número heredados; conserva controles de
  salida autorizada y la integración opcional con el reloj. El número
  definitivo se utiliza también en esa integración, que antes recibía cero
  en un alta. Esa operación externa sigue sin compartir la transacción.

Flujo anterior: consulta de todos los permisos → bloqueo incluso anulado.
Flujo propuesto: estado explícito o histórico conservador → solo estados
ocupantes → reglas existentes de fechas y año.

## Aceptación y verificación

1. Solicitado/Aprobado bloquean RF-03 y RF-06.
2. Rechazado/Anulado no bloquean ninguna de las dos reglas.
3. Sin columna de estado se conserva el bloqueo histórico.
4. Migración repetida conserva estados; cambios explícitos actualizan el booleano.
5. Un cambio heredado de `Autorizado` conserva su significado de aprobación.
6. Estado inválido se rechaza; la reversión se niega si perdería anulaciones o rechazos.

Pruebas ejecutadas: PostgreSQL 18 local desechable, 362/362 pruebas net48,
smoke HTTP correcto, build web sin errores/advertencias y WinForms x86 con
0 errores y 26 advertencias heredadas. Evidencia y límites en
[resultados RF-03](../qa/RF-03-ESTADOS-RESULTADOS.md).

## Riesgos y reversión

Antes del despliegue Kadin debe revisar la clasificación histórica y duplicados.
No aplicar automáticamente a una base compartida. El rollback conserva la
columna si contiene estados no representables mediante `Autorizado`; requiere
exportar y resolver esos casos antes de volver a la versión anterior.

Pendientes separados: edición de estados con autorización en ambas interfaces,
adaptador web de escritura y QA visual. La transacción serializa este
repositorio; clientes SQL externos o escritores heredados ajenos a este flujo
necesitan restricciones adicionales antes de prometer una garantía global.
No declarar RF-03/RF-06 completos con este incremento.

## IA y revisión

Asistencia material de IA en código, pruebas y redacción. No se atribuye una
revisión humana ni una aprobación que todavía no se ha producido.
