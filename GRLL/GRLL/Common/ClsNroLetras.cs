using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

public class ClsNroLetras
{
	[DebuggerNonUserCode]
	public ClsNroLetras()
	{
	}

	public static string ALetras(string numero, string sTipoMoneda = "Nuevos Soles")
	{
		numero = numero.Replace(",", "");
		string flag = "N";
		checked
		{
			string palabras = default(string);
			if (Operators.CompareString(Strings.Mid(numero, 1, 1), "-", TextCompare: false) == 0)
			{
				numero = Strings.Mid(numero, 2, numero.ToString().Length - 1).ToString();
				palabras = "menos ";
			}
			int length = numero.ToString().Length;
			for (int x = 1; x <= length; x++)
			{
				if (Operators.CompareString(Strings.Mid(numero, 1, 1), "0", TextCompare: false) != 0)
				{
					break;
				}
				numero = Strings.Trim(Strings.Mid(numero, 2, numero.ToString().Length).ToString());
				if (Conversions.ToDouble(Strings.Trim(Conversions.ToString(numero.ToString().Length))) == 0.0)
				{
					palabras = "";
				}
			}
			int num = Strings.Len(numero);
			string entero = default(string);
			string dec = default(string);
			for (int y = 1; y <= num; y++)
			{
				if (Operators.CompareString(Strings.Mid(numero, y, 1), ".", TextCompare: false) == 0)
				{
					flag = "S";
				}
				else if (Operators.CompareString(flag, "N", TextCompare: false) == 0)
				{
					entero += Strings.Mid(numero, y, 1);
				}
				else
				{
					dec += Strings.Mid(numero, y, 1);
				}
			}
			if (Strings.Len(dec) == 1)
			{
				dec += "0";
			}
			flag = "N";
			if (Conversion.Val(numero) <= 999999999.0)
			{
				for (int y = Strings.Len(entero); y >= 1; y += -1)
				{
					int num2 = Strings.Len(entero) - (y - 1);
					switch (y)
					{
					case 3:
					case 6:
					case 9:
						switch (Strings.Mid(entero, num2, 1))
						{
						case "1":
							palabras = ((!((Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "0", TextCompare: false) == 0) & (Operators.CompareString(Strings.Mid(entero, num2 + 2, 1), "0", TextCompare: false) == 0))) ? (palabras + "Ciento ") : (palabras + "Cien "));
							break;
						case "2":
							palabras += "Doscientos ";
							break;
						case "3":
							palabras += "Trescientos ";
							break;
						case "4":
							palabras += "Cuatrocientos ";
							break;
						case "5":
							palabras += "Quinientos ";
							break;
						case "6":
							palabras += "Seiscientos ";
							break;
						case "7":
							palabras += "Setecientos ";
							break;
						case "8":
							palabras += "Ochocientos ";
							break;
						case "9":
							palabras += "Novecientos ";
							break;
						}
						break;
					case 2:
					case 5:
					case 8:
						switch (Strings.Mid(entero, num2, 1))
						{
						case "1":
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "0", TextCompare: false) == 0)
							{
								flag = "S";
								palabras += "Diez ";
							}
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "1", TextCompare: false) == 0)
							{
								flag = "S";
								palabras += "Once ";
							}
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "2", TextCompare: false) == 0)
							{
								flag = "S";
								palabras += "Doce ";
							}
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "3", TextCompare: false) == 0)
							{
								flag = "S";
								palabras += "Trece ";
							}
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "4", TextCompare: false) == 0)
							{
								flag = "S";
								palabras += "Catorce ";
							}
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "5", TextCompare: false) == 0)
							{
								flag = "S";
								palabras += "Quince ";
							}
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "5", TextCompare: false) > 0)
							{
								flag = "N";
								palabras += "Dieci";
							}
							break;
						case "2":
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "0", TextCompare: false) == 0)
							{
								palabras += "Veinte ";
								flag = "S";
							}
							else
							{
								palabras += "Veinti";
								flag = "N";
							}
							break;
						case "3":
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "0", TextCompare: false) == 0)
							{
								palabras += "Treinta ";
								flag = "S";
							}
							else
							{
								palabras += "Treinta y ";
								flag = "N";
							}
							break;
						case "4":
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "0", TextCompare: false) == 0)
							{
								palabras += "Cuarenta ";
								flag = "S";
							}
							else
							{
								palabras += "Cuarenta y ";
								flag = "N";
							}
							break;
						case "5":
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "0", TextCompare: false) == 0)
							{
								palabras += "Cincuenta ";
								flag = "S";
							}
							else
							{
								palabras += "Cincuenta y ";
								flag = "N";
							}
							break;
						case "6":
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "0", TextCompare: false) == 0)
							{
								palabras += "Sesenta ";
								flag = "S";
							}
							else
							{
								palabras += "Sesenta y ";
								flag = "N";
							}
							break;
						case "7":
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "0", TextCompare: false) == 0)
							{
								palabras += "Setenta ";
								flag = "S";
							}
							else
							{
								palabras += "Setenta y ";
								flag = "N";
							}
							break;
						case "8":
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "0", TextCompare: false) == 0)
							{
								palabras += "Ochenta ";
								flag = "S";
							}
							else
							{
								palabras += "Ochenta y ";
								flag = "N";
							}
							break;
						case "9":
							if (Operators.CompareString(Strings.Mid(entero, num2 + 1, 1), "0", TextCompare: false) == 0)
							{
								palabras += "Noventa ";
								flag = "S";
							}
							else
							{
								palabras += "Noventa y ";
								flag = "N";
							}
							break;
						}
						break;
					case 1:
					case 4:
					case 7:
						switch (Strings.Mid(entero, num2, 1))
						{
						case "1":
							if (Operators.CompareString(flag, "N", TextCompare: false) == 0)
							{
								palabras = ((y != 1) ? (palabras + "Un ") : (palabras + "Uno "));
							}
							break;
						case "2":
							if (Operators.CompareString(flag, "N", TextCompare: false) == 0)
							{
								palabras += "Dos ";
							}
							break;
						case "3":
							if (Operators.CompareString(flag, "N", TextCompare: false) == 0)
							{
								palabras += "Tres ";
							}
							break;
						case "4":
							if (Operators.CompareString(flag, "N", TextCompare: false) == 0)
							{
								palabras += "Cuatro ";
							}
							break;
						case "5":
							if (Operators.CompareString(flag, "N", TextCompare: false) == 0)
							{
								palabras += "Cinco ";
							}
							break;
						case "6":
							if (Operators.CompareString(flag, "N", TextCompare: false) == 0)
							{
								palabras += "Seis ";
							}
							break;
						case "7":
							if (Operators.CompareString(flag, "N", TextCompare: false) == 0)
							{
								palabras += "Siete ";
							}
							break;
						case "8":
							if (Operators.CompareString(flag, "N", TextCompare: false) == 0)
							{
								palabras += "Ocho ";
							}
							break;
						case "9":
							if (Operators.CompareString(flag, "N", TextCompare: false) == 0)
							{
								palabras += "Nueve ";
							}
							break;
						}
						break;
					}
					if (y == 4 && ((Operators.CompareString(Strings.Mid(entero, 6, 1), "0", TextCompare: false) != 0) | (Operators.CompareString(Strings.Mid(entero, 5, 1), "0", TextCompare: false) != 0) | (Operators.CompareString(Strings.Mid(entero, 4, 1), "0", TextCompare: false) != 0) | ((Operators.CompareString(Strings.Mid(entero, 6, 1), "0", TextCompare: false) == 0) & (Operators.CompareString(Strings.Mid(entero, 5, 1), "0", TextCompare: false) == 0) & (Operators.CompareString(Strings.Mid(entero, 4, 1), "0", TextCompare: false) == 0) & (Strings.Len(entero) <= 6))))
					{
						palabras += "Mil ";
					}
					if (y == 7)
					{
						palabras = ((!((Strings.Len(entero) == 7) & (Operators.CompareString(Strings.Mid(entero, 1, 1), "1", TextCompare: false) == 0))) ? (palabras + "Millones ") : (palabras + "Millón "));
					}
				}
				string ALetras = ((Operators.CompareString(dec, "", TextCompare: false) == 0) ? palabras : (palabras + "Con " + dec));
				return ALetras + "/100 " + sTipoMoneda;
			}
			return "";
		}
	}
}
