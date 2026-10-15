namespace RRHH.PostgreSql.Catalogos;

/// <summary>
/// Columna de otra tabla que guarda el código de un catálogo. El esquema
/// PostgreSQL no tiene claves foráneas, así que el repositorio revisa estas
/// columnas antes de eliminar.
/// </summary>
public sealed class ReferenciaCatalogo
{
	public ReferenciaCatalogo(string tabla, string columna)
	{
		Tabla = IdentificadorSql.Validar(tabla, nameof(tabla));
		Columna = IdentificadorSql.Validar(columna, nameof(columna));
	}

	public string Tabla { get; }

	public string Columna { get; }

	public override string ToString() => Tabla + "." + Columna;
}
