using System;
using RRHH.Application.Asistencia;
using RRHH.Application.Comun;

namespace RRHH.Presentation.Asistencia;

/// <summary>
/// Coordina el listado, registro y eliminación de feriados sobre <see cref="IFeriadoView"/>.
/// </summary>
public sealed class FeriadoPresenter
{
	public const string MensajeSeleccionRequerida = "Primero debe Seleccionar un Feriado No Laborable.";

	private readonly IFeriadoView _view;
	private readonly ListarFeriados _listar;
	private readonly RegistrarFeriado _registrar;
	private readonly EliminarFeriado _eliminar;
	private readonly Func<DateTime> _obtenerFechaActual;

	public FeriadoPresenter(
		IFeriadoView view,
		ListarFeriados listar,
		RegistrarFeriado registrar,
		EliminarFeriado eliminar,
		Func<DateTime> obtenerFechaActual = null)
	{
		_view = view ?? throw new ArgumentNullException(nameof(view));
		_listar = listar ?? throw new ArgumentNullException(nameof(listar));
		_registrar = registrar ?? throw new ArgumentNullException(nameof(registrar));
		_eliminar = eliminar ?? throw new ArgumentNullException(nameof(eliminar));
		_obtenerFechaActual = obtenerFechaActual ?? (() => DateTime.Today);

		_view.CargarSolicitado += (_, _) => Cargar();
		_view.AgregarSolicitado += (_, _) => Agregar();
		_view.EliminarSolicitado += (_, _) => Eliminar();
	}

	private void Cargar()
	{
		try
		{
			_view.MostrarFeriados(_listar.Ejecutar());
		}
		catch (Exception ex)
		{
			_view.MostrarAlerta("No se pudieron cargar los feriados: " + ex.Message);
		}
	}

	private void Agregar()
	{
		var dto = new RegistrarFeriadoDto
		{
			Fecha = _view.FechaCaptura,
			Motivo = _view.MotivoCaptura
		};

		ResultadoOperacion resultado;
		try
		{
			resultado = _registrar.Ejecutar(dto);
		}
		catch (Exception ex)
		{
			_view.MostrarAlerta("No se pudo registrar el feriado: " + ex.Message);
			return;
		}

		if (!resultado.Exitoso)
		{
			_view.MostrarAlerta(resultado.Mensaje);
			return;
		}

		Cargar();
		_view.ReiniciarCaptura(_obtenerFechaActual().Date);
	}

	private void Eliminar()
	{
		FeriadoDto seleccionado = _view.FeriadoSeleccionado;
		if (seleccionado == null || seleccionado.Id <= 0)
		{
			_view.MostrarMensaje(MensajeSeleccionRequerida);
			return;
		}

		if (!_view.ConfirmarEliminacion(seleccionado.Fecha))
		{
			return;
		}

		ResultadoOperacion resultado;
		try
		{
			resultado = _eliminar.Ejecutar(seleccionado.Id);
		}
		catch (Exception ex)
		{
			_view.MostrarAlerta("No se pudo eliminar el feriado: " + ex.Message);
			return;
		}

		if (!resultado.Exitoso)
		{
			_view.MostrarAlerta(resultado.Mensaje);
			return;
		}

		Cargar();
	}
}
