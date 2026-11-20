# CR-003: guardado de salidas autorizadas en ambos clientes

- Depende de RF-15; responsable de continuación: Jorge Enrique Cano Asto;
  revisión ajena pendiente. Mantenimiento correctivo y adaptativo del flujo
  que conservaba verificaciones solo en FrmPermiso.

## Ingeniería inversa y diseño previo

FrmPermiso comprueba Asistencia de hoy, salida registrada, fecha no pasada y
un único día para TipoPermiso=2, pero lo hace fuera de la transacción. El
recuento ==1 dejaba de detectar una salida si había más de una fila; tampoco
impedía fechas futuras pese a consultar la asistencia de hoy.

Se extrae una regla pura y se comprueba dentro del guardado transaccional:
una única fecha, hoy según reloj del host; al menos una marcación con fecha
de hoy; ninguna salida ya registrada. Hor_Sal vacía o cero significa sin
salida; formatos no válidos requieren revisión. Varias marcaciones no
ocultan una salida existente. Anular/rechazar devuelve disponibilidad sin
exigir una marcación actual para corregir el historial.

El repositorio bloquea Asistencia durante lectura y escritura del permiso;
Domain no conoce BD/UI y el reloj se inyecta para pruebas deterministas.
Web y editor MVP habilitan este mismo flujo. No escriben al equipo físico:
la integración Access opcional del formulario original permanece separada
de PostgreSQL y requiere hardware para su propia aceptación.

Aceptación: sin marcación rechaza; hoy sin salida acepta; fecha pasada,
futura o varios días rechaza; salida en cualquiera de dos filas rechaza;
anulación histórica admite. Sin roles o CSRF no permite escribir en web.

Pruebas puras/SQL/HTTP ficticias y build completo. Reversión vuelve a restringir
el adaptador web; los permisos se conservan. Solo local, sin reloj físico ni
servidor compartido. IA material declarada, revisión humana pendiente.

Ejecutado: 388/388 pruebas net48 sin omisiones; reloj inyectado, ausencia
de marcación, fecha distinta, varias filas con salida y anulación. HTTP
crea salida del día con marcación ficticia, rechaza salida ya registrada y
permite anular; regresión completa correcta. Build web 0 errores y 0
advertencias, WinForms completo x86 0 errores y 26 advertencias heredadas.
