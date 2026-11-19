# RF-03 / RF-06: estados y guardado transaccional

Fecha: 19/11/2026. Línea base `3eb62af`. Rama
`codex/rf-03-permisos-transaccionales`. Datos ficticios locales; no se
utilizó la base compartida de Kadin.

## Antes y después

Antes, el formulario comprobaba permisos mediante un mapper y después
validaba RF-03/06 con otra conexión. Finalmente asignaba el número y
escribía mediante el mapper: dos altas podían superar la comprobación.

Ahora `GuardarPermiso` valida los datos y el repositorio ejecuta comprobación,
numeración y escritura en una transacción. Los escritores de este repositorio
se serializan con bloqueo de tabla. Al editar conserva marcaciones y la
autorización administrativa; el DTO recibe su número después del commit.
La salida opcional al reloj utiliza ese número, y permanece fuera de la
transacción PostgreSQL. No se ha probado un reloj físico.

Los estados Rechazado y Anulado liberan fechas y cupo anual. Los históricos
sin estado conservan el bloqueo. La migración no convierte solicitudes
no autorizadas en rechazos y su rollback protege contra pérdida de estados.

## Comprobaciones ejecutadas

| Comprobación | Resultado real |
|---|---|
| `Smoke.ps1 -RegresionEscritorio`, PostgreSQL 18 local | 362/362 pruebas net48, ninguna omitida; smoke HTTP correcto |
| Guardados simultáneos con fechas coincidentes | Solo uno persistido; otro rechazado |
| Guardados simultáneos con motivos distintos del mismo grupo anual | Solo uno persistido; otro rechazado |
| Anulación, intento de reactivar con cupo ocupado y edición de campos | Saldo de cupo liberado, reactivación rechazada, marcaciones conservadas |
| Estados en consultas RF-03 y RF-06 | Solicitado/Aprobado bloquean; Rechazado/Anulado liberan; desconocido bloquea |
| Migración repetida y rollback protegido | Conserva Anulado; rollback rechazado hasta resolver estados no representables |
| Build web net8 | 0 errores, 0 advertencias |
| `Software/scripts/build.cmd`, WinForms net48 x86 | 0 errores, 26 advertencias heredadas |

Durante el desarrollo se corrigió un dato de prueba demasiado largo y un
conflicto de espacio de nombres en el formulario. Los resultados anteriores
corresponden a las ejecuciones posteriores a esas correcciones.

## Qué NO acredita esta evidencia

- No acredita la aplicación de las migraciones sobre la base compartida ni su saneamiento.
- No acredita recorrido visual de este guardado, ni edición de cuatro estados en ambas interfaces.
- No protege clientes SQL externos o flujos heredados que validen fuera de la transacción.
- No incorpora aún el adaptador web de escritura de permisos.
- No cierra RF-08 a RF-12 ni RF-15 ni acredita los 18 RF completos.

## Despliegue propuesto para Kadin

1. Identificar destino QA y tomar respaldo verificable; revisar duplicados con
   `BD/tests/diagnostico_integridad.sql` antes de decidir su saneamiento.
2. Resolver IDs ambiguos y revisar clasificación histórica de permisos.
3. Aplicar RF-06 (`20261111_01_licencia_una_vez_anio.sql`) y, si corresponde,
   su agrupación (`20261119_01_grupo_licencia_anual.sql`), sin activar códigos
   reales hasta confirmar la regla. El motivo 900 solo pertenece a las pruebas.
4. Aplicar `BD/migrations/20261119_02_estados_permiso.sql` en QA revisada.
5. Desplegar el ejecutable de esta rama, comprobar alta/edición y dos operadores
   simultáneos; luego registrar commit, versión de esquema y capturas ficticias.
6. Integración a main y versión de entrega: pendientes de revisión del grupo.

El saneamiento de copias exactas existente está restringido a una base QA
local por diseño; no debe ejecutarse ni adaptarse a ciegas en el servidor.
