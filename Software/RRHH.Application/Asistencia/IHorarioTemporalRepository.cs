using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using System.Collections.Generic;

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
    /// <summary>Lista sin escrituras; rango nulo incluye fechas ausentes, otro rango filtra por intersección.</summary>
    IReadOnlyList<HistoricoHorarioDto> Listar(int empleado, RangoFechas rango);
    /// <summary>Baja explícita por clave única; false si ya no existe, error si es ambigua.</summary>
    bool Eliminar(int empleado, int numero);
}
