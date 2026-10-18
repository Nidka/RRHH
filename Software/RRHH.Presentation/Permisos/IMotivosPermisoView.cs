using System;
using System.Collections.Generic;
using RRHH.Application.Catalogos;
using RRHH.Application.Permisos;

namespace RRHH.Presentation.Permisos;

/// <summary>Contrato de vista pasiva para consulta, selección y navegación del mantenimiento de motivos.</summary>
public interface IMotivosPermisoView
{
    /// <summary>ID del tipo seleccionado; cero representa ausencia de selección válida.</summary>
    int TipoPermisoSeleccionado { get; }
    /// <summary>ID de la fila seleccionada, o null si no hay una fila de datos.</summary>
    int? MotivoSeleccionado { get; }
    event EventHandler CargarSolicitado;
    event EventHandler TipoCambiado;
    event EventHandler AgregarSolicitado;
    event EventHandler EditarSolicitado;
    event EventHandler EliminarSolicitado;
    void MostrarTipos(IList<ItemCatalogoDto> tipos);
    void MostrarMotivos(IReadOnlyList<MotivoPermisoDto> motivos);
    void HabilitarAcciones(bool habilitadas);
    void MostrarError(string mensaje);
    void MostrarInformacion(string mensaje);
    bool ConfirmarEliminacion();
    /// <summary>Abre el editor mediante la navegación suministrada por composición.</summary>
    /// <param name="tipoPermisoId">Tipo seleccionado al iniciar la operación.</param>
    /// <param name="motivoId">Null para alta; identificador existente para edición.</param>
    /// <returns>True únicamente si se guardó; false al cancelar.</returns>
    bool AbrirEditor(int tipoPermisoId, int? motivoId);
}
