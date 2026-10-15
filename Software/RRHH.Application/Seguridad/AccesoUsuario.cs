namespace RRHH.Application.Seguridad;

/// <summary>Usuario activo con acceso al sistema y su rol.</summary>
public sealed class AccesoUsuario
{
	public AccesoUsuario(
		int idUsuario,
		string login,
		int? idEmpleado,
		int? idAreaOrganizacional,
		int idRol,
		string nombreEmpleado)
	{
		IdUsuario = idUsuario;
		Login = login;
		IdEmpleado = idEmpleado;
		IdAreaOrganizacional = idAreaOrganizacional;
		IdRol = idRol;
		NombreEmpleado = nombreEmpleado ?? string.Empty;
	}

	public int IdUsuario { get; }

	public string Login { get; }

	public int? IdEmpleado { get; }

	public int? IdAreaOrganizacional { get; }

	public int IdRol { get; }

	/// <summary>Apellidos y nombres; vacío si el usuario no tiene empleado.</summary>
	public string NombreEmpleado { get; }
}
