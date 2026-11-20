# Actualización de Neon para RRHH v1.6.0

Se respaldó el esquema public de neondb antes de escribir. La restauración
local pasó. SHA256 del respaldo:
12E72A715AD3F04EF2983B1E3E6DF0B34B2C85B753903DBDBA2DEBFF166E5C2E.

La misma transacción se ensayó en la restauración de QA y se confirmó
en Neon. Se reasignó SALIR (143) a Papeleta Salida (2), se retiraron las
copias exactas y se aplicaron TEC-002, autenticación, licencia anual,
teletrabajo, estados y vacaciones.

La consulta posterior confirmó 95 usuarios, 141 motivos, 3 tipos, 70
horarios y 221 feriados, sin IDs repetidos en esas tablas. La transacción
verificó conservación de 52.240 permisos, 6.670 filas de empleados y 184
vínculos usuario-rol. Se comprobaron Teletrabajo y las cinco columnas.

Las marcas de motivos de restricción anual y vacaciones permanecen en
cero. Requieren la selección aprobada del equipo, junto con roles y
vínculos de autoconsulta. La validación funcional previa corresponde a la
copia local. Las bitácoras de aplicación y verificación de Neon registran
la comprobación de base posterior. No se efectuó un login funcional en
Neon ni se publicó la versión estable en este paso.
