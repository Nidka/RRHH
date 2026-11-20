using System;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Presentation.Asistencia;

/// <summary>Vista pasiva de RF-17 y del modo Productividad conservado.</summary>
public interface IReporteAsistenciaPilotoView
{
    int Empleado {get;}
    DateTime Desde {get;}
    DateTime Hasta {get;}
    bool Productividad {get;}
    event EventHandler ConsultarSolicitado;
    void Mostrar(ResumenAsistenciaDto resultado);
    void MostrarError(string mensaje);
}
/// <summary>Expone el caso RF-17 compartido sin depender del reporte heredado.</summary>
public sealed class ReporteAsistenciaPilotoPresenter
{
    public ReporteAsistenciaPilotoPresenter(IReporteAsistenciaPilotoView vista,ReportarAsistenciaConFeriados consulta)
    {
        if(vista==null)throw new ArgumentNullException(nameof(vista));
        if(consulta==null)throw new ArgumentNullException(nameof(consulta));
        vista.ConsultarSolicitado+=(_,_)=>
        {
            vista.Mostrar(null);
            try
            {
                if((vista.Hasta.Date-vista.Desde.Date).Days>366)throw new ReglaNegocioException("Consulte hasta 367 días.");
                vista.Mostrar(consulta.Ejecutar(vista.Empleado,vista.Desde,vista.Hasta,vista.Productividad));
            }
            catch(ReglaNegocioException ex){vista.MostrarError(ex.Message);}
            catch(Exception){vista.MostrarError("No se pudo consultar la asistencia. Revise conexión y esquema.");}
        };
    }
}
