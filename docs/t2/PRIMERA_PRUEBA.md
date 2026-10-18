# Primera prueba antes de refactorizar

Actualización: 16/10/2026. Base de código: `eeeb817`.

## Estado y evidencia disponible

- Evelyn informó que Francisco Kadin Valera Lizarraga completó el despliegue de BD.
- El asistente comprobó conexión con psql y TLS 1.3, presencia de Usuario, Persona, Empleado, Horario, RRHH_Feriado y Motivo_Perm, y columna Usuario.PasswordHash. Solo consultas de metadatos en transacción de lectura; sin filas personales ni modificaciones.
- [Resultado real de conexión/esquema](evidencias/VERIFICACION_BD_2026-10-16.txt). El cifrado del cliente se identifica con conninfo; la salida pg_stat_ssl del backend tras el pooler no sustituye esa comprobación.
- Esta comprobación no ejecuta WinForms ni valida Npgsql, permisos de aplicación, escrituras, cálculos o todos los módulos. El entorno del asistente es macOS, sin dotnet ni el ejecutable local.
- El README y las notas remotas reportan 65 pruebas y consultas de módulos contra Neon el 15/10; esos resultados pertenecen al avance recibido, no a una nueva ejecución del asistente.

## Preparación en Windows

1. Obtener la versión `eeeb817` o posterior y, cuando se comparta, la rama integrada con planes/prompts. Conservar los cambios propios antes de actualizar.
2. En la raíz, junto a `.env.example`, crear `.env` copiando la plantilla. Si ya existe, revisarlo localmente sin sobrescribirlo ni mostrarlo en capturas.

```powershell
Copy-Item .env.example .env
```

Completar el archivo con los valores que Kadin compartió por el canal privado:

```dotenv
DB_HOST=<servidor-compartido>
DB_PORT=5432
DB_USER=<usuario-bd>
DB_PASSWORD=<clave-bd>
DB_NAME=<nombre-bd>
DB_SSLMODE=require
DB_CHANNEL_BINDING=require
```

No pegar la clave en prompts, commits, evidencias ni README. `.env` está ignorado por Git. El cargador busca en carpetas ascendentes desde el ejecutable y el directorio de trabajo; permite ruta explícita con RRHH_ENV_FILE. RRHH_POSTGRES_CONNECTION y variables ya definidas en el proceso tienen prioridad sobre los valores del archivo: revisar configuraciones antiguas si conecta a otra BD.

El constructor Npgsql actual no aplica DB_CHANNEL_BINDING; su comentario explica que Npgsql 4.1 no expone esa opción. Mantener el archivo compartido no equivale a verificar channel binding del aplicativo. La comprobación psql no certifica la implementación TLS de Npgsql.

3. Abrir en Windows el ejecutable compilado de la versión indicada:

```powershell
.\Software\RecursosHumanos\bin\x86\Debug\net48\RecursosHumanos.exe
```

Los binarios no están en Git. Si falta el exe, preparar dependencias según README y compilar con `Software\scripts\build.cmd`; no confundir una copia antigua del exe con el código recién descargado.

4. Iniciar sesión con **usuario y contraseña de RRHH** proporcionados para pruebas. La cuenta PostgreSQL de `.env` conecta la aplicación; no es automáticamente el usuario del formulario. Kadin debe confirmar el usuario de prueba y que tiene hash/rol/empleado válidos. No cambiar contraseñas ni dar acceso a usuarios sin encargo expreso.

## Recorrido inicial de los cuatro

Esta primera sesión caracteriza el comportamiento existente. Evitar altas, ediciones y borrados en la BD compartida hasta que Kadin confirme datos ficticios/entorno y alcance de escritura; no asumir que desplegada equivale a copia QA aislada.

| Integrante | Qué probar primero | Evidencia para su paquete |
|---|---|---|
| Jorge | Abrir listado de horarios y consultar el editor sin guardar | Menú, campos, datos mostrados, flujo y errores; base TEC-001 |
| Kadin | Confirmar entorno/datos de prueba, acceso de aplicación y scripts de comprobación | Versión de esquema, conexión, limitaciones, runbook y resultados; TEC-002 |
| Frank | Abrir feriados y revisar navegación de asistencia/reportes de solo lectura | Pantallas, filtros, salidas, errores y protocolo de caracterización; TEC-003 |
| Evelyn | Consultar tipos/motivos y observar el editor | Reglas/modalidad por rol, captura saneada, diagnóstico; TEC-004. Atención: el código del editor contiene Update durante Load; no abrirlo contra datos reales hasta aislar el caso |

Después de confirmar QA y alcance, cada responsable ejecuta los casos de escritura de su spec con registros ficticios identificados y deja evidencia de antes/después. Conservar comportamiento que no se pretende cambiar y registrar defectos de forma reproducible.

## Comprobaciones adicionales en Windows

Desde la raíz y con el ejecutable compilado:

```powershell
.\Software\scripts\check-postgresql.cmd
.\Software\scripts\check-postgresql.cmd -Modules
dotnet test .\Software\RRHH.Tests\RRHH.Tests.csproj --no-restore -c Debug
```

El script de módulos hace lecturas representativas; no sustituye abrir formularios ni las pruebas de escritura. Guardar comandos, entorno y resultado real sin claves/datos personales. Si falla una dependencia o un módulo, registrar el error y su impacto en la spec, sin marcarlo aprobado.

## Qué cambió para nuestros planes

`eeeb817` añade carga `.env`, autenticación con contraseña PBKDF2 y un puente PostgreSQL para mappers/procedimientos heredados. Por tanto, los nombres XxxMapper ya no prueban por sí solos que la pantalla use SQL Server: revisar el tipo local en PostgreSqlLegacyMapper/PostgreSqlLegacyContext y sus llamadas.

Los paquetes horarios, feriados y motivos siguen vigentes como refactorización hacia casos de uso, repositorios y presenters específicos. Su primera tarea es caracterizar la versión operativa nueva; no volver a implementar la conexión ni atribuir al estado actual defectos históricos ya resueltos. Integridad/IDs sigue en TEC-002; desplegar no cierra esa parte.

Tras este recorrido: actualizar spec con base/diagnóstico → programar en rama propia → pruebas/QA → PR → revisión ajena → evidencia para T2. Los prompts ya exigen este paso inicial.
