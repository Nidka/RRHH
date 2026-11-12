using System;
using RRHH.Application.Teletrabajo;
using RRHH.Domain.Comun;

namespace RRHH.Presentation.Teletrabajo;

/// <summary>Coordina las acciones de registro y consulta de la vista pasiva.</summary>
public sealed class TeletrabajoPresenter
{
    private readonly ITeletrabajoView _vista;
    private readonly RegistrarPeriodoTeletrabajo _registrar;
    private readonly ListarPeriodosTeletrabajo _listar;

    /// <summary>Conecta eventos y casos de uso por la vida de la vista.</summary>
    public TeletrabajoPresenter(ITeletrabajoView vista, RegistrarPeriodoTeletrabajo registrar,
        ListarPeriodosTeletrabajo listar)
    {
        _vista = vista;
        _registrar = registrar;
        _listar = listar;
        vista.RegistrarSolicitado += Registrar;
        vista.ListarSolicitado += Listar;
    }

    private void Registrar(object sender, EventArgs e)
    {
        int id;
        try
        {
            id = _registrar.Ejecutar(_vista.IdEmpleado, _vista.Desde, _vista.Hasta,
                _vista.Modalidad, _vista.DiasRemotos, _vista.Autorizacion);
        }
        catch (ReglaNegocioException ex) { _vista.MostrarError(ex.Message); return; }
        catch (Exception) { _vista.MostrarError("No se pudo confirmar el registro. Consulte los periodos antes de reintentar."); return; }

        _vista.MostrarRegistro(id);
        Listar(sender, e);
    }

    private void Listar(object sender, EventArgs e)
    {
        try { _vista.MostrarPeriodos(_listar.Ejecutar(_vista.IdEmpleado)); }
        catch (ReglaNegocioException ex) { _vista.MostrarError(ex.Message); }
        catch (Exception) { _vista.MostrarError("No se pudieron consultar los periodos. Compruebe la conexión y el esquema."); }
    }
}
