using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using RRHH.Application.Asistencia;
using RRHH.Application.Navegacion;
using RRHH.Application.Seguridad;
using RRHH.Domain.Comun;
using static RRHH.Web.Endpoints.ApiComun;

namespace RRHH.Web.Endpoints;

/// <summary>Sesión, navegación y autoconsulta (RF-12).</summary>
internal static class CuentaEndpoints
{
    internal const string RolOperador = "OperadorTeletrabajo";
    internal const string RolEmpleado = "Empleado";

    internal static void MapCuenta(this RouteGroupBuilder api)
    {
        api.MapGet("/token", (HttpContext context, IAntiforgery tokens) =>
            Results.Ok(new { token = tokens.GetAndStoreTokens(context).RequestToken }));

        api.MapPost("/login", async (HttpContext context, Credenciales entrada, IAntiforgery tokens,
            ObtenerAccesoUsuario acceso, RolesOperador roles, RolesAutoservicio autoservicio, IUsuarioEmpleadoRepository vinculos) =>
        {
            if (!await tokens.IsRequestValidAsync(context)) return Results.BadRequest(new { error = "Actualice la página e intente de nuevo." });
            if (entrada.Login is null || entrada.Password is null || entrada.Login.Length > 128 || entrada.Password.Length > 256)
                return Results.Unauthorized();
            var usuario = acceso.Ejecutar("0500000", entrada.Login, entrada.Password);
            if (usuario is null || (!roles.Contiene(usuario.IdRol) && !autoservicio.Contiene(usuario.IdRol))) return Results.Unauthorized();
            bool empleado = autoservicio.Contiene(usuario.IdRol);
            if (empleado)
            {
                try { vinculos.ObtenerEmpleado(usuario.IdUsuario); }
                catch (ReglaNegocioException) { return Results.Unauthorized(); }
            }
            var identidad = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, usuario.IdUsuario.ToString(CultureInfo.InvariantCulture)),
                new Claim(ClaimTypes.Name, usuario.Login),
                new Claim(CompositionRoot.RolRrhh, usuario.IdRol.ToString(CultureInfo.InvariantCulture)),
                new Claim(ClaimTypes.Role, empleado ? RolEmpleado : RolOperador)
            }, CookieAuthenticationDefaults.AuthenticationScheme);
            await context.SignInAsync(new ClaimsPrincipal(identidad));
            return Results.NoContent();
        }).RequireRateLimiting("login");

        var sesion = api.MapGroup("").RequireAuthorization();
        sesion.MapGet("/sesion", async (ClaimsPrincipal usuario, IAuthorizationService autorizacion) =>
        {
            var permisos = await PermisosSesion.CalcularAsync(usuario, autorizacion);
            return Results.Ok(new
            {
                usuario = usuario.Identity?.Name,
                operador = permisos.Operador,
                autoconsulta = permisos.Autoconsulta,
                ausencias = permisos.Ausencias,
                horarios = permisos.Horarios,
                motivos = permisos.Motivos,
                asistencia = permisos.Asistencia,
                vacaciones = permisos.Vacaciones,
                permisos = permisos.Permisos,
                personal = permisos.Personal
            });
        });
        // CR-019: la navegación se arma en el servidor desde el catálogo único de módulos.
        sesion.MapGet("/modulos", async (ClaimsPrincipal usuario, IAuthorizationService autorizacion) =>
        {
            var permisos = await PermisosSesion.CalcularAsync(usuario, autorizacion);
            return Results.Ok(CatalogoModulos.Visibles(permisos.Habilita).Select(modulo => new
            {
                modulo.Clave,
                modulo.Titulo,
                Pantallas = modulo.Pantallas.Select(p => new { p.Clave, p.Titulo, p.Requerimientos })
            }));
        });
        sesion.MapPost("/salir", async (HttpContext context, IAntiforgery tokens) =>
        {
            if (!await tokens.IsRequestValidAsync(context)) return Results.BadRequest();
            await context.SignOutAsync();
            return Results.NoContent();
        });

        api.MapGet("/mi/vacaciones", (ClaimsPrincipal usuario, string corte, ConsultarMisVacaciones consulta) =>
            Ejecutar(() => Results.Ok(consulta.Ejecutar(
                int.Parse(usuario.FindFirstValue(ClaimTypes.NameIdentifier), CultureInfo.InvariantCulture), Fecha(corte)))))
            .RequireAuthorization(p => p.RequireRole(RolEmpleado));
    }
}

/// <summary>Permisos de la sesión actual, evaluados con las mismas políticas que protegen los endpoints.</summary>
internal sealed record PermisosSesion(bool Operador, bool Autoconsulta, bool Ausencias, bool Horarios,
    bool Motivos, bool Asistencia, bool Vacaciones, bool Permisos, bool Personal)
{
    internal static async Task<PermisosSesion> CalcularAsync(ClaimsPrincipal usuario, IAuthorizationService autorizacion)
    {
        async Task<bool> Cumple(string politica) => (await autorizacion.AuthorizeAsync(usuario, politica)).Succeeded;
        return new PermisosSesion(
            usuario.IsInRole(CuentaEndpoints.RolOperador),
            usuario.IsInRole(CuentaEndpoints.RolEmpleado),
            await Cumple(CompositionRoot.PoliticaAusencias),
            await Cumple(CompositionRoot.PoliticaHorarios),
            await Cumple(CompositionRoot.PoliticaMotivos),
            await Cumple(CompositionRoot.PoliticaAsistencia),
            await Cumple(CompositionRoot.PoliticaVacaciones),
            await Cumple(CompositionRoot.PoliticaPermisos),
            await Cumple(CompositionRoot.PoliticaPersonal));
    }

    /// <summary>
    /// Indica si la sesión puede usar las pantallas de un permiso. Fuera de la autoconsulta, toda pantalla
    /// exige además el rol de operador, igual que el grupo de endpoints que la atiende.
    /// </summary>
    internal bool Habilita(PermisoModulo permiso) => permiso switch
    {
        PermisoModulo.Autoconsulta => Autoconsulta,
        PermisoModulo.Teletrabajo => Operador,
        PermisoModulo.Ausencias => Operador && Ausencias,
        PermisoModulo.Horarios => Operador && Horarios,
        PermisoModulo.Motivos => Operador && Motivos,
        PermisoModulo.Asistencia => Operador && Asistencia,
        PermisoModulo.Vacaciones => Operador && Vacaciones,
        PermisoModulo.Permisos => Operador && Permisos,
        PermisoModulo.Personal => Operador && Personal,
        _ => false
    };
}

internal sealed record Credenciales(string Login, string Password);
