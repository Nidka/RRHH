using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Permisos;
using RRHH.Domain.Comun;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Permisos;

/// <summary>
/// RF-18 (CR-018): ausencias por periodo. Periodo de referencia: 10 al 12 de noviembre de 2026.
/// Todos los datos son ficticios.
/// </summary>
public class ReportarAusenciasPorPeriodoTests
{
	private const int Vacaciones = 10;
	private const int Enfermedad = 20;
	private const int Licencia = 30;

	private static DateTime Dia(int dia)
	{
		return new DateTime(2026, 11, dia);
	}

	private static IReadOnlyList<AusenciaPorPeriodoDto> Consultar(FakeAusenciasRepository repo, int desde = 10, int hasta = 12, int? motivo = null)
	{
		return new ReportarAusenciasPorPeriodo(repo).Ejecutar(Dia(desde), Dia(hasta), motivo);
	}

	[Fact]
	public void SinPermisos_DevuelveListaVacia()
	{
		Assert.Empty(Consultar(new FakeAusenciasRepository()));
	}

	[Fact]
	public void PermisoDentroDelPeriodo_SeIncluyeConSusDias()
	{
		var repo = new FakeAusenciasRepository().Agregar(1, "ANA", Vacaciones, "VACACIONES", Dia(11), Dia(11));

		AusenciaPorPeriodoDto fila = Assert.Single(Consultar(repo));

		Assert.Equal("ANA", fila.Empleado);
		Assert.Equal("VACACIONES", fila.Motivo);
		Assert.Equal(1, fila.DiasEnPeriodo);
	}

	[Fact]
	public void PermisoQueEmpiezaAntesYTerminaDentro_CuentaSoloLosDiasDelPeriodo()
	{
		var repo = new FakeAusenciasRepository().Agregar(1, "ANA", Vacaciones, "VACACIONES", Dia(5), Dia(11));

		AusenciaPorPeriodoDto fila = Assert.Single(Consultar(repo));

		Assert.Equal(Dia(5), fila.Inicio);
		Assert.Equal(Dia(11), fila.Fin);
		Assert.Equal(2, fila.DiasEnPeriodo);
	}

	[Fact]
	public void PermisoQueEmpiezaDentroYTerminaDespues_SeIncluye()
	{
		var repo = new FakeAusenciasRepository().Agregar(1, "ANA", Enfermedad, "ENFERMEDAD", Dia(12), Dia(20));

		Assert.Equal(1, Assert.Single(Consultar(repo)).DiasEnPeriodo);
	}

	[Fact]
	public void PermisoQueContieneTodoElPeriodo_SeIncluye()
	{
		// El criterio heredado (solo la fecha de inicio) lo omitía.
		var repo = new FakeAusenciasRepository().Agregar(2, "BETO", Licencia, "LICENCIA", Dia(1), Dia(30));

		Assert.Equal(3, Assert.Single(Consultar(repo)).DiasEnPeriodo);
	}

	[Fact]
	public void PermisoQueTerminaElDiaPrevioOEmpiezaElSiguiente_SeExcluye()
	{
		var repo = new FakeAusenciasRepository()
			.Agregar(3, "CARLA", Vacaciones, "VACACIONES", Dia(1), Dia(9))
			.Agregar(3, "CARLA", Vacaciones, "VACACIONES", Dia(13), Dia(14));

		Assert.Empty(Consultar(repo));
	}

	[Fact]
	public void PermisoQueTocaSoloUnExtremo_SeIncluyeConUnDia()
	{
		var repo = new FakeAusenciasRepository()
			.Agregar(1, "ANA", Vacaciones, "VACACIONES", Dia(5), Dia(10))
			.Agregar(2, "BETO", Enfermedad, "ENFERMEDAD", Dia(12), Dia(20));

		IReadOnlyList<AusenciaPorPeriodoDto> filas = Consultar(repo);

		Assert.Equal(2, filas.Count);
		Assert.All(filas, f => Assert.Equal(1, f.DiasEnPeriodo));
	}

	[Fact]
	public void PeriodoDeUnSoloDia_IncluyeLosPermisosQueLoCubren()
	{
		var repo = new FakeAusenciasRepository()
			.Agregar(1, "ANA", Vacaciones, "VACACIONES", Dia(10), Dia(12))
			.Agregar(2, "BETO", Licencia, "LICENCIA", Dia(13), Dia(13));

		AusenciaPorPeriodoDto fila = Assert.Single(Consultar(repo, 11, 11));

		Assert.Equal("ANA", fila.Empleado);
		Assert.Equal(1, fila.DiasEnPeriodo);
	}

	[Fact]
	public void FiltrarPorMotivo_DevuelveSoloEseMotivo()
	{
		var repo = new FakeAusenciasRepository()
			.Agregar(1, "ANA", Vacaciones, "VACACIONES", Dia(10), Dia(12))
			.Agregar(2, "BETO", Enfermedad, "ENFERMEDAD", Dia(10), Dia(12));

		AusenciaPorPeriodoDto fila = Assert.Single(Consultar(repo, motivo: Enfermedad));

		Assert.Equal("BETO", fila.Empleado);
		Assert.Equal(Enfermedad, repo.UltimoMotivo);
	}

	[Fact]
	public void MotivoCero_SeTrataComoTodosLosMotivos()
	{
		var repo = new FakeAusenciasRepository()
			.Agregar(1, "ANA", Vacaciones, "VACACIONES", Dia(10), Dia(12))
			.Agregar(2, "BETO", Enfermedad, "ENFERMEDAD", Dia(10), Dia(12));

		Assert.Equal(2, Consultar(repo, motivo: 0).Count);
		Assert.Null(repo.UltimoMotivo);
	}

	[Fact]
	public void DistingueMotivoYPersona_UnaPersonaConDosMotivosApareceDosVeces()
	{
		var repo = new FakeAusenciasRepository()
			.Agregar(1, "ANA", Vacaciones, "VACACIONES", Dia(10), Dia(10))
			.Agregar(1, "ANA", Enfermedad, "ENFERMEDAD", Dia(11), Dia(12));

		IReadOnlyList<AusenciaPorPeriodoDto> filas = Consultar(repo);

		Assert.Equal(new[] { "VACACIONES", "ENFERMEDAD" }, filas.Select(f => f.Motivo).ToArray());
		Assert.All(filas, f => Assert.Equal(1, f.IdEmpleado));
	}

	[Fact]
	public void ElResultadoSeOrdenaPorPersonaYLuegoPorInicio()
	{
		var repo = new FakeAusenciasRepository()
			.Agregar(2, "BETO", Licencia, "LICENCIA", Dia(11), Dia(11))
			.Agregar(1, "ANA", Enfermedad, "ENFERMEDAD", Dia(12), Dia(12))
			.Agregar(1, "ANA", Vacaciones, "VACACIONES", Dia(10), Dia(10));

		string[] orden = Consultar(repo).Select(f => f.Empleado + ":" + f.Motivo).ToArray();

		Assert.Equal(new[] { "ANA:VACACIONES", "ANA:ENFERMEDAD", "BETO:LICENCIA" }, orden);
	}

	[Fact]
	public void SiElRepositorioDevuelveDeMas_ElCasoDeUsoVuelveAFiltrarPorPeriodoYMotivo()
	{
		var repo = new FakeAusenciasRepository { DevolverSinFiltrar = true }
			.Agregar(1, "ANA", Vacaciones, "VACACIONES", Dia(10), Dia(12))
			.Agregar(2, "BETO", Vacaciones, "VACACIONES", Dia(20), Dia(25))
			.Agregar(3, "CARLA", Enfermedad, "ENFERMEDAD", Dia(10), Dia(12));

		AusenciaPorPeriodoDto fila = Assert.Single(Consultar(repo, motivo: Vacaciones));

		Assert.Equal("ANA", fila.Empleado);
	}

	[Fact]
	public void PermisoConFechasInvertidasEnLosDatos_SeOmiteSinAbortarElReporte()
	{
		var repo = new FakeAusenciasRepository { DevolverSinFiltrar = true }
			.Agregar(1, "ANA", Vacaciones, "VACACIONES", Dia(12), Dia(10))
			.Agregar(2, "BETO", Licencia, "LICENCIA", Dia(10), Dia(12));

		Assert.Equal("BETO", Assert.Single(Consultar(repo)).Empleado);
	}

	[Fact]
	public void LaHoraDelPermisoSeIgnora()
	{
		var repo = new FakeAusenciasRepository()
			.Agregar(1, "ANA", Vacaciones, "VACACIONES", new DateTime(2026, 11, 9, 18, 0, 0), new DateTime(2026, 11, 10, 8, 0, 0));

		Assert.Equal(1, Assert.Single(Consultar(repo)).DiasEnPeriodo);
	}

	[Fact]
	public void PeriodoInvertido_LanzaReglaNegocioSinConsultar()
	{
		var repo = new FakeAusenciasRepository();

		Assert.Throws<ReglaNegocioException>(() => Consultar(repo, desde: 12, hasta: 10));
		Assert.Equal(0, repo.Consultas);
	}

	[Fact]
	public void RepositorioNulo_LanzaArgumentNull()
	{
		Assert.Throws<ArgumentNullException>(() => new ReportarAusenciasPorPeriodo(null));
	}
}
