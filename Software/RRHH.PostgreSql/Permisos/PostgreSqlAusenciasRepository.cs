using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using RRHH.Application.Permisos;
using RRHH.Domain.Comun;

namespace RRHH.PostgreSql.Permisos;

/// <summary>
/// Repositorio PostgreSQL del reporte de ausencias por periodo (RF-18) sobre <c>public."Permiso"</c>,
/// <c>public."Empleado"</c>, <c>public."Persona"</c> y <c>public."Motivo_Perm"</c>.
/// </summary>
public sealed class PostgreSqlAusenciasRepository : IAusenciasRepository
{
	private readonly PostgreSqlExecutor _database;

	public PostgreSqlAusenciasRepository(PostgreSqlExecutor database)
	{
		_database = database ?? throw new ArgumentNullException(nameof(database));
	}

	/// <summary>
	/// Reemplaza a <c>RRHHClass.spRRHH_RepPermisos</c> (consulta del reporte de permisos), que seleccionaba los permisos
	/// con <c>"FechaInicio"::date BETWEEN @fechaInicio AND @fechaFin</c> y por eso omitía los que empiezan antes del
	/// periodo o lo contienen. Aquí se usa la condición completa de solapamiento de fechas inclusivas:
	/// <c>inicioPermiso &lt;= finPeriodo AND finPermiso &gt;= inicioPeriodo</c>. Los permisos con fecha inicial o final nula
	/// no se informan (igual que en <c>PostgreSqlPermisoRepository.ExisteSolapamiento</c>). El motivo es opcional y los
	/// permisos sin motivo en el catálogo se informan con motivo vacío.
	/// </summary>
	public IReadOnlyList<AusenciaRegistrada> ListarSolapadas(RangoFechas rango, int? idMotivo)
	{
		if (rango == null)
		{
			throw new ArgumentNullException(nameof(rango));
		}

		DataTable tabla = _database.Query(
			"SELECT p.\"IdEmpleado\" AS idempleado, " +
			"btrim(concat_ws(' ', pe.\"Apellido_Paterno\", pe.\"Apellido_Materno\", pe.\"Nombres\")) AS empleado, " +
			"COALESCE(p.\"idMotivo\", 0) AS idmotivo, " +
			"COALESCE(m.\"Descrip_Motivo\", '') AS motivo, " +
			"p.\"FechaInicio\"::date AS inicio, p.\"FechaFin\"::date AS fin " +
			"FROM public.\"Permiso\" AS p " +
			"INNER JOIN public.\"Empleado\" AS e ON e.\"IdEmpleado\" = p.\"IdEmpleado\" " +
			"INNER JOIN public.\"Persona\" AS pe ON pe.\"IdPersona\" = e.\"IdPersona\" " +
			"LEFT JOIN public.\"Motivo_Perm\" AS m ON m.\"idMotivo\" = p.\"idMotivo\" " +
			"WHERE p.\"FechaInicio\" IS NOT NULL AND p.\"FechaFin\" IS NOT NULL " +
			"AND p.\"FechaInicio\"::date <= @hasta AND p.\"FechaFin\"::date >= @desde " +
			"AND (@motivoId::integer IS NULL OR p.\"idMotivo\" = @motivoId::integer) " +
			"ORDER BY empleado, inicio;",
			new PostgreSqlParameterValue("desde", rango.Desde, DbType.Date),
			new PostgreSqlParameterValue("hasta", rango.Hasta, DbType.Date),
			new PostgreSqlParameterValue("motivoId", idMotivo, DbType.Int32));

		return tabla.Rows.Cast<DataRow>()
			.Select(fila => new AusenciaRegistrada
			{
				IdEmpleado = Convert.ToInt32(fila["idempleado"]),
				Empleado = Convert.ToString(fila["empleado"]),
				IdMotivo = Convert.ToInt32(fila["idmotivo"]),
				Motivo = Convert.ToString(fila["motivo"]),
				Inicio = Convert.ToDateTime(fila["inicio"]),
				Fin = Convert.ToDateTime(fila["fin"])
			})
			.ToList();
	}

	/// <summary>Motivos del catálogo <c>public."Motivo_Perm"</c> con descripción, ordenados alfabéticamente.</summary>
	public IReadOnlyList<MotivoAusenciaDto> ListarMotivos()
	{
		DataTable tabla = _database.Query(
			"SELECT \"idMotivo\" AS id, btrim(\"Descrip_Motivo\") AS descripcion " +
			"FROM public.\"Motivo_Perm\" " +
			"WHERE NULLIF(btrim(\"Descrip_Motivo\"), '') IS NOT NULL " +
			"ORDER BY descripcion, id;");

		return tabla.Rows.Cast<DataRow>()
			.Select(fila => new MotivoAusenciaDto
			{
				Id = Convert.ToInt32(fila["id"]),
				Descripcion = Convert.ToString(fila["descripcion"])
			})
			.ToList();
	}
}
