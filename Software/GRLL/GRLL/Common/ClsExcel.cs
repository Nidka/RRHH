using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using GRLL.Common.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

public class ClsExcel
{
	[DebuggerNonUserCode]
	public ClsExcel()
	{
	}

	public void ExportaExcel(DataTable DT1, string _TituloExcel, string _SubTituloExcel, bool _AnchoAutomat, string _UsuarioExcel, bool _VerFechaExcel)
	{
		object oExcel = null;
		string TempFileName = "";
		checked
		{
			try
			{
				TempFileName = "Reportes" + Strings.Format(DateAndTime.Now, "ddMMyy") + Conversions.ToString(DateAndTime.Now.Hour) + Conversions.ToString(DateAndTime.Now.Minute) + Conversions.ToString(DateAndTime.Now.Second) + Conversions.ToString(DateAndTime.Now.Millisecond) + ".xls";
				TempFileName = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\" + TempFileName;
				FileStream fs = new FileStream(TempFileName, FileMode.Create, FileAccess.Write);
				BinaryWriter fsR = new BinaryWriter(fs);
				fsR.Write(Resources.ReportesTablas, 0, Resources.ReportesTablas.Length);
				fsR.Close();
				fs.Close();
				oExcel = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application"));
				object instance = oExcel;
				NewLateBinding.LateSet(instance, null, "Visible", new object[1] { false }, null, null);
				object instance2 = NewLateBinding.LateGet(instance, null, "Workbooks", new object[0], null, null, null);
				object[] array = new object[1] { TempFileName };
				object[] arguments = array;
				bool[] array2 = new bool[1] { true };
				object obj = NewLateBinding.LateGet(instance2, null, "Open", arguments, null, null, array2);
				if (array2[0])
				{
					TempFileName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				object oBook = RuntimeHelpers.GetObjectValue(obj);
				object oSheet = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(oBook, null, "ActiveSheet", new object[0], null, null, null));
				NewLateBinding.LateCall(NewLateBinding.LateGet(oBook, null, "Sheets", new object[1] { "Hoja1" }, null, null, null), null, "Select", new object[0], null, null, null, IgnoreReturn: true);
				oSheet = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(oBook, null, "ActiveSheet", new object[0], null, null, null));
				NewLateBinding.LateSet(oSheet, null, "RANGE", new object[2] { "B2", _TituloExcel }, null, null);
				NewLateBinding.LateSet(oSheet, null, "RANGE", new object[2] { "B4", _SubTituloExcel }, null, null);
				int _AnchoCol = 0;
				if (DT1.Columns.Count < 3)
				{
					_AnchoAutomat = true;
					_AnchoCol = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Columns", new object[1] { 3 }, null, null, null), null, "Width", new object[0], null, null, null));
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Columns", new object[1] { 3 }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
					if (DT1.Columns.Count < 2)
					{
						_AnchoCol = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Columns", new object[1] { 3 }, null, null, null), null, "Width", new object[0], null, null, null));
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Columns", new object[1] { 3 }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				else if (DT1.Columns.Count > 3)
				{
					_AnchoAutomat = true;
					int num = DT1.Columns.Count - 1;
					for (int I = 2; I <= num; I++)
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Columns", new object[1] { 4 }, null, null, null), null, "EntireColumn", new object[0], null, null, null), null, "Insert", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				if (DT1.Rows.Count < 2)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Rows", new object[1] { 7 }, null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Delete", new object[0], null, null, null, IgnoreReturn: true);
				}
				else if (DT1.Rows.Count > 2)
				{
					int num2 = DT1.Rows.Count - 1;
					for (int i = 2; i <= num2; i++)
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(oSheet, null, "Rows", new object[1] { 8 }, null, null, null), null, "EntireRow", new object[0], null, null, null), null, "Insert", new object[0], null, null, null, IgnoreReturn: true);
					}
				}
				if (_UsuarioExcel.Trim().Length > 0)
				{
					NewLateBinding.LateSet(oSheet, null, "Cells", new object[3]
					{
						3,
						DT1.Columns.Count + 1,
						"Impreso Por : " + _UsuarioExcel
					}, null, null);
				}
				if (_VerFechaExcel)
				{
					NewLateBinding.LateSet(oSheet, null, "Cells", new object[3]
					{
						5,
						DT1.Columns.Count + 1,
						"Impreso el : " + Conversions.ToString(DateTime.Now)
					}, null, null);
				}
				int _FILA = 7;
				int _COL = 2;
				int num3 = DT1.Rows.Count - 1;
				for (int j = 0; j <= num3; j++)
				{
					int num4 = DT1.Columns.Count - 1;
					for (int II = 0; II <= num4; II++)
					{
						NewLateBinding.LateSet(oSheet, null, "Cells", new object[3]
						{
							_FILA + j,
							_COL + II,
							RuntimeHelpers.GetObjectValue(DT1.Rows[j][II])
						}, null, null);
					}
				}
				int num5 = DT1.Columns.Count - 1;
				for (int k = 0; k <= num5; k++)
				{
					NewLateBinding.LateSet(oSheet, null, "Cells", new object[3]
					{
						6,
						_COL + k,
						DT1.Columns[k].ColumnName
					}, null, null);
				}
				object instance3 = oSheet;
				object[] array3 = new object[2];
				object[] array4 = array3;
				object obj2 = oSheet;
				object instance4 = obj2;
				array = new object[2];
				object[] array5 = array;
				int num6 = 2;
				array5[0] = num6;
				object[] array6 = array;
				int num7 = 2;
				array6[1] = num7;
				array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance4, null, "Cells", array, null, null, null));
				object[] array7 = array3;
				object obj3 = oSheet;
				object instance5 = obj3;
				object[] array8 = new object[2];
				object[] array9 = array8;
				int num8 = 2;
				array9[0] = num8;
				object[] array10 = array8;
				int num9 = DT1.Columns.Count + 1;
				array10[1] = num9;
				array7[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance5, null, "Cells", array8, null, null, null));
				object[] array11 = array3;
				object[] arguments2 = array11;
				array2 = new bool[2] { true, true };
				object instance6 = NewLateBinding.LateGet(instance3, null, "Range", arguments2, null, null, array2);
				if (array2[0])
				{
					NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
					{
						num6,
						num7,
						RuntimeHelpers.GetObjectValue(array11[0])
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				if (array2[1])
				{
					NewLateBinding.LateSetComplex(obj3, null, "Cells", new object[3]
					{
						num8,
						num9,
						RuntimeHelpers.GetObjectValue(array11[1])
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				NewLateBinding.LateCall(instance6, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
				object instance7 = oSheet;
				array11 = new object[2];
				object[] array12 = array11;
				obj3 = oSheet;
				object instance8 = obj3;
				object[] array13 = new object[2];
				object[] array14 = array13;
				num9 = 4;
				array14[0] = num9;
				object[] array15 = array13;
				num8 = 2;
				array15[1] = num8;
				array12[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance8, null, "Cells", array13, null, null, null));
				object[] array16 = array11;
				obj2 = oSheet;
				object instance9 = obj2;
				object[] array17 = new object[2];
				object[] array18 = array17;
				num7 = 4;
				array18[0] = num7;
				object[] array19 = array17;
				num6 = DT1.Columns.Count + 1;
				array19[1] = num6;
				array16[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance9, null, "Cells", array17, null, null, null));
				array3 = array11;
				object[] arguments3 = array3;
				array2 = new bool[2] { true, true };
				object instance10 = NewLateBinding.LateGet(instance7, null, "Range", arguments3, null, null, array2);
				if (array2[0])
				{
					NewLateBinding.LateSetComplex(obj3, null, "Cells", new object[3]
					{
						num9,
						num8,
						RuntimeHelpers.GetObjectValue(array3[0])
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				if (array2[1])
				{
					NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
					{
						num7,
						num6,
						RuntimeHelpers.GetObjectValue(array3[1])
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				NewLateBinding.LateCall(instance10, null, "Merge", new object[0], null, null, null, IgnoreReturn: true);
				if (_AnchoAutomat)
				{
					object instance11 = oSheet;
					array11 = new object[2];
					object[] array20 = array11;
					obj3 = oSheet;
					object instance12 = obj3;
					array13 = new object[2];
					object[] array21 = array13;
					num9 = 4;
					array21[0] = num9;
					object[] array22 = array13;
					num8 = 2;
					array22[1] = num8;
					array20[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance12, null, "Cells", array13, null, null, null));
					object[] array23 = array11;
					obj2 = oSheet;
					object instance13 = obj2;
					array17 = new object[2];
					object[] array24 = array17;
					num7 = 4;
					array24[0] = num7;
					object[] array25 = array17;
					num6 = DT1.Columns.Count + 1;
					array25[1] = num6;
					array23[1] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance13, null, "Cells", array17, null, null, null));
					array3 = array11;
					object[] arguments4 = array3;
					array2 = new bool[2] { true, true };
					object instance14 = NewLateBinding.LateGet(instance11, null, "Range", arguments4, null, null, array2);
					if (array2[0])
					{
						NewLateBinding.LateSetComplex(obj3, null, "Cells", new object[3]
						{
							num9,
							num8,
							RuntimeHelpers.GetObjectValue(array3[0])
						}, null, null, OptimisticSet: true, RValueBase: false);
					}
					if (array2[1])
					{
						NewLateBinding.LateSetComplex(obj2, null, "Cells", new object[3]
						{
							num7,
							num6,
							RuntimeHelpers.GetObjectValue(array3[1])
						}, null, null, OptimisticSet: true, RValueBase: false);
					}
					NewLateBinding.LateCall(NewLateBinding.LateGet(instance14, null, "EntireColumn", new object[0], null, null, null), null, "AutoFit", new object[0], null, null, null, IgnoreReturn: true);
				}
				if (DT1.TableName.Trim().Length > 0)
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(oBook, null, "Sheets", new object[1] { "Hoja1" }, null, null, null), null, "Name", new object[1] { DT1.TableName }, null, null, OptimisticSet: false, RValueBase: true);
				}
				if (DT1 != null)
				{
					DT1.Dispose();
					DT1 = null;
				}
				NewLateBinding.LateSet(oExcel, null, "Visible", new object[1] { true }, null, null);
				oBook = null;
				oSheet = null;
				instance = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			finally
			{
				oExcel = null;
			}
		}
	}
}
