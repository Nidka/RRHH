using System;
using System.Collections.Generic;
using System.IO;

namespace RRHH.PostgreSql;

internal static class EnvironmentFile
{
	private const string ExplicitPathVariable = "RRHH_ENV_FILE";

	public static string LoadIfPresent()
	{
		string path = FindFile();
		if (path == null)
		{
			return null;
		}

		foreach (string sourceLine in File.ReadAllLines(path))
		{
			string line = sourceLine.Trim();
			if (line.Length == 0 || line.StartsWith("#", StringComparison.Ordinal))
			{
				continue;
			}

			if (line.StartsWith("export ", StringComparison.OrdinalIgnoreCase))
			{
				line = line.Substring(7).TrimStart();
			}

			int separator = line.IndexOf('=');
			if (separator <= 0)
			{
				continue;
			}

			string name = line.Substring(0, separator).Trim();
			string value = Unquote(line.Substring(separator + 1).Trim());
			if (name.Length > 0 && string.IsNullOrEmpty(Environment.GetEnvironmentVariable(name)))
			{
				Environment.SetEnvironmentVariable(name, value, EnvironmentVariableTarget.Process);
			}
		}

		return path;
	}

	private static string FindFile()
	{
		string explicitPath = Environment.GetEnvironmentVariable(ExplicitPathVariable);
		if (!string.IsNullOrWhiteSpace(explicitPath))
		{
			string fullPath = Path.GetFullPath(explicitPath);
			if (!File.Exists(fullPath))
			{
				throw new FileNotFoundException(
					$"No existe el archivo indicado por {ExplicitPathVariable}.", fullPath);
			}

			return fullPath;
		}

		HashSet<string> visited = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		foreach (string start in new[] { AppDomain.CurrentDomain.BaseDirectory, Environment.CurrentDirectory })
		{
			DirectoryInfo directory = new DirectoryInfo(start);
			for (int level = 0; directory != null && level < 10; level++, directory = directory.Parent)
			{
				if (!visited.Add(directory.FullName))
				{
					continue;
				}

				string candidate = Path.Combine(directory.FullName, ".env");
				if (File.Exists(candidate))
				{
					return candidate;
				}
			}
		}

		return null;
	}

	private static string Unquote(string value)
	{
		if (value.Length >= 2 &&
			((value[0] == '"' && value[value.Length - 1] == '"') ||
			 (value[0] == '\'' && value[value.Length - 1] == '\'')))
		{
			return value.Substring(1, value.Length - 2);
		}

		return value;
	}
}
