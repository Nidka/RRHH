using System.Collections.Generic;
using RRHH.Domain.Asistencia;

namespace RRHH.Application.Asistencia;

/// <summary>Persistencia específica del mantenimiento de horarios, sin exponer proveedor ni tipos de datos UI.</summary>
public interface IHorarioRepository
{
    IReadOnlyList<HorarioDto> Listar();
    /// <summary>Devuelve null si no existe; rechaza un código ambiguo por duplicados.</summary>
    HorarioDto Obtener(int id);
    /// <summary>Inserta y devuelve el identificador persistido; no modifica el esquema.</summary>
    int Insertar(Horario horario);
    /// <summary>Actualiza solo campos editables, conservando SgtDia. False si el registro ya no existe.</summary>
    bool Actualizar(Horario horario);
    /// <summary>Elimina si no tiene referencias; lanza RegistroEnUsoException si está utilizado.</summary>
    /// <returns>False si el registro ya no existe.</returns>
    bool Eliminar(int id);
}
