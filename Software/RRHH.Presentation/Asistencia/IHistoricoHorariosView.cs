using System;
using System.Collections.Generic;
using RRHH.Application.Asistencia;
namespace RRHH.Presentation.Asistencia;

/// <summary>Vista del histórico. Consultar/cancelar no escribe; la baja requiere confirmación explícita.</summary>
public interface IHistoricoHorariosView
{
    int IdEmpleado { get; }
    int? NumeroSeleccionado { get; }
    /// <summary>Ambas fechas nulas para todos; ambas informadas para intersección inclusiva.</summary>
    DateTime? Desde { get; }
    DateTime? Hasta { get; }
    event EventHandler CargarSolicitado;
    event EventHandler ConsultarSolicitado;
    event EventHandler AgregarSolicitado;
    event EventHandler EditarSolicitado;
    event EventHandler EliminarSolicitado;
    void MostrarEmpleado(EmpleadoHorarioDto empleado);
    void MostrarFilas(IReadOnlyList<HistoricoHorarioDto> filas);
    /// <summary>Abre RF-01 mediante composición; true solo si el usuario confirmó el guardado.</summary>
    bool AbrirEditor(int numero);
    bool ConfirmarEliminar();
    void Habilitar(bool habilitado);
    void MostrarError(string mensaje);
}
