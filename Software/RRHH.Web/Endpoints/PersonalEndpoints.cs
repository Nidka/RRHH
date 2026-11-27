using System.Globalization;
using Microsoft.AspNetCore.Antiforgery;
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

        // CR-020: alta y edición de empleados, con su propia política (RRHH_WEB_ROLES_PERSONAL).
        var personal = operador.MapGroup("/personal").RequireAuthorization(CompositionRoot.PoliticaPersonal);

        personal.MapGet("/catalogos", (ObtenerDatosRegistroEmpleado datos) => Results.Ok(datos.Ejecutar()));

        personal.MapGet("/empleados/{id:int}", (int id, ObtenerEmpleado obtener) =>
            Ejecutar(() => Results.Ok(obtener.Ejecutar(id))));

        personal.MapPost("/empleados", async (HttpContext context, EmpleadoEntrada entrada, IAntiforgery tokens,
            RegistrarEmpleado registrar) =>
        {
            if (!await tokens.IsRequestValidAsync(context)) return Results.BadRequest();
            return Ejecutar(() =>
            {
                var dto = entrada.ADto();
                var resultado = registrar.Ejecutar(dto);
                return resultado.Exitoso ? Results.Json(dto, statusCode: 201) : Results.BadRequest(new { error = resultado.Mensaje });
            });
        });

        personal.MapPost("/empleados/{id:int}", async (int id, HttpContext context, EmpleadoEntrada entrada,
            IAntiforgery tokens, ActualizarEmpleado actualizar) =>
        {
            if (!await tokens.IsRequestValidAsync(context)) return Results.BadRequest();
            return Ejecutar(() =>
            {
                var dto = entrada.ADto();
                var resultado = actualizar.Ejecutar(id, dto);
                return resultado.Exitoso ? Results.Ok(dto) : Results.BadRequest(new { error = resultado.Mensaje });
            });
        });
    }

    private static IEnumerable<int> Codigos(string texto) =>
        (texto ?? string.Empty).Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(parte => int.TryParse(parte, NumberStyles.None, CultureInfo.InvariantCulture, out var codigo)
                ? codigo
                : throw new ReglaNegocioException("Los códigos de empleado deben ser números separados por coma."));
}

/// <summary>Cuerpo JSON del formulario de registro de empleados (CR-020). La fecha llega como aaaa-mm-dd.</summary>
internal sealed record EmpleadoEntrada(int TipoDocumento, string NumeroDocumento, string ApellidoPaterno,
    string ApellidoMaterno, string Nombres, int Area, string FechaIngreso, bool? Activo)
{
    internal EmpleadoEdicionDto ADto() => new()
    {
        TipoDocumento = TipoDocumento,
        NumeroDocumento = NumeroDocumento,
        ApellidoPaterno = ApellidoPaterno,
        ApellidoMaterno = ApellidoMaterno,
        Nombres = Nombres,
        Area = Area,
        FechaIngreso = string.IsNullOrEmpty(FechaIngreso)
            ? throw new ReglaNegocioException("Ingrese la fecha de ingreso.")
            : ApiComun.Fecha(FechaIngreso),
        Activo = Activo ?? true
    };
}
