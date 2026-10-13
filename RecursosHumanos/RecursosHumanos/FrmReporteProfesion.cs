using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassRRHH;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Preview;
using GRLL.Common;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class FrmReporteProfesion : FrmConsulta
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PrintBarManager1")]
	private PrintBarManager _PrintBarManager1;

	[AccessedThroughProperty("PreviewBar1")]
	private PreviewBar _PreviewBar1;

	[AccessedThroughProperty("PrintPreviewBarItem2")]
	private PrintPreviewBarItem _PrintPreviewBarItem2;

	[AccessedThroughProperty("PrintPreviewBarItem3")]
	private PrintPreviewBarItem _PrintPreviewBarItem3;

	[AccessedThroughProperty("PrintPreviewBarItem4")]
	private PrintPreviewBarItem _PrintPreviewBarItem4;

	[AccessedThroughProperty("PrintPreviewBarItem5")]
	private PrintPreviewBarItem _PrintPreviewBarItem5;

	[AccessedThroughProperty("PrintPreviewBarItem6")]
	private PrintPreviewBarItem _PrintPreviewBarItem6;

	[AccessedThroughProperty("PrintPreviewBarItem7")]
	private PrintPreviewBarItem _PrintPreviewBarItem7;

	[AccessedThroughProperty("PrintPreviewBarItem8")]
	private PrintPreviewBarItem _PrintPreviewBarItem8;

	[AccessedThroughProperty("PrintPreviewBarItem9")]
	private PrintPreviewBarItem _PrintPreviewBarItem9;

	[AccessedThroughProperty("PrintPreviewBarItem10")]
	private PrintPreviewBarItem _PrintPreviewBarItem10;

	[AccessedThroughProperty("PrintPreviewBarItem11")]
	private PrintPreviewBarItem _PrintPreviewBarItem11;

	[AccessedThroughProperty("PrintPreviewBarItem12")]
	private PrintPreviewBarItem _PrintPreviewBarItem12;

	[AccessedThroughProperty("PrintPreviewBarItem13")]
	private PrintPreviewBarItem _PrintPreviewBarItem13;

	[AccessedThroughProperty("PrintPreviewBarItem14")]
	private PrintPreviewBarItem _PrintPreviewBarItem14;

	[AccessedThroughProperty("PrintPreviewBarItem15")]
	private PrintPreviewBarItem _PrintPreviewBarItem15;

	[AccessedThroughProperty("ZoomBarEditItem1")]
	private ZoomBarEditItem _ZoomBarEditItem1;

	[AccessedThroughProperty("PrintPreviewRepositoryItemComboBox1")]
	private PrintPreviewRepositoryItemComboBox _PrintPreviewRepositoryItemComboBox1;

	[AccessedThroughProperty("PrintPreviewBarItem16")]
	private PrintPreviewBarItem _PrintPreviewBarItem16;

	[AccessedThroughProperty("PrintPreviewBarItem17")]
	private PrintPreviewBarItem _PrintPreviewBarItem17;

	[AccessedThroughProperty("PrintPreviewBarItem18")]
	private PrintPreviewBarItem _PrintPreviewBarItem18;

	[AccessedThroughProperty("PrintPreviewBarItem19")]
	private PrintPreviewBarItem _PrintPreviewBarItem19;

	[AccessedThroughProperty("PrintPreviewBarItem20")]
	private PrintPreviewBarItem _PrintPreviewBarItem20;

	[AccessedThroughProperty("PrintPreviewBarItem21")]
	private PrintPreviewBarItem _PrintPreviewBarItem21;

	[AccessedThroughProperty("PrintPreviewBarItem22")]
	private PrintPreviewBarItem _PrintPreviewBarItem22;

	[AccessedThroughProperty("PrintPreviewBarItem23")]
	private PrintPreviewBarItem _PrintPreviewBarItem23;

	[AccessedThroughProperty("PrintPreviewBarItem24")]
	private PrintPreviewBarItem _PrintPreviewBarItem24;

	[AccessedThroughProperty("PrintPreviewBarItem25")]
	private PrintPreviewBarItem _PrintPreviewBarItem25;

	[AccessedThroughProperty("PrintPreviewBarItem26")]
	private PrintPreviewBarItem _PrintPreviewBarItem26;

	[AccessedThroughProperty("PreviewBar2")]
	private PreviewBar _PreviewBar2;

	[AccessedThroughProperty("PrintPreviewStaticItem1")]
	private PrintPreviewStaticItem _PrintPreviewStaticItem1;

	[AccessedThroughProperty("BarStaticItem1")]
	private BarStaticItem _BarStaticItem1;

	[AccessedThroughProperty("ProgressBarEditItem1")]
	private ProgressBarEditItem _ProgressBarEditItem1;

	[AccessedThroughProperty("RepositoryItemProgressBar1")]
	private RepositoryItemProgressBar _RepositoryItemProgressBar1;

	[AccessedThroughProperty("PrintPreviewBarItem1")]
	private PrintPreviewBarItem _PrintPreviewBarItem1;

	[AccessedThroughProperty("BarButtonItem1")]
	private BarButtonItem _BarButtonItem1;

	[AccessedThroughProperty("PrintPreviewStaticItem2")]
	private PrintPreviewStaticItem _PrintPreviewStaticItem2;

	[AccessedThroughProperty("PreviewBar3")]
	private PreviewBar _PreviewBar3;

	[AccessedThroughProperty("PrintPreviewSubItem1")]
	private PrintPreviewSubItem _PrintPreviewSubItem1;

	[AccessedThroughProperty("PrintPreviewSubItem2")]
	private PrintPreviewSubItem _PrintPreviewSubItem2;

	[AccessedThroughProperty("PrintPreviewSubItem4")]
	private PrintPreviewSubItem _PrintPreviewSubItem4;

	[AccessedThroughProperty("PrintPreviewBarItem27")]
	private PrintPreviewBarItem _PrintPreviewBarItem27;

	[AccessedThroughProperty("PrintPreviewBarItem28")]
	private PrintPreviewBarItem _PrintPreviewBarItem28;

	[AccessedThroughProperty("BarToolbarsListItem1")]
	private BarToolbarsListItem _BarToolbarsListItem1;

	[AccessedThroughProperty("PrintPreviewSubItem3")]
	private PrintPreviewSubItem _PrintPreviewSubItem3;

	[AccessedThroughProperty("barDockControlTop")]
	private BarDockControl _barDockControlTop;

	[AccessedThroughProperty("barDockControlBottom")]
	private BarDockControl _barDockControlBottom;

	[AccessedThroughProperty("barDockControlLeft")]
	private BarDockControl _barDockControlLeft;

	[AccessedThroughProperty("barDockControlRight")]
	private BarDockControl _barDockControlRight;

	[AccessedThroughProperty("PrintPreviewBarCheckItem1")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem1;

	[AccessedThroughProperty("PrintPreviewBarCheckItem2")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem2;

	[AccessedThroughProperty("PrintPreviewBarCheckItem3")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem3;

	[AccessedThroughProperty("PrintPreviewBarCheckItem4")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem4;

	[AccessedThroughProperty("PrintPreviewBarCheckItem5")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem5;

	[AccessedThroughProperty("PrintPreviewBarCheckItem6")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem6;

	[AccessedThroughProperty("PrintPreviewBarCheckItem7")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem7;

	[AccessedThroughProperty("PrintPreviewBarCheckItem8")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem8;

	[AccessedThroughProperty("PrintPreviewBarCheckItem9")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem9;

	[AccessedThroughProperty("PrintPreviewBarCheckItem10")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem10;

	[AccessedThroughProperty("PrintPreviewBarCheckItem11")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem11;

	[AccessedThroughProperty("PrintPreviewBarCheckItem12")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem12;

	[AccessedThroughProperty("PrintPreviewBarCheckItem13")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem13;

	[AccessedThroughProperty("PrintPreviewBarCheckItem14")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem14;

	[AccessedThroughProperty("PrintPreviewBarCheckItem15")]
	private PrintPreviewBarCheckItem _PrintPreviewBarCheckItem15;

	[AccessedThroughProperty("SplitContainerControl1")]
	private SplitContainerControl _SplitContainerControl1;

	[AccessedThroughProperty("CheckedListBoxControl1")]
	private CheckedListBoxControl _CheckedListBoxControl1;

	[AccessedThroughProperty("PrintControl1")]
	private PrintControl _PrintControl1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	private RRHHClass objRRHHClass;

	internal PrintBarManager PrintBarManager1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintBarManager1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintBarManager1 = value;
		}
	}

	internal PreviewBar PreviewBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PreviewBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PreviewBar1 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem2 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem3 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem4 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem5
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem5 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem6
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem6 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem7
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem7 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem8
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem8 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem9
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem9 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem10
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem10 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem11
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem11 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem12
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem12 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem13
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem13 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem14
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem14 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem15
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem15 = value;
		}
	}

	internal ZoomBarEditItem ZoomBarEditItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ZoomBarEditItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ZoomBarEditItem1 = value;
		}
	}

	internal PrintPreviewRepositoryItemComboBox PrintPreviewRepositoryItemComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewRepositoryItemComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewRepositoryItemComboBox1 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem16
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem16 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem17
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem17 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem18
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem18 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem19
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem19 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem20
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem20 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem21
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem21 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem22
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem22 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem23
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem23 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem24
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem24 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem25
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem25 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem26
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem26 = value;
		}
	}

	internal PreviewBar PreviewBar2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PreviewBar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PreviewBar2 = value;
		}
	}

	internal PrintPreviewStaticItem PrintPreviewStaticItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewStaticItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewStaticItem1 = value;
		}
	}

	internal BarStaticItem BarStaticItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BarStaticItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BarStaticItem1 = value;
		}
	}

	internal ProgressBarEditItem ProgressBarEditItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBarEditItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBarEditItem1 = value;
		}
	}

	internal RepositoryItemProgressBar RepositoryItemProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RepositoryItemProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RepositoryItemProgressBar1 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem1 = value;
		}
	}

	internal BarButtonItem BarButtonItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BarButtonItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BarButtonItem1 = value;
		}
	}

	internal PrintPreviewStaticItem PrintPreviewStaticItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewStaticItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewStaticItem2 = value;
		}
	}

	internal PreviewBar PreviewBar3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PreviewBar3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PreviewBar3 = value;
		}
	}

	internal PrintPreviewSubItem PrintPreviewSubItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewSubItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewSubItem1 = value;
		}
	}

	internal PrintPreviewSubItem PrintPreviewSubItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewSubItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewSubItem2 = value;
		}
	}

	internal PrintPreviewSubItem PrintPreviewSubItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewSubItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewSubItem4 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem27
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem27 = value;
		}
	}

	internal PrintPreviewBarItem PrintPreviewBarItem28
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarItem28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarItem28 = value;
		}
	}

	internal BarToolbarsListItem BarToolbarsListItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BarToolbarsListItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BarToolbarsListItem1 = value;
		}
	}

	internal PrintPreviewSubItem PrintPreviewSubItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewSubItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewSubItem3 = value;
		}
	}

	internal BarDockControl barDockControlTop
	{
		[DebuggerNonUserCode]
		get
		{
			return _barDockControlTop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_barDockControlTop = value;
		}
	}

	internal BarDockControl barDockControlBottom
	{
		[DebuggerNonUserCode]
		get
		{
			return _barDockControlBottom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_barDockControlBottom = value;
		}
	}

	internal BarDockControl barDockControlLeft
	{
		[DebuggerNonUserCode]
		get
		{
			return _barDockControlLeft;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_barDockControlLeft = value;
		}
	}

	internal BarDockControl barDockControlRight
	{
		[DebuggerNonUserCode]
		get
		{
			return _barDockControlRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_barDockControlRight = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem1 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem2 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem3 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem4 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem5
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem5 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem6
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem6 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem7
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem7 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem8
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem8 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem9
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem9 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem10
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem10 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem11
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem11 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem12
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem12 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem13
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem13 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem14
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem14 = value;
		}
	}

	internal PrintPreviewBarCheckItem PrintPreviewBarCheckItem15
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewBarCheckItem15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewBarCheckItem15 = value;
		}
	}

	internal SplitContainerControl SplitContainerControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SplitContainerControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SplitContainerControl1 = value;
		}
	}

	internal CheckedListBoxControl CheckedListBoxControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckedListBoxControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckedListBoxControl1 = value;
		}
	}

	internal PrintControl PrintControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintControl1 = value;
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
			EventHandler value2 = Button1_Click;
			if (_Button1 != null)
			{
				_Button1.Click -= value2;
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				_Button1.Click += value2;
			}
		}
	}

	public FrmReporteProfesion()
	{
		base.Load += FrmReporteProfesion_Load;
		__ENCAddToList(this);
		objRRHHClass = new RRHHClass();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecursosHumanos.FrmReporteProfesion));
		this.PrintBarManager1 = new DevExpress.XtraPrinting.Preview.PrintBarManager();
		this.PreviewBar1 = new DevExpress.XtraPrinting.Preview.PreviewBar();
		this.PrintPreviewBarItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem5 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem6 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem7 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem8 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem9 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem10 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem11 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem12 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem13 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem14 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem15 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.ZoomBarEditItem1 = new DevExpress.XtraPrinting.Preview.ZoomBarEditItem();
		this.PrintPreviewRepositoryItemComboBox1 = new DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox();
		this.PrintPreviewBarItem16 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem17 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem18 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem19 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem20 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem21 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem22 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem23 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem24 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem25 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem26 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PreviewBar2 = new DevExpress.XtraPrinting.Preview.PreviewBar();
		this.PrintPreviewStaticItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
		this.BarStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
		this.ProgressBarEditItem1 = new DevExpress.XtraPrinting.Preview.ProgressBarEditItem();
		this.RepositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
		this.PrintPreviewBarItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.BarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
		this.PrintPreviewStaticItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
		this.PreviewBar3 = new DevExpress.XtraPrinting.Preview.PreviewBar();
		this.PrintPreviewSubItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
		this.PrintPreviewSubItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
		this.PrintPreviewSubItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
		this.PrintPreviewBarItem27 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem28 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.BarToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
		this.PrintPreviewSubItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
		this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
		this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
		this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
		this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
		this.PrintPreviewBarCheckItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem5 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem6 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem7 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem8 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem9 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem10 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem11 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem12 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem13 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem14 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem15 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintControl1 = new DevExpress.XtraPrinting.Control.PrintControl();
		this.CheckedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
		this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
		this.Button1 = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.PrintBarManager1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PrintPreviewRepositoryItemComboBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemProgressBar1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CheckedListBoxControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).BeginInit();
		this.SplitContainerControl1.SuspendLayout();
		this.SuspendLayout();
		this.PanelSup.Dock = System.Windows.Forms.DockStyle.None;
		System.Windows.Forms.Panel panelSup = this.PanelSup;
		System.Drawing.Point location = new System.Drawing.Point(0, -58);
		panelSup.Location = location;
		System.Windows.Forms.Panel panelSup2 = this.PanelSup;
		System.Drawing.Size size = new System.Drawing.Size(878, 29);
		panelSup2.Size = size;
		this.PanelInf.Dock = System.Windows.Forms.DockStyle.None;
		System.Windows.Forms.Panel panelInf = this.PanelInf;
		location = new System.Drawing.Point(0, -54);
		panelInf.Location = location;
		System.Windows.Forms.Panel panelInf2 = this.PanelInf;
		size = new System.Drawing.Size(878, 27);
		panelInf2.Size = size;
		this.PrintBarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[3] { this.PreviewBar1, this.PreviewBar2, this.PreviewBar3 });
		this.PrintBarManager1.DockControls.Add(this.barDockControlTop);
		this.PrintBarManager1.DockControls.Add(this.barDockControlBottom);
		this.PrintBarManager1.DockControls.Add(this.barDockControlLeft);
		this.PrintBarManager1.DockControls.Add(this.barDockControlRight);
		this.PrintBarManager1.Form = this;
		this.PrintBarManager1.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("PrintBarManager1.ImageStream");
		this.PrintBarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[54]
		{
			this.PrintPreviewStaticItem1, this.BarStaticItem1, this.ProgressBarEditItem1, this.PrintPreviewBarItem1, this.BarButtonItem1, this.PrintPreviewStaticItem2, this.PrintPreviewBarItem2, this.PrintPreviewBarItem3, this.PrintPreviewBarItem4, this.PrintPreviewBarItem5,
			this.PrintPreviewBarItem6, this.PrintPreviewBarItem7, this.PrintPreviewBarItem8, this.PrintPreviewBarItem9, this.PrintPreviewBarItem10, this.PrintPreviewBarItem11, this.PrintPreviewBarItem12, this.PrintPreviewBarItem13, this.PrintPreviewBarItem14, this.PrintPreviewBarItem15,
			this.ZoomBarEditItem1, this.PrintPreviewBarItem16, this.PrintPreviewBarItem17, this.PrintPreviewBarItem18, this.PrintPreviewBarItem19, this.PrintPreviewBarItem20, this.PrintPreviewBarItem21, this.PrintPreviewBarItem22, this.PrintPreviewBarItem23, this.PrintPreviewBarItem24,
			this.PrintPreviewBarItem25, this.PrintPreviewBarItem26, this.PrintPreviewSubItem1, this.PrintPreviewSubItem2, this.PrintPreviewSubItem3, this.PrintPreviewSubItem4, this.PrintPreviewBarItem27, this.PrintPreviewBarItem28, this.BarToolbarsListItem1, this.PrintPreviewBarCheckItem1,
			this.PrintPreviewBarCheckItem2, this.PrintPreviewBarCheckItem3, this.PrintPreviewBarCheckItem4, this.PrintPreviewBarCheckItem5, this.PrintPreviewBarCheckItem6, this.PrintPreviewBarCheckItem7, this.PrintPreviewBarCheckItem8, this.PrintPreviewBarCheckItem9, this.PrintPreviewBarCheckItem10, this.PrintPreviewBarCheckItem11,
			this.PrintPreviewBarCheckItem12, this.PrintPreviewBarCheckItem13, this.PrintPreviewBarCheckItem14, this.PrintPreviewBarCheckItem15
		});
		this.PrintBarManager1.MainMenu = this.PreviewBar3;
		this.PrintBarManager1.MaxItemId = 54;
		this.PrintBarManager1.PreviewBar = this.PreviewBar1;
		this.PrintBarManager1.PrintControl = this.PrintControl1;
		this.PrintBarManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[2] { this.RepositoryItemProgressBar1, this.PrintPreviewRepositoryItemComboBox1 });
		this.PrintBarManager1.StatusBar = this.PreviewBar2;
		this.PreviewBar1.BarName = "Toolbar";
		this.PreviewBar1.DockCol = 0;
		this.PreviewBar1.DockRow = 1;
		this.PreviewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
		this.PreviewBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[26]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem2),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem3),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem4),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem5, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem6, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem7),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem8, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem9),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem10),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem11),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem12),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem13, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem14),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem15, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.ZoomBarEditItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem16),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem17, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem18),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem19),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem20),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem21, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem22),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem23),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem24, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem25),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem26, true)
		});
		this.PreviewBar1.Text = "Toolbar";
		this.PrintPreviewBarItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
		this.PrintPreviewBarItem2.Caption = "Document Map";
		this.PrintPreviewBarItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap;
		this.PrintPreviewBarItem2.Enabled = false;
		this.PrintPreviewBarItem2.Hint = "Document Map";
		this.PrintPreviewBarItem2.Id = 6;
		this.PrintPreviewBarItem2.ImageIndex = 19;
		this.PrintPreviewBarItem2.Name = "PrintPreviewBarItem2";
		this.PrintPreviewBarItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
		this.PrintPreviewBarItem3.Caption = "Parameters";
		this.PrintPreviewBarItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters;
		this.PrintPreviewBarItem3.Enabled = false;
		this.PrintPreviewBarItem3.Hint = "Parameters";
		this.PrintPreviewBarItem3.Id = 7;
		this.PrintPreviewBarItem3.ImageIndex = 22;
		this.PrintPreviewBarItem3.Name = "PrintPreviewBarItem3";
		this.PrintPreviewBarItem4.Caption = "Search";
		this.PrintPreviewBarItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find;
		this.PrintPreviewBarItem4.Enabled = false;
		this.PrintPreviewBarItem4.Hint = "Search";
		this.PrintPreviewBarItem4.Id = 8;
		this.PrintPreviewBarItem4.ImageIndex = 20;
		this.PrintPreviewBarItem4.Name = "PrintPreviewBarItem4";
		this.PrintPreviewBarItem5.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
		this.PrintPreviewBarItem5.Caption = "Customize";
		this.PrintPreviewBarItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Customize;
		this.PrintPreviewBarItem5.Enabled = false;
		this.PrintPreviewBarItem5.Hint = "Customize";
		this.PrintPreviewBarItem5.Id = 9;
		this.PrintPreviewBarItem5.ImageIndex = 14;
		this.PrintPreviewBarItem5.Name = "PrintPreviewBarItem5";
		this.PrintPreviewBarItem6.Caption = "Open";
		this.PrintPreviewBarItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open;
		this.PrintPreviewBarItem6.Hint = "Open a document";
		this.PrintPreviewBarItem6.Id = 10;
		this.PrintPreviewBarItem6.ImageIndex = 23;
		this.PrintPreviewBarItem6.Name = "PrintPreviewBarItem6";
		this.PrintPreviewBarItem7.Caption = "Save";
		this.PrintPreviewBarItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save;
		this.PrintPreviewBarItem7.Enabled = false;
		this.PrintPreviewBarItem7.Hint = "Save the document";
		this.PrintPreviewBarItem7.Id = 11;
		this.PrintPreviewBarItem7.ImageIndex = 24;
		this.PrintPreviewBarItem7.Name = "PrintPreviewBarItem7";
		this.PrintPreviewBarItem8.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
		this.PrintPreviewBarItem8.Caption = "&Print...";
		this.PrintPreviewBarItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print;
		this.PrintPreviewBarItem8.Enabled = false;
		this.PrintPreviewBarItem8.Hint = "Print";
		this.PrintPreviewBarItem8.Id = 12;
		this.PrintPreviewBarItem8.ImageIndex = 0;
		this.PrintPreviewBarItem8.Name = "PrintPreviewBarItem8";
		this.PrintPreviewBarItem9.Caption = "P&rint";
		this.PrintPreviewBarItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect;
		this.PrintPreviewBarItem9.Enabled = false;
		this.PrintPreviewBarItem9.Hint = "Quick Print";
		this.PrintPreviewBarItem9.Id = 13;
		this.PrintPreviewBarItem9.ImageIndex = 1;
		this.PrintPreviewBarItem9.Name = "PrintPreviewBarItem9";
		this.PrintPreviewBarItem10.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
		this.PrintPreviewBarItem10.Caption = "Page Set&up...";
		this.PrintPreviewBarItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup;
		this.PrintPreviewBarItem10.Enabled = false;
		this.PrintPreviewBarItem10.Hint = "Page Setup";
		this.PrintPreviewBarItem10.Id = 14;
		this.PrintPreviewBarItem10.ImageIndex = 2;
		this.PrintPreviewBarItem10.Name = "PrintPreviewBarItem10";
		this.PrintPreviewBarItem11.Caption = "Header And Footer";
		this.PrintPreviewBarItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF;
		this.PrintPreviewBarItem11.Enabled = false;
		this.PrintPreviewBarItem11.Hint = "Header And Footer";
		this.PrintPreviewBarItem11.Id = 15;
		this.PrintPreviewBarItem11.ImageIndex = 15;
		this.PrintPreviewBarItem11.Name = "PrintPreviewBarItem11";
		this.PrintPreviewBarItem12.ActAsDropDown = true;
		this.PrintPreviewBarItem12.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
		this.PrintPreviewBarItem12.Caption = "Scale";
		this.PrintPreviewBarItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale;
		this.PrintPreviewBarItem12.Enabled = false;
		this.PrintPreviewBarItem12.Hint = "Scale";
		this.PrintPreviewBarItem12.Id = 16;
		this.PrintPreviewBarItem12.ImageIndex = 25;
		this.PrintPreviewBarItem12.Name = "PrintPreviewBarItem12";
		this.PrintPreviewBarItem13.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
		this.PrintPreviewBarItem13.Caption = "Hand Tool";
		this.PrintPreviewBarItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool;
		this.PrintPreviewBarItem13.Enabled = false;
		this.PrintPreviewBarItem13.Hint = "Hand Tool";
		this.PrintPreviewBarItem13.Id = 17;
		this.PrintPreviewBarItem13.ImageIndex = 16;
		this.PrintPreviewBarItem13.Name = "PrintPreviewBarItem13";
		this.PrintPreviewBarItem14.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
		this.PrintPreviewBarItem14.Caption = "Magnifier";
		this.PrintPreviewBarItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier;
		this.PrintPreviewBarItem14.Enabled = false;
		this.PrintPreviewBarItem14.Hint = "Magnifier";
		this.PrintPreviewBarItem14.Id = 18;
		this.PrintPreviewBarItem14.ImageIndex = 3;
		this.PrintPreviewBarItem14.Name = "PrintPreviewBarItem14";
		this.PrintPreviewBarItem15.Caption = "Zoom Out";
		this.PrintPreviewBarItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut;
		this.PrintPreviewBarItem15.Enabled = false;
		this.PrintPreviewBarItem15.Hint = "Zoom Out";
		this.PrintPreviewBarItem15.Id = 19;
		this.PrintPreviewBarItem15.ImageIndex = 5;
		this.PrintPreviewBarItem15.Name = "PrintPreviewBarItem15";
		this.ZoomBarEditItem1.Caption = "Zoom";
		this.ZoomBarEditItem1.Edit = this.PrintPreviewRepositoryItemComboBox1;
		this.ZoomBarEditItem1.EditValue = "100%";
		this.ZoomBarEditItem1.Enabled = false;
		this.ZoomBarEditItem1.Hint = "Zoom";
		this.ZoomBarEditItem1.Id = 20;
		this.ZoomBarEditItem1.Name = "ZoomBarEditItem1";
		this.ZoomBarEditItem1.Width = 70;
		this.PrintPreviewRepositoryItemComboBox1.AutoComplete = false;
		this.PrintPreviewRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.PrintPreviewRepositoryItemComboBox1.DropDownRows = 11;
		this.PrintPreviewRepositoryItemComboBox1.Name = "PrintPreviewRepositoryItemComboBox1";
		this.PrintPreviewBarItem16.Caption = "Zoom In";
		this.PrintPreviewBarItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn;
		this.PrintPreviewBarItem16.Enabled = false;
		this.PrintPreviewBarItem16.Hint = "Zoom In";
		this.PrintPreviewBarItem16.Id = 21;
		this.PrintPreviewBarItem16.ImageIndex = 4;
		this.PrintPreviewBarItem16.Name = "PrintPreviewBarItem16";
		this.PrintPreviewBarItem17.Caption = "First Page";
		this.PrintPreviewBarItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage;
		this.PrintPreviewBarItem17.Enabled = false;
		this.PrintPreviewBarItem17.Hint = "First Page";
		this.PrintPreviewBarItem17.Id = 22;
		this.PrintPreviewBarItem17.ImageIndex = 7;
		this.PrintPreviewBarItem17.Name = "PrintPreviewBarItem17";
		this.PrintPreviewBarItem18.Caption = "Previous Page";
		this.PrintPreviewBarItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage;
		this.PrintPreviewBarItem18.Enabled = false;
		this.PrintPreviewBarItem18.Hint = "Previous Page";
		this.PrintPreviewBarItem18.Id = 23;
		this.PrintPreviewBarItem18.ImageIndex = 8;
		this.PrintPreviewBarItem18.Name = "PrintPreviewBarItem18";
		this.PrintPreviewBarItem19.Caption = "Next Page";
		this.PrintPreviewBarItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage;
		this.PrintPreviewBarItem19.Enabled = false;
		this.PrintPreviewBarItem19.Hint = "Next Page";
		this.PrintPreviewBarItem19.Id = 24;
		this.PrintPreviewBarItem19.ImageIndex = 9;
		this.PrintPreviewBarItem19.Name = "PrintPreviewBarItem19";
		this.PrintPreviewBarItem20.Caption = "Last Page";
		this.PrintPreviewBarItem20.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage;
		this.PrintPreviewBarItem20.Enabled = false;
		this.PrintPreviewBarItem20.Hint = "Last Page";
		this.PrintPreviewBarItem20.Id = 25;
		this.PrintPreviewBarItem20.ImageIndex = 10;
		this.PrintPreviewBarItem20.Name = "PrintPreviewBarItem20";
		this.PrintPreviewBarItem21.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
		this.PrintPreviewBarItem21.Caption = "Multiple Pages";
		this.PrintPreviewBarItem21.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages;
		this.PrintPreviewBarItem21.Enabled = false;
		this.PrintPreviewBarItem21.Hint = "Multiple Pages";
		this.PrintPreviewBarItem21.Id = 26;
		this.PrintPreviewBarItem21.ImageIndex = 11;
		this.PrintPreviewBarItem21.Name = "PrintPreviewBarItem21";
		this.PrintPreviewBarItem22.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
		this.PrintPreviewBarItem22.Caption = "&Color...";
		this.PrintPreviewBarItem22.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground;
		this.PrintPreviewBarItem22.Enabled = false;
		this.PrintPreviewBarItem22.Hint = "Background";
		this.PrintPreviewBarItem22.Id = 27;
		this.PrintPreviewBarItem22.ImageIndex = 12;
		this.PrintPreviewBarItem22.Name = "PrintPreviewBarItem22";
		this.PrintPreviewBarItem23.Caption = "&Watermark...";
		this.PrintPreviewBarItem23.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark;
		this.PrintPreviewBarItem23.Enabled = false;
		this.PrintPreviewBarItem23.Hint = "Watermark";
		this.PrintPreviewBarItem23.Id = 28;
		this.PrintPreviewBarItem23.ImageIndex = 21;
		this.PrintPreviewBarItem23.Name = "PrintPreviewBarItem23";
		this.PrintPreviewBarItem24.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
		this.PrintPreviewBarItem24.Caption = "Export Document...";
		this.PrintPreviewBarItem24.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile;
		this.PrintPreviewBarItem24.Enabled = false;
		this.PrintPreviewBarItem24.Hint = "Export Document...";
		this.PrintPreviewBarItem24.Id = 29;
		this.PrintPreviewBarItem24.ImageIndex = 18;
		this.PrintPreviewBarItem24.Name = "PrintPreviewBarItem24";
		this.PrintPreviewBarItem25.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
		this.PrintPreviewBarItem25.Caption = "Send via E-Mail...";
		this.PrintPreviewBarItem25.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile;
		this.PrintPreviewBarItem25.Enabled = false;
		this.PrintPreviewBarItem25.Hint = "Send via E-Mail...";
		this.PrintPreviewBarItem25.Id = 30;
		this.PrintPreviewBarItem25.ImageIndex = 17;
		this.PrintPreviewBarItem25.Name = "PrintPreviewBarItem25";
		this.PrintPreviewBarItem26.Caption = "E&xit";
		this.PrintPreviewBarItem26.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview;
		this.PrintPreviewBarItem26.Hint = "Close Preview";
		this.PrintPreviewBarItem26.Id = 31;
		this.PrintPreviewBarItem26.ImageIndex = 13;
		this.PrintPreviewBarItem26.Name = "PrintPreviewBarItem26";
		this.PreviewBar2.BarName = "Status Bar";
		this.PreviewBar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
		this.PreviewBar2.DockCol = 0;
		this.PreviewBar2.DockRow = 0;
		this.PreviewBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
		this.PreviewBar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[6]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewStaticItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.BarStaticItem1, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.ProgressBarEditItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.BarButtonItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewStaticItem2, true)
		});
		this.PreviewBar2.OptionsBar.AllowQuickCustomization = false;
		this.PreviewBar2.OptionsBar.DrawDragBorder = false;
		this.PreviewBar2.OptionsBar.UseWholeRow = true;
		this.PreviewBar2.Text = "Status Bar";
		this.PrintPreviewStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.PrintPreviewStaticItem1.Caption = "Page 0 of 0";
		this.PrintPreviewStaticItem1.Id = 0;
		this.PrintPreviewStaticItem1.LeftIndent = 1;
		this.PrintPreviewStaticItem1.Name = "PrintPreviewStaticItem1";
		this.PrintPreviewStaticItem1.RightIndent = 1;
		this.PrintPreviewStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
		this.PrintPreviewStaticItem1.Type = "PageOfPages";
		this.BarStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.BarStaticItem1.Id = 1;
		this.BarStaticItem1.Name = "BarStaticItem1";
		this.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
		this.ProgressBarEditItem1.Edit = this.RepositoryItemProgressBar1;
		this.ProgressBarEditItem1.EditHeight = 12;
		this.ProgressBarEditItem1.Id = 2;
		this.ProgressBarEditItem1.Name = "ProgressBarEditItem1";
		this.ProgressBarEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
		this.ProgressBarEditItem1.Width = 150;
		this.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1";
		this.PrintPreviewBarItem1.Caption = "Stop";
		this.PrintPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding;
		this.PrintPreviewBarItem1.Enabled = false;
		this.PrintPreviewBarItem1.Hint = "Stop";
		this.PrintPreviewBarItem1.Id = 3;
		this.PrintPreviewBarItem1.Name = "PrintPreviewBarItem1";
		this.PrintPreviewBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
		this.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
		this.BarButtonItem1.Enabled = false;
		this.BarButtonItem1.Id = 4;
		this.BarButtonItem1.Name = "BarButtonItem1";
		this.PrintPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		this.PrintPreviewStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.PrintPreviewStaticItem2.Caption = "Zoom Factor: 100%";
		this.PrintPreviewStaticItem2.Id = 5;
		this.PrintPreviewStaticItem2.Name = "PrintPreviewStaticItem2";
		this.PrintPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
		this.PrintPreviewStaticItem2.Type = "ZoomFactor";
		this.PrintPreviewStaticItem2.Width = 40;
		this.PreviewBar3.BarName = "Main Menu";
		this.PreviewBar3.DockCol = 0;
		this.PreviewBar3.DockRow = 0;
		this.PreviewBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
		this.PreviewBar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewSubItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewSubItem2),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewSubItem3)
		});
		this.PreviewBar3.OptionsBar.MultiLine = true;
		this.PreviewBar3.OptionsBar.UseWholeRow = true;
		this.PreviewBar3.Text = "Main Menu";
		this.PrintPreviewSubItem1.Caption = "&File";
		this.PrintPreviewSubItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.File;
		this.PrintPreviewSubItem1.Id = 32;
		this.PrintPreviewSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[6]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem10),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem8),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem9),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem24, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem25),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem26, true)
		});
		this.PrintPreviewSubItem1.Name = "PrintPreviewSubItem1";
		this.PrintPreviewSubItem2.Caption = "&View";
		this.PrintPreviewSubItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.View;
		this.PrintPreviewSubItem2.Id = 33;
		this.PrintPreviewSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewSubItem4, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.BarToolbarsListItem1, true)
		});
		this.PrintPreviewSubItem2.Name = "PrintPreviewSubItem2";
		this.PrintPreviewSubItem4.Caption = "&Page Layout";
		this.PrintPreviewSubItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout;
		this.PrintPreviewSubItem4.Id = 35;
		this.PrintPreviewSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem27),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem28)
		});
		this.PrintPreviewSubItem4.Name = "PrintPreviewSubItem4";
		this.PrintPreviewBarItem27.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
		this.PrintPreviewBarItem27.Caption = "&Facing";
		this.PrintPreviewBarItem27.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing;
		this.PrintPreviewBarItem27.Enabled = false;
		this.PrintPreviewBarItem27.GroupIndex = 100;
		this.PrintPreviewBarItem27.Id = 36;
		this.PrintPreviewBarItem27.Name = "PrintPreviewBarItem27";
		this.PrintPreviewBarItem28.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
		this.PrintPreviewBarItem28.Caption = "&Continuous";
		this.PrintPreviewBarItem28.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous;
		this.PrintPreviewBarItem28.Enabled = false;
		this.PrintPreviewBarItem28.GroupIndex = 100;
		this.PrintPreviewBarItem28.Id = 37;
		this.PrintPreviewBarItem28.Name = "PrintPreviewBarItem28";
		this.BarToolbarsListItem1.Caption = "Bars";
		this.BarToolbarsListItem1.Id = 38;
		this.BarToolbarsListItem1.Name = "BarToolbarsListItem1";
		this.PrintPreviewSubItem3.Caption = "&Background";
		this.PrintPreviewSubItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Background;
		this.PrintPreviewSubItem3.Id = 34;
		this.PrintPreviewSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem22),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem23)
		});
		this.PrintPreviewSubItem3.Name = "PrintPreviewSubItem3";
		this.PrintPreviewBarCheckItem1.Caption = "PDF File";
		this.PrintPreviewBarCheckItem1.Checked = true;
		this.PrintPreviewBarCheckItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf;
		this.PrintPreviewBarCheckItem1.Enabled = false;
		this.PrintPreviewBarCheckItem1.GroupIndex = 2;
		this.PrintPreviewBarCheckItem1.Hint = "PDF File";
		this.PrintPreviewBarCheckItem1.Id = 39;
		this.PrintPreviewBarCheckItem1.Name = "PrintPreviewBarCheckItem1";
		this.PrintPreviewBarCheckItem2.Caption = "HTML File";
		this.PrintPreviewBarCheckItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm;
		this.PrintPreviewBarCheckItem2.Enabled = false;
		this.PrintPreviewBarCheckItem2.GroupIndex = 2;
		this.PrintPreviewBarCheckItem2.Hint = "HTML File";
		this.PrintPreviewBarCheckItem2.Id = 40;
		this.PrintPreviewBarCheckItem2.Name = "PrintPreviewBarCheckItem2";
		this.PrintPreviewBarCheckItem3.Caption = "MHT File";
		this.PrintPreviewBarCheckItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht;
		this.PrintPreviewBarCheckItem3.Enabled = false;
		this.PrintPreviewBarCheckItem3.GroupIndex = 2;
		this.PrintPreviewBarCheckItem3.Hint = "MHT File";
		this.PrintPreviewBarCheckItem3.Id = 41;
		this.PrintPreviewBarCheckItem3.Name = "PrintPreviewBarCheckItem3";
		this.PrintPreviewBarCheckItem4.Caption = "RTF File";
		this.PrintPreviewBarCheckItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf;
		this.PrintPreviewBarCheckItem4.Enabled = false;
		this.PrintPreviewBarCheckItem4.GroupIndex = 2;
		this.PrintPreviewBarCheckItem4.Hint = "RTF File";
		this.PrintPreviewBarCheckItem4.Id = 42;
		this.PrintPreviewBarCheckItem4.Name = "PrintPreviewBarCheckItem4";
		this.PrintPreviewBarCheckItem5.Caption = "Excel File";
		this.PrintPreviewBarCheckItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls;
		this.PrintPreviewBarCheckItem5.Enabled = false;
		this.PrintPreviewBarCheckItem5.GroupIndex = 2;
		this.PrintPreviewBarCheckItem5.Hint = "Excel File";
		this.PrintPreviewBarCheckItem5.Id = 43;
		this.PrintPreviewBarCheckItem5.Name = "PrintPreviewBarCheckItem5";
		this.PrintPreviewBarCheckItem6.Caption = "CSV File";
		this.PrintPreviewBarCheckItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv;
		this.PrintPreviewBarCheckItem6.Enabled = false;
		this.PrintPreviewBarCheckItem6.GroupIndex = 2;
		this.PrintPreviewBarCheckItem6.Hint = "CSV File";
		this.PrintPreviewBarCheckItem6.Id = 44;
		this.PrintPreviewBarCheckItem6.Name = "PrintPreviewBarCheckItem6";
		this.PrintPreviewBarCheckItem7.Caption = "Text File";
		this.PrintPreviewBarCheckItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt;
		this.PrintPreviewBarCheckItem7.Enabled = false;
		this.PrintPreviewBarCheckItem7.GroupIndex = 2;
		this.PrintPreviewBarCheckItem7.Hint = "Text File";
		this.PrintPreviewBarCheckItem7.Id = 45;
		this.PrintPreviewBarCheckItem7.Name = "PrintPreviewBarCheckItem7";
		this.PrintPreviewBarCheckItem8.Caption = "Image File";
		this.PrintPreviewBarCheckItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic;
		this.PrintPreviewBarCheckItem8.Enabled = false;
		this.PrintPreviewBarCheckItem8.GroupIndex = 2;
		this.PrintPreviewBarCheckItem8.Hint = "Image File";
		this.PrintPreviewBarCheckItem8.Id = 46;
		this.PrintPreviewBarCheckItem8.Name = "PrintPreviewBarCheckItem8";
		this.PrintPreviewBarCheckItem9.Caption = "PDF File";
		this.PrintPreviewBarCheckItem9.Checked = true;
		this.PrintPreviewBarCheckItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf;
		this.PrintPreviewBarCheckItem9.Enabled = false;
		this.PrintPreviewBarCheckItem9.GroupIndex = 1;
		this.PrintPreviewBarCheckItem9.Hint = "PDF File";
		this.PrintPreviewBarCheckItem9.Id = 47;
		this.PrintPreviewBarCheckItem9.Name = "PrintPreviewBarCheckItem9";
		this.PrintPreviewBarCheckItem10.Caption = "MHT File";
		this.PrintPreviewBarCheckItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht;
		this.PrintPreviewBarCheckItem10.Enabled = false;
		this.PrintPreviewBarCheckItem10.GroupIndex = 1;
		this.PrintPreviewBarCheckItem10.Hint = "MHT File";
		this.PrintPreviewBarCheckItem10.Id = 48;
		this.PrintPreviewBarCheckItem10.Name = "PrintPreviewBarCheckItem10";
		this.PrintPreviewBarCheckItem11.Caption = "RTF File";
		this.PrintPreviewBarCheckItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf;
		this.PrintPreviewBarCheckItem11.Enabled = false;
		this.PrintPreviewBarCheckItem11.GroupIndex = 1;
		this.PrintPreviewBarCheckItem11.Hint = "RTF File";
		this.PrintPreviewBarCheckItem11.Id = 49;
		this.PrintPreviewBarCheckItem11.Name = "PrintPreviewBarCheckItem11";
		this.PrintPreviewBarCheckItem12.Caption = "Excel File";
		this.PrintPreviewBarCheckItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls;
		this.PrintPreviewBarCheckItem12.Enabled = false;
		this.PrintPreviewBarCheckItem12.GroupIndex = 1;
		this.PrintPreviewBarCheckItem12.Hint = "Excel File";
		this.PrintPreviewBarCheckItem12.Id = 50;
		this.PrintPreviewBarCheckItem12.Name = "PrintPreviewBarCheckItem12";
		this.PrintPreviewBarCheckItem13.Caption = "CSV File";
		this.PrintPreviewBarCheckItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv;
		this.PrintPreviewBarCheckItem13.Enabled = false;
		this.PrintPreviewBarCheckItem13.GroupIndex = 1;
		this.PrintPreviewBarCheckItem13.Hint = "CSV File";
		this.PrintPreviewBarCheckItem13.Id = 51;
		this.PrintPreviewBarCheckItem13.Name = "PrintPreviewBarCheckItem13";
		this.PrintPreviewBarCheckItem14.Caption = "Text File";
		this.PrintPreviewBarCheckItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt;
		this.PrintPreviewBarCheckItem14.Enabled = false;
		this.PrintPreviewBarCheckItem14.GroupIndex = 1;
		this.PrintPreviewBarCheckItem14.Hint = "Text File";
		this.PrintPreviewBarCheckItem14.Id = 52;
		this.PrintPreviewBarCheckItem14.Name = "PrintPreviewBarCheckItem14";
		this.PrintPreviewBarCheckItem15.Caption = "Image File";
		this.PrintPreviewBarCheckItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic;
		this.PrintPreviewBarCheckItem15.Enabled = false;
		this.PrintPreviewBarCheckItem15.GroupIndex = 1;
		this.PrintPreviewBarCheckItem15.Hint = "Image File";
		this.PrintPreviewBarCheckItem15.Id = 53;
		this.PrintPreviewBarCheckItem15.Name = "PrintPreviewBarCheckItem15";
		this.PrintControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.PrintControl1.BackColor = System.Drawing.Color.Empty;
		this.PrintControl1.ForeColor = System.Drawing.Color.Empty;
		this.PrintControl1.IsMetric = true;
		DevExpress.XtraPrinting.Control.PrintControl printControl = this.PrintControl1;
		location = new System.Drawing.Point(1, 0);
		printControl.Location = location;
		this.PrintControl1.Name = "PrintControl1";
		DevExpress.XtraPrinting.Control.PrintControl printControl2 = this.PrintControl1;
		size = new System.Drawing.Size(621, 440);
		printControl2.Size = size;
		this.PrintControl1.TabIndex = 0;
		this.PrintControl1.TooltipFont = new System.Drawing.Font("Tahoma", 8.25f);
		this.CheckedListBoxControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl = this.CheckedListBoxControl1;
		location = new System.Drawing.Point(0, 0);
		checkedListBoxControl.Location = location;
		this.CheckedListBoxControl1.Name = "CheckedListBoxControl1";
		DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl2 = this.CheckedListBoxControl1;
		size = new System.Drawing.Size(231, 440);
		checkedListBoxControl2.Size = size;
		this.CheckedListBoxControl1.TabIndex = 8;
		this.SplitContainerControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DevExpress.XtraEditors.SplitContainerControl splitContainerControl = this.SplitContainerControl1;
		location = new System.Drawing.Point(0, 51);
		splitContainerControl.Location = location;
		this.SplitContainerControl1.Name = "SplitContainerControl1";
		this.SplitContainerControl1.Panel1.Controls.Add(this.CheckedListBoxControl1);
		this.SplitContainerControl1.Panel1.Text = "Panel1";
		this.SplitContainerControl1.Panel2.Controls.Add(this.PrintControl1);
		this.SplitContainerControl1.Panel2.Text = "Panel2";
		DevExpress.XtraEditors.SplitContainerControl splitContainerControl2 = this.SplitContainerControl1;
		size = new System.Drawing.Size(858, 440);
		splitContainerControl2.Size = size;
		this.SplitContainerControl1.SplitterPosition = 230;
		this.SplitContainerControl1.TabIndex = 9;
		this.SplitContainerControl1.Text = "SplitContainerControl1";
		this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.Button1.AutoSize = true;
		this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Image = RecursosHumanos.My.Resources.Resources.document_out;
		System.Windows.Forms.Button button = this.Button1;
		location = new System.Drawing.Point(160, 497);
		button.Location = location;
		this.Button1.Name = "Button1";
		System.Windows.Forms.Button button2 = this.Button1;
		size = new System.Drawing.Size(71, 23);
		button2.Size = size;
		this.Button1.TabIndex = 13;
		this.Button1.Text = "Generar";
		this.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button1.UseVisualStyleBackColor = true;
		System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleDimensions = sizeF;
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		size = new System.Drawing.Size(858, 551);
		this.ClientSize = size;
		this.Controls.Add(this.Button1);
		this.Controls.Add(this.SplitContainerControl1);
		this.Controls.Add(this.barDockControlLeft);
		this.Controls.Add(this.barDockControlRight);
		this.Controls.Add(this.barDockControlBottom);
		this.Controls.Add(this.barDockControlTop);
		this.Name = "FrmReporteProfesion";
		this.TitleMsg = "FrmConsulta";
		this.VerPanelInf = false;
		this.VerPanelSup = false;
		this.Controls.SetChildIndex(this.barDockControlTop, 0);
		this.Controls.SetChildIndex(this.barDockControlBottom, 0);
		this.Controls.SetChildIndex(this.barDockControlRight, 0);
		this.Controls.SetChildIndex(this.barDockControlLeft, 0);
		this.Controls.SetChildIndex(this.SplitContainerControl1, 0);
		this.Controls.SetChildIndex(this.PanelSup, 0);
		this.Controls.SetChildIndex(this.PanelInf, 0);
		this.Controls.SetChildIndex(this.cmdCerrar, 0);
		this.Controls.SetChildIndex(this.Button1, 0);
		((System.ComponentModel.ISupportInitialize)this.PrintBarManager1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PrintPreviewRepositoryItemComboBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemProgressBar1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CheckedListBoxControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).EndInit();
		this.SplitContainerControl1.ResumeLayout(false);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void FrmReporteProfesion_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
		CheckedListBoxControl1.DataSource = RuntimeHelpers.GetObjectValue(objRRHHClass.ListarProfesiones());
		CheckedListBoxControl1.ValueMember = "profesion";
		CheckedListBoxControl1.DisplayMember = "profesion";
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		DataTable dataTable = new DataTable();
		DataTable dataTable2 = new DataTable();
		dataTable2.TableName = "spRRHH_Rep_profesion";
		checked
		{
			int num = CheckedListBoxControl1.ItemCount - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (CheckedListBoxControl1.GetItemChecked(num2))
				{
					dataTable = objRRHHClass.spRRHH_Rep_profesion(CheckedListBoxControl1.GetItemValue(num2).ToString());
					dataTable2.Merge(dataTable, preserveChanges: true);
				}
				num2++;
			}
			DataSet dataSet = new DataSet();
			dataTable2.DefaultView.Sort = "Profesion";
			dataSet.Tables.Add(dataTable2);
			Rep_Profesion rep_Profesion = new Rep_Profesion();
			rep_Profesion.DataSource = dataSet;
			PrintControl1.PrintingSystem = rep_Profesion.PrintingSystem;
			rep_Profesion.CreateDocument();
		}
	}
}
