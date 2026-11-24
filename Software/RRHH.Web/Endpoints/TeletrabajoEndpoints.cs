using Microsoft.AspNetCore.Antiforgery;
using RRHH.Application.Asistencia;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Comun;
using RRHH.Domain.Teletrabajo;
using static RRHH.Web.Endpoints.ApiComun;

namespace RRHH.Web.Endpoints;

/// <summary>Teletrabajo y presencialidad: registro (RF-13), días (RF-14), consolidado (RF-15) y clasificación (RF-16).</summary>
internal static class TeletrabajoEndpoints
{
    internal static void MapTeletrabajo(this RouteGroupBuilder operador)
    {
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

        operador.MapGet("/asistencia/consolidada", (int empleado, string desde, string hasta, ConsolidarAsistencia consulta) =>
            Ejecutar(() => Results.Ok(consulta.Ejecutar(empleado, Fecha(desde), Fecha(hasta)))))
            .RequireAuthorization(CompositionRoot.PoliticaAsistencia);
    }
}

internal sealed record Alta(int Empleado, string Desde, string Hasta, string Modalidad, int DiasRemotos, string Autorizacion);
