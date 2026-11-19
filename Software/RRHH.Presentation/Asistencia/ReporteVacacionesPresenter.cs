using System;
using System.Collections.Generic;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Presentation.Asistencia;

/// <summary>Vista pasiva del reporte RF-11.</summary>
public interface IReporteVacacionesView
{
    int Anio { get; }
    DateTime Corte { get; }
    int? Area { get; }
    int? Empleado { get; }
    event EventHandler ConsultarSolicitado;
    void Mostrar(IReadOnlyList<ReporteVacacionesDto> filas);
    void MostrarError(string mensaje);
}
/// <summary>Coordina filtros y resultados del reporte sin dependencias gráficas.</summary>
public sealed class ReporteVacacionesPresenter
{
    public ReporteVacacionesPresenter(IReporteVacacionesView vista,ReportarSaldoVacaciones reporte)
    {
        if(vista==null) throw new ArgumentNullException(nameof(vista));
        if(reporte==null) throw new ArgumentNullException(nameof(reporte));
        vista.ConsultarSolicitado+=(_,_)=>
        {
            vista.Mostrar(null);
            try {vista.Mostrar(reporte.Ejecutar(vista.Anio,vista.Corte,vista.Area,vista.Empleado));}
            catch(ReglaNegocioException ex){vista.MostrarError(ex.Message);}
            catch(Exception){vista.MostrarError("No se pudo consultar el reporte. Revise conexión y esquema.");}
        };
    }
}
