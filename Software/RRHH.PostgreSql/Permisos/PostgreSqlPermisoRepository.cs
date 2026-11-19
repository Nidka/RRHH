using System;
using System.Data;
using RRHH.Application.Permisos;
using RRHH.Domain.Comun;

namespace RRHH.PostgreSql.Permisos;

/// <summary>
/// Repositorio PostgreSQL de consulta de permisos sobre <c>public."Permiso"</c>.
/// </summary>
public sealed class PostgreSqlPermisoRepository : IPermisoRepository
{
	private readonly PostgreSqlExecutor _database;

	public PostgreSqlPermisoRepository(PostgreSqlExecutor database)
	{
		_database = database ?? throw new ArgumentNullException(nameof(database));
	}

	/// <summary>
	/// Reemplaza <c>RRHHClass.ExistePermiso</c>, que solo comprobaba si el inicio o el fin del rango nuevo
	/// caían dentro de un permiso existente y por eso no detectaba un rango nuevo que contiene a uno
	/// existente (existente 10–12, nuevo 9–13). Aquí se usa la condición completa de solapamiento de
	/// fechas inclusivas: <c>inicioExistente &lt;= finNuevo AND finExistente &gt;= inicioNuevo</c>.
	/// Los permisos con fecha inicial o final nula no se comparan, igual que en la consulta original.
	/// </summary>
	public bool ExisteSolapamiento(int idEmpleado, RangoFechas rango, int excluirNPermiso)
	{
		if (rango == null)
		{
			throw new ArgumentNullException(nameof(rango));
		}

		return _database.ScalarInt(
			"SELECT 1 FROM public.\"Permiso\" " +
			"WHERE \"IdEmpleado\" = @empleadoId " +
			"AND \"NPermiso\" <> @excluirNPermiso " +
			"AND \"FechaInicio\" IS NOT NULL AND \"FechaFin\" IS NOT NULL " +
			"AND \"FechaInicio\"::date <= @hasta AND \"FechaFin\"::date >= @desde " +
			"LIMIT 1;",
			new PostgreSqlParameterValue("empleadoId", idEmpleado, DbType.Int32),
			new PostgreSqlParameterValue("excluirNPermiso", excluirNPermiso, DbType.Int32),
			new PostgreSqlParameterValue("desde", rango.Desde, DbType.Date),
			new PostgreSqlParameterValue("hasta", rango.Hasta, DbType.Date)) == 1;
	}

	/// <summary>
	/// Lee la marca configurable <c>Motivo_Perm."UnaVezPorAnio"</c> (RF-06). Requiere la migración de BD que crea
	/// esa columna (<c>infra/rf-06-flag-licencia-anual</c>); si falta se devuelve un diagnóstico de negocio. Un motivo inexistente o con
	/// la marca nula devuelve <c>false</c>.
	/// </summary>
    /// <exception cref="ReglaNegocioException">Falta la columna anual o tiene un tipo incompatible con la migración.</exception>
	public bool MotivoSeOtorgaUnaVezPorAnio(int idMotivo)
	{
        if (_database.ScalarInt("""
SELECT COUNT(*) FROM information_schema.columns
WHERE table_schema = 'public' AND table_name = 'Motivo_Perm'
AND column_name = 'UnaVezPorAnio' AND data_type = 'boolean';
""") != 1)
            throw new ReglaNegocioException(
                "No se puede guardar el permiso porque falta la migración RF-06. " +
                "Solicite al responsable de BD aplicar BD/migrations/20261111_01_licencia_una_vez_anio.sql " +
                "en esta base y comprobar que UnaVezPorAnio es boolean.");

        ExigirMotivoUnico(idMotivo);
		return _database.ScalarInt(
			"SELECT 1 FROM public.\"Motivo_Perm\" " +
			"WHERE \"idMotivo\" = @motivoId AND COALESCE(\"UnaVezPorAnio\", false) = true " +
			"LIMIT 1;",
			new PostgreSqlParameterValue("motivoId", idMotivo, DbType.Int32)) == 1;
	}

	/// <summary>
	/// Busca otro permiso del empleado bajo el mismo motivo o grupo anual cuya fecha de inicio cae en el año indicado. El año se compara
	/// como rango de fechas tipadas (<c>[1 de enero, 1 de enero siguiente)</c>) y no con texto.
	/// </summary>
	public bool ExistePermisoDelMotivoEnAnio(int idEmpleado, int idMotivo, int anio, int excluirNPermiso)
	{
        ExigirMotivoUnico(idMotivo);
		return _database.ScalarInt(
			"SELECT 1 FROM public.\"Permiso\" p " +
            "JOIN public.\"Motivo_Perm\" elegido ON elegido.\"idMotivo\" = @motivoId " +
            "LEFT JOIN public.\"Motivo_Perm\" previo ON previo.\"idMotivo\" = p.\"idMotivo\" " +
			"WHERE p.\"IdEmpleado\" = @empleadoId " +
            "AND (p.\"idMotivo\" = @motivoId OR " +
            "(NULLIF(to_jsonb(elegido)->>'GrupoReglaAnual', '') IS NOT NULL " +
            "AND to_jsonb(previo)->>'GrupoReglaAnual' = to_jsonb(elegido)->>'GrupoReglaAnual')) " +
			"AND p.\"NPermiso\" <> @excluirNPermiso " +
			"AND p.\"FechaInicio\"::date >= @inicioAnio AND p.\"FechaInicio\"::date < @inicioAnioSiguiente " +
			"LIMIT 1;",
			new PostgreSqlParameterValue("empleadoId", idEmpleado, DbType.Int32),
			new PostgreSqlParameterValue("motivoId", idMotivo, DbType.Int32),
			new PostgreSqlParameterValue("excluirNPermiso", excluirNPermiso, DbType.Int32),
			new PostgreSqlParameterValue("inicioAnio", new DateTime(anio, 1, 1), DbType.Date),
			new PostgreSqlParameterValue("inicioAnioSiguiente", new DateTime(anio, 1, 1).AddYears(1), DbType.Date)) == 1;
	}

    private void ExigirMotivoUnico(int idMotivo)
    {
        if (_database.ScalarInt("SELECT COUNT(*) FROM public.\"Motivo_Perm\" WHERE \"idMotivo\" = @id;",
            new PostgreSqlParameterValue("id", idMotivo, DbType.Int32)) > 1)
            throw new ReglaNegocioException("El motivo tiene un ID duplicado. Solicite revisar la integridad de BD antes de validar la licencia.");
    }
}
