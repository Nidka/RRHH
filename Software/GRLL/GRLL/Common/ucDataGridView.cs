using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

public class ucDataGridView : DataGridView
{
	public delegate void onEnterDialogEventHandler();

	public delegate void onDeleteDialogEventHandler();

	public delegate void BorderChangedEventHandler(object sender, FlatBoxEventArgs e);

	public enum OpcionEdicion
	{
		Ninguna,
		MoverPorColumnas,
		MoverPorFilas
	}

	private bool _ConColorAlternativo;

	private bool _EliminarDEL;

	private TextBox texto;

	private const int WM_PAINT = 15;

	private bool IamON;

	private bool IamFocus;

	private bool _TabNextControl;

	private Color _BorderColorActive;

	private Color _BorderColorInactive;

	private Color _BorderColor;

	private bool _ListOnFocused;

	private int _ExtendLastColumn;

	private OpcionEdicion _Editando;

	[DefaultValue(false)]
	public bool EliminarDEL
	{
		get
		{
			return _EliminarDEL;
		}
		set
		{
			_EliminarDEL = value;
		}
	}

	[DefaultValue(true)]
	public bool ConColorAlternativo
	{
		get
		{
			return _ConColorAlternativo;
		}
		set
		{
			_ConColorAlternativo = value;
			if (!_ConColorAlternativo)
			{
				Color backColor = default(Color);
				AlternatingRowsDefaultCellStyle.BackColor = backColor;
			}
		}
	}

	[DefaultValue(0)]
	public OpcionEdicion ModoEdicion
	{
		get
		{
			return _Editando;
		}
		set
		{
			_Editando = value;
		}
	}

	[DefaultValue(-1)]
	public int ExtendColumn
	{
		get
		{
			return _ExtendLastColumn;
		}
		set
		{
			_ExtendLastColumn = value;
			if (DesignMode && _ExtendLastColumn >= 0 && Columns[_ExtendLastColumn].Visible)
			{
				ExtenderLastColumn();
			}
		}
	}

	public Color BorderColorActive
	{
		get
		{
			return _BorderColorActive;
		}
		set
		{
			_BorderColorActive = value;
		}
	}

	public Color BorderColorInactive
	{
		get
		{
			return _BorderColorInactive;
		}
		set
		{
			_BorderColorInactive = value;
		}
	}

	[method: DebuggerNonUserCode]
	public event onEnterDialogEventHandler onEnterDialog;

	[method: DebuggerNonUserCode]
	public event onDeleteDialogEventHandler onDeleteDialog;

	[method: DebuggerNonUserCode]
	public event BorderChangedEventHandler BorderChanged;

	protected override void OnCellEndEdit(DataGridViewCellEventArgs e)
	{
		ucDataGridView ucDataGridView2 = this;
		if (ucDataGridView2.CurrentCell.ColumnIndex == 0 && texto.Text.Length == 0)
		{
			onEnterDialog?.Invoke();
		}
		ucDataGridView2 = null;
		base.OnCellEndEdit(e);
	}

	public void EliminaFilasNoValidas()
	{
		if (Rows.Count > 1)
		{
			AllowUserToAddRows = false;
		}
		foreach (DataGridViewRow sRow in (IEnumerable)Rows)
		{
			if (sRow.Cells[1].Value == null || Conversion.Val(RuntimeHelpers.GetObjectValue(sRow.Cells[1].Value)) == 0.0)
			{
				Rows.Remove(sRow);
			}
		}
		AllowUserToAddRows = true;
	}

	protected override bool ProcessDialogKey(Keys keyData)
	{
		AllowUserToAddRows = false;
		checked
		{
			try
			{
				if (keyData != Keys.Return)
				{
					goto IL_02a5;
				}
				ucDataGridView ucDataGridView2 = this;
				if (ucDataGridView2.CurrentCell.ColumnIndex == 0 && texto.Text.Length == 0)
				{
					onEnterDialog?.Invoke();
				}
				if (ucDataGridView2.CurrentCell.ColumnIndex == ucDataGridView2.ColumnCount - 1)
				{
					if (ucDataGridView2.CurrentCell.RowIndex != ucDataGridView2.RowCount - 1)
					{
						ucDataGridView2.CurrentCell = ucDataGridView2.Rows[ucDataGridView2.CurrentCell.RowIndex + 1].Cells[0];
						if (CurrentRow.Index <= 0)
						{
							goto IL_02a0;
						}
						if (Rows[CurrentRow.Index - 1].Cells[0].Value == null)
						{
							ucDataGridView2.CurrentCell = ucDataGridView2.Rows[ucDataGridView2.CurrentRow.Index].Cells[0];
							ucDataGridView2.AllowUserToAddRows = false;
						}
						else
						{
							if (Conversion.Val(RuntimeHelpers.GetObjectValue(ucDataGridView2.Rows[ucDataGridView2.CurrentRow.Index - 1].Cells[0].Value)) != 0.0)
							{
								goto IL_02a0;
							}
							ucDataGridView2.CurrentCell = ucDataGridView2.Rows[ucDataGridView2.CurrentRow.Index].Cells[0];
							ucDataGridView2.AllowUserToAddRows = false;
						}
					}
				}
				else if (ucDataGridView2.CurrentCell.RowIndex == ucDataGridView2.RowCount - 1)
				{
					if (ucDataGridView2.CurrentRow.Cells[ucDataGridView2.CurrentCell.ColumnIndex + 1] != null)
					{
						ucDataGridView2.CurrentCell = ucDataGridView2.CurrentRow.Cells[ucDataGridView2.CurrentCell.ColumnIndex + 1];
						goto IL_02a0;
					}
				}
				else
				{
					if (!ucDataGridView2.Columns[ucDataGridView2.CurrentCell.ColumnIndex + 1].ReadOnly || ucDataGridView2.CurrentCell.ColumnIndex + 1 > ucDataGridView2.Columns.Count - 1)
					{
						ucDataGridView2.CurrentCell = ucDataGridView2.CurrentRow.Cells[ucDataGridView2.CurrentCell.ColumnIndex + 1];
						goto IL_02a0;
					}
					if (ucDataGridView2.CurrentCell.ColumnIndex + 2 > ucDataGridView2.ColumnCount - 1)
					{
						ucDataGridView2.CurrentCell = ucDataGridView2.CurrentRow.Cells[ucDataGridView2.CurrentCell.ColumnIndex + 1];
					}
					else
					{
						ucDataGridView2.CurrentCell = ucDataGridView2.CurrentRow.Cells[ucDataGridView2.CurrentCell.ColumnIndex + 2];
					}
				}
				goto end_IL_0007;
				IL_02a0:
				ucDataGridView2 = null;
				keyData = Keys.None;
				goto IL_02a5;
				IL_02a5:
				if (keyData != Keys.Delete)
				{
				}
				end_IL_0007:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			bool ProcessDialogKey = default(bool);
			return ProcessDialogKey;
		}
	}

	protected override bool ProcessDataGridViewKey(KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
		}
		base.ProcessDataGridViewKey(e);
		bool ProcessDataGridViewKey = default(bool);
		return ProcessDataGridViewKey;
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		checked
		{
			if (e.KeyValue == 13)
			{
				ucDataGridView ucDataGridView2 = this;
				try
				{
					if (ucDataGridView2.CurrentCell.ColumnIndex == ucDataGridView2.ColumnCount - 1)
					{
						if (ucDataGridView2.CurrentCell.RowIndex == ucDataGridView2.RowCount - 1)
						{
							return;
						}
						ucDataGridView2.CurrentCell = ucDataGridView2.Rows[ucDataGridView2.CurrentCell.RowIndex + 1].Cells[0];
					}
					else if (ucDataGridView2.CurrentCell.RowIndex == ucDataGridView2.RowCount - 1)
					{
						if (ucDataGridView2.CurrentRow.Cells[ucDataGridView2.CurrentCell.ColumnIndex + 1] == null)
						{
							return;
						}
						ucDataGridView2.CurrentCell = ucDataGridView2.CurrentRow.Cells[ucDataGridView2.CurrentCell.ColumnIndex + 1];
					}
					else
					{
						ucDataGridView2.CurrentCell = ucDataGridView2.CurrentRow.Cells[ucDataGridView2.CurrentCell.ColumnIndex + 1];
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				ucDataGridView2 = null;
				e.Handled = true;
			}
			else if (e.KeyValue == 46 && _EliminarDEL)
			{
				try
				{
					Rows.Remove(CurrentRow);
					if (NewRowIndex != 0)
					{
						CurrentCell = Rows[CurrentRow.Index + 1].Cells[0];
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Interaction.MsgBox(ex4.Message);
					ProjectData.ClearProjectError();
				}
			}
			base.OnKeyDown(e);
		}
	}

	protected override void OnEditingControlShowing(DataGridViewEditingControlShowingEventArgs e)
	{
		base.OnEditingControlShowing(e);
		if (e.Control.GetType() == typeof(DataGridViewTextBoxEditingControl))
		{
			e.Control.KeyPress -= keypressed;
			e.Control.KeyPress += keypressed;
			texto = (TextBox)EditingControl;
		}
	}

	private void keypressed(object o, KeyPressEventArgs e)
	{
		if (CurrentCell != null && CurrentCell.ColumnIndex != 1)
		{
			texto = (TextBox)EditingControl;
			if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", TextCompare: false) == 0 && Strings.InStr(1, texto.Text, ".") != 0)
			{
				e.Handled = true;
				Interaction.Beep();
			}
			else if (!(((Strings.Asc(e.KeyChar) >= 48) & (Strings.Asc(e.KeyChar) <= 57)) | (Strings.Asc(e.KeyChar) == 8) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", TextCompare: false) == 0)))
			{
				e.Handled = true;
				Interaction.Beep();
			}
		}
	}

	public void AplicarEstiloCelda(TEstiloCelda cEstiloCelda)
	{
		DataGridViewCellStyle dataGridViewCellStyle = DefaultCellStyle;
		dataGridViewCellStyle.BackColor = cEstiloCelda.BackColor;
		dataGridViewCellStyle.SelectionBackColor = cEstiloCelda.SelectionBackColor;
		dataGridViewCellStyle.SelectionForeColor = cEstiloCelda.SelectionForeColor;
		dataGridViewCellStyle = null;
		if (_ConColorAlternativo)
		{
			AlternatingRowsDefaultCellStyle.BackColor = cEstiloCelda.AlternatingBackColor;
		}
		ColumnHeadersDefaultCellStyle.BackColor = cEstiloCelda.ColumnBackColor;
	}

	public ucDataGridView()
	{
		_ConColorAlternativo = true;
		texto = new TextBox();
		_TabNextControl = false;
		_BorderColorActive = Color.FromArgb(130, 165, 210);
		_BorderColorInactive = SystemColors.ControlDark;
		_ExtendLastColumn = -1;
		BackgroundColor = Color.White;
		DefaultCellStyle.Font = new Font("Arial", 8f, FontStyle.Regular);
		ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8f, FontStyle.Regular);
		AplicarEstiloCelda(new TEstiloCelda());
	}

	private void ExtenderLastColumn()
	{
		checked
		{
			int K = Columns.Count - 1;
			if (Columns.Count == 0)
			{
				return;
			}
			if (_ExtendLastColumn > Columns.Count - 1)
			{
				throw new Exception("Columna no válida");
			}
			try
			{
				int cUlt = _ExtendLastColumn;
				int size = default(int);
				for (K = Columns.Count - 1; K >= 0; K += -1)
				{
					DataGridViewColumn var = Columns[K];
					if (var.Visible && cUlt != K)
					{
						size += var.Width;
					}
				}
				int AltoFila = 0;
				if (RowCount > 0)
				{
					AltoFila = Rows[0].Height;
				}
				int nuetam = ((RowCount * AltoFila < Height) ? (Width - size - 4) : ((BorderStyle != BorderStyle.Fixed3D) ? (Width - size - 20) : (Width - size - 100)));
				if (RowHeadersVisible)
				{
					nuetam -= RowHeadersWidth;
				}
				if (nuetam > 0)
				{
					if (BorderStyle == BorderStyle.Fixed3D)
					{
						nuetam -= 5;
					}
					Columns[cUlt].Width = nuetam;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
	{
		base.OnColumnAdded(e);
	}

	protected override void OnColumnWidthChanged(DataGridViewColumnEventArgs e)
	{
		base.OnColumnWidthChanged(e);
		if (Columns.Count != 0 && _ExtendLastColumn >= 0 && e.Column.Index != _ExtendLastColumn && Columns[_ExtendLastColumn].Visible)
		{
			ExtenderLastColumn();
		}
	}

	protected override void OnResize(EventArgs e)
	{
		if (Columns.Count > 0 && _ExtendLastColumn >= 0 && Columns[_ExtendLastColumn].Visible)
		{
			ExtenderLastColumn();
		}
		base.OnResize(e);
	}

	protected override void OnDataSourceChanged(EventArgs e)
	{
		base.OnDataSourceChanged(e);
		if (_ExtendLastColumn >= 0 && Columns[_ExtendLastColumn].Visible)
		{
			ExtenderLastColumn();
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		IamON = true;
		Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		IamON = false;
		Invalidate();
	}

	protected override void OnLostFocus(EventArgs e)
	{
		IamON = false;
		Invalidate();
		base.OnLostFocus(e);
	}

	protected override void OnGotFocus(EventArgs e)
	{
		IamON = true;
		Cursor = Cursors.Default;
		base.OnGotFocus(e);
		Invalidate();
	}

	protected override void OnMouseHover(EventArgs e)
	{
		base.OnMouseHover(e);
		IamON = true;
		Invalidate();
	}
}
