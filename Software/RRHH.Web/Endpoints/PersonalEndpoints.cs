using RRHH.Application.Personal;

namespace RRHH.Web.Endpoints;

/// <summary>Búsqueda de empleados para los formularios de todos los módulos (CR-019).</summary>
internal static class PersonalEndpoints
{
    /// <remarks>
    /// Solo para operadores: devuelve identificador, nombre, documento y estado, nada más.
    /// La autoconsulta no la usa porque siempre trabaja con el empleado de la propia sesión.
    /// </remarks>
    internal static void MapPersonal(this RouteGroupBuilder operador)
    {
        operador.MapGet("/empleados", (string texto, BuscarEmpleados buscar) => Results.Ok(buscar.Ejecutar(texto)));
    }
}
