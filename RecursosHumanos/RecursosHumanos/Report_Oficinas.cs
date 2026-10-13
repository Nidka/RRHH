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
public class Report_Oficinas : XtraReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Detail")]
	private DetailBand _Detail;

	[AccessedThroughProperty("PageHeader")]
	private PageHeaderBand _PageHeader;

	[AccessedThroughProperty("PageFooter")]
	private PageFooterBand _PageFooter;

	[AccessedThroughProperty("XrLabel2")]
	private XRLabel _XrLabel2;

	[AccessedThroughProperty("DataSet11")]
	private DataSet1 _DataSet11;

	[AccessedThroughProperty("SpRRHH_Ficha_ExpLabTableAdapter")]
	private spRRHH_Ficha_ExpLabTableAdapter _SpRRHH_Ficha_ExpLabTableAdapter;

	[AccessedThroughProperty("GroupHeader1")]
	private GroupHeaderBand _GroupHeader1;

	[AccessedThroughProperty("XrLabel1")]
	private XRLabel _XrLabel1;

	[AccessedThroughProperty("XrLabel3")]
	private XRLabel _XrLabel3;

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
	public Report_Oficinas()
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
		XrLabel2 = new XRLabel();
		PageHeader = new PageHeaderBand();
		PageFooter = new PageFooterBand();
		DataSet11 = new DataSet1();
		SpRRHH_Ficha_ExpLabTableAdapter = new spRRHH_Ficha_ExpLabTableAdapter();
		GroupHeader1 = new GroupHeaderBand();
		XrLabel4 = new XRLabel();
		XrLabel3 = new XRLabel();
		XrLabel1 = new XRLabel();
		((ISupportInitialize)DataSet11).BeginInit();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[1] { XrLabel2 });
		Detail.Height = 26;
		Detail.Name = "Detail";
		Detail.SortFields.AddRange(new GroupField[1]
		{
			new GroupField("NombresCompletos", XRColumnSortOrder.Ascending)
		});
		XrLabel2.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "sprrhh_prueba1.NombresCompletos", "")
		});
		XRLabel xrLabel = XrLabel2;
		Point location = new Point(133, 0);
		xrLabel.Location = location;
		XrLabel2.Name = "XrLabel2";
		XRLabel xrLabel2 = XrLabel2;
		PaddingInfo padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.Padding = padding;
		XRLabel xrLabel3 = XrLabel2;
		Size size = new Size(342, 25);
		xrLabel3.Size = size;
		XrLabel2.Text = "XrLabel2";
		PageHeader.Height = 26;
		PageHeader.Name = "PageHeader";
		PageFooter.Height = 30;
		PageFooter.Name = "PageFooter";
		DataSet11.DataSetName = "DataSet1";
		DataSet11.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		GroupHeader1.Controls.AddRange(new XRControl[3] { XrLabel4, XrLabel3, XrLabel1 });
		GroupHeader1.GroupFields.AddRange(new GroupField[1]
		{
			new GroupField("AreaOrganizacional", XRColumnSortOrder.Ascending)
		});
		GroupHeader1.Height = 92;
		GroupHeader1.Name = "GroupHeader1";
		XrLabel4.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel4 = XrLabel4;
		location = new Point(133, 67);
		xrLabel4.Location = location;
		XrLabel4.Name = "XrLabel4";
		XRLabel xrLabel5 = XrLabel4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.Padding = padding;
		XrLabel4.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel6 = XrLabel4;
		size = new Size(342, 25);
		xrLabel6.Size = size;
		XrLabel4.Text = "Nombres Completos del Trabajador";
		XrLabel3.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel7 = XrLabel3;
		location = new Point(33, 25);
		xrLabel7.Location = location;
		XrLabel3.Name = "XrLabel3";
		XRLabel xrLabel8 = XrLabel3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.Padding = padding;
		XrLabel3.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel9 = XrLabel3;
		size = new Size(67, 25);
		xrLabel9.Size = size;
		XrLabel3.Text = "Oficina:";
		XrLabel1.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "sprrhh_prueba1.AreaOrganizacional", "")
		});
		XrLabel1.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel10 = XrLabel1;
		location = new Point(100, 25);
		xrLabel10.Location = location;
		XrLabel1.Name = "XrLabel1";
		XRLabel xrLabel11 = XrLabel1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.Padding = padding;
		XrLabel1.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel12 = XrLabel1;
		size = new Size(333, 25);
		xrLabel12.Size = size;
		XrLabel1.Text = "XrLabel1";
		Bands.AddRange(new Band[4] { Detail, PageHeader, PageFooter, GroupHeader1 });
		DataAdapter = SpRRHH_Ficha_ExpLabTableAdapter;
		DataMember = "sprrhh_prueba1";
		DataSource = DataSet11;
		((ISupportInitialize)DataSet11).EndInit();
		((ISupportInitialize)this).EndInit();
	}
}
