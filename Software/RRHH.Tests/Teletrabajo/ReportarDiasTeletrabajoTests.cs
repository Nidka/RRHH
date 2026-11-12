using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using RRHH.Domain.Teletrabajo;
using RRHH.Presentation.Teletrabajo;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Teletrabajo;

public sealed class ReportarDiasTeletrabajoTests
{
    private readonly ConsultaFalsa _consulta = new ConsultaFalsa();
    private readonly FakeFeriadoRepository _feriados = new FakeFeriadoRepository();
    private static DateTime Dia(int dia) => new DateTime(2026, 11, dia);
    private ReportarDiasTeletrabajo Caso => new ReportarDiasTeletrabajo(_consulta, _feriados);

    [Fact]
    public void Recorta_periodo_y_excluye_feriado()
    {
        Agregar(101, 2, 20);
        _feriados.Registros.Add(Feriado.Crear(1, Dia(11), "Feriado ficticio"));
        Assert.Equal(4, Assert.Single(Caso.Ejecutar(101, Dia(9), Dia(15))).Dias);
    }

    [Fact]
    public void Cuenta_patron_parcial_una_vez_por_empleado_y_permite_filtro()
    {
        Agregar(101, 9, 13, 5);
        Agregar(101, 9, 13, 5);
        Agregar(102, 9, 13);
        Assert.Equal(new[] { 2, 5 }, Caso.Ejecutar(null, Dia(9), Dia(13)).Select(r => r.Dias).ToArray());
        Assert.Equal(102, Assert.Single(Caso.Ejecutar(102, Dia(9), Dia(13))).IdEmpleado);
    }

    [Fact]
    public void Rango_sin_periodos_devuelve_lista_vacia()
    {
        Agregar(101, 9, 13);
        Assert.Empty(Caso.Ejecutar(null, Dia(16), Dia(20)));
    }

    [Fact]
    public void Rechaza_rango_invertido_y_codigo_invalido()
    {
        Assert.Throws<ReglaNegocioException>(() => Caso.Ejecutar(null, Dia(15), Dia(9)));
        Assert.Throws<ReglaNegocioException>(() => Caso.Ejecutar(0, Dia(9), Dia(15)));
    }

    [Fact]
    public void Presenter_entrega_filas_tipadas_y_comunica_error()
    {
        Agregar(101, 9, 13);
        var vista = new VistaFalsa();
        _ = new ReporteTeletrabajoPresenter(vista, Caso);
        vista.Consultar();
        Assert.Equal(5, Assert.Single(vista.Filas).Dias);
        vista.Hasta = Dia(8);
        vista.Consultar();
        Assert.Contains("fecha final", vista.Error);
    }

    private void Agregar(int empleado, int desde, int hasta, int dias = 31) =>
        _consulta.Filas.Add(new PeriodoTeletrabajoDto
        {
            IdEmpleado = empleado, Desde = Dia(desde), Hasta = Dia(hasta), DiasRemotos = dias,
            Modalidad = dias == 31 ? ModalidadTeletrabajo.Total : ModalidadTeletrabajo.Parcial
        });

    private sealed class ConsultaFalsa : IConsultaTeletrabajo
    {
        public List<PeriodoTeletrabajoDto> Filas { get; } = new List<PeriodoTeletrabajoDto>();
        public IReadOnlyList<PeriodoTeletrabajoDto> Consultar(int? empleado, RangoFechas rango) =>
            Filas.Where(p => (!empleado.HasValue || p.IdEmpleado == empleado.Value) &&
                rango.Solapa(RangoFechas.Crear(p.Desde, p.Hasta))).ToList();
    }

    private sealed class VistaFalsa : IReporteTeletrabajoView
    {
        public int? IdEmpleado => null;
        public DateTime Desde => Dia(9);
        public DateTime Hasta { get; set; } = Dia(13);
        public IReadOnlyList<DiasTeletrabajoDto> Filas { get; private set; }
        public string Error { get; private set; }
        public event EventHandler ConsultarSolicitado;
        public void Consultar() => ConsultarSolicitado?.Invoke(this, EventArgs.Empty);
        public void MostrarFilas(IReadOnlyList<DiasTeletrabajoDto> filas) => Filas = filas;
        public void MostrarError(string mensaje) => Error = mensaje;
    }
}
