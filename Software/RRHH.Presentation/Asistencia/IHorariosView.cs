using System;
using System.Collections.Generic;
using RRHH.Application.Asistencia;

namespace RRHH.Presentation.Asistencia;

/// <summary>Vista pasiva del listado con navegación modal proporcionada por la composición.</summary>
public interface IHorariosView
{
    /// <summary>Null cuando no hay fila de datos seleccionada.</summary>
    int? HorarioSeleccionado { get; }
    event EventHandler CargarSolicitado;
    event EventHandler AgregarSolicitado;
    event EventHandler EditarSolicitado;
    event EventHandler EliminarSolicitado;
    void MostrarHorarios(IReadOnlyList<HorarioDto> horarios);
    void HabilitarAcciones(bool habilitadas);
    /// <summary>Null para alta. True solo si el editor se cerró tras guardar; false al cancelar.</summary>
    bool AbrirEditor(int? id);
    bool ConfirmarEliminacion();
    void MostrarError(string mensaje);
}
