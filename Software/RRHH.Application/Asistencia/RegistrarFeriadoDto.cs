using System;

namespace RRHH.Application.Asistencia;

/// <summary>
/// Datos de entrada y salida al registrar un feriado nuevo.
/// </summary>
public sealed class RegistrarFeriadoDto
{
	public int Id { get; set; }

	public DateTime Fecha { get; set; }

	public string Motivo { get; set; }
}
