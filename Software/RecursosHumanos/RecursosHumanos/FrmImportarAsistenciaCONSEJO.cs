using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using GRLL.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmImportarAsistenciaCONSEJO : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("LabelControl1")]
	private LabelControl _LabelControl1;

	[AccessedThroughProperty("PictureEdit1")]
	private PictureEdit _PictureEdit1;

	[AccessedThroughProperty("GroupControl1")]
	private GroupControl _GroupControl1;

	[AccessedThroughProperty("CheckEditForzar")]
	private CheckEdit _CheckEditForzar;

	[AccessedThroughProperty("BtnGenerar")]
	private Button _BtnGenerar;

	[AccessedThroughProperty("UcFechas1")]
	private ucFechas _UcFechas1;

	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	internal LabelControl LabelControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelControl1 = value;
		}
	}

	internal PictureEdit PictureEdit1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureEdit1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureEdit1 = value;
		}
	}

	internal GroupControl GroupControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupControl1 = value;
		}
	}

	internal CheckEdit CheckEditForzar
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckEditForzar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckEditForzar = value;
		}
	}

	internal Button BtnGenerar
	{
		[DebuggerNonUserCode]
		get
		{
			return _BtnGenerar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = BtnGenerar_Click;
			if (_BtnGenerar != null)
			{
				_BtnGenerar.Click -= value2;
			}
			_BtnGenerar = value;
			if (_BtnGenerar != null)
			{
				_BtnGenerar.Click += value2;
			}
		}
	}

	internal ucFechas UcFechas1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcFechas1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcFechas1 = value;
		}
	}

	internal BackgroundWorker BackgroundWorker1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
			RunWorkerCompletedEventHandler value3 = BackgroundWorker1_RunWorkerCompleted;
			if (_BackgroundWorker1 != null)
			{
				_BackgroundWorker1.DoWork -= value2;
				_BackgroundWorker1.RunWorkerCompleted -= value3;
			}
			_BackgroundWorker1 = value;
			if (_BackgroundWorker1 != null)
			{
				_BackgroundWorker1.DoWork += value2;
				_BackgroundWorker1.RunWorkerCompleted += value3;
			}
		}
	}

	internal DefaultLookAndFeel DefaultLookAndFeel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DefaultLookAndFeel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DefaultLookAndFeel1 = value;
		}
	}

	[DebuggerNonUserCode]
	public FrmImportarAsistenciaCONSEJO()
	{
		__ENCAddToList(this);
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
		this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
		this.PictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
		this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
		this.CheckEditForzar = new DevExpress.XtraEditors.CheckEdit();
		this.BtnGenerar = new System.Windows.Forms.Button();
		this.UcFechas1 = new GRLL.Common.ucFechas();
		this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		((System.ComponentModel.ISupportInitialize)this.PictureEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
		this.GroupControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CheckEditForzar.Properties).BeginInit();
		this.SuspendLayout();
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = RecursosHumanos.My.Resources.Resources._exit;
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(348, 145);
		button.Location = location;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		System.Drawing.Size size = new System.Drawing.Size(423, 29);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 190);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(423, 27);
		panelInf2.Size = size;
		this.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold);
		this.LabelControl1.Appearance.ForeColor = System.Drawing.Color.DarkRed;
		this.LabelControl1.Appearance.Options.UseFont = true;
		this.LabelControl1.Appearance.Options.UseForeColor = true;
		DevExpress.XtraEditors.LabelControl labelControl = this.LabelControl1;
		location = new System.Drawing.Point(62, 150);
		labelControl.Location = location;
		this.LabelControl1.Name = "LabelControl1";
		DevExpress.XtraEditors.LabelControl labelControl2 = this.LabelControl1;
		size = new System.Drawing.Size(191, 14);
		labelControl2.Size = size;
		this.LabelControl1.TabIndex = 11;
		this.LabelControl1.Text = "Importando, espere porfavor...";
		this.LabelControl1.Visible = false;
		this.PictureEdit1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.PictureEdit1.EditValue = RecursosHumanos.My.Resources.Resources.cargando;
		DevExpress.XtraEditors.PictureEdit pictureEdit = this.PictureEdit1;
		location = new System.Drawing.Point(9, 140);
		pictureEdit.Location = location;
		this.PictureEdit1.Name = "PictureEdit1";
		DevExpress.XtraEditors.PictureEdit pictureEdit2 = this.PictureEdit1;
		size = new System.Drawing.Size(38, 35);
		pictureEdit2.Size = size;
		this.PictureEdit1.TabIndex = 10;
		this.PictureEdit1.Visible = false;
		this.GroupControl1.Controls.Add(this.CheckEditForzar);
		this.GroupControl1.Controls.Add(this.BtnGenerar);
		this.GroupControl1.Controls.Add(this.UcFechas1);
		DevExpress.XtraEditors.GroupControl groupControl = this.GroupControl1;
		location = new System.Drawing.Point(12, 35);
		groupControl.Location = location;
		this.GroupControl1.Name = "GroupControl1";
		DevExpress.XtraEditors.GroupControl groupControl2 = this.GroupControl1;
		size = new System.Drawing.Size(404, 95);
		groupControl2.Size = size;
		this.GroupControl1.TabIndex = 9;
		this.GroupControl1.Text = "Parámetros";
		DevExpress.XtraEditors.CheckEdit checkEditForzar = this.CheckEditForzar;
		location = new System.Drawing.Point(20, 64);
		checkEditForzar.Location = location;
		this.CheckEditForzar.Name = "CheckEditForzar";
		this.CheckEditForzar.Properties.Caption = "Forzar Importacion";
		DevExpress.XtraEditors.CheckEdit checkEditForzar2 = this.CheckEditForzar;
		size = new System.Drawing.Size(123, 18);
		checkEditForzar2.Size = size;
		this.CheckEditForzar.TabIndex = 4;
		this.BtnGenerar.AutoSize = true;
		this.BtnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGenerar.FlatAppearance.BorderSize = 0;
		this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGenerar.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button btnGenerar = this.BtnGenerar;
		location = new System.Drawing.Point(328, 35);
		btnGenerar.Location = location;
		this.BtnGenerar.Name = "BtnGenerar";
		System.Windows.Forms.Button btnGenerar2 = this.BtnGenerar;
		size = new System.Drawing.Size(71, 23);
		btnGenerar2.Size = size;
		this.BtnGenerar.TabIndex = 3;
		this.BtnGenerar.Text = "Generar";
		this.BtnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGenerar.UseVisualStyleBackColor = true;
		GRLL.Common.ucFechas ucFechas = this.UcFechas1;
		location = new System.Drawing.Point(20, 36);
		ucFechas.Location = location;
		this.UcFechas1.Name = "UcFechas1";
		GRLL.Common.ucFechas ucFechas2 = this.UcFechas1;
		size = new System.Drawing.Size(302, 22);
		ucFechas2.Size = size;
		this.UcFechas1.TabIndex = 2;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(423, 217);
		this.ClientSize = size;
		this.Controls.Add(this.LabelControl1);
		this.Controls.Add(this.PictureEdit1);
		this.Controls.Add(this.GroupControl1);
		this.MessageShow = true;
		this.Name = "FrmImportarAsistenciaCONSEJO";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Importar Asistencia Marcacion - CONSEJO";
		this.TituloFrm = "Importar Asistencia Marcacion - CONSEJO";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GroupControl1, 0);
		this.Controls.SetChildIndex(this.PictureEdit1, 0);
		this.Controls.SetChildIndex(this.LabelControl1, 0);
		((System.ComponentModel.ISupportInitialize)this.PictureEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
		this.GroupControl1.ResumeLayout(false);
		this.GroupControl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.CheckEditForzar.Properties).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void BtnGenerar_Click(object sender, EventArgs e)
	{
		PictureEdit1.Visible = true;
		LabelControl1.Visible = true;
		BackgroundWorker1.RunWorkerAsync();
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		AsistenciaAccess asistenciaAccess = new AsistenciaAccess();
		string fechaInicial = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Desde.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Desde.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Month, UcFechas1.Rango.Desde.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Desde.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Desde.Day, UcFechas1.Rango.Desde.Day.ToString())));
		string fechaFinal = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(UcFechas1.Rango.Hasta.Year.ToString(), Interaction.IIf(UcFechas1.Rango.Hasta.Month.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Month, UcFechas1.Rango.Hasta.Month.ToString())), Interaction.IIf(UcFechas1.Rango.Hasta.Day.ToString().Length == 1, "0" + UcFechas1.Rango.Hasta.Day, UcFechas1.Rango.Hasta.Day.ToString())));
		if (asistenciaAccess.Access2SqlCONSEJO(fechaInicial, fechaFinal, Conversions.ToInteger(Interaction.IIf(CheckEditForzar.Checked, 1, 0))))
		{
			MessageBox.Show("La importación se realizó con exitó", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
		}
		else
		{
			MessageBox.Show("La importación NO se completó", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
		}
	}

	private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		PictureEdit1.Visible = false;
		LabelControl1.Visible = false;
	}
}
