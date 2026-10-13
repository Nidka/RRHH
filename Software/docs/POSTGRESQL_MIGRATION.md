# Migración a PostgreSQL

## Estado verificado

El dump privado `BD/CMI.sql` se restauró en una instancia PostgreSQL 17 de
prueba y se comprobó con el ejecutable recuperado. El archivo fue creado por
PostgreSQL 18.3 en formato personalizado y contiene 101 tablas con datos.

La primera ruta vertical ya está migrada:

- configuración PostgreSQL externa mediante `RRHH_POSTGRES_CONNECTION`;
- conexión Npgsql y validación del esquema al iniciar sesión;
- consulta parametrizada de usuario, empleado y rol;
- carga del nombre del empleado en la ventana principal;
- comprobador repetible `scripts/check-postgresql.cmd`.

El antiguo control de login abría una conexión SQL Server con las credenciales
escritas por el usuario. Fue reemplazado para que el arranque no dependa de
`GRLL_Usuario_Acceso` ni de `SqlConnection`.

## Brecha de la base migrada

La base SQL Server original contiene 100 tablas, 303 procedimientos, 90 vistas
y 47 funciones escalares. El dump PostgreSQL disponible contiene tablas y
datos, pero no funciones, procedimientos, vistas, claves ni restricciones. Se
observaron filas duplicadas que las restricciones ausentes habrían impedido.

Por ese motivo el repositorio incluye `BD/schema.sql`, pero no inventa contratos
de procedimientos ni reglas de integridad. Es necesario reconstruirlos y
validarlos con resultados conocidos del sistema original.

## Dependencias heredadas aún activas

El resto de la aplicación contiene aproximadamente:

- 55 archivos que usan `SqlConnection`, `SqlCommand` o `SqlDataAdapter`;
- 807 archivos generados o consumidores de LINQ-to-SQL;
- 78 usos de `CommandType.StoredProcedure`;
- mapeos `dbo` y expresiones T-SQL como `CONVERT`, `ISNULL` y parámetros `@`.

El contexto `dcGRLLDataContext` se conserva temporalmente para que el código
recuperado compile. LINQ-to-SQL genera dialecto SQL Server y no puede ejecutarse
sobre Npgsql. Las pantallas que todavía lo usan no se consideran migradas.

## Seguridad del acceso

La tabla `Usuario` migrada no contiene una contraseña ni un hash. El login
actual selecciona el perfil de un usuario activo después de que PostgreSQL
autentica la cuenta de conexión. Esto sirve para desarrollo y para continuar la
migración, pero no debe publicarse en producción como autenticación de usuario
final.

Antes de producción se debe elegir e implementar una identidad verificable
(por ejemplo Active Directory/OIDC o una tabla de credenciales con hashes
modernos), además de una cuenta PostgreSQL de mínimo privilegio. Las claves se
inyectan mediante secretos; nunca se guardan en `app.config` ni en Git.

## Orden de trabajo recomendado

1. Recuperar en PostgreSQL claves primarias, foráneas, índices y restricciones.
2. Crear pruebas de caracterización contra SQL Server para empleados,
   asistencia, permisos, ficha social y reportes.
3. Migrar catálogos simples a repositorios Npgsql y retirar sus usos de
   `dcGRLLDataContext`.
4. Portar cada procedimiento `spRRHH_*` con consultas parametrizadas y pruebas
   de equivalencia.
5. Migrar las escrituras dentro de transacciones y resolver secuencias,
   booleanos, fechas, valores nulos y mayúsculas/minúsculas.
6. Migrar los TableAdapters y reportes.
7. Retirar finalmente `System.Data.SqlClient`, LINQ-to-SQL y la cadena SQL
   Server del programa.

## Criterio de terminado

La migración completa termina cuando no quedan dependencias de `SqlClient`, las
operaciones de lectura y escritura se ejecutan exclusivamente por PostgreSQL,
las reglas de integridad están restauradas y las pruebas funcionales pasan con
una copia anonimizada de QA.
