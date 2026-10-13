using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Microsoft.VisualBasic.CompilerServices;

namespace RecursosHumanos;

[DesignerGenerated]
public class Report_Porcentaje : XtraReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Detail")]
	private DetailBand _Detail;

	[AccessedThroughProperty("TopMargin")]
	private TopMarginBand _TopMargin;

	[AccessedThroughProperty("BottomMargin")]
	private BottomMarginBand _BottomMargin;

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

	internal TopMarginBand TopMargin
	{
		[DebuggerNonUserCode]
		get
		{
			return _TopMargin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TopMargin = value;
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

	[DebuggerNonUserCode]
	public Report_Porcentaje()
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
		TopMargin = new TopMarginBand();
		BottomMargin = new BottomMarginBand();
		((ISupportInitialize)this).BeginInit();
		Detail.HeightF = 200f;
		Detail.Name = "Detail";
		DetailBand detail = Detail;
		PaddingInfo padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detail.Padding = padding;
		Detail.TextAlignment = TextAlignment.TopLeft;
		TopMargin.Name = "TopMargin";
		TopMarginBand topMargin = TopMargin;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		topMargin.Padding = padding;
		TopMargin.TextAlignment = TextAlignment.TopLeft;
		BottomMargin.Name = "BottomMargin";
		BottomMarginBand bottomMargin = BottomMargin;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		bottomMargin.Padding = padding;
		BottomMargin.TextAlignment = TextAlignment.TopLeft;
		Bands.AddRange(new Band[3] { Detail, TopMargin, BottomMargin });
		ScriptLanguage = ScriptLanguage.VisualBasic;
		Version = "11.2";
		((ISupportInitialize)this).EndInit();
	}
}
