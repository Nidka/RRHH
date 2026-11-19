using System;
using RRHH.Application.Permisos;
using RRHH.Domain.Comun;

namespace RRHH.Presentation.Permisos;

/// <summary>Contrato de vista pasiva del editor académico de permisos y estados.</summary>
public interface IPermisoEditorView
{
    int EmpleadoConsulta { get; }
    int NumeroConsulta { get; }
    PermisoGuardarDto Entrada { get; }
    event EventHandler CargarSolicitado;
    event EventHandler GuardarSolicitado;
    void Mostrar(PermisoGuardarDto permiso);
    void MostrarMensaje(string mensaje,bool error);
}

/// <summary>Coordina carga/guardado tipados; no accede a controles ni al proveedor SQL.</summary>
public sealed class PermisoEditorPresenter
{
    public PermisoEditorPresenter(IPermisoEditorView vista,ConsultarPermiso consulta,GuardarPermiso guardar)
    {
        if (vista==null) throw new ArgumentNullException(nameof(vista));
        if (consulta==null) throw new ArgumentNullException(nameof(consulta));
        if (guardar==null) throw new ArgumentNullException(nameof(guardar));
        vista.CargarSolicitado+=(_,_) => Ejecutar(() =>
        {
            vista.Mostrar(null);
            var permiso=consulta.Ejecutar(vista.EmpleadoConsulta,vista.NumeroConsulta);
            vista.Mostrar(permiso);
            vista.MostrarMensaje("Permiso cargado.",false);
        });
        vista.GuardarSolicitado+=(_,_) => Ejecutar(() =>
        {
            var dto=vista.Entrada;
            var resultado=guardar.Ejecutar(dto);
            if (resultado.Exitoso) vista.Mostrar(dto);
            vista.MostrarMensaje(resultado.Exitoso ? "Permiso guardado: "+dto.Numero : resultado.Mensaje,!resultado.Exitoso);
        });
        void Ejecutar(Action accion)
        {
            try { accion(); }
            catch (ReglaNegocioException ex) { vista.MostrarMensaje(ex.Message,true); }
            catch (Exception) { vista.MostrarMensaje("No se pudo completar la operación. Revise conexión y esquema.",true); }
        }
    }
}
