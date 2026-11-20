using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using RRHH.Application.Asistencia;
using RRHH.Application.Catalogos;
using RRHH.Application.Permisos;
using RRHH.Application.Seguridad;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Comun;
using RRHH.Domain.Permisos;
using RRHH.Domain.Teletrabajo;
using RRHH.PostgreSql.Asistencia;

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
        new Claim(CompositionRoot.RolRrhh, usuario.IdRol.ToString(CultureInfo.InvariantCulture)),
        new Claim(ClaimTypes.Role, "OperadorTeletrabajo")
    }, CookieAuthenticationDefaults.AuthenticationScheme);
    await context.SignInAsync(new ClaimsPrincipal(identidad));
    return Results.NoContent();
}).RequireRateLimiting("login");

var operador = api.MapGroup("").RequireAuthorization(policy => policy.RequireRole("OperadorTeletrabajo"));
operador.MapGet("/sesion", async (ClaimsPrincipal usuario, IAuthorizationService autorizacion) =>
    Results.Ok(new
    {
        usuario = usuario.Identity?.Name,
        ausencias = (await autorizacion.AuthorizeAsync(usuario, CompositionRoot.PoliticaAusencias)).Succeeded,
        horarios = (await autorizacion.AuthorizeAsync(usuario, CompositionRoot.PoliticaHorarios)).Succeeded,
        motivos = (await autorizacion.AuthorizeAsync(usuario, CompositionRoot.PoliticaMotivos)).Succeeded,
        asistencia = (await autorizacion.AuthorizeAsync(usuario, CompositionRoot.PoliticaAsistencia)).Succeeded,
        vacaciones = (await autorizacion.AuthorizeAsync(usuario, CompositionRoot.PoliticaVacaciones)).Succeeded,
        permisos = (await autorizacion.AuthorizeAsync(usuario, CompositionRoot.PoliticaPermisos)).Succeeded
    }));
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
var ausencias = operador.MapGroup("/ausencias").RequireAuthorization(CompositionRoot.PoliticaAusencias);
ausencias.MapGet("/motivos", (ReportarAusenciasPorPeriodo reporte) => Results.Ok(reporte.ListarMotivos()));
ausencias.MapGet("", (string desde, string hasta, int? motivo, ReportarAusenciasPorPeriodo reporte) =>
    Ejecutar(() =>
    {
        var (inicio, fin) = PeriodoReporte(desde, hasta);
        if (motivo < 0)
            throw new ReglaNegocioException("Seleccione un motivo válido.");
        return Results.Ok(reporte.Ejecutar(inicio, fin, motivo));
    }));
var horarios = operador.MapGroup("/horarios").RequireAuthorization(CompositionRoot.PoliticaHorarios);
horarios.MapGet("/catalogo", (ListarHorarios listado) => Results.Ok(listado.Ejecutar()
    .Select(horario => new { horario.Id, horario.Descripcion })));
horarios.MapGet("/historico", (int empleado, HttpRequest solicitud, ConsultarHistoricoHorarios consulta) =>
    Ejecutar(() =>
    {
        var desde = solicitud.Query["desde"].ToString();
        var hasta = solicitud.Query["hasta"].ToString();
        return Results.Ok(consulta.Ejecutar(empleado, desde.Length == 0 ? null : Fecha(desde),
            hasta.Length == 0 ? null : Fecha(hasta)));
    }));
horarios.MapGet("/asignaciones/{empleado:int}/{numero:int}", (int empleado, int numero,
    PostgreSqlHorarioTemporalRepository repositorio) =>
    Ejecutar(() =>
    {
        if (empleado <= 0 || numero <= 0) throw new ReglaNegocioException("Indique un empleado y una asignación válidos.");
        var asignacion = repositorio.Obtener(empleado, numero);
        return asignacion is null
            ? Results.NotFound(new { error = "No se encontró la asignación." })
            : Results.Ok(asignacion);
    }));
horarios.MapPost("/asignaciones", async (HttpContext context, Turno entrada, IAntiforgery tokens,
    AsignarHorarioPorPeriodo guardar) =>
{
    if (!await tokens.IsRequestValidAsync(context)) return Results.BadRequest();
    return Ejecutar(() =>
    {
        var dto = new AsignacionHorarioDto
        {
            IdEmpleado = entrada.Empleado, Numero = entrada.Numero, IdHorario = entrada.Horario,
            Desde = Fecha(entrada.Desde), Hasta = Fecha(entrada.Hasta),
            Documento = entrada.Documento, Sisgedo = entrada.Sisgedo
        };
        var resultado = guardar.Ejecutar(dto);
        return resultado.Exitoso
            ? Results.Json(new { numero = dto.Numero }, statusCode: entrada.Numero == 0 ? 201 : 200)
            : Results.BadRequest(new { error = resultado.Mensaje });
    });
});
var motivos = operador.MapGroup("/motivos-permiso").RequireAuthorization(CompositionRoot.PoliticaMotivos);
motivos.MapGet("/tipos", (ListarCatalogo catalogo) => Results.Ok(catalogo.Ejecutar("")));
motivos.MapGet("", (int tipo, ClaimsPrincipal usuario, IMotivoPermisoRepository repositorio) =>
    Ejecutar(() => Results.Ok(new ListarMotivosPermiso(repositorio, AccesoMotivos(usuario)).Ejecutar(tipo))));
motivos.MapPost("", async (HttpContext context, AltaMotivo entrada, IAntiforgery tokens,
    IMotivoPermisoRepository repositorio) =>
{
    if (!await tokens.IsRequestValidAsync(context)) return Results.BadRequest();
    var dto = new MotivoPermisoDto
    {
        TipoPermisoId = entrada.Tipo, Descripcion = entrada.Descripcion,
        Abreviatura = entrada.Abreviatura, Salario = entrada.Salario
    };
    var resultado = new GuardarMotivoPermiso(repositorio, AccesoMotivos(context.User)).Ejecutar(dto);
    return resultado.Exitoso
        ? Results.Json(new { id = dto.Id }, statusCode: 201)
        : Results.BadRequest(new { error = resultado.Mensaje });
});
motivos.MapPost("/{id:int}/eliminar", async (int id, HttpContext context, IAntiforgery tokens,
    IMotivoPermisoRepository repositorio) =>
{
    if (!await tokens.IsRequestValidAsync(context)) return Results.BadRequest();
    var resultado = new EliminarMotivoPermiso(repositorio, AccesoMotivos(context.User)).Ejecutar(id);
    return resultado.Exitoso ? Results.NoContent() : Results.BadRequest(new { error = resultado.Mensaje });
});
operador.MapGet("/asistencia", (int empleado, string desde, string hasta, string modo,
    ReportarAsistenciaConFeriados reporte) => Ejecutar(() =>
{
    var (inicio, fin) = PeriodoReporte(desde, hasta);
    if (modo != "A" && modo != "P") throw new ReglaNegocioException("Seleccione Asistencias o Productividad.");
    return Results.Ok(reporte.Ejecutar(empleado, inicio, fin, modo == "P"));
})).RequireAuthorization(CompositionRoot.PoliticaAsistencia);
operador.MapGet("/vacaciones/generadas", (int empleado, string corte, ReportarVacacionesGeneradas reporte) =>
    Ejecutar(() => Results.Ok(reporte.Ejecutar(empleado, Fecha(corte)))))
    .RequireAuthorization(CompositionRoot.PoliticaVacaciones);
var permisos = operador.MapGroup("/permisos").RequireAuthorization(CompositionRoot.PoliticaPermisos);
operador.MapGet("/vacaciones/truncas",(int empleado,string cese,ConsultarVacacionesTruncas consulta) =>
    Ejecutar(()=>Results.Ok(consulta.Ejecutar(empleado,Fecha(cese)))))
    .RequireAuthorization(CompositionRoot.PoliticaVacaciones);
operador.MapGet("/vacaciones/saldo",(int empleado,string corte,ConsultarSaldoVacaciones consulta) =>
    Ejecutar(() => Results.Ok(consulta.Ejecutar(empleado,Fecha(corte)))))
    .RequireAuthorization(CompositionRoot.PoliticaVacaciones);
permisos.MapGet("", (int empleado, int numero, ConsultarPermiso consulta) =>
    Ejecutar(() => Results.Ok(consulta.Ejecutar(empleado, numero))));
permisos.MapPost("", async (HttpContext context, PermisoGuardarDto entrada, IAntiforgery tokens,
    GuardarPermiso guardar) =>
{
    if (!await tokens.IsRequestValidAsync(context)) return Results.BadRequest();
    var resultado = guardar.Ejecutar(entrada);
    return resultado.Exitoso ? Results.Ok(new { numero=entrada.Numero })
        : Results.BadRequest(new { error=resultado.Mensaje });
});
app.Run();

static AccesoMotivosPermiso AccesoMotivos(ClaimsPrincipal usuario) =>
    new(int.Parse(usuario.FindFirst(CompositionRoot.RolRrhh).Value, CultureInfo.InvariantCulture));

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
internal sealed record Turno(int Empleado, int Numero, int Horario, string Desde, string Hasta, string Documento, string Sisgedo);
internal sealed record AltaMotivo(int Tipo, string Descripcion, string Abreviatura, bool? Salario);
