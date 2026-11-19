using System;
using System.Data;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.PostgreSql.Seguridad;

/// <summary>Lee únicamente identidad, estado y vínculo, sin exponer credenciales.</summary>
public sealed class PostgreSqlUsuarioEmpleadoRepository:IUsuarioEmpleadoRepository
{
    private readonly PostgreSqlExecutor _db;
    public PostgreSqlUsuarioEmpleadoRepository(PostgreSqlExecutor db)=>_db=db ?? throw new ArgumentNullException(nameof(db));
    /// <inheritdoc/>
    public int ObtenerEmpleado(int idUsuario)
    {
        if(idUsuario<=0) throw new ReglaNegocioException("Identidad no válida para autoconsulta.");
        var fila=_db.Query("""
SELECT COUNT(*) AS filas,COUNT(DISTINCT "IdEmpleado") AS vinculos,MIN("IdEmpleado") AS empleado,
BOOL_AND(COALESCE("Estado",false)) AS activo FROM public."Usuario" WHERE "IdUsuario"=@usuario;
""",new PostgreSqlParameterValue("usuario",idUsuario,DbType.Int32)).Rows[0];
        if(Convert.ToInt64(fila["filas"])!=1 || Convert.ToInt64(fila["vinculos"])!=1 ||
            !Convert.ToBoolean(fila["activo"]) || Convert.ToInt32(fila["empleado"])<=0)
            throw new ReglaNegocioException("La cuenta no tiene un vínculo único y activo con un empleado. Solicite revisión a RRHH.");
        return Convert.ToInt32(fila["empleado"]);
    }
}
