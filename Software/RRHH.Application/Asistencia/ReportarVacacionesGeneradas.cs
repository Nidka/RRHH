using System;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>Consulta la fecha de ingreso del empleado para el cálculo académico de vacaciones.</summary>
public interface IIngresoVacacionesRepository
{
    /// <summary>Devuelve el ingreso o lanza una regla de negocio si falta o es ambiguo.</summary>
    DateTime ObtenerIngreso(int empleado);
}

/// <summary>Resultado reproducible de RF-07, sin consumos ni truncas.</summary>
public sealed class VacacionesGeneradasDto
{
    public int Empleado { get; set; }
    public DateTime Ingreso { get; set; }
    public DateTime Corte { get; set; }
    public int AniosCumplidos { get; set; }
    public decimal DiasAnuales { get; set; }
    public decimal Generadas { get; set; }
}

/// <summary>RF-07 del piloto. Calcula días generados por aniversarios completos desde la fecha de ingreso.</summary>
public sealed class ReportarVacacionesGeneradas
{
    private readonly IIngresoVacacionesRepository _ingresos;
    private readonly RegimenVacacionesPiloto _regimen;

    /// <summary>Compone la fuente de ingreso y el régimen académico parametrizado.</summary>
    public ReportarVacacionesGeneradas(IIngresoVacacionesRepository ingresos, RegimenVacacionesPiloto regimen)
    {
        _ingresos = ingresos ?? throw new ArgumentNullException(nameof(ingresos));
        _regimen = regimen ?? throw new ArgumentNullException(nameof(regimen));
    }

    /// <summary>Consulta sin modificar permisos ni saldo.</summary>
    /// <exception cref="ReglaNegocioException">Empleado inválido, fecha incoherente o ingreso no acreditado.</exception>
    public VacacionesGeneradasDto Ejecutar(int empleado, DateTime corte)
    {
        if (empleado <= 0) throw new ReglaNegocioException("Seleccione un empleado válido.");
        var ingreso = _ingresos.ObtenerIngreso(empleado).Date;
        int anios = _regimen.AniosCumplidos(ingreso, corte);
        return new VacacionesGeneradasDto
        {
            Empleado = empleado, Ingreso = ingreso, Corte = corte.Date,
            AniosCumplidos = anios, DiasAnuales = _regimen.DiasAnuales, Generadas = anios * _regimen.DiasAnuales
        };
    }
}
