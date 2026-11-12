using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Asistencia;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using RRHH.Domain.Teletrabajo;

namespace RRHH.Application.Teletrabajo;

/// <summary>Total de días remotos computables de un empleado en el rango solicitado.</summary>
public sealed class DiasTeletrabajoDto
{
    public int IdEmpleado { get; set; }
    public int Dias { get; set; }
}

/// <summary>Recorta periodos, aplica el calendario y cuenta días remotos por empleado.</summary>
public sealed class ReportarDiasTeletrabajo
{
    private readonly IConsultaTeletrabajo _consulta;
    private readonly IFeriadoRepository _feriados;

    public ReportarDiasTeletrabajo(IConsultaTeletrabajo consulta, IFeriadoRepository feriados)
    {
        _consulta = consulta;
        _feriados = feriados;
    }

    /// <summary>Devuelve filas por empleado con periodos. Un código nulo incluye a todos.</summary>
    /// <exception cref="ReglaNegocioException">Rango invertido o código no positivo.</exception>
    public IReadOnlyList<DiasTeletrabajoDto> Ejecutar(int? empleado, DateTime desde, DateTime hasta)
    {
        var rango = RangoFechas.Crear(desde, hasta);
        if (empleado.HasValue && empleado.Value <= 0)
            throw new ReglaNegocioException("Indique un código de empleado positivo.");
        var periodos = _consulta.Consultar(empleado, rango);
        if (periodos.Count == 0) return Array.Empty<DiasTeletrabajoDto>();

        var calendario = new CalendarioLaboral(_feriados.Listar().Select(f => f.Fecha));
        return periodos.GroupBy(p => p.IdEmpleado).OrderBy(g => g.Key)
            .Select(g => new DiasTeletrabajoDto { IdEmpleado = g.Key, Dias = Contar(g, rango, calendario) })
            .ToList();
    }

    private static int Contar(IEnumerable<PeriodoTeletrabajoDto> periodos, RangoFechas rango,
        CalendarioLaboral calendario)
    {
        var ordenados = periodos.OrderBy(p => p.Desde).ToList();
        // Un único periodo total permite delegar todo el intervalo al calendario común.
        if (ordenados.Count == 1 && ordenados[0].Modalidad == ModalidadTeletrabajo.Total && rango.Hasta < DateTime.MaxValue.Date)
        {
            var p = ordenados[0];
            return calendario.DiasLaborables(Recortar(p, rango));
        }

        var dias = new HashSet<DateTime>();
        foreach (var p in ordenados)
        {
            var corte = Recortar(p, rango);
            for (var dia = corte.Desde; ; dia = dia.AddDays(1))
            {
                int indice = (int)dia.DayOfWeek - (int)DayOfWeek.Monday;
                if (indice >= 0 && indice < 5 && (p.DiasRemotos & (1 << indice)) != 0 && calendario.EsLaborable(dia))
                    dias.Add(dia);
                if (dia == corte.Hasta) break;
            }
        }
        return dias.Count;
    }

    private static RangoFechas Recortar(PeriodoTeletrabajoDto p, RangoFechas rango) =>
        RangoFechas.Crear(p.Desde > rango.Desde ? p.Desde : rango.Desde,
            p.Hasta < rango.Hasta ? p.Hasta : rango.Hasta);
}
