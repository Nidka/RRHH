using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>Consumo aprobado completo que se reconoce desde la fecha inicial del permiso.</summary>
public sealed class ConsumoVacacionesDto
{
    public int Numero { get; set; }
    public DateTime Desde { get; set; }
    public DateTime Hasta { get; set; }
    public decimal Dias { get; set; }
}

/// <summary>Ingreso acreditado y consumos aprobados obtenidos en una consulta consistente.</summary>
public sealed class FichaSaldoVacacionesDto
{
    public DateTime Ingreso { get; set; }
    public IReadOnlyList<ConsumoVacacionesDto> Consumos { get; set; }
}

/// <summary>Fuente de ingreso y consumos del régimen académico explícitamente configurado.</summary>
public interface IVacacionesSaldoRepository
{
    /// <summary>Consulta consumos aprobados cuyo inicio no supera el corte; rechaza datos ambiguos.</summary>
    FichaSaldoVacacionesDto Obtener(int empleado, DateTime corte);
}

/// <summary>Saldo reproducible sin contadores auxiliares; las anulaciones dejan de formar parte del consumo.</summary>
public sealed class SaldoVacacionesDto
{
    public int Empleado { get; set; }
    public DateTime Ingreso { get; set; }
    public DateTime Corte { get; set; }
    public decimal Generadas { get; set; }
    public decimal Usadas { get; set; }
    public decimal Pendientes { get; set; }
    public IReadOnlyList<ConsumoVacacionesDto> Consumos { get; set; }
}

/// <summary>RF-08: calcula saldo acumulado de vacaciones con el régimen compartido de RF-07.</summary>
public sealed class ConsultarSaldoVacaciones
{
    private readonly IVacacionesSaldoRepository _repository;
    private readonly RegimenVacacionesPiloto _regimen;
    public ConsultarSaldoVacaciones(IVacacionesSaldoRepository repository, RegimenVacacionesPiloto regimen)
    {
        _repository=repository ?? throw new ArgumentNullException(nameof(repository));
        _regimen=regimen ?? throw new ArgumentNullException(nameof(regimen));
    }

    /// <summary>Consulta generadas menos usadas; un saldo histórico negativo se conserva para revisión.</summary>
    /// <exception cref="ReglaNegocioException">Empleado, corte o datos de origen inválidos.</exception>
    public SaldoVacacionesDto Ejecutar(int empleado, DateTime corte)
    {
        if (empleado <= 0 || corte.Year < 1900 || corte.Year > 9998)
            throw new ReglaNegocioException("Indique empleado y fecha de corte válidos.");
        var ficha=_repository.Obtener(empleado,corte.Date);
        decimal generadas=_regimen.AniosCumplidos(ficha.Ingreso,corte)*_regimen.DiasAnuales;
        decimal usadas=ficha.Consumos.Sum(c => c.Dias);
        return new SaldoVacacionesDto { Empleado=empleado, Ingreso=ficha.Ingreso, Corte=corte.Date,
            Generadas=generadas, Usadas=usadas, Pendientes=generadas-usadas, Consumos=ficha.Consumos };
    }
}
