using System;

namespace RRHH.Application.Permisos;

/// <summary>Fila del reporte de ausencias por periodo (RF-18).</summary>
public sealed class AusenciaPorPeriodoDto
{
	public int IdEmpleado { get; set; }

	public string Empleado { get; set; }

	public int IdMotivo { get; set; }

	public string Motivo { get; set; }

	/// <summary>Primer día del permiso completo, aunque empiece antes del periodo consultado.</summary>
	public DateTime Inicio { get; set; }

	/// <summary>Último día del permiso completo, aunque termine después del periodo consultado.</summary>
	public DateTime Fin { get; set; }

	/// <summary>Días calendario del permiso que caen dentro del periodo consultado, ambos extremos incluidos.</summary>
	public int DiasEnPeriodo { get; set; }
}
