using System;
using System.Linq;
using RRHH.Domain.Catalogos;
using RRHH.Domain.Comun;
using Xunit;

namespace RRHH.Tests.Catalogos;

public class DefinicionCatalogoTests
{
	private static readonly DefinicionCatalogo EstadoCivil = DefinicionesCatalogo.Definicion(TipoCatalogo.EstadoCivil);
	private static readonly DefinicionCatalogo GrupoSanguineo = DefinicionesCatalogo.Definicion(TipoCatalogo.GrupoSanguineo);

	[Fact]
	public void TodosLosTiposTienenDefinicion()
	{
		foreach (TipoCatalogo tipo in Enum.GetValues(typeof(TipoCatalogo)))
		{
			Assert.Equal(tipo, DefinicionesCatalogo.Definicion(tipo).Tipo);
		}

		Assert.Equal(Enum.GetValues(typeof(TipoCatalogo)).Length, DefinicionesCatalogo.Todos.Count());
	}

	[Theory]
	[InlineData(null)]
	[InlineData("")]
	[InlineData("   ")]
	public void Validar_SinDescripcion_Falla(string descripcion)
	{
		Assert.Equal("Debe ingresar descripción.", EstadoCivil.Validar(descripcion, null));
	}

	[Fact]
	public void Validar_RespetaLongitudDeDescripcion()
	{
		Assert.Null(EstadoCivil.Validar(new string('a', 11), null));
		Assert.Equal("Descripción: no puede superar 11 caracteres.", EstadoCivil.Validar(new string('a', 12), null));
	}

	[Fact]
	public void Validar_RespetaLongitudDelExtra()
	{
		Assert.Null(EstadoCivil.Validar("Casado", "CAS"));
		Assert.Equal("Abreviatura: no puede superar 3 caracteres.", EstadoCivil.Validar("Casado", "CASA"));
	}

	[Fact]
	public void Validar_RegimenUsaSuEtiqueta()
	{
		DefinicionCatalogo regimen = DefinicionesCatalogo.Definicion(TipoCatalogo.RegimenPension);

		Assert.Equal("N° Ley: no puede superar 5 caracteres.", regimen.Validar("123456", null));
	}

	[Fact]
	public void Crear_NormalizaEspaciosYExtraVacio()
	{
		ItemCatalogo item = ItemCatalogo.Crear(EstadoCivil, 0, "  Soltero ", "   ");

		Assert.Equal("Soltero", item.Descripcion);
		Assert.Null(item.Extra);
		Assert.True(item.EsNuevo);
	}

	[Fact]
	public void Crear_CatalogoSinExtra_DescartaElExtra()
	{
		ItemCatalogo item = ItemCatalogo.Crear(GrupoSanguineo, 4, "O+", "ignorado");

		Assert.Null(item.Extra);
		Assert.False(GrupoSanguineo.TieneExtra);
	}

	[Fact]
	public void Crear_DatosInvalidos_Lanza()
	{
		var ex = Assert.Throws<ReglaNegocioException>(() => ItemCatalogo.Crear(GrupoSanguineo, 0, "AB+ rh", null));
		Assert.Equal("Descripción: no puede superar 5 caracteres.", ex.Message);
	}
}
