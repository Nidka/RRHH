using System;
using RRHH.Application.Comun;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>Coordina alta/edición mediante el contrato de persistencia y las reglas de Horario.</summary>
public sealed class GuardarHorario
{
    private readonly IHorarioRepository _repository;
    public GuardarHorario(IHorarioRepository repository) => _repository = repository ?? throw new ArgumentNullException(nameof(repository));

    /// <summary>Guarda campos editables y devuelve validaciones como resultado; no altera SgtDia.</summary>
    /// <param name="dto">ID cero para alta. Recibe el identificador solo si la inserción se completó.</param>
    /// <returns>Error de dominio/conflicto o éxito. Errores de infraestructura se propagan al presenter.</returns>
    public ResultadoOperacion Ejecutar(HorarioDto dto)
    {
        if (dto == null) throw new ArgumentNullException(nameof(dto));
        try
        {
            Horario horario = Horario.Crear(dto.Id, dto.Descripcion, dto.Ingreso1, dto.Salida1,
                dto.Ingreso2, dto.Salida2, dto.Estado);
            if (horario.Id == 0) dto.Id = _repository.Insertar(horario);
            else if (!_repository.Actualizar(horario))
                return ResultadoOperacion.Error("El horario ya no existe. Actualice el listado.");
            return ResultadoOperacion.Ok();
        }
        catch (ReglaNegocioException ex) { return ResultadoOperacion.Error(ex.Message); }
    }
}
