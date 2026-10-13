using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.DataSet1TableAdapters;

namespace RecursosHumanos;

[DesignerGenerated]
public class Report_Cargos : XtraReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Detail")]
	private DetailBand _Detail;

	[AccessedThroughProperty("PageHeader")]
	private PageHeaderBand _PageHeader;

	[AccessedThroughProperty("PageFooter")]
	private PageFooterBand _PageFooter;

	[AccessedThroughProperty("XrLabel1")]
	private XRLabel _XrLabel1;

	[AccessedThroughProperty("XrTable1")]
	private XRTable _XrTable1;

	[AccessedThroughProperty("XrTableRow1")]
	private XRTableRow _XrTableRow1;

	[AccessedThroughProperty("XrTableCell1")]
	private XRTableCell _XrTableCell1;

	[AccessedThroughProperty("XrTableCell2")]
	private XRTableCell _XrTableCell2;

	[AccessedThroughProperty("XrTableCell4")]
	private XRTableCell _XrTableCell4;

	[AccessedThroughProperty("XrTableCell3")]
	private XRTableCell _XrTableCell3;

	[AccessedThroughProperty("XrLabel2")]
	private XRLabel _XrLabel2;

	[AccessedThroughProperty("XrLabel3")]
	private XRLabel _XrLabel3;

	[AccessedThroughProperty("XrLabel4")]
	private XRLabel _XrLabel4;

	[AccessedThroughProperty("XrPageInfo1")]
	private XRPageInfo _XrPageInfo1;

	[AccessedThroughProperty("XrTable2")]
	private XRTable _XrTable2;

	[AccessedThroughProperty("XrTableRow2")]
	private XRTableRow _XrTableRow2;

	[AccessedThroughProperty("XrTableCell5")]
	private XRTableCell _XrTableCell5;

	[AccessedThroughProperty("XrTableCell6")]
	private XRTableCell _XrTableCell6;

	[AccessedThroughProperty("XrTableCell7")]
	private XRTableCell _XrTableCell7;

	[AccessedThroughProperty("XrTableCell8")]
	private XRTableCell _XrTableCell8;

	[AccessedThroughProperty("XrLabel5")]
	private XRLabel _XrLabel5;

	[AccessedThroughProperty("XrPageInfo2")]
	private XRPageInfo _XrPageInfo2;

	[AccessedThroughProperty("GroupHeader1")]
	private GroupHeaderBand _GroupHeader1;

	[AccessedThroughProperty("DataSet11")]
	private DataSet1 _DataSet11;

	[AccessedThroughProperty("SpRRHH_Rep_cargosTableAdapter")]
	private spRRHH_Rep_cargosTableAdapter _SpRRHH_Rep_cargosTableAdapter;

	[AccessedThroughProperty("SpRRHH_Ficha_ExpLabTableAdapter")]
	private spRRHH_Ficha_ExpLabTableAdapter _SpRRHH_Ficha_ExpLabTableAdapter;

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

	internal spRRHH_Rep_cargosTableAdapter SpRRHH_Rep_cargosTableAdapter
	{
		[DebuggerNonUserCode]
		get
		{
			return _SpRRHH_Rep_cargosTableAdapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SpRRHH_Rep_cargosTableAdapter = value;
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

	[DebuggerNonUserCode]
	public Report_Cargos()
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
		XrTableCell5 = new XRTableCell();
		XrTableCell6 = new XRTableCell();
		XrTableCell7 = new XRTableCell();
		XrTableCell8 = new XRTableCell();
		XrLabel2 = new XRLabel();
		XrLabel1 = new XRLabel();
		PageHeader = new PageHeaderBand();
		XrLabel3 = new XRLabel();
		PageFooter = new PageFooterBand();
		XrPageInfo2 = new XRPageInfo();
		XrLabel5 = new XRLabel();
		XrLabel4 = new XRLabel();
		XrPageInfo1 = new XRPageInfo();
		XrTable1 = new XRTable();
		XrTableRow1 = new XRTableRow();
		XrTableCell1 = new XRTableCell();
		XrTableCell2 = new XRTableCell();
		XrTableCell4 = new XRTableCell();
		XrTableCell3 = new XRTableCell();
		GroupHeader1 = new GroupHeaderBand();
		DataSet11 = new DataSet1();
		SpRRHH_Rep_cargosTableAdapter = new spRRHH_Rep_cargosTableAdapter();
		SpRRHH_Ficha_ExpLabTableAdapter = new spRRHH_Ficha_ExpLabTableAdapter();
		((ISupportInitialize)XrTable2).BeginInit();
		((ISupportInitialize)XrTable1).BeginInit();
		((ISupportInitialize)DataSet11).BeginInit();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[2] { XrLabel1, XrTable2 });
		Detail.Height = 33;
		Detail.Name = "Detail";
		DetailBand detail = Detail;
		PaddingInfo padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detail.Padding = padding;
		Detail.TextAlignment = TextAlignment.TopLeft;
		XrTable2.Font = new Font("Times New Roman", 9.75f);
		XRTable xrTable = XrTable2;
		Point location = new Point(25, 0);
		xrTable.Location = location;
		XrTable2.Name = "XrTable2";
		XRTable xrTable2 = XrTable2;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable2.Padding = padding;
		XrTable2.Rows.AddRange(new XRTableRow[1] { XrTableRow2 });
		XRTable xrTable3 = XrTable2;
		Size size = new Size(617, 25);
		xrTable3.Size = size;
		XrTable2.TextAlignment = TextAlignment.TopLeft;
		XrTableRow2.Cells.AddRange(new XRTableCell[4] { XrTableCell5, XrTableCell6, XrTableCell7, XrTableCell8 });
		XrTableRow2.Name = "XrTableRow2";
		XRTableRow xrTableRow = XrTableRow2;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow.Padding = padding;
		XrTableRow2.TextAlignment = TextAlignment.TopLeft;
		XrTableRow2.Weight = 1.0;
		XrTableCell5.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Rep_cargos.Apellido_Paterno", "")
		});
		XrTableCell5.Name = "XrTableCell5";
		XRTableCell xrTableCell = XrTableCell5;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell.Padding = padding;
		XrTableCell5.Text = "Apellido Paterno";
		XrTableCell5.TextAlignment = TextAlignment.TopLeft;
		XrTableCell5.Weight = 133.0 / 592.0;
		XrTableCell6.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Rep_cargos.Apellido_Materno", "")
		});
		XrTableCell6.Name = "XrTableCell6";
		XRTableCell xrTableCell2 = XrTableCell6;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell2.Padding = padding;
		XrTableCell6.Text = "Apellido Materno";
		XrTableCell6.TextAlignment = TextAlignment.TopLeft;
		XrTableCell6.Weight = 71.0 / 296.0;
		XrTableCell7.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Rep_cargos.nombres", "")
		});
		XrTableCell7.Name = "XrTableCell7";
		XRTableCell xrTableCell3 = XrTableCell7;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell3.Padding = padding;
		XrTableCell7.Text = "Nombres";
		XrTableCell7.TextAlignment = TextAlignment.TopLeft;
		XrTableCell7.Weight = 117.0 / 592.0;
		XrTableCell8.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Rep_cargos.AreaOrganizacional", "")
		});
		XrTableCell8.Name = "XrTableCell8";
		XRTableCell xrTableCell4 = XrTableCell8;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell4.Padding = padding;
		XrTableCell8.Text = "Area Organizacional";
		XrTableCell8.TextAlignment = TextAlignment.TopLeft;
		XrTableCell8.Weight = 225.0 / 592.0;
		XrLabel2.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel = XrLabel2;
		location = new Point(650, 58);
		xrLabel.Location = location;
		XrLabel2.Name = "XrLabel2";
		XRLabel xrLabel2 = XrLabel2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.Padding = padding;
		XRLabel xrLabel3 = XrLabel2;
		size = new Size(117, 25);
		xrLabel3.Size = size;
		XrLabel2.Text = "Cargo:";
		XrLabel2.TextAlignment = TextAlignment.TopLeft;
		XrLabel1.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Rep_cargos.cargo", "")
		});
		XrLabel1.Font = new Font("Times New Roman", 9.75f, FontStyle.Italic);
		XRLabel xrLabel4 = XrLabel1;
		location = new Point(650, 0);
		xrLabel4.Location = location;
		XrLabel1.Name = "XrLabel1";
		XRLabel xrLabel5 = XrLabel1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.Padding = padding;
		XRLabel xrLabel6 = XrLabel1;
		size = new Size(125, 25);
		xrLabel6.Size = size;
		XrLabel1.Text = "XrLabel1";
		XrLabel1.TextAlignment = TextAlignment.TopLeft;
		PageHeader.Controls.AddRange(new XRControl[1] { XrLabel3 });
		PageHeader.Height = 74;
		PageHeader.Name = "PageHeader";
		PageHeaderBand pageHeader = PageHeader;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		pageHeader.Padding = padding;
		PageHeader.TextAlignment = TextAlignment.TopLeft;
		XrLabel3.Font = new Font("Arial", 14f, FontStyle.Bold);
		XRLabel xrLabel7 = XrLabel3;
		location = new Point(183, 25);
		xrLabel7.Location = location;
		XrLabel3.Name = "XrLabel3";
		XRLabel xrLabel8 = XrLabel3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.Padding = padding;
		XRLabel xrLabel9 = XrLabel3;
		size = new Size(342, 25);
		xrLabel9.Size = size;
		XrLabel3.Text = "Reporte de Trabajadores por Cargo";
		XrLabel3.TextAlignment = TextAlignment.TopLeft;
		PageFooter.Controls.AddRange(new XRControl[4] { XrPageInfo2, XrLabel5, XrLabel4, XrPageInfo1 });
		PageFooter.Height = 58;
		PageFooter.Name = "PageFooter";
		PageFooterBand pageFooter = PageFooter;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		pageFooter.Padding = padding;
		PageFooter.TextAlignment = TextAlignment.TopLeft;
		XrPageInfo2.Format = "{0:dddd, dd MMMM yyyy hh:mm tt}";
		XRPageInfo xrPageInfo = XrPageInfo2;
		location = new Point(92, 8);
		xrPageInfo.Location = location;
		XrPageInfo2.Name = "XrPageInfo2";
		XRPageInfo xrPageInfo2 = XrPageInfo2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo2.Padding = padding;
		XrPageInfo2.PageInfo = PageInfo.DateTime;
		XRPageInfo xrPageInfo3 = XrPageInfo2;
		size = new Size(250, 17);
		xrPageInfo3.Size = size;
		XrPageInfo2.TextAlignment = TextAlignment.TopLeft;
		XrLabel5.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel10 = XrLabel5;
		location = new Point(8, 8);
		xrLabel10.Location = location;
		XrLabel5.Name = "XrLabel5";
		XRLabel xrLabel11 = XrLabel5;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.Padding = padding;
		XRLabel xrLabel12 = XrLabel5;
		size = new Size(75, 17);
		xrLabel12.Size = size;
		XrLabel5.Text = "Impreso el:";
		XrLabel5.TextAlignment = TextAlignment.TopLeft;
		XrLabel4.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel13 = XrLabel4;
		location = new Point(600, 8);
		xrLabel13.Location = location;
		XrLabel4.Name = "XrLabel4";
		XRLabel xrLabel14 = XrLabel4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.Padding = padding;
		XRLabel xrLabel15 = XrLabel4;
		size = new Size(33, 17);
		xrLabel15.Size = size;
		XrLabel4.Text = "por:";
		XrLabel4.TextAlignment = TextAlignment.TopLeft;
		XRPageInfo xrPageInfo4 = XrPageInfo1;
		location = new Point(642, 8);
		xrPageInfo4.Location = location;
		XrPageInfo1.Name = "XrPageInfo1";
		XRPageInfo xrPageInfo5 = XrPageInfo1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo5.Padding = padding;
		XrPageInfo1.PageInfo = PageInfo.UserName;
		XRPageInfo xrPageInfo6 = XrPageInfo1;
		size = new Size(117, 17);
		xrPageInfo6.Size = size;
		XrPageInfo1.TextAlignment = TextAlignment.TopLeft;
		XrTable1.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable4 = XrTable1;
		location = new Point(25, 58);
		xrTable4.Location = location;
		XrTable1.Name = "XrTable1";
		XRTable xrTable5 = XrTable1;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable5.Padding = padding;
		XrTable1.Rows.AddRange(new XRTableRow[1] { XrTableRow1 });
		XRTable xrTable6 = XrTable1;
		size = new Size(617, 25);
		xrTable6.Size = size;
		XrTable1.TextAlignment = TextAlignment.TopLeft;
		XrTableRow1.Cells.AddRange(new XRTableCell[4] { XrTableCell1, XrTableCell2, XrTableCell4, XrTableCell3 });
		XrTableRow1.Name = "XrTableRow1";
		XRTableRow xrTableRow2 = XrTableRow1;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow2.Padding = padding;
		XrTableRow1.TextAlignment = TextAlignment.TopLeft;
		XrTableRow1.Weight = 1.0;
		XrTableCell1.Name = "XrTableCell1";
		XRTableCell xrTableCell5 = XrTableCell1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell5.Padding = padding;
		XrTableCell1.Text = "Apellido Paterno";
		XrTableCell1.TextAlignment = TextAlignment.TopLeft;
		XrTableCell1.Weight = 133.0 / 592.0;
		XrTableCell2.Name = "XrTableCell2";
		XRTableCell xrTableCell6 = XrTableCell2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell6.Padding = padding;
		XrTableCell2.Text = "Apellido Materno";
		XrTableCell2.TextAlignment = TextAlignment.TopLeft;
		XrTableCell2.Weight = 71.0 / 296.0;
		XrTableCell4.Name = "XrTableCell4";
		XRTableCell xrTableCell7 = XrTableCell4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell7.Padding = padding;
		XrTableCell4.Text = "Nombres";
		XrTableCell4.TextAlignment = TextAlignment.TopLeft;
		XrTableCell4.Weight = 117.0 / 592.0;
		XrTableCell3.Name = "XrTableCell3";
		XRTableCell xrTableCell8 = XrTableCell3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell8.Padding = padding;
		XrTableCell3.Text = "Area Organizacional";
		XrTableCell3.TextAlignment = TextAlignment.TopLeft;
		XrTableCell3.Weight = 225.0 / 592.0;
		GroupHeader1.Controls.AddRange(new XRControl[2] { XrLabel2, XrTable1 });
		GroupHeader1.GroupFields.AddRange(new GroupField[1]
		{
			new GroupField("spRRHH_Rep_cargos.cargo", XRColumnSortOrder.Ascending)
		});
		GroupHeader1.GroupUnion = GroupUnion.WholePage;
		GroupHeader1.Height = 83;
		GroupHeader1.Name = "GroupHeader1";
		GroupHeaderBand groupHeader = GroupHeader1;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		groupHeader.Padding = padding;
		GroupHeader1.TextAlignment = TextAlignment.TopLeft;
		DataSet11.DataSetName = "DataSet1";
		DataSet11.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		SpRRHH_Rep_cargosTableAdapter.ClearBeforeFill = true;
		SpRRHH_Ficha_ExpLabTableAdapter.ClearBeforeFill = true;
		Bands.AddRange(new Band[4] { Detail, PageHeader, PageFooter, GroupHeader1 });
		DataAdapter = SpRRHH_Rep_cargosTableAdapter;
		DataMember = "spRRHH_Rep_cargos";
		DataSource = DataSet11;
		Margins = new Margins(21, 21, 100, 100);
		PageHeight = 1169;
		PageWidth = 827;
		PaperKind = PaperKind.A4;
		ScriptLanguage = ScriptLanguage.VisualBasic;
		Version = "9.1";
		((ISupportInitialize)XrTable2).EndInit();
		((ISupportInitialize)XrTable1).EndInit();
		((ISupportInitialize)DataSet11).EndInit();
		((ISupportInitialize)this).EndInit();
	}
}
