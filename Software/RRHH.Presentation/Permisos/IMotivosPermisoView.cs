using System;
using System.Collections.Generic;
using RRHH.Application.Catalogos;
using RRHH.Application.Permisos;

namespace RRHH.Presentation.Permisos;

public interface IMotivosPermisoView
{
    int TipoPermisoSeleccionado { get; }
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
    bool AbrirEditor(int tipoPermisoId, int? motivoId);
}
