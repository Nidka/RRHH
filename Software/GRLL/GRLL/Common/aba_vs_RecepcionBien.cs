using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.aba_vs_RecepcionBien")]
public class aba_vs_RecepcionBien
{
	private DateTime? _Fecha;

	private string _RazonSocial;

	private char _TipoOrden;

	private string _IdOrden;

	private string _IdBien;

	private string _Descripcion;

	private string _Abreviatura;

	private decimal? _Stock;

	private decimal? _CantidadOrdenada;

	private decimal _CantidadRecibida;

	private string _Estado;

	private decimal? _Saldo;

	private decimal _CantidadIngreso;

	private decimal? _Costo;

	private string _Meta;

	[Column(Storage = "_Fecha", DbType = "DateTime")]
	public DateTime? Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!_Fecha.Equals(value))
			{
				_Fecha = value;
			}
		}
	}

	[Column(Storage = "_RazonSocial", DbType = "VarChar(100)")]
	public string RazonSocial
	{
		get
		{
			return _RazonSocial;
		}
		set
		{
			if (!string.Equals(_RazonSocial, value))
			{
				_RazonSocial = value;
			}
		}
	}

	[Column(Storage = "_TipoOrden", DbType = "Char(1) NOT NULL")]
	public char TipoOrden
	{
		get
		{
			return _TipoOrden;
		}
		set
		{
			if (_TipoOrden != value)
			{
				_TipoOrden = value;
			}
		}
	}

	[Column(Storage = "_IdOrden", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string IdOrden
	{
		get
		{
			return _IdOrden;
		}
		set
		{
			if (!string.Equals(_IdOrden, value))
			{
				_IdOrden = value;
			}
		}
	}

	[Column(Storage = "_IdBien", DbType = "Char(13) NOT NULL", CanBeNull = false)]
	public string IdBien
	{
		get
		{
			return _IdBien;
		}
		set
		{
			if (!string.Equals(_IdBien, value))
			{
				_IdBien = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(120)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				_Descripcion = value;
			}
		}
	}

	[Column(Storage = "_Abreviatura", DbType = "Char(4)")]
	public string Abreviatura
	{
		get
		{
			return _Abreviatura;
		}
		set
		{
			if (!string.Equals(_Abreviatura, value))
			{
				_Abreviatura = value;
			}
		}
	}

	[Column(Storage = "_Stock", DbType = "Decimal(9,2)")]
	public decimal? Stock
	{
		get
		{
			return _Stock;
		}
		set
		{
			if (!_Stock.Equals(value))
			{
				_Stock = value;
			}
		}
	}

	[Column(Storage = "_CantidadOrdenada", DbType = "Decimal(11,4)")]
	public decimal? CantidadOrdenada
	{
		get
		{
			return _CantidadOrdenada;
		}
		set
		{
			if (!_CantidadOrdenada.Equals(value))
			{
				_CantidadOrdenada = value;
			}
		}
	}

	[Column(Storage = "_CantidadRecibida", DbType = "Decimal(38,4) NOT NULL")]
	public decimal CantidadRecibida
	{
		get
		{
			return _CantidadRecibida;
		}
		set
		{
			if (decimal.Compare(_CantidadRecibida, value) != 0)
			{
				_CantidadRecibida = value;
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "VarChar(22)")]
	public string Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!string.Equals(_Estado, value))
			{
				_Estado = value;
			}
		}
	}

	[Column(Storage = "_Saldo", DbType = "Decimal(38,4)")]
	public decimal? Saldo
	{
		get
		{
			return _Saldo;
		}
		set
		{
			if (!_Saldo.Equals(value))
			{
				_Saldo = value;
			}
		}
	}

	[Column(Storage = "_CantidadIngreso", DbType = "Decimal(4,4) NOT NULL")]
	public decimal CantidadIngreso
	{
		get
		{
			return _CantidadIngreso;
		}
		set
		{
			if (decimal.Compare(_CantidadIngreso, value) != 0)
			{
				_CantidadIngreso = value;
			}
		}
	}

	[Column(Storage = "_Costo", DbType = "Decimal(9,2)")]
	public decimal? Costo
	{
		get
		{
			return _Costo;
		}
		set
		{
			if (!_Costo.Equals(value))
			{
				_Costo = value;
			}
		}
	}

	[Column(Storage = "_Meta", DbType = "Char(6)")]
	public string Meta
	{
		get
		{
			return _Meta;
		}
		set
		{
			if (!string.Equals(_Meta, value))
			{
				_Meta = value;
			}
		}
	}
}
