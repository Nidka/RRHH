using System;
using RRHH.Domain.Comun;

namespace RRHH.Domain.Catalogos;

/// <summary>Registro de un catálogo simple.</summary>
public sealed class ItemCatalogo
{
	private ItemCatalogo(int id, string descripcion, string extra)
	{
		Id = id;
		Descripcion = descripcion;
		Extra = extra;
	}

	/// <summary>0 mientras el registro no se haya guardado.</summary>
	public int Id { get; }

	public string Descripcion { get; }

	/// <summary>Abreviatura u observaciones, según el catálogo; puede ser <c>null</c>.</summary>
	public string Extra { get; }

	public bool EsNuevo => Id == 0;

	/// <summary>
	/// Crea un registro válido o lanza <see cref="ReglaNegocioException"/>.
	/// Los textos se guardan sin espacios sobrantes y el extra vacío queda en <c>null</c>.
	/// </summary>
	public static ItemCatalogo Crear(DefinicionCatalogo definicion, int id, string descripcion, string extra)
	{
		if (definicion == null)
		{
			throw new ArgumentNullException(nameof(definicion));
		}

		string error = definicion.Validar(descripcion, extra);
		if (error != null)
		{
			throw new ReglaNegocioException(error);
		}

		string extraNormalizado = definicion.TieneExtra ? extra?.Trim() : null;
		return new ItemCatalogo(
			id,
			descripcion.Trim(),
			string.IsNullOrEmpty(extraNormalizado) ? null : extraNormalizado);
	}

	/// <summary>
	/// Reconstruye un registro ya guardado sin volver a validarlo. Solo para
	/// repositorios: los datos heredados pueden no cumplir las reglas actuales.
	/// </summary>
	public static ItemCatalogo Reconstituir(int id, string descripcion, string extra)
	{
		return new ItemCatalogo(id, descripcion, extra);
	}
}
