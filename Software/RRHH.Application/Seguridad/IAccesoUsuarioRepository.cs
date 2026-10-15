namespace RRHH.Application.Seguridad;

public interface IAccesoUsuarioRepository
{
	/// <summary>
	/// Acceso del usuario activo <paramref name="login"/> (sin distinguir
	/// mayúsculas ni espacios) a un rol del sistema <paramref name="codigoSistema"/>.
	/// Si tiene varios roles, devuelve el de menor código. <c>null</c> si no tiene acceso.
	/// </summary>
	AccesoUsuario Buscar(string codigoSistema, string login);
}
