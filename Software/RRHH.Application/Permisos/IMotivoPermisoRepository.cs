using System.Collections.Generic;
using RRHH.Domain.Permisos;

namespace RRHH.Application.Permisos;

/// <summary>Contrato de persistencia del catálogo de motivos, sin dependencias de UI ni proveedor SQL.</summary>
public interface IMotivoPermisoRepository
{
    /// <summary>Consulta motivos por tipo, incluidos los inactivos.</summary>
    /// <param name="tipoPermisoId">Tipo del catálogo que se desea consultar.</param>
    /// <param name="modalidad">P o C para filtrar; null consulta todas las modalidades.</param>
    /// <returns>Lista vacía si no hay coincidencias.</returns>
    IReadOnlyList<MotivoPermisoDto> Listar(int tipoPermisoId, string modalidad);
    /// <summary>Recupera un motivo por su identificador sin modificarlo.</summary>
    /// <returns>El motivo, o null si no existe.</returns>
    /// <exception cref="RRHH.Domain.Comun.ReglaNegocioException">El ID identifica más de una fila.</exception>
    MotivoPermiso Obtener(int id);
    /// <summary>Persiste un motivo nuevo y devuelve su identificador asignado.</summary>
    /// <returns>ID del registro insertado.</returns>
    /// <exception cref="RRHH.Domain.Comun.ReglaNegocioException">Tipo inexistente/ambiguo o ID generado duplicado.</exception>
    int Insertar(MotivoPermiso motivo);
    /// <summary>Actualiza descripción, abreviatura y salario, conservando tipo, modalidad y estado.</summary>
    /// <returns>True si se actualizó una fila; false si desapareció o cambiaron tipo/modalidad.</returns>
    /// <exception cref="RRHH.Domain.Comun.ReglaNegocioException">El ID identifica más de una fila.</exception>
    bool Actualizar(MotivoPermiso motivo);
    /// <summary>Elimina un motivo sin referencias en permisos ni auditoría, dentro del alcance indicado.</summary>
    /// <param name="id">Identificador del motivo seleccionado.</param>
    /// <param name="modalidad">Modalidad autorizada; null permite cualquier modalidad.</param>
    /// <returns>False si no existe o queda fuera de la modalidad indicada.</returns>
    /// <exception cref="Comun.RegistroEnUsoException">Motivo referenciado por permisos o auditoría.</exception>
    bool Eliminar(int id, string modalidad);
}
