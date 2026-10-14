using System;
using System.Data;
using Npgsql;

namespace RRHH.PostgreSql;

/// <summary>
/// API pequeña y reutilizable para ejecutar SQL PostgreSQL parametrizado.
/// Oculta Npgsql a las capas heredadas y facilita migrarlas por módulos.
/// </summary>
public sealed class PostgreSqlExecutor
{
	private readonly PostgreSqlConnectionFactory _factory;

	public PostgreSqlExecutor()
		: this(new PostgreSqlConnectionFactory())
	{
	}

	public PostgreSqlExecutor(PostgreSqlConnectionFactory factory)
	{
		_factory = factory ?? throw new ArgumentNullException(nameof(factory));
	}

	public DataTable Query(string sql, params PostgreSqlParameterValue[] parameters)
	{
		using NpgsqlConnection connection = _factory.OpenConnection();
		using NpgsqlCommand command = CreateCommand(connection, null, sql, parameters);
		using NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
		DataTable table = new DataTable();
		adapter.Fill(table);
		return table;
	}

	public int Execute(string sql, params PostgreSqlParameterValue[] parameters)
	{
		using NpgsqlConnection connection = _factory.OpenConnection();
		using NpgsqlCommand command = CreateCommand(connection, null, sql, parameters);
		return command.ExecuteNonQuery();
	}

	public object Scalar(string sql, params PostgreSqlParameterValue[] parameters)
	{
		using NpgsqlConnection connection = _factory.OpenConnection();
		using NpgsqlCommand command = CreateCommand(connection, null, sql, parameters);
		object value = command.ExecuteScalar();
		return value == DBNull.Value ? null : value;
	}

	public int ScalarInt(string sql, params PostgreSqlParameterValue[] parameters)
	{
		object value = Scalar(sql, parameters);
		return value == null ? 0 : Convert.ToInt32(value);
	}

	public T InTransaction<T>(Func<PostgreSqlTransactionContext, T> action)
	{
		if (action == null)
		{
			throw new ArgumentNullException(nameof(action));
		}

		using NpgsqlConnection connection = _factory.OpenConnection();
		using NpgsqlTransaction transaction = connection.BeginTransaction();
		try
		{
			T result = action(new PostgreSqlTransactionContext(connection, transaction));
			transaction.Commit();
			return result;
		}
		catch
		{
			transaction.Rollback();
			throw;
		}
	}

	internal static NpgsqlCommand CreateCommand(
		NpgsqlConnection connection,
		NpgsqlTransaction transaction,
		string sql,
		PostgreSqlParameterValue[] parameters)
	{
		NpgsqlCommand command = new NpgsqlCommand(sql, connection, transaction);
		foreach (PostgreSqlParameterValue parameter in parameters ?? Array.Empty<PostgreSqlParameterValue>())
		{
			NpgsqlParameter npgsqlParameter = command.Parameters.AddWithValue(
				parameter.Name,
				parameter.Value ?? DBNull.Value);
			if (parameter.Type.HasValue)
			{
				npgsqlParameter.DbType = parameter.Type.Value;
			}
		}

		return command;
	}
}

public sealed class PostgreSqlTransactionContext
{
	private readonly NpgsqlConnection _connection;
	private readonly NpgsqlTransaction _transaction;

	internal PostgreSqlTransactionContext(NpgsqlConnection connection, NpgsqlTransaction transaction)
	{
		_connection = connection;
		_transaction = transaction;
	}

	public int Execute(string sql, params PostgreSqlParameterValue[] parameters)
	{
		using NpgsqlCommand command = PostgreSqlExecutor.CreateCommand(
			_connection, _transaction, sql, parameters);
		return command.ExecuteNonQuery();
	}

	public object Scalar(string sql, params PostgreSqlParameterValue[] parameters)
	{
		using NpgsqlCommand command = PostgreSqlExecutor.CreateCommand(
			_connection, _transaction, sql, parameters);
		object value = command.ExecuteScalar();
		return value == DBNull.Value ? null : value;
	}

	public int ScalarInt(string sql, params PostgreSqlParameterValue[] parameters)
	{
		object value = Scalar(sql, parameters);
		return value == null ? 0 : Convert.ToInt32(value);
	}
}
