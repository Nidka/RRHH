using System;
using RRHH.Application.Comun;
using RRHH.Domain.Catalogos;
using RRHH.Domain.Comun;

namespace RRHH.Application.Catalogos;

/// <summary>Inserta o actualiza un registro según tenga o no código.</summary>
public sealed class GuardarItemCatalogo
{
	private readonly DefinicionCatalogo _definicion;
	private readonly ICatalogoRepository _repository;

	public GuardarItemCatalogo(DefinicionCatalogo definicion, ICatalogoRepository repository)
	{
		_definicion = definicion ?? throw new ArgumentNullException(nameof(definicion));
		_repository = repository ?? throw new ArgumentNullException(nameof(repository));
	}

	/// <summary>
	/// Guarda la fila. Si es nueva, asigna en <paramref name="dto"/> el código
	/// generado; en ambos casos deja en el DTO los textos tal como se guardaron.
	/// </summary>
	public ResultadoOperacion Ejecutar(ItemCatalogoDto dto)
	{
		if (dto == null)
		{
			throw new ArgumentNullException(nameof(dto));
		}

		ItemCatalogo item;
		try
		{
			item = ItemCatalogo.Crear(_definicion, dto.Id, dto.Descripcion, dto.Extra);
		}
		catch (ReglaNegocioException ex)
		{
			return ResultadoOperacion.Error(ex.Message);
		}

		if (item.EsNuevo)
		{
			dto.Id = _repository.Insertar(item);
		}
		else if (!_repository.Actualizar(item))
		{
			return ResultadoOperacion.Error("El registro ya no existe; es posible que otro usuario lo haya eliminado.");
		}

		dto.Descripcion = item.Descripcion;
		dto.Extra = item.Extra;
		return ResultadoOperacion.Ok();
	}
}
