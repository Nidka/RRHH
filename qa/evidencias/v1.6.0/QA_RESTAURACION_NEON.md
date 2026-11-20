# Restauración de Neon y verificación de QA

Respaldo pg_dump del esquema public de Neon. Restauración local con
pg_restore en una transacción y sin propietarios ni ACL de origen.
SHA256 7E6B3C95220D02143C8A5D1A671419B1FC9767101F71901A442A79A8537DFEF8.
El primer intento se detuvo por public existente. Se retiró el esquema
vacío en el destino local y la restauración completa pasó.

| Tabla | Restauración original | Copia migrada antes de datos QA |
|---|---:|---:|
| Usuario | 190 | 95 |
| Motivo_Perm | 281 | 141 |
| Usuario_Rol | 184 | 184 |
| Permiso | 52240 | 52240 |
| Empleado | 6670 | 6670 |

En la copia local se reasignó el motivo 143 al tipo 2, se retiraron copias
exactas y se aplicaron TEC-002, autenticación, RF-06, teletrabajo, estados
de permisos y vacaciones. La restauración original queda separada.

Web contra la copia migrada: dos empleados ficticios con 47,5 y 60 días
pendientes, aislamiento por identidad y HTTP 403 para acceso operativo.
El operador ficticio registró una licencia y la segunda del mismo grupo
fue rechazada por la restricción anual. WinForms pasó su diagnóstico
contra la misma base. En la consulta visual, qa_emp_a abrió Mis vacaciones y consultó al empleado ficticio 900001. Al 20/11/2026 mostró 60 días generados, 12,5 usados y 47,5 pendientes, con consumos de 12 y 0,5 días. [Captura](WinForms-RF12-Neon-restaurado.jpg).

La copia contiene datos reales en el clúster privado local. Esta evidencia
solo registra conteos y casos ficticios. No se modificó Neon.
