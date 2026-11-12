using System;
using RRHH.Application.Asistencia;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Asistencia;

public class CalcularDiasNoLaborablesTests
{
	// Noviembre de 2026 (fechas ficticias): lunes 9 a domingo 15; el 14 es sábado y el 15 domingo.
	private static readonly DateTime Lunes9 = new DateTime(2026, 11, 9);
	private static readonly DateTime Viernes13 = new DateTime(2026, 11, 13);
	private static readonly DateTime Domingo15 = new DateTime(2026, 11, 15);

	private static FakeFeriadoRepository ConFeriados(params DateTime[] fechas)
	{
		var repo = new FakeFeriadoRepository();
		int id = 1;
		foreach (DateTime fecha in fechas)
		{
			repo.Registros.Add(Feriado.Reconstituir(id++, fecha, "FERIADO DE PRUEBA"));
		}

		return repo;
	}

	/// <summary>Conteo anterior de FrmConsultaAsistencias: solo sábados y domingos del rango.</summary>
	private static int ConteoAnteriorSoloFinesDeSemana(DateTime desde, DateTime hasta)
	{
		int cuenta = 0;
		for (DateTime dia = desde; dia <= hasta; dia = dia.AddDays(1))
		{
			if (dia.DayOfWeek == DayOfWeek.Saturday || dia.DayOfWeek == DayOfWeek.Sunday)
			{
				cuenta++;
			}
		}

		return cuenta;
	}

	[Fact]
	public void SemanaSinFeriados_CuentaSoloElFinDeSemana()
	{
		int dias = new CalcularDiasNoLaborables(ConFeriados()).Ejecutar(Lunes9, Domingo15);

		Assert.Equal(2, dias);
	}

	[Fact]
	public void FeriadoEntreSemana_SeSumaAlFinDeSemana()
	{
		var repo = ConFeriados(new DateTime(2026, 11, 11));

		int dias = new CalcularDiasNoLaborables(repo).Ejecutar(Lunes9, Domingo15);

		Assert.Equal(3, dias);
		// Antes del cambio el mismo caso daba 2: el feriado quedaba fuera de la suma.
		Assert.Equal(2, ConteoAnteriorSoloFinesDeSemana(Lunes9, Domingo15));
	}

	[Fact]
	public void FeriadoEnFinDeSemana_NoSeCuentaDosVeces()
	{
		var repo = ConFeriados(new DateTime(2026, 11, 14));

		int dias = new CalcularDiasNoLaborables(repo).Ejecutar(Lunes9, Domingo15);

		Assert.Equal(2, dias);
	}

	[Fact]
	public void FeriadoRepetidoEnLaTabla_SeCuentaUnaVez()
	{
		// La tabla real tiene filas históricas duplicadas (TEC-003): 442 filas para 221 fechas.
		var repo = ConFeriados(new DateTime(2026, 11, 11), new DateTime(2026, 11, 11, 11, 39, 43));

		int dias = new CalcularDiasNoLaborables(repo).Ejecutar(Lunes9, Domingo15);

		Assert.Equal(3, dias);
	}

	[Fact]
	public void FeriadoFueraDelPeriodo_NoAfecta()
	{
		var repo = ConFeriados(new DateTime(2026, 12, 8));

		int dias = new CalcularDiasNoLaborables(repo).Ejecutar(Lunes9, Domingo15);

		Assert.Equal(2, dias);
	}

	[Fact]
	public void PeriodoDeUnDiaLaborableFeriado_CuentaUno()
	{
		var repo = ConFeriados(Viernes13);

		Assert.Equal(1, new CalcularDiasNoLaborables(repo).Ejecutar(Viernes13, Viernes13));
	}

	[Fact]
	public void PeriodoDeUnDiaLaborableNormal_CuentaCero()
	{
		Assert.Equal(0, new CalcularDiasNoLaborables(ConFeriados()).Ejecutar(Viernes13, Viernes13));
	}

	[Fact]
	public void PeriodoInvertido_LanzaReglaNegocio()
	{
		Assert.Throws<ReglaNegocioException>(
			() => new CalcularDiasNoLaborables(ConFeriados()).Ejecutar(Domingo15, Lunes9));
	}

	[Fact]
	public void RepositorioNulo_LanzaArgumentNull()
	{
		Assert.Throws<ArgumentNullException>(() => new CalcularDiasNoLaborables(null));
	}
}
