using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GRLL.Common.My.Resources;

namespace GRLL.Common;

public class ucToolStripMaestro : ToolStrip
{
	public delegate void OnCargarEventHandler();

	public delegate void OnNuevoEventHandler();

	public delegate void OnEditarEventHandler();

	public delegate void OnEliminarEventHandler();

	public delegate void OnImprimirEventHandler();

	public delegate void OnGuardarEventHandler();

	public delegate void OnCancelarEventHandler();

	public delegate void OnCerrarEventHandler();

	[AccessedThroughProperty("TsbCargar")]
	private ToolStripButton _TsbCargar;

	[AccessedThroughProperty("TsbNuevo")]
	private ToolStripButton _TsbNuevo;

	[AccessedThroughProperty("TsbEditar")]
	private ToolStripButton _TsbEditar;

	[AccessedThroughProperty("TsbEliminar")]
	private ToolStripButton _TsbEliminar;

	[AccessedThroughProperty("TsbCancelar")]
	private ToolStripButton _TsbCancelar;

	[AccessedThroughProperty("TsbGuardar")]
	private ToolStripButton _TsbGuardar;

	[AccessedThroughProperty("TsbImprimir")]
	private ToolStripButton _TsbImprimir;

	[AccessedThroughProperty("TsbCerrar")]
	private ToolStripButton _TsbCerrar;

	private IContainer components;

	internal ToolStripButton TsbCargar
	{
		[DebuggerNonUserCode]
		get
		{
			return _TsbCargar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TsbCargar = value;
		}
	}

	internal ToolStripButton TsbNuevo
	{
		[DebuggerNonUserCode]
		get
		{
			return _TsbNuevo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TsbNuevo = value;
		}
	}

	internal ToolStripButton TsbEditar
	{
		[DebuggerNonUserCode]
		get
		{
			return _TsbEditar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TsbEditar = value;
		}
	}

	internal ToolStripButton TsbEliminar
	{
		[DebuggerNonUserCode]
		get
		{
			return _TsbEliminar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TsbEliminar = value;
		}
	}

	internal ToolStripButton TsbCancelar
	{
		[DebuggerNonUserCode]
		get
		{
			return _TsbCancelar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TsbCancelar = value;
		}
	}

	internal ToolStripButton TsbGuardar
	{
		[DebuggerNonUserCode]
		get
		{
			return _TsbGuardar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TsbGuardar = value;
		}
	}

	internal ToolStripButton TsbImprimir
	{
		[DebuggerNonUserCode]
		get
		{
			return _TsbImprimir;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TsbImprimir = value;
		}
	}

	internal ToolStripButton TsbCerrar
	{
		[DebuggerNonUserCode]
		get
		{
			return _TsbCerrar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TsbCerrar = value;
		}
	}

	[DefaultValue(true)]
	public bool VisibleCargar
	{
		get
		{
			return TsbCargar.Visible;
		}
		set
		{
			TsbCargar.Visible = value;
		}
	}

	[DefaultValue(true)]
	public bool VisibleImprimir
	{
		get
		{
			return TsbImprimir.Visible;
		}
		set
		{
			TsbImprimir.Visible = value;
		}
	}

	[DefaultValue(true)]
	public bool VisibleGuardar
	{
		get
		{
			return TsbGuardar.Visible;
		}
		set
		{
			TsbGuardar.Visible = value;
		}
	}

	[DefaultValue(true)]
	public bool VisibleCancelar
	{
		get
		{
			return TsbCancelar.Visible;
		}
		set
		{
			TsbCancelar.Visible = value;
		}
	}

	[DefaultValue(true)]
	public bool VisibleEditar
	{
		get
		{
			return TsbEditar.Visible;
		}
		set
		{
			TsbEditar.Visible = value;
		}
	}

	[method: DebuggerNonUserCode]
	public event OnCargarEventHandler OnCargar;

	[method: DebuggerNonUserCode]
	public event OnNuevoEventHandler OnNuevo;

	[method: DebuggerNonUserCode]
	public event OnEditarEventHandler OnEditar;

	[method: DebuggerNonUserCode]
	public event OnEliminarEventHandler OnEliminar;

	[method: DebuggerNonUserCode]
	public event OnImprimirEventHandler OnImprimir;

	[method: DebuggerNonUserCode]
	public event OnGuardarEventHandler OnGuardar;

	[method: DebuggerNonUserCode]
	public event OnCancelarEventHandler OnCancelar;

	[method: DebuggerNonUserCode]
	public event OnCerrarEventHandler OnCerrar;

	public ucToolStripMaestro(IContainer Container)
		: this()
	{
		Container.Add(this);
	}

	public ucToolStripMaestro()
	{
		base.ItemClicked += ucToolStripMaestro_ItemClicked;
		TsbNuevo = new ToolStripButton();
		TsbEditar = new ToolStripButton();
		TsbEliminar = new ToolStripButton();
		TsbCancelar = new ToolStripButton();
		TsbGuardar = new ToolStripButton();
		TsbImprimir = new ToolStripButton();
		TsbCerrar = new ToolStripButton();
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		this.TsbCargar = new System.Windows.Forms.ToolStripButton();
		this.TsbCargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.TsbCargar.Image = GRLL.Common.My.Resources.Resources.filefind;
		this.TsbCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.TsbCargar.Name = "TsbCargar";
		System.Windows.Forms.ToolStripButton tsbCargar = this.TsbCargar;
		System.Drawing.Size size = new System.Drawing.Size(23, 22);
		tsbCargar.Size = size;
		this.TsbCargar.Tag = "";
		this.TsbCargar.Text = "Cargar";
		this.TsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.TsbNuevo.Image = GRLL.Common.My.Resources.Resources.copy16;
		this.TsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.TsbNuevo.Name = "TsbNuevo";
		System.Windows.Forms.ToolStripButton tsbNuevo = this.TsbNuevo;
		size = new System.Drawing.Size(23, 22);
		tsbNuevo.Size = size;
		this.TsbNuevo.Tag = "";
		this.TsbNuevo.Text = "Nuevo";
		this.TsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.TsbEditar.Image = GRLL.Common.My.Resources.Resources.paste16;
		this.TsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.TsbEditar.Name = "TsbEditar";
		System.Windows.Forms.ToolStripButton tsbEditar = this.TsbEditar;
		size = new System.Drawing.Size(23, 22);
		tsbEditar.Size = size;
		this.TsbEditar.Text = "Editar";
		this.TsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.TsbEliminar.Image = GRLL.Common.My.Resources.Resources.button_cancel;
		this.TsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.TsbEliminar.Name = "TsbEliminar";
		System.Windows.Forms.ToolStripButton tsbEliminar = this.TsbEliminar;
		size = new System.Drawing.Size(23, 22);
		tsbEliminar.Size = size;
		this.TsbEliminar.Text = "Eliminar";
		this.TsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.TsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.TsbCancelar.Enabled = false;
		this.TsbCancelar.Image = GRLL.Common.My.Resources.Resources.cancel;
		this.TsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.TsbCancelar.Name = "TsbCancelar";
		System.Windows.Forms.ToolStripButton tsbCancelar = this.TsbCancelar;
		size = new System.Drawing.Size(23, 22);
		tsbCancelar.Size = size;
		this.TsbCancelar.Text = "Cancelar";
		this.TsbGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.TsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.TsbGuardar.Enabled = false;
		this.TsbGuardar.Image = GRLL.Common.My.Resources.Resources.filesave;
		this.TsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.TsbGuardar.Name = "TsbGuardar";
		System.Windows.Forms.ToolStripButton tsbGuardar = this.TsbGuardar;
		size = new System.Drawing.Size(23, 22);
		tsbGuardar.Size = size;
		this.TsbGuardar.Text = "Guardar";
		this.TsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.TsbImprimir.Image = GRLL.Common.My.Resources.Resources.printer;
		this.TsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.TsbImprimir.Name = "TsbImprimir";
		System.Windows.Forms.ToolStripButton tsbImprimir = this.TsbImprimir;
		size = new System.Drawing.Size(23, 22);
		tsbImprimir.Size = size;
		this.TsbImprimir.Text = "Imprimir";
		this.Items.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.TsbCargar, this.TsbNuevo, this.TsbEditar, this.TsbEliminar, this.TsbCancelar, this.TsbGuardar, this.TsbImprimir });
	}

	private void ucToolStripMaestro_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
		switch (e.ClickedItem.Name.ToUpper())
		{
		case "TSBCARGAR":
			OnCargar?.Invoke();
			break;
		case "TSBNUEVO":
			OnNuevo?.Invoke();
			break;
		case "TSBEDITAR":
			OnEditar?.Invoke();
			break;
		case "TSBELIMINAR":
			OnEliminar?.Invoke();
			break;
		case "TSBIMPRIMIR":
			OnImprimir?.Invoke();
			break;
		case "TSBGUARDAR":
			OnGuardar?.Invoke();
			break;
		case "TSBCANCELAR":
			OnCancelar?.Invoke();
			break;
		case "TSBCERRAR":
			OnCerrar?.Invoke();
			break;
		}
	}

	private void VerToolbar(bool vbVer)
	{
		TsbCargar.Enabled = vbVer;
		TsbNuevo.Enabled = vbVer;
		TsbEditar.Enabled = vbVer;
		TsbEliminar.Enabled = vbVer;
		TsbImprimir.Enabled = vbVer;
		TsbCancelar.Enabled = !vbVer;
		TsbGuardar.Enabled = !vbVer;
	}
}
