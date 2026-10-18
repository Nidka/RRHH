using System;
using System.Collections.Generic;
using RRHH.Application.Asistencia;
using RRHH.Presentation.Asistencia;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Asistencia;

public class HorariosPresenterTests
{
    [Fact]
    public void SinSeleccionNoAbreEditorNiPideConfirmacion()
    {
        var repo = new FakeHorarioRepository(); var view = Listado(repo);
        view.Editar(); view.Eliminar();
        Assert.Equal(0, view.Aperturas);
        Assert.Equal(0, view.Confirmaciones);
        Assert.Equal(0, repo.Escrituras);
        Assert.NotNull(view.Error);
    }

    [Theory]
    [InlineData(false, 1)]
    [InlineData(true, 2)]
    public void RecargaSoloAlGuardarElEditor(bool guardado, int lecturas)
    {
        var repo = new FakeHorarioRepository(); var view = Listado(repo);
        view.Guardado = guardado; view.Agregar();
        Assert.Equal(lecturas, repo.Lecturas);
        Assert.Null(view.IdAbierto);
    }

    [Fact]
    public void CancelarBorradoNoEscribe()
    {
        var repo = new FakeHorarioRepository(); var view = Listado(repo);
        view.HorarioSeleccionado = 7; view.Confirmar = false; view.Eliminar();
        Assert.Equal(0, repo.Escrituras);
    }

    [Fact]
    public void ReferenciasImpidenBorradoYRecarga()
    {
        var repo = new FakeHorarioRepository { EnUso = true }; var view = Listado(repo);
        view.HorarioSeleccionado = 7; view.Eliminar();
        Assert.Equal("Horario referenciado", view.Error);
        Assert.Equal(1, repo.Lecturas);
        Assert.Equal(0, repo.Escrituras);
    }

    [Fact]
    public void FalloDeCargaDeshabilitaAccionesYNoAbreEditor()
    {
        var repo = new FakeHorarioRepository { Fallar = true }; var view = Listado(repo);
        view.Agregar();
        Assert.False(view.Habilitado);
        Assert.Equal(0, view.Aperturas);
        Assert.NotNull(view.Error);
    }

    [Fact]
    public void CargaDeEditorEsSoloLecturaYGuardaUnaVez()
    {
        var repo = new FakeHorarioRepository(); repo.Datos.Add(Datos(7));
        var view = Editor(repo, 7);
        Assert.Equal(0, repo.Escrituras);
        Assert.Equal("Turno", view.Descripcion);
        view.Guardar(); view.Guardar();
        Assert.True(view.Cerrado);
        Assert.Equal(1, repo.Escrituras);
    }

    [Fact]
    public void RegistroEliminadoAntesDeCargarNoPermiteGuardar()
    {
        var repo = new FakeHorarioRepository(); var view = Editor(repo, 7);
        view.Guardar();
        Assert.False(view.Habilitado);
        Assert.False(view.Cerrado);
        Assert.Equal(0, repo.Escrituras);
        Assert.NotNull(view.Error);
    }

    [Fact]
    public void ValidacionFallidaConservaEditorYPermiteCorregir()
    {
        var repo = new FakeHorarioRepository(); var view = Editor(repo, 0);
        view.Ingreso1 = "27:00"; view.Guardar();
        Assert.False(view.Cerrado); Assert.True(view.Habilitado); Assert.Equal(0, repo.Escrituras);
        view.Ingreso1 = "07:00"; view.Guardar();
        Assert.True(view.Cerrado); Assert.Equal(1, repo.Escrituras);
    }

    [Fact]
    public void FalloDePersistenciaMantieneEditorAbierto()
    {
        var repo = new FakeHorarioRepository(); var view = Editor(repo, 0);
        repo.Fallar = true; view.Guardar();
        Assert.False(view.Cerrado); Assert.True(view.Habilitado); Assert.NotNull(view.Error);
    }

    [Fact]
    public void CasoDeUsoInformaRegistroEliminadoYNoCambiaId()
    {
        var dto = Datos(7);
        Assert.False(new GuardarHorario(new FakeHorarioRepository()).Ejecutar(dto).Exitoso);
        Assert.Equal(7, dto.Id);
    }

    private static HorariosView Listado(FakeHorarioRepository repo)
    {
        var view = new HorariosView();
        _ = new HorariosPresenter(view, new ListarHorarios(repo), new EliminarHorario(repo));
        view.Cargar(); return view;
    }
    private static EditorView Editor(FakeHorarioRepository repo, int id)
    {
        var view = new EditorView { IdHorario = id };
        _ = new HorarioEditorPresenter(view, new ObtenerHorario(repo), new GuardarHorario(repo));
        view.Cargar(); return view;
    }
    private static HorarioDto Datos(int id) => new HorarioDto
    {
        Id=id, Descripcion="Turno", Ingreso1="07:00", Salida1="12:00", Ingreso2="13:00", Salida2="17:00", Estado=null
    };

    private sealed class HorariosView : IHorariosView
    {
        public int? HorarioSeleccionado { get; set; }
        public bool Habilitado; public string Error; public int Aperturas; public int Confirmaciones;
        public bool Guardado; public bool Confirmar = true; public int? IdAbierto;
        public event EventHandler CargarSolicitado;
        public event EventHandler AgregarSolicitado;
        public event EventHandler EditarSolicitado;
        public event EventHandler EliminarSolicitado;
        public void Cargar() => CargarSolicitado?.Invoke(this, EventArgs.Empty);
        public void Agregar() => AgregarSolicitado?.Invoke(this, EventArgs.Empty);
        public void Editar() => EditarSolicitado?.Invoke(this, EventArgs.Empty);
        public void Eliminar() => EliminarSolicitado?.Invoke(this, EventArgs.Empty);
        public void MostrarHorarios(IReadOnlyList<HorarioDto> horarios) { }
        public void HabilitarAcciones(bool habilitadas) => Habilitado=habilitadas;
        public bool AbrirEditor(int? id) { Aperturas++; IdAbierto=id; return Guardado; }
        public bool ConfirmarEliminacion() { Confirmaciones++; return Confirmar; }
        public void MostrarError(string mensaje) => Error=mensaje;
    }
    private sealed class EditorView : IHorarioEditorView
    {
        public int IdHorario { get; set; }
        public string Descripcion { get; set; } = "Turno";
        public string Ingreso1 { get; set; } = "07:00";
        public string Salida1 { get; set; } = "12:00";
        public string Ingreso2 { get; set; } = "13:00";
        public string Salida2 { get; set; } = "17:00";
        public bool? Estado { get; set; }
        public bool Cerrado; public bool Habilitado; public string Error;
        public event EventHandler CargarSolicitado;
        public event EventHandler GuardarSolicitado;
        public void Cargar() => CargarSolicitado?.Invoke(this, EventArgs.Empty);
        public void Guardar() => GuardarSolicitado?.Invoke(this, EventArgs.Empty);
        public void MostrarHorario(HorarioDto h)
        { Descripcion=h.Descripcion; Ingreso1=h.Ingreso1; Salida1=h.Salida1; Ingreso2=h.Ingreso2; Salida2=h.Salida2; Estado=h.Estado; }
        public void HabilitarGuardar(bool habilitado) => Habilitado=habilitado;
        public void MostrarError(string mensaje) => Error=mensaje;
        public void CerrarGuardado() => Cerrado=true;
    }
}
