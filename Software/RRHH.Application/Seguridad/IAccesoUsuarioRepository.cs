namespace RRHH.Application.Seguridad;

public interface IAccesoUsuarioRepository
{
	/// <summary>
	/// Autentica al usuario activo <paramref name="login"/> (sin distinguir
	/// mayúsculas ni espacios) y devuelve su acceso a <paramref name="codigoSistema"/>.
	/// Si tiene varios roles, devuelve el de menor código. <c>null</c> si las
	/// credenciales o el acceso no son válidos.
	/// </summary>
	AccesoUsuario Autenticar(string codigoSistema, string login, string password);
}
