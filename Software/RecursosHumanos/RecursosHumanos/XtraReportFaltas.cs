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
public class XtraReportFaltas : XtraReport
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

	[AccessedThroughProperty("DataSet12")]
	private DataSet1 _DataSet12;

	[AccessedThroughProperty("XrTable1")]
	private XRTable _XrTable1;

	[AccessedThroughProperty("XrTableRow1")]
	private XRTableRow _XrTableRow1;

	[AccessedThroughProperty("XrTableCell1")]
	private XRTableCell _XrTableCell1;

	[AccessedThroughProperty("XrTableCell2")]
	private XRTableCell _XrTableCell2;

	[AccessedThroughProperty("XrLabel2")]
	private XRLabel _XrLabel2;

	[AccessedThroughProperty("GroupHeader1")]
	private GroupHeaderBand _GroupHeader1;

	[AccessedThroughProperty("XrLabel1")]
	private XRLabel _XrLabel1;

	[AccessedThroughProperty("XrLabel4")]
	private XRLabel _XrLabel4;

	[AccessedThroughProperty("XrLabel3")]
	private XRLabel _XrLabel3;

	[AccessedThroughProperty("XrLabel5")]
	private XRLabel _XrLabel5;

	[AccessedThroughProperty("XrTable2")]
	private XRTable _XrTable2;

	[AccessedThroughProperty("XrTableRow2")]
	private XRTableRow _XrTableRow2;

	[AccessedThroughProperty("XrTableCell3")]
	private XRTableCell _XrTableCell3;

	[AccessedThroughProperty("XrTableCell4")]
	private XRTableCell _XrTableCell4;

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

	internal DataSet1 DataSet12
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataSet12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataSet12 = value;
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

	[DebuggerNonUserCode]
	public XtraReportFaltas()
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
		XrTableCell2 = new XRTableCell();
		PageHeader = new PageHeaderBand();
		XrLabel4 = new XRLabel();
		XrLabel3 = new XRLabel();
		XrLabel2 = new XRLabel();
		PageFooter = new PageFooterBand();
		DataSet11 = new DataSet1();
		SpRRHH_Ficha_ExpLabTableAdapter = new spRRHH_Ficha_ExpLabTableAdapter();
		DataSet12 = new DataSet1();
		GroupHeader1 = new GroupHeaderBand();
		XrLabel5 = new XRLabel();
		XrTable2 = new XRTable();
		XrTableRow2 = new XRTableRow();
		XrTableCell3 = new XRTableCell();
		XrTableCell4 = new XRTableCell();
		XrLabel1 = new XRLabel();
		((ISupportInitialize)XrTable1).BeginInit();
		((ISupportInitialize)DataSet11).BeginInit();
		((ISupportInitialize)DataSet12).BeginInit();
		((ISupportInitialize)XrTable2).BeginInit();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[1] { XrTable1 });
		Detail.Height = 25;
		Detail.Name = "Detail";
		XRTable xrTable = XrTable1;
		Point location = new Point(83, 0);
		xrTable.Location = location;
		XrTable1.Name = "XrTable1";
		XrTable1.Rows.AddRange(new XRTableRow[1] { XrTableRow1 });
		XRTable xrTable2 = XrTable1;
		Size size = new Size(525, 25);
		xrTable2.Size = size;
		XrTableRow1.Cells.AddRange(new XRTableCell[2] { XrTableCell1, XrTableCell2 });
		XrTableRow1.Name = "XrTableRow1";
		XRTableRow xrTableRow = XrTableRow1;
		size = new Size(525, 25);
		xrTableRow.Size = size;
		XrTableCell1.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Faltas.NombresC", "")
		});
		XRTableCell xrTableCell = XrTableCell1;
		location = new Point(0, 0);
		xrTableCell.Location = location;
		XrTableCell1.Name = "XrTableCell1";
		XRTableCell xrTableCell2 = XrTableCell1;
		PaddingInfo padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell2.Padding = padding;
		XRTableCell xrTableCell3 = XrTableCell1;
		size = new Size(283, 25);
		xrTableCell3.Size = size;
		XrTableCell1.Text = "XrTableCell1";
		XrTableCell2.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Faltas.AreaOrganizacional", "")
		});
		XRTableCell xrTableCell4 = XrTableCell2;
		location = new Point(283, 0);
		xrTableCell4.Location = location;
		XrTableCell2.Name = "XrTableCell2";
		XRTableCell xrTableCell5 = XrTableCell2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell5.Padding = padding;
		XRTableCell xrTableCell6 = XrTableCell2;
		size = new Size(242, 25);
		xrTableCell6.Size = size;
		XrTableCell2.Text = "XrTableCell2";
		PageHeader.Controls.AddRange(new XRControl[3] { XrLabel4, XrLabel3, XrLabel2 });
		PageHeader.Height = 88;
		PageHeader.Name = "PageHeader";
		XrLabel4.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Faltas.Fecha", "{0:dddd, dd MMMM yyyy}")
		});
		XRLabel xrLabel = XrLabel4;
		location = new Point(267, 50);
		xrLabel.Location = location;
		XrLabel4.Name = "XrLabel4";
		XRLabel xrLabel2 = XrLabel4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.Padding = padding;
		XRLabel xrLabel3 = XrLabel4;
		size = new Size(225, 25);
		xrLabel3.Size = size;
		XrLabel4.Text = "XrLabel4";
		XrLabel3.Font = new Font("Times New Roman", 9.75f, FontStyle.Italic);
		XRLabel xrLabel4 = XrLabel3;
		location = new Point(225, 50);
		xrLabel4.Location = location;
		XrLabel3.Name = "XrLabel3";
		XRLabel xrLabel5 = XrLabel3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.Padding = padding;
		XrLabel3.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel6 = XrLabel3;
		size = new Size(33, 25);
		xrLabel6.Size = size;
		XrLabel3.Text = "Día:";
		XrLabel2.Font = new Font("Times New Roman", 14f, FontStyle.Bold);
		XRLabel xrLabel7 = XrLabel2;
		location = new Point(225, 17);
		xrLabel7.Location = location;
		XrLabel2.Name = "XrLabel2";
		XRLabel xrLabel8 = XrLabel2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.Padding = padding;
		XrLabel2.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel9 = XrLabel2;
		size = new Size(158, 25);
		xrLabel9.Size = size;
		XrLabel2.Text = "Reporte de Faltas";
		PageFooter.Height = 30;
		PageFooter.Name = "PageFooter";
		DataSet11.DataSetName = "DataSet1";
		DataSet11.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		DataSet12.DataSetName = "DataSet1";
		DataSet12.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		GroupHeader1.Controls.AddRange(new XRControl[3] { XrLabel5, XrTable2, XrLabel1 });
		GroupHeader1.GroupFields.AddRange(new GroupField[1]
		{
			new GroupField("idTipoTrabajador", XRColumnSortOrder.Ascending)
		});
		GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail;
		GroupHeader1.Height = 93;
		GroupHeader1.KeepTogether = true;
		GroupHeader1.Name = "GroupHeader1";
		XrLabel5.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel10 = XrLabel5;
		location = new Point(8, 17);
		xrLabel10.Location = location;
		XrLabel5.Name = "XrLabel5";
		XRLabel xrLabel11 = XrLabel5;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.Padding = padding;
		XrLabel5.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel12 = XrLabel5;
		size = new Size(125, 25);
		xrLabel12.Size = size;
		XrLabel5.Text = "Condición Laboral:";
		XrTable2.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable3 = XrTable2;
		location = new Point(83, 67);
		xrTable3.Location = location;
		XrTable2.Name = "XrTable2";
		XrTable2.ParentStyleUsing.UseFont = false;
		XrTable2.Rows.AddRange(new XRTableRow[1] { XrTableRow2 });
		XRTable xrTable4 = XrTable2;
		size = new Size(525, 25);
		xrTable4.Size = size;
		XrTableRow2.Cells.AddRange(new XRTableCell[2] { XrTableCell3, XrTableCell4 });
		XrTableRow2.Name = "XrTableRow2";
		XRTableRow xrTableRow2 = XrTableRow2;
		size = new Size(525, 25);
		xrTableRow2.Size = size;
		XRTableCell xrTableCell7 = XrTableCell3;
		location = new Point(0, 0);
		xrTableCell7.Location = location;
		XrTableCell3.Name = "XrTableCell3";
		XRTableCell xrTableCell8 = XrTableCell3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell8.Padding = padding;
		XRTableCell xrTableCell9 = XrTableCell3;
		size = new Size(283, 25);
		xrTableCell9.Size = size;
		XrTableCell3.Text = "Nombres Completos";
		XRTableCell xrTableCell10 = XrTableCell4;
		location = new Point(283, 0);
		xrTableCell10.Location = location;
		XrTableCell4.Name = "XrTableCell4";
		XRTableCell xrTableCell11 = XrTableCell4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell11.Padding = padding;
		XRTableCell xrTableCell12 = XrTableCell4;
		size = new Size(242, 25);
		xrTableCell12.Size = size;
		XrTableCell4.Text = "Area Organizacional";
		XrLabel1.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Faltas.Descripcion", "")
		});
		XrLabel1.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel13 = XrLabel1;
		location = new Point(142, 17);
		xrLabel13.Location = location;
		XrLabel1.Name = "XrLabel1";
		XRLabel xrLabel14 = XrLabel1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.Padding = padding;
		XrLabel1.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel15 = XrLabel1;
		size = new Size(167, 25);
		xrLabel15.Size = size;
		XrLabel1.Text = "XrLabel1";
		Bands.AddRange(new Band[4] { Detail, PageHeader, PageFooter, GroupHeader1 });
		DataAdapter = SpRRHH_Ficha_ExpLabTableAdapter;
		DataMember = "spRRHH_Faltas";
		DataSource = DataSet11;
		PageHeight = 1169;
		PageWidth = 827;
		PaperKind = PaperKind.A4;
		((ISupportInitialize)XrTable1).EndInit();
		((ISupportInitialize)DataSet11).EndInit();
		((ISupportInitialize)DataSet12).EndInit();
		((ISupportInitialize)XrTable2).EndInit();
		((ISupportInitialize)this).EndInit();
	}
}
