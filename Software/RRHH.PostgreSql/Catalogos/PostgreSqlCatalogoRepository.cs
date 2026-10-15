using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Npgsql;
using RRHH.Application.Catalogos;
using RRHH.Application.Comun;
using RRHH.Domain.Catalogos;

namespace RRHH.PostgreSql.Catalogos;

/// <summary>
/// Repositorio común de catálogos simples. Reemplaza los XxxMapper de GRLL
/// (LINQ-to-SQL, SQL Server) y las consultas de los formularios FrmMant*.
/// Los nombres de tabla y columna salen de <see cref="MapeoCatalogo"/>; los
/// valores siempre van como parámetros.
/// </summary>
public sealed class PostgreSqlCatalogoRepository : ICatalogoRepository
{
	private readonly PostgreSqlExecutor _database;
	private readonly MapeoCatalogo _mapeo;
	private readonly string _tabla;
	private readonly string _id;
	private readonly string _descripcion;
	private readonly string _extra;

	public PostgreSqlCatalogoRepository(PostgreSqlExecutor database, MapeoCatalogo mapeo)
	{
		_database = database ?? throw new ArgumentNullException(nameof(database));
		_mapeo = mapeo ?? throw new ArgumentNullException(nameof(mapeo));
		_tabla = IdentificadorSql.Tabla(mapeo.Tabla);
		_id = IdentificadorSql.Comillas(mapeo.ColumnaId);
		_descripcion = IdentificadorSql.Comillas(mapeo.ColumnaDescripcion);
		_extra = mapeo.ColumnaExtra == null ? null : IdentificadorSql.Comillas(mapeo.ColumnaExtra);
	}

	/// <summary>
	/// Las filas heredadas sin descripción se devuelven con texto vacío para
	/// que el usuario pueda verlas y corregirlas.
	/// </summary>
	public IReadOnlyList<ItemCatalogo> Listar(string filtro)
	{
		string columnaExtra = _extra ?? "NULL::text";
		DataTable table = _database.Query(
			$"SELECT {_id} AS id, COALESCE({_descripcion}, '') AS descripcion, {columnaExtra} AS extra " +
			$"FROM {_tabla} " +
			$"WHERE COALESCE({_descripcion}, '') ILIKE @patron ESCAPE '\\' " +
			$"ORDER BY {_id};",
			new PostgreSqlParameterValue("patron", "%" + EscaparLike(filtro) + "%"));

		return table.Rows.Cast<DataRow>()
			.Select(row => ItemCatalogo.Reconstituir(
				Convert.ToInt32(row["id"]),
				(string)row["descripcion"],
				row["extra"] as string))
			.ToList();
	}

	/// <summary>
	/// Las tablas migradas no tienen secuencia; se conserva la regla original
	/// (máximo + 1) bloqueando la tabla para evitar códigos repetidos.
	/// </summary>
	public int Insertar(ItemCatalogo item)
	{
		if (item == null)
		{
			throw new ArgumentNullException(nameof(item));
		}

		string columnas = _extra == null ? $"{_id}, {_descripcion}" : $"{_id}, {_descripcion}, {_extra}";
		string valores = _extra == null ? "@descripcion" : "@descripcion, @extra";

		return _database.InTransaction(tx =>
		{
			tx.Execute($"LOCK TABLE {_tabla} IN SHARE ROW EXCLUSIVE MODE;");
			return tx.ScalarInt(
				$"INSERT INTO {_tabla} ({columnas}) " +
				$"SELECT COALESCE(MAX({_id}), 0) + 1, {valores} FROM {_tabla} " +
				$"RETURNING {_id};",
				Parametros(item));
		});
	}

	public bool Actualizar(ItemCatalogo item)
	{
		if (item == null)
		{
			throw new ArgumentNullException(nameof(item));
		}

		string asignaciones = _extra == null
			? $"{_descripcion} = @descripcion"
			: $"{_descripcion} = @descripcion, {_extra} = @extra";

		var parametros = Parametros(item).ToList();
		parametros.Add(new PostgreSqlParameterValue("id", item.Id));
		return _database.Execute($"UPDATE {_tabla} SET {asignaciones} WHERE {_id} = @id;", parametros.ToArray()) > 0;
	}

	/// <summary>
	/// Revisa las columnas de <see cref="MapeoCatalogo.Referencias"/> antes de
	/// borrar, porque el esquema no tiene claves foráneas. Si llegan a
	/// existir, su error también se traduce a <see cref="RegistroEnUsoException"/>.
	/// </summary>
	public void Eliminar(int id)
	{
		var parametroId = new PostgreSqlParameterValue("id", id);
		try
		{
			_database.InTransaction(tx =>
			{
				ReferenciaCatalogo enUso = _mapeo.Referencias.FirstOrDefault(r => tx.ScalarInt(
					$"SELECT 1 FROM {IdentificadorSql.Tabla(r.Tabla)} " +
					$"WHERE {IdentificadorSql.Comillas(r.Columna)} = @id LIMIT 1;",
					parametroId) == 1);
				if (enUso != null)
				{
					throw new RegistroEnUsoException(
						$"El registro {id} de {_mapeo.Tabla} está referenciado en {enUso}.", null);
				}

				return tx.Execute($"DELETE FROM {_tabla} WHERE {_id} = @id;", parametroId);
			});
		}
		catch (PostgresException ex) when (ex.SqlState == PostgresErrorCodes.ForeignKeyViolation)
		{
			throw new RegistroEnUsoException($"El registro {id} de {_mapeo.Tabla} está referenciado en otra tabla.", ex);
		}
	}

	private PostgreSqlParameterValue[] Parametros(ItemCatalogo item)
	{
		var descripcion = new PostgreSqlParameterValue("descripcion", item.Descripcion, DbType.String);
		return _extra == null
			? new[] { descripcion }
			: new[] { descripcion, new PostgreSqlParameterValue("extra", item.Extra, DbType.String) };
	}

	private static string EscaparLike(string texto)
	{
		return (texto ?? string.Empty)
			.Replace("\\", "\\\\")
			.Replace("%", "\\%")
			.Replace("_", "\\_");
	}
}
