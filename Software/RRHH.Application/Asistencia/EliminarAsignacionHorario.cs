using System;
using RRHH.Application.Comun;
using RRHH.Domain.Comun;
namespace RRHH.Application.Asistencia;

/// <summary>Baja explícita de una asignación, independiente de crear/reasignar periodos.</summary>
public sealed class EliminarAsignacionHorario
{
    private readonly IHorarioTemporalRepository _repository;
    public EliminarAsignacionHorario(IHorarioTemporalRepository repository) =>
        _repository=repository ?? throw new ArgumentNullException(nameof(repository));
    /// <summary>Elimina únicamente la clave seleccionada; el presenter requiere confirmación previa.</summary>
    public ResultadoOperacion Ejecutar(int empleado,int numero)
    {
        if(empleado<=0 || numero<=0) return ResultadoOperacion.Error("Seleccione una asignación válida.");
        try { return _repository.Eliminar(empleado,numero) ? ResultadoOperacion.Ok() :
            ResultadoOperacion.Error("La asignación ya no existe. Actualice el listado."); }
        catch(ReglaNegocioException ex) { return ResultadoOperacion.Error(ex.Message); }
    }
}
