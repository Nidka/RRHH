# CR-004/CR-005: cierre verificable de motivos de permiso

- RF-04 agregar / RF-05 eliminar; responsable Evelyn Victoria Rodriguez Cardozo, revisor Frank Piero Mantilla Arqueros.
- Base `03ab748`, rama `fix/rf-04-05-cierre-motivos`. TEC-004 integrado; no reimplementar el módulo ni tocar RF-06.
- Estado: comprobación automatizada local ejecutada; **cierre funcional Windows pendiente**.

## Comportamiento y diagnóstico

FrmMotivoPermiso y FrmMantMotivo usan presenters/casos de TEC-004. Cargar/cancelar no escribe; alta obtiene ID, edición conserva tipo/modalidad/activo y baja explícita protege Permiso/Permiso_Aud. Repositorio PostgreSqlMotivoPermisoRepository actualiza solo Descrip_Motivo/Abrev/Salario; por diseño debería conservar UnaVezPorAnio de RF-06, pero falta una prueba SQL que lo demuestre. Sin columna RF-06 debe seguir funcionando el mantenimiento original.

Duplicado se distingue: un ID ambiguo debe impedir mutaciones; descripción repetida no tiene política de unicidad implementada ni confirmada. Caracterizar el resultado real sin inventar prohibición. Las pruebas existentes cubren duplicación de ID y referencias; nuevas pruebas añaden esquema con marca anual y descripción repetida como observación de comportamiento.

## Alcance, mantenimiento y principios

Preventivo: pruebas de regresión/compatibilidad sobre implementación existente, no nueva capacidad. No se aplica un patrón adicional ni se atribuye nuevo refactor; MVP/Repository y SRP/DIP ya existen en TEC-004. Solo se corrige código si una prueba demuestra defecto, en commit fix separado. No se altera regla de negocio ni se crea DDL contra destino compartido.

## Aceptación y plan

1. Ejecutar suite actual con fixture local ficticio; comprobar alta, duplicado de ID, edición, baja libre y baja en uso.
2. Añadir casos con UnaVezPorAnio default false: alta usa default y edición conserva marca true sin reescribirla; el caso RF-06 sigue reconociendo el motivo marcado.
3. Ejecutar en Windows con BD QA ficticia los CP-04/05; adjuntar capturas reales, incluyendo cancelar, error y permisos por rol. **No sustituir esto por pruebas del repositorio.**
4. Frank revisa; PR etiqueta semver:patch solo si contiene corrección; si solo pruebas/documentación proponer semver:none conforme política y explicar diferencia respecto a nombre de rama sugerido.

## Verificación y reversión

Datos ficticios en PostgreSQL temporal local, sin .env ni conexión compartida. Las tablas fixture son desechables y las pruebas destructivas están protegidas por host/nombre de BD. Revertir commit de tests/documentos no cambia datos de aplicación. No se modifica esquema de producción ni migración de Kadin. Build Windows/WinForms/Excel no disponibles aquí; Evelyn completa y Frank comprueba.

## Fichas de RF

| RF/CR | Módulo/pantalla/caso | Regla | Estado/evidencia | Commit/PR |
|---|---|---|---|---|
| RF-04 / CR-004 | Permisos, FrmMantMotivo, GuardarMotivoPermiso | Alta válida, ID único, no escritura al cargar; marca anual por default | CP-04-nn en evelyn.csv; automatización local y QA diferenciadas | Se registra al guardar commit local; PR pendiente |
| RF-05 / CR-005 | Permisos, FrmMotivoPermiso, EliminarMotivoPermiso | Baja explícita sin referencias; proteger auditoría | CP-05-nn en evelyn.csv; Windows pendiente | PR pendiente |

Codex asiste revisión, pruebas y documentación. No se atribuye aprobación humana ni captura no obtenida; Evelyn verifica resultados y Frank revisa. REF-003/004 e informe §9/§12 usan evidencias reales de Git y comandos.

## Resultado automatizado

293 pruebas complementarias net8 correctas, ninguna omitida. No se requirió cambio de producción. [Evidencia](../docs/t3/evidencias/RF-04/validacion-local.txt). Windows y revisión humana pendientes.
