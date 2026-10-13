using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GRLL.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmReport_Selec_Fechas : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("UcFechas1")]
	private ucFechas _UcFechas1;

	[AccessedThroughProperty("BtnGenerar")]
	private Button _BtnGenerar;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("UcCmBPresupuestal")]
	private ucComboBox _UcCmBPresupuestal;

	private FrmReport_Empleado_Ingre objReport_Empleado_Ingre;

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

	internal ucComboBox UcCmBPresupuestal
	{
		[DebuggerNonUserCode]
		get
		{
			return _UcCmBPresupuestal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UcCmBPresupuestal = value;
		}
	}

	public FrmReport_Selec_Fechas()
	{
		base.Load += FrmReport_Selec_Fechas_Load;
		__ENCAddToList(this);
		objReport_Empleado_Ingre = new FrmReport_Empleado_Ingre();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmReport_Selec_Fechas));
		this.UcFechas1 = new GRLL.Common.ucFechas();
		this.BtnGenerar = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.UcCmBPresupuestal = new GRLL.Common.ucComboBox();
		this.SuspendLayout();
		this.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.cmdCerrar.AutoSize = true;
		this.cmdCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cmdCerrar.FlatAppearance.BorderSize = 0;
		this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmdCerrar.Image = (System.Drawing.Image)resources.GetObject("cmdCerrar.Image");
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(329, 110);
		button.Location = location;
		System.Windows.Forms.Button button2 = this.cmdCerrar;
		System.Drawing.Size size = new System.Drawing.Size(61, 23);
		button2.Size = size;
		this.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.cmdCerrar.Visible = true;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		size = new System.Drawing.Size(402, 24);
		panelSup.Size = size;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 139);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(402, 27);
		panelInf2.Size = size;
		GRLL.Common.ucFechas ucFechas = this.UcFechas1;
		location = new System.Drawing.Point(12, 66);
		ucFechas.Location = location;
		this.UcFechas1.Name = "UcFechas1";
		GRLL.Common.ucFechas ucFechas2 = this.UcFechas1;
		size = new System.Drawing.Size(302, 22);
		ucFechas2.Size = size;
		this.UcFechas1.TabIndex = 0;
		this.BtnGenerar.AutoSize = true;
		this.BtnGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnGenerar.FlatAppearance.BorderSize = 0;
		this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnGenerar.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button btnGenerar = this.BtnGenerar;
		location = new System.Drawing.Point(320, 65);
		btnGenerar.Location = location;
		this.BtnGenerar.Name = "BtnGenerar";
		System.Windows.Forms.Button btnGenerar2 = this.BtnGenerar;
		size = new System.Drawing.Size(71, 23);
		btnGenerar2.Size = size;
		this.BtnGenerar.TabIndex = 6;
		this.BtnGenerar.Text = "Generar";
		this.BtnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BtnGenerar.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		System.Windows.Forms.Label label = this.Label1;
		location = new System.Drawing.Point(12, 42);
		label.Location = location;
		this.Label1.Name = "Label1";
		System.Windows.Forms.Label label2 = this.Label1;
		size = new System.Drawing.Size(107, 13);
		label2.Size = size;
		this.Label1.TabIndex = 7;
		this.Label1.Text = "Partida Presupuestal:";
		this.UcCmBPresupuestal.BorderColorActive = System.Drawing.Color.FromArgb(130, 165, 210);
		this.UcCmBPresupuestal.BorderColorInactive = System.Drawing.SystemColors.ControlDark;
		this.UcCmBPresupuestal.FormattingEnabled = true;
		this.UcCmBPresupuestal.IncluirNinguno = false;
		GRLL.Common.ucComboBox ucCmBPresupuestal = this.UcCmBPresupuestal;
		location = new System.Drawing.Point(125, 39);
		ucCmBPresupuestal.Location = location;
		this.UcCmBPresupuestal.Name = "UcCmBPresupuestal";
		GRLL.Common.ucComboBox ucCmBPresupuestal2 = this.UcCmBPresupuestal;
		size = new System.Drawing.Size(139, 21);
		ucCmBPresupuestal2.Size = size;
		this.UcCmBPresupuestal.TabIndex = 8;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Calculadora = false;
		size = new System.Drawing.Size(402, 166);
		this.ClientSize = size;
		this.Controls.Add(this.Label1);
		this.Controls.Add(this.UcCmBPresupuestal);
		this.Controls.Add(this.BtnGenerar);
		this.Controls.Add(this.UcFechas1);
		this.MessageShow = true;
		this.Name = "FrmReport_Selec_Fechas";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Fechas de Ingreso";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.UcFechas1, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.BtnGenerar, 0);
		this.Controls.SetChildIndex(this.UcCmBPresupuestal, 0);
		this.Controls.SetChildIndex(this.Label1, 0);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void BtnGenerar_Click(object sender, EventArgs e)
	{
		StartPosition = FormStartPosition.CenterParent;
		DateTime date = UcFechas1.Rango.Desde.Date;
		DateTime date2 = UcFechas1.Rango.Hasta.Date;
		if (DateTime.Compare(date2, date) < 0)
		{
			MessageBox.Show("La Fecha de Termino no puede ser menor que la de Inicio", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
			return;
		}
		List<Empleado> list = EmpleadoMapper.Instance().SelectBy([SpecialName] (Empleado v) =>
		{
			DateTime t = date;
			DateTime? fechaIngreso = v.FechaIngreso;
			bool? obj;
			if (!fechaIngreso.HasValue)
			{
				obj = null;
			}
			else
			{
				bool? flag = DateTime.Compare(fechaIngreso.GetValueOrDefault(), t) >= 0;
				obj = flag;
			}
			bool? flag2 = obj;
			DateTime t2 = date2;
			DateTime? fechaIngreso2 = v.FechaIngreso;
			bool? obj2;
			if (!fechaIngreso2.HasValue)
			{
				obj2 = null;
			}
			else
			{
				bool? flag3 = DateTime.Compare(fechaIngreso2.GetValueOrDefault(), t2) <= 0;
				obj2 = flag3;
			}
			bool? flag4 = obj2;
			bool? obj3;
			if (flag2 ?? true)
			{
				if (!flag4.HasValue)
				{
					obj3 = null;
				}
				else if (flag4 != true)
				{
					bool? flag5 = false;
					obj3 = flag5;
				}
				else
				{
					obj3 = flag2;
				}
			}
			else
			{
				bool? flag6 = false;
				obj3 = flag6;
			}
			bool? flag7 = obj3;
			bool? flag9;
			if (!v.FechaIngreso.HasValue)
			{
				bool? flag8 = false;
				flag9 = flag8;
			}
			else
			{
				flag9 = flag7;
			}
			return (bool)flag9;
		}).ToList();
		if (list.Count <= 0)
		{
			MessageBox.Show("No existen Trabajadores, registrados entre esas Fechas", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
			return;
		}
		objReport_Empleado_Ingre.fi = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(date.Year.ToString(), Interaction.IIf(date.Month.ToString().Length == 1, "0" + date.Month, date.Month.ToString())), Interaction.IIf(date.Day.ToString().Length == 1, "0" + date.Day, date.Day.ToString())));
		objReport_Empleado_Ingre.ft = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(date2.Year.ToString(), Interaction.IIf(date2.Month.ToString().Length == 1, "0" + date2.Month, date2.Month.ToString())), Interaction.IIf(date2.Day.ToString().Length == 1, "0" + date2.Day, date2.Day.ToString())));
		objReport_Empleado_Ingre.tipo = Conversions.ToInteger(UcCmBPresupuestal.SelectedValue);
		objReport_Empleado_Ingre.WindowState = FormWindowState.Maximized;
		objReport_Empleado_Ingre.MdiParent = MyProject.Forms.MainMDI;
		objReport_Empleado_Ingre.Show();
		Close();
	}

	private void FrmReport_Selec_Fechas_Load(object sender, EventArgs e)
	{
		UcCmBPresupuestal.ValueMember = "IdTipoTrabajador";
		UcCmBPresupuestal.DisplayMember = "Descripcion";
		List<TipoTrabajador> dataSource = TipoTrabajadorMapper.Instance().SelectAll();
		UcCmBPresupuestal.DataSource = dataSource;
	}
}
