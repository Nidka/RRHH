using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class ANT_SP_BuscarAnticipoResult
{
	private string _IdAnticipo;

	private string _IdEmpleado;

	private DateTime _Fecha;

	private decimal _Monto;

	private string _Motivo;

	private string _Observacion;

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

	[Column(Storage = "_IdEmpleado", DbType = "Char(10) NOT NULL", CanBeNull = false)]
	public string IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (!string.Equals(_IdEmpleado, value))
			{
				_IdEmpleado = value;
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

	[Column(Storage = "_Motivo", DbType = "Char(50) NOT NULL", CanBeNull = false)]
	public string Motivo
	{
		get
		{
			return _Motivo;
		}
		set
		{
			if (!string.Equals(_Motivo, value))
			{
				_Motivo = value;
			}
		}
	}

	[Column(Storage = "_Observacion", DbType = "Char(100)")]
	public string Observacion
	{
		get
		{
			return _Observacion;
		}
		set
		{
			if (!string.Equals(_Observacion, value))
			{
				_Observacion = value;
			}
		}
	}
}
