using System;
using RRHH.Domain.Comun;
using Xunit;

namespace RRHH.Tests.Comun;

public class RangoFechasTests
{
	private static RangoFechas Rango(int diaDesde, int diaHasta)
	{
		return RangoFechas.Crear(new DateTime(2026, 11, diaDesde), new DateTime(2026, 11, diaHasta));
	}

	[Fact]
	public void Crear_TruncaLaHoraDeAmbosExtremos()
	{
		RangoFechas rango = RangoFechas.Crear(new DateTime(2026, 11, 10, 15, 30, 0), new DateTime(2026, 11, 12, 8, 5, 0));

		Assert.Equal(new DateTime(2026, 11, 10), rango.Desde);
		Assert.Equal(new DateTime(2026, 11, 12), rango.Hasta);
	}

	[Fact]
	public void Crear_RangoInvertido_LanzaReglaNegocio()
	{
		var ex = Assert.Throws<ReglaNegocioException>(() => Rango(12, 10));

		Assert.Equal("La fecha final no puede ser anterior a la fecha inicial.", ex.Message);
	}

	[Fact]
	public void Crear_MismoDiaConHorasInvertidas_NoEsInvertido()
	{
		RangoFechas rango = RangoFechas.Crear(new DateTime(2026, 11, 10, 18, 0, 0), new DateTime(2026, 11, 10, 8, 0, 0));

		Assert.Equal(1, rango.Dias);
	}

	[Fact]
	public void Dias_RangoDeUnDia_EsUno()
	{
		Assert.Equal(1, Rango(10, 10).Dias);
	}

	[Fact]
	public void Dias_CuentaAmbosExtremos()
	{
		Assert.Equal(3, Rango(10, 12).Dias);
	}

	[Fact]
	public void Dias_CruzaFinDeMes()
	{
		RangoFechas rango = RangoFechas.Crear(new DateTime(2026, 11, 29), new DateTime(2026, 12, 2));

		Assert.Equal(4, rango.Dias);
	}

	[Theory]
	[InlineData(9, false)]
	[InlineData(10, true)]
	[InlineData(11, true)]
	[InlineData(12, true)]
	[InlineData(13, false)]
	public void Contiene_IncluyeLosExtremos(int dia, bool esperado)
	{
		Assert.Equal(esperado, Rango(10, 12).Contiene(new DateTime(2026, 11, dia)));
	}

	[Fact]
	public void Contiene_IgnoraLaHora()
	{
		Assert.True(Rango(10, 12).Contiene(new DateTime(2026, 11, 12, 23, 59, 59)));
	}

	[Fact]
	public void Solapa_RangosIguales()
	{
		Assert.True(Rango(10, 12).Solapa(Rango(10, 12)));
	}

	[Fact]
	public void Solapa_ParcialPorElInicio()
	{
		Assert.True(Rango(10, 12).Solapa(Rango(8, 10)));
	}

	[Fact]
	public void Solapa_ParcialPorElFinal()
	{
		Assert.True(Rango(10, 12).Solapa(Rango(12, 14)));
	}

	[Fact]
	public void Solapa_ElNuevoContieneAlExistente()
	{
		// Caso que RRHHClass.ExistePermiso no detectaba: existente 10-12, nuevo 9-13.
		Assert.True(Rango(10, 12).Solapa(Rango(9, 13)));
	}

	[Fact]
	public void Solapa_ElNuevoEstaContenidoEnElExistente()
	{
		Assert.True(Rango(10, 12).Solapa(Rango(11, 11)));
	}

	[Fact]
	public void Solapa_UnDiaContraUnDiaIgual()
	{
		Assert.True(Rango(10, 10).Solapa(Rango(10, 10)));
	}

	[Fact]
	public void Solapa_RangoAnteriorSinDiaEnComun_NoSolapa()
	{
		Assert.False(Rango(10, 12).Solapa(Rango(5, 9)));
	}

	[Fact]
	public void Solapa_RangoPosteriorContiguo_NoSolapa()
	{
		Assert.False(Rango(10, 12).Solapa(Rango(13, 15)));
	}

	[Fact]
	public void Solapa_EsSimetrico()
	{
		RangoFechas a = Rango(10, 12);
		RangoFechas b = Rango(9, 13);

		Assert.Equal(a.Solapa(b), b.Solapa(a));
	}

	[Fact]
	public void Solapa_Nulo_LanzaArgumentNull()
	{
		Assert.Throws<ArgumentNullException>(() => Rango(10, 12).Solapa(null));
	}
}
