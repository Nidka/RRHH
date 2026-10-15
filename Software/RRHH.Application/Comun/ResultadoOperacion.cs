namespace RRHH.Application.Comun;

/// <summary>Resultado de un caso de uso que puede fallar por una regla de negocio.</summary>
public sealed class ResultadoOperacion
{
	private ResultadoOperacion(bool exitoso, string mensaje)
	{
		Exitoso = exitoso;
		Mensaje = mensaje;
	}

	public bool Exitoso { get; }

	/// <summary>Mensaje para el usuario; vacío cuando la operación fue exitosa.</summary>
	public string Mensaje { get; }

	public static ResultadoOperacion Ok() => new ResultadoOperacion(true, string.Empty);

	public static ResultadoOperacion Error(string mensaje) => new ResultadoOperacion(false, mensaje);
}
