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
    btrim(concat_ws(' ', p.""Apellido_Paterno"", p.""Apellido_Materno"", p.""Nombres"")) AS nombre_empleado
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

	private readonly PostgreSqlExecutor _database;

	public PostgreSqlAccesoUsuarioRepository(PostgreSqlExecutor database)
	{
		_database = database ?? throw new ArgumentNullException(nameof(database));
	}

	public AccesoUsuario Buscar(string codigoSistema, string login)
	{
		if (login == null)
		{
			throw new ArgumentNullException(nameof(login));
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
		return new AccesoUsuario(
			Convert.ToInt32(row["id_usuario"]),
			row["login"] as string ?? login.Trim(),
			row["id_empleado"] as int?,
			row["id_area"] as int?,
			Convert.ToInt32(row["id_rol"]),
			row["nombre_empleado"] as string);
	}
}
