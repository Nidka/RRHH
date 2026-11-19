using System;
using System.Data;
using RRHH.Application.Permisos;
using RRHH.Domain.Comun;

namespace RRHH.PostgreSql.Permisos;

/// <summary>Reemplaza Insert/Update de PermisoMapper y la numeración de RRHHClass para el formulario migrado.</summary>
/// <remarks>
/// Serializa los escritores de este repositorio mediante bloqueo de tabla. No garantiza
/// integridad frente a clientes externos que validen fuera de esta transacción.
/// No modifica Hora_Sal, Hora_Ret ni AutorizacionRRHH al editar.
/// </remarks>
public sealed class PostgreSqlPermisoEscrituraRepository : IPermisoEscrituraRepository, IPermisoConsultaRepository
{
    private readonly PostgreSqlExecutor _db;
    private readonly bool _permitirSalidasAutorizadas;
    /// <summary>Configura el alcance del host; web excluye salidas cuyo control de marcación sigue en escritorio.</summary>
    /// <param name="db">Ejecutor para consultas y transacciones PostgreSQL.</param>
    /// <param name="permitirSalidasAutorizadas">True solo en el host que conserva los controles de salida autorizada.</param>
    public PostgreSqlPermisoEscrituraRepository(PostgreSqlExecutor db, bool permitirSalidasAutorizadas = true)
    {
        _db = db ?? throw new ArgumentNullException(nameof(db));
        _permitirSalidasAutorizadas = permitirSalidasAutorizadas;
    }

    /// <inheritdoc/>
    public PermisoGuardarDto Obtener(int empleado, int numero)
    {
        DataTable filas = _db.Query("""
SELECT "IdEmpleado","NPermiso","idMotivo","FechaInicio","FechaFin","EstadoSolicitud",
"Lugar","Referencia","Autorizacion","Obs","Dia","Retorno" FROM public."Permiso"
WHERE "IdEmpleado"=@empleado AND "NPermiso"=@numero;
""", new PostgreSqlParameterValue("empleado", empleado, DbType.Int32),
            new PostgreSqlParameterValue("numero", numero, DbType.Int32));
        if (filas.Rows.Count == 0) return null;
        if (filas.Rows.Count != 1) throw new ReglaNegocioException("El número de permiso está duplicado. Revise la integridad de BD.");
        DataRow fila = filas.Rows[0];
        if (fila.IsNull("FechaInicio") || fila.IsNull("FechaFin") || fila.IsNull("idMotivo"))
            throw new ReglaNegocioException("El permiso histórico tiene fechas o motivo incompletos. Requiere revisión de datos.");
        return new PermisoGuardarDto
        {
            IdEmpleado=empleado, Numero=numero, IdMotivo=Convert.ToInt32(fila["idMotivo"]),
            Desde=Convert.ToDateTime(fila["FechaInicio"]), Hasta=Convert.ToDateTime(fila["FechaFin"]),
            Estado=Convert.ToString(fila["EstadoSolicitud"]), Lugar=Texto(fila,"Lugar"),
            Referencia=Texto(fila,"Referencia"), Autorizacion=Texto(fila,"Autorizacion"),
            Observacion=Texto(fila,"Obs"), Dia=Booleano(fila,"Dia"), Retorno=Booleano(fila,"Retorno")
        };
    }

    private static string Texto(DataRow fila, string campo) => fila.IsNull(campo) ? null : (string)fila[campo];
    private static bool? Booleano(DataRow fila, string campo) => fila.IsNull(campo) ? (bool?)null : Convert.ToBoolean(fila[campo]);

    /// <inheritdoc/>
    public int Guardar(PermisoGuardarDto dto)
    {
        if (dto == null) throw new ArgumentNullException(nameof(dto));
        return _db.InTransaction(tx =>
        {
            tx.Execute("LOCK TABLE public.\"Permiso\", public.\"Motivo_Perm\" IN SHARE ROW EXCLUSIVE MODE;");
            if (tx.ScalarInt("""
SELECT COUNT(*) FROM information_schema.columns WHERE table_schema='public'
AND table_name='Permiso' AND column_name='EstadoSolicitud';
""") != 1)
                throw new ReglaNegocioException("Falta aplicar 20261119_02_estados_permiso.sql antes de guardar permisos.");
            var empleado = new PostgreSqlParameterValue("empleado", dto.IdEmpleado, DbType.Int32);
            var numeroAnterior = new PostgreSqlParameterValue("numeroAnterior", dto.Numero, DbType.Int32);
            if (tx.ScalarInt("SELECT COUNT(*) FROM public.\"Empleado\" WHERE \"IdEmpleado\"=@empleado;", empleado) == 0)
                throw new ReglaNegocioException("El empleado no existe.");
            if (tx.ScalarInt("SELECT COUNT(*) FROM public.\"Motivo_Perm\" WHERE \"idMotivo\"=@motivo AND \"Activo\" IS TRUE;",
                new PostgreSqlParameterValue("motivo", dto.IdMotivo, DbType.Int32)) != 1)
                throw new ReglaNegocioException("El motivo no existe, está inactivo o tiene un ID duplicado.");
            if (!_permitirSalidasAutorizadas && tx.ScalarInt(
                "SELECT \"idTipoPermiso\" FROM public.\"Motivo_Perm\" WHERE \"idMotivo\"=@motivo;",
                new PostgreSqlParameterValue("motivo", dto.IdMotivo, DbType.Int32)) == 2)
                throw new ReglaNegocioException("Las salidas autorizadas por horas todavía se gestionan desde la aplicación de escritorio.");
            string estado = dto.Estado ?? "Solicitado";
            if (dto.Numero > 0)
            {
                if (tx.ScalarInt("SELECT COUNT(*) FROM public.\"Permiso\" WHERE \"IdEmpleado\"=@empleado AND \"NPermiso\"=@numeroAnterior;",
                    empleado, numeroAnterior) != 1)
                    throw new ReglaNegocioException("El permiso no existe o su número está duplicado. Actualice el listado.");
                if (!_permitirSalidasAutorizadas && tx.ScalarInt("""
SELECT COUNT(*) FROM public."Permiso" p JOIN public."Motivo_Perm" m ON m."idMotivo"=p."idMotivo"
WHERE p."IdEmpleado"=@empleado AND p."NPermiso"=@numeroAnterior AND m."idTipoPermiso"=2;
""", empleado, numeroAnterior) > 0)
                    throw new ReglaNegocioException("Esta salida autorizada debe editarse desde la aplicación de escritorio.");
                if (dto.Estado == null)
                    estado = (string)tx.Scalar("SELECT \"EstadoSolicitud\" FROM public.\"Permiso\" WHERE \"IdEmpleado\"=@empleado AND \"NPermiso\"=@numeroAnterior;",
                        empleado, numeroAnterior);
            }
            var consultas = new PostgreSqlPermisoRepository(tx);
            // También comprueba el contrato RF-06 cuando el estado no ocupa cupo.
            bool anual = consultas.MotivoSeOtorgaUnaVezPorAnio(dto.IdMotivo);
            if (estado != "Rechazado" && estado != "Anulado")
            {
                if (consultas.ExisteSolapamiento(dto.IdEmpleado, RangoFechas.Crear(dto.Desde, dto.Hasta), dto.Numero))
                    throw new ReglaNegocioException(ValidarPermisoSinSolapamiento.MensajeSolapamiento);
                if (anual && consultas.ExistePermisoDelMotivoEnAnio(dto.IdEmpleado, dto.IdMotivo, dto.Desde.Year, dto.Numero))
                    throw new ReglaNegocioException("El empleado ya tiene una licencia de este motivo o grupo en el año " + dto.Desde.Year + ".");
            }
            int numero = dto.Numero;
            if (numero == 0)
                numero = checked(tx.ScalarInt("SELECT COALESCE(MAX(\"NPermiso\"),0) FROM public.\"Permiso\" WHERE \"IdEmpleado\"=@empleado;", empleado) + 1);
            var valores = new[]
            {
                empleado, new PostgreSqlParameterValue("numero", numero, DbType.Int32),
                new PostgreSqlParameterValue("motivo", dto.IdMotivo, DbType.Int32),
                new PostgreSqlParameterValue("desde", dto.Desde.Date, DbType.Date),
                new PostgreSqlParameterValue("hasta", dto.Hasta.Date, DbType.Date),
                new PostgreSqlParameterValue("estado", estado, DbType.String),
                new PostgreSqlParameterValue("lugar", dto.Lugar, DbType.String),
                new PostgreSqlParameterValue("referencia", dto.Referencia, DbType.String),
                new PostgreSqlParameterValue("autorizacion", dto.Autorizacion, DbType.String),
                new PostgreSqlParameterValue("obs", dto.Observacion, DbType.String),
                new PostgreSqlParameterValue("dia", dto.Dia, DbType.Boolean),
                new PostgreSqlParameterValue("retorno", dto.Retorno, DbType.Boolean)
            };
            string sql = dto.Numero == 0 ? """
INSERT INTO public."Permiso" ("IdEmpleado","NPermiso","idMotivo","FechaInicio","FechaFin",
"EstadoSolicitud","Lugar","Referencia","Autorizacion","Obs","Dia","Retorno")
VALUES (@empleado,@numero,@motivo,@desde,@hasta,@estado,@lugar,@referencia,@autorizacion,@obs,@dia,@retorno);
""" : """
UPDATE public."Permiso" SET "idMotivo"=@motivo,"FechaInicio"=@desde,"FechaFin"=@hasta,
"EstadoSolicitud"=@estado,"Lugar"=@lugar,"Referencia"=@referencia,"Autorizacion"=@autorizacion,
"Obs"=@obs,"Dia"=@dia,"Retorno"=@retorno WHERE "IdEmpleado"=@empleado AND "NPermiso"=@numero;
""";
            if (tx.Execute(sql, valores) != 1)
                throw new ReglaNegocioException("No se pudo guardar exactamente un permiso.");
            return numero;
        });
    }
}
