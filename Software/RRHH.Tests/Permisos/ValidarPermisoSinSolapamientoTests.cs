using System;
using RRHH.Application.Comun;
using RRHH.Application.Permisos;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Permisos;

public class ValidarPermisoSinSolapamientoTests
{
	private const int Empleado = 1;

	private static DateTime Dia(int dia)
	{
		return new DateTime(2026, 11, dia);
	}

	// Permiso ficticio existente: del 10 al 12 de noviembre para el empleado 1.
	private static FakePermisoRepository ConPermisoDel10Al12()
	{
		return new FakePermisoRepository().Agregar(Empleado, 1, Dia(10), Dia(12));
	}

	private static ResultadoOperacion Validar(FakePermisoRepository repo, int idEmpleado, int desde, int hasta, int excluir = 0)
	{
		return new ValidarPermisoSinSolapamiento(repo).Ejecutar(idEmpleado, Dia(desde), Dia(hasta), excluir);
	}

	[Fact]
	public void SinPermisosPrevios_Pasa()
	{
		ResultadoOperacion r = Validar(new FakePermisoRepository(), Empleado, 10, 12);

		Assert.True(r.Exitoso);
		Assert.Equal(string.Empty, r.Mensaje);
	}

	[Fact]
	public void RangoIgualAlExistente_SeRechaza()
	{
		ResultadoOperacion r = Validar(ConPermisoDel10Al12(), Empleado, 10, 12);

		Assert.False(r.Exitoso);
		Assert.Equal(ValidarPermisoSinSolapamiento.MensajeSolapamiento, r.Mensaje);
	}

	[Theory]
	[InlineData(8, 10)]
	[InlineData(12, 14)]
	public void SolapamientoParcialPorUnLado_SeRechaza(int desde, int hasta)
	{
		Assert.False(Validar(ConPermisoDel10Al12(), Empleado, desde, hasta).Exitoso);
	}

	[Fact]
	public void NuevoContieneAlExistente_SeRechaza()
	{
		// Caso que RRHHClass.ExistePermiso dejaba pasar: existente 10-12, nuevo 9-13.
		Assert.False(Validar(ConPermisoDel10Al12(), Empleado, 9, 13).Exitoso);
	}

	[Fact]
	public void NuevoContenidoEnElExistente_SeRechaza()
	{
		Assert.False(Validar(ConPermisoDel10Al12(), Empleado, 11, 11).Exitoso);
	}

	[Theory]
	[InlineData(5, 9)]
	[InlineData(13, 15)]
	public void RangoSinDiasEnComun_Pasa(int desde, int hasta)
	{
		Assert.True(Validar(ConPermisoDel10Al12(), Empleado, desde, hasta).Exitoso);
	}

	[Fact]
	public void PermisoDeOtroEmpleado_NoBloquea()
	{
		Assert.True(Validar(ConPermisoDel10Al12(), 2, 10, 12).Exitoso);
	}

	[Fact]
	public void EditarElPropioPermiso_NoGeneraConflictoConsigoMismo()
	{
		Assert.True(Validar(ConPermisoDel10Al12(), Empleado, 10, 13, excluir: 1).Exitoso);
	}

	[Fact]
	public void EditarUnPermisoQueChocaConOtro_SeRechaza()
	{
		FakePermisoRepository repo = ConPermisoDel10Al12().Agregar(Empleado, 2, Dia(20), Dia(22));

		Assert.False(Validar(repo, Empleado, 12, 21, excluir: 2).Exitoso);
	}

	[Fact]
	public void RangoInvertido_DevuelveMensajeClaroSinConsultar()
	{
		FakePermisoRepository repo = ConPermisoDel10Al12();

		ResultadoOperacion r = Validar(repo, Empleado, 12, 10);

		Assert.False(r.Exitoso);
		Assert.Equal("La fecha final no puede ser anterior a la fecha inicial.", r.Mensaje);
		Assert.Equal(0, repo.Consultas);
	}

	[Fact]
	public void LaHoraDeLasFechasNoInfluye()
	{
		var repo = ConPermisoDel10Al12();

		ResultadoOperacion r = new ValidarPermisoSinSolapamiento(repo)
			.Ejecutar(Empleado, new DateTime(2026, 11, 12, 23, 0, 0), new DateTime(2026, 11, 13, 1, 0, 0));

		Assert.False(r.Exitoso);
	}

	[Fact]
	public void RepositorioNulo_LanzaArgumentNull()
	{
		Assert.Throws<ArgumentNullException>(() => new ValidarPermisoSinSolapamiento(null));
	}
}
