using System;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>Carga solo datos de lectura del editor; no asigna IDs ni actualiza filas.</summary>
public sealed class ObtenerDatosAsignacion
{
    private readonly IHorarioTemporalRepository _repository;
    public ObtenerDatosAsignacion(IHorarioTemporalRepository repository) =>
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));

    /// <summary>Devuelve identificación de un empleado existente y único.</summary>
    public EmpleadoHorarioDto Empleado(int empleado) => _repository.ObtenerEmpleado(empleado) ??
        throw new ReglaNegocioException("El empleado no existe o no tiene persona asociada.");

    /// <summary>Devuelve una asignación existente para edición; cero es alta y no requiere esta lectura.</summary>
    public AsignacionHorarioDto Asignacion(int empleado, int numero) => _repository.Obtener(empleado, numero) ??
        throw new ReglaNegocioException("La asignación ya no existe. Actualice el listado.");
}
