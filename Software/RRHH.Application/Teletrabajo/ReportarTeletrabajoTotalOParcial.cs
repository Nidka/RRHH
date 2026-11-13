using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Asistencia;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;
using RRHH.Domain.Teletrabajo;

namespace RRHH.Application.Teletrabajo;

/// <summary>
/// RF-16: informa quiénes realizan teletrabajo total o parcial en un periodo, con sus días remotos
/// y los días laborables del periodo.
/// </summary>
/// <remarks>
/// Reutiliza <see cref="ReportarDiasTeletrabajo"/> (RF-14) para contar los días remotos computables de cada persona
/// y <see cref="CalendarioLaboral"/> para los días laborables del periodo; no agrega consultas a la base.
/// HIPÓTESIS (ver <c>specs/CR-016-teletrabajo-total-parcial.md</c>): la clasificación es <b>por cobertura del periodo
/// consultado</b>, no por la modalidad con que se registró cada periodo. «Total» exige teletrabajar todos los días
/// laborables del periodo (100 %); «Parcial» es cualquier cobertura mayor que cero y menor que el total. Quien no
/// teletrabaja ningún día laborable del periodo no figura. Un periodo sin días laborables no clasifica a nadie.
/// </remarks>
public sealed class ReportarTeletrabajoTotalOParcial
{
    private readonly ReportarDiasTeletrabajo _dias;
    private readonly IFeriadoRepository _feriados;

    public ReportarTeletrabajoTotalOParcial(ReportarDiasTeletrabajo dias, IFeriadoRepository feriados)
    {
        _dias = dias ?? throw new ArgumentNullException(nameof(dias));
        _feriados = feriados ?? throw new ArgumentNullException(nameof(feriados));
    }

    /// <param name="desde">Primer día del periodo; se ignora la hora.</param>
    /// <param name="hasta">Último día del periodo, incluido; se ignora la hora.</param>
    /// <param name="filtro">Si tiene valor, solo las personas con esa clasificación; <c>null</c> incluye ambas.</param>
    /// <returns>Personas ordenadas por código; lista vacía si nadie teletrabaja o el periodo no tiene días laborables.</returns>
    /// <exception cref="ReglaNegocioException"><paramref name="hasta"/> es anterior a <paramref name="desde"/>.</exception>
    public IReadOnlyList<ClasificacionTeletrabajoDto> Ejecutar(DateTime desde, DateTime hasta, ModalidadTeletrabajo? filtro)
    {
        RangoFechas periodo = RangoFechas.Crear(desde, hasta);
        var calendario = new CalendarioLaboral(_feriados.Listar().Select(f => f.Fecha));
        int laborables = calendario.DiasLaborables(periodo);
        if (laborables == 0)
        {
            return Array.Empty<ClasificacionTeletrabajoDto>();
        }

        return _dias.Ejecutar(null, periodo.Desde, periodo.Hasta)
            .Where(fila => fila.Dias > 0)
            .Select(fila => new ClasificacionTeletrabajoDto
            {
                IdEmpleado = fila.IdEmpleado,
                DiasRemotos = fila.Dias,
                DiasLaborables = laborables,
                Clasificacion = fila.Dias >= laborables ? ModalidadTeletrabajo.Total : ModalidadTeletrabajo.Parcial
            })
            .Where(fila => !filtro.HasValue || fila.Clasificacion == filtro.Value)
            .OrderBy(fila => fila.IdEmpleado)
            .ToList();
    }
}
