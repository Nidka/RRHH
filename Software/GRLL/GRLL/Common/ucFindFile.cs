using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GRLL.Common.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[DesignerGenerated]
public class ucFindFile : UserControl
{
	public delegate void CancelarEventHandler();

	public delegate void FileNameChangedEventHandler(string cFile);

	private IContainer components;

	[AccessedThroughProperty("cmdBuscar")]
	private Button _cmdBuscar;

	[AccessedThroughProperty("lblcaption")]
	private Label _lblcaption;

	[AccessedThroughProperty("lblFileName")]
	private Label _lblFileName;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	private bool _Excel;

	private bool _Doc;

	private bool _Texto;

	private bool _Access;

	private bool _Zip;

	private bool _Pdf;

	private bool _Imagenes;

	private bool _Todos;

	private bool _Otros;

	private string _sOtros;

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

	internal Label lblcaption
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblcaption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblcaption = value;
		}
	}

	internal Label lblFileName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFileName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFileName = value;
		}
	}

	internal ToolTip ToolTip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolTip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolTip1 = value;
		}
	}

	public bool TypeExcel
	{
		get
		{
			return _Excel;
		}
		set
		{
			_Excel = value;
		}
	}

	public bool TypeDoc
	{
		get
		{
			return _Doc;
		}
		set
		{
			_Doc = value;
		}
	}

	public bool TypeTexto
	{
		get
		{
			return _Texto;
		}
		set
		{
			_Texto = value;
		}
	}

	public bool TypeAccess
	{
		get
		{
			return _Access;
		}
		set
		{
			_Access = value;
		}
	}

	public bool TypeTodos
	{
		get
		{
			return _Todos;
		}
		set
		{
			_Todos = value;
		}
	}

	public bool TypeZip
	{
		get
		{
			return _Zip;
		}
		set
		{
			_Zip = value;
		}
	}

	public bool TypePdf
	{
		get
		{
			return _Pdf;
		}
		set
		{
			_Pdf = value;
		}
	}

	public bool TypeImage
	{
		get
		{
			return _Imagenes;
		}
		set
		{
			_Imagenes = value;
		}
	}

	public bool TypeOtros
	{
		get
		{
			return _Otros;
		}
		set
		{
			_Otros = value;
		}
	}

	public string ExtensionOtros
	{
		get
		{
			return _sOtros;
		}
		set
		{
			_sOtros = value;
		}
	}

	public string TextoCaption
	{
		get
		{
			return lblcaption.Text;
		}
		set
		{
			lblcaption.Text = value;
		}
	}

	[method: DebuggerNonUserCode]
	public event CancelarEventHandler Cancelar;

	[method: DebuggerNonUserCode]
	public event FileNameChangedEventHandler FileNameChanged;

	[DebuggerNonUserCode]
	public ucFindFile()
	{
		base.Resize += ucFindFile_Resize;
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
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRLL.Common.ucFindFile));
		this.cmdBuscar = new System.Windows.Forms.Button();
		this.lblcaption = new System.Windows.Forms.Label();
		this.lblFileName = new System.Windows.Forms.Label();
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.SuspendLayout();
		this.cmdBuscar.Dock = System.Windows.Forms.DockStyle.Left;
		this.cmdBuscar.Image = (System.Drawing.Image)resources.GetObject("cmdBuscar.Image");
		System.Windows.Forms.Button button = this.cmdBuscar;
		System.Drawing.Point location = new System.Drawing.Point(46, 0);
		button.Location = location;
		this.cmdBuscar.Name = "cmdBuscar";
		System.Windows.Forms.Button button2 = this.cmdBuscar;
		System.Drawing.Size size = new System.Drawing.Size(38, 23);
		button2.Size = size;
		this.cmdBuscar.TabIndex = 0;
		this.cmdBuscar.UseVisualStyleBackColor = true;
		this.lblcaption.AutoSize = true;
		this.lblcaption.Dock = System.Windows.Forms.DockStyle.Left;
		System.Windows.Forms.Label label = this.lblcaption;
		location = new System.Drawing.Point(0, 0);
		label.Location = location;
		this.lblcaption.Name = "lblcaption";
		System.Windows.Forms.Label label2 = this.lblcaption;
		size = new System.Drawing.Size(46, 13);
		label2.Size = size;
		this.lblcaption.TabIndex = 1;
		this.lblcaption.Text = "Archivo:";
		this.lblcaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblFileName.BackColor = System.Drawing.Color.Honeydew;
		this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.lblFileName.Dock = System.Windows.Forms.DockStyle.Fill;
		this.lblFileName.Font = new System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		System.Windows.Forms.Label label3 = this.lblFileName;
		location = new System.Drawing.Point(84, 0);
		label3.Location = location;
		this.lblFileName.Name = "lblFileName";
		System.Windows.Forms.Label label4 = this.lblFileName;
		size = new System.Drawing.Size(148, 23);
		label4.Size = size;
		this.lblFileName.TabIndex = 2;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.lblFileName);
		this.Controls.Add(this.cmdBuscar);
		this.Controls.Add(this.lblcaption);
		this.Name = "ucFindFile";
		size = new System.Drawing.Size(232, 23);
		this.Size = size;
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void cmdBuscar_Click(object sender, EventArgs e)
	{
		OpenFileDialog oFile = new OpenFileDialog();
		string cFilter = Conversions.ToString(Interaction.IIf(_Excel, "Hojas de Cálculo|*.xls*", ""));
		if (_Doc)
		{
			cFilter = Conversions.ToString(Operators.ConcatenateObject(cFilter, Operators.ConcatenateObject(Interaction.IIf(cFilter.Length > 0, "|", ""), "Documentos|*.doc*;*.rtf")));
		}
		if (_Texto)
		{
			cFilter = Conversions.ToString(Operators.ConcatenateObject(cFilter, Operators.ConcatenateObject(Interaction.IIf(cFilter.Length > 0, "|", ""), "Archivos de Texto|*.txt")));
		}
		if (_Access)
		{
			cFilter = Conversions.ToString(Operators.ConcatenateObject(cFilter, Operators.ConcatenateObject(Interaction.IIf(cFilter.Length > 0, "|", ""), "Base de datos de Access|*.mdb")));
		}
		if (_Zip)
		{
			cFilter = Conversions.ToString(Operators.ConcatenateObject(cFilter, Operators.ConcatenateObject(Interaction.IIf(cFilter.Length > 0, "|", ""), "Archivos Comprimidos|*.zip;*.rar")));
		}
		if (_Pdf)
		{
			cFilter = Conversions.ToString(Operators.ConcatenateObject(cFilter, Operators.ConcatenateObject(Interaction.IIf(cFilter.Length > 0, "|", ""), "Documentos de Acrobat Reader|*.pdf")));
		}
		if (_Imagenes)
		{
			cFilter = Conversions.ToString(Operators.ConcatenateObject(cFilter, Operators.ConcatenateObject(Interaction.IIf(cFilter.Length > 0, "|", ""), "Archivos de Imagenes|*.jpg;*.gif;*.bmp;*.png;*.ico")));
		}
		if (_Todos)
		{
			cFilter = Conversions.ToString(Operators.ConcatenateObject(cFilter, Operators.ConcatenateObject(Interaction.IIf(cFilter.Length > 0, "|", ""), "Todos los Archivos|*.*")));
		}
		if (_Otros && _sOtros.Length > 0)
		{
			cFilter = Conversions.ToString(Operators.ConcatenateObject(cFilter, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(cFilter.Length > 0, "|", ""), "Otro Tipo : "), _sOtros), "|*."), _sOtros)));
		}
		if (cFilter.Length == 0)
		{
			cFilter += "Todos los Archivos|*.*";
		}
		oFile.Filter = cFilter;
		oFile.ShowDialog();
		if (Operators.CompareString(oFile.FileName, "", TextCompare: false) == 0)
		{
			lblFileName.Tag = null;
			ToolTip1.SetToolTip(lblFileName, lblFileName.Text);
			Cancelar?.Invoke();
		}
		else
		{
			lblFileName.Tag = oFile.SafeFileName;
			lblFileName.Text = oFile.FileName;
			ToolTip1.SetToolTip(lblFileName, lblFileName.Text);
			FileNameChanged?.Invoke(lblFileName.Text);
		}
	}

	private void ucFindFile_Resize(object sender, EventArgs e)
	{
		if (Width < 160)
		{
			Width = 160;
		}
		if (Height != lblFileName.Height)
		{
			Height = lblFileName.Height;
		}
		lblFileName.Width = checked(Width - lblFileName.Left);
	}

	public void SetFilename(string Filename)
	{
		lblFileName.Text = Filename;
		if (Strings.InStrRev(Filename, "\\") > 0)
		{
			lblFileName.Tag = Strings.Mid(Filename, checked(Strings.InStrRev(Filename, "\\") + 1), Filename.Length);
		}
	}

	public string GetFileName()
	{
		if (lblFileName.Tag == null)
		{
			return "";
		}
		return lblFileName.Tag.ToString().Trim();
	}

	public FileInfo GetFileInfo()
	{
		if (lblFileName.Text.Trim().Length == 0)
		{
			return null;
		}
		return MyProject.Computer.FileSystem.GetFileInfo(lblFileName.Text);
	}

	public string GetPath()
	{
		return lblFileName.Text;
	}

	public void Clear()
	{
		lblFileName.Text = "";
	}
}
