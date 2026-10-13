using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmRelacionSalidaAutorizada : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("DefaultLookAndFeel1")]
	private DefaultLookAndFeel _DefaultLookAndFeel1;

	[AccessedThroughProperty("GridControl1")]
	private GridControl _GridControl1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

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

	internal GridControl GridControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridControl1 = value;
		}
	}

	internal GridView GridView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GridView1 = value;
		}
	}

	internal Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button1 = value;
		}
	}

	[DebuggerNonUserCode]
	public FrmRelacionSalidaAutorizada()
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
		this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.Button1 = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).BeginInit();
		this.SuspendLayout();
		System.Windows.Forms.Button button = this.cmdCerrar;
		System.Drawing.Point location = new System.Drawing.Point(569, 376);
		button.Location = location;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, 416);
		panelInf.Location = location;
		this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
		DevExpress.XtraGrid.GridControl gridControl = this.GridControl1;
		location = new System.Drawing.Point(12, 53);
		gridControl.Location = location;
		this.GridControl1.MainView = this.GridView1;
		this.GridControl1.Name = "GridControl1";
		DevExpress.XtraGrid.GridControl gridControl2 = this.GridControl1;
		System.Drawing.Size size = new System.Drawing.Size(620, 317);
		gridControl2.Size = size;
		this.GridControl1.TabIndex = 3;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.GridView1 });
		this.GridView1.GridControl = this.GridControl1;
		this.GridView1.Name = "GridView1";
		System.Windows.Forms.Button button2 = this.Button1;
		location = new System.Drawing.Point(12, 376);
		button2.Location = location;
		this.Button1.Name = "Button1";
		System.Windows.Forms.Button button3 = this.Button1;
		size = new System.Drawing.Size(99, 23);
		button3.Size = size;
		this.Button1.TabIndex = 4;
		this.Button1.Text = "Autorizar Salida";
		this.Button1.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(644, 443);
		this.ClientSize = size;
		this.Controls.Add(this.GridControl1);
		this.Controls.Add(this.Button1);
		this.MessageShow = true;
		this.Name = "FrmRelacionSalidaAutorizada";
		this.TitleMsg = "FrmConsulta";
		this.Titulo = "Relacion Salida Autorizada";
		this.VerCmdCerrar = true;
		this.Controls.SetChildIndex(this.Button1, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.GridControl1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView1).EndInit();
		this.ResumeLayout(false);
	}
}
