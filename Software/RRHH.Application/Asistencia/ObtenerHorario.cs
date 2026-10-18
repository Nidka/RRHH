using System;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>Carga solo lectura del horario que se editará.</summary>
public sealed class ObtenerHorario
{
    private readonly IHorarioRepository _repository;
    public ObtenerHorario(IHorarioRepository repository) => _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    /// <exception cref="ReglaNegocioException">El código es inválido o el horario no existe.</exception>
    public HorarioDto Ejecutar(int id)
    {
        if (id <= 0) throw new ReglaNegocioException("Seleccione un horario válido.");
        return _repository.Obtener(id) ?? throw new ReglaNegocioException("El horario ya no existe. Actualice el listado.");
    }
}
