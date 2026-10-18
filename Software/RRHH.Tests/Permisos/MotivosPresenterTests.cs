using System;
using System.Collections.Generic;
using RRHH.Application.Catalogos;
using RRHH.Application.Permisos;
using RRHH.Domain.Permisos;
using RRHH.Presentation.Permisos;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Permisos;

public class MotivosPresenterTests
{
    private readonly FakeMotivoPermisoRepository _repo = new FakeMotivoPermisoRepository();

    [Fact]
    public void CargarEditorExistenteSoloLeeYConservaCampos()
    {
        _repo.Registros.Add(MotivoPermiso.Reconstituir(4, 1, "Anterior", "A", null, "P", false));
        var view = new EditorView { IdMotivo = 4, IdTipoPermiso = 1 };
        Editor(view);
        view.Cargar();
        Assert.Equal("Anterior", view.Descripcion);
        Assert.Null(view.Salario);
        Assert.Equal(0, _repo.Escrituras);
        Assert.True(view.GuardarHabilitado);
        Assert.False(view.Cerrado);
    }

    [Fact]
    public void CargaFallidaNoPermiteGuardarUnEditorVacio()
    {
        var view = new EditorView { IdMotivo = 4, IdTipoPermiso = 1 };
        Editor(view);
        view.Cargar(); view.Guardar();
        Assert.False(view.GuardarHabilitado);
        Assert.NotEmpty(view.Errores);
        Assert.Equal(0, _repo.Escrituras);
    }

    [Fact]
    public void GuardadoInvalidoMantieneEditorAbiertoYSinEscritura()
    {
        var view = new EditorView { IdTipoPermiso = 1, Descripcion = " " };
        Editor(view); view.Cargar(); view.Guardar();
        Assert.False(view.Cerrado);
        Assert.True(view.GuardarHabilitado);
        Assert.Single(view.Errores);
        Assert.Equal(0, _repo.Escrituras);
    }

    [Fact]
    public void ErrorDePersistenciaNoCierraEditorYPuedeReintentarse()
    {
        var view = new EditorView { IdTipoPermiso = 1, Descripcion = "Nuevo" };
        Editor(view); view.Cargar();
        _repo.Fallar = true; view.Guardar();
        Assert.False(view.Cerrado);
        Assert.True(view.GuardarHabilitado);
        Assert.Single(view.Errores);
        _repo.Fallar = false; view.Guardar();
        Assert.True(view.Cerrado);
        Assert.Equal(1, _repo.Escrituras);
    }

    [Fact]
    public void EditarSinSeleccionNoAbreDialogo()
    {
        var view = new ListadoView { TipoPermisoSeleccionado = 1 };
        Listado(view); view.Cargar(); view.Editar();
        Assert.Equal(0, view.Aperturas);
        Assert.Single(view.Errores);
    }

    [Fact]
    public void EditorCanceladoNoRecargaYGuardadoSiRecarga()
    {
        var view = new ListadoView { TipoPermisoSeleccionado = 1 };
        Listado(view); view.Cargar();
        int antes = _repo.Listados;
        view.ResultadoEditor = false; view.Agregar();
        Assert.Equal(antes, _repo.Listados);
        view.ResultadoEditor = true; view.Agregar();
        Assert.Equal(antes + 1, _repo.Listados);
    }

    [Fact]
    public void EliminarCanceladoNoEscribeNiRecarga()
    {
        _repo.Registros.Add(MotivoPermiso.Reconstituir(1, 1, "Motivo", null, null, "P", true));
        var view = new ListadoView { TipoPermisoSeleccionado = 1, MotivoSeleccionado = 1, Confirmacion = false };
        Listado(view); view.Cargar();
        int antes = _repo.Listados; view.Eliminar();
        Assert.Equal(0, _repo.Escrituras);
        Assert.Equal(antes, _repo.Listados);
        Assert.Single(_repo.Registros);
    }

    [Fact]
    public void EliminarEnUsoInformaYMantieneListado()
    {
        _repo.Registros.Add(MotivoPermiso.Reconstituir(1, 1, "Motivo", null, null, "P", true));
        _repo.EnUso.Add(1);
        var view = new ListadoView { TipoPermisoSeleccionado = 1, MotivoSeleccionado = 1, Confirmacion = true };
        Listado(view); view.Cargar(); view.Eliminar();
        Assert.Single(view.Errores);
        Assert.Equal(0, _repo.Escrituras);
    }

    [Fact]
    public void RolDesconocidoNoCargaDatosNiAbreEditor()
    {
        var view = new ListadoView { TipoPermisoSeleccionado = 1 };
        Listado(view, 3); view.Cargar(); view.Agregar(); view.CambiarTipo();
        Assert.False(view.Acciones);
        Assert.Equal(0, view.Aperturas);
        Assert.Equal(0, _repo.Listados);
    }

    private void Editor(EditorView view) => _ = new MotivoPermisoEditorPresenter(view,
        new ObtenerMotivoPermiso(_repo, new AccesoMotivosPermiso(10)),
        new GuardarMotivoPermiso(_repo, new AccesoMotivosPermiso(10)));

    private void Listado(ListadoView view, int rol = 10) => _ = new MotivosPermisoPresenter(view,
        new ListarCatalogo(new FakeCatalogoRepository()),
        new ListarMotivosPermiso(_repo, new AccesoMotivosPermiso(rol)),
        new EliminarMotivoPermiso(_repo, new AccesoMotivosPermiso(rol)));

    private sealed class EditorView : IMotivoPermisoEditorView
    {
        public int IdMotivo { get; set; }
        public int IdTipoPermiso { get; set; }
        public string Descripcion { get; set; }
        public string Abreviatura { get; set; }
        public bool? Salario { get; set; }
        public bool GuardarHabilitado { get; private set; }
        public bool Cerrado { get; private set; }
        public List<string> Errores { get; } = new List<string>();
        public event EventHandler CargarSolicitado;
        public event EventHandler GuardarSolicitado;
        public void Cargar() => CargarSolicitado?.Invoke(this, EventArgs.Empty);
        public void Guardar() => GuardarSolicitado?.Invoke(this, EventArgs.Empty);
        public void MostrarMotivo(MotivoPermisoDto dto)
        { Descripcion = dto.Descripcion; Abreviatura = dto.Abreviatura; Salario = dto.Salario; }
        public void MostrarError(string mensaje) => Errores.Add(mensaje);
        public void HabilitarGuardar(bool habilitado) => GuardarHabilitado = habilitado;
        public void CerrarGuardado() => Cerrado = true;
    }

    private sealed class ListadoView : IMotivosPermisoView
    {
        public int TipoPermisoSeleccionado { get; set; }
        public int? MotivoSeleccionado { get; set; }
        public bool ResultadoEditor { get; set; }
        public bool Confirmacion { get; set; }
        public int Aperturas { get; private set; }
        public bool Acciones { get; private set; }
        public List<string> Errores { get; } = new List<string>();
        public event EventHandler CargarSolicitado;
        public event EventHandler TipoCambiado;
        public event EventHandler AgregarSolicitado;
        public event EventHandler EditarSolicitado;
        public event EventHandler EliminarSolicitado;
        public void Cargar() => CargarSolicitado?.Invoke(this, EventArgs.Empty);
        public void CambiarTipo() => TipoCambiado?.Invoke(this, EventArgs.Empty);
        public void Agregar() => AgregarSolicitado?.Invoke(this, EventArgs.Empty);
        public void Editar() => EditarSolicitado?.Invoke(this, EventArgs.Empty);
        public void Eliminar() => EliminarSolicitado?.Invoke(this, EventArgs.Empty);
        public void MostrarTipos(IList<ItemCatalogoDto> tipos) { }
        public void MostrarMotivos(IReadOnlyList<MotivoPermisoDto> motivos) { }
        public void HabilitarAcciones(bool habilitadas) => Acciones = habilitadas;
        public void MostrarError(string mensaje) => Errores.Add(mensaje);
        public void MostrarInformacion(string mensaje) { }
        public bool ConfirmarEliminacion() => Confirmacion;
        public bool AbrirEditor(int tipo, int? id) { Aperturas++; return ResultadoEditor; }
    }
}
