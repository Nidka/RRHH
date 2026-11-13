using System;
using RRHH.Application.Asistencia;
namespace RRHH.Presentation.Asistencia;

/// <summary>Coordina lectura del histórico y acciones explícitas, sin persistencia desde la vista.</summary>
public sealed class HistoricoHorariosPresenter
{
    private readonly IHistoricoHorariosView _vista;
    private readonly ObtenerDatosAsignacion _datos;
    private readonly ConsultarHistoricoHorarios _consulta;
    private readonly EliminarAsignacionHorario _eliminar;
    private bool _consultado;
    public HistoricoHorariosPresenter(IHistoricoHorariosView vista,ObtenerDatosAsignacion datos,
        ConsultarHistoricoHorarios consulta,EliminarAsignacionHorario eliminar)
    {
        _vista=vista ?? throw new ArgumentNullException(nameof(vista));
        _datos=datos ?? throw new ArgumentNullException(nameof(datos));
        _consulta=consulta ?? throw new ArgumentNullException(nameof(consulta));
        _eliminar=eliminar ?? throw new ArgumentNullException(nameof(eliminar));
        vista.CargarSolicitado+=(_,_)=>Consultar();vista.ConsultarSolicitado+=(_,_)=>Consultar();
        vista.AgregarSolicitado+=(_,_)=>Editar(0);
        vista.EditarSolicitado+=(_,_)=> { if(SeleccionValida()) Editar(_vista.NumeroSeleccionado.Value); };
        vista.EliminarSolicitado+=(_,_)=>Eliminar();
    }
    private void Consultar()
    {
        _consultado=false;_vista.Habilitar(false);
        try
        {
            _vista.MostrarEmpleado(_datos.Empleado(_vista.IdEmpleado));
            _vista.MostrarFilas(_consulta.Ejecutar(_vista.IdEmpleado,_vista.Desde,_vista.Hasta));
            _consultado=true;
        }
        catch(Exception ex)
        {
            _vista.MostrarFilas(Array.Empty<HistoricoHorarioDto>());
            _vista.MostrarError("No se pudo consultar el histórico: "+ex.Message);
        }
        finally { _vista.Habilitar(true); }
    }
    private bool SeleccionValida()
    {
        if(!_consultado) return false;
        if(_vista.NumeroSeleccionado.HasValue && _vista.NumeroSeleccionado.Value>0) return true;
        _vista.MostrarError("Seleccione una asignación de horario.");return false;
    }
    private void Editar(int numero)
    {
        if(!_consultado) return;
        try { if(_vista.AbrirEditor(numero)) Consultar(); }
        catch(Exception ex) { _vista.MostrarError("No se pudo abrir el editor: "+ex.Message); }
    }
    private void Eliminar()
    {
        if(!SeleccionValida() || !_vista.ConfirmarEliminar()) return;
        try
        {
            var r=_eliminar.Ejecutar(_vista.IdEmpleado,_vista.NumeroSeleccionado.Value);
            if(!r.Exitoso) _vista.MostrarError(r.Mensaje);
            Consultar();
        }
        catch(Exception ex) { _vista.MostrarError("No se pudo eliminar la asignación: "+ex.Message); }
    }
}
