using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DefaultEvent("onSeleccionar")]
[DesignerGenerated]
public class ucBuscaDato : UserControl
{
	public delegate void onSeleccionarEventHandler();

	public delegate void onBotonBuscarEventHandler();

	public struct Contenedor
	{
		public Control Control;

		public int Left;

		public int Top;
	}

	private IContainer components;

	[AccessedThroughProperty("Texto")]
	private ucTextBox _Texto;

	[AccessedThroughProperty("frabotones")]
	private Panel _frabotones;

	[AccessedThroughProperty("btndown")]
	private Button _btndown;

	[AccessedThroughProperty("btn")]
	private Button _btn;

	[AccessedThroughProperty("FraTop")]
	private Panel _FraTop;

	[AccessedThroughProperty("lvw")]
	private DataGridView _lvw;

	private DataTable _dt;

	private string _CampoFillStr;

	private string _CampoFillInt;

	private bool _IsNumeric;

	private DataView dv;

	public DataRowView _Dato;

	private bool _verbtn;

	private int _WidthLvw;

	private bool _IsKeyDown;

	internal ucTextBox Texto
	{
		[DebuggerNonUserCode]
		get
		{
			return _Texto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = Texto_TextChanged;
			ucTextBox.onESCAPEEventHandler obj = Texto_onESCAPE;
			KeyEventHandler value3 = Texto_KeyDown;
			if (_Texto != null)
			{
				_Texto.TextChanged -= value2;
				_Texto.onESCAPE -= obj;
				_Texto.KeyDown -= value3;
			}
			_Texto = value;
			if (_Texto != null)
			{
				_Texto.TextChanged += value2;
				_Texto.onESCAPE += obj;
				_Texto.KeyDown += value3;
			}
		}
	}

	internal Panel frabotones
	{
		[DebuggerNonUserCode]
		get
		{
			return _frabotones;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_frabotones = value;
		}
	}

	internal Button btndown
	{
		[DebuggerNonUserCode]
		get
		{
			return _btndown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			KeyEventHandler value2 = btndown_KeyDown;
			EventHandler value3 = btndown_Click;
			if (_btndown != null)
			{
				_btndown.KeyDown -= value2;
				_btndown.Click -= value3;
			}
			_btndown = value;
			if (_btndown != null)
			{
				_btndown.KeyDown += value2;
				_btndown.Click += value3;
			}
		}
	}

	internal Button btn
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			KeyEventHandler value2 = btn_KeyDown;
			EventHandler value3 = btn_Click;
			if (_btn != null)
			{
				_btn.KeyDown -= value2;
				_btn.Click -= value3;
			}
			_btn = value;
			if (_btn != null)
			{
				_btn.KeyDown += value2;
				_btn.Click += value3;
			}
		}
	}

	internal Panel FraTop
	{
		[DebuggerNonUserCode]
		get
		{
			return _FraTop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FraTop = value;
		}
	}

	private DataGridView lvw
	{
		[DebuggerNonUserCode]
		get
		{
			return _lvw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = lvw_DoubleClick;
			KeyEventHandler value3 = lvw_KeyDown;
			if (_lvw != null)
			{
				_lvw.DoubleClick -= value2;
				_lvw.KeyDown -= value3;
			}
			_lvw = value;
			if (_lvw != null)
			{
				_lvw.DoubleClick += value2;
				_lvw.KeyDown += value3;
			}
		}
	}

	public DataTable Dt
	{
		get
		{
			return _dt;
		}
		set
		{
			_dt = value;
		}
	}

	public bool IsNumeric
	{
		get
		{
			return _IsNumeric;
		}
		set
		{
			_IsNumeric = value;
		}
	}

	public string CampoFillInt
	{
		get
		{
			return _CampoFillInt;
		}
		set
		{
			_CampoFillInt = value.Trim();
		}
	}

	public string CampoFillStr
	{
		get
		{
			return _CampoFillStr;
		}
		set
		{
			_CampoFillStr = value.Trim();
		}
	}

	public bool Verbtn
	{
		get
		{
			return _verbtn;
		}
		set
		{
			_verbtn = value;
			btn.Visible = value;
			ReuvicaCtrls();
		}
	}

	public int WidthLvw
	{
		get
		{
			return _WidthLvw;
		}
		set
		{
			_WidthLvw = value;
			if (_WidthLvw < 50)
			{
				_WidthLvw = 50;
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event onSeleccionarEventHandler onSeleccionar;

	[method: DebuggerNonUserCode]
	public event onBotonBuscarEventHandler onBotonBuscar;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRLL.Common.ucBuscaDato));
		this.frabotones = new System.Windows.Forms.Panel();
		this.btn = new System.Windows.Forms.Button();
		this.btndown = new System.Windows.Forms.Button();
		this.FraTop = new System.Windows.Forms.Panel();
		this.Texto = new GRLL.Common.ucTextBox(this.components);
		this.frabotones.SuspendLayout();
		this.FraTop.SuspendLayout();
		this.SuspendLayout();
		this.frabotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.frabotones.Controls.Add(this.btn);
		this.frabotones.Controls.Add(this.btndown);
		this.frabotones.Dock = System.Windows.Forms.DockStyle.Right;
		System.Windows.Forms.Panel panel = this.frabotones;
		System.Drawing.Point location = new System.Drawing.Point(164, 0);
		panel.Location = location;
		this.frabotones.Name = "frabotones";
		System.Windows.Forms.Panel panel2 = this.frabotones;
		System.Drawing.Size size = new System.Drawing.Size(40, 22);
		panel2.Size = size;
		this.frabotones.TabIndex = 28;
		this.btn.BackColor = System.Drawing.SystemColors.Control;
		this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		System.Windows.Forms.Button button = this.btn;
		location = new System.Drawing.Point(20, 0);
		button.Location = location;
		this.btn.Name = "btn";
		System.Windows.Forms.Button button2 = this.btn;
		size = new System.Drawing.Size(18, 20);
		button2.Size = size;
		this.btn.TabIndex = 1;
		this.btn.TabStop = false;
		this.btn.Text = "...";
		this.btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.btn.UseVisualStyleBackColor = false;
		this.btndown.BackColor = System.Drawing.SystemColors.Control;
		this.btndown.Dock = System.Windows.Forms.DockStyle.Left;
		this.btndown.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btndown.Image = (System.Drawing.Image)resources.GetObject("btndown.Image");
		System.Windows.Forms.Button button3 = this.btndown;
		location = new System.Drawing.Point(0, 0);
		button3.Location = location;
		this.btndown.Name = "btndown";
		System.Windows.Forms.Button button4 = this.btndown;
		size = new System.Drawing.Size(20, 20);
		button4.Size = size;
		this.btndown.TabIndex = 0;
		this.btndown.TabStop = false;
		this.btndown.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.btndown.UseVisualStyleBackColor = false;
		this.FraTop.Controls.Add(this.Texto);
		this.FraTop.Controls.Add(this.frabotones);
		this.FraTop.Dock = System.Windows.Forms.DockStyle.Top;
		System.Windows.Forms.Panel fraTop = this.FraTop;
		location = new System.Drawing.Point(0, 0);
		fraTop.Location = location;
		this.FraTop.Name = "FraTop";
		System.Windows.Forms.Panel fraTop2 = this.FraTop;
		size = new System.Drawing.Size(204, 22);
		fraTop2.Size = size;
		this.FraTop.TabIndex = 0;
		this.Texto.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.Texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Texto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.Texto.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Texto.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Texto.Formato = null;
		this.Texto.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox texto = this.Texto;
		location = new System.Drawing.Point(0, 0);
		texto.Location = location;
		this.Texto.MaxLength = 120;
		this.Texto.Name = "Texto";
		this.Texto.NormalColor = System.Drawing.SystemColors.Window;
		this.Texto.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.Texto.OnErrorBlankText = "Debe ingresar la descripción";
		this.Texto.PadLeftLenght = 0;
		this.Texto.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.Texto.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox texto2 = this.Texto;
		size = new System.Drawing.Size(164, 22);
		texto2.Size = size;
		this.Texto.TabIndex = 0;
		this.Texto.TabNextControl = false;
		this.Texto.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.Controls.Add(this.FraTop);
		this.Name = "ucBuscaDato";
		size = new System.Drawing.Size(204, 110);
		this.Size = size;
		this.frabotones.ResumeLayout(false);
		this.FraTop.ResumeLayout(false);
		this.FraTop.PerformLayout();
		this.ResumeLayout(false);
	}

	public ucBuscaDato()
	{
		base.Resize += ucBuscaAuto_Resize;
		base.Validated += ucBuscaProducto_Validated;
		_IsNumeric = false;
		_Dato = null;
		_verbtn = false;
		_WidthLvw = 50;
		_IsKeyDown = false;
		InitializeComponent();
	}

	private void ucBuscaAuto_Resize(object sender, EventArgs e)
	{
		try
		{
			if (!DesignMode)
			{
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void btndown_Click(object sender, EventArgs e)
	{
		if (Texto.Text.Trim().Length != 0)
		{
			if (dv.Count > 0)
			{
				VerLista(vbVer: true);
			}
			else
			{
				VerLista(vbVer: false);
			}
		}
	}

	private void VerLista(bool vbVer)
	{
		checked
		{
			if (vbVer)
			{
				if (lvw != null)
				{
					lvw.Visible = false;
					lvw = null;
				}
				lvw = new DataGridView();
				lvw.Visible = true;
				FormatLVw();
				_WidthLvw = 350;
				Size size2;
				if (_WidthLvw != 0)
				{
					size2 = (lvw.Size = new Size(_WidthLvw, Bounds.Height + 60));
				}
				else
				{
					DataGridView dataGridView = lvw;
					size2 = new Size(Bounds.Width, Bounds.Height + 60);
					dataGridView.Size = size2;
				}
				lvw.BorderStyle = BorderStyle;
				lvw.BackgroundColor = Color.White;
				lvw.DataSource = dv;
				try
				{
					Contenedor conten = Formcontenedor(this, Left, Height + 10);
					Control control = conten.Control;
					DataGridView dataGridView2 = lvw;
					Point location = new Point(conten.Left, conten.Top);
					dataGridView2.Location = location;
					control.Controls.Add(lvw);
					lvw.BringToFront();
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
			if (lvw != null)
			{
				lvw.Visible = false;
				lvw = null;
			}
		}
	}

	private void FormatLVw()
	{
		lvw.AllowUserToAddRows = false;
		lvw.AllowUserToDeleteRows = false;
		lvw.AllowUserToOrderColumns = true;
		lvw.AllowUserToResizeColumns = false;
		lvw.AllowUserToResizeRows = false;
		lvw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		lvw.AutoGenerateColumns = true;
		lvw.BackgroundColor = SystemColors.ActiveCaptionText;
		lvw.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
		lvw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		lvw.ColumnHeadersVisible = false;
		DataGridViewCellStyle DataGridViewCellStyle1 = new DataGridViewCellStyle();
		DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
		DataGridViewCellStyle1.BackColor = SystemColors.Window;
		DataGridViewCellStyle1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		DataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
		DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 0, 192);
		DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
		DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
		lvw.DefaultCellStyle = DataGridViewCellStyle1;
		lvw.Dock = DockStyle.None;
		lvw.EnableHeadersVisualStyles = false;
		DataGridView dataGridView = lvw;
		Point location = new Point(0, 22);
		dataGridView.Location = location;
		lvw.MultiSelect = false;
		lvw.Name = "lvw";
		lvw.ReadOnly = true;
		lvw.RowHeadersVisible = false;
		lvw.ScrollBars = ScrollBars.Both;
		lvw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
	}

	public Contenedor Formcontenedor(Control Control, int Left, int Top)
	{
		if (!Control.Parent.GetType().Name.ToUpper().Contains("FRM"))
		{
			return checked(Formcontenedor(Control.Parent, Left + Control.Parent.Left, Top + Control.Parent.Top));
		}
		Contenedor c = default(Contenedor);
		c.Control = Control.Parent;
		c.Left = Left;
		c.Top = Top;
		return c;
	}

	private void Texto_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 40 && lvw != null && lvw.Visible)
		{
			_IsKeyDown = true;
			lvw_KeyDown(lvw, e);
			lvw.Focus();
			_IsKeyDown = false;
			if (lvw.RowCount > 1 && lvw.CurrentCell == null)
			{
				lvw.CurrentCell = lvw.Rows[0].Cells[0];
			}
		}
		if (e.KeyValue == 13 && lvw != null && lvw.Visible)
		{
			lvw_KeyDown(null, e);
		}
		if (e.KeyValue == 27)
		{
			VerLista(vbVer: false);
		}
	}

	private void Texto_onESCAPE()
	{
		if (_Dato == null)
		{
			Texto.Clear();
			return;
		}
		Texto.Text = Conversions.ToString(_Dato[_CampoFillStr]);
		Texto.SelectionStart = Texto.Text.Length;
		VerLista(vbVer: false);
	}

	private void Texto_TextChanged(object sender, EventArgs e)
	{
		if (Texto.Text.Trim().Length == 0)
		{
			VerLista(vbVer: false);
			return;
		}
		dv = Dt.DefaultView;
		if (_IsNumeric)
		{
			dv.RowFilter = _CampoFillInt + " = " + Texto.Text;
		}
		else
		{
			dv.RowFilter = _CampoFillStr + " LIKE '%" + Texto.Text + "%'";
		}
		if (dv.Count > 0)
		{
			VerLista(vbVer: true);
		}
		else
		{
			VerLista(vbVer: false);
		}
	}

	public void BuscarStr(string DatoBusca, string sNewCampo = "")
	{
		Clear();
		dv = Dt.DefaultView;
		sNewCampo = Conversions.ToString(Interaction.IIf(Operators.CompareString(sNewCampo.Trim(), "", TextCompare: false) == 0, _CampoFillStr, sNewCampo));
		dv.RowFilter = sNewCampo + " LIKE '%" + DatoBusca + "%'";
		if (dv.Count > 0)
		{
			VerLista(vbVer: true);
			if (lvw.RowCount > 0)
			{
				lvw.CurrentCell = lvw.Rows[0].Cells[0];
				Seleccionar();
			}
		}
		else
		{
			VerLista(vbVer: false);
		}
	}

	public void BuscarInt(int DatoBusca, string sNewCampo = "")
	{
		Clear();
		dv = Dt.DefaultView;
		sNewCampo = Conversions.ToString(Interaction.IIf(Operators.CompareString(sNewCampo.Trim(), "", TextCompare: false) == 0, _CampoFillStr, sNewCampo));
		dv.RowFilter = sNewCampo + " = " + Conversions.ToString(DatoBusca);
		if (dv.Count > 0)
		{
			VerLista(vbVer: true);
			if (lvw.RowCount > 0)
			{
				lvw.CurrentCell = lvw.Rows[0].Cells[0];
				Seleccionar();
			}
		}
		else
		{
			VerLista(vbVer: false);
		}
	}

	private void lvw_DoubleClick(object sender, EventArgs e)
	{
		if (lvw.Rows.Count != 0 && lvw.CurrentRow != null && lvw.Visible)
		{
			Seleccionar();
		}
	}

	private void lvw_KeyDown(object sender, KeyEventArgs e)
	{
		if (lvw.Rows.Count != 0 && lvw.CurrentRow != null)
		{
			if (e.KeyValue == 13)
			{
				Seleccionar();
			}
			else
			{
				lvw.Focus();
			}
		}
	}

	private void Seleccionar()
	{
		DataView LIsta = new DataView();
		LIsta = (DataView)lvw.DataSource;
		_Dato = LIsta[lvw.CurrentRow.Index];
		Texto.Text = Conversions.ToString(_Dato[_CampoFillStr]);
		onSeleccionar?.Invoke();
		VerLista(vbVer: false);
	}

	private void btn_Click(object sender, EventArgs e)
	{
		onBotonBuscar?.Invoke();
	}

	private void ucBuscaProducto_Validated(object sender, EventArgs e)
	{
	}

	private void btndown_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 27)
		{
			Texto_onESCAPE();
		}
	}

	private void btn_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 27)
		{
			Texto_onESCAPE();
		}
	}

	public void Clear()
	{
		Texto.Clear();
		if (lvw != null)
		{
			lvw.DataSource = null;
		}
		_Dato = null;
	}

	private void ReuvicaCtrls()
	{
		if (_verbtn)
		{
			frabotones.Width = 40;
		}
		else
		{
			frabotones.Width = 20;
		}
	}
}
