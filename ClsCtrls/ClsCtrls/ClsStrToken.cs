using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ClsCtrls;

public class ClsStrToken
{
	private string cCadena;

	private string cDelimiter;

	private string[] aStrTokens;

	public string StrCadena
	{
		get
		{
			return cCadena;
		}
		set
		{
			cCadena = value;
			aStrTokens = GetArrStrTokens(cCadena, cDelimiter);
		}
	}

	public string StrDelimiter
	{
		get
		{
			return cDelimiter;
		}
		set
		{
			cDelimiter = value;
			aStrTokens = GetArrStrTokens(cCadena, cDelimiter);
		}
	}

	public string[] TokensArray => aStrTokens;

	public int TokensLen => aStrTokens.GetLength(0);

	public string TokenIndex(int nIndex = 1)
	{
		if (nIndex < 1 || ((nIndex > aStrTokens.GetLength(0)) ? true : false))
		{
			return "";
		}
		return aStrTokens[checked(nIndex - 1)];
	}

	public string ReplaceTokens(string cCadena, string cParam, string cDelimCadena, string cDelimParam)
	{
		string text = "";
		int num = 0;
		if (cCadena.Length == 0 || cDelimCadena.Length == 0)
		{
			return cCadena;
		}
		if (!cCadena.Contains(cDelimCadena))
		{
			return cCadena;
		}
		string[] arrStrTokens = GetArrStrTokens(cCadena, cDelimCadena);
		if (arrStrTokens.GetLength(0) <= 1)
		{
			return cCadena;
		}
		if (cParam.Length == 0)
		{
			return Strings.Replace(cCadena, cDelimCadena, "");
		}
		string[] arrStrTokens2 = GetArrStrTokens(cParam, cDelimParam);
		if (arrStrTokens2.GetLength(0) <= 0)
		{
			return Strings.Replace(cCadena, cDelimCadena, "");
		}
		checked
		{
			int num2 = arrStrTokens.GetLength(0) - 1;
			num = 0;
			while (true)
			{
				int num3 = num;
				int num4 = num2;
				if (num3 > num4)
				{
					break;
				}
				text += arrStrTokens[num];
				if (num <= arrStrTokens2.GetLength(0) - 1)
				{
					text += arrStrTokens2[num];
				}
				num++;
			}
			return text;
		}
	}

	public string ReplaceTokens(string cCadena, string cDelimCadena = "{?}")
	{
		string text = "";
		int num = 0;
		if (cCadena.Length == 0 || cDelimCadena.Length == 0)
		{
			return cCadena;
		}
		if (aStrTokens.GetLength(0) <= 0 || cDelimiter.Length == 0)
		{
			return Strings.Replace(cCadena, cDelimCadena, "");
		}
		string[] arrStrTokens = GetArrStrTokens(cCadena, cDelimCadena);
		checked
		{
			int num2 = arrStrTokens.GetLength(0) - 1;
			num = 0;
			while (true)
			{
				int num3 = num;
				int num4 = num2;
				if (num3 > num4)
				{
					break;
				}
				text = text + arrStrTokens[num] + TokenIndex(num);
				num++;
			}
			return text;
		}
	}

	public ClsStrToken(string cStrCadena = "", string cStrToken = ",")
	{
		cCadena = "";
		cDelimiter = ",";
		cCadena = cStrCadena;
		cDelimiter = cStrToken;
		aStrTokens = GetArrStrTokens(cCadena, cDelimiter);
	}

	public static string GetTokenIndex(string cCadena, int nIndex, string cDelimCadena = ",")
	{
		string result = "";
		if (cCadena.Length == 0 || nIndex < 1)
		{
			return result;
		}
		if (cDelimCadena.Length == 0)
		{
			return cCadena;
		}
		string[] arrStrTokens = GetArrStrTokens(cCadena, cDelimCadena);
		return (nIndex <= arrStrTokens.GetLength(0)) ? arrStrTokens[checked(nIndex - 1)] : "";
	}

	public static string[] GetArrStrTokens(string cCadena, string cDelimiter = ",")
	{
		int num = 1;
		int num2 = 0;
		int num3 = 0;
		string[] array = new string[1];
		array[0] = cCadena;
		if (cCadena.Length == 0)
		{
			return array;
		}
		if (cDelimiter.Length == 0)
		{
			return array;
		}
		checked
		{
			while (num >= 0)
			{
				array = (string[])Utils.CopyArray(array, new string[num3 + 1]);
				num = cCadena.IndexOf(cDelimiter, num2);
				if (num >= 0)
				{
					array[num3] = cCadena.Substring(num2, num - num2);
					num2 = num + cDelimiter.Length;
				}
				else
				{
					array[num3] = cCadena.Substring(num2);
				}
				num3++;
			}
			return array;
		}
	}

	public override string ToString()
	{
		string text = "";
		int upperBound = aStrTokens.GetUpperBound(0);
		int num = 0;
		while (true)
		{
			int num2 = num;
			int num3 = upperBound;
			if (num2 > num3)
			{
				break;
			}
			if (num > 0)
			{
				text += "\r\n";
			}
			text += aStrTokens[num];
			num = checked(num + 1);
		}
		return text;
	}
}
