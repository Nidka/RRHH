using System.Security.Claims;
using Microsoft.AspNetCore.Antiforgery;
using RRHH.Application.Catalogos;
using RRHH.Application.Permisos;
using RRHH.Domain.Permisos;
using static RRHH.Web.Endpoints.ApiComun;

namespace RRHH.Web.Endpoints;

/// <summary>Permisos y licencias: registro con validaciones (RF-03, RF-06, RF-10) y motivos (RF-04, RF-05).</summary>
internal static class PermisosEndpoints
{
    internal static void MapPermisos(this RouteGroupBuilder operador)
    {
        var permisos = operador.MapGroup("/permisos").RequireAuthorization(CompositionRoot.PoliticaPermisos);

        permisos.MapGet("", (int empleado, int numero, ConsultarPermiso consulta) =>
            Ejecutar(() => Results.Ok(consulta.Ejecutar(empleado, numero))));

        permisos.MapPost("", async (HttpContext context, PermisoGuardarDto entrada, IAntiforgery tokens,
            GuardarPermiso guardar) =>
        {
            if (!await tokens.IsRequestValidAsync(context)) return Results.BadRequest();
            var resultado = guardar.Ejecutar(entrada);
            return resultado.Exitoso ? Results.Ok(new { numero = entrada.Numero })
                : Results.BadRequest(new { error = resultado.Mensaje });
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
    }
}

internal sealed record AltaMotivo(int Tipo, string Descripcion, string Abreviatura, bool? Salario);
