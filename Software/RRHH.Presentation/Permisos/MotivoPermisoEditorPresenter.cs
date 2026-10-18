using System;
using RRHH.Application.Permisos;

namespace RRHH.Presentation.Permisos;

/// <summary>Cargar es solo lectura; se escribe exclusivamente ante GuardarSolicitado.</summary>
public sealed class MotivoPermisoEditorPresenter
{
    private readonly IMotivoPermisoEditorView _view;
    private readonly ObtenerMotivoPermiso _obtener;
    private readonly GuardarMotivoPermiso _guardar;
    private bool _cargado;

    public MotivoPermisoEditorPresenter(IMotivoPermisoEditorView view,
        ObtenerMotivoPermiso obtener, GuardarMotivoPermiso guardar)
    {
        _view = view ?? throw new ArgumentNullException(nameof(view));
        _obtener = obtener ?? throw new ArgumentNullException(nameof(obtener));
        _guardar = guardar ?? throw new ArgumentNullException(nameof(guardar));
        _view.CargarSolicitado += (_, _) => Cargar();
        _view.GuardarSolicitado += (_, _) => Guardar();
    }

    private void Cargar()
    {
        _cargado = false;
        _view.HabilitarGuardar(false);
        try
        {
            if (_view.IdMotivo > 0)
            {
                MotivoPermisoDto motivo = _obtener.Ejecutar(_view.IdMotivo);
                if (motivo.TipoPermisoId != _view.IdTipoPermiso)
                {
                    _view.MostrarError("El motivo no pertenece al tipo seleccionado. Actualice el listado.");
                    return;
                }
                _view.MostrarMotivo(motivo);
            }
            _cargado = true;
            _view.HabilitarGuardar(true);
        }
        catch (Exception ex) { _view.MostrarError("No se pudo cargar el motivo: " + ex.Message); }
    }

    private void Guardar()
    {
        if (!_cargado) return;
        _view.HabilitarGuardar(false);
        try
        {
            var resultado = _guardar.Ejecutar(new MotivoPermisoDto
            {
                Id = _view.IdMotivo, TipoPermisoId = _view.IdTipoPermiso,
                Descripcion = _view.Descripcion, Abreviatura = _view.Abreviatura,
                Salario = _view.Salario
            });
            if (resultado.Exitoso) _view.CerrarGuardado();
            else _view.MostrarError(resultado.Mensaje);
        }
        catch (Exception ex) { _view.MostrarError("No se pudo guardar el motivo: " + ex.Message); }
        finally { _view.HabilitarGuardar(true); }
    }
}
