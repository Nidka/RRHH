using System;
using RRHH.Application.Asistencia;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using Xunit;

namespace RRHH.Tests.Asistencia;

/// <summary>Ejemplos del grupo y regresiones de los límites de aniversario del piloto.</summary>
public sealed class VacacionesGeneradasTests
{
    private sealed class Ingreso : IIngresoVacacionesRepository
    {
        public DateTime ObtenerIngreso(int empleado) => new DateTime(2024, 3, 1);
    }

    [Theory]
    [InlineData(2024, 3, 1, 0)]
    [InlineData(2025, 2, 28, 0)]
    [InlineData(2025, 3, 1, 30)]
    [InlineData(2026, 11, 12, 60)]
    public void CuentaSoloAniversariosCompletos(int anio, int mes, int dia, int esperadas)
    {
        var resultado = new ReportarVacacionesGeneradas(new Ingreso(), new RegimenVacacionesPiloto())
            .Ejecutar(101, new DateTime(anio, mes, dia));
        Assert.Equal((decimal)esperadas, resultado.Generadas);
    }

    [Fact]
    public void RegimenParametrizadoNoUsaTreintaFijo()
    {
        var resultado = new ReportarVacacionesGeneradas(new Ingreso(), new RegimenVacacionesPiloto(15m))
            .Ejecutar(101, new DateTime(2026, 11, 12));
        Assert.Equal(30m, resultado.Generadas);
    }

    [Fact]
    public void IngresoBisiestoUsaFebrero28EnAnioNoBisiesto()
    {
        Assert.Equal(1, new RegimenVacacionesPiloto().AniosCumplidos(
            new DateTime(2024, 2, 29), new DateTime(2025, 2, 28)));
    }

    [Fact]
    public void CorteAnteriorAlIngresoSeRechaza()
    {
        Assert.Throws<ReglaNegocioException>(() => new ReportarVacacionesGeneradas(new Ingreso(), new RegimenVacacionesPiloto())
            .Ejecutar(101, new DateTime(2024, 2, 29)));
    }
}
