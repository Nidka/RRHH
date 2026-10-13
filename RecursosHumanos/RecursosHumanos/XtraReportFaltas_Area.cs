using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.DataSet1TableAdapters;

namespace RecursosHumanos;

[DesignerGenerated]
public class XtraReportFaltas_Area : XtraReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Detail")]
	private DetailBand _Detail;

	[AccessedThroughProperty("PageHeader")]
	private PageHeaderBand _PageHeader;

	[AccessedThroughProperty("PageFooter")]
	private PageFooterBand _PageFooter;

	[AccessedThroughProperty("GroupHeader1")]
	private GroupHeaderBand _GroupHeader1;

	[AccessedThroughProperty("GroupHeader2")]
	private GroupHeaderBand _GroupHeader2;

	[AccessedThroughProperty("XrLabel3")]
	private XRLabel _XrLabel3;

	[AccessedThroughProperty("XrLabel2")]
	private XRLabel _XrLabel2;

	[AccessedThroughProperty("XrLabel1")]
	private XRLabel _XrLabel1;

	[AccessedThroughProperty("DataSet11")]
	private DataSet1 _DataSet11;

	[AccessedThroughProperty("SpRRHH_Ficha_ExpLabTableAdapter")]
	private spRRHH_Ficha_ExpLabTableAdapter _SpRRHH_Ficha_ExpLabTableAdapter;

	[AccessedThroughProperty("XrLabel6")]
	private XRLabel _XrLabel6;

	[AccessedThroughProperty("XrLabel5")]
	private XRLabel _XrLabel5;

	[AccessedThroughProperty("XrLabel4")]
	private XRLabel _XrLabel4;

	internal DetailBand Detail
	{
		[DebuggerNonUserCode]
		get
		{
			return _Detail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Detail = value;
		}
	}

	internal PageHeaderBand PageHeader
	{
		[DebuggerNonUserCode]
		get
		{
			return _PageHeader;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PageHeader = value;
		}
	}

	internal PageFooterBand PageFooter
	{
		[DebuggerNonUserCode]
		get
		{
			return _PageFooter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PageFooter = value;
		}
	}

	internal GroupHeaderBand GroupHeader1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupHeader1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupHeader1 = value;
		}
	}

	internal GroupHeaderBand GroupHeader2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupHeader2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupHeader2 = value;
		}
	}

	internal XRLabel XrLabel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel3 = value;
		}
	}

	internal XRLabel XrLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel2 = value;
		}
	}

	internal XRLabel XrLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel1 = value;
		}
	}

	internal DataSet1 DataSet11
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataSet11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataSet11 = value;
		}
	}

	internal spRRHH_Ficha_ExpLabTableAdapter SpRRHH_Ficha_ExpLabTableAdapter
	{
		[DebuggerNonUserCode]
		get
		{
			return _SpRRHH_Ficha_ExpLabTableAdapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SpRRHH_Ficha_ExpLabTableAdapter = value;
		}
	}

	internal XRLabel XrLabel6
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel6 = value;
		}
	}

	internal XRLabel XrLabel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel5 = value;
		}
	}

	internal XRLabel XrLabel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel4 = value;
		}
	}

	[DebuggerNonUserCode]
	public XtraReportFaltas_Area()
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
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		Detail = new DetailBand();
		XrLabel3 = new XRLabel();
		PageHeader = new PageHeaderBand();
		XrLabel6 = new XRLabel();
		XrLabel5 = new XRLabel();
		XrLabel4 = new XRLabel();
		PageFooter = new PageFooterBand();
		GroupHeader1 = new GroupHeaderBand();
		XrLabel2 = new XRLabel();
		GroupHeader2 = new GroupHeaderBand();
		XrLabel1 = new XRLabel();
		DataSet11 = new DataSet1();
		SpRRHH_Ficha_ExpLabTableAdapter = new spRRHH_Ficha_ExpLabTableAdapter();
		((ISupportInitialize)DataSet11).BeginInit();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[1] { XrLabel3 });
		Detail.Height = 25;
		Detail.Name = "Detail";
		XrLabel3.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Faltas.NombresC", "")
		});
		XRLabel xrLabel = XrLabel3;
		Point location = new Point(167, 0);
		xrLabel.Location = location;
		XrLabel3.Name = "XrLabel3";
		XRLabel xrLabel2 = XrLabel3;
		PaddingInfo padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.Padding = padding;
		XrLabel3.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel3 = XrLabel3;
		Size size = new Size(483, 25);
		xrLabel3.Size = size;
		XrLabel3.Text = "XrLabel3";
		PageHeader.Controls.AddRange(new XRControl[3] { XrLabel6, XrLabel5, XrLabel4 });
		PageHeader.Height = 84;
		PageHeader.KeepTogether = true;
		PageHeader.Name = "PageHeader";
		XrLabel6.CanShrink = true;
		XrLabel6.Font = new Font("Times New Roman", 9.75f, FontStyle.Italic);
		XRLabel xrLabel4 = XrLabel6;
		location = new Point(283, 42);
		xrLabel4.Location = location;
		XrLabel6.Name = "XrLabel6";
		XRLabel xrLabel5 = XrLabel6;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.Padding = padding;
		XrLabel6.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel6 = XrLabel6;
		size = new Size(217, 25);
		xrLabel6.Size = size;
		XrLabel6.Text = "XrLabel6";
		XrLabel5.Font = new Font("Times New Roman", 9.75f, FontStyle.Italic);
		XRLabel xrLabel7 = XrLabel5;
		location = new Point(225, 42);
		xrLabel7.Location = location;
		XrLabel5.Name = "XrLabel5";
		XRLabel xrLabel8 = XrLabel5;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.Padding = padding;
		XrLabel5.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel9 = XrLabel5;
		size = new Size(50, 25);
		xrLabel9.Size = size;
		XrLabel5.Text = "Fecha:";
		XrLabel4.Font = new Font("Times New Roman", 14f);
		XRLabel xrLabel10 = XrLabel4;
		location = new Point(225, 8);
		xrLabel10.Location = location;
		XrLabel4.Name = "XrLabel4";
		XRLabel xrLabel11 = XrLabel4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.Padding = padding;
		XrLabel4.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel12 = XrLabel4;
		size = new Size(167, 25);
		xrLabel12.Size = size;
		XrLabel4.Text = "Reporte de Faltas";
		PageFooter.Height = 30;
		PageFooter.Name = "PageFooter";
		GroupHeader1.Controls.AddRange(new XRControl[1] { XrLabel2 });
		GroupHeader1.GroupFields.AddRange(new GroupField[1]
		{
			new GroupField("Descripcion", XRColumnSortOrder.Ascending)
		});
		GroupHeader1.Height = 25;
		GroupHeader1.Name = "GroupHeader1";
		XrLabel2.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Faltas.Descripcion", "")
		});
		XrLabel2.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Italic);
		XRLabel xrLabel13 = XrLabel2;
		location = new Point(100, 0);
		xrLabel13.Location = location;
		XrLabel2.Name = "XrLabel2";
		XRLabel xrLabel14 = XrLabel2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.Padding = padding;
		XrLabel2.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel15 = XrLabel2;
		size = new Size(125, 25);
		xrLabel15.Size = size;
		XrLabel2.Text = "XrLabel2";
		GroupHeader2.Controls.AddRange(new XRControl[1] { XrLabel1 });
		GroupHeader2.GroupFields.AddRange(new GroupField[1]
		{
			new GroupField("AreaOrganizacional", XRColumnSortOrder.Ascending)
		});
		GroupHeader2.Height = 25;
		GroupHeader2.Level = 1;
		GroupHeader2.Name = "GroupHeader2";
		XrLabel1.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Faltas.AreaOrganizacional", "")
		});
		XrLabel1.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel16 = XrLabel1;
		location = new Point(8, 0);
		xrLabel16.Location = location;
		XrLabel1.Name = "XrLabel1";
		XRLabel xrLabel17 = XrLabel1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel17.Padding = padding;
		XrLabel1.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel18 = XrLabel1;
		size = new Size(183, 25);
		xrLabel18.Size = size;
		XrLabel1.Text = "XrLabel1";
		DataSet11.DataSetName = "DataSet1";
		DataSet11.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Bands.AddRange(new Band[5] { Detail, PageHeader, PageFooter, GroupHeader1, GroupHeader2 });
		DataAdapter = SpRRHH_Ficha_ExpLabTableAdapter;
		DataMember = "spRRHH_Faltas";
		DataSource = DataSet11;
		((ISupportInitialize)DataSet11).EndInit();
		((ISupportInitialize)this).EndInit();
	}
}
