using System;

namespace RRHH.Domain.Catalogos;

/// <summary>
/// Reglas de un catálogo simple. Las longitudes máximas coinciden con las
/// columnas de BD/schema.sql (una prueba lo verifica).
/// </summary>
public sealed class DefinicionCatalogo
{
	public DefinicionCatalogo(
		TipoCatalogo tipo,
		string nombre,
		string etiquetaDescripcion,
		int longitudMaximaDescripcion,
		string etiquetaExtra = null,
		int longitudMaximaExtra = 0)
	{
		if (string.IsNullOrWhiteSpace(nombre))
		{
			throw new ArgumentException("El nombre es obligatorio.", nameof(nombre));
		}

		if (longitudMaximaDescripcion <= 0)
		{
			throw new ArgumentOutOfRangeException(nameof(longitudMaximaDescripcion));
		}

		if (etiquetaExtra != null && longitudMaximaExtra <= 0)
		{
			throw new ArgumentOutOfRangeException(nameof(longitudMaximaExtra));
		}

		Tipo = tipo;
		Nombre = nombre;
		EtiquetaDescripcion = etiquetaDescripcion;
		LongitudMaximaDescripcion = longitudMaximaDescripcion;
		EtiquetaExtra = etiquetaExtra;
		LongitudMaximaExtra = etiquetaExtra == null ? 0 : longitudMaximaExtra;
	}

	public TipoCatalogo Tipo { get; }

	/// <summary>Nombre en singular para los mensajes, por ejemplo "estado civil".</summary>
	public string Nombre { get; }

	public string EtiquetaDescripcion { get; }

	public int LongitudMaximaDescripcion { get; }

	/// <summary><c>null</c> si el catálogo no tiene campo adicional.</summary>
	public string EtiquetaExtra { get; }

	public int LongitudMaximaExtra { get; }

	public bool TieneExtra => EtiquetaExtra != null;

	/// <summary>Devuelve el primer error encontrado o <c>null</c> si los datos son válidos.</summary>
	public string Validar(string descripcion, string extra)
	{
		if (string.IsNullOrWhiteSpace(descripcion))
		{
			return $"Debe ingresar {EtiquetaDescripcion.ToLowerInvariant()}.";
		}

		if (descripcion.Trim().Length > LongitudMaximaDescripcion)
		{
			return $"{EtiquetaDescripcion}: no puede superar {LongitudMaximaDescripcion} caracteres.";
		}

		if (TieneExtra && extra != null && extra.Trim().Length > LongitudMaximaExtra)
		{
			return $"{EtiquetaExtra}: no puede superar {LongitudMaximaExtra} caracteres.";
		}

		return null;
	}
}
