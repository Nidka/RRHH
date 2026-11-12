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
	/// esa columna (<c>infra/rf-06-flag-licencia-anual</c>); sin ella la consulta falla. Un motivo inexistente o con
	/// la marca nula devuelve <c>false</c>.
	/// </summary>
	public bool MotivoSeOtorgaUnaVezPorAnio(int idMotivo)
	{
		return _database.ScalarInt(
			"SELECT 1 FROM public.\"Motivo_Perm\" " +
			"WHERE \"idMotivo\" = @motivoId AND COALESCE(\"UnaVezPorAnio\", false) = true " +
			"LIMIT 1;",
			new PostgreSqlParameterValue("motivoId", idMotivo, DbType.Int32)) == 1;
	}

	/// <summary>
	/// Busca otro permiso del mismo empleado y motivo cuya fecha de inicio cae en el año indicado. El año se compara
	/// como rango de fechas tipadas (<c>[1 de enero, 1 de enero siguiente)</c>) y no con texto.
	/// </summary>
	public bool ExistePermisoDelMotivoEnAnio(int idEmpleado, int idMotivo, int anio, int excluirNPermiso)
	{
		return _database.ScalarInt(
			"SELECT 1 FROM public.\"Permiso\" " +
			"WHERE \"IdEmpleado\" = @empleadoId " +
			"AND \"idMotivo\" = @motivoId " +
			"AND \"NPermiso\" <> @excluirNPermiso " +
			"AND \"FechaInicio\"::date >= @inicioAnio AND \"FechaInicio\"::date < @inicioAnioSiguiente " +
			"LIMIT 1;",
			new PostgreSqlParameterValue("empleadoId", idEmpleado, DbType.Int32),
			new PostgreSqlParameterValue("motivoId", idMotivo, DbType.Int32),
			new PostgreSqlParameterValue("excluirNPermiso", excluirNPermiso, DbType.Int32),
			new PostgreSqlParameterValue("inicioAnio", new DateTime(anio, 1, 1), DbType.Date),
			new PostgreSqlParameterValue("inicioAnioSiguiente", new DateTime(anio, 1, 1).AddYears(1), DbType.Date)) == 1;
	}
}
