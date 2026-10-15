using System;
using System.Text.RegularExpressions;

namespace RRHH.PostgreSql;

/// <summary>
/// Nombres de tabla y columna que se insertan en el texto SQL. Solo se
/// aceptan constantes del código con forma de identificador simple; los
/// valores siempre van como parámetros.
/// </summary>
internal static class IdentificadorSql
{
	private static readonly Regex Valido = new Regex("^[A-Za-z_][A-Za-z0-9_]*$");

	public static string Validar(string identificador, string parametro)
	{
		if (identificador == null || !Valido.IsMatch(identificador))
		{
			throw new ArgumentException($"Identificador SQL no válido: '{identificador}'.", parametro);
		}

		return identificador;
	}

	/// <summary>Identificador entre comillas dobles, tal como está en BD/schema.sql.</summary>
	public static string Comillas(string identificador) => "\"" + identificador + "\"";

	/// <summary>Tabla del esquema public entre comillas: <c>public."Tabla"</c>.</summary>
	public static string Tabla(string tabla) => "public." + Comillas(tabla);
}
