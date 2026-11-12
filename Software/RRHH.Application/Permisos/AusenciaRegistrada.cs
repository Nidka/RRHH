using System;

namespace RRHH.Application.Permisos;

/// <summary>
/// Permiso tal como lo devuelve el repositorio para el reporte de ausencias (RF-18):
/// la persona, el motivo y el intervalo completo del permiso, sin recortar al periodo consultado.
/// </summary>
public sealed class AusenciaRegistrada
{
	/// <summary><c>public."Permiso"."IdEmpleado"</c>.</summary>
	public int IdEmpleado { get; set; }

	/// <summary>Apellidos y nombres de la persona (<c>public."Persona"</c>).</summary>
	public string Empleado { get; set; }

	/// <summary><c>public."Permiso"."idMotivo"</c>; 0 cuando el permiso no tiene motivo.</summary>
	public int IdMotivo { get; set; }

	/// <summary><c>public."Motivo_Perm"."Descrip_Motivo"</c>.</summary>
	public string Motivo { get; set; }

	/// <summary>Primer día del permiso; se ignora la hora.</summary>
	public DateTime Inicio { get; set; }

	/// <summary>Último día del permiso, incluido; se ignora la hora.</summary>
	public DateTime Fin { get; set; }
}
