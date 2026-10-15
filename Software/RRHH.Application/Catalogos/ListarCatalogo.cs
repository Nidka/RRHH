using System;
using System.Collections.Generic;
using System.Linq;

namespace RRHH.Application.Catalogos;

public sealed class ListarCatalogo
{
	private readonly ICatalogoRepository _repository;

	public ListarCatalogo(ICatalogoRepository repository)
	{
		_repository = repository ?? throw new ArgumentNullException(nameof(repository));
	}

	public IList<ItemCatalogoDto> Ejecutar(string filtro)
	{
		return _repository.Listar(filtro?.Trim() ?? string.Empty)
			.Select(item => new ItemCatalogoDto
			{
				Id = item.Id,
				Descripcion = item.Descripcion,
				Extra = item.Extra
			})
			.ToList();
	}
}
