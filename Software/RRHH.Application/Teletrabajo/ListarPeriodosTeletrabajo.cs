using System.Collections.Generic;
using RRHH.Domain.Comun;

namespace RRHH.Application.Teletrabajo;

/// <summary>Consulta periodos activos de un empleado identificado por su código.</summary>
public sealed class ListarPeriodosTeletrabajo
{
    private readonly ITeletrabajoRepository _repository;

    public ListarPeriodosTeletrabajo(ITeletrabajoRepository repository) => _repository = repository;

    /// <summary>Obtiene los periodos del empleado. Una consulta sin coincidencias devuelve una lista vacía.</summary>
    public IReadOnlyList<PeriodoTeletrabajoDto> Ejecutar(int empleado)
    {
        if (empleado <= 0) throw new ReglaNegocioException("Indique un código de empleado positivo.");
        return _repository.Listar(empleado);
    }
}
