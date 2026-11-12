using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Domain.Comun;

namespace RRHH.Application.Permisos;

/// <summary>
/// RF-18: informa quiénes están ausentes (vacaciones, licencia, enfermedad u otros motivos del catálogo)
/// en algún día de un periodo, con su motivo y los días del permiso que caen dentro del periodo.
/// </summary>
/// <remarks>
/// Reemplaza el criterio de <c>RRHHClass.spRRHH_RepPermisos</c>, que solo comprobaba que la <i>fecha de inicio</i>
/// del permiso cayera en el periodo y por eso omitía el permiso que empieza antes del periodo o que lo contiene.
/// Aquí se usa <see cref="RangoFechas.Solapa"/> (igualdad, solapamiento parcial y contención en ambos sentidos,
/// extremos incluidos), la misma regla de RF-03.
/// HIPÓTESIS (ver <c>specs/CR-018-ausencias-por-periodo.md</c>): la única fuente de ausencias es
/// <c>public."Permiso"</c>; las vacaciones y licencias se registran allí como motivos del catálogo.
/// </remarks>
public sealed class ReportarAusenciasPorPeriodo
{
	private readonly IAusenciasRepository _repository;

	public ReportarAusenciasPorPeriodo(IAusenciasRepository repository)
	{
		_repository = repository ?? throw new ArgumentNullException(nameof(repository));
	}

	/// <param name="desde">Primer día del periodo; se ignora la hora.</param>
	/// <param name="hasta">Último día del periodo, incluido; se ignora la hora.</param>
	/// <param name="idMotivo">Motivo a filtrar; <c>null</c> o <c>0</c> incluye todos.</param>
	/// <returns>Ausencias ordenadas por persona, inicio y motivo; lista vacía si nadie se ausenta.</returns>
	/// <exception cref="ReglaNegocioException"><paramref name="hasta"/> es anterior a <paramref name="desde"/>.</exception>
	public IReadOnlyList<AusenciaPorPeriodoDto> Ejecutar(DateTime desde, DateTime hasta, int? idMotivo)
	{
		RangoFechas periodo = RangoFechas.Crear(desde, hasta);
		int? motivo = idMotivo.HasValue && idMotivo.Value > 0 ? idMotivo : null;

		List<AusenciaPorPeriodoDto> resultado = new List<AusenciaPorPeriodoDto>();
		foreach (AusenciaRegistrada ausencia in _repository.ListarSolapadas(periodo, motivo))
		{
			// Un permiso con fin anterior al inicio es un dato inconsistente del sistema heredado: no se informa
			// como ausencia en lugar de abortar todo el reporte.
			if (ausencia.Fin.Date < ausencia.Inicio.Date)
			{
				continue;
			}

			RangoFechas permiso = RangoFechas.Crear(ausencia.Inicio, ausencia.Fin);
			if (!permiso.Solapa(periodo) || (motivo.HasValue && ausencia.IdMotivo != motivo.Value))
			{
				continue;
			}

			DateTime primero = permiso.Desde > periodo.Desde ? permiso.Desde : periodo.Desde;
			DateTime ultimo = permiso.Hasta < periodo.Hasta ? permiso.Hasta : periodo.Hasta;
			resultado.Add(new AusenciaPorPeriodoDto
			{
				IdEmpleado = ausencia.IdEmpleado,
				Empleado = ausencia.Empleado ?? string.Empty,
				IdMotivo = ausencia.IdMotivo,
				Motivo = ausencia.Motivo ?? string.Empty,
				Inicio = permiso.Desde,
				Fin = permiso.Hasta,
				DiasEnPeriodo = RangoFechas.Crear(primero, ultimo).Dias
			});
		}

		return resultado
			.OrderBy(a => a.Empleado, StringComparer.CurrentCultureIgnoreCase)
			.ThenBy(a => a.Inicio)
			.ThenBy(a => a.Motivo, StringComparer.CurrentCultureIgnoreCase)
			.ToList();
	}

	/// <summary>Motivos disponibles para el filtro del reporte.</summary>
	public IReadOnlyList<MotivoAusenciaDto> ListarMotivos()
	{
		return _repository.ListarMotivos();
	}
}
