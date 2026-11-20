using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>Fuentes distintas presentes en una fecha; no son totales ya sumados.</summary>
public sealed class FuentesAsistenciaDiaDto
{
    public DateTime Fecha { get; set; }
    public bool Laborable { get; set; }
    public bool Ausencia { get; set; }
    public bool Presencial { get; set; }
    public bool Remoto { get; set; }
}
/// <summary>Fuente de una fila por fecha dentro de la misma instantánea de lectura.</summary>
public interface IAsistenciaConsolidadaRepository
{
    IReadOnlyList<FuentesAsistenciaDiaDto> Consultar(int empleado,RangoFechas periodo);
}
/// <summary>Detalle con fuentes visibles y categoría única.</summary>
public sealed class DiaConsolidadoDto
{
    public DateTime Fecha { get; set; }
    public string Categoria { get; set; }
    public bool Laborable { get; set; }
    public bool Ausencia { get; set; }
    public bool Presencial { get; set; }
    public bool Remoto { get; set; }
    public bool Inconsistencia { get; set; }
}
/// <summary>Totales excluyentes; SinRegistro informa días sin evidencia y no suma asistencia.</summary>
public sealed class AsistenciaConsolidadaDto
{
    public int Empleado { get; set; }
    public int Laborables { get; set; }
    public int Ausencias { get; set; }
    public int Presenciales { get; set; }
    public int Remotos { get; set; }
    public int SinRegistro { get; set; }
    public int Inconsistencias { get; set; }
    public IReadOnlyList<DiaConsolidadoDto> Dias { get; set; }
}
/// <summary>RF-15: clasifica cada fecha una sola vez y conserva la evidencia de conflictos.</summary>
public sealed class ConsolidarAsistencia
{
    private readonly IAsistenciaConsolidadaRepository _repository;
    public ConsolidarAsistencia(IAsistenciaConsolidadaRepository repository)=>_repository=repository ?? throw new ArgumentNullException(nameof(repository));
    /// <summary>Consulta hasta 367 días; rechaza una fuente incompleta o duplicada.</summary>
    public AsistenciaConsolidadaDto Ejecutar(int empleado,DateTime desde,DateTime hasta)
    {
        var periodo=RangoFechas.Crear(desde,hasta);
        if(empleado<=0 || desde.Year<1900 || hasta.Year>9998 || (hasta.Date-desde.Date).Days>366)
            throw new ReglaNegocioException("Indique empleado y rango válidos de hasta 367 días.");
        var fuentes=_repository.Consultar(empleado,periodo);
        int esperadas=(hasta.Date-desde.Date).Days+1;
        if(fuentes.Count!=esperadas || fuentes.Select(f=>f.Fecha.Date).Distinct().Count()!=esperadas || fuentes.Any(f=>f.Fecha.Date<desde.Date || f.Fecha.Date>hasta.Date))
            throw new ReglaNegocioException("La fuente de asistencia está incompleta o duplica fechas.");
        var dias=fuentes.OrderBy(f=>f.Fecha).Select(f=>
        {
            var clasificacion=ClasificacionAsistenciaDia.Resolver(f.Laborable,f.Ausencia,f.Presencial,f.Remoto);
            return new DiaConsolidadoDto {Fecha=f.Fecha.Date,Categoria=clasificacion.Categoria,Laborable=f.Laborable,
                Ausencia=f.Ausencia,Presencial=f.Presencial,Remoto=f.Remoto,Inconsistencia=clasificacion.Inconsistencia};
        }).ToList();
        return new AsistenciaConsolidadaDto {Empleado=empleado,Laborables=dias.Count(d=>d.Laborable),
            Ausencias=dias.Count(d=>d.Categoria=="Ausencia"),Presenciales=dias.Count(d=>d.Categoria=="Presencial"),
            Remotos=dias.Count(d=>d.Categoria=="Remoto"),SinRegistro=dias.Count(d=>d.Categoria=="Sin registro"),
            Inconsistencias=dias.Count(d=>d.Inconsistencia),Dias=dias};
    }
}
