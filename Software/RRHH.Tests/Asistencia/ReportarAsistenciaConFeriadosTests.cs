using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Asistencia;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Asistencia;

/// <summary>Regresiones del doble conteo en el reporte general y del modo Productividad.</summary>
public sealed class ReportarAsistenciaConFeriadosTests
{
    private sealed class Fechas : IFechasAsistenciaRepository
    {
        public IReadOnlyList<DateTime> Valores { get; set; } = Array.Empty<DateTime>();
        public int Consultas { get; private set; }
        public IReadOnlyList<DateTime> Listar(int empleado, RangoFechas periodo)
        {
            Consultas++;
            return Valores;
        }
    }

    [Theory]
    [InlineData(false, 4)]
    [InlineData(true, 3)]
    public void FeriadoYSabadoConMarcacionCuentanUnaVez(bool productividad, int total)
    {
        var fechas = new Fechas { Valores = new[] {
            new DateTime(2026, 11, 9), new DateTime(2026, 11, 11), new DateTime(2026, 11, 14),
            new DateTime(2026, 11, 14, 16, 0, 0), new DateTime(2026, 11, 20)
        }};
        var feriados = new FakeFeriadoRepository();
        feriados.Registros.Add(Feriado.Reconstituir(1, new DateTime(2026, 11, 11), "Ficticio"));
        var resultado = new ReportarAsistenciaConFeriados(fechas, feriados)
            .Ejecutar(101, new DateTime(2026, 11, 9), new DateTime(2026, 11, 15), productividad);
        Assert.Equal(total, resultado.Total);
        Assert.Equal(7, resultado.Dias.Count);
        Assert.True(resultado.Dias.Single(dia => dia.Fecha.Day == 11).Asistio);
        Assert.True(resultado.Dias.Single(dia => dia.Fecha.Day == 14).NoLaborable);
    }

    [Theory]
    [InlineData(false, 2)]
    [InlineData(true, 0)]
    public void SinMarcacionesConservaElCriterioDelModo(bool productividad, int total)
    {
        var resultado = new ReportarAsistenciaConFeriados(new Fechas(), new FakeFeriadoRepository())
            .Ejecutar(101, new DateTime(2026, 11, 14), new DateTime(2026, 11, 15), productividad);
        Assert.Equal(total, resultado.Total);
    }

    /// <summary>
    /// Escenario del enunciado «Consultar asistencia desde el año 2008». El heredado fijaba el año 2008 en
    /// FrmConsultaFaltas (parámetro Anio de spRRHH_Faltas); aquí la consulta histórica no tiene un año fijo.
    /// Semana del lunes 25/02 al domingo 02/03/2008, con el 29 de febrero bisiesto y un feriado ficticio el 27.
    /// </summary>
    [Theory]
    [InlineData(false, 5)]
    [InlineData(true, 2)]
    public void ConsultaHistoricaDe2008IncluyeElBisiestoYElFeriado(bool productividad, int total)
    {
        var fechas = new Fechas { Valores = new[] { new DateTime(2008, 2, 25), new DateTime(2008, 2, 29) } };
        var feriados = new FakeFeriadoRepository();
        feriados.Registros.Add(Feriado.Reconstituir(1, new DateTime(2008, 2, 27), "Ficticio"));
        var resultado = new ReportarAsistenciaConFeriados(fechas, feriados)
            .Ejecutar(101, new DateTime(2008, 2, 25), new DateTime(2008, 3, 2), productividad);
        Assert.Equal(total, resultado.Total);
        Assert.Equal(7, resultado.Dias.Count);
        Assert.True(resultado.Dias.Single(dia => dia.Fecha == new DateTime(2008, 2, 29)).Asistio);
    }

    /// <summary>El año 2008 completo: 366 días, 104 de fin de semana y el feriado ficticio del martes 1 de enero.</summary>
    [Fact]
    public void ConsultaDelAnio2008CompletoCuentaCadaDiaNoLaborableUnaVez()
    {
        var feriados = new FakeFeriadoRepository();
        feriados.Registros.Add(Feriado.Reconstituir(1, new DateTime(2008, 1, 1), "Ficticio"));
        var resultado = new ReportarAsistenciaConFeriados(new Fechas(), feriados)
            .Ejecutar(101, new DateTime(2008, 1, 1), new DateTime(2008, 12, 31), false);
        Assert.Equal(366, resultado.Dias.Count);
        Assert.Equal(105, resultado.Total);
    }

    [Fact]
    public void RangoInvertidoNoConsultaDatos()
    {
        var fechas = new Fechas();
        var caso = new ReportarAsistenciaConFeriados(fechas, new FakeFeriadoRepository());
        Assert.Throws<ReglaNegocioException>(() =>
            caso.Ejecutar(101, new DateTime(2026, 11, 15), new DateTime(2026, 11, 9), false));
        Assert.Equal(0, fechas.Consultas);
    }
}
