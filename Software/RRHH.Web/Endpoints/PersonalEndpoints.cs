using System.Globalization;
using RRHH.Application.Personal;
using RRHH.Domain.Comun;
using static RRHH.Web.Endpoints.ApiComun;

namespace RRHH.Web.Endpoints;

/// <summary>Búsqueda de empleados y nombres para los formularios y reportes de todos los módulos (CR-019).</summary>
internal static class PersonalEndpoints
{
    /// <remarks>
    /// Solo para operadores: devuelven identificador, nombre, documento y estado, nada más.
    /// La autoconsulta no los usa porque siempre trabaja con el empleado de la propia sesión.
    /// </remarks>
    internal static void MapPersonal(this RouteGroupBuilder operador)
    {
        operador.MapGet("/empleados", (string texto, BuscarEmpleados buscar) => Results.Ok(buscar.Ejecutar(texto)));

        // Códigos separados por coma: /api/empleados/nombres?codigos=101,102
        operador.MapGet("/empleados/nombres", (string codigos, ObtenerNombresEmpleados nombres) =>
            Ejecutar(() => Results.Ok(nombres.Ejecutar(Codigos(codigos)))));
    }

    private static IEnumerable<int> Codigos(string texto) =>
        (texto ?? string.Empty).Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(parte => int.TryParse(parte, NumberStyles.None, CultureInfo.InvariantCulture, out var codigo)
                ? codigo
                : throw new ReglaNegocioException("Los códigos de empleado deben ser números separados por coma."));
}
