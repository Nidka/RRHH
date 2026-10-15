using System;
using System.Collections.Generic;

namespace RRHH.PostgreSql.Catalogos;

/// <summary>
/// Tabla y columnas de PostgreSQL de un catálogo simple. Los nombres son
/// constantes del código (nunca entrada del usuario) y se validan igual.
/// </summary>
public sealed class MapeoCatalogo
{
	public MapeoCatalogo(
		string tabla,
		string columnaId,
		string columnaDescripcion,
		string columnaExtra = null,
		params ReferenciaCatalogo[] referencias)
	{
		Tabla = IdentificadorSql.Validar(tabla, nameof(tabla));
		ColumnaId = IdentificadorSql.Validar(columnaId, nameof(columnaId));
		ColumnaDescripcion = IdentificadorSql.Validar(columnaDescripcion, nameof(columnaDescripcion));
		ColumnaExtra = columnaExtra == null ? null : IdentificadorSql.Validar(columnaExtra, nameof(columnaExtra));
		Referencias = referencias ?? Array.Empty<ReferenciaCatalogo>();
	}

	public string Tabla { get; }

	public string ColumnaId { get; }

	public string ColumnaDescripcion { get; }

	/// <summary><c>null</c> si el catálogo no tiene campo adicional.</summary>
	public string ColumnaExtra { get; }

	/// <summary>Columnas de otras tablas que usan el código (las claves foráneas del SQL Server original).</summary>
	public IReadOnlyList<ReferenciaCatalogo> Referencias { get; }
}
