using System;

namespace RRHH.Application.Asistencia;

/// <summary>
/// Registro de feriado expuesto a la capa de presentación.
/// </summary>
public sealed class FeriadoDto
{
	public int Id { get; set; }

	public DateTime Fecha { get; set; }

	public string Motivo { get; set; }
}
