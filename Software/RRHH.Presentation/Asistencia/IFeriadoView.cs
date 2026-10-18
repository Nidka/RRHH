using System;
using System.Collections.Generic;
using RRHH.Application.Asistencia;

namespace RRHH.Presentation.Asistencia;

/// <summary>
/// Contrato de vista pasiva para la pantalla de gestión de feriados (<c>FrmFeriado</c>).
/// </summary>
public interface IFeriadoView
{
	event EventHandler CargarSolicitado;

	event EventHandler AgregarSolicitado;

	event EventHandler EliminarSolicitado;

	DateTime FechaCaptura { get; }

	string MotivoCaptura { get; }

	FeriadoDto FeriadoSeleccionado { get; }

	void MostrarFeriados(IList<FeriadoDto> feriados);

	void ReiniciarCaptura(DateTime fechaPorDefecto);

	bool ConfirmarEliminacion(DateTime fecha);

	void MostrarAlerta(string mensaje);

	void MostrarMensaje(string mensaje);
}
