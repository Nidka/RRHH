namespace RRHH.Application.Catalogos;

/// <summary>
/// Fila editable de un catálogo. Es mutable y tiene constructor sin
/// parámetros porque la grilla agrega y edita filas directamente.
/// </summary>
public sealed class ItemCatalogoDto
{
	public int Id { get; set; }

	public string Descripcion { get; set; }

	/// <summary>Abreviatura u observaciones, según el catálogo.</summary>
	public string Extra { get; set; }

	public bool EsNuevo => Id == 0;
}
