using System;
using System.Collections.Generic;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using Xunit;

namespace RRHH.Tests.Asistencia;

public class CalendarioLaboralTests
{
	// Noviembre de 2026: el 9 es lunes, el 14 sábado y el 15 domingo.
	private static readonly DateTime Lunes = new DateTime(2026, 11, 9);

	private static CalendarioLaboral SinFeriados()
	{
		return new CalendarioLaboral(new List<DateTime>());
	}

	private static RangoFechas Rango(int diaDesde, int diaHasta)
	{
		return RangoFechas.Crear(new DateTime(2026, 11, diaDesde), new DateTime(2026, 11, diaHasta));
	}

	[Theory]
	[InlineData(9)]
	[InlineData(10)]
	[InlineData(11)]
	[InlineData(12)]
	[InlineData(13)]
	public void EsLaborable_LunesAViernes_SinFeriados(int dia)
	{
		Assert.True(SinFeriados().EsLaborable(new DateTime(2026, 11, dia)));
	}

	[Theory]
	[InlineData(14)]
	[InlineData(15)]
	public void EsLaborable_FinDeSemana_NoEsLaborable(int dia)
	{
		Assert.False(SinFeriados().EsLaborable(new DateTime(2026, 11, dia)));
	}

	[Fact]
	public void EsLaborable_FeriadoEntreSemana_NoEsLaborable()
	{
		var calendario = new CalendarioLaboral(new[] { new DateTime(2026, 11, 11) });

		Assert.False(calendario.EsLaborable(new DateTime(2026, 11, 11)));
		Assert.True(calendario.EsLaborable(new DateTime(2026, 11, 12)));
	}

	[Fact]
	public void EsLaborable_IgnoraLaHoraTantoEnFeriadoComoEnConsulta()
	{
		var calendario = new CalendarioLaboral(new[] { new DateTime(2026, 11, 11, 10, 30, 0) });

		Assert.False(calendario.EsLaborable(new DateTime(2026, 11, 11, 23, 0, 0)));
	}

	[Fact]
	public void EsLaborable_FeriadoEnSabado_SigueSiendoNoLaborable()
	{
		var calendario = new CalendarioLaboral(new[] { new DateTime(2026, 11, 14) });

		Assert.False(calendario.EsLaborable(new DateTime(2026, 11, 14)));
	}

	[Fact]
	public void DiasLaborables_SemanaCompleta_SinFeriados()
	{
		Assert.Equal(5, SinFeriados().DiasLaborables(Rango(9, 13)));
	}

	[Fact]
	public void DiasLaborables_ExcluyeFinesDeSemana()
	{
		// Lunes 9 a lunes 16: ocho días calendario menos sábado y domingo.
		Assert.Equal(6, SinFeriados().DiasLaborables(Rango(9, 16)));
	}

	[Fact]
	public void DiasLaborables_ExcluyeFeriadoEntreSemana()
	{
		var calendario = new CalendarioLaboral(new[] { new DateTime(2026, 11, 11) });

		Assert.Equal(4, calendario.DiasLaborables(Rango(9, 13)));
	}

	[Fact]
	public void DiasLaborables_FeriadoEnFinDeSemana_NoDescuentaDeMas()
	{
		var calendario = new CalendarioLaboral(new[] { new DateTime(2026, 11, 14), new DateTime(2026, 11, 15) });

		Assert.Equal(6, calendario.DiasLaborables(Rango(9, 16)));
	}

	[Fact]
	public void DiasLaborables_FeriadoFueraDelRango_NoAfecta()
	{
		var calendario = new CalendarioLaboral(new[] { new DateTime(2026, 11, 20) });

		Assert.Equal(5, calendario.DiasLaborables(Rango(9, 13)));
	}

	[Fact]
	public void DiasLaborables_FeriadosRepetidos_SeCuentanUnaVez()
	{
		var calendario = new CalendarioLaboral(new[] { new DateTime(2026, 11, 11), new DateTime(2026, 11, 11, 8, 0, 0) });

		Assert.Equal(4, calendario.DiasLaborables(Rango(9, 13)));
	}

	[Fact]
	public void DiasLaborables_UnDiaLaborable_EsUno()
	{
		Assert.Equal(1, SinFeriados().DiasLaborables(RangoFechas.Crear(Lunes, Lunes)));
	}

	[Fact]
	public void DiasLaborables_UnDiaDeFinDeSemana_EsCero()
	{
		Assert.Equal(0, SinFeriados().DiasLaborables(Rango(14, 14)));
	}

	[Fact]
	public void DiasLaborables_UnDiaFeriado_EsCero()
	{
		var calendario = new CalendarioLaboral(new[] { Lunes });

		Assert.Equal(0, calendario.DiasLaborables(RangoFechas.Crear(Lunes, Lunes)));
	}

	[Fact]
	public void Constructor_FeriadosNulos_LanzaArgumentNull()
	{
		Assert.Throws<ArgumentNullException>(() => new CalendarioLaboral(null));
	}

	[Fact]
	public void DiasLaborables_RangoNulo_LanzaArgumentNull()
	{
		Assert.Throws<ArgumentNullException>(() => SinFeriados().DiasLaborables(null));
	}
}
