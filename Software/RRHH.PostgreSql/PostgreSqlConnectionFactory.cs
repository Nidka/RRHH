using System;
using System.Configuration;
using Npgsql;

namespace RRHH.PostgreSql;

/// <summary>
/// Centraliza la configuración de PostgreSQL para todos los proyectos de RRHH.
/// En producción se recomienda usar RRHH_POSTGRES_CONNECTION.
/// </summary>
public sealed class PostgreSqlConnectionFactory
{
	public const string EnvironmentVariable = "RRHH_POSTGRES_CONNECTION";
	public const string ConfigurationName = "RrhhPostgreSql";

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
