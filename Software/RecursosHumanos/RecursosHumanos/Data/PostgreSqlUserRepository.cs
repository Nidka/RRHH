using System;
using Npgsql;
using NpgsqlTypes;
using RRHH.PostgreSql;

namespace RecursosHumanos.Data;

/// <summary>
/// Consultas PostgreSQL que reemplazan el procedimiento SQL Server
/// GRLL_Usuario_Acceso y la consulta inicial del empleado.
/// </summary>
internal sealed class PostgreSqlUserRepository
{
	private readonly PostgreSqlConnectionFactory _connectionFactory;

	public PostgreSqlUserRepository(PostgreSqlConnectionFactory connectionFactory)
	{
		_connectionFactory = connectionFactory ??
			throw new ArgumentNullException(nameof(connectionFactory));
	}

	public UserAccess FindAccess(string systemCode, string login)
	{
		const string sql = @"
SELECT DISTINCT
    u.""IdUsuario"",
    btrim(u.""Login"") AS ""Login"",
    u.""IdEmpleado"",
    e.""idAreaOrganiz"",
    ur.""IdRol"",
    btrim(concat_ws(' ', p.""Apellido_Paterno"", p.""Apellido_Materno"", p.""Nombres"")) AS ""EmployeeName""
FROM public.""Usuario"" AS u
INNER JOIN public.""Usuario_Rol"" AS ur ON ur.""IdUsuario"" = u.""IdUsuario""
INNER JOIN public.""Rol"" AS r ON r.""IdRol"" = ur.""IdRol""
LEFT JOIN public.""Empleado"" AS e ON e.""IdEmpleado"" = u.""IdEmpleado""
LEFT JOIN public.""Persona"" AS p ON p.""IdPersona"" = e.""IdPersona""
WHERE lower(btrim(u.""Login"")) = lower(btrim(@login))
  AND COALESCE(u.""Estado"", FALSE)
  AND r.""IdSistema"" = @systemCode
ORDER BY ur.""IdRol""
LIMIT 1;";

		using NpgsqlConnection connection = _connectionFactory.OpenConnection();
		using NpgsqlCommand command = new NpgsqlCommand(sql, connection);
		command.Parameters.Add("login", NpgsqlDbType.Varchar).Value = login.Trim();
		command.Parameters.Add("systemCode", NpgsqlDbType.Varchar).Value = systemCode;

		using NpgsqlDataReader reader = command.ExecuteReader();
		if (!reader.Read())
		{
			return null;
		}

		return new UserAccess
		{
			UserId = reader.GetInt32(0),
			Login = reader.IsDBNull(1) ? login.Trim() : reader.GetString(1),
			EmployeeId = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
			OrganizationAreaId = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3),
			RoleId = reader.GetInt32(4),
			EmployeeName = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)
		};
	}
}
