using System;
using GRLL.Common.Conversiones.Rutinas;

namespace GRLL.Common;

public class RangoFecha
{
	private DateTime _Desde;

	private DateTime _Hasta;

	public DateTime Desde
	{
		get
		{
			return _Desde.FechaCorta();
		}
		set
		{
			_Desde = value;
		}
	}

	public DateTime Hasta
	{
		get
		{
			return _Hasta.FechaCorta();
		}
		set
		{
			_Hasta = value;
		}
	}

	public RangoFecha(DateTime Desde, DateTime Hasta)
	{
		_Desde = Desde;
		_Hasta = Hasta;
	}

	public void SetRange(DateTime Desde, DateTime Hasta)
	{
		_Desde = Desde;
		_Hasta = Hasta;
	}
}
