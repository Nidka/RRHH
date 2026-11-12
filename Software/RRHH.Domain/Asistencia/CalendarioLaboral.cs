using System;
using System.Collections.Generic;
using RRHH.Domain.Comun;

namespace RRHH.Domain.Asistencia;

/// <summary>
/// Define qué días cuentan como laborables a partir de una lista de feriados.
/// Es una regla pura: quien la use obtiene los feriados de <c>IFeriadoRepository</c>
/// y los pasa al constructor.
/// </summary>
/// <remarks>
/// HIPÓTESIS inicial: un día es laborable si es de lunes a viernes y no es feriado. El sábado
/// no se considera laborable hasta confirmarlo contra la regla de horarios. Un feriado que
/// cae en fin de semana no cambia el resultado (ya era no laborable).
/// </remarks>
public sealed class CalendarioLaboral
{
	private readonly HashSet<DateTime> _feriados;

	/// <param name="feriados">Fechas feriadas; se usa solo la parte fecha y se ignoran los repetidos.</param>
	/// <exception cref="ArgumentNullException"><paramref name="feriados"/> es <c>null</c>.</exception>
	public CalendarioLaboral(IEnumerable<DateTime> feriados)
	{
		if (feriados == null)
		{
			throw new ArgumentNullException(nameof(feriados));
		}

		_feriados = new HashSet<DateTime>();
		foreach (DateTime feriado in feriados)
		{
			_feriados.Add(feriado.Date);
		}
	}

	/// <summary>Indica si <paramref name="fecha"/> (solo la parte fecha) es lunes a viernes y no es feriado.</summary>
	public bool EsLaborable(DateTime fecha)
	{
		DateTime dia = fecha.Date;
		if (dia.DayOfWeek == DayOfWeek.Saturday || dia.DayOfWeek == DayOfWeek.Sunday)
		{
			return false;
		}

		return !_feriados.Contains(dia);
	}

	/// <summary>Cuenta los días laborables del rango, ambos extremos incluidos.</summary>
	/// <exception cref="ArgumentNullException"><paramref name="rango"/> es <c>null</c>.</exception>
	public int DiasLaborables(RangoFechas rango)
	{
		if (rango == null)
		{
			throw new ArgumentNullException(nameof(rango));
		}

		int laborables = 0;
		for (DateTime dia = rango.Desde; dia <= rango.Hasta; dia = dia.AddDays(1))
		{
			if (EsLaborable(dia))
			{
				laborables++;
			}
		}

		return laborables;
	}
}
