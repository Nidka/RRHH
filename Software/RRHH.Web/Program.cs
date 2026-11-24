using RRHH.Web.Endpoints;

// Configuración y composición del host. Cada módulo de negocio registra sus rutas en Endpoints/ (CR-019).
var builder = WebApplication.CreateBuilder(args);
CompositionRoot.Configurar(builder);
var app = builder.Build();
// Detrás de un proxy de plataforma (Render, etc.) la IP y el esquema reales llegan en X-Forwarded-*.
if (app.Configuration.GetValue<bool>("RRHH_WEB_TRUST_PROXY"))
    app.UseForwardedHeaders();
// Las sondas de salud de la plataforma llegan por HTTP interno: no se redirigen.
app.UseWhen(context => !context.Request.Path.StartsWithSegments("/salud"), rama =>
{
    if (!app.Environment.IsDevelopment())
    {
        rama.UseHsts();
        rama.UseHttpsRedirection();
    }
});
app.Use(async (context, next) =>
{
    context.Response.Headers["X-Content-Type-Options"] = "nosniff";
    context.Response.Headers["Content-Security-Policy"] =
        "default-src 'self'; object-src 'none'; base-uri 'none'; frame-ancestors 'none'; form-action 'self'";
    if (context.Request.Path.StartsWithSegments("/api") || context.Request.Path.StartsWithSegments("/salud"))
        context.Response.Headers.CacheControl = "no-store";
    await next();
});
app.UseExceptionHandler(error => error.Run(context =>
    Results.Problem("No se pudo completar la operación. Compruebe el entorno de RRHH.").ExecuteAsync(context)));
app.UseDefaultFiles();
app.UseStaticFiles(new StaticFileOptions
{
    // El service worker y el manifiesto deben revalidarse siempre para que las actualizaciones lleguen.
    OnPrepareResponse = archivo =>
    {
        if (archivo.File.Name is "service-worker.js" or "manifest.webmanifest")
            archivo.Context.Response.Headers.CacheControl = "no-cache";
    }
});
app.UseAuthentication();
app.UseAuthorization();
app.UseRateLimiter();

app.MapSalud();

var api = app.MapGroup("/api");
api.MapCuenta();

var operador = api.MapGroup("").RequireAuthorization(policy => policy.RequireRole(CuentaEndpoints.RolOperador));
operador.MapTurnos();
operador.MapPermisos();
operador.MapVacaciones();
operador.MapTeletrabajo();
operador.MapReportes();
operador.MapPersonal();

app.Run();
