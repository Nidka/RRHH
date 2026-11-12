using System;
using RRHH.Domain.Teletrabajo;

namespace RRHH.Application.Teletrabajo;

/// <summary>Fila tipada para consultar un periodo registrado.</summary>
public sealed class PeriodoTeletrabajoDto
{
    public int Id { get; set; }
    public int IdEmpleado { get; set; }
    public DateTime Desde { get; set; }
    public DateTime Hasta { get; set; }
    public ModalidadTeletrabajo Modalidad { get; set; }
    public int DiasRemotos { get; set; }
    public string Autorizacion { get; set; }
}
