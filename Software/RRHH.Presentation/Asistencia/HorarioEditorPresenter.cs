using System;
using RRHH.Application.Asistencia;

namespace RRHH.Presentation.Asistencia;

/// <summary>Carga sin escrituras y guarda solo ante la acción explícita del usuario.</summary>
public sealed class HorarioEditorPresenter
{
    private readonly IHorarioEditorView _view;
    private readonly ObtenerHorario _obtener;
    private readonly GuardarHorario _guardar;
    private bool _cargado;

    public HorarioEditorPresenter(IHorarioEditorView view, ObtenerHorario obtener, GuardarHorario guardar)
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
            if (_view.IdHorario != 0) _view.MostrarHorario(_obtener.Ejecutar(_view.IdHorario));
            _cargado = true;
            _view.HabilitarGuardar(true);
        }
        catch (Exception ex) { _view.MostrarError("No se pudo cargar el horario: " + ex.Message); }
    }

    private void Guardar()
    {
        if (!_cargado) return;
        _view.HabilitarGuardar(false);
        try
        {
            var resultado = _guardar.Ejecutar(new HorarioDto
            {
                Id = _view.IdHorario, Descripcion = _view.Descripcion, Estado = _view.Estado,
                Ingreso1 = _view.Ingreso1, Salida1 = _view.Salida1,
                Ingreso2 = _view.Ingreso2, Salida2 = _view.Salida2
            });
            if (resultado.Exitoso)
            {
                _cargado = false;
                _view.CerrarGuardado();
            }
            else _view.MostrarError(resultado.Mensaje);
        }
        catch (Exception ex) { _view.MostrarError("No se pudo guardar el horario: " + ex.Message); }
        finally { if (_cargado) _view.HabilitarGuardar(true); }
    }
}
