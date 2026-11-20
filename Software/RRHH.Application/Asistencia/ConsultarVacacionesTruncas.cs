using System;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>Resultado de la simulación académica al último día de servicio indicado por el operador.</summary>
public sealed class VacacionesTruncasDto
{
    public int Empleado { get; set; }
    public DateTime Ingreso { get; set; }
    public DateTime Cese { get; set; }
    public decimal DiasAnuales { get; set; }
    public decimal Truncas { get; set; }
}

/// <summary>RF-09: calcula truncas sin asumir que la fecha de resolución sea la fecha efectiva del cese.</summary>
public sealed class ConsultarVacacionesTruncas
{
    private readonly IIngresoVacacionesRepository _ingresos;
    private readonly RegimenVacacionesPiloto _regimen;
    public ConsultarVacacionesTruncas(IIngresoVacacionesRepository ingresos,RegimenVacacionesPiloto regimen)
    {
        _ingresos=ingresos ?? throw new ArgumentNullException(nameof(ingresos));
        _regimen=regimen ?? throw new ArgumentNullException(nameof(regimen));
    }
    /// <summary>Consulta ingreso y calcula al cese inclusivo, entre 1900 y 9998.</summary>
    public VacacionesTruncasDto Ejecutar(int empleado,DateTime cese)
    {
        if (empleado<=0 || cese.Year<1900 || cese.Year>9998) throw new ReglaNegocioException("Empleado o fecha de cese inválidos.");
        DateTime ingreso=_ingresos.ObtenerIngreso(empleado);
        return new VacacionesTruncasDto {Empleado=empleado,Ingreso=ingreso,Cese=cese.Date,
            DiasAnuales=_regimen.DiasAnuales,Truncas=_regimen.Truncas(ingreso,cese)};
    }
}
