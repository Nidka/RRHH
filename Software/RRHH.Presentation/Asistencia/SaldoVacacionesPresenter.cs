using System;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Presentation.Asistencia;

/// <summary>Vista pasiva del saldo y consumos aprobados del empleado.</summary>
public interface ISaldoVacacionesView
{
    int Empleado { get; }
    DateTime Corte { get; }
    event EventHandler ConsultarSolicitado;
    void Mostrar(SaldoVacacionesDto resultado);
    void MostrarError(string mensaje);
}

/// <summary>Coordina consulta y limpieza de resultados de RF-08 sin depender de WinForms.</summary>
public sealed class SaldoVacacionesPresenter
{
    public SaldoVacacionesPresenter(ISaldoVacacionesView vista, ConsultarSaldoVacaciones consulta)
    {
        if (vista==null) throw new ArgumentNullException(nameof(vista));
        if (consulta==null) throw new ArgumentNullException(nameof(consulta));
        vista.ConsultarSolicitado+=(_,_) =>
        {
            vista.Mostrar(null);
            try { vista.Mostrar(consulta.Ejecutar(vista.Empleado,vista.Corte)); }
            catch (ReglaNegocioException ex) { vista.MostrarError(ex.Message); }
            catch (Exception) { vista.MostrarError("No se pudo consultar el saldo. Revise conexión, configuración y esquema."); }
        };
    }
}
