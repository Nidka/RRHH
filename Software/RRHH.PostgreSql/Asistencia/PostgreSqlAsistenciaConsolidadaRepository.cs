using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.PostgreSql.Asistencia;

/// <summary>Lee calendario y fuentes de cada día con EXISTS para no multiplicar marcaciones o permisos.</summary>
public sealed class PostgreSqlAsistenciaConsolidadaRepository:IAsistenciaConsolidadaRepository
{
    private readonly PostgreSqlExecutor _db;
    public PostgreSqlAsistenciaConsolidadaRepository(PostgreSqlExecutor db)=>_db=db ?? throw new ArgumentNullException(nameof(db));
    /// <inheritdoc/>
    public IReadOnlyList<FuentesAsistenciaDiaDto> Consultar(int empleado,RangoFechas periodo)=>_db.InTransaction(tx=>
    {
        tx.Execute("SET TRANSACTION ISOLATION LEVEL REPEATABLE READ READ ONLY;");
        var parametros=new[] {new PostgreSqlParameterValue("empleado",empleado,DbType.Int32),
            new PostgreSqlParameterValue("desde",periodo.Desde,DbType.Date),new PostgreSqlParameterValue("hasta",periodo.Hasta,DbType.Date)};
        if(tx.ScalarInt("SELECT COUNT(*) FROM public.\"Empleado\" WHERE \"IdEmpleado\"=@empleado;",parametros)==0)
            throw new ReglaNegocioException("El empleado no existe.");
        if(tx.ScalarInt("""
SELECT COUNT(*) FROM public."Permiso" p WHERE p."IdEmpleado"=@empleado
AND COALESCE(to_jsonb(p)->>'EstadoSolicitud',CASE WHEN (to_jsonb(p)->>'Autorizado')::boolean IS TRUE
THEN 'Aprobado' ELSE 'Solicitado' END)='Aprobado'
AND (p."FechaInicio" IS NULL OR p."FechaFin" IS NULL OR p."FechaFin"::date<p."FechaInicio"::date);
""",parametros)>0)
            throw new ReglaNegocioException("Un permiso aprobado tiene fechas incompletas o invertidas. Revise sus datos.");
        var tabla=tx.Query("""
SELECT d.fecha::date AS fecha,
(EXTRACT(ISODOW FROM d.fecha) BETWEEN 1 AND 5 AND NOT EXISTS
 (SELECT 1 FROM public."RRHH_Feriado" f WHERE f."Fecha"::date=d.fecha::date)) AS laborable,
EXISTS(SELECT 1 FROM public."Permiso" p WHERE p."IdEmpleado"=@empleado
 AND d.fecha::date BETWEEN p."FechaInicio"::date AND p."FechaFin"::date
 AND COALESCE(to_jsonb(p)->>'EstadoSolicitud',CASE WHEN (to_jsonb(p)->>'Autorizado')::boolean IS TRUE
 THEN 'Aprobado' ELSE 'Solicitado' END)='Aprobado') AS ausencia,
EXISTS(SELECT 1 FROM public."Asistencia" a WHERE a."IdEmpleado"=@empleado AND a."Fecha"::date=d.fecha::date) AS presencial,
EXISTS(SELECT 1 FROM public."Teletrabajo" t WHERE t."IdEmpleado"=@empleado AND t."Estado"
 AND d.fecha::date BETWEEN t."FechaInicio" AND t."FechaFin" AND EXTRACT(ISODOW FROM d.fecha) BETWEEN 1 AND 5
 AND (t."Modalidad"='T' OR (t."Modalidad"='P' AND (t."DiasRemotos" & (1 << (EXTRACT(ISODOW FROM d.fecha)::integer-1)))<>0))) AS remoto
FROM generate_series(@desde::timestamp,@hasta::timestamp,interval '1 day') AS d(fecha) ORDER BY d.fecha;
""",parametros);
        return (IReadOnlyList<FuentesAsistenciaDiaDto>)tabla.Rows.Cast<DataRow>().Select(f=>new FuentesAsistenciaDiaDto
            {Fecha=(DateTime)f["fecha"],Laborable=(bool)f["laborable"],Ausencia=(bool)f["ausencia"],Presencial=(bool)f["presencial"],Remoto=(bool)f["remoto"]}).ToList();
    });
}
