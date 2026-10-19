using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using ClassRRHH;
using GRLL.Common;
using RRHH.Application.Seguridad;
using RRHH.PostgreSql;

namespace RecursosHumanos;

internal static class PostgreSqlDiagnostic
{
	private const string CheckArgument = "--check-postgresql";
	private const string SetPasswordArgument = "--set-password";
	private const string CheckModulesArgument = "--check-modules";
	private const string ApplyModuleSchemaArgument = "--apply-module-schema";
	private const string ApplyOrganizationalCatalogArgument = "--apply-organizational-catalog";
	private const string FindUserArgument = "--find-user";
	private const string ResultVariable = "RRHH_POSTGRES_CHECK_RESULT";
	private const string LoginPasswordVariable = "RRHH_LOGIN_PASSWORD";
	private const string NewPasswordVariable = "RRHH_NEW_PASSWORD";

	public static bool TryRun(string[] arguments, out int exitCode)
	{
		exitCode = 0;
		bool checkRequested = arguments != null && arguments.Any(argument =>
			string.Equals(argument, CheckArgument, StringComparison.OrdinalIgnoreCase));
		bool setPasswordRequested = arguments != null && arguments.Any(argument =>
			string.Equals(argument, SetPasswordArgument, StringComparison.OrdinalIgnoreCase));
		bool checkModulesRequested = arguments != null && arguments.Any(argument =>
			string.Equals(argument, CheckModulesArgument, StringComparison.OrdinalIgnoreCase));
		bool applyModuleSchemaRequested = arguments != null && arguments.Any(argument =>
			string.Equals(argument, ApplyModuleSchemaArgument, StringComparison.OrdinalIgnoreCase));
		bool applyOrganizationalCatalogRequested = arguments != null && arguments.Any(argument =>
			string.Equals(argument, ApplyOrganizationalCatalogArgument, StringComparison.OrdinalIgnoreCase));
		bool findUserRequested = arguments != null && arguments.Any(argument =>
			string.Equals(argument, FindUserArgument, StringComparison.OrdinalIgnoreCase));
		if (!checkRequested && !setPasswordRequested && !checkModulesRequested && !applyModuleSchemaRequested &&
			!applyOrganizationalCatalogRequested && !findUserRequested)
		{
			return false;
		}

		try
		{
			CompositionRoot.VerificarBaseDeDatos();
			if (applyModuleSchemaRequested)
			{
				string migrationPath = FindRepositoryFile(
					Path.Combine("BD", "migrations", "20261015_01_complete_module_tables.sql"));
				new PostgreSqlExecutor().Execute(File.ReadAllText(migrationPath));
			}
			if (applyOrganizationalCatalogRequested)
			{
				string migrationPath = FindRepositoryFile(
					Path.Combine("BD", "migrations", "20261019_01_rebuild_organizational_catalog.sql"));
				new PostgreSqlExecutor().Execute(File.ReadAllText(migrationPath));
			}
			string login = GetOption(arguments, "--login");
			if (findUserRequested)
			{
				string search = GetOption(arguments, FindUserArgument);
				if (string.IsNullOrWhiteSpace(search))
				{
					throw new InvalidOperationException("Debe indicar el usuario o apellido que desea buscar.");
				}

				DataTable users = new PostgreSqlExecutor().Query(@"
SELECT u.""Login"", u.""Descripcion"", u.""Estado"", u.""IdEmpleado"",
       btrim(concat_ws(' ', p.""Apellido_Paterno"", p.""Apellido_Materno"", p.""Nombres"")) AS ""Empleado"",
       (u.""PasswordHash"" IS NOT NULL AND u.""PasswordSalt"" IS NOT NULL) AS ""TieneClave"",
       string_agg(DISTINCT ur.""IdRol""::text, ', ' ORDER BY ur.""IdRol""::text) AS ""Roles""
FROM public.""Usuario"" u
LEFT JOIN public.""Empleado"" e ON e.""IdEmpleado"" = u.""IdEmpleado""
LEFT JOIN public.""Persona"" p ON p.""IdPersona"" = e.""IdPersona""
LEFT JOIN public.""Usuario_Rol"" ur ON ur.""IdUsuario"" = u.""IdUsuario""
WHERE lower(coalesce(u.""Login"", '')) LIKE '%' || lower(@search) || '%'
   OR lower(coalesce(u.""Descripcion"", '')) LIKE '%' || lower(@search) || '%'
   OR lower(coalesce(p.""Apellido_Paterno"", '')) LIKE '%' || lower(@search) || '%'
   OR lower(coalesce(p.""Apellido_Materno"", '')) LIKE '%' || lower(@search) || '%'
GROUP BY u.""IdUsuario"", u.""Login"", u.""Descripcion"", u.""Estado"", u.""IdEmpleado"",
         p.""Apellido_Paterno"", p.""Apellido_Materno"", p.""Nombres"", u.""PasswordHash"", u.""PasswordSalt""
ORDER BY u.""Login"";",
					new PostgreSqlParameterValue("search", search.Trim(), DbType.String));
				if (users.Rows.Count == 0)
				{
					WriteResult("No se encontro una cuenta coincidente.");
					return true;
				}

				string[] lines = users.Rows.Cast<DataRow>().Select(row =>
					$"Login={row["Login"]}; Descripcion={row["Descripcion"]}; Activo={row["Estado"]}; " +
					$"IdEmpleado={row["IdEmpleado"]}; Empleado={row["Empleado"]}; Roles={row["Roles"]}; " +
					$"ClaveConfigurada={row["TieneClave"]}").ToArray();
				WriteResult(string.Join(Environment.NewLine, lines));
				return true;
			}
			if (setPasswordRequested)
			{
				string newPassword = Environment.GetEnvironmentVariable(NewPasswordVariable);
				if (string.IsNullOrWhiteSpace(login) || string.IsNullOrEmpty(newPassword))
				{
					throw new InvalidOperationException(
						"Para asignar una contraseña se requieren --login y RRHH_NEW_PASSWORD.");
				}

				if (!CompositionRoot.EstablecerContrasenaUsuario(login, newPassword))
				{
					throw new InvalidOperationException(
						$"No existe un único usuario con el login '{login}'.");
				}

				WriteResult($"Contraseña actualizada para el usuario '{login}'.");
				return true;
			}

			string result = "PostgreSQL: conexión y esquema RRHH verificados.";

			if (checkModulesRequested)
			{
				PostgreSqlLegacyContext context = Module1.DcGrll;
				RRHHClass rrhh = new RRHHClass();
				List<Empleado> employees = EmpleadoMapper.Instance().SelectAll();
				int employeeId = employees.Select(item => item.IdEmpleado).First();
				int activeEmployeesVisibleInSearch = rrhh.buscar_empleado(null, string.Empty, string.Empty, null, 1, 13).Rows.Count;
				int inactiveEmployeesVisibleInSearch = rrhh.buscar_empleado(null, string.Empty, string.Empty, null, 0, 13).Rows.Count;
				PostgreSqlExecutor diagnostics = new PostgreSqlExecutor();
				DataTable employeeStates = diagnostics.Query(@"
SELECT COALESCE(NULLIF(btrim(""Estado""), ''), '<vacio>') AS ""Valor"", COUNT(*) AS ""Cantidad""
FROM public.""Empleado""
GROUP BY COALESCE(NULLIF(btrim(""Estado""), ''), '<vacio>')
ORDER BY ""Valor"";");
				DataTable areaYears = diagnostics.Query(@"
SELECT ""Year"" AS ""Valor"", COUNT(*) AS ""Cantidad""
FROM public.""Empleado_Area""
GROUP BY ""Year""
ORDER BY ""Year"";");
				DataTable organizationYears = diagnostics.Query(@"
SELECT ""Year"" AS ""Valor"", COUNT(*) AS ""Cantidad""
FROM public.""EstructOrganiz""
GROUP BY ""Year""
ORDER BY ""Year"";");
				int employeesWithPerson = diagnostics.ScalarInt(@"
SELECT COUNT(*) FROM public.""Empleado"" e
INNER JOIN public.""Persona"" p ON p.""IdPersona"" = e.""IdPersona"";");
				int employeesWithArea2011 = diagnostics.ScalarInt(@"
SELECT COUNT(*) FROM public.""Empleado"" e
INNER JOIN public.""Empleado_Area"" ea ON ea.""IdEmpleado"" = e.""IdEmpleado""
WHERE ea.""Year"" = 2011;");
				int employeesWithOrganization2011 = diagnostics.ScalarInt(@"
SELECT COUNT(*) FROM public.""Empleado"" e
INNER JOIN public.""Empleado_Area"" ea ON ea.""IdEmpleado"" = e.""IdEmpleado""
INNER JOIN public.""EstructOrganiz"" eo
  ON eo.""idAreaOrganiz"" = ea.""idAreaOrganiz"" AND eo.""Year"" = ea.""Year""
WHERE ea.""Year"" = 2011;");
				string stateSummary = string.Join(",", employeeStates.Rows.Cast<DataRow>()
					.Select(row => $"{row["Valor"]}:{row["Cantidad"]}"));
				string yearSummary = string.Join(",", areaYears.Rows.Cast<DataRow>()
					.Select(row => $"{row["Valor"]}:{row["Cantidad"]}"));
				string organizationYearSummary = string.Join(",", organizationYears.Rows.Cast<DataRow>()
					.Select(row => $"{row["Valor"]}:{row["Cantidad"]}"));
				int workerTypes = TipoTrabajadorMapper.Instance().SelectAll().Count;
				int permissionTypes = TipoPermisoMapper.Instance().SelectAll().Count;
				int reasons = Motivo_PermMapper.Instance().SelectAll().Count;
				int locationsCatalog = new PostgreSqlExecutor().ScalarInt("SELECT COUNT(*) FROM public.\"Ubigeo\";");
				int schedules = context.sp_Listar_Empleado_Horario(null, null).Count();
				int locations = context.sp_Listar_Empleado_Local(null, null).Count();
				int weeklyRows = context.spRRHH_GetRecordAsistenciasSemanales("20240101", "20240107", null).Rows.Count;
				int detailRows = rrhh.spRRHH_RepAsisdiarria("20240101", "20240107", null, null, null, "2024", null).Rows.Count;
				DataSet birthday = (DataSet)rrhh.Generar_Cumples(1);
				DataSet profile = (DataSet)rrhh.Generar_Ficha_Prueba(employeeId);
				int documents = DocumentoMapper.Instance().SelectAll().Count;
				result += Environment.NewLine +
					$"Modulos PostgreSQL: empleados={employees.Count}; busquedaActivos={activeEmployeesVisibleInSearch}; " +
					$"busquedaInactivos={inactiveEmployeesVisibleInSearch}; estados=[{stateSummary}]; aniosArea=[{yearSummary}]; " +
					$"aniosOrganizacion=[{organizationYearSummary}]; joinPersona={employeesWithPerson}; " +
					$"joinArea2011={employeesWithArea2011}; joinOrganizacion2011={employeesWithOrganization2011}; " +
					$"tipos={workerTypes}/{permissionTypes}; motivos={reasons}; ubigeos={locationsCatalog}; " +
					$"horarios={schedules}; locales={locations}; semanal={weeklyRows}; detalle={detailRows}; " +
					$"cumples={birthday.Tables[0].Rows.Count}; ficha={profile.Tables.Count} tablas; documentos={documents}.";
			}

			if (!string.IsNullOrWhiteSpace(login))
			{
				string password = Environment.GetEnvironmentVariable(LoginPasswordVariable);
				if (string.IsNullOrEmpty(password))
				{
					throw new InvalidOperationException(
						$"Falta {LoginPasswordVariable} para probar el inicio de sesión.");
				}

				AccesoUsuario access = CompositionRoot.CrearObtenerAccesoUsuario().Ejecutar(
					RRHH.Codsys,
					login,
					password);
				if (access == null)
				{
					throw new InvalidOperationException(
						"Usuario o contraseña incorrectos, o sin acceso activo a RRHH.");
				}

				result += Environment.NewLine +
					$"Usuario={access.Login}; Empleado={access.IdEmpleado}; " +
					$"Rol={access.IdRol}; Nombre={access.NombreEmpleado}";
			}

			WriteResult(result);
		}
		catch (Exception exception)
		{
			exitCode = 1;
			WriteResult("ERROR: " + exception.Message);
		}

		return true;
	}

	private static string GetOption(string[] arguments, string option)
	{
		for (int index = 0; index < arguments.Length - 1; index++)
		{
			if (string.Equals(arguments[index], option, StringComparison.OrdinalIgnoreCase))
			{
				return arguments[index + 1];
			}
		}

		return null;
	}

	private static string FindRepositoryFile(string relativePath)
	{
		DirectoryInfo directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
		while (directory != null)
		{
			string candidate = Path.Combine(directory.FullName, relativePath);
			if (File.Exists(candidate))
			{
				return candidate;
			}
			directory = directory.Parent;
		}
		throw new FileNotFoundException("No se encontro la migracion PostgreSQL requerida.", relativePath);
	}

	private static void WriteResult(string result)
	{
		string resultPath = Environment.GetEnvironmentVariable(ResultVariable);
		if (!string.IsNullOrWhiteSpace(resultPath))
		{
			File.WriteAllText(resultPath, result);
		}
	}
}
