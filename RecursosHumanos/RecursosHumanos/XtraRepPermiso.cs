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
public class XtraRepPermiso : XtraReport
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

	[AccessedThroughProperty("SpRRHH_Ficha_ExpLabTableAdapter")]
	private spRRHH_Ficha_ExpLabTableAdapter _SpRRHH_Ficha_ExpLabTableAdapter;

	[AccessedThroughProperty("XrTable1")]
	private XRTable _XrTable1;

	[AccessedThroughProperty("XrTableRow1")]
	private XRTableRow _XrTableRow1;

	[AccessedThroughProperty("XrTableCell1")]
	private XRTableCell _XrTableCell1;

	[AccessedThroughProperty("XrTableCell5")]
	private XRTableCell _XrTableCell5;

	[AccessedThroughProperty("XrTableCell2")]
	private XRTableCell _XrTableCell2;

	[AccessedThroughProperty("XrTableCell6")]
	private XRTableCell _XrTableCell6;

	[AccessedThroughProperty("XrTableCell3")]
	private XRTableCell _XrTableCell3;

	[AccessedThroughProperty("XrTableCell4")]
	private XRTableCell _XrTableCell4;

	[AccessedThroughProperty("XrTableCell7")]
	private XRTableCell _XrTableCell7;

	[AccessedThroughProperty("XrTableCell8")]
	private XRTableCell _XrTableCell8;

	[AccessedThroughProperty("XrTable2")]
	private XRTable _XrTable2;

	[AccessedThroughProperty("XrTableRow2")]
	private XRTableRow _XrTableRow2;

	[AccessedThroughProperty("XrTableCell9")]
	private XRTableCell _XrTableCell9;

	[AccessedThroughProperty("XrTableCell13")]
	private XRTableCell _XrTableCell13;

	[AccessedThroughProperty("XrTableCell10")]
	private XRTableCell _XrTableCell10;

	[AccessedThroughProperty("XrTableCell15")]
	private XRTableCell _XrTableCell15;

	[AccessedThroughProperty("XrTableCell14")]
	private XRTableCell _XrTableCell14;

	[AccessedThroughProperty("XrTableCell16")]
	private XRTableCell _XrTableCell16;

	[AccessedThroughProperty("XrTableCell11")]
	private XRTableCell _XrTableCell11;

	[AccessedThroughProperty("XrTableCell12")]
	private XRTableCell _XrTableCell12;

	[AccessedThroughProperty("XrLabel2")]
	private XRLabel _XrLabel2;

	[AccessedThroughProperty("XrPageInfo2")]
	private XRPageInfo _XrPageInfo2;

	[AccessedThroughProperty("XrLabel1")]
	private XRLabel _XrLabel1;

	[AccessedThroughProperty("XrPageInfo1")]
	private XRPageInfo _XrPageInfo1;

	[AccessedThroughProperty("XrLine1")]
	private XRLine _XrLine1;

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

	internal XRTableCell XrTableCell9
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell9 = value;
		}
	}

	internal XRTableCell XrTableCell13
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell13 = value;
		}
	}

	internal XRTableCell XrTableCell10
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell10 = value;
		}
	}

	internal XRTableCell XrTableCell15
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell15 = value;
		}
	}

	internal XRTableCell XrTableCell14
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell14 = value;
		}
	}

	internal XRTableCell XrTableCell16
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell16 = value;
		}
	}

	internal XRTableCell XrTableCell11
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell11 = value;
		}
	}

	internal XRTableCell XrTableCell12
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell12 = value;
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

	internal XRLine XrLine1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLine1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLine1 = value;
		}
	}

	[DebuggerNonUserCode]
	public XtraRepPermiso()
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
		XrTableCell5 = new XRTableCell();
		XrTableCell2 = new XRTableCell();
		XrTableCell6 = new XRTableCell();
		XrTableCell3 = new XRTableCell();
		XrTableCell4 = new XRTableCell();
		XrTableCell7 = new XRTableCell();
		XrTableCell8 = new XRTableCell();
		PageHeader = new PageHeaderBand();
		XrLine1 = new XRLine();
		XrLabel2 = new XRLabel();
		XrTable2 = new XRTable();
		XrTableRow2 = new XRTableRow();
		XrTableCell9 = new XRTableCell();
		XrTableCell13 = new XRTableCell();
		XrTableCell10 = new XRTableCell();
		XrTableCell15 = new XRTableCell();
		XrTableCell14 = new XRTableCell();
		XrTableCell16 = new XRTableCell();
		XrTableCell11 = new XRTableCell();
		XrTableCell12 = new XRTableCell();
		PageFooter = new PageFooterBand();
		XrPageInfo2 = new XRPageInfo();
		XrLabel1 = new XRLabel();
		XrPageInfo1 = new XRPageInfo();
		DataSet11 = new DataSet1();
		SpRRHH_Ficha_ExpLabTableAdapter = new spRRHH_Ficha_ExpLabTableAdapter();
		((ISupportInitialize)XrTable1).BeginInit();
		((ISupportInitialize)XrTable2).BeginInit();
		((ISupportInitialize)DataSet11).BeginInit();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[1] { XrTable1 });
		Detail.Height = 25;
		Detail.Name = "Detail";
		XRTable xrTable = XrTable1;
		Point location = new Point(8, 0);
		xrTable.Location = location;
		XrTable1.Name = "XrTable1";
		XrTable1.Rows.AddRange(new XRTableRow[1] { XrTableRow1 });
		XRTable xrTable2 = XrTable1;
		Size size = new Size(1050, 25);
		xrTable2.Size = size;
		XrTableRow1.Cells.AddRange(new XRTableCell[8] { XrTableCell1, XrTableCell5, XrTableCell2, XrTableCell6, XrTableCell3, XrTableCell4, XrTableCell7, XrTableCell8 });
		XrTableRow1.Name = "XrTableRow1";
		XRTableRow xrTableRow = XrTableRow1;
		size = new Size(1050, 25);
		xrTableRow.Size = size;
		XrTableCell1.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_RepPermisos.Nombres", "")
		});
		XRTableCell xrTableCell = XrTableCell1;
		location = new Point(0, 0);
		xrTableCell.Location = location;
		XrTableCell1.Name = "XrTableCell1";
		XRTableCell xrTableCell2 = XrTableCell1;
		PaddingInfo padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell2.Padding = padding;
		XRTableCell xrTableCell3 = XrTableCell1;
		size = new Size(217, 25);
		xrTableCell3.Size = size;
		XrTableCell1.Text = "XrTableCell1";
		XrTableCell5.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_RepPermisos.Descrip_Motivo", "")
		});
		XRTableCell xrTableCell4 = XrTableCell5;
		location = new Point(217, 0);
		xrTableCell4.Location = location;
		XrTableCell5.Name = "XrTableCell5";
		XRTableCell xrTableCell5 = XrTableCell5;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell5.Padding = padding;
		XRTableCell xrTableCell6 = XrTableCell5;
		size = new Size(175, 25);
		xrTableCell6.Size = size;
		XrTableCell5.Text = "XrTableCell5";
		XrTableCell2.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_RepPermisos.FechaInicio", "{0:dd/MM/yyyy}")
		});
		XRTableCell xrTableCell7 = XrTableCell2;
		location = new Point(392, 0);
		xrTableCell7.Location = location;
		XrTableCell2.Name = "XrTableCell2";
		XRTableCell xrTableCell8 = XrTableCell2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell8.Padding = padding;
		XRTableCell xrTableCell9 = XrTableCell2;
		size = new Size(100, 25);
		xrTableCell9.Size = size;
		XrTableCell2.Text = "XrTableCell2";
		XrTableCell6.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_RepPermisos.FEchaFin", "{0:dd/MM/yyyy}")
		});
		XRTableCell xrTableCell10 = XrTableCell6;
		location = new Point(492, 0);
		xrTableCell10.Location = location;
		XrTableCell6.Name = "XrTableCell6";
		XRTableCell xrTableCell11 = XrTableCell6;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell11.Padding = padding;
		XRTableCell xrTableCell12 = XrTableCell6;
		size = new Size(108, 25);
		xrTableCell12.Size = size;
		XrTableCell6.Text = "XrTableCell6";
		XrTableCell3.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_RepPermisos.Hora_Sal", "")
		});
		XRTableCell xrTableCell13 = XrTableCell3;
		location = new Point(600, 0);
		xrTableCell13.Location = location;
		XrTableCell3.Name = "XrTableCell3";
		XRTableCell xrTableCell14 = XrTableCell3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell14.Padding = padding;
		XRTableCell xrTableCell15 = XrTableCell3;
		size = new Size(67, 25);
		xrTableCell15.Size = size;
		XrTableCell3.Text = "XrTableCell3";
		XrTableCell4.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_RepPermisos.Hora_ret", "")
		});
		XRTableCell xrTableCell16 = XrTableCell4;
		location = new Point(667, 0);
		xrTableCell16.Location = location;
		XrTableCell4.Name = "XrTableCell4";
		XRTableCell xrTableCell17 = XrTableCell4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell17.Padding = padding;
		XRTableCell xrTableCell18 = XrTableCell4;
		size = new Size(67, 25);
		xrTableCell18.Size = size;
		XrTableCell4.Text = "XrTableCell4";
		XrTableCell7.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_RepPermisos.Lugar", "")
		});
		XRTableCell xrTableCell19 = XrTableCell7;
		location = new Point(734, 0);
		xrTableCell19.Location = location;
		XrTableCell7.Name = "XrTableCell7";
		XRTableCell xrTableCell20 = XrTableCell7;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell20.Padding = padding;
		XRTableCell xrTableCell21 = XrTableCell7;
		size = new Size(175, 25);
		xrTableCell21.Size = size;
		XrTableCell7.Text = "XrTableCell7";
		XrTableCell8.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_RepPermisos.Observaciones", "")
		});
		XRTableCell xrTableCell22 = XrTableCell8;
		location = new Point(909, 0);
		xrTableCell22.Location = location;
		XrTableCell8.Name = "XrTableCell8";
		XRTableCell xrTableCell23 = XrTableCell8;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell23.Padding = padding;
		XRTableCell xrTableCell24 = XrTableCell8;
		size = new Size(141, 25);
		xrTableCell24.Size = size;
		XrTableCell8.Text = "XrTableCell8";
		PageHeader.Controls.AddRange(new XRControl[3] { XrLine1, XrLabel2, XrTable2 });
		PageHeader.Height = 117;
		PageHeader.Name = "PageHeader";
		XRLine xrLine = XrLine1;
		location = new Point(8, 58);
		xrLine.Location = location;
		XrLine1.Name = "XrLine1";
		XRLine xrLine2 = XrLine1;
		size = new Size(1050, 17);
		xrLine2.Size = size;
		XrLabel2.Font = new Font("Times New Roman", 16f);
		XRLabel xrLabel = XrLabel2;
		location = new Point(8, 17);
		xrLabel.Location = location;
		XrLabel2.Name = "XrLabel2";
		XRLabel xrLabel2 = XrLabel2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.Padding = padding;
		XrLabel2.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel3 = XrLabel2;
		size = new Size(1050, 25);
		xrLabel3.Size = size;
		XrLabel2.Text = "Reporte  de Permisos";
		XrLabel2.TextAlignment = TextAlignment.TopCenter;
		XrTable2.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable3 = XrTable2;
		location = new Point(8, 92);
		xrTable3.Location = location;
		XrTable2.Name = "XrTable2";
		XrTable2.ParentStyleUsing.UseFont = false;
		XrTable2.Rows.AddRange(new XRTableRow[1] { XrTableRow2 });
		XRTable xrTable4 = XrTable2;
		size = new Size(1050, 25);
		xrTable4.Size = size;
		XrTableRow2.Cells.AddRange(new XRTableCell[8] { XrTableCell9, XrTableCell13, XrTableCell10, XrTableCell15, XrTableCell14, XrTableCell16, XrTableCell11, XrTableCell12 });
		XrTableRow2.Name = "XrTableRow2";
		XRTableRow xrTableRow2 = XrTableRow2;
		size = new Size(1050, 25);
		xrTableRow2.Size = size;
		XRTableCell xrTableCell25 = XrTableCell9;
		location = new Point(0, 0);
		xrTableCell25.Location = location;
		XrTableCell9.Name = "XrTableCell9";
		XRTableCell xrTableCell26 = XrTableCell9;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell26.Padding = padding;
		XRTableCell xrTableCell27 = XrTableCell9;
		size = new Size(217, 25);
		xrTableCell27.Size = size;
		XrTableCell9.Text = "Nombres";
		XRTableCell xrTableCell28 = XrTableCell13;
		location = new Point(217, 0);
		xrTableCell28.Location = location;
		XrTableCell13.Name = "XrTableCell13";
		XRTableCell xrTableCell29 = XrTableCell13;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell29.Padding = padding;
		XRTableCell xrTableCell30 = XrTableCell13;
		size = new Size(175, 25);
		xrTableCell30.Size = size;
		XrTableCell13.Text = "Permiso";
		XRTableCell xrTableCell31 = XrTableCell10;
		location = new Point(392, 0);
		xrTableCell31.Location = location;
		XrTableCell10.Name = "XrTableCell10";
		XRTableCell xrTableCell32 = XrTableCell10;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell32.Padding = padding;
		XRTableCell xrTableCell33 = XrTableCell10;
		size = new Size(100, 25);
		xrTableCell33.Size = size;
		XrTableCell10.Text = "Fecha Inicio";
		XRTableCell xrTableCell34 = XrTableCell15;
		location = new Point(492, 0);
		xrTableCell34.Location = location;
		XrTableCell15.Name = "XrTableCell15";
		XRTableCell xrTableCell35 = XrTableCell15;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell35.Padding = padding;
		XRTableCell xrTableCell36 = XrTableCell15;
		size = new Size(108, 25);
		xrTableCell36.Size = size;
		XrTableCell15.Text = "Fecha Termino";
		XRTableCell xrTableCell37 = XrTableCell14;
		location = new Point(600, 0);
		xrTableCell37.Location = location;
		XrTableCell14.Name = "XrTableCell14";
		XRTableCell xrTableCell38 = XrTableCell14;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell38.Padding = padding;
		XRTableCell xrTableCell39 = XrTableCell14;
		size = new Size(67, 25);
		xrTableCell39.Size = size;
		XrTableCell14.Text = "Hora Sal.";
		XRTableCell xrTableCell40 = XrTableCell16;
		location = new Point(667, 0);
		xrTableCell40.Location = location;
		XrTableCell16.Name = "XrTableCell16";
		XRTableCell xrTableCell41 = XrTableCell16;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell41.Padding = padding;
		XRTableCell xrTableCell42 = XrTableCell16;
		size = new Size(67, 25);
		xrTableCell42.Size = size;
		XrTableCell16.Text = "Hora Ret.";
		XRTableCell xrTableCell43 = XrTableCell11;
		location = new Point(734, 0);
		xrTableCell43.Location = location;
		XrTableCell11.Name = "XrTableCell11";
		XRTableCell xrTableCell44 = XrTableCell11;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell44.Padding = padding;
		XRTableCell xrTableCell45 = XrTableCell11;
		size = new Size(175, 25);
		xrTableCell45.Size = size;
		XrTableCell11.Text = "Lugar";
		XRTableCell xrTableCell46 = XrTableCell12;
		location = new Point(909, 0);
		xrTableCell46.Location = location;
		XrTableCell12.Name = "XrTableCell12";
		XRTableCell xrTableCell47 = XrTableCell12;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell47.Padding = padding;
		XRTableCell xrTableCell48 = XrTableCell12;
		size = new Size(140, 25);
		xrTableCell48.Size = size;
		XrTableCell12.Text = "Obs.";
		PageFooter.Controls.AddRange(new XRControl[3] { XrPageInfo2, XrLabel1, XrPageInfo1 });
		PageFooter.Height = 42;
		PageFooter.Name = "PageFooter";
		XrPageInfo2.Font = new Font("Times New Roman", 9.75f, FontStyle.Italic);
		XrPageInfo2.Format = "{0:dddd, dd MMMM yyyy hh:mm tt}";
		XRPageInfo xrPageInfo = XrPageInfo2;
		location = new Point(117, 17);
		xrPageInfo.Location = location;
		XrPageInfo2.Name = "XrPageInfo2";
		XRPageInfo xrPageInfo2 = XrPageInfo2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo2.Padding = padding;
		XrPageInfo2.PageInfo = PageInfo.DateTime;
		XrPageInfo2.ParentStyleUsing.UseFont = false;
		XRPageInfo xrPageInfo3 = XrPageInfo2;
		size = new Size(558, 17);
		xrPageInfo3.Size = size;
		XRLabel xrLabel4 = XrLabel1;
		location = new Point(17, 17);
		xrLabel4.Location = location;
		XrLabel1.Name = "XrLabel1";
		XRLabel xrLabel5 = XrLabel1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.Padding = padding;
		XRLabel xrLabel6 = XrLabel1;
		size = new Size(92, 17);
		xrLabel6.Size = size;
		XrLabel1.Text = "Impreso el:";
		XRPageInfo xrPageInfo4 = XrPageInfo1;
		location = new Point(992, 0);
		xrPageInfo4.Location = location;
		XrPageInfo1.Name = "XrPageInfo1";
		XRPageInfo xrPageInfo5 = XrPageInfo1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo5.Padding = padding;
		XRPageInfo xrPageInfo6 = XrPageInfo1;
		size = new Size(75, 25);
		xrPageInfo6.Size = size;
		DataSet11.DataSetName = "DataSet1";
		DataSet11.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Bands.AddRange(new Band[3] { Detail, PageHeader, PageFooter });
		DataAdapter = SpRRHH_Ficha_ExpLabTableAdapter;
		DataMember = "spRRHH_RepPermisos";
		DataSource = DataSet11;
		Margins = new Margins(50, 50, 100, 100);
		PageHeight = 827;
		PageWidth = 1169;
		PaperKind = PaperKind.A4Rotated;
		((ISupportInitialize)XrTable1).EndInit();
		((ISupportInitialize)XrTable2).EndInit();
		((ISupportInitialize)DataSet11).EndInit();
		((ISupportInitialize)this).EndInit();
	}
}
