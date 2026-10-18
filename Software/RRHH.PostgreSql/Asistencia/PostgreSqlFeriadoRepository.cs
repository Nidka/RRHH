using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Npgsql;
using RRHH.Application.Asistencia;
using RRHH.Domain.Asistencia;

namespace RRHH.PostgreSql.Asistencia;

/// <summary>
/// Repositorio PostgreSQL de días feriados no laborables sobre <c>public."RRHH_Feriado"</c>.
/// Sustituye las llamadas combinadas a <c>RRHHClass.GetFeriado</c> y <c>RRHH_FeriadoMapper</c>.
/// </summary>
public sealed class PostgreSqlFeriadoRepository : IFeriadoRepository
{
	public const string Tabla = "RRHH_Feriado";
	public const string ColumnaId = "idFeriado";
	public const string ColumnaFecha = "Fecha";
	public const string ColumnaMotivo = "Motivo";

	private static readonly string TablaCalificada = IdentificadorSql.Tabla(Tabla);
	private static readonly string IdSql = IdentificadorSql.Comillas(ColumnaId);
	private static readonly string FechaSql = IdentificadorSql.Comillas(ColumnaFecha);
	private static readonly string MotivoSql = IdentificadorSql.Comillas(ColumnaMotivo);

	private readonly PostgreSqlExecutor _database;

	public PostgreSqlFeriadoRepository(PostgreSqlExecutor database)
	{
		_database = database ?? throw new ArgumentNullException(nameof(database));
	}

	public IReadOnlyList<Feriado> Listar()
	{
		DataTable table = _database.Query(
			$"SELECT {IdSql} AS id, {FechaSql} AS fecha, COALESCE({MotivoSql}, '') AS motivo " +
			$"FROM {TablaCalificada} " +
			$"ORDER BY {IdSql};");

		return table.Rows.Cast<DataRow>()
			.Select(row => Feriado.Reconstituir(
				Convert.ToInt32(row["id"]),
				Convert.ToDateTime(row["fecha"]),
				Convert.ToString(row["motivo"])))
			.ToList();
	}

	public bool ExisteFecha(DateTime fecha)
	{
		return _database.ScalarInt(
			$"SELECT 1 FROM {TablaCalificada} WHERE {FechaSql}::date = @fecha LIMIT 1;",
			new PostgreSqlParameterValue("fecha", fecha.Date, DbType.Date)) == 1;
	}

	/// <summary>
	/// Comprueba unicidad por día calendario e inserta en una misma transacción
	/// bloqueando la tabla para evitar duplicados de fecha o colisiones de ID
	/// en sesiones concurrentes.
	/// </summary>
	public bool InsertarSiNoExisteFecha(Feriado feriado, out int idAsignado)
	{
		if (feriado == null)
		{
			throw new ArgumentNullException(nameof(feriado));
		}

		var parametroFecha = new PostgreSqlParameterValue("fecha", feriado.Fecha.Date, DbType.Date);
		var parametroMotivo = new PostgreSqlParameterValue("motivo", feriado.Motivo, DbType.String);

		try
		{
			int resultado = _database.InTransaction(tx =>
			{
				tx.Execute($"LOCK TABLE {TablaCalificada} IN SHARE ROW EXCLUSIVE MODE;");

				int existe = tx.ScalarInt(
					$"SELECT 1 FROM {TablaCalificada} WHERE {FechaSql}::date = @fecha LIMIT 1;",
					parametroFecha);
				if (existe == 1)
				{
					return 0;
				}

				return tx.ScalarInt(
					$"INSERT INTO {TablaCalificada} ({IdSql}, {FechaSql}, {MotivoSql}) " +
					$"SELECT COALESCE(MAX({IdSql}), 0) + 1, @fecha, @motivo FROM {TablaCalificada} " +
					$"RETURNING {IdSql};",
					parametroFecha,
					parametroMotivo);
			});

			idAsignado = resultado;
			return resultado > 0;
		}
		catch (PostgresException ex) when (ex.SqlState == PostgresErrorCodes.UniqueViolation)
		{
			idAsignado = 0;
			return false;
		}
	}

	public bool Eliminar(int id)
	{
		return _database.Execute(
			$"DELETE FROM {TablaCalificada} WHERE {IdSql} = @id;",
			new PostgreSqlParameterValue("id", id, DbType.Int32)) > 0;
	}
}
