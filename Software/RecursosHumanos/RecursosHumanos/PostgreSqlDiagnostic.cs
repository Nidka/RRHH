using System;
using System.IO;
using System.Linq;
using RRHH.Application.Seguridad;

namespace RecursosHumanos;

internal static class PostgreSqlDiagnostic
{
	private const string CheckArgument = "--check-postgresql";
	private const string ResultVariable = "RRHH_POSTGRES_CHECK_RESULT";

	public static bool TryRun(string[] arguments, out int exitCode)
	{
		exitCode = 0;
		if (arguments == null || !arguments.Any(argument =>
			string.Equals(argument, CheckArgument, StringComparison.OrdinalIgnoreCase)))
		{
			return false;
		}

		try
		{
			CompositionRoot.VerificarBaseDeDatos();
			string login = GetOption(arguments, "--login");
			string result = "PostgreSQL: conexión y esquema RRHH verificados.";

			if (!string.IsNullOrWhiteSpace(login))
			{
				AccesoUsuario access = CompositionRoot.CrearObtenerAccesoUsuario().Ejecutar(RRHH.Codsys, login);
				if (access == null)
				{
					throw new InvalidOperationException(
						$"El usuario '{login}' no tiene acceso activo al sistema {RRHH.Codsys} o no está asociado a un empleado.");
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

	private static void WriteResult(string result)
	{
		string resultPath = Environment.GetEnvironmentVariable(ResultVariable);
		if (!string.IsNullOrWhiteSpace(resultPath))
		{
			File.WriteAllText(resultPath, result);
		}
	}
}
