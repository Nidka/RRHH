using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using RRHH.Application.Personal;

namespace RRHH.PostgreSql.Personal;

/// <summary>
/// Búsqueda de empleados por texto sobre <c>Empleado</c> y <c>Persona</c> (CR-019).
/// </summary>
/// <remarks>
/// Toma de <c>RRHHClass.buscar_empleado</c> la regla de estado: activo solo si <c>Empleado."Estado"</c>
/// es <c>'1'</c>; vacío o nulo cuenta como inactivo. A diferencia de esa consulta heredada, no filtra
/// por estado, área ni tipo de trabajador: devuelve activos y cesados para que el operador elija.
/// </remarks>
public sealed class PostgreSqlEmpleadoBusquedaRepository : IEmpleadoBusquedaRepository
{
    private const string Sql = """
SELECT "IdEmpleado", "NombreCompleto", "Documento", "Activo"
FROM (
    SELECT DISTINCT ON (e."IdEmpleado")
        e."IdEmpleado",
        concat_ws(', ',
            NULLIF(btrim(concat_ws(' ', btrim(p."Apellido_Paterno"), btrim(p."Apellido_Materno"))), ''),
            NULLIF(btrim(p."Nombres"), '')) AS "NombreCompleto",
        NULLIF(btrim(p."NumDocID"), '') AS "Documento",
        COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1' AS "Activo"
    FROM public."Empleado" AS e
    INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
    WHERE concat_ws(' ', p."Apellido_Paterno", p."Apellido_Materno", p."Nombres") ILIKE '%' || @texto || '%'
       OR concat_ws(' ', p."Nombres", p."Apellido_Paterno", p."Apellido_Materno") ILIKE '%' || @texto || '%'
       OR btrim(p."NumDocID") LIKE @texto || '%'
    ORDER BY e."IdEmpleado", e."Year" DESC
) AS encontrados
ORDER BY "Activo" DESC, "NombreCompleto", "IdEmpleado"
LIMIT @limite;
""";

    private readonly PostgreSqlExecutor _db;

    public PostgreSqlEmpleadoBusquedaRepository(PostgreSqlExecutor db) =>
        _db = db ?? throw new ArgumentNullException(nameof(db));

    /// <summary>Misma proyección que la búsqueda, filtrada por una lista de códigos (un solo parámetro integer[]).</summary>
    private const string SqlPorCodigos = """
SELECT DISTINCT ON (e."IdEmpleado")
    e."IdEmpleado",
    concat_ws(', ',
        NULLIF(btrim(concat_ws(' ', btrim(p."Apellido_Paterno"), btrim(p."Apellido_Materno"))), ''),
        NULLIF(btrim(p."Nombres"), '')) AS "NombreCompleto",
    NULLIF(btrim(p."NumDocID"), '') AS "Documento",
    COALESCE(NULLIF(btrim(e."Estado"), ''), '0') = '1' AS "Activo"
FROM public."Empleado" AS e
INNER JOIN public."Persona" AS p ON p."IdPersona" = e."IdPersona"
WHERE e."IdEmpleado" = ANY(@codigos)
ORDER BY e."IdEmpleado", e."Year" DESC;
""";

    /// <inheritdoc/>
    public IReadOnlyList<EmpleadoResumenDto> Buscar(string texto, int limite) =>
        Mapear(_db.Query(Sql,
            new PostgreSqlParameterValue("texto", EscaparComodines(texto ?? string.Empty), DbType.String),
            new PostgreSqlParameterValue("limite", limite, DbType.Int32)));

    /// <inheritdoc/>
    public IReadOnlyList<EmpleadoResumenDto> ObtenerPorCodigos(IReadOnlyCollection<int> codigos) =>
        Mapear(_db.Query(SqlPorCodigos, new PostgreSqlParameterValue("codigos", (codigos ?? Array.Empty<int>()).ToArray())));

    private static IReadOnlyList<EmpleadoResumenDto> Mapear(DataTable tabla) =>
        tabla.Rows.Cast<DataRow>()
            .Select(fila => new EmpleadoResumenDto(
                Convert.ToInt32(fila["IdEmpleado"]),
                fila.IsNull("NombreCompleto") ? string.Empty : (string)fila["NombreCompleto"],
                fila.IsNull("Documento") ? null : (string)fila["Documento"],
                (bool)fila["Activo"]))
            .ToList();

    /// <summary>Hace que <c>%</c>, <c>_</c> y <c>\</c> se busquen como caracteres y no como comodines.</summary>
    private static string EscaparComodines(string texto) =>
        texto.Replace(@"\", @"\\").Replace("%", @"\%").Replace("_", @"\_");
}
