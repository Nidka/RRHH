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

/// <summary>
/// RF-16 (CR-016): personal en teletrabajo total o parcial. Periodo de referencia: lunes 9 a viernes 13 de noviembre de 2026
/// (5 días laborables). Todos los datos son ficticios.
/// </summary>
public sealed class ClasificacionTeletrabajoTests
{
    private const int LunesMiercolesViernes = 1 + 4 + 16;

    private readonly ConsultaFalsa _consulta = new ConsultaFalsa();
    private readonly FakeFeriadoRepository _feriados = new FakeFeriadoRepository();

    private static DateTime Dia(int dia) => new DateTime(2026, 11, dia);

    private ReportarTeletrabajoTotalOParcial Caso =>
        new ReportarTeletrabajoTotalOParcial(new ReportarDiasTeletrabajo(_consulta, _feriados), _feriados);

    private IReadOnlyList<ClasificacionTeletrabajoDto> Consultar(int desde = 9, int hasta = 13, ModalidadTeletrabajo? filtro = null) =>
        Caso.Ejecutar(Dia(desde), Dia(hasta), filtro);

    [Fact]
    public void PeriodoTotalQueCubreTodoElRango_EsTotal()
    {
        Agregar(101, 9, 13);

        ClasificacionTeletrabajoDto fila = Assert.Single(Consultar());

        Assert.Equal(ModalidadTeletrabajo.Total, fila.Clasificacion);
        Assert.Equal(5, fila.DiasRemotos);
        Assert.Equal(5, fila.DiasLaborables);
    }

    [Fact]
    public void PatronConTresDiasDeCinco_EsParcial()
    {
        Agregar(101, 9, 13, LunesMiercolesViernes);

        ClasificacionTeletrabajoDto fila = Assert.Single(Consultar());

        Assert.Equal(ModalidadTeletrabajo.Parcial, fila.Clasificacion);
        Assert.Equal(3, fila.DiasRemotos);
        Assert.Equal(5, fila.DiasLaborables);
    }

    [Fact]
    public void UnFeriadoEnElRango_NoImpideQueSeaTotal()
    {
        _feriados.Registros.Add(Feriado.Crear(1, Dia(11), "Feriado ficticio"));
        Agregar(101, 9, 13);

        ClasificacionTeletrabajoDto fila = Assert.Single(Consultar());

        Assert.Equal(ModalidadTeletrabajo.Total, fila.Clasificacion);
        Assert.Equal(4, fila.DiasLaborables);
    }

    [Fact]
    public void PeriodoTotalQueCubreSoloParteDelRango_EsParcial()
    {
        // Criterio por cobertura del periodo consultado, no por la modalidad registrada.
        Agregar(101, 9, 11);

        ClasificacionTeletrabajoDto fila = Assert.Single(Consultar());

        Assert.Equal(ModalidadTeletrabajo.Parcial, fila.Clasificacion);
        Assert.Equal(3, fila.DiasRemotos);
    }

    [Fact]
    public void DosPeriodosConsecutivosQueJuntosCubrenElRango_EsTotal()
    {
        Agregar(101, 9, 10);
        Agregar(101, 11, 13);

        Assert.Equal(ModalidadTeletrabajo.Total, Assert.Single(Consultar()).Clasificacion);
    }

    [Fact]
    public void SinPeriodosEnElRango_DevuelveListaVacia()
    {
        Agregar(101, 16, 20);

        Assert.Empty(Consultar());
    }

    [Fact]
    public void RangoSinDiasLaborables_DevuelveListaVacia()
    {
        Agregar(101, 9, 15);

        Assert.Empty(Consultar(14, 15));
    }

    [Fact]
    public void UnPeriodoSoloEnUnFeriado_NoFigura()
    {
        _feriados.Registros.Add(Feriado.Crear(1, Dia(11), "Feriado ficticio"));
        Agregar(101, 11, 11);

        Assert.Empty(Consultar());
    }

    [Fact]
    public void FiltrarPorClasificacion_DevuelveSoloEsaClase()
    {
        Agregar(101, 9, 13);
        Agregar(102, 9, 13, LunesMiercolesViernes);

        Assert.Equal(101, Assert.Single(Consultar(filtro: ModalidadTeletrabajo.Total)).IdEmpleado);
        Assert.Equal(102, Assert.Single(Consultar(filtro: ModalidadTeletrabajo.Parcial)).IdEmpleado);
        Assert.Equal(2, Consultar().Count);
    }

    [Fact]
    public void UnaFilaPorEmpleadoOrdenadaPorCodigo_AunConPeriodosRepetidos()
    {
        Agregar(103, 9, 13);
        Agregar(101, 9, 13, LunesMiercolesViernes);
        Agregar(101, 9, 13, LunesMiercolesViernes);

        Assert.Equal(new[] { 101, 103 }, Consultar().Select(f => f.IdEmpleado).ToArray());
    }

    [Fact]
    public void PeriodoInvertido_LanzaReglaDeNegocioSinConsultar()
    {
        Agregar(101, 9, 13);

        Assert.Throws<ReglaNegocioException>(() => Consultar(13, 9));
        Assert.Equal(0, _consulta.Consultas);
    }

    [Fact]
    public void ArgumentosNulos_Lanzan()
    {
        var dias = new ReportarDiasTeletrabajo(_consulta, _feriados);
        Assert.Throws<ArgumentNullException>(() => new ReportarTeletrabajoTotalOParcial(null, _feriados));
        Assert.Throws<ArgumentNullException>(() => new ReportarTeletrabajoTotalOParcial(dias, null));
    }

    [Fact]
    public void Presenter_MuestraFilasYResumen()
    {
        Agregar(101, 9, 13);
        Agregar(102, 9, 13, LunesMiercolesViernes);
        var vista = new VistaFalsa();
        _ = new ClasificacionTeletrabajoPresenter(vista, Caso);

        vista.Consultar();

        Assert.Equal(2, vista.Filas.Count);
        Assert.Equal("2 personas en teletrabajo: 1 total y 1 parcial", vista.Resumen);
        Assert.Null(vista.Error);
    }

    [Fact]
    public void Presenter_SinPersonal_InformaQueNadieTeletrabaja()
    {
        var vista = new VistaFalsa();
        _ = new ClasificacionTeletrabajoPresenter(vista, Caso);

        vista.Consultar();

        Assert.Empty(vista.Filas);
        Assert.Equal(ClasificacionTeletrabajoPresenter.ResumenSinPersonal, vista.Resumen);
    }

    [Fact]
    public void Presenter_AplicaElFiltroDeLaVista()
    {
        Agregar(101, 9, 13);
        Agregar(102, 9, 13, LunesMiercolesViernes);
        var vista = new VistaFalsa { Filtro = ModalidadTeletrabajo.Parcial };
        _ = new ClasificacionTeletrabajoPresenter(vista, Caso);

        vista.Consultar();

        Assert.Equal(102, Assert.Single(vista.Filas).IdEmpleado);
    }

    [Fact]
    public void Presenter_ComunicaElErrorDeReglaYLaFallaDeInfraestructura()
    {
        var vista = new VistaFalsa { Hasta = Dia(8) };
        _ = new ClasificacionTeletrabajoPresenter(vista, Caso);

        vista.Consultar();
        Assert.Contains("fecha final", vista.Error);

        vista.Hasta = Dia(13);
        _feriados.FallarAlConsultar = true;
        vista.Consultar();
        Assert.Contains("No se pudo consultar el reporte", vista.Error);
    }

    [Fact]
    public void Presenter_ArgumentosNulos_Lanzan()
    {
        Assert.Throws<ArgumentNullException>(() => new ClasificacionTeletrabajoPresenter(null, Caso));
        Assert.Throws<ArgumentNullException>(() => new ClasificacionTeletrabajoPresenter(new VistaFalsa(), null));
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
        public int Consultas { get; private set; }

        public IReadOnlyList<PeriodoTeletrabajoDto> Consultar(int? empleado, RangoFechas rango)
        {
            Consultas++;
            return Filas.Where(p => (!empleado.HasValue || p.IdEmpleado == empleado.Value) &&
                rango.Solapa(RangoFechas.Crear(p.Desde, p.Hasta))).ToList();
        }
    }

    private sealed class VistaFalsa : IClasificacionTeletrabajoView
    {
        public DateTime Desde { get; set; } = Dia(9);
        public DateTime Hasta { get; set; } = Dia(13);
        public ModalidadTeletrabajo? Filtro { get; set; }
        public IReadOnlyList<ClasificacionTeletrabajoDto> Filas { get; private set; }
        public string Resumen { get; private set; }
        public string Error { get; private set; }
        public event EventHandler ConsultarSolicitado;
        public void Consultar() => ConsultarSolicitado?.Invoke(this, EventArgs.Empty);
        public void MostrarFilas(IReadOnlyList<ClasificacionTeletrabajoDto> filas) => Filas = filas;
        public void MostrarResumen(string resumen) => Resumen = resumen;
        public void MostrarError(string mensaje) => Error = mensaje;
    }
}
