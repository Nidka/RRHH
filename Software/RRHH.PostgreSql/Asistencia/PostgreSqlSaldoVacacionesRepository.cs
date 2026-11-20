using System;
using System.Data;
using System.Collections.Generic;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.PostgreSql.Asistencia;

/// <summary>Consulta ingreso y permisos aprobados del piloto en una sola sentencia PostgreSQL.</summary>
public sealed class PostgreSqlSaldoVacacionesRepository : IVacacionesSaldoRepository
{
    private readonly PostgreSqlExecutor _db;
    private readonly PostgreSqlTransactionContext _transaction;
    private readonly int _excluir;
    public PostgreSqlSaldoVacacionesRepository(PostgreSqlExecutor db) => _db=db ?? throw new ArgumentNullException(nameof(db));
    internal PostgreSqlSaldoVacacionesRepository(PostgreSqlTransactionContext transaction,int excluir)
    {
        _transaction=transaction ?? throw new ArgumentNullException(nameof(transaction));
        _excluir=excluir;
    }
    private DataTable Query(string sql,params PostgreSqlParameterValue[] parameters) =>
        _transaction==null ? _db.Query(sql,parameters) : _transaction.Query(sql,parameters);

    /// <inheritdoc/>
    public FichaSaldoVacacionesDto Obtener(int empleado, DateTime corte)
    {
        var filas=Query("""
WITH ingreso AS (
 SELECT MIN("FechaIngreso"::date) AS fecha, COUNT(*) AS filas,
 COUNT(DISTINCT "FechaIngreso"::date) AS fechas,
 COUNT(*) FILTER (WHERE "FechaIngreso" IS NULL) AS nulos
 FROM public."Empleado" WHERE "IdEmpleado"=@empleado
), catalogo AS (
 SELECT COUNT(*) FILTER (WHERE COALESCE((to_jsonb(m)->>'EsVacacionesPiloto')::boolean,false)) AS configurados,
 EXISTS (SELECT 1 FROM public."Motivo_Perm" x GROUP BY x."idMotivo" HAVING COUNT(*)>1
 AND BOOL_OR(COALESCE((to_jsonb(x)->>'EsVacacionesPiloto')::boolean,false))) AS duplicados
 FROM public."Motivo_Perm" m
), consumos AS (
 SELECT true AS consumo,p."NPermiso",p."FechaInicio"::date AS desde,p."FechaFin"::date AS hasta,
 COALESCE((to_jsonb(p)->>'MediaJornadaVacaciones')::boolean,false) AS media
 FROM public."Permiso" p
 WHERE p."IdEmpleado"=@empleado AND (p."FechaInicio" IS NULL OR p."FechaInicio"::date<=@corte)
 AND (p."NPermiso" IS NULL OR p."NPermiso"<>@excluir)
 AND COALESCE(to_jsonb(p)->>'EstadoSolicitud',CASE WHEN (to_jsonb(p)->>'Autorizado')::boolean IS TRUE
 THEN 'Aprobado' ELSE 'Solicitado' END)='Aprobado'
 AND EXISTS (SELECT 1 FROM public."Motivo_Perm" m WHERE m."idMotivo"=p."idMotivo"
 AND COALESCE((to_jsonb(m)->>'EsVacacionesPiloto')::boolean,false))
)
SELECT ingreso.*,catalogo.*,c.* FROM ingreso CROSS JOIN catalogo LEFT JOIN consumos c ON true ORDER BY c.desde,c."NPermiso";
""", new PostgreSqlParameterValue("empleado",empleado,DbType.Int32),
            new PostgreSqlParameterValue("corte",corte.Date,DbType.Date),
            new PostgreSqlParameterValue("excluir",_excluir,DbType.Int32));
        var fila=filas.Rows[0];
        if (Convert.ToInt64(fila["configurados"])==0 || Convert.ToBoolean(fila["duplicados"]))
            throw new ReglaNegocioException("Configure motivos únicos de vacaciones del piloto antes de consultar el saldo.");
        if (Convert.ToInt64(fila["filas"])==0 || Convert.ToInt64(fila["nulos"])>0 || Convert.ToInt64(fila["fechas"])!=1)
            throw new ReglaNegocioException("El ingreso del empleado falta o es contradictorio. Revise sus datos.");
        var consumos=new List<ConsumoVacacionesDto>();
        var numeros=new HashSet<int>();
        foreach (DataRow registro in filas.Rows)
        {
            if (registro.IsNull("consumo")) continue;
            if (registro.IsNull("NPermiso")) throw new ReglaNegocioException("Un consumo no tiene número de permiso.");
            int numero=Convert.ToInt32(registro["NPermiso"]);
            if (!numeros.Add(numero) || registro.IsNull("desde") || registro.IsNull("hasta"))
                throw new ReglaNegocioException("Hay consumos duplicados o fechas incompletas. Revise los permisos.");
            DateTime desde=(DateTime)registro["desde"], hasta=(DateTime)registro["hasta"];
            if (hasta<desde) throw new ReglaNegocioException("Un consumo tiene fechas invertidas.");
            bool media=Convert.ToBoolean(registro["media"]);
            if (media && desde!=hasta) throw new ReglaNegocioException("Una media jornada debe ocupar una sola fecha.");
            consumos.Add(new ConsumoVacacionesDto {Numero=numero,Desde=desde,Hasta=hasta,Dias=media ? 0.5m : (hasta-desde).Days+1m});
        }
        return new FichaSaldoVacacionesDto {Ingreso=(DateTime)fila["fecha"],Consumos=consumos};
    }
}
