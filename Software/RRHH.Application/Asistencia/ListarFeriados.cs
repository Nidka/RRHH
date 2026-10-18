using System;
using System.Collections.Generic;
using System.Linq;

namespace RRHH.Application.Asistencia;

/// <summary>
/// Obtiene el listado completo de feriados registrados.
/// </summary>
public sealed class ListarFeriados
{
	private readonly IFeriadoRepository _repository;

	public ListarFeriados(IFeriadoRepository repository)
	{
		_repository = repository ?? throw new ArgumentNullException(nameof(repository));
	}

	public IList<FeriadoDto> Ejecutar()
	{
		return _repository.Listar()
			.Select(feriado => new FeriadoDto
			{
				Id = feriado.Id,
				Fecha = feriado.Fecha,
				Motivo = feriado.Motivo
			})
			.ToList();
	}
}
