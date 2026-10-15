using System;

namespace RRHH.Application.Seguridad;

/// <summary>
/// Busca el acceso con el que el usuario entra a RRHH. Solo selecciona el
/// perfil: no verifica contraseña (pendiente, ver PLAN_REFACTORIZACION.md).
/// </summary>
public sealed class ObtenerAccesoUsuario
{
	private readonly IAccesoUsuarioRepository _repository;

	public ObtenerAccesoUsuario(IAccesoUsuarioRepository repository)
	{
		_repository = repository ?? throw new ArgumentNullException(nameof(repository));
	}

	/// <summary>
	/// <c>null</c> si el login está vacío, si el usuario no está activo o no
	/// tiene rol en el sistema, o si no está asociado a un empleado (RRHH lo necesita).
	/// </summary>
	public AccesoUsuario Ejecutar(string codigoSistema, string login)
	{
		if (string.IsNullOrWhiteSpace(login))
		{
			return null;
		}

		AccesoUsuario acceso = _repository.Buscar(codigoSistema, login.Trim());
		return acceso?.IdEmpleado == null ? null : acceso;
	}
}
