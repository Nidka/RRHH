using System;
using System.Collections.Generic;

namespace RRHH.Application.Asistencia;

/// <summary>Obtiene los horarios sin escrituras ni filtrado implícito de estados históricos.</summary>
public sealed class ListarHorarios
{
    private readonly IHorarioRepository _repository;
    public ListarHorarios(IHorarioRepository repository) => _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    public IReadOnlyList<HorarioDto> Ejecutar() => _repository.Listar();
}
