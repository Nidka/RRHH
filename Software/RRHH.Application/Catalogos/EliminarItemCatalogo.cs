using System;
using RRHH.Application.Comun;

namespace RRHH.Application.Catalogos;

public sealed class EliminarItemCatalogo
{
	private readonly ICatalogoRepository _repository;

	public EliminarItemCatalogo(ICatalogoRepository repository)
	{
		_repository = repository ?? throw new ArgumentNullException(nameof(repository));
	}

	public ResultadoOperacion Ejecutar(int id)
	{
		try
		{
			_repository.Eliminar(id);
			return ResultadoOperacion.Ok();
		}
		catch (RegistroEnUsoException)
		{
			return ResultadoOperacion.Error("Se hace referencia a este registro en otra tabla.");
		}
	}
}
