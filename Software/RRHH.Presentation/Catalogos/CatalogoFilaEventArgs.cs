using System;
using RRHH.Application.Catalogos;

namespace RRHH.Presentation.Catalogos;

/// <summary>
/// Evento sobre una fila de la grilla. El presenter responde llenando
/// <see cref="Error"/> o marcando <see cref="Cancelar"/>.
/// </summary>
public sealed class CatalogoFilaEventArgs : EventArgs
{
	public CatalogoFilaEventArgs(ItemCatalogoDto fila)
	{
		Fila = fila ?? throw new ArgumentNullException(nameof(fila));
	}

	public ItemCatalogoDto Fila { get; }

	/// <summary>Mensaje de validación; <c>null</c> si la fila es válida.</summary>
	public string Error { get; set; }

	/// <summary>La vista debe deshacer la acción del usuario (por ejemplo, no quitar la fila).</summary>
	public bool Cancelar { get; set; }
}
