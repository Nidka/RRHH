using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>Consulta las fechas con asistencia registrada, conservando el origen del reporte general.</summary>
public interface IFechasAsistenciaRepository
{
    /// <summary>Devuelve fechas de Asistencia del empleado dentro del intervalo inclusivo.</summary>
    IReadOnlyList<DateTime> Listar(int empleado, RangoFechas periodo);
}

/// <summary>Detalle de una fecha del reporte RF-17. La marcación se conserva aunque el día no sea laborable.</summary>
public sealed class DiaAsistenciaDto
{
    public DateTime Fecha { get; set; }
    public bool Asistio { get; set; }
    public bool NoLaborable { get; set; }
    public bool CuentaEnTotal { get; set; }
}

/// <summary>Total por empleado y detalle diario con el criterio de Asistencias o Productividad.</summary>
public sealed class ResumenAsistenciaDto
{
    public int Empleado { get; set; }
    public int Total { get; set; }
    public IReadOnlyList<DiaAsistenciaDto> Dias { get; set; }
}

/// <summary>RF-17 del piloto. Cuenta cada fecha una vez y conserva el detalle de asistencia en feriados.</summary>
public sealed class ReportarAsistenciaConFeriados
{
    private readonly IFechasAsistenciaRepository _asistencias;
    private readonly IFeriadoRepository _feriados;

    /// <summary>Compone las fuentes compartidas por escritorio y web.</summary>
    public ReportarAsistenciaConFeriados(IFechasAsistenciaRepository asistencias, IFeriadoRepository feriados)
    {
        _asistencias = asistencias ?? throw new ArgumentNullException(nameof(asistencias));
        _feriados = feriados ?? throw new ArgumentNullException(nameof(feriados));
    }

    /// <summary>Calcula fechas únicas. Productividad solo cuenta las asistidas.</summary>
    /// <param name="empleado">Código positivo del empleado.</param>
    /// <param name="desde">Inicio inclusivo del intervalo.</param>
    /// <param name="hasta">Fin inclusivo del intervalo.</param>
    /// <param name="productividad">True para contar solo asistencia registrada.</param>
    /// <returns>Total y detalle de todos los días del intervalo.</returns>
    /// <exception cref="ReglaNegocioException">Empleado inválido o intervalo invertido.</exception>
    public ResumenAsistenciaDto Ejecutar(int empleado, DateTime desde, DateTime hasta, bool productividad)
    {
        if (empleado <= 0) throw new ReglaNegocioException("Seleccione un empleado válido.");
        var periodo = RangoFechas.Crear(desde, hasta);
        var asistidas = new HashSet<DateTime>(_asistencias.Listar(empleado, periodo)
            .Select(fecha => fecha.Date).Where(fecha => fecha >= periodo.Desde && fecha <= periodo.Hasta));
        var calendario = new CalendarioLaboral(_feriados.Listar().Select(feriado => feriado.Fecha));
        var dias = new List<DiaAsistenciaDto>();
        for (var fecha = periodo.Desde; fecha <= periodo.Hasta; fecha = fecha.AddDays(1))
        {
            bool asistio = asistidas.Contains(fecha);
            bool noLaborable = !calendario.EsLaborable(fecha);
            dias.Add(new DiaAsistenciaDto
            {
                Fecha = fecha, Asistio = asistio, NoLaborable = noLaborable,
                CuentaEnTotal = asistio || (!productividad && noLaborable)
            });
        }
        return new ResumenAsistenciaDto { Empleado = empleado, Total = dias.Count(dia => dia.CuentaEnTotal), Dias = dias };
    }
}
