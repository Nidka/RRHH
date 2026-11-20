# Recorrido WinForms con datos ficticios

20/11/2026. Main en 4af4a01, con el código de aplicación probado en 7b90c45. Demo desechable PostgreSQL local.

- RF-04. Alta manual de MOTIVO TEMPORAL QA, abreviatura QAT. Confirmada su aparición en el catálogo.
- RF-05. Baja autorizada de QAT. Confirmación del sistema y catálogo sin QAT.
- RF-13. Alta del periodo 2 para 102 el 20/11/2026, modalidad Total. Se volvió a consultar la fila.
- RF-14. Reporte del 20/11/2026, un día remoto por empleado 101 y 102.
- RF-16. Noviembre presenta 101 con 5 de 20 y 102 con 1 de 20 días remotos. Ambos son parciales en el rango mensual. En el rango del 20/11 al 20/11, los dos empleados se clasificaron Total con 1 día remoto de 1 laborable. Ver [captura](RF16-clasificacion-total.jpg).
- RF-18. Consulta del 01 al 30 de noviembre con todos los motivos. Devolvió cuatro registros ficticios. El filtro Licencia ficticia devolvió tres filas. La consulta sin filtro incluye el permiso de vacaciones 01–30/11, marcado Anulado por la fixture. CR-018 deja el filtro por Autorizado a decisión del área usuaria y no define el nuevo estado Anulado. Queda por acordar el criterio para ese estado.
- Reloj. La prueba de dispositivo y de importación MDB siguen pendientes.
