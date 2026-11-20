using System;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Presentation.Asistencia;

/// <summary>Vista pasiva de categorías diarias e inconsistencias.</summary>
public interface IAsistenciaConsolidadaView
{
    int Empleado { get; }
    DateTime Desde { get; }
    DateTime Hasta { get; }
    event EventHandler ConsultarSolicitado;
    void Mostrar(AsistenciaConsolidadaDto resultado);
    void MostrarError(string mensaje);
}
/// <summary>Coordina el reporte RF-15 sin reglas gráficas ni SQL.</summary>
public sealed class AsistenciaConsolidadaPresenter
{
    public AsistenciaConsolidadaPresenter(IAsistenciaConsolidadaView vista,ConsolidarAsistencia consulta)
    {
        if(vista==null)throw new ArgumentNullException(nameof(vista));
        if(consulta==null)throw new ArgumentNullException(nameof(consulta));
        vista.ConsultarSolicitado+=(_,_)=>
        {
            vista.Mostrar(null);
            try{vista.Mostrar(consulta.Ejecutar(vista.Empleado,vista.Desde,vista.Hasta));}
            catch(ReglaNegocioException ex){vista.MostrarError(ex.Message);}
            catch(Exception){vista.MostrarError("No se pudo consolidar la asistencia. Revise conexión y esquema.");}
        };
    }
}
