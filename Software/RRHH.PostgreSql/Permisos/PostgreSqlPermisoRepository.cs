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
}
