using System;
using RRHH.Application.Permisos;
using RRHH.Presentation.Permisos;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Permisos;

/// <summary>RF-18 (CR-018): el presenter del reporte de ausencias solo coordina; las reglas están en el caso de uso.</summary>
public class RepAusenciasPresenterTests
{
	private static DateTime Dia(int dia)
	{
		return new DateTime(2026, 11, dia);
	}

	private static (FakeRepAusenciasView Vista, FakeAusenciasRepository Repo) Crear()
	{
		var repo = new FakeAusenciasRepository();
		var vista = new FakeRepAusenciasView();
		_ = new RepAusenciasPresenter(vista, new ReportarAusenciasPorPeriodo(repo));
		return (vista, repo);
	}

	[Fact]
	public void Cargar_EntregaLosMotivosALaVista()
	{
		var (vista, repo) = Crear();
		repo.Motivos.Add(new MotivoAusenciaDto { Id = 10, Descripcion = "VACACIONES" });

		vista.Cargar();

		Assert.Equal("VACACIONES", Assert.Single(vista.MotivosMostrados).Descripcion);
		Assert.Empty(vista.Errores);
	}

	[Fact]
	public void Cargar_SiFallaElRepositorio_MuestraElError()
	{
		var (vista, repo) = Crear();
		repo.Fallar = true;

		vista.Cargar();

		Assert.Contains("No se pudieron cargar los motivos", Assert.Single(vista.Errores));
	}

	[Fact]
	public void Consultar_MuestraLasAusenciasYElResumen()
	{
		var (vista, repo) = Crear();
		repo.Agregar(1, "ANA", 10, "VACACIONES", Dia(10), Dia(11))
			.Agregar(1, "ANA", 20, "ENFERMEDAD", Dia(12), Dia(12))
			.Agregar(2, "BETO", 30, "LICENCIA", Dia(1), Dia(30));

		vista.Consultar();

		Assert.Equal(3, vista.AusenciasMostradas.Count);
		Assert.Equal("2 personas ausentes (3 permisos)", vista.Resumen);
		Assert.Empty(vista.Errores);
	}

	[Fact]
	public void Consultar_UnaPersonaUnPermiso_UsaElSingular()
	{
		var (vista, repo) = Crear();
		repo.Agregar(1, "ANA", 10, "VACACIONES", Dia(10), Dia(11));

		vista.Consultar();

		Assert.Equal("1 persona ausente (1 permiso)", vista.Resumen);
	}

	[Fact]
	public void Consultar_SinAusencias_InformaQueNadieSeAusenta()
	{
		var (vista, _) = Crear();

		vista.Consultar();

		Assert.Empty(vista.AusenciasMostradas);
		Assert.Equal(RepAusenciasPresenter.ResumenSinAusencias, vista.Resumen);
	}

	[Fact]
	public void Consultar_AplicaElMotivoElegidoEnLaVista()
	{
		var (vista, repo) = Crear();
		repo.Agregar(1, "ANA", 10, "VACACIONES", Dia(10), Dia(12))
			.Agregar(2, "BETO", 20, "ENFERMEDAD", Dia(10), Dia(12));
		vista.MotivoSeleccionado = 20;

		vista.Consultar();

		Assert.Equal("BETO", Assert.Single(vista.AusenciasMostradas).Empleado);
		Assert.Equal(20, repo.UltimoMotivo);
	}

	[Fact]
	public void Consultar_PeriodoInvertido_MuestraElMensajeDeLaReglaSinConsultar()
	{
		var (vista, repo) = Crear();
		vista.Desde = Dia(12);
		vista.Hasta = Dia(10);

		vista.Consultar();

		Assert.Equal("La fecha final no puede ser anterior a la fecha inicial.", Assert.Single(vista.Errores));
		Assert.Equal(0, repo.Consultas);
		Assert.Null(vista.AusenciasMostradas);
	}

	[Fact]
	public void Consultar_SiFallaElRepositorio_MuestraErrorYVuelveAHabilitar()
	{
		var (vista, repo) = Crear();
		repo.Fallar = true;

		vista.Consultar();

		Assert.Contains("No se pudo consultar las ausencias", Assert.Single(vista.Errores));
		Assert.Equal(new[] { false, true }, vista.EstadosConsulta.ToArray());
	}

	[Fact]
	public void Consultar_DeshabilitaMientrasTrabajaYHabilitaAlTerminar()
	{
		var (vista, _) = Crear();

		vista.Consultar();

		Assert.Equal(new[] { false, true }, vista.EstadosConsulta.ToArray());
	}

	[Fact]
	public void ConstructorConArgumentosNulos_Lanza()
	{
		Assert.Throws<ArgumentNullException>(() => new RepAusenciasPresenter(null, new ReportarAusenciasPorPeriodo(new FakeAusenciasRepository())));
		Assert.Throws<ArgumentNullException>(() => new RepAusenciasPresenter(new FakeRepAusenciasView(), null));
	}
}
