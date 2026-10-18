using System.Collections.Generic;
using RRHH.Domain.Permisos;

namespace RRHH.Application.Permisos;

public interface IMotivoPermisoRepository
{
    IReadOnlyList<MotivoPermisoDto> Listar(int tipoPermisoId, string modalidad);
    MotivoPermiso Obtener(int id);
    int Insertar(MotivoPermiso motivo);
    bool Actualizar(MotivoPermiso motivo);
    /// <summary>False si no existe o cambió su modalidad. Impide borrar referencias activas o históricas.</summary>
    /// <exception cref="Comun.RegistroEnUsoException">Motivo referenciado por permisos o auditoría.</exception>
    bool Eliminar(int id, string modalidad);
}
