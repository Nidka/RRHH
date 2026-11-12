using System;
using System.Collections.Generic;
using RRHH.Application.Permisos;
using RRHH.Presentation.Permisos;

namespace RRHH.Tests.Fakes;

internal sealed class FakeRepAusenciasView : IRepAusenciasView
{
	public DateTime Desde { get; set; } = new DateTime(2026, 11, 10);

	public DateTime Hasta { get; set; } = new DateTime(2026, 11, 12);

	public int? MotivoSeleccionado { get; set; }

	public IReadOnlyList<MotivoAusenciaDto> MotivosMostrados { get; private set; }

	public IReadOnlyList<AusenciaPorPeriodoDto> AusenciasMostradas { get; private set; }

	public string Resumen { get; private set; }

	public List<string> Errores { get; } = new List<string>();

	public List<bool> EstadosConsulta { get; } = new List<bool>();

	public event EventHandler CargarSolicitado;

	public event EventHandler ConsultarSolicitado;

	public void Cargar() => CargarSolicitado?.Invoke(this, EventArgs.Empty);

	public void Consultar() => ConsultarSolicitado?.Invoke(this, EventArgs.Empty);

	public void MostrarMotivos(IReadOnlyList<MotivoAusenciaDto> motivos) => MotivosMostrados = motivos;

	public void MostrarAusencias(IReadOnlyList<AusenciaPorPeriodoDto> ausencias) => AusenciasMostradas = ausencias;

	public void MostrarResumen(string resumen) => Resumen = resumen;

	public void HabilitarConsulta(bool habilitada) => EstadosConsulta.Add(habilitada);

	public void MostrarError(string mensaje) => Errores.Add(mensaje);
}
