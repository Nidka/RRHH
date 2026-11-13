using System;
using System.Collections.Generic;
using RRHH.Application.Asistencia;

namespace RRHH.Presentation.Asistencia;

/// <summary>Vista pasiva del editor de periodos. Los eventos de carga y cancelación no escriben.</summary>
public interface IAsignacionHorarioView
{
    int IdEmpleado { get; }
    /// <summary>Cero para alta; número de la fila seleccionada para edición.</summary>
    int Numero { get; }
    int IdHorario { get; }
    DateTime Desde { get; }
    DateTime Hasta { get; }
    string Documento { get; }
    string Sisgedo { get; }
    event EventHandler CargarSolicitado;
    event EventHandler GuardarSolicitado;
    void MostrarEmpleado(EmpleadoHorarioDto empleado);
    void MostrarHorarios(IReadOnlyList<HorarioDto> horarios);
    void MostrarAsignacion(AsignacionHorarioDto asignacion);
    void HabilitarGuardar(bool habilitado);
    void MostrarError(string mensaje);
    /// <summary>Cierra con resultado OK únicamente tras confirmar la escritura.</summary>
    void CerrarGuardado();
}
