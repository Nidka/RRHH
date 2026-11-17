# RRHH Web

Versión web de RF-13 y RF-14 para operadores de RRHH. Reutiliza dominio, casos de uso y repositorios de T3.

## Preparación segura

- SDK .NET 8 y base PostgreSQL de QA con datos ficticios.
- Preparar en esa base `BD/schema.sql`, el [esquema de autenticación](../../BD/password-auth.sql) y la [migración de teletrabajo](../../BD/migrations/20261112_03_teletrabajo.sql). Coordinar aplicación y respaldo con Kadin.
- Configurar `RRHH_WEB_POSTGRES` en el entorno del servidor con la cadena de esa base y `RRHH_WEB_ROLES` con los IDs de roles autorizados separados por comas. El piloto admite solo el rol devuelto por el login existente de RRHH. Los operadores habilitados pueden consultar y registrar para distintos empleados. Confirmar ese permiso con el equipo antes de habilitar un rol.
- Para habilitar el reporte RF-18, configurar `RRHH_WEB_ROLES_AUSENCIAS` con los IDs de roles autorizados para consultar motivos y ausencias. Deben estar también en `RRHH_WEB_ROLES`. Una lista vacía deshabilita el acceso al reporte.

## Ejecutar

Desde la raíz, con las variables ya configuradas:

```powershell
$env:ASPNETCORE_ENVIRONMENT = 'Development'
dotnet run --project Software/RRHH.Web --urls http://127.0.0.1:5080
```

Abrir http://localhost:5080 en el mismo equipo. Configurar HTTPS del host antes de exponerlo. Development se usa solo en loopback durante la prueba.

La instalación móvil y el modo PWA quedan pendientes para una entrega separada.

## Demostración y QA

Para una demo local desde cero, con PowerShell 7, SDK .NET 8 y los binarios de PostgreSQL instalados:

```powershell
pwsh -NoProfile -File Software/RRHH.Web/qa/Smoke.ps1 -PostgreSqlBin 'C:\Program Files\PostgreSQL\18\bin' -Demo
```

El comando genera un clúster de prueba, aplica la migración, crea dos empleados ficticios y muestra la URL y las credenciales del operador. Mantén la consola abierta mientras pruebas. Presiona Enter para detener ambos servicios. La contraseña del operador cambia en cada ejecución. Puedes usar `-Dotnet '<ruta a dotnet.exe>'` si usas un SDK local.

Para repetir la prueba HTTP y la suite de escritorio con sus casos de PostgreSQL, usa el mismo comando con `-RegresionEscritorio` en lugar de `-Demo`. Las pruebas de escritorio tienen una BD independiente de los registros de la demo dentro del clúster temporal.

1. Iniciar sesión con un operador ficticio de un rol habilitado.
2. Registrar un periodo total de lunes a viernes para un empleado ficticio. Consultar el periodo y anotar el ID.
3. Repetir el intervalo para el mismo empleado y verificar el mensaje de rechazo.
4. Consultar un rango con un feriado ficticio y comprobar los días remotos. Repetir con modalidad parcial.
5. Cerrar sesión y confirmar que los datos requieren una sesión válida.

Para revisión del alcance y reversión, ver la [spec](../../specs/CR-013-014-web-movil.md) y el [ADR](../docs/adr/0002-web-y-pwa.md).
