using System;
using RRHH.Application.Asistencia;

namespace RRHH.Presentation.Asistencia;

/// <summary>Coordina selección, navegación y una sola recarga tras guardar o eliminar.</summary>
public sealed class HorariosPresenter
{
    private readonly IHorariosView _view;
    private readonly ListarHorarios _listar;
    private readonly EliminarHorario _eliminar;
    private bool _cargado;

    public HorariosPresenter(IHorariosView view, ListarHorarios listar, EliminarHorario eliminar)
    {
        _view = view ?? throw new ArgumentNullException(nameof(view));
        _listar = listar ?? throw new ArgumentNullException(nameof(listar));
        _eliminar = eliminar ?? throw new ArgumentNullException(nameof(eliminar));
        _view.CargarSolicitado += (_, _) => Recargar();
        _view.AgregarSolicitado += (_, _) => Editar(false);
        _view.EditarSolicitado += (_, _) => Editar(true);
        _view.EliminarSolicitado += (_, _) => Eliminar();
    }

    private void Recargar()
    {
        _cargado = false;
        _view.HabilitarAcciones(false);
        try
        {
            _view.MostrarHorarios(_listar.Ejecutar());
            _cargado = true;
            _view.HabilitarAcciones(true);
        }
        catch (Exception ex) { _view.MostrarError("No se pudieron cargar los horarios: " + ex.Message); }
    }

    private void Editar(bool existente)
    {
        if (!_cargado) return;
        int? id = existente ? _view.HorarioSeleccionado : null;
        if (existente && (!id.HasValue || id.Value <= 0))
        {
            _view.MostrarError("Seleccione un horario para modificar.");
            return;
        }
        try { if (_view.AbrirEditor(id)) Recargar(); }
        catch (Exception ex) { _view.MostrarError("No se pudo abrir el horario: " + ex.Message); }
    }

    private void Eliminar()
    {
        if (!_cargado) return;
        int? id = _view.HorarioSeleccionado;
        if (!id.HasValue || id.Value <= 0)
        {
            _view.MostrarError("Seleccione un horario para eliminar.");
            return;
        }
        if (!_view.ConfirmarEliminacion()) return;
        try
        {
            var resultado = _eliminar.Ejecutar(id.Value);
            if (resultado.Exitoso) Recargar();
            else _view.MostrarError(resultado.Mensaje);
        }
        catch (Exception ex) { _view.MostrarError("No se pudo eliminar el horario: " + ex.Message); }
    }
}
