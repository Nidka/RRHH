using System;
using RRHH.Application.Comun;

namespace RRHH.Application.Asistencia;

/// <summary>
/// Elimina un feriado registrado por su identificador.
/// </summary>
public sealed class EliminarFeriado
{
	private readonly IFeriadoRepository _repository;

	public EliminarFeriado(IFeriadoRepository repository)
	{
		_repository = repository ?? throw new ArgumentNullException(nameof(repository));
	}

	public ResultadoOperacion Ejecutar(int id)
	{
		if (id <= 0)
		{
			return ResultadoOperacion.Error("Primero debe Seleccionar un Feriado No Laborable.");
		}

		_repository.Eliminar(id);
		return ResultadoOperacion.Ok();
	}
}
