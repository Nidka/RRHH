using System;
using RRHH.Application.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Presentation.Asistencia;

/// <summary>Vista pasiva de la consulta académica de vacaciones generadas.</summary>
public interface IVacacionesGeneradasView
{
    int Empleado { get; }
    DateTime Corte { get; }
    event EventHandler ConsultarSolicitado;
    void Mostrar(VacacionesGeneradasDto resultado);
    void MostrarError(string mensaje);
}

/// <summary>Coordina la consulta RF-07 y limpia el resultado cuando falla.</summary>
public sealed class VacacionesGeneradasPresenter
{
    private readonly IVacacionesGeneradasView _vista;
    private readonly ReportarVacacionesGeneradas _consulta;

    /// <summary>Conecta la vista con el caso de uso compartido por las plataformas.</summary>
    public VacacionesGeneradasPresenter(IVacacionesGeneradasView vista, ReportarVacacionesGeneradas consulta)
    {
        _vista = vista ?? throw new ArgumentNullException(nameof(vista));
        _consulta = consulta ?? throw new ArgumentNullException(nameof(consulta));
        _vista.ConsultarSolicitado += (_, _) => Consultar();
    }

    private void Consultar()
    {
        _vista.Mostrar(null);
        try { _vista.Mostrar(_consulta.Ejecutar(_vista.Empleado, _vista.Corte)); }
        catch (ReglaNegocioException ex) { _vista.MostrarError(ex.Message); }
        catch (Exception) { _vista.MostrarError("No se pudo consultar el ingreso. Revise la conexión y el esquema."); }
    }
}
