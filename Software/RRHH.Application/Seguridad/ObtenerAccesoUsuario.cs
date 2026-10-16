using System;

namespace RRHH.Application.Seguridad;

/// <summary>
/// Autentica al usuario y obtiene el acceso con el que entra a RRHH.
/// </summary>
public sealed class ObtenerAccesoUsuario
{
	private readonly IAccesoUsuarioRepository _repository;

	public ObtenerAccesoUsuario(IAccesoUsuarioRepository repository)
	{
		_repository = repository ?? throw new ArgumentNullException(nameof(repository));
	}

	/// <summary>
	/// <c>null</c> si las credenciales son inválidas, si el usuario no está activo,
	/// no tiene rol o no está asociado a un empleado (RRHH lo necesita).
	/// </summary>
	public AccesoUsuario Ejecutar(string codigoSistema, string login, string password)
	{
		if (string.IsNullOrWhiteSpace(login) || string.IsNullOrEmpty(password))
		{
			return null;
		}

		AccesoUsuario acceso = _repository.Autenticar(codigoSistema, login.Trim(), password);
		return acceso?.IdEmpleado == null ? null : acceso;
	}
}
