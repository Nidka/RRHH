using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using RRHH.Application.Catalogos;
using RRHH.Presentation.Catalogos;

namespace RecursosHumanos;

/// <summary>
/// Implementación de <see cref="ICatalogoView"/> sobre la grilla DevExpress
/// que comparten los formularios FrmMant* de catálogos. Cada formulario
/// conserva su diseño y reenvía aquí sus eventos.
/// La grilla debe tener columnas con FieldName "Id", "Descripcion" y, si
/// el catálogo lo usa, "Extra".
/// </summary>
internal sealed class VistaCatalogoGrid : ICatalogoView
{
	public const string CampoId = "Id";
	public const string CampoDescripcion = "Descripcion";
	public const string CampoExtra = "Extra";

	private readonly Form _form;
	private readonly GridView _grilla;
	private readonly DataNavigator _navegador;
	private readonly Func<string> _leerFiltro;
	private BindingList<ItemCatalogoDto> _filas = new BindingList<ItemCatalogoDto>();

	public VistaCatalogoGrid(Form form, GridView grilla, DataNavigator navegador, Func<string> leerFiltro)
	{
		_form = form ?? throw new ArgumentNullException(nameof(form));
		_grilla = grilla ?? throw new ArgumentNullException(nameof(grilla));
		_navegador = navegador ?? throw new ArgumentNullException(nameof(navegador));
		_leerFiltro = leerFiltro ?? throw new ArgumentNullException(nameof(leerFiltro));
	}

	public event EventHandler BuscarSolicitado;

	public event EventHandler<CatalogoFilaEventArgs> ValidarFilaSolicitado;

	public event EventHandler<CatalogoFilaEventArgs> GuardarFilaSolicitado;

	public event EventHandler<CatalogoFilaEventArgs> EliminarFilaSolicitado;

	public string Filtro => _leerFiltro() ?? string.Empty;

	public void ConfigurarColumnas(string etiquetaDescripcion, string etiquetaExtra)
	{
		GridColumn descripcion = _grilla.Columns.ColumnByFieldName(CampoDescripcion);
		if (descripcion != null)
		{
			descripcion.Caption = etiquetaDescripcion;
		}

		GridColumn extra = _grilla.Columns.ColumnByFieldName(CampoExtra);
		if (extra != null)
		{
			extra.Visible = etiquetaExtra != null;
			if (etiquetaExtra != null)
			{
				extra.Caption = etiquetaExtra;
			}
		}
	}

	public void MostrarItems(IList<ItemCatalogoDto> items)
	{
		_filas = new BindingList<ItemCatalogoDto>(new List<ItemCatalogoDto>(items))
		{
			AllowNew = true,
			AllowEdit = true,
			AllowRemove = true
		};
		((GridControl)_grilla.GridControl).DataSource = _filas;
		_navegador.DataSource = _filas;
	}

	public bool Confirmar(string mensaje)
	{
		return MessageBox.Show(mensaje, _form.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
	}

	public void MostrarInformacion(string mensaje)
	{
		MessageBox.Show(mensaje, _form.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	public void MostrarError(string mensaje)
	{
		MessageBox.Show(mensaje, _form.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
	}

	/// <summary>Al cargar el formulario, al cambiar el filtro o al pulsar "Buscar".</summary>
	public void Buscar()
	{
		BuscarSolicitado?.Invoke(this, EventArgs.Empty);
	}

	public void ClickNavegador(NavigatorButtonClickEventArgs e)
	{
		if (e.Button.ButtonType == NavigatorButtonType.Append)
		{
			if (_grilla.FocusedColumn != null)
			{
				_grilla.FocusedColumn = _grilla.Columns.ColumnByFieldName(CampoDescripcion);
				_navegador.Buttons.DoClick(_navegador.Buttons.Last);
				if (_grilla.FocusedValue == null || _grilla.FocusedValue is DBNull)
				{
					e.Handled = true;
				}
				_grilla.ClearSorting();
				_grilla.ShowEditor();
			}
			return;
		}

		// EndEdit no guarda aquí: al confirmar la fila la grilla dispara
		// RowUpdated, que es el único punto de guardado.
		if (e.Button.ButtonType == NavigatorButtonType.Remove)
		{
			ItemCatalogoDto fila = FilaEnFoco();
			if (fila == null || fila.EsNuevo)
			{
				// Fila aún no guardada: solo se quita de la grilla.
				e.Handled = true;
				_grilla.DeleteRow(_grilla.FocusedRowHandle);
				return;
			}

			CatalogoFilaEventArgs args = new CatalogoFilaEventArgs(fila);
			EliminarFilaSolicitado?.Invoke(this, args);
			if (args.Cancelar)
			{
				e.Handled = true;
			}
		}

		if (e.Button.ButtonType == NavigatorButtonType.CancelEdit)
		{
			ItemCatalogoDto fila = FilaEnFoco();
			if (fila == null || fila.Descripcion == null)
			{
				_grilla.DeleteRow(_grilla.FocusedRowHandle);
			}
		}
	}

	public void AntesDeSalirDeFila(RowAllowEventArgs e)
	{
		if (_grilla.GetRow(e.RowHandle) is ItemCatalogoDto fila && fila.Descripcion == null)
		{
			e.Allow = false;
			_grilla.ShowEditor();
		}
	}

	public void ValidarFila(ValidateRowEventArgs e)
	{
		if (!(e.Row is ItemCatalogoDto fila))
		{
			return;
		}

		CatalogoFilaEventArgs args = new CatalogoFilaEventArgs(fila);
		ValidarFilaSolicitado?.Invoke(this, args);
		if (args.Error != null)
		{
			e.Valid = false;
			e.ErrorText = args.Error;
		}
	}

	public void FilaActualizada(RowObjectEventArgs e)
	{
		if (!(e.Row is ItemCatalogoDto fila) || fila.Descripcion == null)
		{
			return;
		}

		CatalogoFilaEventArgs args = new CatalogoFilaEventArgs(fila);
		GuardarFilaSolicitado?.Invoke(this, args);

		// Se difiere hasta que la grilla termine de procesar el evento.
		if (args.Cancelar)
		{
			// No se guardó: se recarga para no mostrar datos que no están en la base.
			_form.BeginInvoke(new Action(Buscar));
		}
		else
		{
			// Muestra el código asignado y los textos normalizados.
			_form.BeginInvoke(new Action(() => _grilla.RefreshData()));
		}
	}

	private ItemCatalogoDto FilaEnFoco()
	{
		return _grilla.GetRow(_grilla.FocusedRowHandle) as ItemCatalogoDto;
	}
}
