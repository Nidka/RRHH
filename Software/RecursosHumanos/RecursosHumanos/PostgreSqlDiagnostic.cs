using System;
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
		if (!checkRequested && !setPasswordRequested && !checkModulesRequested && !applyModuleSchemaRequested)
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
			string login = GetOption(arguments, "--login");
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
				int employeeId = EmpleadoMapper.Instance().SelectAll().Select(item => item.IdEmpleado).First();
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
					$"Modulos PostgreSQL: tipos={workerTypes}/{permissionTypes}; motivos={reasons}; ubigeos={locationsCatalog}; " +
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
