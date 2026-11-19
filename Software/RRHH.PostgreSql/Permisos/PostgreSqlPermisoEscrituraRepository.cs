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
public sealed class PostgreSqlPermisoEscrituraRepository : IPermisoEscrituraRepository
{
    private readonly PostgreSqlExecutor _db;
    public PostgreSqlPermisoEscrituraRepository(PostgreSqlExecutor db)
    {
        _db = db ?? throw new ArgumentNullException(nameof(db));
    }

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
            string estado = dto.Estado ?? "Solicitado";
            if (dto.Numero > 0)
            {
                if (tx.ScalarInt("SELECT COUNT(*) FROM public.\"Permiso\" WHERE \"IdEmpleado\"=@empleado AND \"NPermiso\"=@numeroAnterior;",
                    empleado, numeroAnterior) != 1)
                    throw new ReglaNegocioException("El permiso no existe o su número está duplicado. Actualice el listado.");
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
