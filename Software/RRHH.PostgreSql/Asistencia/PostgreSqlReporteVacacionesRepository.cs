using System;
using System.Data;
using System.Collections.Generic;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.PostgreSql.Asistencia;

/// <summary>Lee padrón anual y consumos de todos los empleados dentro de una instantánea de solo lectura.</summary>
public sealed class PostgreSqlReporteVacacionesRepository : IVacacionesReporteRepository
{
    private readonly PostgreSqlExecutor _db;
    public PostgreSqlReporteVacacionesRepository(PostgreSqlExecutor db) => _db=db ?? throw new ArgumentNullException(nameof(db));
    /// <inheritdoc/>
    public IReadOnlyList<FichaReporteVacacionesDto> Obtener(int anio,DateTime corte,int? area,int? empleado) => _db.InTransaction(tx=>
    {
        tx.Execute("SET TRANSACTION ISOLATION LEVEL REPEATABLE READ READ ONLY;");
        var padron=tx.Query("""
SELECT "IdEmpleado",MIN("idAreaOrganiz") AS area,COUNT(*) AS filas,COUNT(DISTINCT "idAreaOrganiz") AS areas
FROM public."Empleado" WHERE "Year"=@anio AND (@empleado IS NULL OR "IdEmpleado"=@empleado)
GROUP BY "IdEmpleado" HAVING (@area IS NULL OR BOOL_OR("idAreaOrganiz"=@area))
ORDER BY "IdEmpleado" LIMIT 1001;
""",new PostgreSqlParameterValue("anio",anio,DbType.Int32),new PostgreSqlParameterValue("area",area,DbType.Int32),
            new PostgreSqlParameterValue("empleado",empleado,DbType.Int32));
        if (padron.Rows.Count>1000) throw new ReglaNegocioException("Refine los filtros: máximo 1000 empleados por consulta.");
        var resultado=new List<FichaReporteVacacionesDto>();
        foreach (DataRow row in padron.Rows)
        {
            var ficha=new FichaReporteVacacionesDto {Empleado=Convert.ToInt32(row["IdEmpleado"]),Area=row.IsNull("area") ? (int?)null : Convert.ToInt32(row["area"])};
            if (Convert.ToInt64(row["filas"])!=1 || Convert.ToInt64(row["areas"])!=1)
                ficha.Error="Padrón anual duplicado o área incompleta. Revisar empleado/año.";
            else
            {
                try {ficha.Ficha=new PostgreSqlSaldoVacacionesRepository(tx,0).Obtener(ficha.Empleado,corte);}
                catch (ReglaNegocioException ex) {ficha.Error=ex.Message;}
            }
            resultado.Add(ficha);
        }
        return (IReadOnlyList<FichaReporteVacacionesDto>)resultado;
    });
}
