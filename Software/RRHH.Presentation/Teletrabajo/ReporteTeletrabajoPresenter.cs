using System;
using System.Collections.Generic;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Comun;

namespace RRHH.Presentation.Teletrabajo;

/// <summary>Entrada de consulta y salida tipada del reporte de días remotos.</summary>
public interface IReporteTeletrabajoView
{
    int? IdEmpleado { get; }
    DateTime Desde { get; }
    DateTime Hasta { get; }
    event EventHandler ConsultarSolicitado;
    void MostrarFilas(IReadOnlyList<DiasTeletrabajoDto> filas);
    void MostrarError(string mensaje);
}

/// <summary>Ejecuta la consulta y comunica resultados y errores a la vista.</summary>
public sealed class ReporteTeletrabajoPresenter
{
    private readonly IReporteTeletrabajoView _vista;
    private readonly ReportarDiasTeletrabajo _reporte;

    public ReporteTeletrabajoPresenter(IReporteTeletrabajoView vista, ReportarDiasTeletrabajo reporte)
    {
        _vista = vista;
        _reporte = reporte;
        vista.ConsultarSolicitado += Consultar;
    }

    private void Consultar(object sender, EventArgs e)
    {
        try { _vista.MostrarFilas(_reporte.Ejecutar(_vista.IdEmpleado, _vista.Desde, _vista.Hasta)); }
        catch (ReglaNegocioException ex) { _vista.MostrarError(ex.Message); }
        catch (Exception) { _vista.MostrarError("No se pudo consultar el reporte. Compruebe la conexión y el esquema."); }
    }
}
