using RRHH.Domain.Asistencia;

namespace RRHH.Application.Asistencia;

/// <summary>Persistencia de periodos con clave compuesta, sin exponer proveedor a la aplicación.</summary>
public interface IHorarioTemporalRepository
{
    /// <summary>Obtiene una asignación única; null si no existe, error ante clave ambigua.</summary>
    AsignacionHorarioDto Obtener(int empleado, int numero);
    /// <summary>Obtiene la persona de un empleado único; null si no existe.</summary>
    EmpleadoHorarioDto ObtenerEmpleado(int empleado);
    /// <summary>Valida referencias/conflictos y guarda atómicamente; devuelve el número persistido.</summary>
    /// <remarks>Un alta agrega una fila. La edición conserva FechaRegistro y no cambia otras asignaciones.</remarks>
    /// <exception cref="RRHH.Domain.Comun.ReglaNegocioException">Conflicto, datos ambiguos o referencia inválida.</exception>
    int Guardar(AsignacionHorario asignacion);
}
