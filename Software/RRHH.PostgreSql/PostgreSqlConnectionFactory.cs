using System;
using Npgsql;

namespace RRHH.PostgreSql;

/// <summary>
/// Centraliza la configuración de PostgreSQL para todos los proyectos de RRHH.
/// Acepta RRHH_POSTGRES_CONNECTION o las variables DB_* de un .env local.
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
			"AND to_regclass('public.\"Persona\"') IS NOT NULL " +
			"AND EXISTS (SELECT 1 FROM information_schema.columns " +
			"WHERE table_schema = 'public' AND table_name = 'Usuario' " +
			"AND column_name = 'PasswordHash');",
			connection);

		if (!(command.ExecuteScalar() is bool isValid) || !isValid)
		{
			throw new InvalidOperationException(
				"La base PostgreSQL no contiene el esquema RRHH esperado. " +
				"Restaure BD/schema.sql y ejecute BD/password-auth.sql.");
		}
	}

	private static string ResolveConnectionString()
	{
		EnvironmentFile.LoadIfPresent();

		string fromEnvironment = Environment.GetEnvironmentVariable(EnvironmentVariable);
		if (!string.IsNullOrWhiteSpace(fromEnvironment))
		{
			return fromEnvironment;
		}

		SslMode sslMode = ReadSslMode();
		NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder
		{
			Host = Required("DB_HOST"),
			Port = ReadPort(),
			Database = Required("DB_NAME"),
			Username = Required("DB_USER"),
			Password = Required("DB_PASSWORD"),
			SslMode = sslMode,
			TrustServerCertificate = sslMode != SslMode.Disable,
			Pooling = true,
			KeepAlive = 30,
			Timeout = 15,
			CommandTimeout = 60
		};

		// DB_CHANNEL_BINDING pertenece al formato libpq. Npgsql 4.1 no expone
		// esa opción; la conexión a Neon sigue cifrada con SSL Mode=Require.
		return builder.ConnectionString;
	}

	private static string Required(string name)
	{
		string value = Environment.GetEnvironmentVariable(name);
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new InvalidOperationException(
				$"Falta {name}. Defina {EnvironmentVariable} o complete el archivo .env local.");
		}

		return value.Trim();
	}

	private static int ReadPort()
	{
		string value = Environment.GetEnvironmentVariable("DB_PORT");
		if (string.IsNullOrWhiteSpace(value))
		{
			return 5432;
		}

		if (!int.TryParse(value, out int port) || port < 1 || port > 65535)
		{
			throw new InvalidOperationException("DB_PORT no contiene un puerto válido.");
		}

		return port;
	}

	private static SslMode ReadSslMode()
	{
		string value = Environment.GetEnvironmentVariable("DB_SSLMODE");
		if (string.IsNullOrWhiteSpace(value))
		{
			return SslMode.Require;
		}

		if (!Enum.TryParse(value, true, out SslMode sslMode))
		{
			throw new InvalidOperationException(
				"DB_SSLMODE no es válido. Use Disable, Prefer o Require.");
		}

		return sslMode;
	}
}
