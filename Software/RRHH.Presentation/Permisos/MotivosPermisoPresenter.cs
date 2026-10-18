using System;
using RRHH.Application.Catalogos;
using RRHH.Application.Permisos;

namespace RRHH.Presentation.Permisos;

/// <summary>Una sola recarga para selección, alta, edición y eliminación.</summary>
public sealed class MotivosPermisoPresenter
{
    private readonly IMotivosPermisoView _view;
    private readonly ListarCatalogo _tipos;
    private readonly ListarMotivosPermiso _listar;
    private readonly EliminarMotivoPermiso _eliminar;

    public MotivosPermisoPresenter(IMotivosPermisoView view, ListarCatalogo tipos,
        ListarMotivosPermiso listar, EliminarMotivoPermiso eliminar)
    {
        _view = view ?? throw new ArgumentNullException(nameof(view));
        _tipos = tipos ?? throw new ArgumentNullException(nameof(tipos));
        _listar = listar ?? throw new ArgumentNullException(nameof(listar));
        _eliminar = eliminar ?? throw new ArgumentNullException(nameof(eliminar));
        _view.CargarSolicitado += (_, _) => Cargar();
        _view.TipoCambiado += (_, _) => Recargar();
        _view.AgregarSolicitado += (_, _) => Editar(false);
        _view.EditarSolicitado += (_, _) => Editar(true);
        _view.EliminarSolicitado += (_, _) => Eliminar();
    }

    private void Cargar()
    {
        _view.HabilitarAcciones(false);
        if (!_listar.Permitido)
        {
            _view.MostrarError("Su rol no tiene acceso al mantenimiento de motivos.");
            return;
        }
        try
        {
            _view.MostrarTipos(_tipos.Ejecutar(string.Empty));
            Recargar();
        }
        catch (Exception ex) { _view.MostrarError("No se pudieron cargar los tipos de permiso: " + ex.Message); }
    }

    private void Recargar()
    {
        _view.HabilitarAcciones(false);
        if (!_listar.Permitido) return;
        try
        {
            _view.MostrarMotivos(_listar.Ejecutar(_view.TipoPermisoSeleccionado));
            _view.HabilitarAcciones(_view.TipoPermisoSeleccionado > 0);
        }
        catch (Exception ex) { _view.MostrarError("No se pudieron cargar los motivos: " + ex.Message); }
    }

    private void Editar(bool existente)
    {
        if (!_listar.Permitido) return;
        if (_view.TipoPermisoSeleccionado <= 0)
        {
            _view.MostrarError("Seleccione un tipo de permiso.");
            return;
        }
        int? id = existente ? _view.MotivoSeleccionado : null;
        if (existente && (!id.HasValue || id.Value <= 0))
        {
            _view.MostrarError("Seleccione un motivo para modificar.");
            return;
        }
        try
        {
            if (_view.AbrirEditor(_view.TipoPermisoSeleccionado, id)) Recargar();
        }
        catch (Exception ex) { _view.MostrarError("No se pudo abrir el motivo: " + ex.Message); }
    }

    private void Eliminar()
    {
        if (!_listar.Permitido) return;
        int? id = _view.MotivoSeleccionado;
        if (!id.HasValue || id.Value <= 0)
        {
            _view.MostrarError("Seleccione un motivo para eliminar.");
            return;
        }
        if (!_view.ConfirmarEliminacion()) return;
        try
        {
            var resultado = _eliminar.Ejecutar(id.Value);
            if (!resultado.Exitoso) { _view.MostrarError(resultado.Mensaje); return; }
            _view.MostrarInformacion("Se eliminó el motivo.");
            Recargar();
        }
        catch (Exception ex) { _view.MostrarError("No se pudo eliminar el motivo: " + ex.Message); }
    }
}
