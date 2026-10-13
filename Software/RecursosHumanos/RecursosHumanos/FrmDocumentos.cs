using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmDocumentos : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("UcCmbDocumento")]
	private ucComboBox _UcCmbDocumento;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("UcDTIngreso")]
	private ucDateTime _UcDTIngreso;

	[AccessedThroughProperty("UcDTVence")]
	private ucDateTime _UcDTVence;

	[AccessedThroughProperty("UcTxtReferencia")]
	private ucTextBox _UcTxtReferencia;

	[AccessedThroughProperty("UcTxtObs")]
	private ucTextBox _UcTxtObs;

	[AccessedThroughProperty("BtnGrabar")]
	private Button _BtnGrabar;

	[AccessedThroughProperty("BtnCerrar")]
	private Button _BtnCerrar;

	public int CodEmple;

	public int CodDocumento;

	private Archivo Archivo;

	internal ucComboBox UcCmbDocumento
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmbDocumento;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmbDocumento = value;
		}
	}

	internal Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal ucDateTime UcDTIngreso
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTIngreso;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTIngreso = value;
		}
	}

	internal ucDateTime UcDTVence
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcDTVence;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcDTVence = value;
		}
	}

	internal ucTextBox UcTxtReferencia
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtReferencia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtReferencia = value;
		}
	}

	internal ucTextBox UcTxtObs
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcTxtObs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcTxtObs = value;
		}
	}

	internal Button BtnGrabar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnGrabar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnGrabar_Click;
			if (_BtnGrabar != null)
			{
				_BtnGrabar.Click -= value2;
			}
			_BtnGrabar = value;
			if (_BtnGrabar != null)
			{
				_BtnGrabar.Click += value2;
			}
		}
	}

	internal Button BtnCerrar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnCerrar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnCerrar_Click;
			if (_BtnCerrar != null)
			{
				_BtnCerrar.Click -= value2;
			}
			_BtnCerrar = value;
			if (_BtnCerrar != null)
			{
				_BtnCerrar.Click += value2;
			}
		}
	}

	public FrmDocumentos()
	{
		base.Load += FrmDocumentos_Load;
		__ENCAddToList(this);
		CodDocumento = 0;
		Archivo = new Archivo();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmDocumentos));
		this.UcCmbDocumento = new GRLL.Common.ucComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.UcDTIngreso = new GRLL.Common.ucDateTime();
		this.UcDTVence = new GRLL.Common.ucDateTime();
		this.UcTxtReferencia = new GRLL.Common.ucTextBox(this.components);
		this.UcTxtObs = new GRLL.Common.ucTextBox(this.components);
		this.BtnGrabar = new System.Windows.Forms.Button();
		this.BtnCerrar = new System.Windows.Forms.Button();
		this.SuspendLayout();
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(249, 213);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(69, 30);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(330, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 249);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(330, 27);
		panelInf2.Size = size;
		this.UcCmbDocumento.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmbDocumento.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmbDocumento.FormattingEnabled = true;
		this.UcCmbDocumento.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmbDocumento = this.UcCmbDocumento;
		location = new System.Drawing.Point(111, 39);
		ucCmbDocumento.Location = location;
		this.UcCmbDocumento.Name = "UcCmbDocumento";
		GRLL.Common.ucComboBox ucCmbDocumento2 = this.UcCmbDocumento;
		size = new System.Drawing.Size(155, 21);
		ucCmbDocumento2.Size = size;
		this.UcCmbDocumento.TabIndex = 3;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(40, 42);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(65, 13);
		label2.Size = size;
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Documento:";
		this.Label2.AutoSize = true;
		System.Windows.Forms.Label label3 = this.Label2;
		location = new System.Drawing.Point(12, 79);
		label3.Location = location;
		this.Label2.Name = "Label2";
		System.Windows.Forms.Label label4 = this.Label2;
		size = new System.Drawing.Size(93, 13);
		label4.Size = size;
		this.Label2.TabIndex = 6;
		this.Label2.Text = "Fecha de Ingreso:";
		this.Label3.AutoSize = true;
		System.Windows.Forms.Label label5 = this.Label3;
		location = new System.Drawing.Point(34, 105);
		label5.Location = location;
		this.Label3.Name = "Label3";
		System.Windows.Forms.Label label6 = this.Label3;
		size = new System.Drawing.Size(71, 13);
		label6.Size = size;
		this.Label3.TabIndex = 6;
		this.Label3.Text = "Fecha Venc.:";
		this.Label4.AutoSize = true;
		System.Windows.Forms.Label label7 = this.Label4;
		location = new System.Drawing.Point(47, 130);
		label7.Location = location;
		this.Label4.Name = "Label4";
		System.Windows.Forms.Label label8 = this.Label4;
		size = new System.Drawing.Size(58, 13);
		label8.Size = size;
		this.Label4.TabIndex = 6;
		this.Label4.Text = "Num. Ref.:";
		this.Label5.AutoSize = true;
		System.Windows.Forms.Label label9 = this.Label5;
		location = new System.Drawing.Point(24, 156);
		label9.Location = location;
		this.Label5.Name = "Label5";
		System.Windows.Forms.Label label10 = this.Label5;
		size = new System.Drawing.Size(81, 13);
		label10.Size = size;
		this.Label5.TabIndex = 6;
		this.Label5.Text = "Observaciones:";
		this.UcDTIngreso.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTIngreso.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTIngreso = this.UcDTIngreso;
		location = new System.Drawing.Point(111, 75);
		ucDTIngreso.Location = location;
		this.UcDTIngreso.Name = "UcDTIngreso";
		GRLL.Common.ucDateTime ucDTIngreso2 = this.UcDTIngreso;
		size = new System.Drawing.Size(200, 20);
		ucDTIngreso2.Size = size;
		this.UcDTIngreso.TabIndex = 7;
		this.UcDTVence.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcDTVence.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucDateTime ucDTVence = this.UcDTVence;
		location = new System.Drawing.Point(111, 101);
		ucDTVence.Location = location;
		this.UcDTVence.Name = "UcDTVence";
		GRLL.Common.ucDateTime ucDTVence2 = this.UcDTVence;
		size = new System.Drawing.Size(200, 20);
		ucDTVence2.Size = size;
		this.UcDTVence.TabIndex = 8;
		this.UcTxtReferencia.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtReferencia.Formato = null;
		this.UcTxtReferencia.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtReferencia = this.UcTxtReferencia;
		location = new System.Drawing.Point(111, 127);
		ucTxtReferencia.Location = location;
		this.UcTxtReferencia.Name = "UcTxtReferencia";
		this.UcTxtReferencia.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtReferencia.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtReferencia.OnErrorBlankText = "";
		this.UcTxtReferencia.PadLeftLenght = 0;
		this.UcTxtReferencia.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtReferencia.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtReferencia2 = this.UcTxtReferencia;
		size = new System.Drawing.Size(200, 20);
		ucTxtReferencia2.Size = size;
		this.UcTxtReferencia.TabIndex = 9;
		this.UcTxtReferencia.TabNextControl = false;
		this.UcTxtReferencia.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.UcTxtObs.ActiveBorderColor = System.Drawing.SystemColors.ControlDark;
		this.UcTxtObs.Formato = null;
		this.UcTxtObs.InactiveBorderColor = System.Drawing.SystemColors.ControlDark;
		GRLL.Common.ucTextBox ucTxtObs = this.UcTxtObs;
		location = new System.Drawing.Point(111, 153);
		ucTxtObs.Location = location;
		this.UcTxtObs.Multiline = true;
		this.UcTxtObs.Name = "UcTxtObs";
		this.UcTxtObs.NormalColor = System.Drawing.SystemColors.Window;
		this.UcTxtObs.NormalForeColor = System.Drawing.SystemColors.ControlText;
		this.UcTxtObs.OnErrorBlankText = "";
		this.UcTxtObs.PadLeftLenght = 0;
		this.UcTxtObs.SelectionBackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.UcTxtObs.SelectionForeColor = System.Drawing.Color.Blue;
		GRLL.Common.ucTextBox ucTxtObs2 = this.UcTxtObs;
		size = new System.Drawing.Size(200, 50);
		ucTxtObs2.Size = size;
		this.UcTxtObs.TabIndex = 10;
		this.UcTxtObs.TabNextControl = false;
		this.UcTxtObs.Tipo = GRLL.Common.ucTextBox.TipoDato.Todos;
		this.BtnGrabar.AutoSize = true;
		this.BtnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGrabar.FlatAppearance.BorderSize = 0;
		this.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGrabar.Image = (System.Drawing.Image)resources.GetObject("BtnGrabar.Image");
		System.Windows.Forms.Button btnGrabar = this.BtnGrabar;
		location = new System.Drawing.Point(12, 213);
		btnGrabar.Location = location;
		this.BtnGrabar.Name = "BtnGrabar";
		System.Windows.Forms.Button btnGrabar2 = this.BtnGrabar;
		size = new System.Drawing.Size(65, 23);
		btnGrabar2.Size = size;
		this.BtnGrabar.TabIndex = 11;
		this.BtnGrabar.Text = "Grabar";
		this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGrabar.UseVisualStyleBackColor = true;
		this.BtnCerrar.AutoSize = true;
		this.BtnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnCerrar.FlatAppearance.BorderSize = 0;
		this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnCerrar.Image = (System.Drawing.Image)resources.GetObject("BtnCerrar.Image");
		System.Windows.Forms.Button btnCerrar = this.BtnCerrar;
		location = new System.Drawing.Point(257, 213);
		btnCerrar.Location = location;
		this.BtnCerrar.Name = "BtnCerrar";
		System.Windows.Forms.Button btnCerrar2 = this.BtnCerrar;
		size = new System.Drawing.Size(61, 23);
		btnCerrar2.Size = size;
		this.BtnCerrar.TabIndex = 12;
		this.BtnCerrar.Text = "Cerrar";
		this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnCerrar.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(330, 276);
		this.ClientSize = size;
		this.Controls.Add(this.BtnCerrar);
		this.Controls.Add(this.UcDTIngreso);
		this.Controls.Add(this.UcTxtObs);
		this.Controls.Add(this.BtnGrabar);
		this.Controls.Add(this.UcTxtReferencia);
		this.Controls.Add(this.Label2);
		this.Controls.Add(this.UcDTVence);
		this.Controls.Add(this.Label3);
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.Label5);
		this.Controls.Add(this.UcCmbDocumento);
		this.Controls.Add(this.Label4);
		this.MessageShow = true;
		this.Name = "FrmDocumentos";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Documentos";
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.Label4, 0);
		this.Controls.SetChildIndex(this.UcCmbDocumento, 0);
		this.Controls.SetChildIndex(this.Label5, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.Controls.SetChildIndex(this.Label3, 0);
		this.Controls.SetChildIndex(this.UcDTVence, 0);
		this.Controls.SetChildIndex(this.Label2, 0);
		this.Controls.SetChildIndex(this.UcTxtReferencia, 0);
		this.Controls.SetChildIndex(this.BtnGrabar, 0);
		this.Controls.SetChildIndex(this.UcTxtObs, 0);
		this.Controls.SetChildIndex(this.UcDTIngreso, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.BtnCerrar, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmDocumentos_Load(object sender, EventArgs e)
	{
		UcCmbDocumento.ValueMember = "idDocumento";
		UcCmbDocumento.DisplayMember = "DescripDocumento";
		UcCmbDocumento.DataSource = DocumentoMapper.Instance().SelectAll();
		if (CodDocumento != 0)
		{
			Archivo archivo = ArchivoMapper.Instance().SelectOneBy([SpecialName] (Archivo v) => (v.IdEmpleado == CodEmple) & (v.idDocumento == CodDocumento));
			UcCmbDocumento.SelectedValue = archivo.idDocumento;
			UcCmbDocumento.Enabled = false;
			UcDTIngreso.Value = (DateTime)archivo.FechaIngreDoc;
			UcDTVence.Value = (DateTime)archivo.FechaVenDoc;
			UcTxtReferencia.Text = archivo.NumRef;
			UcTxtObs.Text = archivo.Obs;
		}
	}

	private void BtnGrabar_Click(object sender, EventArgs e)
	{
		Archivo.idDocumento = Conversions.ToInteger(UcCmbDocumento.SelectedValue);
		Archivo.IdEmpleado = CodEmple;
		Archivo.FechaIngreDoc = UcDTIngreso.Value;
		Archivo.FechaVenDoc = UcDTVence.Value;
		if (UcTxtReferencia.TextLength == 0)
		{
			Archivo.NumRef = ((CodDocumento == 0) ? null : RRHH.nulo);
		}
		else
		{
			Archivo.NumRef = UcTxtReferencia.Text;
		}
		if (UcTxtObs.TextLength == 0)
		{
			Archivo.Obs = ((CodDocumento == 0) ? null : RRHH.nulo);
		}
		else
		{
			Archivo.Obs = UcTxtObs.Text;
		}
		if (CodDocumento == 0)
		{
			ArchivoMapper.Instance().Insert(Archivo);
		}
		else
		{
			ArchivoMapper.Instance().Update(Archivo);
		}
		DialogResult = DialogResult.OK;
	}

	private void BtnCerrar_Click(object sender, EventArgs e)
	{
		Close();
	}
}
