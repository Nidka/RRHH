using System;

namespace RRHH.Application.Asistencia;

/// <summary>Datos de una asignación; Numero cero significa alta, FechaRegistro no se edita.</summary>
public sealed class AsignacionHorarioDto
{
    public int IdEmpleado { get; set; }
    public int Numero { get; set; }
    public DateTime Desde { get; set; }
    public DateTime Hasta { get; set; }
    public int IdHorario { get; set; }
    public string Documento { get; set; }
    public string Sisgedo { get; set; }
    public DateTime? FechaRegistro { get; set; }
}

/// <summary>Identificación de empleado para el encabezado del editor y del histórico.</summary>
public sealed class EmpleadoHorarioDto
{
    public string Nombres { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public string Documento { get; set; }
    public byte[] Foto { get; set; }
}
