using System;
using Npgsql;

namespace RRHH.PostgreSql;

/// <summary>
/// Centraliza la configuración de PostgreSQL para todos los proyectos de RRHH.
/// La cadena de conexión solo viene de RRHH_POSTGRES_CONNECTION; nunca de
/// app.config ni del código.
/// </summary>
public sealed class PostgreSqlConnectionFactory
{
	public const string EnvironmentVariable = "RRHH_POSTGRES_CONNECTION";

	public string ConnectionString { get; }

	public PostgreSqlConnectionFactory()
		: this(ResolveConnectionString())
	{
	}

	public PostgreSqlConnectionFactory(string connectionString)
	{
		if (string.IsNullOrWhiteSpace(connectionString))
		{
			throw new ArgumentException("La cadena de PostgreSQL no puede estar vacía.", nameof(connectionString));
		}

		ConnectionString = connectionString;
	}

	public NpgsqlConnection OpenConnection()
	{
		NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
		connection.Open();
		return connection;
	}

	public void VerifySchema()
	{
		using NpgsqlConnection connection = OpenConnection();
		using NpgsqlCommand command = new NpgsqlCommand(
			"SELECT to_regclass('public.\"Usuario\"') IS NOT NULL " +
			"AND to_regclass('public.\"Empleado\"') IS NOT NULL " +
			"AND to_regclass('public.\"Persona\"') IS NOT NULL;",
			connection);

		if (!(command.ExecuteScalar() is bool isValid) || !isValid)
		{
			throw new InvalidOperationException(
				"La base PostgreSQL no contiene el esquema RRHH esperado. " +
				"Restaure BD/schema.sql o el dump privado de CMI.");
		}
	}

	private static string ResolveConnectionString()
	{
		string fromEnvironment = Environment.GetEnvironmentVariable(EnvironmentVariable);
		if (string.IsNullOrWhiteSpace(fromEnvironment))
		{
			throw new InvalidOperationException(
				$"Defina la variable de entorno {EnvironmentVariable} con la cadena de conexión " +
				"de PostgreSQL, por ejemplo: Host=localhost;Port=5432;Database=CMI;Username=rrhh_app;Password=...");
		}

		return fromEnvironment;
	}
}
