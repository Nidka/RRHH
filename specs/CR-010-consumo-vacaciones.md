# CR-010: consumo y aprobación de vacaciones del piloto

- RF-10 y cierre de RF-08/RF-03; depende de CR-008 (`4334c6a`).
- Responsable de continuación: Jorge Enrique Cano Asto. Revisión ajena pendiente.
- Mantenimiento correctivo/perfectivo: impedir aprobar consumos sin saldo y
  habilitar media jornada y edición explícita de estados en escritorio/web.

## Diseño previo y aceptación

La fuente sigue siendo Permiso. Se añade MediaJornadaVacaciones al DTO,
con null para conservar el valor al editar desde un cliente anterior.
Completo consume días calendario inclusivos; media jornada consume 0,5 en
una única fecha laborable. No puede aplicarse a motivos no vacacionales.

La aprobación valida saldo dentro de la transacción que ya bloquea permisos
y motivos. Obtiene ingreso y consumos con el mismo contexto transaccional.
Para evitar doble gasto se consideran TODOS los aprobados, incluidas reservas
futuras, excluyendo el propio permiso; generadas se calcula al inicio de la
solicitud. Es una política conservadora del piloto, no regla legal oficial.
Anulado/rechazado no reserva saldo y debe permitir devolverlo aunque el
calendario haya cambiado después. Se conserva el régimen configurable.

Repository/DIP y MVP vista pasiva para el editor nuevo, compuesto en
CompositionRoot. El ejecutor incorpora Query transaccional para no abrir
otra conexión dentro de una operación atómica. Dominio conserva reglas puras.

Casos: media válida 0,5; sábado/feriado rechazados; insuficiente rechazado sin
escritura; dos aprobaciones concurrentes no gastan el mismo saldo; anulación
restituye; editar conserva marcaciones; estados accesibles solo a roles
explícitos. Salidas por horas conservan su flujo heredado hasta migrarlo.

Verificar build completo, pruebas SQL ficticias y HTTP. Reversión: revertir
código sin retirar columnas con consumos fraccionarios; rollback protegido
en CR-008. No cambios en servidor compartido. Ayuda material de IA declarada;
revisión humana y recorrido visual pendientes.

Resultados ejecutados: 366/366 pruebas net48 sin omisiones en PostgreSQL 18
local; smoke HTTP prueba descuento de 0,5, anulación con devolución y sábado
rechazado. SQL prueba feriado, insuficiencia, reservas futuras y dos altas
concurrentes para un único saldo de 0,5 (solo una persiste). Build web:
0 errores/0 advertencias; WinForms x86 completo: 0 errores/26 advertencias
heredadas. Configurar RRHH_PERMISOS_ROLES para abrir el editor de escritorio;
no se habilita automáticamente para ningún rol.
