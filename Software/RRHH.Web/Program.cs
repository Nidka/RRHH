using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using RRHH.Application.Seguridad;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Comun;
using RRHH.Domain.Teletrabajo;

var builder = WebApplication.CreateBuilder(args);
CompositionRoot.Configurar(builder);
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
    app.UseHttpsRedirection();
}
app.Use(async (context, next) =>
{
    context.Response.Headers["X-Content-Type-Options"] = "nosniff";
    context.Response.Headers["Content-Security-Policy"] =
        "default-src 'self'; object-src 'none'; base-uri 'none'; frame-ancestors 'none'; form-action 'self'";
    if (context.Request.Path.StartsWithSegments("/api"))
        context.Response.Headers.CacheControl = "no-store";
    await next();
});
app.UseExceptionHandler(error => error.Run(context =>
    Results.Problem("No se pudo completar la operación. Compruebe el entorno de RRHH.").ExecuteAsync(context)));
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.UseRateLimiter();

var api = app.MapGroup("/api");
api.MapGet("/token", (HttpContext context, IAntiforgery tokens) =>
    Results.Ok(new { token = tokens.GetAndStoreTokens(context).RequestToken }));

api.MapPost("/login", async (HttpContext context, Credenciales entrada, IAntiforgery tokens,
    ObtenerAccesoUsuario acceso, RolesOperador roles) =>
{
    if (!await tokens.IsRequestValidAsync(context)) return Results.BadRequest(new { error = "Actualice la página e intente de nuevo." });
    if (entrada.Login is null || entrada.Password is null || entrada.Login.Length > 128 || entrada.Password.Length > 256)
        return Results.Unauthorized();
    var usuario = acceso.Ejecutar("0500000", entrada.Login, entrada.Password);
    if (usuario is null || !roles.Contiene(usuario.IdRol)) return Results.Unauthorized();
    var identidad = new ClaimsIdentity(new[]
    {
        new Claim(ClaimTypes.NameIdentifier, usuario.IdUsuario.ToString(CultureInfo.InvariantCulture)),
        new Claim(ClaimTypes.Name, usuario.Login),
        new Claim(ClaimTypes.Role, "OperadorTeletrabajo")
    }, CookieAuthenticationDefaults.AuthenticationScheme);
    await context.SignInAsync(new ClaimsPrincipal(identidad));
    return Results.NoContent();
}).RequireRateLimiting("login");

var operador = api.MapGroup("").RequireAuthorization(policy => policy.RequireRole("OperadorTeletrabajo"));
operador.MapGet("/sesion", (ClaimsPrincipal usuario) => Results.Ok(new { usuario = usuario.Identity?.Name }));
operador.MapPost("/salir", async (HttpContext context, IAntiforgery tokens) =>
{
    if (!await tokens.IsRequestValidAsync(context)) return Results.BadRequest();
    await context.SignOutAsync();
    return Results.NoContent();
});
operador.MapGet("/periodos", (int empleado, ListarPeriodosTeletrabajo listado) =>
    Ejecutar(() => Results.Ok(listado.Ejecutar(empleado))));
operador.MapPost("/periodos", async (HttpContext context, Alta entrada, IAntiforgery tokens,
    RegistrarPeriodoTeletrabajo registro) =>
{
    if (!await tokens.IsRequestValidAsync(context)) return Results.BadRequest();
    return Ejecutar(() => Results.Json(new
    {
        id = registro.Ejecutar(entrada.Empleado, Fecha(entrada.Desde), Fecha(entrada.Hasta),
            entrada.Modalidad switch
            {
                "T" => ModalidadTeletrabajo.Total,
                "P" => ModalidadTeletrabajo.Parcial,
                _ => throw new ReglaNegocioException("Seleccione una modalidad válida.")
            }, entrada.DiasRemotos, entrada.Autorizacion)
    }, statusCode: 201));
});
operador.MapGet("/reporte", (int? empleado, string desde, string hasta, ReportarDiasTeletrabajo reporte) =>
    Ejecutar(() =>
    {
        var (inicio, fin) = PeriodoReporte(desde, hasta);
        return Results.Ok(reporte.Ejecutar(empleado, inicio, fin));
    }));
operador.MapGet("/clasificacion-teletrabajo", (string desde, string hasta, HttpRequest solicitud,
    ReportarTeletrabajoTotalOParcial reporte) =>
    Ejecutar(() =>
    {
        var (inicio, fin) = PeriodoReporte(desde, hasta);
        ModalidadTeletrabajo? filtro = solicitud.Query["clase"].ToString() switch
        {
            "" => null,
            "T" => ModalidadTeletrabajo.Total,
            "P" => ModalidadTeletrabajo.Parcial,
            _ => throw new ReglaNegocioException("Seleccione una clasificación válida.")
        };
        return Results.Ok(reporte.Ejecutar(inicio, fin, filtro));
    }));
app.Run();

static (DateTime Inicio, DateTime Fin) PeriodoReporte(string desde, string hasta)
{
    var inicio = Fecha(desde);
    var fin = Fecha(hasta);
    if ((fin - inicio).TotalDays > 366)
        throw new ReglaNegocioException("Consulte intervalos de hasta 367 días.");
    return (inicio, fin);
}

static DateTime Fecha(string texto) =>
    DateTime.TryParseExact(texto, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var fecha)
        && fecha.Year is >= 1900 and <= 9998
        ? fecha
        : throw new ReglaNegocioException("Use fechas válidas entre 1900 y 9998.");

static IResult Ejecutar(Func<IResult> operacion)
{
    try { return operacion(); }
    catch (ReglaNegocioException ex) { return Results.BadRequest(new { error = ex.Message }); }
}

internal sealed record Credenciales(string Login, string Password);
internal sealed record Alta(int Empleado, string Desde, string Hasta, string Modalidad, int DiasRemotos, string Autorizacion);
