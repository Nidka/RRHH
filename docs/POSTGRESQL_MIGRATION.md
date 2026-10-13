# Migración pendiente a PostgreSQL

## Diagnóstico

La migración de los datos no migra automáticamente el cliente. El código
recuperado contiene aproximadamente:

- 55 archivos que usan directamente `SqlConnection`, `SqlCommand` o
  `SqlDataAdapter`;
- 807 archivos generados o consumidores de LINQ-to-SQL;
- 78 usos explícitos de `CommandType.StoredProcedure`;
- cientos de mapeos con esquema `dbo` y expresiones T-SQL (`CONVERT`, `ISNULL`,
  nombres entre corchetes y parámetros con prefijo `@`).

LINQ-to-SQL genera dialecto SQL Server y no funciona sobre Npgsql. Por eso no se
ha hecho un reemplazo mecánico de tipos `Sql*` por `Npgsql*`: compilaría sólo en
algunos puntos, pero fallaría al ejecutar consultas y procedimientos.

## Insumos necesarios

Para continuar sin adivinar nombres ni tipos se necesita:

1. Un `pg_dump --schema-only` de la base PostgreSQL ya migrada, o el DDL
   equivalente. Puede entregarse sin datos.
2. La versión de PostgreSQL y el nombre real de la base/esquema.
3. El inventario o DDL de funciones/procedimientos PostgreSQL que reemplazan
   los `spRRHH_*`, incluyendo sus parámetros y tipos de retorno.
4. Una cuenta de desarrollo con permisos mínimos. La contraseña no debe
   guardarse en Git ni dentro de `app.config`.
5. Casos de prueba o resultados esperados para login, empleados, asistencia,
   permisos, ficha social y reportes.

El único respaldo disponible actualmente es
`C:\Users\maki-\Downloads\CMI_Backup_QA\CMI_Backup_QA.bak`, de SQL Server.

## Secuencia recomendada

1. Crear una capa de acceso PostgreSQL nueva con Npgsql y configuración externa.
2. Migrar primero autenticación y catálogos de sólo lectura.
3. Reemplazar las entidades LINQ-to-SQL usadas por RRHH por repositorios o por
   EF Core/Dapper, manteniendo modelos de dominio independientes del proveedor.
4. Adaptar cada procedimiento almacenado a funciones/procedimientos PostgreSQL
   y verificar contratos de parámetros y resultados.
5. Parametrizar todo SQL que hoy concatena texto.
6. Migrar escrituras de empleados, asistencia, permisos y ficha social dentro
   de transacciones.
7. Validar reportes y diferencias de fechas, booleanos, mayúsculas/minúsculas,
   secuencias/identidades y valores nulos.
8. Retirar finalmente `System.Data.SqlClient`, LINQ-to-SQL y las cadenas de SQL
   Server.

## Criterio de terminado

La aplicación estará realmente migrada cuando compile sin `SqlClient`, se
conecte únicamente mediante Npgsql, ejecute las funciones PostgreSQL y supere
pruebas funcionales contra una copia de QA. Una cadena de conexión PostgreSQL
en el programa actual no cumple ese criterio.
