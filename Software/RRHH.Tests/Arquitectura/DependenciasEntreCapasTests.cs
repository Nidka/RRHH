using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RRHH.Application.Comun;
using RRHH.Domain.Comun;
using RRHH.PostgreSql;
using RRHH.Presentation.Catalogos;
using Xunit;

namespace RRHH.Tests.Arquitectura;

/// <summary>
/// Comprueba las reglas de dependencias de docs/ARQUITECTURA.md sobre los
/// ensamblados compilados. Los proyectos SDK para net48 referencian por
/// defecto System.Data y System.Drawing, así que el compilador no basta:
/// un <c>using System.Data</c> en el dominio compilaría sin error.
/// </summary>
public class DependenciasEntreCapasTests
{
	private static readonly string[] Heredados = { "GRLL", "ClassRRHH", "ClsCtrls", "Seguridad" };

	private static readonly string[] Interfaz = { "System.Windows.Forms", "System.Drawing", "DevExpress" };

	private static readonly string[] AccesoADatos = { "System.Data", "Npgsql" };

	private static readonly Assembly Dominio = typeof(ReglaNegocioException).Assembly;
	private static readonly Assembly Aplicacion = typeof(ResultadoOperacion).Assembly;
	private static readonly Assembly Presentacion = typeof(CatalogoPresenter).Assembly;
	private static readonly Assembly Infraestructura = typeof(PostgreSqlExecutor).Assembly;

	[Fact]
	public void ElDominioNoDependeDeNingunaOtraCapaNiDeInfraestructura()
	{
		AssertNoReferencia(Dominio,
			new[] { "RRHH." }.Concat(Heredados).Concat(Interfaz).Concat(AccesoADatos));
	}

	[Fact]
	public void LaAplicacionSoloDependeDelDominio()
	{
		AssertNoReferencia(Aplicacion,
			new[] { "RRHH.Presentation", "RRHH.PostgreSql" }.Concat(Heredados).Concat(Interfaz).Concat(AccesoADatos));
	}

	[Fact]
	public void LaPresentacionNoConoceWinFormsDevExpressNiLaBase()
	{
		AssertNoReferencia(Presentacion,
			new[] { "RRHH.PostgreSql" }.Concat(Heredados).Concat(Interfaz).Concat(AccesoADatos));
	}

	[Fact]
	public void LaInfraestructuraNoConoceLaPresentacionNiLaInterfaz()
	{
		AssertNoReferencia(Infraestructura,
			new[] { "RRHH.Presentation" }.Concat(Heredados).Concat(Interfaz));
	}

	private static void AssertNoReferencia(Assembly ensamblado, IEnumerable<string> prefijosProhibidos)
	{
		string[] prefijos = prefijosProhibidos.ToArray();
		string[] violaciones = ensamblado.GetReferencedAssemblies()
			.Select(referencia => referencia.Name)
			.Where(nombre => prefijos.Any(prefijo => EmpiezaCon(nombre, prefijo)))
			.OrderBy(nombre => nombre, StringComparer.Ordinal)
			.ToArray();

		Assert.True(violaciones.Length == 0,
			$"{ensamblado.GetName().Name} no debe referenciar: {string.Join(", ", violaciones)}.");
	}

	/// <summary>"System.Data" coincide con System.Data y System.Data.Linq, pero no con System.DataX.</summary>
	private static bool EmpiezaCon(string nombre, string prefijo)
	{
		if (prefijo.EndsWith("."))
		{
			return nombre.StartsWith(prefijo, StringComparison.OrdinalIgnoreCase);
		}

		return string.Equals(nombre, prefijo, StringComparison.OrdinalIgnoreCase)
			|| nombre.StartsWith(prefijo + ".", StringComparison.OrdinalIgnoreCase);
	}
}
