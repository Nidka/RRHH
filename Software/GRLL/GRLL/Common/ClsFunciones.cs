using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GRLL.Common;

public class ClsFunciones
{
	[DebuggerNonUserCode]
	public ClsFunciones()
	{
	}

	public static string GetFechasql(DateTime dFecha, bool bInicio = true)
	{
		if (bInicio)
		{
			return Conversions.ToString(DateAndTime.DateSerial(DateAndTime.Year(dFecha), DateAndTime.Month(dFecha), DateAndTime.Day(dFecha))) + " " + Conversions.ToString(DateAndTime.TimeSerial(0, 0, 0));
		}
		return Conversions.ToString(DateAndTime.DateSerial(DateAndTime.Year(dFecha), DateAndTime.Month(dFecha), DateAndTime.Day(dFecha))) + " " + Conversions.ToString(DateAndTime.TimeSerial(23, 59, 59));
	}

	public static void GetFechaMaxMin(ref DateTimePicker dtpIni, string dFechaMin, string dFechaMax)
	{
		string sDate = Conversions.ToString(Interaction.IIf(Information.IsDate(dFechaMin), dFechaMin, "01/01/2000"));
		dtpIni.MinDate = Conversions.ToDate(Conversions.ToString(DateAndTime.DateSerial(DateAndTime.Year(Conversions.ToDate(sDate)), DateAndTime.Month(Conversions.ToDate(sDate)), DateAndTime.Day(Conversions.ToDate(sDate)))) + " " + Conversions.ToString(DateAndTime.TimeSerial(0, 0, 0)));
		sDate = Conversions.ToString(Interaction.IIf(Information.IsDate(dFechaMax), dFechaMax, "31/12/2100"));
		dtpIni.MaxDate = Conversions.ToDate(Conversions.ToString(DateAndTime.DateSerial(DateAndTime.Year(Conversions.ToDate(sDate)), DateAndTime.Month(Conversions.ToDate(sDate)), DateAndTime.Day(Conversions.ToDate(sDate)))) + " " + Conversions.ToString(DateAndTime.TimeSerial(23, 59, 59)));
	}

	public static void GetFechaMaxMin(ref DateTimePicker dtpIni, DateTime dFechaMin, DateTime dFechaMax)
	{
		DateTime _F_Min = Conversions.ToDate(Conversions.ToString(DateAndTime.DateSerial(DateAndTime.Year(dFechaMin), DateAndTime.Month(dFechaMin), DateAndTime.Day(dFechaMin))) + " " + Conversions.ToString(DateAndTime.TimeSerial(0, 0, 0)));
		DateTime _F_Max = Conversions.ToDate(Conversions.ToString(DateAndTime.DateSerial(DateAndTime.Year(dFechaMax), DateAndTime.Month(dFechaMax), DateAndTime.Day(dFechaMax))) + " " + Conversions.ToString(DateAndTime.TimeSerial(23, 59, 59)));
		if (DateTime.Compare(_F_Max, _F_Min) < 0)
		{
			_F_Min = _F_Max;
		}
		dtpIni.MinDate = _F_Min;
		dtpIni.MaxDate = _F_Max;
	}

	public static string GetFecha103(string sFecha)
	{
		if (sFecha.Trim().Length == 10 && Information.IsDate(sFecha))
		{
			return sFecha;
		}
		if (sFecha.Trim().Length > 9 && Information.IsDate(sFecha))
		{
			return sFecha.Substring(0, 10);
		}
		if (sFecha.Trim().Length != 8)
		{
			sFecha = GetFecha112(DateAndTime.Now.Date);
		}
		return sFecha.Substring(6, 2) + "/" + sFecha.Substring(4, 2) + "/" + sFecha.Substring(0, 4);
	}

	public static string GetFecha112(string sFecha)
	{
		return sFecha.Substring(6, 4) + sFecha.Substring(3, 2) + sFecha.Substring(0, 2);
	}

	public static string GetFecha112(DateTime sFecha)
	{
		return Conversions.ToString(sFecha.Year) + Strings.Format(sFecha.Month, "00") + Strings.Format(sFecha.Day, "00");
	}

	public static string GetHoraMinutoSeg(decimal dHora)
	{
		int _Hor = 0;
		int _Min = 0;
		int _Seg = 0;
		decimal _dHora = dHora;
		_Hor = Convert.ToInt32(decimal.Subtract(dHora, decimal.Remainder(dHora, 1m)));
		_dHora = decimal.Multiply(decimal.Remainder(dHora, 1m), 100m);
		string GetHoraMinutoSeg = Conversions.ToString(_Hor);
		checked
		{
			if (decimal.Compare(_dHora, 0m) > 0)
			{
				_Min = (int)unchecked(Convert.ToInt64(_dHora) / 60);
				GetHoraMinutoSeg = Conversions.ToString(_Hor) + "." + Conversions.ToString(_Min) + "'";
				_Seg = Convert.ToInt32(decimal.Subtract(_dHora, new decimal(_Min * 60)));
				if (_Seg > 0)
				{
					GetHoraMinutoSeg = Conversions.ToString(_Hor) + "." + Conversions.ToString(_Min) + "'" + Conversions.ToString(_Seg) + "''";
				}
			}
			return GetHoraMinutoSeg;
		}
	}

	public static void MuestraMsj(SqlException ex)
	{
		if (ex.Number >= 50000)
		{
			Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Mensaje de Error desde el DB");
		}
		else
		{
			Interaction.MsgBox(ex.Message + "\r\n" + Conversions.ToString(ex.LineNumber), MsgBoxStyle.Critical, "Error");
		}
	}

	public static void MuestraMsj(Exception ex)
	{
		Interaction.MsgBox(ex.Message + "\r\n" + ex.TargetSite.Name, MsgBoxStyle.Critical, "Mensaje de Error del Sistema");
	}
}
