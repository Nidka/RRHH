using System;
using RRHH.Application.Comun;
using RRHH.Application.Permisos;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Permisos;

public class ValidarLicenciaUnaVezPorAnioTests
{
	private const int Empleado = 1;

	// Motivo ficticio marcado como de una vez por año; el número no tiene significado real.
	private const int MotivoAnual = 900;
	private const int MotivoLibre = 901;

	private static FakePermisoRepository Repo()
	{
		var repo = new FakePermisoRepository();
		repo.MotivosUnaVezPorAnio.Add(MotivoAnual);
		return repo;
	}

	private static ResultadoOperacion Validar(FakePermisoRepository repo, int empleado, int motivo, DateTime inicio, int excluir = 0)
	{
		return new ValidarLicenciaUnaVezPorAnio(repo).Ejecutar(empleado, motivo, inicio, excluir);
	}

	[Fact]
	public void PrimeraLicenciaDelAnio_Pasa()
	{
		Assert.True(Validar(Repo(), Empleado, MotivoAnual, new DateTime(2026, 3, 10)).Exitoso);
	}

	[Fact]
	public void SegundaLicenciaEnElMismoAnio_SeRechazaConMensajeClaro()
	{
		FakePermisoRepository repo = Repo().Agregar(Empleado, 1, new DateTime(2026, 3, 10), new DateTime(2026, 3, 12), MotivoAnual);

		ResultadoOperacion r = Validar(repo, Empleado, MotivoAnual, new DateTime(2026, 9, 1));

		Assert.False(r.Exitoso);
		Assert.Equal(ValidarLicenciaUnaVezPorAnio.MensajeLicenciaYaOtorgada(2026), r.Mensaje);
		Assert.Contains("2026", r.Mensaje);
	}

	[Fact]
	public void MismoTipoEnOtroAnio_Pasa()
	{
		FakePermisoRepository repo = Repo().Agregar(Empleado, 1, new DateTime(2025, 12, 30), new DateTime(2025, 12, 31), MotivoAnual);

		Assert.True(Validar(repo, Empleado, MotivoAnual, new DateTime(2026, 1, 2)).Exitoso);
	}

	[Fact]
	public void OtraPersonaConLaLicenciaDelAnio_NoBloquea()
	{
		FakePermisoRepository repo = Repo().Agregar(2, 1, new DateTime(2026, 3, 10), new DateTime(2026, 3, 12), MotivoAnual);

		Assert.True(Validar(repo, Empleado, MotivoAnual, new DateTime(2026, 9, 1)).Exitoso);
	}

	[Fact]
	public void MotivoSinLaMarca_NoSeRestringe()
	{
		FakePermisoRepository repo = Repo().Agregar(Empleado, 1, new DateTime(2026, 3, 10), new DateTime(2026, 3, 12), MotivoLibre);

		Assert.True(Validar(repo, Empleado, MotivoLibre, new DateTime(2026, 9, 1)).Exitoso);
	}

	[Fact]
	public void OtroMotivoDelMismoAnio_NoBloqueaALaLicenciaAnual()
	{
		FakePermisoRepository repo = Repo().Agregar(Empleado, 1, new DateTime(2026, 3, 10), new DateTime(2026, 3, 12), MotivoLibre);

		Assert.True(Validar(repo, Empleado, MotivoAnual, new DateTime(2026, 9, 1)).Exitoso);
	}

	[Fact]
	public void EditarLaPropiaLicencia_NoChocaConsigoMisma()
	{
		FakePermisoRepository repo = Repo().Agregar(Empleado, 1, new DateTime(2026, 3, 10), new DateTime(2026, 3, 12), MotivoAnual);

		Assert.True(Validar(repo, Empleado, MotivoAnual, new DateTime(2026, 3, 11), excluir: 1).Exitoso);
	}

	[Fact]
	public void EditarUnaLicenciaCuandoYaHayOtraEnElAnio_SeRechaza()
	{
		FakePermisoRepository repo = Repo()
			.Agregar(Empleado, 1, new DateTime(2026, 3, 10), new DateTime(2026, 3, 12), MotivoAnual)
			.Agregar(Empleado, 2, new DateTime(2025, 6, 1), new DateTime(2025, 6, 2), MotivoAnual);

		// El permiso 2 (de 2025) se mueve a 2026, donde ya existe el permiso 1.
		Assert.False(Validar(repo, Empleado, MotivoAnual, new DateTime(2026, 7, 1), excluir: 2).Exitoso);
	}

	[Fact]
	public void SinMotivoElegido_NoConsultaNiRestringe()
	{
		FakePermisoRepository repo = Repo();

		Assert.True(Validar(repo, Empleado, 0, new DateTime(2026, 3, 10)).Exitoso);
		Assert.Equal(0, repo.Consultas);
	}

	[Fact]
	public void RepositorioNulo_LanzaArgumentNull()
	{
		Assert.Throws<ArgumentNullException>(() => new ValidarLicenciaUnaVezPorAnio(null));
	}
}
