using System;
namespace RRHH.Application.Asistencia;

/// <summary>Fila histórica tipada; nombres conservados para las columnas de la grilla heredada.</summary>
/// <remarks>Fechas/horario pueden faltar en datos recuperados; consultar no los repara.</remarks>
public sealed class HistoricoHorarioDto
{
    public int IdEmpleado { get; set; }
    public int N { get; set; }
    public DateTime? FechaInicio { get; set; }
    public DateTime? FechaFin { get; set; }
    public int? HorarioAsignado { get; set; }
    public string Descrip_Horario { get; set; }
    public string Ingreso1 { get; set; }
    public string Salida2 { get; set; }
    public string NroDocumento { get; set; }
    public string Sisgedo { get; set; }
    public DateTime? FechaRegistro { get; set; }
}
