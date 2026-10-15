using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using RRHH.Domain.Catalogos;
using RRHH.PostgreSql.Catalogos;
using Xunit;

namespace RRHH.Tests.Catalogos;

/// <summary>
/// Comprueba cada mapeo contra BD/schema.sql, sin necesidad de una base de
/// datos: la tabla y las columnas existen, y las longitudes máximas de la
/// definición coinciden con las columnas character varying(n).
/// </summary>
public class MapeosCatalogoTests
{
	private static readonly Lazy<Dictionary<string, Dictionary<string, string>>> Esquema =
		new Lazy<Dictionary<string, Dictionary<string, string>>>(LeerEsquema);

	public static IEnumerable<object[]> Tipos =>
		Enum.GetValues(typeof(TipoCatalogo)).Cast<TipoCatalogo>().Select(t => new object[] { t });

	[Theory]
	[MemberData(nameof(Tipos))]
	public void ElMapeoCoincideConElEsquema(TipoCatalogo tipo)
	{
		MapeoCatalogo mapeo = MapeosCatalogo.Para(tipo);
		DefinicionCatalogo definicion = DefinicionesCatalogo.Definicion(tipo);

		Assert.True(Esquema.Value.ContainsKey(mapeo.Tabla), $"No existe la tabla {mapeo.Tabla} en schema.sql.");
		Dictionary<string, string> columnas = Esquema.Value[mapeo.Tabla];

		Assert.True(columnas.ContainsKey(mapeo.ColumnaId), $"{mapeo.Tabla}.{mapeo.ColumnaId} no existe.");
		Assert.StartsWith("integer", columnas[mapeo.ColumnaId]);

		Assert.Equal(definicion.LongitudMaximaDescripcion, LongitudVarchar(columnas, mapeo.Tabla, mapeo.ColumnaDescripcion));

		Assert.Equal(definicion.TieneExtra, mapeo.ColumnaExtra != null);
		if (definicion.TieneExtra)
		{
			Assert.Equal(definicion.LongitudMaximaExtra, LongitudVarchar(columnas, mapeo.Tabla, mapeo.ColumnaExtra));
		}
	}

	[Theory]
	[MemberData(nameof(Tipos))]
	public void LasReferenciasExistenEnElEsquema(TipoCatalogo tipo)
	{
		MapeoCatalogo mapeo = MapeosCatalogo.Para(tipo);

		Assert.NotEmpty(mapeo.Referencias);
		foreach (ReferenciaCatalogo referencia in mapeo.Referencias)
		{
			Assert.True(Esquema.Value.TryGetValue(referencia.Tabla, out Dictionary<string, string> columnas),
				$"No existe la tabla {referencia.Tabla} en schema.sql.");
			Assert.True(columnas.ContainsKey(referencia.Columna), $"{referencia} no existe.");
			Assert.StartsWith("integer", columnas[referencia.Columna]);
		}
	}

	/// <summary>
	/// Toda columna entera de otra tabla que se llame como la clave del
	/// catálogo debe revisarse antes de eliminar; si se agrega una al
	/// esquema y no al mapeo, esta prueba falla.
	/// </summary>
	[Theory]
	[MemberData(nameof(Tipos))]
	public void NoFaltaNingunaReferencia(TipoCatalogo tipo)
	{
		MapeoCatalogo mapeo = MapeosCatalogo.Para(tipo);

		IEnumerable<string> esperadas = Esquema.Value
			.Where(tabla => tabla.Key != mapeo.Tabla)
			.SelectMany(tabla => tabla.Value
				.Where(columna => string.Equals(columna.Key, mapeo.ColumnaId, StringComparison.OrdinalIgnoreCase)
					&& columna.Value.StartsWith("integer"))
				.Select(columna => tabla.Key + "." + columna.Key))
			.OrderBy(nombre => nombre, StringComparer.Ordinal);

		Assert.Equal(esperadas, mapeo.Referencias.Select(r => r.ToString()).OrderBy(nombre => nombre, StringComparer.Ordinal));
	}

	private static int LongitudVarchar(Dictionary<string, string> columnas, string tabla, string columna)
	{
		Assert.True(columnas.ContainsKey(columna), $"{tabla}.{columna} no existe.");
		Match match = Regex.Match(columnas[columna], @"^character varying\((\d+)\)");
		Assert.True(match.Success, $"{tabla}.{columna} no es character varying(n): {columnas[columna]}");
		return int.Parse(match.Groups[1].Value);
	}

	private static Dictionary<string, Dictionary<string, string>> LeerEsquema()
	{
		string ruta = BuscarEsquema();
		var tablas = new Dictionary<string, Dictionary<string, string>>();
		Dictionary<string, string> actual = null;

		foreach (string linea in File.ReadLines(ruta))
		{
			Match inicio = Regex.Match(linea, @"^CREATE TABLE public\.""([^""]+)"" \($");
			if (inicio.Success)
			{
				actual = new Dictionary<string, string>();
				tablas[inicio.Groups[1].Value] = actual;
				continue;
			}

			if (actual == null)
			{
				continue;
			}

			if (linea.StartsWith(");"))
			{
				actual = null;
				continue;
			}

			Match columna = Regex.Match(linea, @"^\s+""([^""]+)"" (.+?),?$");
			if (columna.Success)
			{
				actual[columna.Groups[1].Value] = columna.Groups[2].Value;
			}
		}

		return tablas;
	}

	private static string BuscarEsquema()
	{
		for (DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory); dir != null; dir = dir.Parent)
		{
			string candidato = Path.Combine(dir.FullName, "BD", "schema.sql");
			if (File.Exists(candidato))
			{
				return candidato;
			}
		}

		throw new FileNotFoundException("No se encontró BD/schema.sql subiendo desde la carpeta de las pruebas.");
	}
}
