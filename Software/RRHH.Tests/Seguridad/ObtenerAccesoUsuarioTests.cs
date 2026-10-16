using RRHH.Application.Seguridad;
using Xunit;

namespace RRHH.Tests.Seguridad;

public class ObtenerAccesoUsuarioTests
{
	private sealed class FakeAccesoUsuarioRepository : IAccesoUsuarioRepository
	{
		public AccesoUsuario Resultado { get; set; }

		public string LoginRecibido { get; private set; }
		public string PasswordRecibido { get; private set; }

		public AccesoUsuario Autenticar(string codigoSistema, string login, string password)
		{
			LoginRecibido = login;
			PasswordRecibido = password;
			return Resultado;
		}
	}

	private readonly FakeAccesoUsuarioRepository _repository = new FakeAccesoUsuarioRepository();

	[Theory]
	[InlineData(null)]
	[InlineData("   ")]
	public void LoginVacio_DevuelveNullSinConsultar(string login)
	{
		Assert.Null(new ObtenerAccesoUsuario(_repository).Ejecutar("RRHH", login, "Password-123"));
		Assert.Null(_repository.LoginRecibido);
	}

	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void PasswordVacio_DevuelveNullSinConsultar(string password)
	{
		Assert.Null(new ObtenerAccesoUsuario(_repository).Ejecutar("RRHH", "jperez", password));
		Assert.Null(_repository.LoginRecibido);
	}

	[Fact]
	public void UsuarioConEmpleado_DevuelveElAcceso()
	{
		_repository.Resultado = new AccesoUsuario(1, "jperez", 10, null, 4, "Pérez Juan");

		AccesoUsuario acceso = new ObtenerAccesoUsuario(_repository).Ejecutar("RRHH", "  jperez ", "Password-123");

		Assert.Same(_repository.Resultado, acceso);
		Assert.Equal("jperez", _repository.LoginRecibido);
		Assert.Equal("Password-123", _repository.PasswordRecibido);
	}

	[Fact]
	public void UsuarioSinEmpleado_NoTieneAccesoARRHH()
	{
		_repository.Resultado = new AccesoUsuario(1, "admin", null, null, 1, null);

		Assert.Null(new ObtenerAccesoUsuario(_repository).Ejecutar("RRHH", "admin", "Password-123"));
	}

	[Fact]
	public void UsuarioInexistente_DevuelveNull()
	{
		Assert.Null(new ObtenerAccesoUsuario(_repository).Ejecutar("RRHH", "nadie", "Password-123"));
	}
}
