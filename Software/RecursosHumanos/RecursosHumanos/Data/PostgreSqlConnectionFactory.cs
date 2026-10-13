using System;
using System.Configuration;
using Npgsql;

namespace RecursosHumanos.Data;

/// <summary>
/// Punto único de configuración para la nueva capa PostgreSQL.
/// </summary>
internal sealed class PostgreSqlConnectionFactory
{
	private const string EnvironmentVariable = "RRHH_POSTGRES_CONNECTION";
	private const string ConfigurationName = "RrhhPostgreSql";

	public string ConnectionString { get; }

	public PostgreSqlConnectionFactory()
	{
		ConnectionString = ResolveConnectionString();
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
		if (!string.IsNullOrWhiteSpace(fromEnvironment))
		{
			return fromEnvironment;
		}

		ConnectionStringSettings configured =
			ConfigurationManager.ConnectionStrings[ConfigurationName];
		if (configured == null || string.IsNullOrWhiteSpace(configured.ConnectionString))
		{
			throw new ConfigurationErrorsException(
				$"Falta '{ConfigurationName}' en app.config. También puede definir " +
				$"la variable de entorno {EnvironmentVariable}.");
		}

		return configured.ConnectionString;
	}
}
