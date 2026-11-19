using System;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Presentation.Asistencia;

/// <summary>Vista propia de solo lectura; no ofrece un selector de empleado.</summary>
public interface IMisVacacionesView
{
    DateTime Corte { get; }
    event EventHandler ConsultarSolicitado;
    void Mostrar(SaldoVacacionesDto saldo);
    void MostrarError(string mensaje);
}
/// <summary>Conserva la identidad proporcionada por el login, fuera de los controles editables.</summary>
public sealed class MisVacacionesPresenter
{
    public MisVacacionesPresenter(IMisVacacionesView vista,ConsultarMisVacaciones consulta,int idUsuario)
    {
        if(vista==null) throw new ArgumentNullException(nameof(vista));
        if(consulta==null) throw new ArgumentNullException(nameof(consulta));
        vista.ConsultarSolicitado+=(_,_)=>
        {
            vista.Mostrar(null);
            try{vista.Mostrar(consulta.Ejecutar(idUsuario,vista.Corte));}
            catch(ReglaNegocioException ex){vista.MostrarError(ex.Message);}
            catch(Exception){vista.MostrarError("No se pudo consultar su saldo. Revise la conexión.");}
        };
    }
}
