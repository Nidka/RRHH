using System;
using System.Collections.Generic;
using RRHH.Application.Asistencia;
using RRHH.Presentation.Asistencia;

namespace RRHH.Tests.Fakes;

internal sealed class FakeFeriadoView : IFeriadoView
{
	public DateTime FechaCaptura { get; set; } = new DateTime(2026, 7, 28);

	public string MotivoCaptura { get; set; } = string.Empty;

	public FeriadoDto FeriadoSeleccionado { get; set; }

	public bool RespuestaConfirmacion { get; set; } = true;

	public IList<FeriadoDto> Mostrados { get; private set; } = new List<FeriadoDto>();

	public List<DateTime> FechasConfirmadas { get; } = new List<DateTime>();

	public List<string> Alertas { get; } = new List<string>();

	public List<string> Mensajes { get; } = new List<string>();

	public int ReiniciosCaptura { get; private set; }

	public event EventHandler CargarSolicitado;

	public event EventHandler AgregarSolicitado;

	public event EventHandler EliminarSolicitado;

	public void Cargar() => CargarSolicitado?.Invoke(this, EventArgs.Empty);

	public void Agregar() => AgregarSolicitado?.Invoke(this, EventArgs.Empty);

	public void Eliminar() => EliminarSolicitado?.Invoke(this, EventArgs.Empty);

	public void MostrarFeriados(IList<FeriadoDto> feriados)
	{
		Mostrados = feriados;
	}

	public void ReiniciarCaptura(DateTime fechaPorDefecto)
	{
		ReiniciosCaptura++;
		MotivoCaptura = string.Empty;
		FechaCaptura = fechaPorDefecto;
	}

	public bool ConfirmarEliminacion(DateTime fecha)
	{
		FechasConfirmadas.Add(fecha);
		return RespuestaConfirmacion;
	}

	public void MostrarAlerta(string mensaje)
	{
		Alertas.Add(mensaje);
	}

	public void MostrarMensaje(string mensaje)
	{
		Mensajes.Add(mensaje);
	}
}

