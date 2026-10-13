using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

public class ucListData : TextBox
{
	public delegate void SeleccionChangedEventHandler();

	public delegate void BorderChangedEventHandler(object sender, FlatBoxEventArgs e);

	public delegate void SeleccionEnterEventHandler();

	public struct Contenedor
	{
		public Control Control;

		public int Left;

		public int Top;
	}

	private SqlConnection _SQLConexion;

	private string _SQLQuery;

	private string _SQLFiltro;

	private string _SQLColumaID;

	private DataGridViewRow _FilaSeleccionada;

	private const int WM_PAINT = 15;

	private Color _ActiveBorderColor;

	private Color _InactiveBorderColor;

	private Color _BorderColor;

	private bool IamON;

	private int _ListaWidth;

	private string _FilaValor;

	private bool fueEnter;

	[AccessedThroughProperty("LIsta")]
	private DataGridView _LIsta;

	private bool vbVerlista;

	public string FilaValor
	{
		get
		{
			return _FilaValor;
		}
		set
		{
			_FilaValor = value;
		}
	}

	public int ListaWidth
	{
		get
		{
			return _ListaWidth;
		}
		set
		{
			_ListaWidth = value;
			if (_ListaWidth < 50)
			{
				_ListaWidth = 50;
			}
		}
	}

	public Color ActiveBorderColor
	{
		get
		{
			return _ActiveBorderColor;
		}
		set
		{
			_ActiveBorderColor = value;
		}
	}

	public Color InactiveBorderColor
	{
		get
		{
			return _InactiveBorderColor;
		}
		set
		{
			_InactiveBorderColor = value;
		}
	}

	[Description("Devuelve un DataGridViewRow con los valores de la fila seleccionada")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public DataGridViewRow FilaSeleccionada => _FilaSeleccionada;

	[Description("Conexión activa del tipo SQLConnection")]
	public SqlConnection SQLConexion
	{
		get
		{
			return _SQLConexion;
		}
		set
		{
			_SQLConexion = value;
		}
	}

	[Description("Instrucción SQL a procesar, minimo debe contener 2 Fields")]
	public string SQLQuery
	{
		get
		{
			return _SQLQuery;
		}
		set
		{
			_SQLQuery = value;
		}
	}

	[Description("Nombre de campo por el que se realizará la búsqueda autocompletada")]
	public string SQLFiltro
	{
		get
		{
			return _SQLFiltro;
		}
		set
		{
			_SQLFiltro = value;
		}
	}

	[Description("Nombre de campo por el que se realizará la búsqueda por ID")]
	public string SQLColumnaID
	{
		get
		{
			return _SQLColumaID;
		}
		set
		{
			_SQLColumaID = value;
		}
	}

	private DataGridView LIsta
	{
		[DebuggerNonUserCode]
		get
		{
			return _LIsta;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = LIsta_LostFocus;
			KeyEventHandler value3 = LIsta_KeyDown;
			EventHandler value4 = LIsta_DoubleClick;
			if (_LIsta != null)
			{
				_LIsta.LostFocus -= value2;
				_LIsta.KeyDown -= value3;
				_LIsta.DoubleClick -= value4;
			}
			_LIsta = value;
			if (_LIsta != null)
			{
				_LIsta.LostFocus += value2;
				_LIsta.KeyDown += value3;
				_LIsta.DoubleClick += value4;
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event SeleccionChangedEventHandler SeleccionChanged;

	[method: DebuggerNonUserCode]
	public event BorderChangedEventHandler BorderChanged;

	[method: DebuggerNonUserCode]
	public event SeleccionEnterEventHandler SeleccionEnter;

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
		base.OnLostFocus(e);
		IamON = false;
		Invalidate();
	}

	protected override void OnGotFocus(EventArgs e)
	{
		base.OnGotFocus(e);
		IamON = true;
		Invalidate();
	}

	protected override void OnClick(EventArgs e)
	{
		base.OnClick(e);
		_ = LIsta;
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		if (e.KeyValue == 27 && LIsta != null)
		{
			LIsta.Visible = false;
			LIsta = null;
		}
		base.OnKeyUp(e);
	}

	protected override void OnMouseHover(EventArgs e)
	{
		base.OnMouseHover(e);
		IamON = true;
		Invalidate();
	}

	protected override void WndProc(ref Message m)
	{
		base.WndProc(ref m);
		checked
		{
			if (m.Msg == 15)
			{
				Graphics g = CreateGraphics();
				Rectangle cliente = ClientRectangle;
				if (IamON)
				{
					_BorderColor = _ActiveBorderColor;
				}
				else
				{
					_BorderColor = _InactiveBorderColor;
				}
				if (BorderStyle != BorderStyle.Fixed3D)
				{
					g.DrawRectangle(new Pen(_BorderColor), 0, 0, cliente.Width - 1, cliente.Height - 1);
					g.Dispose();
				}
				BorderChanged?.Invoke(this, new FlatBoxEventArgs(_BorderColor, IamON));
			}
		}
	}

	public ucListData()
	{
		base.LostFocus += ucListData_LostFocus;
		_ActiveBorderColor = SystemColors.ControlDarkDark;
		_InactiveBorderColor = SystemColors.ControlDark;
		_ListaWidth = 185;
		_FilaValor = null;
		fueEnter = false;
		SQLConexion = null;
		SQLFiltro = null;
		SQLQuery = null;
		SQLColumnaID = null;
	}

	public new void Show()
	{
		OnTextChanged(null);
	}

	public new void Hide()
	{
		VerLista(vbVer: false);
	}

	public DataGridViewRow SeleccionarFila(string Valor)
	{
		if (SQLQuery == null)
		{
			return null;
		}
		if (SQLConexion == null)
		{
			return null;
		}
		if (SQLConexion.State == ConnectionState.Closed)
		{
			SQLConexion.Open();
		}
		string vSQL = SQLQuery;
		if (vSQL.Trim().Length == 0)
		{
			return null;
		}
		if (SQLColumnaID == null)
		{
			return null;
		}
		vSQL = ((Strings.InStr(vSQL, "WHERE", CompareMethod.Text) <= 0) ? (vSQL + " WHERE " + SQLColumnaID + " = '" + Valor + "'") : (vSQL + "  AND " + SQLColumnaID + " = '" + Valor + "'"));
		SqlDataAdapter da = new SqlDataAdapter(vSQL, SQLConexion);
		DataTable Dt = new DataTable();
		da.Fill(Dt);
		da.Dispose();
		da = null;
		_SQLConexion.Close();
		checked
		{
			if (Dt.Rows.Count > 0)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				int num = Dt.Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
					dataGridViewTextBoxCell.Value = RuntimeHelpers.GetObjectValue(Dt.Rows[0][i]);
					dataGridViewRow.Cells.Add(dataGridViewTextBoxCell);
				}
				Text = Conversions.ToString(Dt.Rows[0][1]);
				_FilaSeleccionada = dataGridViewRow;
				_FilaValor = _FilaSeleccionada.Cells[0].Value.ToString().Trim();
				SeleccionChanged?.Invoke();
				VerLista(vbVer: false);
				Focus();
				return dataGridViewRow;
			}
			MessageBox.Show("No se encontró el Registro " + Valor, "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			Clear();
			return null;
		}
	}

	protected override void OnPrint(PaintEventArgs e)
	{
		base.OnPrint(e);
	}

	protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
	{
		base.OnPreviewKeyDown(e);
	}

	protected override void OnLayout(LayoutEventArgs levent)
	{
		_ = !DesignMode & (Parent != null);
		base.OnLayout(levent);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
	}

	protected override void OnLeave(EventArgs e)
	{
		if (LIsta != null && LIsta.Focused)
		{
			base.OnLeave(e);
			return;
		}
		VerLista(vbVer: false);
		base.OnLeave(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e.KeyValue == 13)
		{
			if (LIsta != null && LIsta.Visible && LIsta.CurrentRow != null)
			{
				_FilaSeleccionada = LIsta.CurrentRow;
				_FilaValor = _FilaSeleccionada.Cells[SQLColumnaID].Value.ToString().Trim();
				string buscar = "";
				if (Text.Trim().Length == 0)
				{
					fueEnter = true;
					Text = LIsta.CurrentRow.Cells[1].Value.ToString().Trim();
					SeleccionEnter?.Invoke();
				}
				else
				{
					Text = LIsta.CurrentRow.Cells[1].Value.ToString().Trim();
					SeleccionChanged?.Invoke();
				}
				VerLista(vbVer: false);
			}
			else
			{
				SendKeys.Send("{TAB}");
			}
		}
		if (e.KeyValue == 27)
		{
			VerLista(vbVer: false);
		}
		if (e.KeyValue == 40 && LIsta != null && LIsta.Visible)
		{
			LIsta.Focus();
			if (LIsta == null)
			{
				return;
			}
			if (LIsta.RowCount > 1)
			{
				LIsta.CurrentCell = LIsta.Rows[1].Cells[1];
			}
		}
		base.OnKeyDown(e);
	}

	public new void Clear()
	{
		Text = "";
		VerLista(vbVer: false);
	}

	protected override void OnTextChanged(EventArgs e)
	{
		if (Text.Trim().Length == 0)
		{
			VerLista(vbVer: false);
			base.OnTextChanged(e);
		}
		else if (fueEnter)
		{
			fueEnter = false;
		}
		else
		{
			if ((SQLQuery == null) | (SQLConexion == null) | (SQLFiltro == null))
			{
				return;
			}
			if (SQLConexion.State == ConnectionState.Closed)
			{
				SQLConexion.Open();
			}
			string vSQL = SQLQuery;
			if (vSQL.Trim().Length == 0)
			{
				return;
			}
			vSQL = ((Strings.InStr(vSQL, "WHERE", CompareMethod.Text) <= 0) ? (vSQL + " WHERE " + SQLFiltro + " LIKE '" + Text.Trim() + "%'") : (vSQL + "  AND " + SQLFiltro + " LIKE '" + Text.Trim() + "%'"));
			SqlDataAdapter da = new SqlDataAdapter(vSQL, SQLConexion);
			DataTable Dt = new DataTable();
			da.Fill(Dt);
			da.Dispose();
			da = null;
			_SQLConexion.Close();
			if (LIsta == null && Dt.Rows.Count > 0)
			{
				VerLista(vbVer: true);
			}
			if (LIsta == null)
			{
				return;
			}
			LIsta.AutoGenerateColumns = true;
			LIsta.DataSource = Dt;
			LIsta.ColumnHeadersVisible = false;
			foreach (DataGridViewColumn Col in LIsta.Columns)
			{
				if (Col.Index == 0)
				{
					Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
				}
				else if (Col.Index == 1)
				{
					Col.Width = checked(LIsta.Width - 40);
					LIsta.ScrollBars = ScrollBars.Vertical;
				}
				else
				{
					Col.Visible = false;
				}
			}
			if ((LIsta.RowCount > 0) & vbVerlista)
			{
				if (_FilaValor == null || _FilaValor.Trim().Length == 0)
				{
					LIsta.CurrentCell = LIsta.Rows[0].Cells[0];
				}
				else
				{
					foreach (DataGridViewRow row in (IEnumerable)LIsta.Rows)
					{
						if (Operators.CompareString(row.Cells[SQLColumnaID].Value.ToString().Trim().ToUpper(), Text.Trim().ToUpper(), TextCompare: false) == 0)
						{
							LIsta.CurrentCell = row.Cells[0];
							break;
						}
					}
				}
			}
			else
			{
				VerLista(vbVer: false);
			}
			base.OnTextChanged(e);
		}
	}

	public void VerLista(bool vbVer, bool boton = false)
	{
		vbVerlista = vbVer;
		checked
		{
			if (vbVer)
			{
				if (LIsta != null)
				{
					LIsta.Visible = false;
					LIsta = null;
				}
				LIsta = new DataGridView();
				LIsta.Visible = true;
				TemplateLista();
				Size size2;
				if (_ListaWidth != 0)
				{
					size2 = (LIsta.Size = new Size(_ListaWidth, Bounds.Height + 60));
				}
				else
				{
					DataGridView lIsta = LIsta;
					size2 = new Size(Bounds.Width, Bounds.Height + 60);
					lIsta.Size = size2;
				}
				LIsta.BorderStyle = BorderStyle;
				LIsta.BackgroundColor = Color.White;
				try
				{
					Contenedor conten = Formcontenedor(this, Left, Height);
					Control control = conten.Control;
					DataGridView lIsta2 = LIsta;
					Point location = new Point(conten.Left, conten.Top);
					lIsta2.Location = location;
					control.Controls.Add(LIsta);
					LIsta.BringToFront();
					OnTextChanged(null);
					if (boton)
					{
						LIsta.Focus();
					}
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					return;
				}
			}
			if (LIsta != null)
			{
				LIsta.Visible = false;
				LIsta = null;
			}
		}
	}

	public Contenedor Formcontenedor(Control Control, int Left, int Top)
	{
		if (!Control.Parent.GetType().Name.Contains("frm") & !Control.Parent.GetType().Name.Contains("Frm"))
		{
			return checked(Formcontenedor(Control.Parent, Left + Control.Parent.Left, Top + Control.Parent.Top));
		}
		Contenedor c = default(Contenedor);
		c.Control = Control.Parent;
		c.Left = Left;
		c.Top = Top;
		return c;
	}

	private void TemplateLista()
	{
		((ISupportInitialize)LIsta).BeginInit();
		SuspendLayout();
		DataGridViewCellStyle DataGridViewCellStyle1 = new DataGridViewCellStyle();
		DataGridViewCellStyle DataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle DataGridViewCellStyle3 = new DataGridViewCellStyle();
		DataGridViewCellStyle DataGridViewCellStyle4 = new DataGridViewCellStyle();
		LIsta.AllowUserToAddRows = false;
		LIsta.AllowUserToDeleteRows = false;
		LIsta.AllowUserToResizeColumns = false;
		LIsta.AllowUserToResizeRows = false;
		LIsta.BackgroundColor = SystemColors.ButtonHighlight;
		LIsta.BorderStyle = BorderStyle.FixedSingle;
		LIsta.CellBorderStyle = DataGridViewCellBorderStyle.None;
		LIsta.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
		LIsta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
		DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
		DataGridViewCellStyle1.BackColor = SystemColors.ActiveBorder;
		DataGridViewCellStyle1.Font = new Font("Verdana", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		DataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
		DataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
		DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
		DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
		LIsta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
		LIsta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		LIsta.EnableHeadersVisualStyles = false;
		LIsta.GridColor = SystemColors.ControlLight;
		DataGridView lIsta = LIsta;
		Point location = new Point(23, 188);
		lIsta.Location = location;
		LIsta.MultiSelect = false;
		LIsta.Name = "Lista";
		LIsta.ReadOnly = true;
		LIsta.RowHeadersVisible = false;
		LIsta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
		LIsta.RowsDefaultCellStyle = DataGridViewCellStyle2;
		LIsta.RowTemplate.Height = 15;
		LIsta.RowTemplate.ReadOnly = true;
		LIsta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		DataGridView lIsta2 = LIsta;
		Size size = new Size(376, 92);
		lIsta2.Size = size;
		((ISupportInitialize)LIsta).EndInit();
		ResumeLayout();
	}

	protected virtual void Finalize()
	{
		base.Finalize();
	}

	private void LIsta_DoubleClick(object sender, EventArgs e)
	{
		try
		{
			if (LIsta != null && LIsta.Visible && LIsta.CurrentRow != null)
			{
				Text = LIsta.CurrentRow.Cells[SQLColumnaID].Value.ToString();
				SelectionLength = 0;
				SelectionStart = Text.Length;
				_FilaSeleccionada = LIsta.CurrentRow;
				_FilaValor = _FilaSeleccionada.Cells[SQLColumnaID].Value.ToString().Trim();
				SeleccionChanged?.Invoke();
				Focus();
				VerLista(vbVer: false);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void LIsta_KeyDown(object sender, KeyEventArgs e)
	{
		try
		{
			if (e.KeyValue == 13 && LIsta != null && LIsta.Visible && LIsta.CurrentRow != null)
			{
				Text = LIsta.CurrentRow.Cells[1].Value.ToString();
				SelectionLength = 0;
				SelectionStart = Text.Length;
				_FilaSeleccionada = LIsta.CurrentRow;
				_FilaValor = _FilaSeleccionada.Cells[SQLColumnaID].Value.ToString().Trim();
				SeleccionChanged?.Invoke();
				Focus();
				VerLista(vbVer: false);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void LIsta_LostFocus(object sender, EventArgs e)
	{
		if (LIsta != null)
		{
			LIsta.Visible = false;
			LIsta = null;
		}
	}

	private void ucListData_LostFocus(object sender, EventArgs e)
	{
		if (LIsta != null && !LIsta.Focused && LIsta != null)
		{
			LIsta.Visible = false;
			LIsta = null;
		}
	}
}
