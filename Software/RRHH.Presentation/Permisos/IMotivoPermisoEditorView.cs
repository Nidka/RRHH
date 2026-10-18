using System;
using RRHH.Application.Permisos;

namespace RRHH.Presentation.Permisos;

/// <summary>Vista pasiva del editor: expone entradas y eventos; la consulta y el guardado corresponden al presenter.</summary>
public interface IMotivoPermisoEditorView
{
    /// <summary>Cero al crear; identificador existente al editar.</summary>
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
    /// <summary>Cierra señalando guardado exitoso, para que el listado se recargue.</summary>
    void CerrarGuardado();
}
