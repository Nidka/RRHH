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
}
