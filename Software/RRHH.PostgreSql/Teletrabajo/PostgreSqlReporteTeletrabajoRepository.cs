using System.Collections.Generic;
using System.Data;
using System.Linq;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Comun;

namespace RRHH.PostgreSql.Teletrabajo;

/// <summary>Consulta parametrizada de periodos activos que intersectan la ventana del reporte.</summary>
public sealed class PostgreSqlReporteTeletrabajoRepository : IConsultaTeletrabajo
{
    private readonly PostgreSqlExecutor _database;

    public PostgreSqlReporteTeletrabajoRepository(PostgreSqlExecutor database) => _database = database;

    /// <inheritdoc/>
    public IReadOnlyList<PeriodoTeletrabajoDto> Consultar(int? empleado, RangoFechas rango) =>
        _database.Query("""
SELECT "Id", "IdEmpleado", "FechaInicio", "FechaFin", "Modalidad", "DiasRemotos", "Autorizacion"
FROM public."Teletrabajo"
WHERE "Estado" AND (@empleado IS NULL OR "IdEmpleado" = @empleado)
  AND "FechaInicio" <= @hasta AND "FechaFin" >= @desde;
""", new PostgreSqlParameterValue("empleado", empleado, DbType.Int32),
        new PostgreSqlParameterValue("desde", rango.Desde, DbType.Date),
        new PostgreSqlParameterValue("hasta", rango.Hasta, DbType.Date))
        .Rows.Cast<DataRow>().Select(PostgreSqlTeletrabajoRepository.Mapear).ToList();
}
