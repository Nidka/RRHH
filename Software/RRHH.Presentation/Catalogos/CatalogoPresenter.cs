using System;
using RRHH.Application.Catalogos;
using RRHH.Application.Comun;
using RRHH.Domain.Catalogos;

namespace RRHH.Presentation.Catalogos;

/// <summary>Presenter común a todos los mantenimientos de catálogos simples.</summary>
public sealed class CatalogoPresenter
{
	private readonly ICatalogoView _view;
	private readonly DefinicionCatalogo _definicion;
	private readonly ListarCatalogo _listar;
	private readonly GuardarItemCatalogo _guardar;
	private readonly EliminarItemCatalogo _eliminar;

	public CatalogoPresenter(
		ICatalogoView view,
		DefinicionCatalogo definicion,
		ListarCatalogo listar,
		GuardarItemCatalogo guardar,
		EliminarItemCatalogo eliminar)
	{
		_view = view ?? throw new ArgumentNullException(nameof(view));
		_definicion = definicion ?? throw new ArgumentNullException(nameof(definicion));
		_listar = listar ?? throw new ArgumentNullException(nameof(listar));
		_guardar = guardar ?? throw new ArgumentNullException(nameof(guardar));
		_eliminar = eliminar ?? throw new ArgumentNullException(nameof(eliminar));

		_view.ConfigurarColumnas(_definicion.EtiquetaDescripcion, _definicion.EtiquetaExtra);
		_view.BuscarSolicitado += (_, _) => Buscar();
		_view.ValidarFilaSolicitado += (_, e) => ValidarFila(e);
		_view.GuardarFilaSolicitado += (_, e) => GuardarFila(e);
		_view.EliminarFilaSolicitado += (_, e) => EliminarFila(e);
	}

	private void Buscar()
	{
		try
		{
			_view.MostrarItems(_listar.Ejecutar(_view.Filtro));
		}
		catch (Exception ex)
		{
			_view.MostrarError($"No se pudo cargar el catálogo de {_definicion.Nombre}: {ex.Message}");
		}
	}

	private void ValidarFila(CatalogoFilaEventArgs e)
	{
		e.Error = _definicion.Validar(e.Fila.Descripcion, e.Fila.Extra);
	}

	private void GuardarFila(CatalogoFilaEventArgs e)
	{
		bool eraNuevo = e.Fila.EsNuevo;
		ResultadoOperacion resultado;
		try
		{
			resultado = _guardar.Ejecutar(e.Fila);
		}
		catch (Exception ex)
		{
			_view.MostrarError("No se pudo guardar el registro: " + ex.Message);
			e.Cancelar = true;
			return;
		}

		if (!resultado.Exitoso)
		{
			_view.MostrarError(resultado.Mensaje);
			e.Cancelar = true;
			return;
		}

		string accion = eraNuevo ? "Se insertó" : "Se actualizó";
		_view.MostrarInformacion(accion + " el registro:" + Describir(e.Fila));
	}

	private void EliminarFila(CatalogoFilaEventArgs e)
	{
		if (!_view.Confirmar("Va a eliminar el registro:" + Describir(e.Fila) + "\r\n¿Desea continuar?"))
		{
			e.Cancelar = true;
			return;
		}

		ResultadoOperacion resultado;
		try
		{
			resultado = _eliminar.Ejecutar(e.Fila.Id);
		}
		catch (Exception ex)
		{
			_view.MostrarError("No se pudo eliminar el registro: " + ex.Message);
			e.Cancelar = true;
			return;
		}

		if (!resultado.Exitoso)
		{
			_view.MostrarError(resultado.Mensaje);
			e.Cancelar = true;
		}
	}

	private string Describir(ItemCatalogoDto fila)
	{
		string texto = "\r\nCódigo=" + fila.Id +
			"\r\n" + _definicion.EtiquetaDescripcion + "=" + fila.Descripcion;
		if (_definicion.TieneExtra)
		{
			texto += "\r\n" + _definicion.EtiquetaExtra + "=" + fila.Extra;
		}

		return texto + "\r\n";
	}
}
