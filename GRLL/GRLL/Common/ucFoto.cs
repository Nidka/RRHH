using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class ucFoto : UserControl
{
	public delegate void BuscarEventHandler();

	public delegate void EliminarEventHandler(bool Cancel);

	public delegate void GrabarEventHandler(bool Cancel);

	public delegate void FileNameChangedEventHandler(string cFile);

	private IContainer components;

	[AccessedThroughProperty("cmdBuscar")]
	private Button _cmdBuscar;

	[AccessedThroughProperty("cmdEliminar")]
	private Button _cmdEliminar;

	[AccessedThroughProperty("cmdGrabar")]
	private Button _cmdGrabar;

	[AccessedThroughProperty("pbFoto")]
	private PictureBox _pbFoto;

	[AccessedThroughProperty("chkAjustar")]
	private CheckBox _chkAjustar;

	private ToolTip oToolTip;

	private bool _ViewControles;

	private bool _ViewAjustar;

	private string _cFileName;

	private bool _Changed;

	private bool _Borde;

	internal Button cmdBuscar
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdBuscar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdBuscar_Click;
			if (_cmdBuscar != null)
			{
				_cmdBuscar.Click -= value2;
			}
			_cmdBuscar = value;
			if (_cmdBuscar != null)
			{
				_cmdBuscar.Click += value2;
			}
		}
	}

	internal Button cmdEliminar
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdEliminar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdEliminar_Click;
			if (_cmdEliminar != null)
			{
				_cmdEliminar.Click -= value2;
			}
			_cmdEliminar = value;
			if (_cmdEliminar != null)
			{
				_cmdEliminar.Click += value2;
			}
		}
	}

	internal Button cmdGrabar
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdGrabar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = cmdGrabar_Click;
			if (_cmdGrabar != null)
			{
				_cmdGrabar.Click -= value2;
			}
			_cmdGrabar = value;
			if (_cmdGrabar != null)
			{
				_cmdGrabar.Click += value2;
			}
		}
	}

	internal PictureBox pbFoto
	{
		[DebuggerNonUserCode]
		get
		{
			return _pbFoto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_pbFoto = value;
		}
	}

	internal CheckBox chkAjustar
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkAjustar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = chkAjustar_CheckedChanged;
			if (_chkAjustar != null)
			{
				_chkAjustar.CheckedChanged -= value2;
			}
			_chkAjustar = value;
			if (_chkAjustar != null)
			{
				_chkAjustar.CheckedChanged += value2;
			}
		}
	}

	public bool Borde
	{
		get
		{
			return _Borde;
		}
		set
		{
			_Borde = value;
			pbFoto.BorderStyle = (BorderStyle)Conversions.ToInteger(Interaction.IIf(_Borde, BorderStyle.FixedSingle, BorderStyle.None));
		}
	}

	public bool AjustarImagen
	{
		get
		{
			return chkAjustar.Checked;
		}
		set
		{
			chkAjustar.Checked = value;
		}
	}

	public string FileName
	{
		get
		{
			return _cFileName;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				_cFileName = value;
				pbFoto.Image = Image.FromFile(_cFileName);
				_Changed = true;
				cmdEliminar.Enabled = true;
				cmdGrabar.Enabled = true;
				FileNameChanged?.Invoke(_cFileName);
			}
		}
	}

	public bool VerControles
	{
		get
		{
			return _ViewControles;
		}
		set
		{
			_ViewControles = value;
			cmdBuscar.Visible = _ViewControles;
			cmdEliminar.Visible = _ViewControles;
			cmdGrabar.Visible = _ViewControles;
			Reubicar();
		}
	}

	public bool VerAjuste
	{
		get
		{
			return _ViewAjustar;
		}
		set
		{
			_ViewAjustar = value;
			chkAjustar.Visible = _ViewAjustar;
			Reubicar();
		}
	}

	public bool ImageChanged
	{
		get
		{
			return _Changed;
		}
		set
		{
			_Changed = value;
		}
	}

	public Image Image
	{
		get
		{
			return pbFoto.Image;
		}
		set
		{
			pbFoto.Image = value;
		}
	}

	[method: DebuggerNonUserCode]
	public event BuscarEventHandler Buscar;

	[method: DebuggerNonUserCode]
	public event EliminarEventHandler Eliminar;

	[method: DebuggerNonUserCode]
	public event GrabarEventHandler Grabar;

	[method: DebuggerNonUserCode]
	public event FileNameChangedEventHandler FileNameChanged;

	public ucFoto()
	{
		base.Load += ucFoto_Load;
		base.Resize += ucFoto_Resize;
		oToolTip = new ToolTip();
		_ViewControles = true;
		_ViewAjustar = true;
		_cFileName = "";
		_Changed = false;
		_Borde = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRLL.Common.ucFoto));
		this.cmdBuscar = new System.Windows.Forms.Button();
		this.cmdEliminar = new System.Windows.Forms.Button();
		this.cmdGrabar = new System.Windows.Forms.Button();
		this.pbFoto = new System.Windows.Forms.PictureBox();
		this.chkAjustar = new System.Windows.Forms.CheckBox();
		((System.ComponentModel.ISupportInitialize)this.pbFoto).BeginInit();
		this.SuspendLayout();
		this.cmdBuscar.Image = (System.Drawing.Image)resources.GetObject("cmdBuscar.Image");
		System.Windows.Forms.Button button = this.cmdBuscar;
		System.Drawing.Point location = new System.Drawing.Point(0, 56);
		button.Location = location;
		this.cmdBuscar.Name = "cmdBuscar";
		System.Windows.Forms.Button button2 = this.cmdBuscar;
		System.Drawing.Size size = new System.Drawing.Size(25, 25);
		button2.Size = size;
		this.cmdBuscar.TabIndex = 0;
		this.cmdBuscar.UseVisualStyleBackColor = true;
		this.cmdEliminar.Image = (System.Drawing.Image)resources.GetObject("cmdEliminar.Image");
		System.Windows.Forms.Button button3 = this.cmdEliminar;
		location = new System.Drawing.Point(31, 56);
		button3.Location = location;
		this.cmdEliminar.Name = "cmdEliminar";
		System.Windows.Forms.Button button4 = this.cmdEliminar;
		size = new System.Drawing.Size(25, 25);
		button4.Size = size;
		this.cmdEliminar.TabIndex = 1;
		this.cmdEliminar.UseVisualStyleBackColor = true;
		this.cmdGrabar.Image = (System.Drawing.Image)resources.GetObject("cmdGrabar.Image");
		System.Windows.Forms.Button button5 = this.cmdGrabar;
		location = new System.Drawing.Point(62, 56);
		button5.Location = location;
		this.cmdGrabar.Name = "cmdGrabar";
		System.Windows.Forms.Button button6 = this.cmdGrabar;
		size = new System.Drawing.Size(25, 25);
		button6.Size = size;
		this.cmdGrabar.TabIndex = 2;
		this.cmdGrabar.UseVisualStyleBackColor = true;
		System.Windows.Forms.PictureBox pictureBox = this.pbFoto;
		location = new System.Drawing.Point(0, 3);
		pictureBox.Location = location;
		this.pbFoto.Name = "pbFoto";
		System.Windows.Forms.PictureBox pictureBox2 = this.pbFoto;
		size = new System.Drawing.Size(51, 47);
		pictureBox2.Size = size;
		this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pbFoto.TabIndex = 3;
		this.pbFoto.TabStop = false;
		this.chkAjustar.AutoSize = true;
		this.chkAjustar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
		System.Windows.Forms.CheckBox checkBox = this.chkAjustar;
		location = new System.Drawing.Point(104, 61);
		checkBox.Location = location;
		this.chkAjustar.Name = "chkAjustar";
		System.Windows.Forms.CheckBox checkBox2 = this.chkAjustar;
		size = new System.Drawing.Size(58, 17);
		checkBox2.Size = size;
		this.chkAjustar.TabIndex = 4;
		this.chkAjustar.Text = "Ajustar";
		this.chkAjustar.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.chkAjustar);
		this.Controls.Add(this.pbFoto);
		this.Controls.Add(this.cmdGrabar);
		this.Controls.Add(this.cmdEliminar);
		this.Controls.Add(this.cmdBuscar);
		this.Name = "ucFoto";
		size = new System.Drawing.Size(107, 99);
		this.Size = size;
		((System.ComponentModel.ISupportInitialize)this.pbFoto).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void ucFoto_Load(object sender, EventArgs e)
	{
		PictureBox pictureBox = pbFoto;
		Point location = new Point(0, 0);
		pictureBox.Location = location;
		oToolTip.SetToolTip(cmdBuscar, "Buscar Imagen");
		oToolTip.SetToolTip(cmdEliminar, "Eliminar Imagen");
		oToolTip.SetToolTip(cmdGrabar, "Guardar Imagen");
		cmdGrabar.Enabled = false;
		cmdEliminar.Enabled = false;
	}

	private void ucFoto_Resize(object sender, EventArgs e)
	{
		Reubicar();
	}

	private void Reubicar()
	{
		checked
		{
			if (_ViewControles | _ViewAjustar)
			{
				PictureBox pictureBox = pbFoto;
				Size size = new Size(Width, Height - cmdBuscar.Height - 3);
				pictureBox.Size = size;
			}
			else
			{
				PictureBox pictureBox2 = pbFoto;
				Size size = new Size(Width, Height);
				pictureBox2.Size = size;
			}
			Button button = cmdBuscar;
			Point location = new Point(0, Height - cmdBuscar.Height);
			button.Location = location;
			Button button2 = cmdEliminar;
			location = new Point(cmdBuscar.Width, Height - cmdEliminar.Height);
			button2.Location = location;
			Button button3 = cmdGrabar;
			location = new Point(cmdEliminar.Left + cmdEliminar.Width, Height - cmdGrabar.Height);
			button3.Location = location;
			CheckBox checkBox = chkAjustar;
			location = new Point(Width - chkAjustar.Width, Height - chkAjustar.Height);
			checkBox.Location = location;
		}
	}

	private void cmdBuscar_Click(object sender, EventArgs e)
	{
		Buscar?.Invoke();
		OpenFileDialog oFile = new OpenFileDialog();
		oFile.Filter = "Archivos de Imagenes|*.jpg;*.gif;*.bmp;*.png;*.ico";
		oFile.ShowDialog();
		if (Operators.CompareString(oFile.FileName, "", TextCompare: false) != 0)
		{
			_cFileName = oFile.FileName;
			pbFoto.Image = Image.FromFile(_cFileName);
			_Changed = true;
			cmdEliminar.Enabled = true;
			cmdGrabar.Enabled = true;
			FileNameChanged?.Invoke(_cFileName);
		}
	}

	private void cmdEliminar_Click(object sender, EventArgs e)
	{
		bool bCancelar = false;
		Eliminar?.Invoke(bCancelar);
		if (!bCancelar)
		{
			pbFoto.Image = null;
			_Changed = true;
			_cFileName = "";
			cmdGrabar.Enabled = true;
			cmdEliminar.Enabled = false;
			FileNameChanged?.Invoke(_cFileName);
		}
	}

	private void cmdGrabar_Click(object sender, EventArgs e)
	{
		bool bCancelar = false;
		Grabar?.Invoke(bCancelar);
		if (!bCancelar)
		{
			_Changed = false;
			cmdGrabar.Enabled = false;
		}
	}

	public void SetNoChanged()
	{
		_Changed = false;
		cmdGrabar.Enabled = false;
		cmdEliminar.Enabled = false;
	}

	public void Clear()
	{
		_cFileName = "";
		_Changed = false;
		pbFoto.Image = null;
		cmdGrabar.Enabled = false;
		cmdEliminar.Enabled = false;
	}

	private void chkAjustar_CheckedChanged(object sender, EventArgs e)
	{
		pbFoto.SizeMode = (PictureBoxSizeMode)Conversions.ToInteger(Interaction.IIf(chkAjustar.Checked, PictureBoxSizeMode.StretchImage, PictureBoxSizeMode.Normal));
	}
}
