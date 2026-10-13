using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Seguridad;

public class Seguridad
{
	[DebuggerNonUserCode]
	public Seguridad()
	{
	}

	public static string EncryptString(string InputString, string SecretKey, CipherMode CyphMode = CipherMode.ECB)
	{
		TripleDESCryptoServiceProvider Des = new TripleDESCryptoServiceProvider();
		byte[] InputbyteArray = Encoding.UTF8.GetBytes(InputString);
		MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
		Des.Key = hashMD5.ComputeHash(Encoding.ASCII.GetBytes(SecretKey));
		Des.Mode = CyphMode;
		MemoryStream ms = new MemoryStream();
		CryptoStream cs = new CryptoStream(ms, Des.CreateEncryptor(), CryptoStreamMode.Write);
		cs.Write(InputbyteArray, 0, InputbyteArray.Length);
		cs.FlushFinalBlock();
		StringBuilder ret = new StringBuilder();
		byte[] b = ms.ToArray();
		ms.Close();
		int num = Information.UBound(b);
		int I = 0;
		while (true)
		{
			int num2 = I;
			int num3 = num;
			if (num2 > num3)
			{
				break;
			}
			ret.AppendFormat("{0:X2}", b[I]);
			I = checked(I + 1);
		}
		return ret.ToString();
	}

	public static string DecryptString(string InputString, string SecretKey, CipherMode CyphMode = CipherMode.ECB)
	{
		if (Operators.CompareString(InputString, string.Empty, TextCompare: false) == 0)
		{
			return "";
		}
		TripleDESCryptoServiceProvider Des = new TripleDESCryptoServiceProvider();
		checked
		{
			byte[] InputbyteArray = new byte[(int)Math.Round((double)InputString.Length / 2.0 - 1.0) + 1];
			MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
			Des.Key = hashMD5.ComputeHash(Encoding.ASCII.GetBytes(SecretKey));
			Des.Mode = CyphMode;
			int num = InputbyteArray.Length - 1;
			int X = 0;
			while (true)
			{
				int num2 = X;
				int num3 = num;
				if (num2 > num3)
				{
					break;
				}
				int IJ = Convert.ToInt32(InputString.Substring(X * 2, 2), 16);
				ByteConverter BT = new ByteConverter();
				InputbyteArray[X] = default(byte);
				InputbyteArray[X] = Conversions.ToByte(BT.ConvertTo(IJ, typeof(byte)));
				X++;
			}
			MemoryStream ms = new MemoryStream();
			CryptoStream cs = new CryptoStream(ms, Des.CreateDecryptor(), CryptoStreamMode.Write);
			cs.Write(InputbyteArray, 0, InputbyteArray.Length);
			cs.FlushFinalBlock();
			StringBuilder ret = new StringBuilder();
			byte[] B = ms.ToArray();
			ms.Close();
			int num4 = Information.UBound(B);
			int I = 0;
			while (true)
			{
				int num5 = I;
				int num3 = num4;
				if (num5 > num3)
				{
					break;
				}
				ret.Append(Strings.Chr(B[I]));
				I++;
			}
			return ret.ToString();
		}
	}
}
