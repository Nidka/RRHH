# Migracion a PostgreSQL

## Estado operativo

La aplicacion se ejecuta con PostgreSQL/Npgsql. El arranque no crea una
conexion SQL Server y los formularios recuperados usan implementaciones
PostgreSQL compatibles para sus mappers y procedimientos heredados.

Flujos cubiertos:

- autenticacion con PBKDF2-SHA256 y permisos del sistema RRHH;
- catalogos, empleados, personas y ubigeo;
- permisos, horarios, locales y feriados;
- asistencia diaria, semanal, faltas, tardanzas y horas extra;
- importacion biometrica desde Access hacia PostgreSQL;
- legajo, ficha social, documentos y archivos;
- reportes de personal, oficinas, cumpleanos, permisos y ficha social.

La migracion `BD/migrations/20261015_01_complete_module_tables.sql` agrega de
forma idempotente las tablas `Documento`, `Archivo`, `Ingreso` y `Egreso` que
no estaban en el dump PostgreSQL inicial.

## Verificacion

```powershell
.\Software\scripts\check-postgresql.cmd
.\Software\scripts\check-postgresql.cmd -Modules
dotnet test .\Software\RRHH.Tests\RRHH.Tests.csproj --no-restore -c Debug
```

`-Modules` ejecuta consultas reales de empleados, tipos, motivos, ubigeo,
horarios, locales, asistencia, cumpleanos, ficha social y documentos. La
prueba se ejecuto correctamente contra Neon el 2026-10-15; no escribe datos.

## Importacion biometrica

Los relojes antiguos siguen entregando archivos `Marcacion.mdb`. Esto no
convierte Access en base principal: `AsistenciaAccess` lee el archivo local y
guarda `Asistencia` y `Marcacion` en PostgreSQL dentro de una transaccion. El
equipo que ejecute este proceso necesita:

- plataforma x86;
- Microsoft Jet OLE DB 4.0 de 32 bits;
- acceso a la ruta configurada para la sede, PROIND o CONSEJO.

## Artefactos heredados

Las fuentes decompiladas conservan clases LINQ-to-SQL y `TableAdapter`
generados para los disenadores antiguos de Visual Studio/DevExpress. Se
mantienen como referencia y compatibilidad visual. La ruta funcional de los
formularios usa `PostgreSqlLegacyMapper`, `PostgreSqlLegacyContext` y
`RRHHClass`; esta ultima no expone ni inicializa ya `SqlConnection`.

Tambien existe codigo SQL Server deshabilitado con `#if false` dentro de
`RRHHClass` para comparar la forma de los reportes durante la refactorizacion.
No se incluye en el ensamblado.

## Brecha del esquema

El dump PostgreSQL contiene datos y tablas, pero no recupero todas las claves,
restricciones, vistas ni rutinas de la base SQL Server original. Algunas
tablas restauradas tienen duplicados y no se deben agregar restricciones a
ciegas. La ruta segura es:

1. trabajar con una copia anonimizada;
2. detectar y resolver duplicados;
3. agregar indices y claves por modulo mediante migraciones idempotentes;
4. ejecutar pruebas de caracterizacion antes y despues;
5. desplegar primero en QA y luego en produccion.

## Seguridad

`.env`, `BD/CMI.sql`, dumps y respaldos estan excluidos de Git. Cada
desarrollador usa su propia configuracion local. En CI y produccion las
credenciales deben venir del almacen de secretos de la plataforma.

Las cuentas importadas sin hash no pueden iniciar sesion. Un administrador
asigna la clave con `scripts/set-user-password.cmd`, que nunca la recibe como
argumento visible del proceso.

## Trabajo estructural pendiente

La migracion operativa no equivale a una modernizacion completa. Queda:

1. reemplazar el puente generico por repositorios por caso de uso;
2. retirar `TableAdapter` y fuentes SQL Server no usadas de los reportes;
3. restaurar reglas de integridad del esquema despues de sanear los datos;
4. agregar pruebas funcionales de escritura con una copia anonimizada de QA;
5. modernizar gradualmente DevExpress 11.2 y los controles de `GRLL.dll`.
