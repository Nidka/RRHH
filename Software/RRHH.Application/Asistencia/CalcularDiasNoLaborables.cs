using System;
using System.Linq;
using RRHH.Domain.Asistencia;
using RRHH.Domain.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>
/// RF-17: cuenta los días no laborables de un periodo (fines de semana y feriados de
/// <c>public."RRHH_Feriado"</c>) sin contar dos veces un feriado que cae en fin de semana
/// ni un feriado repetido en la tabla.
/// </summary>
/// <remarks>
/// Reemplaza el conteo que hacía <c>FrmConsultaAsistencias</c> (botón de consulta del reporte general),
/// que solo contaba sábados y domingos del rango y por eso omitía los feriados entre semana.
/// HIPÓTESIS (ver <c>specs/CR-017-feriados-reporte.md</c>): en el modo «Asistencias» los días no laborables
/// se suman automáticamente a los días asistidos; la definición de día laborable es la de
/// <see cref="CalendarioLaboral"/> (lunes a viernes y no feriado).
/// </remarks>
public sealed class CalcularDiasNoLaborables
{
	private readonly IFeriadoRepository _repository;

	public CalcularDiasNoLaborables(IFeriadoRepository repository)
	{
		_repository = repository ?? throw new ArgumentNullException(nameof(repository));
	}

	/// <param name="desde">Primer día del periodo; se ignora la hora.</param>
	/// <param name="hasta">Último día del periodo, incluido; se ignora la hora.</param>
	/// <returns>Cantidad de días del periodo que no son laborables.</returns>
	/// <exception cref="ReglaNegocioException"><paramref name="hasta"/> es anterior a <paramref name="desde"/>.</exception>
	public int Ejecutar(DateTime desde, DateTime hasta)
	{
		RangoFechas rango = RangoFechas.Crear(desde, hasta);
		CalendarioLaboral calendario = new CalendarioLaboral(
			_repository.Listar().Select(feriado => feriado.Fecha));
		return rango.Dias - calendario.DiasLaborables(rango);
	}
}
