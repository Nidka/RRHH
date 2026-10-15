using System;

namespace RRHH.Domain.Comun;

/// <summary>
/// Se lanza cuando un dato no cumple una regla de negocio. El mensaje está
/// redactado para mostrarse directamente al usuario.
/// </summary>
public sealed class ReglaNegocioException : Exception
{
	public ReglaNegocioException(string mensaje)
		: base(mensaje)
	{
	}
}
