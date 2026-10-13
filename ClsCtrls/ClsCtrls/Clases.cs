using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ClsCtrls;

public class Clases
{
	public enum enumStListItemChangedType
	{
		Added,
		Removed,
		Replaced,
		Cleared
	}

	public class MyErrObject
	{
		private ErrObject oErr;

		private string cModClass;

		private string cSubFunct;

		public ErrObject err
		{
			get
			{
				return oErr;
			}
			set
			{
				oErr = value;
			}
		}

		public string ModuloClase
		{
			get
			{
				return cModClass;
			}
			set
			{
				cModClass = value.Trim();
			}
		}

		public string SubFunct
		{
			get
			{
				return cSubFunct;
			}
			set
			{
				cSubFunct = value.Trim();
			}
		}

		public void Clear()
		{
			oErr = null;
			cModClass = "";
			cSubFunct = "";
		}

		public override string ToString()
		{
			return "Error en " + cModClass + ":" + cSubFunct + "\r\nDetalle: " + Conversions.ToString(oErr.Number) + ", " + oErr.Description + "\r\nSource: " + oErr.Source;
		}

		public MyErrObject(ErrObject oError, string cModuloClase, string cSubFunction)
		{
			oErr = oError;
			cModClass = cModuloClase;
			cSubFunct = cSubFunction;
		}

		public MyErrObject()
		{
			oErr.Clear();
			cModClass = "";
			cSubFunct = "";
		}
	}

	public class clsDbArray
	{
		public delegate void MyDBArrayListChangedEventHandler(object sender, stListItemChangedEventArgs e);

		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private string _Select;

		private string _OrderBy;

		private string _ColText1;

		private string _ColText2;

		private string _ColText3;

		private string _ColInt1;

		private string _ColInt2;

		private string _ColInt3;

		private string _Tabla;

		private string _cWhere;

		private string _ColIntId;

		private string _ColInt;

		private string _ColLong;

		private string _ColDecimal;

		private string _ColSingle;

		private string _ColTextId;

		private string _ColTextShow;

		private string _ColDescrip;

		private int nOpciones;

		[AccessedThroughProperty("oListItems")]
		private MyStListItemCollection _oListItems;

		private SqlConnection oCn;

		private MyStListItemCollection oListItems
		{
			[DebuggerNonUserCode]
			get
			{
				return _oListItems;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler<stListItemChangedEventArgs> obj = oListItems_MyStListItemCollectionChanged;
				if (_oListItems != null)
				{
					_oListItems.MyStListItemCollectionChanged -= obj;
				}
				_oListItems = value;
				if (_oListItems != null)
				{
					_oListItems.MyStListItemCollectionChanged += obj;
				}
			}
		}

		public MyStListItemCollection oItems => oListItems;

		public SqlConnection SysCn
		{
			get
			{
				return oCn;
			}
			set
			{
				oCn = value;
			}
		}

		public string DbColText1
		{
			get
			{
				return _ColText1;
			}
			set
			{
				_ColText1 = value.Trim();
			}
		}

		public string DbColText2
		{
			get
			{
				return _ColText2;
			}
			set
			{
				_ColText2 = value.Trim();
			}
		}

		public string DbColText3
		{
			get
			{
				return _ColText3;
			}
			set
			{
				_ColText3 = value.Trim();
			}
		}

		public string DbColInt1
		{
			get
			{
				return _ColInt1;
			}
			set
			{
				_ColInt1 = value.Trim();
			}
		}

		public string DbColInt2
		{
			get
			{
				return _ColInt2;
			}
			set
			{
				_ColInt2 = value.Trim();
			}
		}

		public string DbColInt3
		{
			get
			{
				return _ColInt3;
			}
			set
			{
				_ColInt3 = value.Trim();
			}
		}

		public string DbSelect
		{
			get
			{
				return _Select;
			}
			set
			{
				_Select = value.Trim();
			}
		}

		public string DbOrderBy
		{
			get
			{
				return _OrderBy;
			}
			set
			{
				_OrderBy = value.Trim();
			}
		}

		public string DbTabla
		{
			get
			{
				return _Tabla;
			}
			set
			{
				_Tabla = value.Trim();
			}
		}

		public string DbWhere
		{
			get
			{
				return _cWhere;
			}
			set
			{
				_cWhere = value.Trim();
			}
		}

		public string DbColIntId
		{
			get
			{
				return _ColIntId;
			}
			set
			{
				_ColIntId = value.Trim();
			}
		}

		public string DbColInt
		{
			get
			{
				return _ColInt;
			}
			set
			{
				_ColInt = value.Trim();
			}
		}

		public string DbColLong
		{
			get
			{
				return _ColLong;
			}
			set
			{
				_ColLong = value.Trim();
			}
		}

		public string DbColDecimal
		{
			get
			{
				return _ColDecimal;
			}
			set
			{
				_ColDecimal = value.Trim();
			}
		}

		public string DbColSingle
		{
			get
			{
				return _ColSingle;
			}
			set
			{
				_ColSingle = value.Trim();
			}
		}

		public string DbColTextId
		{
			get
			{
				return _ColTextId;
			}
			set
			{
				_ColTextId = value.Trim();
			}
		}

		public string DbColTextShow
		{
			get
			{
				return _ColTextShow;
			}
			set
			{
				_ColTextShow = value.Trim();
			}
		}

		public string DbColDescrip
		{
			get
			{
				return _ColDescrip;
			}
			set
			{
				_ColDescrip = value.Trim();
			}
		}

		public int ListCount => oItems.Count;

		[method: DebuggerNonUserCode]
		public event MyDBArrayListChangedEventHandler MyDBArrayListChanged;

		public clsDbArray()
		{
			lock (__ENCList)
			{
				__ENCList.Add(new WeakReference(this));
			}
			_Select = "";
			_OrderBy = "";
			_ColText1 = "";
			_ColText2 = "";
			_ColText3 = "";
			_ColInt1 = "";
			_ColInt2 = "";
			_ColInt3 = "";
			_Tabla = "";
			_cWhere = "";
			_ColIntId = "";
			_ColInt = "";
			_ColLong = "";
			_ColDecimal = "";
			_ColSingle = "";
			_ColTextId = "";
			_ColTextShow = "";
			_ColDescrip = "";
			nOpciones = -1;
			oListItems = new MyStListItemCollection();
		}

		public int FindText1(string cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			cValue = cValue.Trim();
			cValue = cValue.ToUpper();
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.CompareString(cValue, Strings.UCase(oItems[num2].Text1), TextCompare: false) == 0)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindText2(string cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			cValue = cValue.Trim();
			cValue = cValue.ToUpper();
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.CompareString(cValue, Strings.UCase(oItems[num2].Text2), TextCompare: false) == 0)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindText3(string cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			cValue = cValue.Trim();
			cValue = cValue.ToUpper();
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.CompareString(cValue, Strings.UCase(oItems[num2].Text3), TextCompare: false) == 0)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindInt1(int cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (cValue == oItems[num2].Int1)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindInt2(int cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (cValue == oItems[num2].Int2)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindInt3(int cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (cValue == oItems[num2].Int3)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindTextShow(string cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			cValue = cValue.Trim();
			cValue = cValue.ToUpper();
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.CompareString(cValue, Strings.UCase(oItems[num2].TextShow), TextCompare: false) == 0)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindTextId(string cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			cValue = cValue.Trim();
			cValue = cValue.ToUpper();
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.CompareString(cValue, Strings.UCase(oItems[num2].TextId), TextCompare: false) == 0)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindTextDescrip(string cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			cValue = cValue.Trim();
			cValue = cValue.ToUpper();
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.CompareString(cValue, Strings.UCase(oItems[num2].TextDescrip), TextCompare: false) == 0)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindNroInt(int cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (cValue == oItems[num2].NroInt)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindNroIntId(int cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (cValue == oItems[num2].NroIntId)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindNroLong(long cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (cValue == oItems[num2].NroLong)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindNroDecimal(decimal cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (decimal.Compare(cValue, oItems[num2].NroDecimal) == 0)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public int FindNroSingle(float cValue)
		{
			int result = -1;
			if (oItems.Count <= 0)
			{
				return result;
			}
			checked
			{
				int num = nOpciones - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (cValue == oItems[num2].NroSingle)
					{
						result = num2;
						break;
					}
					num2++;
				}
				return result;
			}
		}

		public void ClearAll()
		{
			checked
			{
				int num = oItems.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						oItems[num2].Clear();
						num2++;
						continue;
					}
					break;
				}
			}
		}

		public void SetItems(int nItems)
		{
			if (nItems <= 0)
			{
				oItems.Clear();
				return;
			}
			checked
			{
				int num2;
				if (nItems > oItems.Count)
				{
					int count = oItems.Count;
					int num = nItems - 1;
					num2 = count;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						MyStListItemCollection myStListItemCollection = oItems;
						stListItem item = new stListItem("", (short)num2, 0, "", "", 0, 0L);
						myStListItemCollection.Add(item);
						num2++;
					}
				}
				if (nItems >= oItems.Count)
				{
					return;
				}
				int num5 = oItems.Count - 1;
				int num6 = nItems - 1;
				num2 = num5;
				while (true)
				{
					int num7 = num2;
					int num4 = num6;
					if (num7 <= num4)
					{
						oItems.RemoveAt(num2);
						num2++;
						continue;
					}
					break;
				}
			}
		}

		public void AddItem(string cTxtShow, int nNroId = 0, string cTxtId = "", string cTxtDescrip = "", int nNroInt = 0, long nNroLong = 0L, decimal nNroDecimal = 0m, float nNroSingle = 0f, string cTxt1 = "", string cTxt2 = "", string cTxt3 = "", int nInt1 = 0, int nInt2 = 0, int nInt3 = 0)
		{
			MyStListItemCollection myStListItemCollection = oItems;
			stListItem item = new stListItem(cTxtShow, checked((short)oItems.Count), nNroId, cTxtId, cTxtDescrip, nNroInt, nNroLong, nNroDecimal, nNroSingle, cTxt1, cTxt2, cTxt3, nInt1, nInt2, nInt3);
			myStListItemCollection.Add(item);
		}

		private void LeerDatosTabla(DataTable Tabla)
		{
			if (Tabla == null || Tabla.Rows.Count < 1)
			{
				return;
			}
			clsRs clsRs = new clsRs();
			checked
			{
				try
				{
					clsRs.OpenRs(Tabla);
					oItems.Clear();
					if (clsRs.Count <= 0)
					{
						nOpciones = -1;
						return;
					}
					nOpciones = clsRs.Count;
					clsRs.GoFirst();
					int num = nOpciones;
					int num2 = 1;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 <= num4)
						{
							stListItem item = new stListItem("", (short)oItems.Count, 0, "", "", 0, 0L);
							if (_ColTextShow.Length > 0)
							{
								item.TextShow = Conversions.ToString(clsRs.CurrentRow[_ColTextShow]);
							}
							else
							{
								item.TextShow = Conversions.ToString(clsRs.CurrentRow[0]);
							}
							if (_ColTextId.Length > 0)
							{
								item.TextId = Conversions.ToString(clsRs.CurrentRow[_ColTextId]);
							}
							if (_ColDescrip.Length > 0)
							{
								item.TextDescrip = Conversions.ToString(clsRs.CurrentRow[_ColDescrip]);
							}
							if (_ColIntId.Length > 0)
							{
								item.NroIntId = Conversions.ToInteger(clsRs.CurrentRow[_ColIntId]);
							}
							if (_ColInt.Length > 0)
							{
								item.NroInt = Conversions.ToInteger(clsRs.CurrentRow[_ColInt]);
							}
							if (_ColLong.Length > 0)
							{
								item.NroLong = Conversions.ToLong(clsRs.CurrentRow[_ColLong]);
							}
							if (_ColDecimal.Length > 0)
							{
								item.NroDecimal = Conversions.ToDecimal(clsRs.CurrentRow[_ColDecimal]);
							}
							if (_ColSingle.Length > 0)
							{
								item.NroSingle = Conversions.ToSingle(clsRs.CurrentRow[_ColSingle]);
							}
							if (_ColInt1.Length > 0)
							{
								item.Int1 = Conversions.ToInteger(clsRs.CurrentRow[_ColInt1]);
							}
							if (_ColInt2.Length > 0)
							{
								item.Int2 = Conversions.ToInteger(clsRs.CurrentRow[_ColInt2]);
							}
							if (_ColInt3.Length > 0)
							{
								item.Int3 = Conversions.ToInteger(clsRs.CurrentRow[_ColInt3]);
							}
							if (_ColText1.Length > 0)
							{
								item.Text1 = Conversions.ToString(clsRs.CurrentRow[_ColText1]);
							}
							if (_ColText2.Length > 0)
							{
								item.Text2 = Conversions.ToString(clsRs.CurrentRow[_ColText2]);
							}
							if (_ColText3.Length > 0)
							{
								item.Text3 = Conversions.ToString(clsRs.CurrentRow[_ColText3]);
							}
							oItems.Add(item);
							clsRs.GoNext();
							num2++;
							continue;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		public void GetData(DataTable tabla)
		{
			LeerDatosTabla(tabla);
		}

		public void GetData()
		{
			LeerDatos();
		}

		public void GetData(SqlConnection oConn)
		{
			oCn = oConn;
			LeerDatos();
		}

		private void LeerDatos()
		{
			string text = "";
			clsRs clsRs = new clsRs();
			if (oCn == null || oCn.State == ConnectionState.Closed || ((Operators.CompareString(_Tabla, "", TextCompare: false) == 0) & (Operators.CompareString(_Select, "", TextCompare: false) == 0)) || ((_Tabla.Trim().Length == 0 && _Select.Trim().Length == 0) ? true : false))
			{
				return;
			}
			if (_Select.Trim().Length > 0)
			{
				text = _Select.Trim();
			}
			else
			{
				if (_cWhere.Length > 0)
				{
					text = " WHERE " + _cWhere;
				}
				text = "SELECT * FROM " + _Tabla + text;
				if (_OrderBy.Length > 0)
				{
					text = text + " ORDER BY " + _OrderBy;
				}
			}
			clsRs.SqlSelect = text;
			checked
			{
				try
				{
					clsRs.SysCn = oCn;
					clsRs.OpenRs();
					oItems.Clear();
					if (clsRs.Count <= 0)
					{
						nOpciones = -1;
						return;
					}
					nOpciones = clsRs.Count;
					clsRs.GoFirst();
					int num = nOpciones;
					int num2 = 1;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 <= num4)
						{
							stListItem item = new stListItem("", (short)oItems.Count, 0, "", "", 0, 0L);
							if (_ColTextShow.Length > 0)
							{
								item.TextShow = Conversions.ToString(clsRs.CurrentRow[_ColTextShow]);
							}
							else
							{
								item.TextShow = Conversions.ToString(clsRs.CurrentRow[0]);
							}
							if (_ColTextId.Length > 0)
							{
								item.TextId = Conversions.ToString(clsRs.CurrentRow[_ColTextId]);
							}
							if (_ColDescrip.Length > 0)
							{
								item.TextDescrip = Conversions.ToString(clsRs.CurrentRow[_ColDescrip]);
							}
							if (_ColIntId.Length > 0)
							{
								item.NroIntId = Conversions.ToInteger(clsRs.CurrentRow[_ColIntId]);
							}
							if (_ColInt.Length > 0)
							{
								item.NroInt = Conversions.ToInteger(clsRs.CurrentRow[_ColInt]);
							}
							if (_ColLong.Length > 0)
							{
								item.NroLong = Conversions.ToLong(clsRs.CurrentRow[_ColLong]);
							}
							if (_ColDecimal.Length > 0)
							{
								item.NroDecimal = Conversions.ToDecimal(clsRs.CurrentRow[_ColDecimal]);
							}
							if (_ColSingle.Length > 0)
							{
								item.NroSingle = Conversions.ToSingle(clsRs.CurrentRow[_ColSingle]);
							}
							if (_ColInt1.Length > 0)
							{
								item.Int1 = Conversions.ToInteger(clsRs.CurrentRow[_ColInt1]);
							}
							if (_ColInt2.Length > 0)
							{
								item.Int2 = Conversions.ToInteger(clsRs.CurrentRow[_ColInt2]);
							}
							if (_ColInt3.Length > 0)
							{
								item.Int3 = Conversions.ToInteger(clsRs.CurrentRow[_ColInt3]);
							}
							if (_ColText1.Length > 0)
							{
								item.Text1 = Conversions.ToString(clsRs.CurrentRow[_ColText1]);
							}
							if (_ColText2.Length > 0)
							{
								item.Text2 = Conversions.ToString(clsRs.CurrentRow[_ColText2]);
							}
							if (_ColText3.Length > 0)
							{
								item.Text3 = Conversions.ToString(clsRs.CurrentRow[_ColText3]);
							}
							oItems.Add(item);
							clsRs.GoNext();
							num2++;
							continue;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		~clsDbArray()
		{
			oCn = null;
		}

		private void oListItems_MyStListItemCollectionChanged(object sender, stListItemChangedEventArgs e)
		{
			MyDBArrayListChanged?.Invoke(this, e);
		}
	}

	public struct stListItem
	{
		private string cTextShow;

		private string cTextId;

		private string cTextDescrip;

		private int nNroIntId;

		private int nNroInt;

		private long nNroLong;

		private decimal nNroDecimal;

		private float nNroSingle;

		private short nOrden;

		private string cText1;

		private string cText2;

		private string cText3;

		private int nInt1;

		private int nInt2;

		private int nInt3;

		public string Text1
		{
			get
			{
				return cText1;
			}
			set
			{
				cText1 = value.Trim();
			}
		}

		public string Text2
		{
			get
			{
				return cText2;
			}
			set
			{
				cText2 = value.Trim();
			}
		}

		public string Text3
		{
			get
			{
				return cText3;
			}
			set
			{
				cText3 = value.Trim();
			}
		}

		public int Int1
		{
			get
			{
				return nInt1;
			}
			set
			{
				nInt1 = value;
			}
		}

		public int Int2
		{
			get
			{
				return nInt2;
			}
			set
			{
				nInt2 = value;
			}
		}

		public int Int3
		{
			get
			{
				return nInt3;
			}
			set
			{
				nInt3 = value;
			}
		}

		public string TextShow
		{
			get
			{
				return cTextShow;
			}
			set
			{
				cTextShow = value.Trim();
			}
		}

		public string TextId
		{
			get
			{
				return cTextId;
			}
			set
			{
				cTextId = value.Trim();
			}
		}

		public string TextDescrip
		{
			get
			{
				return cTextDescrip;
			}
			set
			{
				cTextDescrip = value.Trim();
			}
		}

		public int NroIntId
		{
			get
			{
				return nNroIntId;
			}
			set
			{
				nNroIntId = value;
			}
		}

		public int NroInt
		{
			get
			{
				return nNroInt;
			}
			set
			{
				nNroInt = value;
			}
		}

		public long NroLong
		{
			get
			{
				return nNroLong;
			}
			set
			{
				nNroLong = value;
			}
		}

		public decimal NroDecimal
		{
			get
			{
				return nNroDecimal;
			}
			set
			{
				nNroDecimal = value;
			}
		}

		public float NroSingle
		{
			get
			{
				return nNroSingle;
			}
			set
			{
				nNroSingle = value;
			}
		}

		public short Orden
		{
			get
			{
				return nOrden;
			}
			set
			{
				if (value >= 0)
				{
					nOrden = value;
				}
			}
		}

		public void Clear()
		{
			cTextShow = "";
			cTextId = "";
			cTextDescrip = "";
			nNroIntId = 0;
			nNroInt = 0;
			nNroLong = 0L;
			nNroDecimal = default(decimal);
			nNroSingle = 0f;
			cText1 = "";
			cText2 = "";
			cText3 = "";
			nInt1 = 0;
			nInt2 = 0;
			nInt3 = 0;
		}

		public stListItem(string cStrShow, short nOrden, int nId = 0, string cStrId = "", string cDescrip = "", int nInt = 0, long nLong = 0L, decimal nDecimal = 0m, float nSingle = 0f, string cTex1 = "", string cTex2 = "", string cTex3 = "", int nInt1 = 0, int nInt2 = 0, int nInt3 = 0)
		{
			this = default(stListItem);
			cTextShow = cStrShow;
			cTextId = cStrId;
			cTextDescrip = cDescrip;
			nNroIntId = nId;
			nNroInt = nInt;
			nNroLong = nLong;
			nNroDecimal = nDecimal;
			nNroSingle = nSingle;
			nOrden = nOrden;
			cText1 = cTex1;
			cText2 = cTex2;
			cText3 = cTex3;
			nInt1 = nInt1;
			nInt2 = nInt2;
			nInt3 = nInt3;
		}

		public override string ToString()
		{
			if (Operators.CompareString(cTextShow, "", TextCompare: false) != 0)
			{
				return cTextShow;
			}
			if (Operators.CompareString(cTextId, "", TextCompare: false) != 0)
			{
				return cTextId;
			}
			if (Operators.CompareString(cTextDescrip, "", TextCompare: false) != 0)
			{
				return cTextDescrip;
			}
			if (nNroInt != 0)
			{
				return nNroInt.ToString();
			}
			if (nNroIntId != 0)
			{
				return nNroIntId.ToString();
			}
			if (nNroLong != 0)
			{
				return nNroLong.ToString();
			}
			if (decimal.Compare(nNroDecimal, 0m) != 0)
			{
				return nNroDecimal.ToString();
			}
			if (nNroSingle != 0f)
			{
				return nNroSingle.ToString();
			}
			if (Operators.CompareString(cText1, "", TextCompare: false) != 0)
			{
				return cText1;
			}
			if (Operators.CompareString(cText2, "", TextCompare: false) != 0)
			{
				return cText2;
			}
			if (Operators.CompareString(cText3, "", TextCompare: false) != 0)
			{
				return cText3;
			}
			if (nInt1 != 0)
			{
				return nInt1.ToString();
			}
			if (nInt2 != 0)
			{
				return nInt2.ToString();
			}
			if (nInt3 != 0)
			{
				return nInt3.ToString();
			}
			return "";
		}
	}

	public class clsRs
	{
		public delegate void myRsPositionChangedEventHandler();

		public delegate void myRsOpenInitEventHandler(string cSql, ref bool Cancel);

		public delegate void myRsOpenCompletedEventHandler(string cSqlExecuted);

		public delegate void myRsExecSelectInitEventHandler(string cSql, ref bool Cancel);

		public delegate void myRsExecInsertInitEventHandler(string cSql, ref bool Cancel);

		public delegate void myRsExecUpdateInitEventHandler(string cSql, ref bool Cancel);

		public delegate void myRsExecDeleteInitEventHandler(string cSql, ref bool Cancel);

		public delegate void myRsExecSelectCompletedEventHandler();

		public delegate void myRsExecInsertCompletedEventHandler();

		public delegate void myRsExecUpdateCompletedEventHandler();

		public delegate void myRsExecDeleteCompletedEventHandler();

		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private SqlConnection oSysCn;

		[AccessedThroughProperty("oBs")]
		private BindingSource _oBs;

		private SqlDataAdapter oDa;

		private DataSet oDs;

		private SqlCommand oCmd;

		private DataTable oDt;

		private string cSqlSelect;

		private string cSqlInsert;

		private string cSqlUpdate;

		private string cSqlDelete;

		private string cSqlParameters;

		private bool bCanAdd;

		private bool bEditSqlOnly;

		private bool bEnEdicion;

		private bool bEnAdd;

		private string cErrMsg;

		private bool bIsError;

		private BindingSource oBs
		{
			[DebuggerNonUserCode]
			get
			{
				return _oBs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler value2 = oBs_PositionChanged;
				if (_oBs != null)
				{
					_oBs.PositionChanged -= value2;
				}
				_oBs = value;
				if (_oBs != null)
				{
					_oBs.PositionChanged += value2;
				}
			}
		}

		public bool IsError => bIsError;

		public string ErrorMessage => cErrMsg;

		public SqlConnection SysCn
		{
			get
			{
				return oSysCn;
			}
			set
			{
				oSysCn = value;
			}
		}

		public bool EditSqlOnly
		{
			get
			{
				return bEditSqlOnly;
			}
			set
			{
				bEditSqlOnly = value;
			}
		}

		public bool CanEdit
		{
			get
			{
				bool result;
				try
				{
					result = oBs.AllowEdit;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					result = false;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		public bool CanAdd
		{
			get
			{
				return bCanAdd;
			}
			set
			{
				bCanAdd = value;
				oBs.AllowNew = bCanAdd;
			}
		}

		public bool CanDelete
		{
			get
			{
				bool result;
				try
				{
					result = oBs.AllowRemove;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					result = false;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		public string SqlSelect
		{
			get
			{
				return cSqlSelect;
			}
			set
			{
				cSqlSelect = value.Trim();
			}
		}

		public string SqlInsert
		{
			get
			{
				return cSqlInsert;
			}
			set
			{
				cSqlInsert = value.Trim();
			}
		}

		public string SqlUpdate
		{
			get
			{
				return cSqlUpdate;
			}
			set
			{
				cSqlUpdate = value.Trim();
			}
		}

		public string SqlDelete
		{
			get
			{
				return cSqlDelete;
			}
			set
			{
				cSqlDelete = value.Trim();
			}
		}

		public string SqlParameters
		{
			get
			{
				return cSqlParameters;
			}
			set
			{
				cSqlParameters = value.Trim();
			}
		}

		public DataTable oTable => oDt;

		public int Count => oDt.Rows.Count;

		public int Position => oBs.Position;

		public BindingSource BindingSource => oBs;

		public DataRow CurrentRow
		{
			get
			{
				if (oBs.Position < 0)
				{
					return null;
				}
				return oDt.Rows[oBs.Position];
			}
		}

		[method: DebuggerNonUserCode]
		public event myRsPositionChangedEventHandler myRsPositionChanged;

		[method: DebuggerNonUserCode]
		public event myRsOpenInitEventHandler myRsOpenInit;

		[method: DebuggerNonUserCode]
		public event myRsOpenCompletedEventHandler myRsOpenCompleted;

		[method: DebuggerNonUserCode]
		public event myRsExecSelectInitEventHandler myRsExecSelectInit;

		[method: DebuggerNonUserCode]
		public event myRsExecInsertInitEventHandler myRsExecInsertInit;

		[method: DebuggerNonUserCode]
		public event myRsExecUpdateInitEventHandler myRsExecUpdateInit;

		[method: DebuggerNonUserCode]
		public event myRsExecDeleteInitEventHandler myRsExecDeleteInit;

		[method: DebuggerNonUserCode]
		public event myRsExecSelectCompletedEventHandler myRsExecSelectCompleted;

		[method: DebuggerNonUserCode]
		public event myRsExecInsertCompletedEventHandler myRsExecInsertCompleted;

		[method: DebuggerNonUserCode]
		public event myRsExecUpdateCompletedEventHandler myRsExecUpdateCompleted;

		[method: DebuggerNonUserCode]
		public event myRsExecDeleteCompletedEventHandler myRsExecDeleteCompleted;

		public clsRs()
		{
			lock (__ENCList)
			{
				__ENCList.Add(new WeakReference(this));
			}
			oBs = new BindingSource();
			oDa = new SqlDataAdapter();
			oDs = new DataSet();
			oCmd = new SqlCommand();
			oDt = new DataTable();
			cSqlSelect = "";
			cSqlInsert = "";
			cSqlUpdate = "";
			cSqlDelete = "";
			cSqlParameters = "";
			bCanAdd = false;
			bEditSqlOnly = true;
			bEnEdicion = false;
			bEnAdd = false;
			cErrMsg = "";
			bIsError = false;
		}

		public bool OpenRs(DataTable Tabla, bool bRefresh = false)
		{
			bool result = false;
			int num = -1;
			bIsError = false;
			cErrMsg = "";
			if (Tabla == null)
			{
				return result;
			}
			try
			{
				if (bRefresh)
				{
					num = ((oBs.Count > 0) ? oBs.Position : (-1));
				}
				oDs.Tables.Clear();
				oDs.Tables.Add(Tabla.Copy());
				oBs.DataSource = oDs.Tables[0];
				oDt = oDs.Tables[0];
				result = true;
				if (num >= 0)
				{
					oBs.Position = num;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				bIsError = true;
				cErrMsg = "Error en Tabla\r\nNro = " + Conversions.ToString(Information.Err().Number) + "\r\nDescripcion: " + Information.Err().Description + "\r\nSource: " + Information.Err().Source;
				result = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				oDs.Dispose();
				Tabla.Dispose();
			}
			return result;
		}

		public bool OpenRs(bool bRefresh = false)
		{
			bool result = false;
			bool Cancel = false;
			int num = -1;
			string text = "";
			bIsError = false;
			cErrMsg = "";
			myRsOpenInit?.Invoke(cSqlSelect, ref Cancel);
			if (!Cancel)
			{
				if (cSqlSelect.Length == 0)
				{
					return result;
				}
				try
				{
					if (bRefresh)
					{
						num = ((oBs.Count > 0) ? oBs.Position : (-1));
					}
					text = ReplaceTokens(cSqlSelect, cSqlParameters);
					oCmd.CommandText = text;
					if (oCmd.Connection == null)
					{
						oCmd.Connection = oSysCn;
					}
					if (oSysCn.State != 0 || Operators.CompareString(oSysCn.ConnectionString, "", TextCompare: false) == 0)
					{
					}
					oDa.SelectCommand = oCmd;
					oDs.Tables.Clear();
					oDa.Fill(oDs, "Datos");
					oBs.DataSource = oDs.Tables["Datos"];
					oDt = oDs.Tables["Datos"];
					result = true;
					if (num >= 0)
					{
						oBs.Position = num;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					bIsError = true;
					cErrMsg = "Error en clsRs::OpenRs\r\nNro = " + Conversions.ToString(Information.Err().Number) + "\r\nDescripcion: " + Information.Err().Description + "\r\nSource: " + Information.Err().Source;
					result = false;
					ProjectData.ClearProjectError();
				}
				finally
				{
					oDs.Dispose();
				}
				myRsOpenCompleted?.Invoke(text);
				return result;
			}
			bool result2 = default(bool);
			return result2;
		}

		public SqlDataReader ExecSelect()
		{
			bool Cancel = false;
			myRsExecSelectInit?.Invoke(cSqlInsert, ref Cancel);
			if (Cancel)
			{
				return null;
			}
			bIsError = false;
			cErrMsg = "";
			if (cSqlSelect.Length <= 0)
			{
				return null;
			}
			SqlDataReader result;
			try
			{
				SqlCommand sqlCommand = new SqlCommand(ReplaceTokens(cSqlSelect, cSqlParameters), oSysCn);
				result = sqlCommand.ExecuteReader();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = null;
				bIsError = true;
				cErrMsg = "Error en clsRs::ExecSelect\r\nNro = " + Conversions.ToString(Information.Err().Number) + "\r\nDescripcion: " + Information.Err().Description + "\r\nSource: " + Information.Err().Source;
				ProjectData.ClearProjectError();
			}
			myRsExecSelectCompleted?.Invoke();
			return result;
		}

		public object ExecInsert()
		{
			bool Cancel = false;
			myRsExecInsertInit?.Invoke(cSqlInsert, ref Cancel);
			if (Cancel)
			{
				return -1;
			}
			bIsError = false;
			cErrMsg = "";
			if (cSqlInsert.Length <= 0)
			{
				return -1;
			}
			object result;
			try
			{
				SqlCommand sqlCommand = new SqlCommand(ReplaceTokens(cSqlInsert, cSqlParameters), oSysCn);
				result = RuntimeHelpers.GetObjectValue(sqlCommand.ExecuteScalar());
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = null;
				bIsError = true;
				cErrMsg = "Error en clsRs::ExecInsert\r\nNro = " + Conversions.ToString(Information.Err().Number) + "\r\nDescripcion: " + Information.Err().Description + "\r\nSource: " + Information.Err().Source;
				ProjectData.ClearProjectError();
			}
			myRsExecInsertCompleted?.Invoke();
			return result;
		}

		public object ExecUpdate()
		{
			bool Cancel = false;
			myRsExecUpdateInit?.Invoke(cSqlUpdate, ref Cancel);
			if (Cancel)
			{
				return -1;
			}
			bIsError = false;
			cErrMsg = "";
			if (cSqlUpdate.Length <= 0)
			{
				return -1;
			}
			object result;
			try
			{
				SqlCommand sqlCommand = new SqlCommand(ReplaceTokens(cSqlUpdate, cSqlParameters), oSysCn);
				result = RuntimeHelpers.GetObjectValue(sqlCommand.ExecuteScalar());
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = null;
				bIsError = true;
				cErrMsg = "Error en clsRs::ExecUpdate\r\nNro = " + Conversions.ToString(Information.Err().Number) + "\r\nDescripcion: " + Information.Err().Description + "\r\nSource: " + Information.Err().Source;
				ProjectData.ClearProjectError();
			}
			myRsExecUpdateCompleted?.Invoke();
			return result;
		}

		public int ExecDelete()
		{
			bool Cancel = false;
			myRsExecDeleteInit?.Invoke(cSqlDelete, ref Cancel);
			if (Cancel)
			{
				return -1;
			}
			bIsError = false;
			cErrMsg = "";
			if (cSqlDelete.Length <= 0)
			{
				return -1;
			}
			object value;
			try
			{
				SqlCommand sqlCommand = new SqlCommand(ReplaceTokens(cSqlDelete, cSqlParameters), oSysCn);
				value = sqlCommand.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				value = null;
				bIsError = true;
				cErrMsg = "Error en clsRs::ExecDelete\r\nNro = " + Conversions.ToString(Information.Err().Number) + "\r\nDescripcion: " + Information.Err().Description + "\r\nSource: " + Information.Err().Source;
				ProjectData.ClearProjectError();
			}
			myRsExecDeleteCompleted?.Invoke();
			return Conversions.ToInteger(value);
		}

		public void ReOpen()
		{
			OpenRs(bRefresh: true);
		}

		public void Refresh()
		{
			oBs.ResetBindings(metadataChanged: false);
		}

		public bool Agregar()
		{
			bool result = false;
			if (bEditSqlOnly | (cSqlInsert.Length > 0))
			{
				bEnAdd = true;
				return true;
			}
			try
			{
				if (Operators.ConditionalCompareObjectEqual(oBs.AddNew(), true, TextCompare: false))
				{
					oBs.AddNew();
					bEnAdd = true;
					result = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public bool Editar()
		{
			bool result = false;
			if (bEditSqlOnly | (cSqlUpdate.Length > 0))
			{
				bEnEdicion = true;
				return true;
			}
			try
			{
				if (Operators.ConditionalCompareObjectEqual(oBs.AddNew(), true, TextCompare: false))
				{
					oBs.AddNew();
					bEnEdicion = true;
					result = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public bool Cancelar()
		{
			bool result = false;
			if (bEditSqlOnly | (cSqlInsert.Length > 0) | (cSqlUpdate.Length > 0))
			{
				bEnAdd = false;
				bEnEdicion = false;
				return true;
			}
			if (bEnEdicion | bEnAdd)
			{
				try
				{
					oBs.CancelEdit();
					result = true;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					result = false;
					ProjectData.ClearProjectError();
				}
				finally
				{
					bEnEdicion = false;
					bEnAdd = false;
				}
			}
			return result;
		}

		public bool Grabar()
		{
			bool result = false;
			if (bEnEdicion | bEnAdd)
			{
				if (bEditSqlOnly | (bEnEdicion & (cSqlUpdate.Length > 0)))
				{
					if (cSqlUpdate.Length <= 0)
					{
						return false;
					}
					ExecUpdate();
					OpenRs(bRefresh: true);
					bEnEdicion = false;
					bEnAdd = false;
					return true;
				}
				if (bEditSqlOnly | (bEnAdd & (cSqlInsert.Length > 0)))
				{
					ExecInsert();
					OpenRs(bRefresh: true);
					bEnEdicion = false;
					bEnAdd = false;
					return true;
				}
				try
				{
					oBs.EndEdit();
					result = true;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					result = false;
					ProjectData.ClearProjectError();
				}
				finally
				{
					bEnEdicion = false;
					bEnAdd = false;
				}
			}
			return result;
		}

		public bool Eliminar()
		{
			bool flag = false;
			bool result = default(bool);
			if (bEditSqlOnly | (cSqlDelete.Length > 0))
			{
				ExecDelete();
				OpenRs(bRefresh: true);
				bEnEdicion = false;
				bEnAdd = false;
				result = true;
			}
			else
			{
				try
				{
					if (oBs.AllowRemove)
					{
						oBs.RemoveCurrent();
						result = true;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					result = false;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		public int GoNext()
		{
			int result = default(int);
			try
			{
				if (checked(oBs.Position + 1) < oBs.Count)
				{
					oBs.MoveNext();
					result = oBs.Position;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = -1;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public int GoBack()
		{
			int result = default(int);
			try
			{
				if (oBs.Position > 0)
				{
					oBs.MovePrevious();
					result = oBs.Position;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = -1;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public int GoLast()
		{
			int result;
			try
			{
				oBs.MoveLast();
				result = oBs.Position;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = -1;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public int GoFirst()
		{
			int result;
			try
			{
				oBs.MoveFirst();
				result = oBs.Position;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = -1;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		private void oBs_PositionChanged(object sender, EventArgs e)
		{
			myRsPositionChanged?.Invoke();
		}

		private string ReplaceTokens(string cReplaced, string cParam, string cSep = ",")
		{
			string text = "";
			int num = 0;
			int num2 = 1;
			if (cParam.Length <= 0)
			{
				return cReplaced;
			}
			ClsStrToken clsStrToken = new ClsStrToken(cParam, cSep);
			checked
			{
				while (num2 > 0)
				{
					num++;
					num2 = Strings.InStr(1, cReplaced, "{?}");
					if (num2 > 0)
					{
						text += Strings.Mid(cReplaced, 1, num2 - 1);
						text += clsStrToken.TokenIndex(num);
						cReplaced = Strings.Mid(cReplaced, num2 + 3);
					}
					else
					{
						text += cReplaced;
					}
				}
				return text;
			}
		}
	}

	public class MyStListItemCollection : Collection<stListItem>
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		[method: DebuggerNonUserCode]
		public event EventHandler<stListItemChangedEventArgs> MyStListItemCollectionChanged;

		[DebuggerNonUserCode]
		public MyStListItemCollection()
		{
			lock (__ENCList)
			{
				__ENCList.Add(new WeakReference(this));
			}
		}

		public void Add(string cString)
		{
			int count = base.Items.Count;
			stListItem newItem = new stListItem(cString, checked((short)base.Items.Count), 0, "", "", 0, 0L);
			InsertItem(count, newItem);
		}

		protected override void InsertItem(int Index, stListItem NewItem)
		{
			base.InsertItem(Index, NewItem);
			stListItem oItemBy = default(stListItem);
			MyStListItemCollectionChanged?.Invoke(this, new stListItemChangedEventArgs(enumStListItemChangedType.Added, NewItem, oItemBy));
		}

		protected override void SetItem(int Index, stListItem NewItem)
		{
			stListItem oItem = Items[Index];
			base.SetItem(Index, NewItem);
			MyStListItemCollectionChanged?.Invoke(this, new stListItemChangedEventArgs(enumStListItemChangedType.Replaced, oItem, NewItem));
		}

		protected override void RemoveItem(int Index)
		{
			stListItem oItem = Items[Index];
			base.RemoveItem(Index);
			stListItem oItemBy = default(stListItem);
			MyStListItemCollectionChanged?.Invoke(this, new stListItemChangedEventArgs(enumStListItemChangedType.Removed, oItem, oItemBy));
		}

		protected override void ClearItems()
		{
			base.ClearItems();
			stListItem stListItem = default(stListItem);
			MyStListItemCollectionChanged?.Invoke(this, new stListItemChangedEventArgs(enumStListItemChangedType.Cleared, stListItem, stListItem));
		}
	}

	public class stListItemChangedEventArgs : EventArgs
	{
		public readonly enumStListItemChangedType ChangedType;

		public readonly stListItem oItemChanged;

		public readonly stListItem oItemReplacedBy;

		public stListItemChangedEventArgs(enumStListItemChangedType nChangedType, stListItem oItem, stListItem oItemBy)
		{
			ChangedType = nChangedType;
			oItemChanged = oItem;
			oItemReplacedBy = oItemReplacedBy;
		}
	}

	[DebuggerNonUserCode]
	public Clases()
	{
	}
}
