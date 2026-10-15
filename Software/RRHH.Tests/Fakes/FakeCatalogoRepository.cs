using System;
using System.Collections.Generic;
using System.Linq;
using RRHH.Application.Catalogos;
using RRHH.Application.Comun;
using RRHH.Domain.Catalogos;

namespace RRHH.Tests.Fakes;

internal sealed class FakeCatalogoRepository : ICatalogoRepository
{
	public List<ItemCatalogo> Registros { get; } = new List<ItemCatalogo>();

	public HashSet<int> IdsEnUso { get; } = new HashSet<int>();

	public bool FallarAlGuardar { get; set; }

	public IReadOnlyList<ItemCatalogo> Listar(string filtro)
	{
		return Registros
			.Where(e => e.Descripcion.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
			.ToList();
	}

	public int Insertar(ItemCatalogo item)
	{
		LanzarSiFalla();
		int id = Registros.Count == 0 ? 1 : Registros.Max(e => e.Id) + 1;
		Registros.Add(ItemCatalogo.Reconstituir(id, item.Descripcion, item.Extra));
		return id;
	}

	public bool Actualizar(ItemCatalogo item)
	{
		LanzarSiFalla();
		int index = Registros.FindIndex(e => e.Id == item.Id);
		if (index < 0)
		{
			return false;
		}

		Registros[index] = item;
		return true;
	}

	public void Eliminar(int id)
	{
		if (IdsEnUso.Contains(id))
		{
			throw new RegistroEnUsoException("En uso", null);
		}

		Registros.RemoveAll(e => e.Id == id);
	}

	private void LanzarSiFalla()
	{
		if (FallarAlGuardar)
		{
			throw new InvalidOperationException("Conexión perdida");
		}
	}
}
