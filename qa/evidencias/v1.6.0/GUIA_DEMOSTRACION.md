# Ensayo de evaluación RRHH v1.6.0-beta.1

Paquetes extraídos del corte 0be0ee6, conectados a la misma copia local
rrhh_integridad_qa en 127.0.0.1:55649. La web escucha solo en loopback
en http://127.0.0.1:5219. El clúster local se conserva en el perfil
restore-neon-30b49aba bajo AppData Local RRHH-QA.

## Orden de demostración

1. Arrancar el clúster PostgreSQL 18 de QA en el puerto 55649 con pg_ctl.
2. Cargar la credencial local cifrada del perfil y configurar RRHH_WEB_POSTGRES
   y RRHH_POSTGRES_CONNECTION para rrhh_integridad_qa.
3. Habilitar el rol ficticio 9010 para el operador web y los módulos de
   permisos y vacaciones. Configurar el rol 9020 de autoconsulta en ambos
   clientes. En WinForms usar el modo de solo autoconsulta durante la exposición.
4. Ejecutar RRHH.Web.dll con .NET 8 desde el ZIP extraído e iniciar
   RecursosHumanos.exe desde el ZIP de WinForms.
5. Mostrar en web la licencia ficticia existente del empleado 900001 y el
   rechazo de una segunda licencia del mismo grupo. Consultar con qa_emp_a
   y qa_emp_b. Los saldos esperados son 47,5 y 60 días. Mostrar 47,5 días en
   WinForms con qa_emp_a.
6. Cerrar ambas aplicaciones y detener el clúster de QA.

La copia conserva registros reales del respaldo. Usar únicamente las cuentas
ficticias y consultas por los IDs 900001 y 900002 en la exposición.

## Resultado del arranque conjunto

La web recuperó la licencia inicial, rechazó la segunda y verificó los
dos saldos y la denegación de operaciones para empleados. El WinForms
extraído aprobó el diagnóstico de conexión contra la misma base. WinForms abrió Mis vacaciones para qa_emp_a y devolvió 47,5 días pendientes al 20/11/2026, con 60 generados, 12,5 usados y dos consumos. Ver [captura](WinForms-ZIP-copia-migrada.jpg).

La versión estable v1.6.0 está publicada. El paquete web está
adjunto. El ZIP WinForms se usa localmente hasta confirmar sus DLL.
La importación física requiere un Marcacion.mdb de prueba.
