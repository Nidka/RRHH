using RRHH.Application.Asistencia;
using static RRHH.Web.Endpoints.ApiComun;

namespace RRHH.Web.Endpoints;

/// <summary>Vacaciones: generadas (RF-07), pendientes (RF-08), truncas (RF-09) y reporte (RF-11).</summary>
internal static class VacacionesEndpoints
{
    internal static void MapVacaciones(this RouteGroupBuilder operador)
    {
        var vacaciones = operador.MapGroup("/vacaciones").RequireAuthorization(CompositionRoot.PoliticaVacaciones);

        vacaciones.MapGet("/generadas", (int empleado, string corte, ReportarVacacionesGeneradas reporte) =>
            Ejecutar(() => Results.Ok(reporte.Ejecutar(empleado, Fecha(corte)))));

        vacaciones.MapGet("/saldo", (int empleado, string corte, ConsultarSaldoVacaciones consulta) =>
            Ejecutar(() => Results.Ok(consulta.Ejecutar(empleado, Fecha(corte)))));

        vacaciones.MapGet("/truncas", (int empleado, string cese, ConsultarVacacionesTruncas consulta) =>
            Ejecutar(() => Results.Ok(consulta.Ejecutar(empleado, Fecha(cese)))));

        vacaciones.MapGet("/reporte", (int anio, string corte, int? area, int? empleado, ReportarSaldoVacaciones reporte) =>
            Ejecutar(() => Results.Ok(reporte.Ejecutar(anio, Fecha(corte), area, empleado))));
    }
}
