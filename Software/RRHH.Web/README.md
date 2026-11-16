# RRHH Web y móvil

Piloto RF-13/14 para escritorio en navegador y móvil como PWA. Reutiliza dominio, casos de uso y repositorios de T3. La PWA requiere conexión para autenticación y operaciones.

## Preparación segura

- SDK .NET 8 y base PostgreSQL de QA con datos ficticios.
- Preparar en esa base `BD/schema.sql`, el [esquema de autenticación](../../BD/password-auth.sql) y la [migración de teletrabajo](../../BD/migrations/20261112_03_teletrabajo.sql). Coordinar aplicación y respaldo con Kadin.
- Configurar `RRHH_WEB_POSTGRES` en el entorno del servidor con la cadena de esa base y `RRHH_WEB_ROLES` con los IDs de roles autorizados separados por comas. El piloto admite solo el rol devuelto por el login existente de RRHH. Los operadores habilitados pueden consultar y registrar para distintos empleados. Confirmar ese permiso con el equipo antes de habilitar un rol.

## Ejecutar

Desde la raíz, con las variables ya configuradas:

```powershell
$env:ASPNETCORE_ENVIRONMENT = 'Development'
dotnet run --project Software/RRHH.Web --urls http://127.0.0.1:5080
```

Abrir http://localhost:5080 en el mismo equipo. Para un teléfono, ejecutar el host detrás de HTTPS con un certificado que el dispositivo acepte y usar el origen asignado al piloto. Configurar HTTPS del host antes de exponerlo. Development se usa solo en loopback durante la prueba.

En móvil, abrir la URL en el navegador y elegir **Instalar aplicación** o **Añadir a pantalla de inicio** si está disponible. Se presenta la misma operación a una columna y con controles táctiles. Los recursos estáticos se almacenan en caché. La sesión y las respuestas de la API quedan fuera de la caché de la PWA.

## Demostración y QA

1. Iniciar sesión con un operador ficticio de un rol habilitado.
2. Registrar un periodo total de lunes a viernes para un empleado ficticio. Consultar el periodo y anotar el ID.
3. Repetir el intervalo para el mismo empleado y verificar el mensaje de rechazo.
4. Consultar un rango con un feriado ficticio y comprobar los días remotos. Repetir con modalidad parcial.
5. Cerrar sesión y confirmar que los datos requieren una sesión válida. Repetir desde el teléfono y comprobar la instalación de la PWA.

Para revisión del alcance y reversión, ver la [spec](../../specs/CR-013-014-web-movil.md) y el [ADR](../docs/adr/0002-web-y-pwa.md).
