using RRHH.Domain.Teletrabajo;

namespace RRHH.Application.Teletrabajo;

/// <summary>Fila del reporte de teletrabajo total o parcial (RF-16).</summary>
public sealed class ClasificacionTeletrabajoDto
{
    public int IdEmpleado { get; set; }

    /// <summary><see cref="ModalidadTeletrabajo.Total"/> si trabajó remoto todos los días laborables del periodo; si no, <see cref="ModalidadTeletrabajo.Parcial"/>.</summary>
    public ModalidadTeletrabajo Clasificacion { get; set; }

    /// <summary>Días laborables del periodo consultado en los que la persona teletrabaja.</summary>
    public int DiasRemotos { get; set; }

    /// <summary>Días laborables del periodo consultado (lunes a viernes sin feriados).</summary>
    public int DiasLaborables { get; set; }
}
