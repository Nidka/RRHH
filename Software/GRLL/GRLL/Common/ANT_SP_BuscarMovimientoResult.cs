using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class ANT_SP_BuscarMovimientoResult
{
	private string _IdMovimiento;

	private string _IdAnticipo;

	private DateTime _Fecha;

	private decimal _Monto;

	private decimal _Saldo;

	[Column(Storage = "_IdMovimiento", DbType = "Char(10) NOT NULL", CanBeNull = false)]
	public string IdMovimiento
	{
		get
		{
			return _IdMovimiento;
		}
		set
		{
			if (!string.Equals(_IdMovimiento, value))
			{
				_IdMovimiento = value;
			}
		}
	}

	[Column(Storage = "_IdAnticipo", DbType = "Char(10) NOT NULL", CanBeNull = false)]
	public string IdAnticipo
	{
		get
		{
			return _IdAnticipo;
		}
		set
		{
			if (!string.Equals(_IdAnticipo, value))
			{
				_IdAnticipo = value;
			}
		}
	}

	[Column(Storage = "_Fecha", DbType = "DateTime NOT NULL")]
	public DateTime Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (DateTime.Compare(_Fecha, value) != 0)
			{
				_Fecha = value;
			}
		}
	}

	[Column(Storage = "_Monto", DbType = "Money NOT NULL")]
	public decimal Monto
	{
		get
		{
			return _Monto;
		}
		set
		{
			if (decimal.Compare(_Monto, value) != 0)
			{
				_Monto = value;
			}
		}
	}

	[Column(Storage = "_Saldo", DbType = "Money NOT NULL")]
	public decimal Saldo
	{
		get
		{
			return _Saldo;
		}
		set
		{
			if (decimal.Compare(_Saldo, value) != 0)
			{
				_Saldo = value;
			}
		}
	}
}
