using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.DataSet1TableAdapters;

namespace RecursosHumanos;

[DesignerGenerated]
public class Report_Emple_Ingreso : XtraReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Detail")]
	private DetailBand _Detail;

	[AccessedThroughProperty("PageHeader")]
	private PageHeaderBand _PageHeader;

	[AccessedThroughProperty("PageFooter")]
	private PageFooterBand _PageFooter;

	[AccessedThroughProperty("XrLabel3")]
	private XRLabel _XrLabel3;

	[AccessedThroughProperty("XrLabel2")]
	private XRLabel _XrLabel2;

	[AccessedThroughProperty("DataSet1")]
	private DataSet1 _DataSet1;

	[AccessedThroughProperty("SpRRHH_Ficha_ExpLabTableAdapter")]
	private spRRHH_Ficha_ExpLabTableAdapter _SpRRHH_Ficha_ExpLabTableAdapter;

	[AccessedThroughProperty("GroupHeader1")]
	private GroupHeaderBand _GroupHeader1;

	[AccessedThroughProperty("XrLabel6")]
	private XRLabel _XrLabel6;

	[AccessedThroughProperty("XrLabel5")]
	private XRLabel _XrLabel5;

	[AccessedThroughProperty("XrLabel4")]
	private XRLabel _XrLabel4;

	[AccessedThroughProperty("XrLabel1")]
	private XRLabel _XrLabel1;

	[AccessedThroughProperty("XrPageInfo2")]
	private XRPageInfo _XrPageInfo2;

	[AccessedThroughProperty("XrLabel8")]
	private XRLabel _XrLabel8;

	[AccessedThroughProperty("XrPageInfo1")]
	private XRPageInfo _XrPageInfo1;

	[AccessedThroughProperty("XrLabel7")]
	private XRLabel _XrLabel7;

	[AccessedThroughProperty("XrLabel9")]
	private XRLabel _XrLabel9;

	[AccessedThroughProperty("XrTable2")]
	private XRTable _XrTable2;

	[AccessedThroughProperty("XrTableRow2")]
	private XRTableRow _XrTableRow2;

	[AccessedThroughProperty("XrTableCell4")]
	private XRTableCell _XrTableCell4;

	[AccessedThroughProperty("XrTableCell5")]
	private XRTableCell _XrTableCell5;

	[AccessedThroughProperty("XrTableCell6")]
	private XRTableCell _XrTableCell6;

	[AccessedThroughProperty("XrTable1")]
	private XRTable _XrTable1;

	[AccessedThroughProperty("XrTableRow1")]
	private XRTableRow _XrTableRow1;

	[AccessedThroughProperty("XrTableCell1")]
	private XRTableCell _XrTableCell1;

	[AccessedThroughProperty("XrTableCell2")]
	private XRTableCell _XrTableCell2;

	[AccessedThroughProperty("XrTableCell3")]
	private XRTableCell _XrTableCell3;

	[AccessedThroughProperty("BottomMargin")]
	private BottomMarginBand _BottomMargin;

	[AccessedThroughProperty("XrPageInfo3")]
	private XRPageInfo _XrPageInfo3;

	[AccessedThroughProperty("SpRRHH_Report_FechaIngresoTableAdapter")]
	private spRRHH_Report_FechaIngresoTableAdapter _SpRRHH_Report_FechaIngresoTableAdapter;

	[AccessedThroughProperty("XrLabel10")]
	private XRLabel _XrLabel10;

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

	internal DataSet1 DataSet1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataSet1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataSet1 = value;
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

	internal XRPageInfo XrPageInfo2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrPageInfo2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrPageInfo2 = value;
		}
	}

	internal XRLabel XrLabel8
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel8 = value;
		}
	}

	internal XRPageInfo XrPageInfo1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrPageInfo1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrPageInfo1 = value;
		}
	}

	internal XRLabel XrLabel7
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel7 = value;
		}
	}

	internal XRLabel XrLabel9
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel9 = value;
		}
	}

	internal XRTable XrTable2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable2 = value;
		}
	}

	internal XRTableRow XrTableRow2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow2 = value;
		}
	}

	internal XRTableCell XrTableCell4
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell4 = value;
		}
	}

	internal XRTableCell XrTableCell5
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell5 = value;
		}
	}

	internal XRTableCell XrTableCell6
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell6 = value;
		}
	}

	internal XRTable XrTable1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable1 = value;
		}
	}

	internal XRTableRow XrTableRow1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow1 = value;
		}
	}

	internal XRTableCell XrTableCell1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell1 = value;
		}
	}

	internal XRTableCell XrTableCell2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell2 = value;
		}
	}

	internal XRTableCell XrTableCell3
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell3 = value;
		}
	}

	internal BottomMarginBand BottomMargin
	{
		[DebuggerNonUserCode]
		get
		{
			return _BottomMargin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BottomMargin = value;
		}
	}

	internal XRPageInfo XrPageInfo3
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrPageInfo3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrPageInfo3 = value;
		}
	}

	internal spRRHH_Report_FechaIngresoTableAdapter SpRRHH_Report_FechaIngresoTableAdapter
	{
		[DebuggerNonUserCode]
		get
		{
			return _SpRRHH_Report_FechaIngresoTableAdapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SpRRHH_Report_FechaIngresoTableAdapter = value;
		}
	}

	internal XRLabel XrLabel10
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel10 = value;
		}
	}

	[DebuggerNonUserCode]
	public Report_Emple_Ingreso()
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
		XrTable2 = new XRTable();
		XrTableRow2 = new XRTableRow();
		XrTableCell4 = new XRTableCell();
		XrTableCell5 = new XRTableCell();
		XrTableCell6 = new XRTableCell();
		XrLabel3 = new XRLabel();
		XrLabel2 = new XRLabel();
		PageHeader = new PageHeaderBand();
		PageFooter = new PageFooterBand();
		XrPageInfo2 = new XRPageInfo();
		XrLabel8 = new XRLabel();
		XrPageInfo1 = new XRPageInfo();
		XrLabel7 = new XRLabel();
		DataSet1 = new DataSet1();
		SpRRHH_Ficha_ExpLabTableAdapter = new spRRHH_Ficha_ExpLabTableAdapter();
		GroupHeader1 = new GroupHeaderBand();
		XrTable1 = new XRTable();
		XrTableRow1 = new XRTableRow();
		XrTableCell1 = new XRTableCell();
		XrTableCell2 = new XRTableCell();
		XrTableCell3 = new XRTableCell();
		XrLabel9 = new XRLabel();
		XrLabel6 = new XRLabel();
		XrLabel5 = new XRLabel();
		XrLabel4 = new XRLabel();
		XrLabel1 = new XRLabel();
		BottomMargin = new BottomMarginBand();
		XrPageInfo3 = new XRPageInfo();
		SpRRHH_Report_FechaIngresoTableAdapter = new spRRHH_Report_FechaIngresoTableAdapter();
		XrLabel10 = new XRLabel();
		((ISupportInitialize)XrTable2).BeginInit();
		((ISupportInitialize)DataSet1).BeginInit();
		((ISupportInitialize)XrTable1).BeginInit();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[3] { XrTable2, XrLabel3, XrLabel2 });
		Detail.Height = 25;
		Detail.Name = "Detail";
		DetailBand detail = Detail;
		PaddingInfo padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detail.Padding = padding;
		Detail.SortFields.AddRange(new GroupField[1]
		{
			new GroupField("NombresCompletos", XRColumnSortOrder.Ascending)
		});
		Detail.TextAlignment = TextAlignment.TopLeft;
		XrTable2.Font = new Font("Times New Roman", 9.75f);
		XRTable xrTable = XrTable2;
		Point location = new Point(217, 0);
		xrTable.Location = location;
		XrTable2.Name = "XrTable2";
		XRTable xrTable2 = XrTable2;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable2.Padding = padding;
		XrTable2.Rows.AddRange(new XRTableRow[1] { XrTableRow2 });
		XRTable xrTable3 = XrTable2;
		Size size = new Size(125, 25);
		xrTable3.Size = size;
		XrTable2.TextAlignment = TextAlignment.TopLeft;
		XrTableRow2.Cells.AddRange(new XRTableCell[3] { XrTableCell4, XrTableCell5, XrTableCell6 });
		XrTableRow2.Name = "XrTableRow2";
		XRTableRow xrTableRow = XrTableRow2;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow.Padding = padding;
		XrTableRow2.TextAlignment = TextAlignment.TopLeft;
		XrTableRow2.Weight = 1.0;
		XrTableCell4.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Report_FechaIngreso.años", "")
		});
		XrTableCell4.Name = "XrTableCell4";
		XRTableCell xrTableCell = XrTableCell4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell.Padding = padding;
		XrTableCell4.Text = "Años";
		XrTableCell4.TextAlignment = TextAlignment.TopLeft;
		XrTableCell4.Weight = 0.336;
		XrTableCell5.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Report_FechaIngreso.meses", "")
		});
		XrTableCell5.Name = "XrTableCell5";
		XRTableCell xrTableCell2 = XrTableCell5;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell2.Padding = padding;
		XrTableCell5.Text = "Meses";
		XrTableCell5.TextAlignment = TextAlignment.TopLeft;
		XrTableCell5.Weight = 0.336;
		XrTableCell6.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Report_FechaIngreso.dias", "")
		});
		XrTableCell6.Name = "XrTableCell6";
		XRTableCell xrTableCell3 = XrTableCell6;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell3.Padding = padding;
		XrTableCell6.Text = "Dias";
		XrTableCell6.TextAlignment = TextAlignment.TopLeft;
		XrTableCell6.Weight = 0.328;
		XrLabel3.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Report_FechaIngreso.FechadeIngreso", "{0:dd/MM/yyyy}")
		});
		XRLabel xrLabel = XrLabel3;
		location = new Point(92, 0);
		xrLabel.Location = location;
		XrLabel3.Name = "XrLabel3";
		XRLabel xrLabel2 = XrLabel3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.Padding = padding;
		XRLabel xrLabel3 = XrLabel3;
		size = new Size(125, 25);
		xrLabel3.Size = size;
		XrLabel3.Text = "XrLabel3";
		XrLabel3.TextAlignment = TextAlignment.TopLeft;
		XrLabel2.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Report_FechaIngreso.NombresCompletos", "")
		});
		XRLabel xrLabel4 = XrLabel2;
		location = new Point(342, 0);
		xrLabel4.Location = location;
		XrLabel2.Name = "XrLabel2";
		XRLabel xrLabel5 = XrLabel2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.Padding = padding;
		XRLabel xrLabel6 = XrLabel2;
		size = new Size(258, 25);
		xrLabel6.Size = size;
		XrLabel2.Text = "XrLabel2";
		XrLabel2.TextAlignment = TextAlignment.TopLeft;
		PageHeader.Controls.AddRange(new XRControl[1] { XrLabel10 });
		PageHeader.Height = 53;
		PageHeader.Name = "PageHeader";
		PageHeaderBand pageHeader = PageHeader;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		pageHeader.Padding = padding;
		PageHeader.TextAlignment = TextAlignment.TopLeft;
		PageFooter.Height = 0;
		PageFooter.Name = "PageFooter";
		PageFooterBand pageFooter = PageFooter;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		pageFooter.Padding = padding;
		PageFooter.TextAlignment = TextAlignment.TopLeft;
		XRPageInfo xrPageInfo = XrPageInfo2;
		location = new Point(400, 8);
		xrPageInfo.Location = location;
		XrPageInfo2.Name = "XrPageInfo2";
		XRPageInfo xrPageInfo2 = XrPageInfo2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo2.Padding = padding;
		XrPageInfo2.PageInfo = PageInfo.UserName;
		XRPageInfo xrPageInfo3 = XrPageInfo2;
		size = new Size(158, 25);
		xrPageInfo3.Size = size;
		XrPageInfo2.TextAlignment = TextAlignment.TopLeft;
		XrLabel8.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel7 = XrLabel8;
		location = new Point(358, 8);
		xrLabel7.Location = location;
		XrLabel8.Name = "XrLabel8";
		XRLabel xrLabel8 = XrLabel8;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.Padding = padding;
		XRLabel xrLabel9 = XrLabel8;
		size = new Size(33, 25);
		xrLabel9.Size = size;
		XrLabel8.Text = "Por:";
		XrLabel8.TextAlignment = TextAlignment.TopLeft;
		XrPageInfo1.Format = "{0:dddd, dd MMMM yyyy h:mm tt}";
		XRPageInfo xrPageInfo4 = XrPageInfo1;
		location = new Point(92, 8);
		xrPageInfo4.Location = location;
		XrPageInfo1.Name = "XrPageInfo1";
		XRPageInfo xrPageInfo5 = XrPageInfo1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo5.Padding = padding;
		XrPageInfo1.PageInfo = PageInfo.DateTime;
		XRPageInfo xrPageInfo6 = XrPageInfo1;
		size = new Size(233, 25);
		xrPageInfo6.Size = size;
		XrPageInfo1.TextAlignment = TextAlignment.TopLeft;
		XrLabel7.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel10 = XrLabel7;
		location = new Point(8, 8);
		xrLabel10.Location = location;
		XrLabel7.Name = "XrLabel7";
		XRLabel xrLabel11 = XrLabel7;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.Padding = padding;
		XRLabel xrLabel12 = XrLabel7;
		size = new Size(75, 25);
		xrLabel12.Size = size;
		XrLabel7.Text = "Impreso el:";
		XrLabel7.TextAlignment = TextAlignment.TopLeft;
		DataSet1.DataSetName = "DataSet1";
		DataSet1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		SpRRHH_Ficha_ExpLabTableAdapter.ClearBeforeFill = true;
		GroupHeader1.Controls.AddRange(new XRControl[6] { XrTable1, XrLabel9, XrLabel6, XrLabel5, XrLabel4, XrLabel1 });
		GroupHeader1.GroupFields.AddRange(new GroupField[1]
		{
			new GroupField("AreaOrganizacional", XRColumnSortOrder.Ascending)
		});
		GroupHeader1.Height = 92;
		GroupHeader1.Name = "GroupHeader1";
		GroupHeaderBand groupHeader = GroupHeader1;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		groupHeader.Padding = padding;
		GroupHeader1.TextAlignment = TextAlignment.TopLeft;
		XrTable1.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable4 = XrTable1;
		location = new Point(217, 75);
		xrTable4.Location = location;
		XrTable1.Name = "XrTable1";
		XRTable xrTable5 = XrTable1;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable5.Padding = padding;
		XrTable1.Rows.AddRange(new XRTableRow[1] { XrTableRow1 });
		XRTable xrTable6 = XrTable1;
		size = new Size(125, 17);
		xrTable6.Size = size;
		XrTable1.TextAlignment = TextAlignment.TopLeft;
		XrTableRow1.Cells.AddRange(new XRTableCell[3] { XrTableCell1, XrTableCell2, XrTableCell3 });
		XrTableRow1.Name = "XrTableRow1";
		XRTableRow xrTableRow2 = XrTableRow1;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow2.Padding = padding;
		XrTableRow1.TextAlignment = TextAlignment.TopLeft;
		XrTableRow1.Weight = 1.0;
		XrTableCell1.Name = "XrTableCell1";
		XRTableCell xrTableCell4 = XrTableCell1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell4.Padding = padding;
		XrTableCell1.Text = "Años";
		XrTableCell1.TextAlignment = TextAlignment.TopLeft;
		XrTableCell1.Weight = 0.336;
		XrTableCell2.Name = "XrTableCell2";
		XRTableCell xrTableCell5 = XrTableCell2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell5.Padding = padding;
		XrTableCell2.Text = "Meses";
		XrTableCell2.TextAlignment = TextAlignment.TopLeft;
		XrTableCell2.Weight = 0.336;
		XrTableCell3.Name = "XrTableCell3";
		XRTableCell xrTableCell6 = XrTableCell3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell6.Padding = padding;
		XrTableCell3.Text = "Dias";
		XrTableCell3.TextAlignment = TextAlignment.TopLeft;
		XrTableCell3.Weight = 0.328;
		XrLabel9.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel13 = XrLabel9;
		location = new Point(217, 58);
		xrLabel13.Location = location;
		XrLabel9.Name = "XrLabel9";
		XRLabel xrLabel14 = XrLabel9;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.Padding = padding;
		XRLabel xrLabel15 = XrLabel9;
		size = new Size(125, 17);
		xrLabel15.Size = size;
		XrLabel9.Text = "Tiempo de Servicio";
		XrLabel9.TextAlignment = TextAlignment.TopLeft;
		XrLabel6.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel16 = XrLabel6;
		location = new Point(343, 58);
		xrLabel16.Location = location;
		XrLabel6.Name = "XrLabel6";
		XRLabel xrLabel17 = XrLabel6;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel17.Padding = padding;
		XRLabel xrLabel18 = XrLabel6;
		size = new Size(250, 17);
		xrLabel18.Size = size;
		XrLabel6.Text = "Nombres Completos del Trabajador";
		XrLabel6.TextAlignment = TextAlignment.TopLeft;
		XrLabel5.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel19 = XrLabel5;
		location = new Point(92, 58);
		xrLabel19.Location = location;
		XrLabel5.Name = "XrLabel5";
		XRLabel xrLabel20 = XrLabel5;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel20.Padding = padding;
		XRLabel xrLabel21 = XrLabel5;
		size = new Size(125, 17);
		xrLabel21.Size = size;
		XrLabel5.Text = "Fecha de Ingreso";
		XrLabel5.TextAlignment = TextAlignment.TopLeft;
		XrLabel4.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel22 = XrLabel4;
		location = new Point(42, 17);
		xrLabel22.Location = location;
		XrLabel4.Name = "XrLabel4";
		XRLabel xrLabel23 = XrLabel4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel23.Padding = padding;
		XRLabel xrLabel24 = XrLabel4;
		size = new Size(58, 25);
		xrLabel24.Size = size;
		XrLabel4.Text = "Oficina:";
		XrLabel4.TextAlignment = TextAlignment.TopLeft;
		XrLabel1.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Report_FechaIngreso.AreaOrganizacional", "")
		});
		XrLabel1.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel25 = XrLabel1;
		location = new Point(100, 17);
		xrLabel25.Location = location;
		XrLabel1.Name = "XrLabel1";
		XRLabel xrLabel26 = XrLabel1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel26.Padding = padding;
		XRLabel xrLabel27 = XrLabel1;
		size = new Size(333, 25);
		xrLabel27.Size = size;
		XrLabel1.Text = "XrLabel1";
		XrLabel1.TextAlignment = TextAlignment.TopLeft;
		BottomMargin.Controls.AddRange(new XRControl[5] { XrPageInfo3, XrLabel8, XrPageInfo2, XrPageInfo1, XrLabel7 });
		BottomMargin.Height = 42;
		BottomMargin.Name = "BottomMargin";
		BottomMarginBand bottomMargin = BottomMargin;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		bottomMargin.Padding = padding;
		BottomMargin.TextAlignment = TextAlignment.TopLeft;
		XRPageInfo xrPageInfo7 = XrPageInfo3;
		location = new Point(625, 8);
		xrPageInfo7.Location = location;
		XrPageInfo3.Name = "XrPageInfo3";
		XRPageInfo xrPageInfo8 = XrPageInfo3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo8.Padding = padding;
		XRPageInfo xrPageInfo9 = XrPageInfo3;
		size = new Size(25, 25);
		xrPageInfo9.Size = size;
		XrPageInfo3.TextAlignment = TextAlignment.TopLeft;
		SpRRHH_Report_FechaIngresoTableAdapter.ClearBeforeFill = true;
		XrLabel10.Font = new Font("Times New Roman", 12f, FontStyle.Bold);
		XRLabel xrLabel28 = XrLabel10;
		location = new Point(33, 17);
		xrLabel28.Location = location;
		XrLabel10.Name = "XrLabel10";
		XRLabel xrLabel29 = XrLabel10;
		padding = new PaddingInfo(2, 2, 0, 0, 96f);
		xrLabel29.Padding = padding;
		XRLabel xrLabel30 = XrLabel10;
		size = new Size(233, 25);
		xrLabel30.Size = size;
		XrLabel10.StylePriority.UseFont = false;
		XrLabel10.Text = "Reporte por Fechas deIngreso";
		Bands.AddRange(new Band[5] { Detail, PageHeader, PageFooter, GroupHeader1, BottomMargin });
		DataAdapter = SpRRHH_Report_FechaIngresoTableAdapter;
		DataMember = "spRRHH_Report_FechaIngreso";
		DataSource = DataSet1;
		Margins = new Margins(100, 100, 100, 42);
		Version = "9.1";
		((ISupportInitialize)XrTable2).EndInit();
		((ISupportInitialize)DataSet1).EndInit();
		((ISupportInitialize)XrTable1).EndInit();
		((ISupportInitialize)this).EndInit();
	}

	public void xxx()
	{
	}
}
