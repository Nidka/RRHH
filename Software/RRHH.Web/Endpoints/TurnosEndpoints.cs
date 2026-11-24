using Microsoft.AspNetCore.Antiforgery;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;
using RRHH.PostgreSql.Asistencia;
using static RRHH.Web.Endpoints.ApiComun;

namespace RRHH.Web.Endpoints;

/// <summary>Gestión de turnos: asignación por periodo (RF-01) e histórico (RF-02).</summary>
internal static class TurnosEndpoints
{
    internal static void MapTurnos(this RouteGroupBuilder operador)
    {
        var horarios = operador.MapGroup("/horarios").RequireAuthorization(CompositionRoot.PoliticaHorarios);

        horarios.MapGet("/catalogo", (ListarHorarios listado) => Results.Ok(listado.Ejecutar()
            .Select(horario => new { horario.Id, horario.Descripcion })));

        horarios.MapGet("/historico", (int empleado, HttpRequest solicitud, ConsultarHistoricoHorarios consulta) =>
            Ejecutar(() => Results.Ok(consulta.Ejecutar(empleado,
                FechaOpcional(solicitud.Query["desde"].ToString()),
                FechaOpcional(solicitud.Query["hasta"].ToString())))));

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
    }
}

internal sealed record Turno(int Empleado, int Numero, int Horario, string Desde, string Hasta, string Documento, string Sisgedo);
