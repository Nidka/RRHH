using RRHH.Application.Seguridad;
using Xunit;

namespace RRHH.Tests.Seguridad;

public class Pbkdf2PasswordHasherTests
{
	[Fact]
	public void HashCreado_VerificaLaContrasenaCorrecta()
	{
		PasswordHash hash = Pbkdf2PasswordHasher.Crear("Una-Clave-Segura-123");

		Assert.True(Pbkdf2PasswordHasher.Verificar(
			"Una-Clave-Segura-123", hash.Hash, hash.Salt, hash.Iterations));
		Assert.False(Pbkdf2PasswordHasher.Verificar(
			"Clave-Incorrecta-123", hash.Hash, hash.Salt, hash.Iterations));
	}

	[Fact]
	public void HashMalFormado_NoLanzaExcepcion()
	{
		Assert.False(Pbkdf2PasswordHasher.Verificar("Password-123", "no-base64", "no-base64", 210000));
	}
}
