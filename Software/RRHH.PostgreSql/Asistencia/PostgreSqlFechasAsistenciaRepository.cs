using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.PostgreSql.Asistencia;

/// <summary>Fuente tipada que reemplaza el agregado de spRRHH_GetDiasAsistidos para el total de Asistencias.</summary>
public sealed class PostgreSqlFechasAsistenciaRepository : IFechasAsistenciaRepository
{
    private readonly PostgreSqlExecutor _db;

    /// <summary>Usa la conexión PostgreSQL del cliente que solicita el reporte.</summary>
    public PostgreSqlFechasAsistenciaRepository(PostgreSqlExecutor db) =>
        _db = db ?? throw new ArgumentNullException(nameof(db));

    /// <inheritdoc/>
    public IReadOnlyList<DateTime> Listar(int empleado, RangoFechas periodo) =>
        _db.Query("""
SELECT DISTINCT "Fecha"::date AS fecha FROM public."Asistencia"
WHERE "IdEmpleado" = @empleado AND "Fecha"::date BETWEEN @desde AND @hasta
ORDER BY fecha;
""", new PostgreSqlParameterValue("empleado", empleado, DbType.Int32),
            new PostgreSqlParameterValue("desde", periodo.Desde, DbType.Date),
            new PostgreSqlParameterValue("hasta", periodo.Hasta, DbType.Date))
            .Rows.Cast<DataRow>().Select(fila => (DateTime)fila["fecha"]).ToList();
}
