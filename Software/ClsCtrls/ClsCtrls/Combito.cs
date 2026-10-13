using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ClsCtrls;

public class Combito : ComboBox
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("oList")]
	private Clases.clsDbArray _oList;

	private const int EM_SETREADONLY = 207;

	private const int EM_EMPTYUNDOBUFFER = 205;

	private const int CB_SHOWDROPDOWN = 335;

	private const int GW_CHILD = 5;

	private Color nBackColorNormal;

	private Color nBackColorDisabled;

	private Color nBackColorFocus;

	private Color nForeColorNormal;

	private Color nForeColorDisabled;

	private Color nForeColorFocus;

	private bool bReadOnly;

	private bool bDroppedDown;

	private int nSelectedIndex;

	private ComboBoxStyle oDropDownStyle;

	private bool bEnabled;

	private string mDividerFormat;

	private Color mGroupColor;

	private int mLastSelectedIndex;

	private Clases clsClase;

	private Clases.clsDbArray oList
	{
		[DebuggerNonUserCode]
		get
		{
			return _oList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			Clases.clsDbArray.MyDBArrayListChangedEventHandler obj = oList_MyDBArrayListChanged;
			if (_oList != null)
			{
				_oList.MyDBArrayListChanged -= obj;
			}
			_oList = value;
			if (_oList != null)
			{
				_oList.MyDBArrayListChanged += obj;
			}
		}
	}

	public Clases Clase
	{
		get
		{
			return clsClase;
		}
		set
		{
			clsClase = value;
		}
	}

	public Clases.clsDbArray oDbArray => oList;

	public new Clases.MyStListItemCollection Items => oList.oItems;

	[DefaultValue(false)]
	[Browsable(true)]
	public bool ReadOnly
	{
		get
		{
			return bReadOnly;
		}
		set
		{
			bReadOnly = value;
			if (bReadOnly)
			{
				oDropDownStyle = base.DropDownStyle;
				base.DropDownStyle = ComboBoxStyle.DropDown;
			}
			else
			{
				base.DropDownStyle = oDropDownStyle;
			}
			base.TabStop = !value;
			base.SelectionLength = 0;
			SendMessage(GetWindow(Handle, 5), 207, value, 0);
			SendMessage(GetWindow(Handle, 5), 205, value, 0);
			bDroppedDown = false;
			Refresh();
		}
	}

	public new int SelectedIndex
	{
		get
		{
			return nSelectedIndex;
		}
		set
		{
			nSelectedIndex = value;
			base.SelectedIndex = value;
			if (value == -1)
			{
				nSelectedIndex = value;
				base.SelectedIndex = value;
				base.Text = "";
			}
		}
	}

	public SqlConnection SysCn
	{
		get
		{
			return oList.SysCn;
		}
		set
		{
			oList.SysCn = value;
		}
	}

	public string BdColText1
	{
		get
		{
			return oList.DbColText1;
		}
		set
		{
			oList.DbColText1 = value;
		}
	}

	public string BdColText2
	{
		get
		{
			return oList.DbColText2;
		}
		set
		{
			oList.DbColText2 = value;
		}
	}

	public string BdColText3
	{
		get
		{
			return oList.DbColText3;
		}
		set
		{
			oList.DbColText3 = value;
		}
	}

	public string BdColInt1
	{
		get
		{
			return oList.DbColInt1;
		}
		set
		{
			oList.DbColInt1 = value;
		}
	}

	public string BdColInt2
	{
		get
		{
			return oList.DbColInt2;
		}
		set
		{
			oList.DbColInt2 = value;
		}
	}

	public string BdColInt3
	{
		get
		{
			return oList.DbColInt3;
		}
		set
		{
			oList.DbColInt3 = value;
		}
	}

	public string BDTabla
	{
		get
		{
			return oList.DbTabla;
		}
		set
		{
			oList.DbTabla = value;
		}
	}

	public string BdColWhere
	{
		get
		{
			return oList.DbWhere;
		}
		set
		{
			oList.DbWhere = value;
		}
	}

	public string BdColTextShow
	{
		get
		{
			return oList.DbColTextShow;
		}
		set
		{
			oList.DbColTextShow = value;
		}
	}

	public string BdColTextId
	{
		get
		{
			return oList.DbColTextId;
		}
		set
		{
			oList.DbColTextId = value;
		}
	}

	public string BdColDescrip
	{
		get
		{
			return oList.DbColDescrip;
		}
		set
		{
			oList.DbColDescrip = value;
		}
	}

	public string BdColInt
	{
		get
		{
			return oList.DbColInt;
		}
		set
		{
			oList.DbColInt = value;
		}
	}

	public string BdColIntId
	{
		get
		{
			return oList.DbColIntId;
		}
		set
		{
			oList.DbColIntId = value;
		}
	}

	public string BdColLong
	{
		get
		{
			return oList.DbColLong;
		}
		set
		{
			oList.DbColLong = value;
		}
	}

	public string BdColDecimal
	{
		get
		{
			return oList.DbColDecimal;
		}
		set
		{
			oList.DbColDecimal = value;
		}
	}

	public string BdColSingle
	{
		get
		{
			return oList.DbColSingle;
		}
		set
		{
			oList.DbColSingle = value;
		}
	}

	public int ListCount => base.Items.Count;

	public int ListIndex
	{
		get
		{
			return base.SelectedIndex;
		}
		set
		{
			base.SelectedIndex = value;
			if (value < 0)
			{
				Text = "";
			}
		}
	}

	public new bool Enabled
	{
		get
		{
			return bEnabled;
		}
		set
		{
			base.Enabled = value;
			Invalidate();
		}
	}

	public string DividerFormat
	{
		get
		{
			return mDividerFormat;
		}
		set
		{
			mDividerFormat = value;
			Invalidate();
		}
	}

	public Color GroupColor
	{
		get
		{
			return mGroupColor;
		}
		set
		{
			mGroupColor = value;
			Invalidate();
		}
	}

	public Color BackColorNormal
	{
		get
		{
			return nBackColorNormal;
		}
		set
		{
			nBackColorNormal = value;
			SetColor();
		}
	}

	public Color ForeColorNormal
	{
		get
		{
			return nForeColorNormal;
		}
		set
		{
			nForeColorNormal = value;
			SetColor();
		}
	}

	public Color ForeColorFocus
	{
		get
		{
			return nForeColorFocus;
		}
		set
		{
			nForeColorFocus = value;
		}
	}

	public Color ForeColorDisabled
	{
		get
		{
			return nForeColorDisabled;
		}
		set
		{
			nForeColorDisabled = value;
		}
	}

	public Color BackColorFocus
	{
		get
		{
			return nBackColorFocus;
		}
		set
		{
			nBackColorFocus = value;
		}
	}

	public Color BackColorDisabled
	{
		get
		{
			return nBackColorDisabled;
		}
		set
		{
			nBackColorDisabled = value;
		}
	}

	public string BDSelect
	{
		get
		{
			return oList.DbSelect;
		}
		set
		{
			oList.DbSelect = value;
		}
	}

	public string BDOrderBy
	{
		get
		{
			return oList.DbOrderBy;
		}
		set
		{
			oList.DbOrderBy = value;
		}
	}

	public int ValorInt1
	{
		get
		{
			if (ListIndex < 0)
			{
				return 0;
			}
			return oListItem(ListIndex).Int1;
		}
	}

	public int ValorInt2
	{
		get
		{
			if (ListIndex < 0)
			{
				return 0;
			}
			return oListItem(ListIndex).Int2;
		}
	}

	public int ValorInt3
	{
		get
		{
			if (ListIndex < 0)
			{
				return 0;
			}
			return oListItem(ListIndex).Int3;
		}
	}

	public decimal ValorNroDecimal
	{
		get
		{
			if (ListIndex < 0)
			{
				return 0m;
			}
			return oListItem(ListIndex).NroDecimal;
		}
	}

	public int ValorNroInt
	{
		get
		{
			if (ListIndex < 0)
			{
				return 0;
			}
			return oListItem(ListIndex).NroInt;
		}
	}

	public int ValorNroIntId
	{
		get
		{
			if (ListIndex < 0)
			{
				return 0;
			}
			return oListItem(ListIndex).NroIntId;
		}
	}

	public long ValorNroLong
	{
		get
		{
			if (ListIndex < 0)
			{
				return 0L;
			}
			return oListItem(ListIndex).NroLong;
		}
	}

	public float ValorNroSingle
	{
		get
		{
			if (ListIndex < 0)
			{
				return 0f;
			}
			return oListItem(ListIndex).NroSingle;
		}
	}

	public string ValorText1
	{
		get
		{
			if (ListIndex < 0)
			{
				return "";
			}
			return oListItem(ListIndex).Text1.ToString();
		}
	}

	public string ValorText2
	{
		get
		{
			if (ListIndex < 0)
			{
				return "";
			}
			return oListItem(ListIndex).Text2.ToString();
		}
	}

	public string ValorText3
	{
		get
		{
			if (ListIndex < 0)
			{
				return "";
			}
			return oListItem(ListIndex).Text3.ToString();
		}
	}

	public string ValorTextDescrip
	{
		get
		{
			if (ListIndex < 0)
			{
				return "";
			}
			return oListItem(ListIndex).TextDescrip.ToString();
		}
	}

	public string ValorTextId
	{
		get
		{
			if (ListIndex < 0)
			{
				return "";
			}
			return oListItem(ListIndex).TextId.ToString();
		}
	}

	public string ValorTextShow
	{
		get
		{
			if (ListIndex < 0)
			{
				return "";
			}
			return oListItem(ListIndex).TextShow.ToString();
		}
	}

	public Combito()
	{
		base.KeyDown += Combito_KeyDown;
		base.KeyPress += ucBaseComboBox_KeyPress;
		base.GotFocus += ucBaseComboBox_GotFocus;
		base.LostFocus += ucBaseComboBox_LostFocus;
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		oList = new Clases.clsDbArray();
		nBackColorNormal = Color.FromArgb(255, 255, 255);
		nBackColorDisabled = Color.Gainsboro;
		nBackColorFocus = Color.FromArgb(255, 255, 255);
		nForeColorNormal = Color.MediumBlue;
		nForeColorDisabled = Color.DarkGreen;
		nForeColorFocus = Color.Blue;
		bReadOnly = false;
		nSelectedIndex = -1;
		oDropDownStyle = ComboBoxStyle.DropDown;
		bEnabled = true;
		mDividerFormat = "---";
		mGroupColor = Color.Red;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetWindow(IntPtr hwnd, int wCmd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SendMessage(IntPtr hwnd, int wMsg, bool wParam, int lParam);

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
	}

	private void oList_MyDBArrayListChanged(object sender, Clases.stListItemChangedEventArgs e)
	{
		SetItemsCore(oList.oItems);
	}

	public void SelectByText1(string cValue)
	{
		base.SelectedIndex = oList.FindText1(cValue);
	}

	public void SelectByText2(string cValue)
	{
		base.SelectedIndex = oList.FindText2(cValue);
	}

	public void SelectByText3(string cValue)
	{
		base.SelectedIndex = oList.FindText3(cValue);
	}

	public void SelectByInt1(int cValue)
	{
		base.SelectedIndex = oList.FindInt1(cValue);
	}

	public void SelectByInt2(int cValue)
	{
		base.SelectedIndex = oList.FindInt2(cValue);
	}

	public void SelectByInt3(int cValue)
	{
		base.SelectedIndex = oList.FindInt3(cValue);
	}

	public void SelectByTextShow(string cValue)
	{
		base.SelectedIndex = oList.FindTextShow(cValue);
	}

	public void SelectByTextId(string cValue)
	{
		base.SelectedIndex = oList.FindTextId(cValue);
	}

	public void SelectByTextDescrip(string cValue)
	{
		base.SelectedIndex = oList.FindTextDescrip(cValue);
	}

	public void SelectByNroInt(int cValue)
	{
		base.SelectedIndex = oList.FindNroInt(cValue);
	}

	public void SelectByNroIntId(int cValue)
	{
		base.SelectedIndex = oList.FindNroIntId(cValue);
	}

	public void SelectByNroLong(long cValue)
	{
		base.SelectedIndex = oList.FindNroLong(cValue);
	}

	public void SelectByNroDecimal(decimal cValue)
	{
		base.SelectedIndex = oList.FindNroDecimal(cValue);
	}

	public void SelectByNroSingle(float cValue)
	{
		base.SelectedIndex = oList.FindNroSingle(cValue);
	}

	public Clases.stListItem oListItem(int nItem)
	{
		return oList.oItems[nItem];
	}

	public void AddItem(string cText, int nNroInt = 0, string cTextId = "")
	{
		oList.AddItem(cText, nNroInt, cTextId, "", 0, 0L);
		SetItemsCore(oList.oItems);
	}

	private void SetColor()
	{
		object obj = Interaction.IIf(bEnabled, nForeColorNormal, nForeColorDisabled);
		Color color = default(Color);
		base.ForeColor = ((obj != null) ? ((Color)obj) : color);
		object obj2 = Interaction.IIf(bEnabled, nBackColorNormal, nBackColorDisabled);
		base.BackColor = ((obj2 != null) ? ((Color)obj2) : color);
	}

	public void GetData(DataTable Tabla)
	{
		oList.GetData(Tabla);
		SetItemsCore(oList.oItems);
	}

	public void GetData()
	{
		oList.GetData();
		SetItemsCore(oList.oItems);
	}

	public void GetData(SqlConnection oCn)
	{
		oList.SysCn = oCn;
		oList.GetData();
		SetItemsCore(oList.oItems);
	}

	private void Combito_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
		{
			Combito combito = (Combito)sender;
			combito.SelectedIndex = -1;
		}
	}

	private void ucBaseComboBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			SendKeys.Send("{TAB}");
		}
	}

	private void ucBaseComboBox_GotFocus(object sender, EventArgs e)
	{
		base.ForeColor = nForeColorFocus;
		base.BackColor = nBackColorFocus;
		SelectAll();
	}

	private void ucBaseComboBox_LostFocus(object sender, EventArgs e)
	{
		base.ForeColor = nForeColorNormal;
		base.BackColor = nBackColorNormal;
	}

	protected override void OnDropDown(EventArgs e)
	{
		bDroppedDown = true;
		base.OnDropDown(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (bReadOnly && ((e.KeyCode == Keys.Up || e.KeyCode == Keys.Prior || e.KeyCode == Keys.Next || ((e.KeyCode == Keys.Down) & ((Control.ModifierKeys & Keys.Alt) != Keys.Alt))) ? true : false))
		{
			e.Handled = true;
		}
		base.OnKeyDown(e);
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		base.OnEnabledChanged(e);
		bEnabled = base.Enabled;
		SetColor();
	}

	protected override void OnSelectionChangeCommitted(EventArgs e)
	{
		if (!bReadOnly)
		{
			base.OnSelectionChangeCommitted(e);
		}
	}

	protected override void OnSelectedIndexChanged(EventArgs e)
	{
		if (Text.IndexOf(mDividerFormat) == -1)
		{
			nSelectedIndex = base.SelectedIndex;
			mLastSelectedIndex = SelectedIndex;
			base.OnSelectedIndexChanged(e);
		}
		else
		{
			SelectedIndex = mLastSelectedIndex;
		}
	}

	public void Clear()
	{
		base.Items.Clear();
		base.Text = "";
	}
}
