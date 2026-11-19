using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>Datos de un empleado del año solicitado o diagnóstico de integridad.</summary>
public sealed class FichaReporteVacacionesDto
{
    public int Empleado { get; set; }
    public int? Area { get; set; }
    public FichaSaldoVacacionesDto Ficha { get; set; }
    public string Error { get; set; }
}
/// <summary>Fuente consistente por año y filtros organizacionales.</summary>
public interface IVacacionesReporteRepository
{
    /// <summary>Devuelve datos de una instantánea de lectura; área/empleado null no filtran.</summary>
    IReadOnlyList<FichaReporteVacacionesDto> Obtener(int anio,DateTime corte,int? area,int? empleado);
}
/// <summary>Fila conciliada; cifras null identifican datos pendientes de corregir.</summary>
public sealed class ReporteVacacionesDto
{
    public int Empleado { get; set; }
    public int? Area { get; set; }
    public DateTime Corte { get; set; }
    public decimal? Generadas { get; set; }
    public decimal? Usadas { get; set; }
    public decimal? Pendientes { get; set; }
    public decimal? TruncasAlCorte { get; set; }
    public string Error { get; set; }
}
/// <summary>RF-11: consolida saldos acumulados con la misma fuente y régimen que la consulta individual.</summary>
public sealed class ReportarSaldoVacaciones
{
    private readonly IVacacionesReporteRepository _repository;
    private readonly RegimenVacacionesPiloto _regimen;
    public ReportarSaldoVacaciones(IVacacionesReporteRepository repository,RegimenVacacionesPiloto regimen)
    {
        _repository=repository ?? throw new ArgumentNullException(nameof(repository));
        _regimen=regimen ?? throw new ArgumentNullException(nameof(regimen));
    }
    /// <summary>Emite saldos al corte dentro del año indicado; no interpreta las truncas simuladas como liquidación.</summary>
    public IReadOnlyList<ReporteVacacionesDto> Ejecutar(int anio,DateTime corte,int? area=null,int? empleado=null)
    {
        if (anio<1900 || anio>9998 || corte.Year!=anio || area<=0 || empleado<=0)
            throw new ReglaNegocioException("Año, corte o filtros inválidos; el corte debe pertenecer al año elegido.");
        var resultado=new List<ReporteVacacionesDto>();
        foreach (var item in _repository.Obtener(anio,corte.Date,area,empleado))
        {
            var fila=new ReporteVacacionesDto {Empleado=item.Empleado,Area=item.Area,Corte=corte.Date,Error=item.Error};
            if (fila.Error==null)
            {
                try
                {
                    fila.Generadas=_regimen.AniosCumplidos(item.Ficha.Ingreso,corte)*_regimen.DiasAnuales;
                    fila.Usadas=item.Ficha.Consumos.Sum(c=>c.Dias);
                    fila.Pendientes=fila.Generadas-fila.Usadas;
                    fila.TruncasAlCorte=_regimen.Truncas(item.Ficha.Ingreso,corte);
                }
                catch (ReglaNegocioException ex) {fila.Error=ex.Message;fila.Generadas=fila.Usadas=fila.Pendientes=fila.TruncasAlCorte=null;}
            }
            resultado.Add(fila);
        }
        return resultado;
    }
}
