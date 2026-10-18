using System;
using RRHH.Application.Permisos;

namespace RRHH.Presentation.Permisos;

public interface IMotivoPermisoEditorView
{
    int IdMotivo { get; }
    int IdTipoPermiso { get; }
    string Descripcion { get; }
    string Abreviatura { get; }
    bool? Salario { get; }
    event EventHandler CargarSolicitado;
    event EventHandler GuardarSolicitado;
    void MostrarMotivo(MotivoPermisoDto motivo);
    void MostrarError(string mensaje);
    void HabilitarGuardar(bool habilitado);
    void CerrarGuardado();
}
