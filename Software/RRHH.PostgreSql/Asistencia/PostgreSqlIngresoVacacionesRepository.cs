using System;
using System.Data;
using System.Linq;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.PostgreSql.Asistencia;

/// <summary>Lee FechaIngreso y rechaza datos ausentes o contradictorios del empleado.</summary>
public sealed class PostgreSqlIngresoVacacionesRepository : IIngresoVacacionesRepository
{
    private readonly PostgreSqlExecutor _db;

    /// <summary>Recibe el ejecutor de la conexión del cliente.</summary>
    public PostgreSqlIngresoVacacionesRepository(PostgreSqlExecutor db) =>
        _db = db ?? throw new ArgumentNullException(nameof(db));

    /// <inheritdoc/>
    public DateTime ObtenerIngreso(int empleado)
    {
        var filas = _db.Query("""
SELECT "FechaIngreso"::date AS ingreso FROM public."Empleado" WHERE "IdEmpleado" = @empleado;
""", new PostgreSqlParameterValue("empleado", empleado, DbType.Int32)).Rows.Cast<DataRow>().ToList();
        if (filas.Count == 0 || filas.Any(fila => fila.IsNull("ingreso")))
            throw new ReglaNegocioException("El empleado no existe o no tiene fecha de ingreso.");
        var fechas = filas.Select(fila => (DateTime)fila["ingreso"]).Distinct().ToList();
        if (fechas.Count != 1)
            throw new ReglaNegocioException("El empleado tiene fechas de ingreso contradictorias. Solicite su revisión.");
        return fechas[0];
    }
}
