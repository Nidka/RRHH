using System;
using System.Collections.Generic;
using RRHH.Application.Catalogos;

namespace RRHH.Presentation.Catalogos;

/// <summary>Vista pasiva del mantenimiento de un catálogo simple.</summary>
public interface ICatalogoView
{
	/// <summary>Texto de búsqueda escrito por el usuario.</summary>
	string Filtro { get; }

	/// <summary>Al abrir la pantalla, al cambiar el filtro o al pulsar "Buscar".</summary>
	event EventHandler BuscarSolicitado;

	/// <summary>Antes de confirmar la edición de una fila.</summary>
	event EventHandler<CatalogoFilaEventArgs> ValidarFilaSolicitado;

	/// <summary>Después de que el usuario confirma la edición de una fila válida.</summary>
	event EventHandler<CatalogoFilaEventArgs> GuardarFilaSolicitado;

	/// <summary>Cuando el usuario pide quitar una fila ya guardada.</summary>
	event EventHandler<CatalogoFilaEventArgs> EliminarFilaSolicitado;

	/// <summary>
	/// Títulos de las columnas. Si <paramref name="etiquetaExtra"/> es <c>null</c>,
	/// la columna adicional se oculta.
	/// </summary>
	void ConfigurarColumnas(string etiquetaDescripcion, string etiquetaExtra);

	void MostrarItems(IList<ItemCatalogoDto> items);

	bool Confirmar(string mensaje);

	void MostrarInformacion(string mensaje);

	void MostrarError(string mensaje);
}
