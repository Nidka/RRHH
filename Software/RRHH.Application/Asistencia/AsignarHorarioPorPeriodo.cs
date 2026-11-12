using System;
using RRHH.Application.Comun;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>Reemplaza la validación y guardado heredados de FrmHorarioEsp sin cambiar horario principal.</summary>
public sealed class AsignarHorarioPorPeriodo
{
    private readonly IHorarioTemporalRepository _repository;
    public AsignarHorarioPorPeriodo(IHorarioTemporalRepository repository) =>
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));

    /// <summary>Valida fechas/datos; asigna Numero al DTO únicamente tras confirmar la escritura.</summary>
    /// <returns>Error de regla o éxito; los errores de infraestructura se propagan al presenter.</returns>
    public ResultadoOperacion Ejecutar(AsignacionHorarioDto dto)
    {
        if (dto == null) throw new ArgumentNullException(nameof(dto));
        try
        {
            var asignacion = new AsignacionHorario(dto.IdEmpleado, dto.Numero,
                RangoFechas.Crear(dto.Desde, dto.Hasta), dto.IdHorario, dto.Documento, dto.Sisgedo);
            dto.Numero = _repository.Guardar(asignacion);
            return ResultadoOperacion.Ok();
        }
        catch (ReglaNegocioException ex) { return ResultadoOperacion.Error(ex.Message); }
    }
}
