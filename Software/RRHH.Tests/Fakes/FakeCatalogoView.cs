using System;
using System.Collections.Generic;
using RRHH.Application.Catalogos;
using RRHH.Presentation.Catalogos;

namespace RRHH.Tests.Fakes;

internal sealed class FakeCatalogoView : ICatalogoView
{
	public string Filtro { get; set; } = string.Empty;

	public bool RespuestaConfirmacion { get; set; } = true;

	public string EtiquetaDescripcion { get; private set; }

	public string EtiquetaExtra { get; private set; }

	public bool ColumnasConfiguradas { get; private set; }

	public IList<ItemCatalogoDto> Mostrados { get; private set; }

	public List<string> Confirmaciones { get; } = new List<string>();

	public List<string> Informaciones { get; } = new List<string>();

	public List<string> Errores { get; } = new List<string>();

	public event EventHandler BuscarSolicitado;
	public event EventHandler<CatalogoFilaEventArgs> ValidarFilaSolicitado;
	public event EventHandler<CatalogoFilaEventArgs> GuardarFilaSolicitado;
	public event EventHandler<CatalogoFilaEventArgs> EliminarFilaSolicitado;

	public void Buscar() => BuscarSolicitado?.Invoke(this, EventArgs.Empty);

	public CatalogoFilaEventArgs Validar(ItemCatalogoDto fila) => Disparar(ValidarFilaSolicitado, fila);

	public CatalogoFilaEventArgs Guardar(ItemCatalogoDto fila) => Disparar(GuardarFilaSolicitado, fila);

	public CatalogoFilaEventArgs Eliminar(ItemCatalogoDto fila) => Disparar(EliminarFilaSolicitado, fila);

	public void ConfigurarColumnas(string etiquetaDescripcion, string etiquetaExtra)
	{
		ColumnasConfiguradas = true;
		EtiquetaDescripcion = etiquetaDescripcion;
		EtiquetaExtra = etiquetaExtra;
	}

	public void MostrarItems(IList<ItemCatalogoDto> items) => Mostrados = items;

	public bool Confirmar(string mensaje)
	{
		Confirmaciones.Add(mensaje);
		return RespuestaConfirmacion;
	}

	public void MostrarInformacion(string mensaje) => Informaciones.Add(mensaje);

	public void MostrarError(string mensaje) => Errores.Add(mensaje);

	private CatalogoFilaEventArgs Disparar(EventHandler<CatalogoFilaEventArgs> handler, ItemCatalogoDto fila)
	{
		var args = new CatalogoFilaEventArgs(fila);
		handler?.Invoke(this, args);
		return args;
	}
}
