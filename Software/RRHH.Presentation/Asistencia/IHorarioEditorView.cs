using System;
using RRHH.Application.Asistencia;

namespace RRHH.Presentation.Asistencia;

/// <summary>Entradas y eventos del editor; cargar/cancelar no implica persistencia.</summary>
public interface IHorarioEditorView
{
    /// <summary>Cero para alta; código existente para edición.</summary>
    int IdHorario { get; }
    string Descripcion { get; }
    string Ingreso1 { get; }
    string Salida1 { get; }
    string Ingreso2 { get; }
    string Salida2 { get; }
    bool? Estado { get; }
    event EventHandler CargarSolicitado;
    event EventHandler GuardarSolicitado;
    void MostrarHorario(HorarioDto horario);
    void HabilitarGuardar(bool habilitado);
    void MostrarError(string mensaje);
    /// <summary>Cierra con resultado Guardado para que el listado se recargue.</summary>
    void CerrarGuardado();
}
