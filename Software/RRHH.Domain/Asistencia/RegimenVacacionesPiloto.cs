using System;
using RRHH.Domain.Comun;

namespace RRHH.Domain.Asistencia;

/// <summary>Regla académica de días calendario por año completo desde el ingreso.</summary>
public sealed class RegimenVacacionesPiloto
{
    /// <summary>Cantidad positiva de días que genera cada aniversario cumplido.</summary>
    public decimal DiasAnuales { get; }

    /// <summary>Configura el régimen único del piloto, con 30 días anuales por defecto.</summary>
    /// <exception cref="ReglaNegocioException">Cantidad anual no positiva o superior a 366.</exception>
    public RegimenVacacionesPiloto(decimal diasAnuales = 30m)
    {
        if (diasAnuales <= 0 || diasAnuales > 366)
            throw new ReglaNegocioException("Los días anuales deben ser mayores que cero y como máximo 366.");
        DiasAnuales = diasAnuales;
    }

    /// <summary>Cuenta aniversarios completos. El 29 de febrero se ajusta al 28 en años no bisiestos.</summary>
    /// <exception cref="ReglaNegocioException">El corte es anterior al ingreso.</exception>
    public int AniosCumplidos(DateTime ingreso, DateTime corte)
    {
        if (corte.Date < ingreso.Date)
            throw new ReglaNegocioException("La fecha de corte no puede ser anterior al ingreso.");
        int anios = corte.Year - ingreso.Year;
        return ingreso.Date.AddYears(anios) > corte.Date ? anios - 1 : anios;
    }

    /// <summary>Consumo calendario inclusivo; media jornada requiere una única fecha laborable.</summary>
    /// <param name="desde">Fecha inicial, sin hora.</param>
    /// <param name="hasta">Fecha final inclusiva.</param>
    /// <param name="mediaJornada">Solicita un consumo de 0,5 días.</param>
    /// <param name="esLaborable">Resultado del calendario del piloto para la fecha inicial.</param>
    /// <exception cref="ReglaNegocioException">Rango inválido o media jornada fuera de un día laborable.</exception>
    public decimal Consumo(DateTime desde,DateTime hasta,bool mediaJornada,bool esLaborable)
    {
        RangoFechas.Crear(desde,hasta);
        if (mediaJornada && (desde.Date!=hasta.Date || !esLaborable))
            throw new ReglaNegocioException("La media jornada requiere una única fecha laborable.");
        return mediaJornada ? 0.5m : (hasta.Date-desde.Date).Days+1m;
    }

    /// <summary>Trunca académica del periodo en curso: meses completos y días 30/360, incluido el cese.</summary>
    /// <remarks>Usa AddMonths para meses completos y redondea a dos decimales alejándose de cero.</remarks>
    public decimal Truncas(DateTime ingreso,DateTime cese)
    {
        int anios=AniosCumplidos(ingreso,cese);
        if (cese.Year>9998) throw new ReglaNegocioException("Fecha de cese fuera del rango del piloto.");
        DateTime aniversario=ingreso.Date.AddYears(anios), fin=cese.Date.AddDays(1);
        int meses=0;
        while (meses<12 && aniversario.AddMonths(meses+1)<=fin) meses++;
        int dias=(fin-aniversario.AddMonths(meses)).Days;
        return Math.Round(meses*DiasAnuales/12m+Math.Min(dias,30)*DiasAnuales/360m,2,MidpointRounding.AwayFromZero);
    }
}
