using System.Globalization;
using System.Security.Claims;
using RRHH.Domain.Comun;
using RRHH.Domain.Permisos;

namespace RRHH.Web.Endpoints;

/// <summary>Reglas comunes de entrada y salida que comparten todos los módulos de la API.</summary>
internal static class ApiComun
{
    /// <summary>Convierte una fecha <c>yyyy-MM-dd</c>; fuera de 1900-9998 es una regla de negocio incumplida.</summary>
    internal static DateTime Fecha(string texto) =>
        DateTime.TryParseExact(texto, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var fecha)
            && fecha.Year is >= 1900 and <= 9998
            ? fecha
            : throw new ReglaNegocioException("Use fechas válidas entre 1900 y 9998.");

    /// <summary>Fecha opcional: un texto vacío o ausente significa «sin límite».</summary>
    internal static DateTime? FechaOpcional(string texto) => string.IsNullOrEmpty(texto) ? null : Fecha(texto);

    /// <summary>Periodo de reporte de hasta 367 días, para acotar el costo de las consultas.</summary>
    internal static (DateTime Inicio, DateTime Fin) PeriodoReporte(string desde, string hasta)
    {
        var inicio = Fecha(desde);
        var fin = Fecha(hasta);
        if ((fin - inicio).TotalDays > 366)
            throw new ReglaNegocioException("Consulte intervalos de hasta 367 días.");
        return (inicio, fin);
    }

    /// <summary>Ejecuta la operación y traduce una regla de negocio incumplida a 400 con su mensaje.</summary>
    internal static IResult Ejecutar(Func<IResult> operacion)
    {
        try { return operacion(); }
        catch (ReglaNegocioException ex) { return Results.BadRequest(new { error = ex.Message }); }
    }

    /// <summary>Acceso a motivos según el rol RRHH de la sesión.</summary>
    internal static AccesoMotivosPermiso AccesoMotivos(ClaimsPrincipal usuario) =>
        new(int.Parse(usuario.FindFirst(CompositionRoot.RolRrhh).Value, CultureInfo.InvariantCulture));
}
