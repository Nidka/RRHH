using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Domain.Comun;
namespace RRHH.Application.Asistencia;

/// <summary>Consulta periodos de un empleado, por intersección inclusiva o sin filtro temporal.</summary>
public sealed class ConsultarHistoricoHorarios
{
    private readonly IHorarioTemporalRepository _repository;
    public ConsultarHistoricoHorarios(IHorarioTemporalRepository repository) =>
        _repository=repository ?? throw new ArgumentNullException(nameof(repository));

    /// <summary>Devuelve histórico descendente por inicio y número; consultar no escribe.</summary>
    /// <param name="empleado">Código positivo del empleado consultado.</param>
    /// <param name="desde">Nulo junto con hasta para todos los periodos.</param>
    /// <param name="hasta">Último día incluido; obligatorio si desde tiene valor.</param>
    /// <exception cref="ReglaNegocioException">Empleado/rango inválido o solo un extremo informado.</exception>
    public IReadOnlyList<HistoricoHorarioDto> Ejecutar(int empleado, DateTime? desde, DateTime? hasta)
    {
        if(empleado<=0) throw new ReglaNegocioException("Seleccione un empleado válido.");
        if(desde.HasValue!=hasta.HasValue) throw new ReglaNegocioException("Indique las dos fechas o consulte todos los periodos.");
        RangoFechas rango=desde.HasValue ? RangoFechas.Crear(desde.Value,hasta.Value) : null;
        return _repository.Listar(empleado,rango).Where(f=>f.IdEmpleado==empleado &&
            (rango==null || (f.FechaInicio.HasValue && f.FechaFin.HasValue &&
            f.FechaInicio.Value.Date<=f.FechaFin.Value.Date && f.FechaInicio.Value.Date<=rango.Hasta && f.FechaFin.Value.Date>=rango.Desde)))
            .OrderByDescending(f=>f.FechaInicio).ThenByDescending(f=>f.N).ToList();
    }
}
