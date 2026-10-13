using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class FrmMaestro : frmBase
{
	public enum Tipo
	{
		Simple,
		SeleccionEditable,
		Seleccion
	}

	private IContainer components;

	[AccessedThroughProperty("BtnImprimir")]
	private Button _BtnImprimir;

	[AccessedThroughProperty("Fra_botones")]
	private Panel _Fra_botones;

	[AccessedThroughProperty("btn_cerrar")]
	private Button _btn_cerrar;

	[AccessedThroughProperty("btn_guardar")]
	private Button _btn_guardar;

	[AccessedThroughProperty("btn_cancelar")]
	private Button _btn_cancelar;

	[AccessedThroughProperty("btn_eliminar")]
	private Button _btn_eliminar;

	[AccessedThroughProperty("btn_editar")]
	private Button _btn_editar;

	[AccessedThroughProperty("btn_nuevo")]
	private Button _btn_nuevo;

	[AccessedThroughProperty("btn_cargar")]
	private Button _btn_cargar;

	[AccessedThroughProperty("Tab")]
	private TabControl _Tab;

	[AccessedThroughProperty("TabLista")]
	private TabPage _TabLista;

	[AccessedThroughProperty("TabEdicion")]
	private TabPage _TabEdicion;

	[AccessedThroughProperty("btn_imprimir")]
	private Button _btn_imprimir;

	[AccessedThroughProperty("Fra_Filtro")]
	private Panel _Fra_Filtro;

	[AccessedThroughProperty("txtFiltro")]
	private ucText _txtFiltro;

	[AccessedThroughProperty("CboFiltro")]
	private ComboBox _CboFiltro;

	[AccessedThroughProperty("lbl_titulo")]
	private ucLabel _lbl_titulo;

	[AccessedThroughProperty("lbl_titulo1")]
	private Label _lbl_titulo1;

	[AccessedThroughProperty("btn_sel")]
	private Button _btn_sel;

	protected bool EsNuevo;

	private Tipo _TipoMaestro;

	private bool arriba;

	internal Button BtnImprimir
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnImprimir;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BtnImprimir = value;
		}
	}

	protected virtual Panel Fra_botones
	{
		[DebuggerNonUserCode]
		get
		{
			return _Fra_botones;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Fra_botones = value;
		}
	}

	protected virtual Button btn_cerrar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_cerrar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			MouseEventHandler value2 = btn_sel_MouseUp;
			MouseEventHandler value3 = btn_sel_MouseDown;
			EventHandler value4 = btn_cerrar_Click;
			EventHandler value5 = btn_sel_MouseEnter;
			EventHandler value6 = btn_sel_MouseLeave;
			if (_btn_cerrar != null)
			{
				_btn_cerrar.MouseUp -= value2;
				_btn_cerrar.MouseDown -= value3;
				_btn_cerrar.Click -= value4;
				_btn_cerrar.MouseEnter -= value5;
				_btn_cerrar.MouseLeave -= value6;
			}
			_btn_cerrar = value;
			if (_btn_cerrar != null)
			{
				_btn_cerrar.MouseUp += value2;
				_btn_cerrar.MouseDown += value3;
				_btn_cerrar.Click += value4;
				_btn_cerrar.MouseEnter += value5;
				_btn_cerrar.MouseLeave += value6;
			}
		}
	}

	protected virtual Button btn_guardar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_guardar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			MouseEventHandler value2 = btn_sel_MouseUp;
			MouseEventHandler value3 = btn_sel_MouseDown;
			EventHandler value4 = btn_guardar_Click;
			EventHandler value5 = btn_sel_MouseEnter;
			EventHandler value6 = btn_sel_MouseLeave;
			if (_btn_guardar != null)
			{
				_btn_guardar.MouseUp -= value2;
				_btn_guardar.MouseDown -= value3;
				_btn_guardar.Click -= value4;
				_btn_guardar.MouseEnter -= value5;
				_btn_guardar.MouseLeave -= value6;
			}
			_btn_guardar = value;
			if (_btn_guardar != null)
			{
				_btn_guardar.MouseUp += value2;
				_btn_guardar.MouseDown += value3;
				_btn_guardar.Click += value4;
				_btn_guardar.MouseEnter += value5;
				_btn_guardar.MouseLeave += value6;
			}
		}
	}

	protected virtual Button btn_cancelar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_cancelar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			MouseEventHandler value2 = btn_sel_MouseUp;
			MouseEventHandler value3 = btn_sel_MouseDown;
			EventHandler value4 = btn_sel_MouseEnter;
			EventHandler value5 = btn_sel_MouseLeave;
			if (_btn_cancelar != null)
			{
				_btn_cancelar.MouseUp -= value2;
				_btn_cancelar.MouseDown -= value3;
				_btn_cancelar.MouseEnter -= value4;
				_btn_cancelar.MouseLeave -= value5;
			}
			_btn_cancelar = value;
			if (_btn_cancelar != null)
			{
				_btn_cancelar.MouseUp += value2;
				_btn_cancelar.MouseDown += value3;
				_btn_cancelar.MouseEnter += value4;
				_btn_cancelar.MouseLeave += value5;
			}
		}
	}

	protected virtual Button btn_eliminar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_eliminar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			MouseEventHandler value2 = btn_sel_MouseUp;
			MouseEventHandler value3 = btn_sel_MouseDown;
			EventHandler value4 = btn_sel_MouseEnter;
			EventHandler value5 = btn_sel_MouseLeave;
			if (_btn_eliminar != null)
			{
				_btn_eliminar.MouseUp -= value2;
				_btn_eliminar.MouseDown -= value3;
				_btn_eliminar.MouseEnter -= value4;
				_btn_eliminar.MouseLeave -= value5;
			}
			_btn_eliminar = value;
			if (_btn_eliminar != null)
			{
				_btn_eliminar.MouseUp += value2;
				_btn_eliminar.MouseDown += value3;
				_btn_eliminar.MouseEnter += value4;
				_btn_eliminar.MouseLeave += value5;
			}
		}
	}

	protected virtual Button btn_editar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_editar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			MouseEventHandler value2 = btn_sel_MouseUp;
			MouseEventHandler value3 = btn_sel_MouseDown;
			EventHandler value4 = btn_editar_Click;
			EventHandler value5 = btn_sel_MouseEnter;
			EventHandler value6 = btn_sel_MouseLeave;
			if (_btn_editar != null)
			{
				_btn_editar.MouseUp -= value2;
				_btn_editar.MouseDown -= value3;
				_btn_editar.Click -= value4;
				_btn_editar.MouseEnter -= value5;
				_btn_editar.MouseLeave -= value6;
			}
			_btn_editar = value;
			if (_btn_editar != null)
			{
				_btn_editar.MouseUp += value2;
				_btn_editar.MouseDown += value3;
				_btn_editar.Click += value4;
				_btn_editar.MouseEnter += value5;
				_btn_editar.MouseLeave += value6;
			}
		}
	}

	protected virtual Button btn_nuevo
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_nuevo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			MouseEventHandler value2 = btn_sel_MouseUp;
			MouseEventHandler value3 = btn_sel_MouseDown;
			EventHandler value4 = btn_nuevo_Click;
			EventHandler value5 = btn_sel_MouseEnter;
			EventHandler value6 = btn_sel_MouseLeave;
			if (_btn_nuevo != null)
			{
				_btn_nuevo.MouseUp -= value2;
				_btn_nuevo.MouseDown -= value3;
				_btn_nuevo.Click -= value4;
				_btn_nuevo.MouseEnter -= value5;
				_btn_nuevo.MouseLeave -= value6;
			}
			_btn_nuevo = value;
			if (_btn_nuevo != null)
			{
				_btn_nuevo.MouseUp += value2;
				_btn_nuevo.MouseDown += value3;
				_btn_nuevo.Click += value4;
				_btn_nuevo.MouseEnter += value5;
				_btn_nuevo.MouseLeave += value6;
			}
		}
	}

	protected virtual Button btn_cargar
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_cargar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			MouseEventHandler value2 = btn_sel_MouseUp;
			MouseEventHandler value3 = btn_sel_MouseDown;
			EventHandler value4 = btn_sel_MouseEnter;
			EventHandler value5 = btn_sel_MouseLeave;
			if (_btn_cargar != null)
			{
				_btn_cargar.MouseUp -= value2;
				_btn_cargar.MouseDown -= value3;
				_btn_cargar.MouseEnter -= value4;
				_btn_cargar.MouseLeave -= value5;
			}
			_btn_cargar = value;
			if (_btn_cargar != null)
			{
				_btn_cargar.MouseUp += value2;
				_btn_cargar.MouseDown += value3;
				_btn_cargar.MouseEnter += value4;
				_btn_cargar.MouseLeave += value5;
			}
		}
	}

	protected virtual TabControl Tab
	{
		[DebuggerNonUserCode]
		get
		{
			return _Tab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Tab = value;
		}
	}

	protected virtual TabPage TabLista
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabLista;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabLista = value;
		}
	}

	protected virtual TabPage TabEdicion
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabEdicion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabEdicion = value;
		}
	}

	protected virtual Button btn_imprimir
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_imprimir;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			MouseEventHandler value2 = btn_sel_MouseUp;
			MouseEventHandler value3 = btn_sel_MouseDown;
			EventHandler value4 = btn_sel_MouseEnter;
			EventHandler value5 = btn_sel_MouseLeave;
			if (_btn_imprimir != null)
			{
				_btn_imprimir.MouseUp -= value2;
				_btn_imprimir.MouseDown -= value3;
				_btn_imprimir.MouseEnter -= value4;
				_btn_imprimir.MouseLeave -= value5;
			}
			_btn_imprimir = value;
			if (_btn_imprimir != null)
			{
				_btn_imprimir.MouseUp += value2;
				_btn_imprimir.MouseDown += value3;
				_btn_imprimir.MouseEnter += value4;
				_btn_imprimir.MouseLeave += value5;
			}
		}
	}

	protected virtual Panel Fra_Filtro
	{
		[DebuggerNonUserCode]
		get
		{
			return _Fra_Filtro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Fra_Filtro = value;
		}
	}

	protected virtual ucText txtFiltro
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFiltro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtFiltro = value;
		}
	}

	protected virtual ComboBox CboFiltro
	{
		[DebuggerNonUserCode]
		get
		{
			return _CboFiltro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CboFiltro = value;
		}
	}

	internal ucLabel lbl_titulo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_titulo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_titulo = value;
		}
	}

	internal Label lbl_titulo1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_titulo1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_titulo1 = value;
		}
	}

	protected virtual Button btn_sel
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_sel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = btn_sel_Click_1;
			if (_btn_sel != null)
			{
				_btn_sel.Click -= value2;
			}
			_btn_sel = value;
			if (_btn_sel != null)
			{
				_btn_sel.Click += value2;
			}
		}
	}

	public Tipo TipoMaestro
	{
		get
		{
			return _TipoMaestro;
		}
		set
		{
			_TipoMaestro = value;
			VerBotones(vbVer: true);
		}
	}

	public string Titulo
	{
		get
		{
			return lbl_titulo.Text;
		}
		set
		{
			lbl_titulo.Text = value;
			lbl_titulo1.Text = value;
		}
	}

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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRLL.Common.FrmMaestro));
		this.Fra_botones = new System.Windows.Forms.Panel();
		this.btn_imprimir = new System.Windows.Forms.Button();
		this.btn_cerrar = new System.Windows.Forms.Button();
		this.BtnImprimir = new System.Windows.Forms.Button();
		this.btn_guardar = new System.Windows.Forms.Button();
		this.btn_cancelar = new System.Windows.Forms.Button();
		this.btn_eliminar = new System.Windows.Forms.Button();
		this.btn_editar = new System.Windows.Forms.Button();
		this.btn_nuevo = new System.Windows.Forms.Button();
		this.btn_cargar = new System.Windows.Forms.Button();
		this.btn_sel = new System.Windows.Forms.Button();
		this.Tab = new System.Windows.Forms.TabControl();
		this.TabLista = new System.Windows.Forms.TabPage();
		this.Fra_Filtro = new System.Windows.Forms.Panel();
		this.txtFiltro = new GRLL.Common.ucText();
		this.CboFiltro = new System.Windows.Forms.ComboBox();
		this.TabEdicion = new System.Windows.Forms.TabPage();
		this.lbl_titulo = new GRLL.Common.ucLabel();
		this.lbl_titulo1 = new System.Windows.Forms.Label();
		this.PanelSup.SuspendLayout();
		this.Fra_botones.SuspendLayout();
		this.Tab.SuspendLayout();
		this.TabLista.SuspendLayout();
		this.Fra_Filtro.SuspendLayout();
		this.SuspendLayout();
		this.cmdCerrar.Visible = false;
		this.PanelSup.Controls.Add(this.lbl_titulo);
		this.PanelSup.Controls.Add(this.lbl_titulo1);
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		System.Drawing.Size size = new System.Drawing.Size(632, 24);
		panelSup.Size = size;
		this.PanelSup.Controls.SetChildIndex(this.lbl_titulo1, 0);
		this.PanelSup.Controls.SetChildIndex(this.lbl_titulo, 0);
		this.PanelInf.Dock = System.Windows.Forms.DockStyle.None;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		System.Drawing.Point location = new System.Drawing.Point(0, 480);
		panelInf.Location = location;
		this.Fra_botones.Controls.Add(this.btn_imprimir);
		this.Fra_botones.Controls.Add(this.btn_cerrar);
		this.Fra_botones.Controls.Add(this.BtnImprimir);
		this.Fra_botones.Controls.Add(this.btn_guardar);
		this.Fra_botones.Controls.Add(this.btn_cancelar);
		this.Fra_botones.Controls.Add(this.btn_eliminar);
		this.Fra_botones.Controls.Add(this.btn_editar);
		this.Fra_botones.Controls.Add(this.btn_nuevo);
		this.Fra_botones.Controls.Add(this.btn_cargar);
		this.Fra_botones.Controls.Add(this.btn_sel);
		this.Fra_botones.Dock = System.Windows.Forms.DockStyle.Bottom;
		System.Windows.Forms.Panel fra_botones = this.Fra_botones;
		location = new System.Drawing.Point(0, 371);
		fra_botones.Location = location;
		this.Fra_botones.Name = "Fra_botones";
		System.Windows.Forms.Panel fra_botones2 = this.Fra_botones;
		size = new System.Drawing.Size(632, 34);
		fra_botones2.Size = size;
		this.Fra_botones.TabIndex = 41;
		this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_imprimir.Dock = System.Windows.Forms.DockStyle.Right;
		this.btn_imprimir.FlatAppearance.BorderSize = 0;
		this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_imprimir.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_imprimir.Image = (System.Drawing.Image)resources.GetObject("btn_imprimir.Image");
		System.Windows.Forms.Button button = this.btn_imprimir;
		location = new System.Drawing.Point(518, 0);
		button.Location = location;
		this.btn_imprimir.Name = "btn_imprimir";
		System.Windows.Forms.Button button2 = this.btn_imprimir;
		size = new System.Drawing.Size(57, 34);
		button2.Size = size;
		this.btn_imprimir.TabIndex = 37;
		this.btn_imprimir.Text = "Imprimir";
		this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_imprimir.UseVisualStyleBackColor = true;
		this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_cerrar.Dock = System.Windows.Forms.DockStyle.Right;
		this.btn_cerrar.FlatAppearance.BorderSize = 0;
		this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_cerrar.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_cerrar.Image = (System.Drawing.Image)resources.GetObject("btn_cerrar.Image");
		System.Windows.Forms.Button button3 = this.btn_cerrar;
		location = new System.Drawing.Point(575, 0);
		button3.Location = location;
		this.btn_cerrar.Name = "btn_cerrar";
		System.Windows.Forms.Button button4 = this.btn_cerrar;
		size = new System.Drawing.Size(57, 34);
		button4.Size = size;
		this.btn_cerrar.TabIndex = 35;
		this.btn_cerrar.Text = "Cerrar";
		this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_cerrar.UseVisualStyleBackColor = true;
		this.BtnImprimir.BackgroundImage = (System.Drawing.Image)resources.GetObject("BtnImprimir.BackgroundImage");
		this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.BtnImprimir.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BtnImprimir.Image = (System.Drawing.Image)resources.GetObject("BtnImprimir.Image");
		System.Windows.Forms.Button btnImprimir = this.BtnImprimir;
		location = new System.Drawing.Point(888, 3);
		btnImprimir.Location = location;
		this.BtnImprimir.Name = "BtnImprimir";
		System.Windows.Forms.Button btnImprimir2 = this.BtnImprimir;
		size = new System.Drawing.Size(57, 36);
		btnImprimir2.Size = size;
		this.BtnImprimir.TabIndex = 30;
		this.BtnImprimir.Text = "Imprimir";
		this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.BtnImprimir.UseVisualStyleBackColor = true;
		this.BtnImprimir.Visible = false;
		this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_guardar.CausesValidation = false;
		this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_guardar.Dock = System.Windows.Forms.DockStyle.Left;
		this.btn_guardar.FlatAppearance.BorderSize = 0;
		this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_guardar.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_guardar.Image = (System.Drawing.Image)resources.GetObject("btn_guardar.Image");
		System.Windows.Forms.Button button5 = this.btn_guardar;
		location = new System.Drawing.Point(344, 0);
		button5.Location = location;
		this.btn_guardar.Name = "btn_guardar";
		System.Windows.Forms.Button button6 = this.btn_guardar;
		size = new System.Drawing.Size(59, 34);
		button6.Size = size;
		this.btn_guardar.TabIndex = 30;
		this.btn_guardar.Text = "Guardar";
		this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_guardar.UseVisualStyleBackColor = true;
		this.btn_guardar.Visible = false;
		this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_cancelar.CausesValidation = false;
		this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Left;
		this.btn_cancelar.FlatAppearance.BorderSize = 0;
		this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_cancelar.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_cancelar.Image = (System.Drawing.Image)resources.GetObject("btn_cancelar.Image");
		System.Windows.Forms.Button button7 = this.btn_cancelar;
		location = new System.Drawing.Point(285, 0);
		button7.Location = location;
		this.btn_cancelar.Name = "btn_cancelar";
		System.Windows.Forms.Button button8 = this.btn_cancelar;
		size = new System.Drawing.Size(59, 34);
		button8.Size = size;
		this.btn_cancelar.TabIndex = 29;
		this.btn_cancelar.Text = "Cancelar";
		this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_cancelar.UseVisualStyleBackColor = true;
		this.btn_cancelar.Visible = false;
		this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_eliminar.Dock = System.Windows.Forms.DockStyle.Left;
		this.btn_eliminar.FlatAppearance.BorderSize = 0;
		this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_eliminar.Image = (System.Drawing.Image)resources.GetObject("btn_eliminar.Image");
		System.Windows.Forms.Button button9 = this.btn_eliminar;
		location = new System.Drawing.Point(228, 0);
		button9.Location = location;
		this.btn_eliminar.Name = "btn_eliminar";
		System.Windows.Forms.Button button10 = this.btn_eliminar;
		size = new System.Drawing.Size(57, 34);
		button10.Size = size;
		this.btn_eliminar.TabIndex = 34;
		this.btn_eliminar.Text = "Eliminar";
		this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_eliminar.UseVisualStyleBackColor = true;
		this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_editar.Dock = System.Windows.Forms.DockStyle.Left;
		this.btn_editar.FlatAppearance.BorderSize = 0;
		this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_editar.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_editar.Image = (System.Drawing.Image)resources.GetObject("btn_editar.Image");
		System.Windows.Forms.Button button11 = this.btn_editar;
		location = new System.Drawing.Point(171, 0);
		button11.Location = location;
		this.btn_editar.Name = "btn_editar";
		System.Windows.Forms.Button button12 = this.btn_editar;
		size = new System.Drawing.Size(57, 34);
		button12.Size = size;
		this.btn_editar.TabIndex = 33;
		this.btn_editar.Text = "Editar";
		this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_editar.UseVisualStyleBackColor = true;
		this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_nuevo.Dock = System.Windows.Forms.DockStyle.Left;
		this.btn_nuevo.FlatAppearance.BorderSize = 0;
		this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_nuevo.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_nuevo.Image = (System.Drawing.Image)resources.GetObject("btn_nuevo.Image");
		System.Windows.Forms.Button button13 = this.btn_nuevo;
		location = new System.Drawing.Point(114, 0);
		button13.Location = location;
		this.btn_nuevo.Name = "btn_nuevo";
		System.Windows.Forms.Button button14 = this.btn_nuevo;
		size = new System.Drawing.Size(57, 34);
		button14.Size = size;
		this.btn_nuevo.TabIndex = 32;
		this.btn_nuevo.Text = "Nuevo";
		this.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_nuevo.UseVisualStyleBackColor = true;
		this.btn_cargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_cargar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_cargar.Dock = System.Windows.Forms.DockStyle.Left;
		this.btn_cargar.FlatAppearance.BorderSize = 0;
		this.btn_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_cargar.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_cargar.Image = (System.Drawing.Image)resources.GetObject("btn_cargar.Image");
		System.Windows.Forms.Button button15 = this.btn_cargar;
		location = new System.Drawing.Point(57, 0);
		button15.Location = location;
		this.btn_cargar.Name = "btn_cargar";
		System.Windows.Forms.Button button16 = this.btn_cargar;
		size = new System.Drawing.Size(57, 34);
		button16.Size = size;
		this.btn_cargar.TabIndex = 31;
		this.btn_cargar.Text = "Cargar";
		this.btn_cargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_cargar.UseVisualStyleBackColor = true;
		this.btn_sel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_sel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_sel.Dock = System.Windows.Forms.DockStyle.Left;
		this.btn_sel.FlatAppearance.BorderSize = 0;
		this.btn_sel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_sel.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btn_sel.Image = (System.Drawing.Image)resources.GetObject("btn_sel.Image");
		System.Windows.Forms.Button button17 = this.btn_sel;
		location = new System.Drawing.Point(0, 0);
		button17.Location = location;
		this.btn_sel.Name = "btn_sel";
		System.Windows.Forms.Button button18 = this.btn_sel;
		size = new System.Drawing.Size(57, 34);
		button18.Size = size;
		this.btn_sel.TabIndex = 38;
		this.btn_sel.Text = "Aceptar";
		this.btn_sel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.btn_sel.UseVisualStyleBackColor = true;
		this.Tab.Controls.Add(this.TabLista);
		this.Tab.Controls.Add(this.TabEdicion);
		this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
		System.Windows.Forms.TabControl tab = this.Tab;
		location = new System.Drawing.Point(0, 24);
		tab.Location = location;
		this.Tab.Name = "Tab";
		this.Tab.SelectedIndex = 0;
		System.Windows.Forms.TabControl tab2 = this.Tab;
		size = new System.Drawing.Size(632, 347);
		tab2.Size = size;
		this.Tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		this.Tab.TabIndex = 42;
		this.TabLista.BackColor = System.Drawing.Color.FromArgb(224, 233, 244);
		this.TabLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.TabLista.Controls.Add(this.Fra_Filtro);
		System.Windows.Forms.TabPage tabLista = this.TabLista;
		location = new System.Drawing.Point(4, 22);
		tabLista.Location = location;
		this.TabLista.Name = "TabLista";
		System.Windows.Forms.TabPage tabLista2 = this.TabLista;
		System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(3);
		tabLista2.Padding = padding;
		System.Windows.Forms.TabPage tabLista3 = this.TabLista;
		size = new System.Drawing.Size(624, 321);
		tabLista3.Size = size;
		this.TabLista.TabIndex = 0;
		this.TabLista.Text = "Listado";
		this.Fra_Filtro.BackColor = System.Drawing.Color.FromArgb(199, 223, 250);
		this.Fra_Filtro.Controls.Add(this.txtFiltro);
		this.Fra_Filtro.Controls.Add(this.CboFiltro);
		this.Fra_Filtro.Dock = System.Windows.Forms.DockStyle.Top;
		System.Windows.Forms.Panel fra_Filtro = this.Fra_Filtro;
		location = new System.Drawing.Point(3, 3);
		fra_Filtro.Location = location;
		this.Fra_Filtro.Name = "Fra_Filtro";
		System.Windows.Forms.Panel fra_Filtro2 = this.Fra_Filtro;
		size = new System.Drawing.Size(614, 26);
		fra_Filtro2.Size = size;
		this.Fra_Filtro.TabIndex = 0;
		this.txtFiltro.ActiveBorderColor = System.Drawing.SystemColors.ControlDarkDark;
		this.txtFiltro.BackColorFocus = System.Drawing.Color.FromArgb(255, 192, 255);
		this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtFiltro.ExitOnEnter = true;
		this.txtFiltro.ExitOnMaxLength = true;
		this.txtFiltro.ForeColorFocus = System.Drawing.Color.Blue;
		this.txtFiltro.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucText obj = this.txtFiltro;
		location = new System.Drawing.Point(3, 3);
		obj.Location = location;
		this.txtFiltro.MsgError = "Un dato es requerido aquí";
		this.txtFiltro.Name = "txtFiltro";
		this.txtFiltro.SelectOnEnter = true;
		GRLL.Common.ucText obj2 = this.txtFiltro;
		size = new System.Drawing.Size(414, 20);
		obj2.Size = size;
		this.txtFiltro.TabIndex = 1;
		this.txtFiltro.TipoDato = GRLL.Common.clsVariables.TipoDato.LetrasyNumeros;
		this.txtFiltro.Valida = false;
		this.CboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.CboFiltro.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CboFiltro.FormattingEnabled = true;
		System.Windows.Forms.ComboBox cboFiltro = this.CboFiltro;
		location = new System.Drawing.Point(423, 3);
		cboFiltro.Location = location;
		this.CboFiltro.Name = "CboFiltro";
		System.Windows.Forms.ComboBox cboFiltro2 = this.CboFiltro;
		size = new System.Drawing.Size(121, 21);
		cboFiltro2.Size = size;
		this.CboFiltro.TabIndex = 0;
		this.TabEdicion.BackColor = System.Drawing.Color.FromArgb(224, 233, 244);
		this.TabEdicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		System.Windows.Forms.TabPage tabEdicion = this.TabEdicion;
		location = new System.Drawing.Point(4, 22);
		tabEdicion.Location = location;
		this.TabEdicion.Name = "TabEdicion";
		System.Windows.Forms.TabPage tabEdicion2 = this.TabEdicion;
		padding = new System.Windows.Forms.Padding(3);
		tabEdicion2.Padding = padding;
		System.Windows.Forms.TabPage tabEdicion3 = this.TabEdicion;
		size = new System.Drawing.Size(624, 321);
		tabEdicion3.Size = size;
		this.TabEdicion.TabIndex = 1;
		this.TabEdicion.Text = "Edición";
		this.lbl_titulo.Font = new System.Drawing.Font("Arial", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lbl_titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
		GRLL.Common.ucLabel obj3 = this.lbl_titulo;
		location = new System.Drawing.Point(38, 3);
		obj3.Location = location;
		this.lbl_titulo.Name = "lbl_titulo";
		GRLL.Common.ucLabel obj4 = this.lbl_titulo;
		size = new System.Drawing.Size(148, 25);
		obj4.Size = size;
		this.lbl_titulo.TabIndex = 25;
		this.lbl_titulo.Text = "Título principal";
		this.lbl_titulo1.AutoSize = true;
		this.lbl_titulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lbl_titulo1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
		System.Windows.Forms.Label label = this.lbl_titulo1;
		location = new System.Drawing.Point(35, -1);
		label.Location = location;
		this.lbl_titulo1.Name = "lbl_titulo1";
		System.Windows.Forms.Label label2 = this.lbl_titulo1;
		size = new System.Drawing.Size(148, 24);
		label2.Size = size;
		this.lbl_titulo1.TabIndex = 24;
		this.lbl_titulo1.Text = "Título principal";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(632, 405);
		this.ClientSize = size;
		this.Controls.Add(this.Tab);
		this.Controls.Add(this.Fra_botones);
		this.MessageShow = true;
		this.Name = "FrmMaestro";
		this.Text = "";
		this.TitleMsg = "frmBase";
		this.VerPanelInf = false;
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.Fra_botones, 0);
		this.Controls.SetChildIndex(this.Tab, 0);
		this.PanelSup.ResumeLayout(false);
		this.PanelSup.PerformLayout();
		this.Fra_botones.ResumeLayout(false);
		this.Tab.ResumeLayout(false);
		this.TabLista.ResumeLayout(false);
		this.Fra_Filtro.ResumeLayout(false);
		this.Fra_Filtro.PerformLayout();
		this.ResumeLayout(false);
	}

	public FrmMaestro()
	{
		base.Load += FrmMantFamilia_Load;
		EsNuevo = true;
		_TipoMaestro = Tipo.Simple;
		arriba = false;
		InitializeComponent();
	}

	public FrmMaestro(Tipo Tipo)
	{
		base.Load += FrmMantFamilia_Load;
		EsNuevo = true;
		_TipoMaestro = Tipo.Simple;
		arriba = false;
		InitializeComponent();
		_TipoMaestro = Tipo;
	}

	protected void VerBotones(bool vbVer)
	{
		Tab.TabPages.Clear();
		if (_TipoMaestro == Tipo.Simple)
		{
			btn_cargar.Visible = vbVer;
			btn_sel.Visible = false;
			btn_nuevo.Visible = vbVer;
			btn_editar.Visible = vbVer;
			btn_eliminar.Visible = vbVer;
			btn_guardar.Visible = !vbVer;
			btn_cancelar.Visible = !vbVer;
			btn_imprimir.Visible = !vbVer;
			btn_cerrar.Visible = vbVer;
			if (vbVer)
			{
				ClearErrors(TabEdicion);
				Tab.TabPages.Insert(0, TabLista);
			}
			else
			{
				Tab.TabPages.Insert(0, TabEdicion);
			}
		}
		if (_TipoMaestro == Tipo.SeleccionEditable)
		{
			btn_cargar.Visible = false;
			btn_sel.Visible = vbVer;
			btn_nuevo.Visible = vbVer;
			btn_editar.Visible = vbVer;
			btn_eliminar.Visible = false;
			btn_guardar.Visible = !vbVer;
			btn_cancelar.Visible = !vbVer;
			btn_imprimir.Visible = false;
			btn_cerrar.Visible = vbVer;
			if (vbVer)
			{
				ClearErrors(TabEdicion);
				Tab.TabPages.Insert(0, TabLista);
			}
			else
			{
				Limpiar(TabEdicion);
				Tab.TabPages.Insert(0, TabEdicion);
			}
		}
		if (_TipoMaestro != Tipo.Seleccion)
		{
			return;
		}
		btn_cargar.Visible = false;
		btn_sel.Visible = vbVer;
		btn_nuevo.Visible = false;
		btn_editar.Visible = false;
		btn_eliminar.Visible = false;
		btn_guardar.Visible = !vbVer;
		btn_cancelar.Visible = !vbVer;
		btn_imprimir.Visible = false;
		btn_cerrar.Visible = vbVer;
		Tab.TabPages.Insert(0, TabLista);
		Tab.TabPages.Insert(1, TabEdicion);
		ClearErrors(TabEdicion);
		foreach (Control var in TabEdicion.Controls)
		{
			var.Enabled = false;
		}
	}

	private void FrmMantFamilia_Load(object sender, EventArgs e)
	{
	}

	protected void ClearErrors(Control Control)
	{
		bool Retorno = true;
		if (!Validate())
		{
			return;
		}
		foreach (Control var in Control.Controls)
		{
			if (var.GetType() == typeof(ucTextBox))
			{
				ucTextBox texto = (ucTextBox)var;
				texto.ClearErrors();
			}
		}
	}

	protected void Limpiar(Control control)
	{
		bool Retorno = true;
		if (!Validate())
		{
			return;
		}
		foreach (Control var in control.Controls)
		{
			if (var.GetType() == typeof(ucTextBox))
			{
				ucTextBox texto = (ucTextBox)var;
				texto.Clear();
			}
		}
	}

	protected bool Validar(Control Control)
	{
		bool Retorno = true;
		if (!Validate())
		{
			return false;
		}
		foreach (Control var in Control.Controls)
		{
			if (var.GetType() == typeof(ucTextBox) && var.Text.Trim().Length == 0)
			{
				ucTextBox texto = (ucTextBox)var;
				texto.Validar();
				if (texto.IsRequired)
				{
					Retorno = false;
				}
			}
		}
		return Retorno;
	}

	private void btn_sel_MouseDown(object sender, MouseEventArgs e)
	{
		Button btn = (Button)sender;
		btn.FlatStyle = FlatStyle.Popup;
		btn.FlatAppearance.BorderSize = 1;
	}

	private void btn_sel_MouseUp(object sender, MouseEventArgs e)
	{
		Button btn = (Button)sender;
		btn.FlatStyle = FlatStyle.Flat;
		btn.FlatAppearance.BorderSize = 0;
	}

	private void btn_sel_MouseLeave(object sender, EventArgs e)
	{
		if (arriba)
		{
			Button btn = (Button)sender;
			btn.FlatAppearance.BorderSize = 0;
			arriba = false;
		}
	}

	private void btn_sel_MouseEnter(object sender, EventArgs e)
	{
		Button btn = (Button)sender;
		btn.FlatAppearance.BorderSize = 1;
		arriba = true;
	}

	private void btn_nuevo_Click(object sender, EventArgs e)
	{
		Limpiar(TabEdicion);
	}

	private void btn_editar_Click(object sender, EventArgs e)
	{
	}

	private void btn_guardar_Click(object sender, EventArgs e)
	{
	}

	private void btn_sel_Click_1(object sender, EventArgs e)
	{
		DialogResult = DialogResult.OK;
		Close();
	}

	private void btn_cerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
}
