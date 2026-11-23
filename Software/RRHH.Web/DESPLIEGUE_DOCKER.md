# Despliegue de RRHH Web con Docker

El Dockerfile compila RRHH.Web para .NET 8. La imagen de ejecución usa el usuario
sin privilegios `app` y escucha por HTTP en el puerto 8080 del contenedor. Usa
Npgsql y la conexión `RRHH_WEB_POSTGRES`; las migraciones se administran por
separado. El contenedor no incluye una base ni credenciales.

## Preparar PostgreSQL

- Usar una base de QA migrada para la primera validación. Si se usa Neon, tomar
  del proyecto autorizado el host, puerto, usuario, base y parámetros TLS.
- Configurar una cuenta de aplicación con los permisos de lectura y escritura
  requeridos en los módulos habilitados. Usar un usuario de migración separado.
- Introducir una cadena Npgsql en el gestor de secretos del host. Ejemplo de
  formato sin valores reales: `Host=HOST;Port=5432;Database=BD;Username=ROL_APP;Password=CLAVE;SSL Mode=VerifyFull`.
- Configurar los IDs de operador y autoconsulta según el catálogo del destino.
  Mantener ambas listas separadas. Cada módulo operativo tiene su propia lista
  y cada cuenta de autoconsulta requiere un vínculo único y activo.

## Prueba local en Windows o macOS

Con Docker y Compose en ejecución, copiar `.env.docker.example` a `.env` en
la raíz. Configurar `RRHH_WEB_ENVIRONMENT=Development`, la conexión de QA y
los roles ficticios de esa base. Desde la raíz:

```sh
docker compose up --build -d
docker compose ps
docker compose logs --tail=40 web
```

Abrir `http://127.0.0.1:8080` desde el mismo equipo. Si PostgreSQL se encuentra
en esa Mac o Windows, desde Docker Desktop se utiliza `host.docker.internal`
en lugar de `localhost`. PostgreSQL debe admitir esa conexión. Una base remota
usa su propio host DNS. Para terminar, ejecutar `docker compose down`.

## Acceso desde otro equipo

En el servidor, pasar el entorno `Production`, la conexión y roles en el gestor
de configuración del alojamiento. Configurar el puerto interno 8080 y un proxy
o plataforma que termine HTTPS y redirija HTTP a HTTPS. Con Compose, exponer
solo el puerto de loopback a un proxy HTTPS configurado en ese mismo servidor.
La URL pública será la que asigne el alojamiento.

Antes de anunciarla, comprobar desde otra máquina que el sitio carga por HTTPS,
que una cuenta ficticia inicia sesión, que consulta su saldo y que los módulos
operativos están bloqueados para ese rol. La carga del HTML por sí sola no
demuestra conectividad con PostgreSQL ni autenticación.
