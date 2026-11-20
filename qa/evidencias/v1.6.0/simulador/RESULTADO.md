# Ensayo de importación de marcaciones

20/11/2026. MDB ficticio generado con Jet x86, documento QA001 y
empleado ficticio 900001. Destino rrhh_integridad_qa en loopback:55649.

1. Jet abrió el archivo y devolvió una asistencia y una marcación.
2. El primer ejecutor PowerShell falló al resolver Unsafe. El ejecutor
   .NET Framework x86 con la configuración de WinForms ejecutó dos
   veces el método de importación del adaptador, sin forzar.
3. PostgreSQL conservó una asistencia IMPORTACION del 20/11/2026 con
   entrada 08:00:00 y una marcación E a las 08:00:00 en lugar QA.
4. La web aceptó la salida del motivo 143, permiso 103, usando la
   asistencia importada. Al simular una hora de salida en PostgreSQL,
   rechazó otro registro con HTTP 400. Se restauró la hora original y
   se anuló el permiso de prueba.

Se ejecutó el método del adaptador con un archivo Jet sin contraseña.
La selección del archivo desde el formulario y la exportación desde
un reloj físico quedan fuera de esta comprobación. Clúster detenido.

## Recorrido posterior en el formulario WinForms

Importacion > Importacion Asistencias - OTROS. Se seleccionó el
Marcacion.mdb ficticio con el selector de archivos, rango 20/11/2026
y Forzar Importacion desactivado. Generar mostró confirmación de éxito.
La consulta posterior conservó una asistencia y una marcación QA
para el empleado ficticio 900001. Ver WinForms-MDB-seleccionado.jpg
y WinForms-MDB-resultado.jpg. Falta la captura y exportación
desde un dispositivo físico de QA.
