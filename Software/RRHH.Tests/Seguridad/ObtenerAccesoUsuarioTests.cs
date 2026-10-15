using RRHH.Application.Seguridad;
using Xunit;

namespace RRHH.Tests.Seguridad;

public class ObtenerAccesoUsuarioTests
{
	private sealed class FakeAccesoUsuarioRepository : IAccesoUsuarioRepository
	{
		public AccesoUsuario Resultado { get; set; }

		public string LoginRecibido { get; private set; }

		public AccesoUsuario Buscar(string codigoSistema, string login)
		{
			LoginRecibido = login;
			return Resultado;
		}
	}

	private readonly FakeAccesoUsuarioRepository _repository = new FakeAccesoUsuarioRepository();

	[Theory]
	[InlineData(null)]
	[InlineData("   ")]
	public void LoginVacio_DevuelveNullSinConsultar(string login)
	{
		Assert.Null(new ObtenerAccesoUsuario(_repository).Ejecutar("RRHH", login));
		Assert.Null(_repository.LoginRecibido);
	}

	[Fact]
	public void UsuarioConEmpleado_DevuelveElAcceso()
	{
		_repository.Resultado = new AccesoUsuario(1, "jperez", 10, null, 4, "Pérez Juan");

		AccesoUsuario acceso = new ObtenerAccesoUsuario(_repository).Ejecutar("RRHH", "  jperez ");

		Assert.Same(_repository.Resultado, acceso);
		Assert.Equal("jperez", _repository.LoginRecibido);
	}

	[Fact]
	public void UsuarioSinEmpleado_NoTieneAccesoARRHH()
	{
		_repository.Resultado = new AccesoUsuario(1, "admin", null, null, 1, null);

		Assert.Null(new ObtenerAccesoUsuario(_repository).Ejecutar("RRHH", "admin"));
	}

	[Fact]
	public void UsuarioInexistente_DevuelveNull()
	{
		Assert.Null(new ObtenerAccesoUsuario(_repository).Ejecutar("RRHH", "nadie"));
	}
}
