using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Comun;
using RRHH.Domain.Teletrabajo;
using RRHH.Presentation.Teletrabajo;
using Xunit;

namespace RRHH.Tests.Teletrabajo;

public sealed class RegistroTeletrabajoTests
{
    private static DateTime Dia(int dia) => new DateTime(2026, 11, dia);
    private readonly RepositorioFalso _repo = new RepositorioFalso();

    [Fact]
    public void Registra_y_lista_un_dia_para_un_empleado_existente()
    {
        Assert.Equal(1, Alta(101, 10, 10));
        var item = Assert.Single(new ListarPeriodosTeletrabajo(_repo).Ejecutar(101));
        Assert.Equal(Dia(10), item.Hasta);
    }

    [Theory]
    [InlineData(10, 12)]
    [InlineData(12, 14)]
    [InlineData(9, 13)]
    public void Rechaza_solapamiento_del_mismo_empleado(int desde, int hasta)
    {
        Alta(101, 10, 12);
        Assert.Throws<ReglaNegocioException>(() => Alta(101, desde, hasta));
        Assert.Single(_repo.Periodos);
    }

    [Fact]
    public void Otro_empleado_y_rangos_contiguos_pueden_registrarse()
    {
        Alta(101, 10, 12);
        Alta(102, 10, 12);
        Alta(101, 13, 14);
        Assert.Equal(3, _repo.Periodos.Count);
    }

    [Fact]
    public void Rechaza_rango_invertido_y_empleado_inexistente()
    {
        Assert.Throws<ReglaNegocioException>(() => Alta(101, 12, 10));
        Assert.Throws<ReglaNegocioException>(() => Alta(999, 10, 10));
        Assert.Empty(_repo.Periodos);
    }

    [Theory]
    [InlineData(999, 31)]
    [InlineData(1, 0)]
    [InlineData(1, 31)]
    public void Rechaza_modalidad_o_patron_invalido(int modalidad, int mascara)
    {
        Assert.Throws<ReglaNegocioException>(() => new RegistrarPeriodoTeletrabajo(_repo)
            .Ejecutar(101, Dia(10), Dia(10), (ModalidadTeletrabajo)modalidad, mascara, null));
        Assert.Empty(_repo.Periodos);
    }

    [Fact]
    public void Presenter_refresca_la_consulta_y_comunica_un_conflicto()
    {
        var vista = new VistaFalsa();
        _ = new TeletrabajoPresenter(vista, new RegistrarPeriodoTeletrabajo(_repo), new ListarPeriodosTeletrabajo(_repo));
        vista.Registrar();
        Assert.Equal(1, vista.IdRegistrado);
        Assert.Single(vista.Filas);
        vista.Registrar();
        Assert.Contains("solapa", vista.Error);
        Assert.Single(_repo.Periodos);
    }

    private int Alta(int empleado, int desde, int hasta) => new RegistrarPeriodoTeletrabajo(_repo)
        .Ejecutar(empleado, Dia(desde), Dia(hasta), ModalidadTeletrabajo.Total, 31, null);

    private sealed class RepositorioFalso : ITeletrabajoRepository
    {
        public List<PeriodoTeletrabajo> Periodos { get; } = new List<PeriodoTeletrabajo>();
        public int Registrar(PeriodoTeletrabajo periodo)
        {
            if (periodo.IdEmpleado != 101 && periodo.IdEmpleado != 102) throw new ReglaNegocioException("Empleado inexistente.");
            if (Periodos.Any(periodo.Solapa)) throw new ReglaNegocioException("El periodo se solapa.");
            Periodos.Add(periodo);
            return Periodos.Count;
        }

        public IReadOnlyList<PeriodoTeletrabajoDto> Listar(int empleado) => Periodos
            .Select((p, i) => new PeriodoTeletrabajoDto { Id = i + 1, IdEmpleado = p.IdEmpleado, Desde = p.Rango.Desde, Hasta = p.Rango.Hasta })
            .Where(p => p.IdEmpleado == empleado).ToList();
    }

    private sealed class VistaFalsa : ITeletrabajoView
    {
        public int IdEmpleado => 101;
        public DateTime Desde => Dia(10);
        public DateTime Hasta => Dia(10);
        public ModalidadTeletrabajo Modalidad => ModalidadTeletrabajo.Total;
        public int DiasRemotos => 31;
        public string Autorizacion => null;
        public int IdRegistrado { get; private set; }
        public string Error { get; private set; }
        public IReadOnlyList<PeriodoTeletrabajoDto> Filas { get; private set; }
        public event EventHandler RegistrarSolicitado;
        public event EventHandler ListarSolicitado { add { } remove { } }
        public void Registrar() => RegistrarSolicitado?.Invoke(this, EventArgs.Empty);
        public void MostrarPeriodos(IReadOnlyList<PeriodoTeletrabajoDto> periodos) => Filas = periodos;
        public void MostrarRegistro(int id) => IdRegistrado = id;
        public void MostrarError(string mensaje) => Error = mensaje;
    }
}
