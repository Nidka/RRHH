using System;

namespace RRHH.Application.Comun;

/// <summary>
/// La infraestructura la lanza cuando no se puede eliminar un registro porque
/// otra tabla lo referencia.
/// </summary>
public sealed class RegistroEnUsoException : Exception
{
	public RegistroEnUsoException(string mensaje, Exception innerException)
		: base(mensaje, innerException)
	{
	}
}
