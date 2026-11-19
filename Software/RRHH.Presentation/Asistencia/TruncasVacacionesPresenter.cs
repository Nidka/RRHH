using System;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Presentation.Asistencia;

/// <summary>Vista pasiva de la simulación RF-09.</summary>
public interface ITruncasVacacionesView
{
    int Empleado { get; }
    DateTime Cese { get; }
    event EventHandler TruncasSolicitadas;
    void MostrarTruncas(VacacionesTruncasDto resultado);
    void MostrarError(string mensaje);
}

/// <summary>Conecta la fecha efectiva indicada con el cálculo de truncas.</summary>
public sealed class TruncasVacacionesPresenter
{
    public TruncasVacacionesPresenter(ITruncasVacacionesView vista,ConsultarVacacionesTruncas consulta)
    {
        if (vista==null) throw new ArgumentNullException(nameof(vista));
        if (consulta==null) throw new ArgumentNullException(nameof(consulta));
        vista.TruncasSolicitadas+=(_,_) =>
        {
            vista.MostrarTruncas(null);
            try {vista.MostrarTruncas(consulta.Ejecutar(vista.Empleado,vista.Cese));}
            catch (ReglaNegocioException ex) {vista.MostrarError(ex.Message);}
            catch (Exception) {vista.MostrarError("No se pudieron calcular las truncas. Revise el ingreso y la conexión.");}
        };
    }
}
