using RRHH.Application.Asistencia;
using RRHH.Application.Permisos;
using RRHH.Domain.Comun;
using static RRHH.Web.Endpoints.ApiComun;

namespace RRHH.Web.Endpoints;

/// <summary>Reportes generales: asistencia con feriados (RF-17) y ausencias por periodo (RF-18).</summary>
internal static class ReportesEndpoints
{
    internal static void MapReportes(this RouteGroupBuilder operador)
    {
        operador.MapGet("/asistencia", (int empleado, string desde, string hasta, string modo,
            ReportarAsistenciaConFeriados reporte) => Ejecutar(() =>
        {
            var (inicio, fin) = PeriodoReporte(desde, hasta);
            if (modo != "A" && modo != "P") throw new ReglaNegocioException("Seleccione Asistencias o Productividad.");
            return Results.Ok(reporte.Ejecutar(empleado, inicio, fin, modo == "P"));
        })).RequireAuthorization(CompositionRoot.PoliticaAsistencia);

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
    }
}
