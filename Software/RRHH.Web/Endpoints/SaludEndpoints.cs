using RRHH.PostgreSql;

namespace RRHH.Web.Endpoints;

/// <summary>Sondas de la plataforma de despliegue.</summary>
internal static class SaludEndpoints
{
    internal static void MapSalud(this WebApplication app)
    {
        // Vivacidad: el proceso responde. No toca la base, para que una caída de la base no reinicie el contenedor.
        app.MapGet("/salud", () => Results.Ok(new { estado = "ok" }));

        // Disponibilidad: además comprueba que la base responde.
        app.MapGet("/salud/lista", (PostgreSqlExecutor baseDatos, ILoggerFactory registros) =>
        {
            try
            {
                baseDatos.ScalarInt("SELECT 1;");
                return Results.Ok(new { estado = "ok", baseDatos = "ok" });
            }
            catch (Exception ex)
            {
                // Solo los tipos de excepción: el mensaje de Npgsql puede incluir fragmentos de la cadena de conexión (usuario y clave).
                registros.CreateLogger("Salud").LogWarning("La base de datos no respondió: {Tipo} (interna: {Interna})", ex.GetType().Name, ex.InnerException?.GetType().Name ?? "ninguna");
                return Results.Json(new { estado = "degradado", baseDatos = "sin conexión" }, statusCode: 503);
            }
        });
    }
}
