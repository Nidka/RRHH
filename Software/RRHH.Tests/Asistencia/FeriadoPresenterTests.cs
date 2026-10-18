using System;
using RRHH.Application.Asistencia;
using RRHH.Domain.Asistencia;
using RRHH.Presentation.Asistencia;
using RRHH.Tests.Fakes;
using Xunit;

namespace RRHH.Tests.Asistencia;

public class FeriadoPresenterTests
{
	private static readonly DateTime HoyFijo = new DateTime(2026, 10, 17);

	private readonly FakeFeriadoRepository _repository = new FakeFeriadoRepository();
	private readonly FakeFeriadoView _view = new FakeFeriadoView();

	private void Iniciar()
	{
		_repository.Registros.Add(Feriado.Reconstituir(1, new DateTime(2026, 1, 1), "AÑO NUEVO"));
		_repository.Registros.Add(Feriado.Reconstituir(2, new DateTime(2026, 5, 1), "DIA DEL TRABAJO"));

		_ = new FeriadoPresenter(
			_view,
			new ListarFeriados(_repository),
			new RegistrarFeriado(_repository),
			new EliminarFeriado(_repository),
			() => HoyFijo);
	}

	[Fact]
	public void Cargar_MuestraLosFeriadosDelRepositorio()
	{
		Iniciar();

		_view.Cargar();

		Assert.Equal(2, _view.Mostrados.Count);
		Assert.Equal("AÑO NUEVO", _view.Mostrados[0].Motivo);
		Assert.Equal("DIA DEL TRABAJO", _view.Mostrados[1].Motivo);
	}

	[Fact]
	public void Agregar_FeriadoNuevo_InsertaRecargaYReiniciaControles()
	{
		Iniciar();
		_view.FechaCaptura = new DateTime(2026, 7, 28, 14, 20, 0);
		_view.MotivoCaptura = "  FIESTAS PATRIAS ";

		_view.Agregar();

		Assert.Empty(_view.Alertas);
		Assert.Equal(3, _view.Mostrados.Count);
		Assert.Equal("FIESTAS PATRIAS", _view.Mostrados[2].Motivo);
		Assert.Equal(new DateTime(2026, 7, 28), _view.Mostrados[2].Fecha);
		Assert.Equal(1, _view.ReiniciosCaptura);
		Assert.Equal(string.Empty, _view.MotivoCaptura);
		Assert.Equal(HoyFijo, _view.FechaCaptura);
	}

	[Fact]
	public void Agregar_FechaDuplicada_MuestraAlertaYNoInserta()
	{
		Iniciar();
		_view.FechaCaptura = new DateTime(2026, 1, 1, 9, 0, 0);
		_view.MotivoCaptura = "AÑO NUEVO REPETIDO";

		_view.Agregar();

		Assert.Equal("Ya a Agregado esa Fecha", Assert.Single(_view.Alertas));
		Assert.Equal(2, _repository.Registros.Count);
		Assert.Equal(0, _view.ReiniciosCaptura);
	}

	[Fact]
	public void Agregar_MotivoVacio_MuestraAlertaYNoInserta()
	{
		Iniciar();
		_view.FechaCaptura = new DateTime(2026, 12, 25);
		_view.MotivoCaptura = "   ";

		_view.Agregar();

		Assert.Equal("Debe ingresar motivo.", Assert.Single(_view.Alertas));
		Assert.Equal(2, _repository.Registros.Count);
	}

	[Fact]
	public void Eliminar_SinSeleccion_MuestraMensajeYNoElimina()
	{
		Iniciar();
		_view.FeriadoSeleccionado = null;

		_view.Eliminar();

		Assert.Equal(
			"Primero debe Seleccionar un Feriado No Laborable.",
			Assert.Single(_view.Mensajes));
		Assert.Empty(_view.FechasConfirmadas);
		Assert.Equal(2, _repository.Registros.Count);
	}

	[Fact]
	public void Eliminar_ConfirmacionCancelada_NoElimina()
	{
		Iniciar();
		_view.FeriadoSeleccionado = new FeriadoDto
		{
			Id = 1,
			Fecha = new DateTime(2026, 1, 1),
			Motivo = "AÑO NUEVO"
		};
		_view.RespuestaConfirmacion = false;

		_view.Eliminar();

		Assert.Equal(new DateTime(2026, 1, 1), Assert.Single(_view.FechasConfirmadas));
		Assert.Equal(2, _repository.Registros.Count);
	}

	[Fact]
	public void Eliminar_Confirmado_EliminaElElegidoYRecarga()
	{
		Iniciar();
		_view.FeriadoSeleccionado = new FeriadoDto
		{
			Id = 1,
			Fecha = new DateTime(2026, 1, 1),
			Motivo = "AÑO NUEVO"
		};
		_view.RespuestaConfirmacion = true;

		_view.Eliminar();

		FeriadoDto restante = Assert.Single(_view.Mostrados);
		Assert.Equal(2, restante.Id);
		Assert.Equal("DIA DEL TRABAJO", restante.Motivo);
	}

	[Fact]
	public void Agregar_ErrorDeBaseDeDatos_MuestraAlerta()
	{
		Iniciar();
		_repository.FallarAlGuardar = true;
		_view.FechaCaptura = new DateTime(2026, 12, 25);
		_view.MotivoCaptura = "NAVIDAD";

		_view.Agregar();

		Assert.Equal("No se pudo registrar el feriado: Conexión perdida", Assert.Single(_view.Alertas));
	}
}

