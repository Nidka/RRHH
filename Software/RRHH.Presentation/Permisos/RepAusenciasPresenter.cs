using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Permisos;
using RRHH.Domain.Comun;

namespace RRHH.Presentation.Permisos;

/// <summary>
/// Coordina el reporte de ausencias por periodo (RF-18): carga el filtro de motivos, valida el periodo
/// mediante el caso de uso y entrega a la vista el resultado y un resumen.
/// </summary>
public sealed class RepAusenciasPresenter
{
    public const string ResumenSinAusencias = "Nadie se ausenta en el periodo consultado.";

    private readonly IRepAusenciasView _view;
    private readonly ReportarAusenciasPorPeriodo _reportar;

    public RepAusenciasPresenter(IRepAusenciasView view, ReportarAusenciasPorPeriodo reportar)
    {
        _view = view ?? throw new ArgumentNullException(nameof(view));
        _reportar = reportar ?? throw new ArgumentNullException(nameof(reportar));
        _view.CargarSolicitado += (_, _) => Cargar();
        _view.ConsultarSolicitado += (_, _) => Consultar();
    }

    private void Cargar()
    {
        try
        {
            _view.MostrarMotivos(_reportar.ListarMotivos());
        }
        catch (Exception ex)
        {
            _view.MostrarError("No se pudieron cargar los motivos: " + ex.Message);
        }
    }

    private void Consultar()
    {
        _view.HabilitarConsulta(false);
        try
        {
            IReadOnlyList<AusenciaPorPeriodoDto> ausencias =
                _reportar.Ejecutar(_view.Desde, _view.Hasta, _view.MotivoSeleccionado);
            _view.MostrarAusencias(ausencias);
            _view.MostrarResumen(Resumir(ausencias));
        }
        catch (ReglaNegocioException ex)
        {
            _view.MostrarError(ex.Message);
        }
        catch (Exception ex)
        {
            _view.MostrarError("No se pudo consultar las ausencias: " + ex.Message);
        }
        finally
        {
            _view.HabilitarConsulta(true);
        }
    }

    private static string Resumir(IReadOnlyList<AusenciaPorPeriodoDto> ausencias)
    {
        if (ausencias.Count == 0)
        {
            return ResumenSinAusencias;
        }

        int personas = ausencias.Select(a => a.IdEmpleado).Distinct().Count();
        return personas + (personas == 1 ? " persona ausente" : " personas ausentes")
            + " (" + ausencias.Count + (ausencias.Count == 1 ? " permiso)" : " permisos)");
    }
}
