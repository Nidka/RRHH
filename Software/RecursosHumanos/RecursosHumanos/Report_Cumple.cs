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
public class Report_Cumple : XtraReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Detail")]
	private DetailBand _Detail;

	[AccessedThroughProperty("PageHeader")]
	private PageHeaderBand _PageHeader;

	[AccessedThroughProperty("PageFooter")]
	private PageFooterBand _PageFooter;

	[AccessedThroughProperty("DataSet11")]
	private DataSet1 _DataSet11;

	[AccessedThroughProperty("SpRRHH_Report_CuadroPerTableAdapter")]
	private spRRHH_Report_CuadroPerTableAdapter _SpRRHH_Report_CuadroPerTableAdapter;

	[AccessedThroughProperty("GroupHeader1")]
	private GroupHeaderBand _GroupHeader1;

	[AccessedThroughProperty("XrTable1")]
	private XRTable _XrTable1;

	[AccessedThroughProperty("XrTableRow1")]
	private XRTableRow _XrTableRow1;

	[AccessedThroughProperty("XrTableCell1")]
	private XRTableCell _XrTableCell1;

	[AccessedThroughProperty("XrTableCell2")]
	private XRTableCell _XrTableCell2;

	[AccessedThroughProperty("XrTable2")]
	private XRTable _XrTable2;

	[AccessedThroughProperty("XrTableRow2")]
	private XRTableRow _XrTableRow2;

	[AccessedThroughProperty("XrTableCell3")]
	private XRTableCell _XrTableCell3;

	[AccessedThroughProperty("XrTableCell4")]
	private XRTableCell _XrTableCell4;

	[AccessedThroughProperty("XrLabel2")]
	private XRLabel _XrLabel2;

	[AccessedThroughProperty("ReportHeader")]
	private ReportHeaderBand _ReportHeader;

	[AccessedThroughProperty("XrLabel3")]
	private XRLabel _XrLabel3;

	[AccessedThroughProperty("XrTableCell6")]
	private XRTableCell _XrTableCell6;

	[AccessedThroughProperty("XrTableCell5")]
	private XRTableCell _XrTableCell5;

	[AccessedThroughProperty("XrPageInfo2")]
	private XRPageInfo _XrPageInfo2;

	[AccessedThroughProperty("XrLabel4")]
	private XRLabel _XrLabel4;

	[AccessedThroughProperty("XrPageInfo1")]
	private XRPageInfo _XrPageInfo1;

	[AccessedThroughProperty("XrLabel1")]
	private XRLabel _XrLabel1;

	[AccessedThroughProperty("BottomMargin")]
	private BottomMarginBand _BottomMargin;

	[AccessedThroughProperty("XrTableCell7")]
	private XRTableCell _XrTableCell7;

	[AccessedThroughProperty("XrTableCell8")]
	private XRTableCell _XrTableCell8;

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

	internal spRRHH_Report_CuadroPerTableAdapter SpRRHH_Report_CuadroPerTableAdapter
	{
		[DebuggerNonUserCode]
		get
		{
			return _SpRRHH_Report_CuadroPerTableAdapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SpRRHH_Report_CuadroPerTableAdapter = value;
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

	internal ReportHeaderBand ReportHeader
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReportHeader;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReportHeader = value;
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

	internal XRTableCell XrTableCell7
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell7 = value;
		}
	}

	internal XRTableCell XrTableCell8
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell8 = value;
		}
	}

	[DebuggerNonUserCode]
	public Report_Cumple()
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
		XrTable1 = new XRTable();
		XrTableRow1 = new XRTableRow();
		XrTableCell1 = new XRTableCell();
		XrTableCell8 = new XRTableCell();
		XrTableCell2 = new XRTableCell();
		XrTableCell6 = new XRTableCell();
		PageHeader = new PageHeaderBand();
		PageFooter = new PageFooterBand();
		DataSet11 = new DataSet1();
		SpRRHH_Report_CuadroPerTableAdapter = new spRRHH_Report_CuadroPerTableAdapter();
		GroupHeader1 = new GroupHeaderBand();
		XrTable2 = new XRTable();
		XrTableRow2 = new XRTableRow();
		XrTableCell3 = new XRTableCell();
		XrTableCell7 = new XRTableCell();
		XrTableCell4 = new XRTableCell();
		XrTableCell5 = new XRTableCell();
		XrLabel2 = new XRLabel();
		ReportHeader = new ReportHeaderBand();
		XrLabel3 = new XRLabel();
		XrLabel1 = new XRLabel();
		XrPageInfo1 = new XRPageInfo();
		XrLabel4 = new XRLabel();
		XrPageInfo2 = new XRPageInfo();
		BottomMargin = new BottomMarginBand();
		((ISupportInitialize)XrTable1).BeginInit();
		((ISupportInitialize)DataSet11).BeginInit();
		((ISupportInitialize)XrTable2).BeginInit();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[1] { XrTable1 });
		Detail.Height = 26;
		Detail.Name = "Detail";
		Detail.SortFields.AddRange(new GroupField[2]
		{
			new GroupField("Dia", XRColumnSortOrder.Ascending),
			new GroupField("NombresCompletos", XRColumnSortOrder.Ascending)
		});
		XRTable xrTable = XrTable1;
		Point location = new Point(33, 0);
		xrTable.Location = location;
		XrTable1.Name = "XrTable1";
		XrTable1.Rows.AddRange(new XRTableRow[1] { XrTableRow1 });
		XRTable xrTable2 = XrTable1;
		Size size = new Size(592, 25);
		xrTable2.Size = size;
		XrTableRow1.Cells.AddRange(new XRTableCell[4] { XrTableCell1, XrTableCell8, XrTableCell2, XrTableCell6 });
		XrTableRow1.Name = "XrTableRow1";
		XRTableRow xrTableRow = XrTableRow1;
		size = new Size(592, 25);
		xrTableRow.Size = size;
		XrTableCell1.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Report_Cumple.Dia", "")
		});
		XRTableCell xrTableCell = XrTableCell1;
		location = new Point(0, 0);
		xrTableCell.Location = location;
		XrTableCell1.Name = "XrTableCell1";
		XRTableCell xrTableCell2 = XrTableCell1;
		PaddingInfo padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell2.Padding = padding;
		XRTableCell xrTableCell3 = XrTableCell1;
		size = new Size(61, 25);
		xrTableCell3.Size = size;
		XrTableCell1.Text = "XrTableCell1";
		XrTableCell8.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Report_Cumple.edadEmpleado", "")
		});
		XRTableCell xrTableCell4 = XrTableCell8;
		location = new Point(61, 0);
		xrTableCell4.Location = location;
		XrTableCell8.Name = "XrTableCell8";
		XRTableCell xrTableCell5 = XrTableCell8;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell5.Padding = padding;
		XRTableCell xrTableCell6 = XrTableCell8;
		size = new Size(62, 25);
		xrTableCell6.Size = size;
		XrTableCell8.Text = "XrTableCell8";
		XrTableCell2.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Report_Cumple.NombresCompletos", "")
		});
		XRTableCell xrTableCell7 = XrTableCell2;
		location = new Point(123, 0);
		xrTableCell7.Location = location;
		XrTableCell2.Name = "XrTableCell2";
		XRTableCell xrTableCell8 = XrTableCell2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell8.Padding = padding;
		XRTableCell xrTableCell9 = XrTableCell2;
		size = new Size(234, 25);
		xrTableCell9.Size = size;
		XrTableCell2.Text = "XrTableCell2";
		XrTableCell6.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Report_Cumple.AreaOrganizacional", "")
		});
		XRTableCell xrTableCell10 = XrTableCell6;
		location = new Point(357, 0);
		xrTableCell10.Location = location;
		XrTableCell6.Name = "XrTableCell6";
		XRTableCell xrTableCell11 = XrTableCell6;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell11.Padding = padding;
		XRTableCell xrTableCell12 = XrTableCell6;
		size = new Size(235, 25);
		xrTableCell12.Size = size;
		XrTableCell6.Text = "XrTableCell6";
		PageHeader.Height = 0;
		PageHeader.Name = "PageHeader";
		PageFooter.Height = 0;
		PageFooter.Name = "PageFooter";
		DataSet11.DataSetName = "DataSet1";
		DataSet11.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		GroupHeader1.Controls.AddRange(new XRControl[1] { XrTable2 });
		GroupHeader1.Height = 50;
		GroupHeader1.Name = "GroupHeader1";
		XrTable2.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable3 = XrTable2;
		location = new Point(33, 25);
		xrTable3.Location = location;
		XrTable2.Name = "XrTable2";
		XrTable2.ParentStyleUsing.UseFont = false;
		XrTable2.Rows.AddRange(new XRTableRow[1] { XrTableRow2 });
		XRTable xrTable4 = XrTable2;
		size = new Size(592, 25);
		xrTable4.Size = size;
		XrTableRow2.Cells.AddRange(new XRTableCell[4] { XrTableCell3, XrTableCell7, XrTableCell4, XrTableCell5 });
		XrTableRow2.Name = "XrTableRow2";
		XRTableRow xrTableRow2 = XrTableRow2;
		size = new Size(592, 25);
		xrTableRow2.Size = size;
		XRTableCell xrTableCell13 = XrTableCell3;
		location = new Point(0, 0);
		xrTableCell13.Location = location;
		XrTableCell3.Name = "XrTableCell3";
		XRTableCell xrTableCell14 = XrTableCell3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell14.Padding = padding;
		XRTableCell xrTableCell15 = XrTableCell3;
		size = new Size(63, 25);
		xrTableCell15.Size = size;
		XrTableCell3.Text = "Fecha";
		XRTableCell xrTableCell16 = XrTableCell7;
		location = new Point(63, 0);
		xrTableCell16.Location = location;
		XrTableCell7.Name = "XrTableCell7";
		XRTableCell xrTableCell17 = XrTableCell7;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell17.Padding = padding;
		XRTableCell xrTableCell18 = XrTableCell7;
		size = new Size(63, 25);
		xrTableCell18.Size = size;
		XrTableCell7.Text = "Edad";
		XRTableCell xrTableCell19 = XrTableCell4;
		location = new Point(126, 0);
		xrTableCell19.Location = location;
		XrTableCell4.Name = "XrTableCell4";
		XRTableCell xrTableCell20 = XrTableCell4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell20.Padding = padding;
		XRTableCell xrTableCell21 = XrTableCell4;
		size = new Size(233, 25);
		xrTableCell21.Size = size;
		XrTableCell4.Text = "Apellidos y Nombres";
		XRTableCell xrTableCell22 = XrTableCell5;
		location = new Point(359, 0);
		xrTableCell22.Location = location;
		XrTableCell5.Name = "XrTableCell5";
		XRTableCell xrTableCell23 = XrTableCell5;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell23.Padding = padding;
		XRTableCell xrTableCell24 = XrTableCell5;
		size = new Size(233, 25);
		xrTableCell24.Size = size;
		XrTableCell5.Text = "Oficina";
		XrLabel2.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel = XrLabel2;
		location = new Point(8, 8);
		xrLabel.Location = location;
		XrLabel2.Name = "XrLabel2";
		XRLabel xrLabel2 = XrLabel2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.Padding = padding;
		XrLabel2.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel3 = XrLabel2;
		size = new Size(50, 25);
		xrLabel3.Size = size;
		XrLabel2.Text = "Mes:";
		ReportHeader.Controls.AddRange(new XRControl[2] { XrLabel3, XrLabel2 });
		ReportHeader.Height = 42;
		ReportHeader.Name = "ReportHeader";
		XrLabel3.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Report_Cumple.MESletras", "")
		});
		XRLabel xrLabel4 = XrLabel3;
		location = new Point(67, 8);
		xrLabel4.Location = location;
		XrLabel3.Name = "XrLabel3";
		XRLabel xrLabel5 = XrLabel3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.Padding = padding;
		XRLabel xrLabel6 = XrLabel3;
		size = new Size(183, 25);
		xrLabel6.Size = size;
		XrLabel3.Text = "XrLabel3";
		XrLabel1.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel7 = XrLabel1;
		location = new Point(8, 8);
		xrLabel7.Location = location;
		XrLabel1.Name = "XrLabel1";
		XRLabel xrLabel8 = XrLabel1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.Padding = padding;
		XrLabel1.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel9 = XrLabel1;
		size = new Size(83, 25);
		xrLabel9.Size = size;
		XrLabel1.Text = "Impreso el:";
		XrPageInfo1.Format = "{0:dddd, dd MMMM yyyy HH:mm}";
		XRPageInfo xrPageInfo = XrPageInfo1;
		location = new Point(92, 8);
		xrPageInfo.Location = location;
		XrPageInfo1.Name = "XrPageInfo1";
		XRPageInfo xrPageInfo2 = XrPageInfo1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo2.Padding = padding;
		XrPageInfo1.PageInfo = PageInfo.DateTime;
		XRPageInfo xrPageInfo3 = XrPageInfo1;
		size = new Size(258, 25);
		xrPageInfo3.Size = size;
		XrLabel4.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel10 = XrLabel4;
		location = new Point(417, 0);
		xrLabel10.Location = location;
		XrLabel4.Name = "XrLabel4";
		XRLabel xrLabel11 = XrLabel4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.Padding = padding;
		XrLabel4.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel12 = XrLabel4;
		size = new Size(33, 25);
		xrLabel12.Size = size;
		XrLabel4.Text = "Por:";
		XRPageInfo xrPageInfo4 = XrPageInfo2;
		location = new Point(458, 0);
		xrPageInfo4.Location = location;
		XrPageInfo2.Name = "XrPageInfo2";
		XRPageInfo xrPageInfo5 = XrPageInfo2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo5.Padding = padding;
		XrPageInfo2.PageInfo = PageInfo.UserName;
		XRPageInfo xrPageInfo6 = XrPageInfo2;
		size = new Size(167, 25);
		xrPageInfo6.Size = size;
		BottomMargin.Controls.AddRange(new XRControl[4] { XrLabel4, XrPageInfo2, XrPageInfo1, XrLabel1 });
		BottomMargin.Height = 56;
		BottomMargin.Name = "BottomMargin";
		Bands.AddRange(new Band[6] { Detail, PageHeader, PageFooter, GroupHeader1, ReportHeader, BottomMargin });
		DataAdapter = SpRRHH_Report_CuadroPerTableAdapter;
		DataMember = "spRRHH_Report_Cumple";
		DataSource = DataSet11;
		Margins = new Margins(100, 100, 100, 56);
		PageHeight = 1169;
		PageWidth = 827;
		PaperKind = PaperKind.A4;
		((ISupportInitialize)XrTable1).EndInit();
		((ISupportInitialize)DataSet11).EndInit();
		((ISupportInitialize)XrTable2).EndInit();
		((ISupportInitialize)this).EndInit();
	}
}
