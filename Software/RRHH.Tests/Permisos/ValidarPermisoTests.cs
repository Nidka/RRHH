using System;
using RRHH.Application.Comun;
using RRHH.Application.Permisos;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Permisos;

/// <summary>Comprueba que RF-03 y RF-06 se aplican desde un único punto de validación.</summary>
public class ValidarPermisoTests
{
	private const int Empleado = 1;
	private const int MotivoAnual = 900;

	private static ValidarPermiso Crear(FakePermisoRepository repo)
	{
		repo.MotivosUnaVezPorAnio.Add(MotivoAnual);
		return new ValidarPermiso(new ValidarPermisoSinSolapamiento(repo), new ValidarLicenciaUnaVezPorAnio(repo));
	}

	[Fact]
	public void SinConflictos_Pasa()
	{
		ResultadoOperacion r = Crear(new FakePermisoRepository())
			.Ejecutar(Empleado, MotivoAnual, new DateTime(2026, 3, 10), new DateTime(2026, 3, 12));

		Assert.True(r.Exitoso);
	}

	[Fact]
	public void PermisoSolapado_SeRechazaPorRF03()
	{
		FakePermisoRepository repo = new FakePermisoRepository().Agregar(Empleado, 1, new DateTime(2026, 3, 10), new DateTime(2026, 3, 12), 5);

		ResultadoOperacion r = Crear(repo).Ejecutar(Empleado, 5, new DateTime(2026, 3, 9), new DateTime(2026, 3, 13));

		Assert.False(r.Exitoso);
		Assert.Equal(ValidarPermisoSinSolapamiento.MensajeSolapamiento, r.Mensaje);
	}

	[Fact]
	public void LicenciaAnualRepetida_SeRechazaPorRF06()
	{
		FakePermisoRepository repo = new FakePermisoRepository().Agregar(Empleado, 1, new DateTime(2026, 3, 10), new DateTime(2026, 3, 12), MotivoAnual);

		ResultadoOperacion r = Crear(repo).Ejecutar(Empleado, MotivoAnual, new DateTime(2026, 9, 1), new DateTime(2026, 9, 2));

		Assert.False(r.Exitoso);
		Assert.Equal(ValidarLicenciaUnaVezPorAnio.MensajeLicenciaYaOtorgada(2026), r.Mensaje);
	}

	[Fact]
	public void SiHayAmbosConflictos_PrevaleceElSolapamiento()
	{
		FakePermisoRepository repo = new FakePermisoRepository().Agregar(Empleado, 1, new DateTime(2026, 3, 10), new DateTime(2026, 3, 12), MotivoAnual);

		ResultadoOperacion r = Crear(repo).Ejecutar(Empleado, MotivoAnual, new DateTime(2026, 3, 11), new DateTime(2026, 3, 11));

		Assert.Equal(ValidarPermisoSinSolapamiento.MensajeSolapamiento, r.Mensaje);
	}

	[Fact]
	public void RangoInvertido_NoLlegaAConsultarLaLicencia()
	{
		FakePermisoRepository repo = new FakePermisoRepository();

		ResultadoOperacion r = Crear(repo).Ejecutar(Empleado, MotivoAnual, new DateTime(2026, 3, 12), new DateTime(2026, 3, 10));

		Assert.False(r.Exitoso);
		Assert.Equal(0, repo.Consultas);
	}

	[Fact]
	public void ColaboradoresNulos_LanzanArgumentNull()
	{
		var repo = new FakePermisoRepository();
		Assert.Throws<ArgumentNullException>(() => new ValidarPermiso(null, new ValidarLicenciaUnaVezPorAnio(repo)));
		Assert.Throws<ArgumentNullException>(() => new ValidarPermiso(new ValidarPermisoSinSolapamiento(repo), null));
	}
}
