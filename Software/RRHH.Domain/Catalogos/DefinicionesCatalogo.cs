using System;
using System.Collections.Generic;
using System.Linq;

namespace RRHH.Domain.Catalogos;

/// <summary>Definiciones de todos los catálogos simples del sistema.</summary>
public static class DefinicionesCatalogo
{
	private static readonly Dictionary<TipoCatalogo, DefinicionCatalogo> Definiciones =
		new DefinicionCatalogo[]
		{
			new DefinicionCatalogo(TipoCatalogo.EstadoCivil, "estado civil", "Descripción", 11, "Abreviatura", 3),
			new DefinicionCatalogo(TipoCatalogo.Cargo, "cargo", "Descripción", 50, "Abreviatura", 8),
			new DefinicionCatalogo(TipoCatalogo.GrupoSanguineo, "grupo sanguíneo", "Descripción", 5),
			new DefinicionCatalogo(TipoCatalogo.Nacionalidad, "nacionalidad", "Descripción", 50, "Abreviatura", 3),
			new DefinicionCatalogo(TipoCatalogo.RegimenPension, "régimen de pensión", "N° Ley", 5),
			new DefinicionCatalogo(TipoCatalogo.TipoDocumentoIdentidad, "tipo de documento", "Descripción", 40),
			new DefinicionCatalogo(TipoCatalogo.TipoEstudio, "tipo de estudio", "Descripción", 15),
			new DefinicionCatalogo(TipoCatalogo.TipoInstitucion, "tipo de institución", "Descripción", 15),
			new DefinicionCatalogo(TipoCatalogo.TipoPermiso, "tipo de permiso", "Descripción", 50),
			new DefinicionCatalogo(TipoCatalogo.TipoTrabajador, "tipo de trabajador", "Descripción", 30, "Observaciones", 150)
		}.ToDictionary(d => d.Tipo);

	public static IEnumerable<DefinicionCatalogo> Todos => Definiciones.Values;

	public static DefinicionCatalogo Definicion(TipoCatalogo tipo)
	{
		if (!Definiciones.TryGetValue(tipo, out DefinicionCatalogo definicion))
		{
			throw new ArgumentOutOfRangeException(nameof(tipo), tipo, "Catálogo sin definición.");
		}

		return definicion;
	}
}
