using System;
using System.Data;
using RRHH.Application.Seguridad;

namespace RRHH.PostgreSql.Seguridad;

/// <summary>
/// Reemplaza el procedimiento GRLL_Usuario_Acceso (SQL Server) y la consulta
/// inicial del empleado que hacía el login.
/// </summary>
public sealed class PostgreSqlAccesoUsuarioRepository : IAccesoUsuarioRepository
{
	private const string Sql = @"
SELECT DISTINCT
    u.""IdUsuario"" AS id_usuario,
    btrim(u.""Login"") AS login,
    u.""IdEmpleado"" AS id_empleado,
    e.""idAreaOrganiz"" AS id_area,
    ur.""IdRol"" AS id_rol,
    btrim(concat_ws(' ', p.""Apellido_Paterno"", p.""Apellido_Materno"", p.""Nombres"")) AS nombre_empleado,
    u.""PasswordHash"" AS password_hash,
    u.""PasswordSalt"" AS password_salt,
    u.""PasswordIterations"" AS password_iterations
FROM public.""Usuario"" AS u
INNER JOIN public.""Usuario_Rol"" AS ur ON ur.""IdUsuario"" = u.""IdUsuario""
INNER JOIN public.""Rol"" AS r ON r.""IdRol"" = ur.""IdRol""
LEFT JOIN public.""Empleado"" AS e ON e.""IdEmpleado"" = u.""IdEmpleado""
LEFT JOIN public.""Persona"" AS p ON p.""IdPersona"" = e.""IdPersona""
WHERE lower(btrim(u.""Login"")) = lower(btrim(@login))
  AND COALESCE(u.""Estado"", FALSE)
  AND r.""IdSistema"" = @codigoSistema
ORDER BY ur.""IdRol""
LIMIT 1;";

	private const string UpdatePasswordSql = @"
WITH matching_users AS (
    SELECT ""IdUsuario""
    FROM public.""Usuario""
    WHERE lower(btrim(""Login"")) = lower(btrim(@login))
), unique_user AS (
    SELECT min(""IdUsuario"") AS id_usuario
    FROM matching_users
    HAVING count(DISTINCT ""IdUsuario"") = 1
)
UPDATE public.""Usuario"" AS u
SET ""PasswordHash"" = @passwordHash,
    ""PasswordSalt"" = @passwordSalt,
    ""PasswordIterations"" = @passwordIterations,
    ""PasswordChangedAt"" = CURRENT_TIMESTAMP
FROM unique_user
WHERE u.""IdUsuario"" = unique_user.id_usuario;";

	private readonly PostgreSqlExecutor _database;

	public PostgreSqlAccesoUsuarioRepository(PostgreSqlExecutor database)
	{
		_database = database ?? throw new ArgumentNullException(nameof(database));
	}

	public AccesoUsuario Autenticar(string codigoSistema, string login, string password)
	{
		if (login == null)
		{
			throw new ArgumentNullException(nameof(login));
		}
		if (password == null)
		{
			throw new ArgumentNullException(nameof(password));
		}

		DataTable table = _database.Query(
			Sql,
			new PostgreSqlParameterValue("login", login.Trim(), DbType.String),
			new PostgreSqlParameterValue("codigoSistema", codigoSistema, DbType.String));
		if (table.Rows.Count == 0)
		{
			return null;
		}

		DataRow row = table.Rows[0];
		string passwordHash = row["password_hash"] as string;
		string passwordSalt = row["password_salt"] as string;
		int passwordIterations = row["password_iterations"] == DBNull.Value
			? 0
			: Convert.ToInt32(row["password_iterations"]);
		if (!Pbkdf2PasswordHasher.Verificar(password, passwordHash, passwordSalt, passwordIterations))
		{
			return null;
		}

		return new AccesoUsuario(
			Convert.ToInt32(row["id_usuario"]),
			row["login"] as string ?? login.Trim(),
			row["id_empleado"] as int?,
			row["id_area"] as int?,
			Convert.ToInt32(row["id_rol"]),
			row["nombre_empleado"] as string);
	}

	public bool EstablecerContrasena(string login, string password)
	{
		if (string.IsNullOrWhiteSpace(login))
		{
			throw new ArgumentException("El usuario es obligatorio.", nameof(login));
		}

		PasswordHash hash = Pbkdf2PasswordHasher.Crear(password);
		int affected = _database.Execute(
			UpdatePasswordSql,
			new PostgreSqlParameterValue("login", login.Trim(), DbType.String),
			new PostgreSqlParameterValue("passwordHash", hash.Hash, DbType.String),
			new PostgreSqlParameterValue("passwordSalt", hash.Salt, DbType.String),
			new PostgreSqlParameterValue("passwordIterations", hash.Iterations, DbType.Int32));
		return affected >= 1;
	}
}
