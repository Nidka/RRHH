using System;
using RRHH.Application.Asistencia;

namespace RRHH.Presentation.Asistencia;

/// <summary>Carga identificación/catálogo y coordina el guardado explícito del periodo.</summary>
public sealed class AsignacionHorarioPresenter
{
    private readonly IAsignacionHorarioView _vista;
    private readonly ObtenerDatosAsignacion _datos;
    private readonly ListarHorarios _horarios;
    private readonly AsignarHorarioPorPeriodo _asignar;
    private bool _cargado;
    public AsignacionHorarioPresenter(IAsignacionHorarioView vista, ObtenerDatosAsignacion datos,
        ListarHorarios horarios, AsignarHorarioPorPeriodo asignar)
    {
        _vista=vista ?? throw new ArgumentNullException(nameof(vista));
        _datos=datos ?? throw new ArgumentNullException(nameof(datos));
        _horarios=horarios ?? throw new ArgumentNullException(nameof(horarios));
        _asignar=asignar ?? throw new ArgumentNullException(nameof(asignar));
        vista.CargarSolicitado+=(_,_)=>Cargar();
        vista.GuardarSolicitado+=(_,_)=>Guardar();
    }
    private void Cargar()
    {
        _cargado=false;_vista.HabilitarGuardar(false);
        try
        {
            _vista.MostrarEmpleado(_datos.Empleado(_vista.IdEmpleado));
            _vista.MostrarHorarios(_horarios.Ejecutar());
            if(_vista.Numero!=0) _vista.MostrarAsignacion(_datos.Asignacion(_vista.IdEmpleado,_vista.Numero));
            _cargado=true;_vista.HabilitarGuardar(true);
        }
        catch(Exception ex) { _vista.MostrarError("No se pudo cargar la asignación: "+ex.Message); }
    }
    private void Guardar()
    {
        if(!_cargado) return;
        _vista.HabilitarGuardar(false);
        try
        {
            var resultado=_asignar.Ejecutar(new AsignacionHorarioDto { IdEmpleado=_vista.IdEmpleado,
                Numero=_vista.Numero,IdHorario=_vista.IdHorario,Desde=_vista.Desde,Hasta=_vista.Hasta,
                Documento=_vista.Documento,Sisgedo=_vista.Sisgedo });
            if(resultado.Exitoso) { _cargado=false;_vista.CerrarGuardado(); }
            else _vista.MostrarError(resultado.Mensaje);
        }
        catch(Exception ex) { _vista.MostrarError("No se pudo guardar la asignación: "+ex.Message); }
        finally { if(_cargado) _vista.HabilitarGuardar(true); }
    }
}
