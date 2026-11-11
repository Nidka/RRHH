using System;

namespace RRHH.Domain.Comun;

/// <summary>
/// Rango de fechas inmutable con ambos extremos incluidos. Solo se considera la parte
/// fecha (<see cref="DateTime.Date"/>): la hora se descarta al crear el rango.
/// </summary>
/// <remarks>
/// Base compartida de las reglas con periodos (turnos, permisos, teletrabajo, ausencias).
/// Centraliza la comprobación de solapamiento, que en <c>RRHHClass.ExistePermiso</c> era
/// incompleta: no detectaba un rango nuevo que contiene a uno existente.
/// </remarks>
public sealed class RangoFechas
{
	private RangoFechas(DateTime desde, DateTime hasta)
	{
		Desde = desde;
		Hasta = hasta;
	}

	/// <summary>Primer día del rango, sin hora.</summary>
	public DateTime Desde { get; }

	/// <summary>Último día del rango, sin hora. Está incluido en el rango.</summary>
	public DateTime Hasta { get; }

	/// <summary>Cantidad de días calendario del rango, contando ambos extremos. Un rango de un día vale 1.</summary>
	public int Dias => (Hasta - Desde).Days + 1;

	/// <summary>
	/// Crea un rango con las fechas truncadas al día calendario.
	/// </summary>
	/// <exception cref="ReglaNegocioException">
	/// <paramref name="hasta"/> es anterior a <paramref name="desde"/> (se comparan solo las fechas).
	/// </exception>
	public static RangoFechas Crear(DateTime desde, DateTime hasta)
	{
		if (hasta.Date < desde.Date)
		{
			throw new ReglaNegocioException("La fecha final no puede ser anterior a la fecha inicial.");
		}

		return new RangoFechas(desde.Date, hasta.Date);
	}

	/// <summary>Indica si <paramref name="fecha"/> (solo la parte fecha) cae dentro del rango, extremos incluidos.</summary>
	public bool Contiene(DateTime fecha)
	{
		DateTime dia = fecha.Date;
		return dia >= Desde && dia <= Hasta;
	}

	/// <summary>
	/// Indica si ambos rangos comparten al menos un día: igualdad, solapamiento parcial por
	/// cualquiera de los lados y contención en cualquier sentido. Rangos contiguos sin día en
	/// común (uno termina el 12 y el otro empieza el 13) no se solapan.
	/// </summary>
	/// <exception cref="ArgumentNullException"><paramref name="otro"/> es <c>null</c>.</exception>
	public bool Solapa(RangoFechas otro)
	{
		if (otro == null)
		{
			throw new ArgumentNullException(nameof(otro));
		}

		return Desde <= otro.Hasta && Hasta >= otro.Desde;
	}
}
