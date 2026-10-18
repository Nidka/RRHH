using System;
using RRHH.Application.Comun;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>Elimina un horario seleccionado mediante la comprobación atómica de referencias del repositorio.</summary>
public sealed class EliminarHorario
{
    private readonly IHorarioRepository _repository;
    public EliminarHorario(IHorarioRepository repository) => _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    /// <summary>Traduce referencias/ambigüedad a mensajes; no elimina ante código inválido.</summary>
    public ResultadoOperacion Ejecutar(int id)
    {
        if (id <= 0) return ResultadoOperacion.Error("Seleccione un horario para eliminar.");
        try
        {
            return _repository.Eliminar(id) ? ResultadoOperacion.Ok() :
                ResultadoOperacion.Error("El horario ya no existe. Actualice el listado.");
        }
        catch (RegistroEnUsoException ex) { return ResultadoOperacion.Error(ex.Message); }
        catch (ReglaNegocioException ex) { return ResultadoOperacion.Error(ex.Message); }
    }
}
