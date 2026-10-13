using System;
using System.ComponentModel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

[StandardModule]
internal static class ModFunciones
{
	[Description("Devuelve un string conteniendo ul número especifico de caracteres desde la parte izquierda del string")]
	public static string Left(this string Value, int Len)
	{
		return Strings.Left(Value, Len);
	}

	[Description("Devuelve un string conteniendo ul número especifico de caracteres desde la parte derecha del string")]
	public static string Right(this string Value, int Len)
	{
		return Strings.Right(Value, Len);
	}

	public static string Date103(this DateTime value)
	{
		return Right("00" + value.Day, 2) + "/" + Right("00" + value.Month, 2) + "/" + value.Year;
	}

	public static string Date112(this DateTime value)
	{
		return value.Year + Right("00" + value.Month, 2) + Right("00" + value.Day, 2);
	}
}
