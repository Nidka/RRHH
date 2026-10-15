using System.Collections.Generic;
using RRHH.Domain.Catalogos;

namespace RRHH.Application.Catalogos;

/// <summary>Acceso a datos de un catálogo simple concreto.</summary>
public interface ICatalogoRepository
{
	/// <summary>Registros cuya descripción contiene <paramref name="filtro"/> (sin distinguir mayúsculas).</summary>
	IReadOnlyList<ItemCatalogo> Listar(string filtro);

	/// <summary>Inserta el registro y devuelve el código asignado.</summary>
	int Insertar(ItemCatalogo item);

	/// <summary>Devuelve <c>false</c> si el registro ya no existe (por ejemplo, otro usuario lo eliminó).</summary>
	bool Actualizar(ItemCatalogo item);

	/// <exception cref="Comun.RegistroEnUsoException">Si otra tabla referencia el registro.</exception>
	void Eliminar(int id);
}
