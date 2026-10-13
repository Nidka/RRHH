using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spPresupuestoT_ExpResult
{
	private int _IdPresupuesto;

	private decimal? _PAnual;

	private decimal? _PTriI;

	private decimal? _PTriII;

	private decimal? _PTriIII;

	private decimal? _PTriIV;

	private decimal? _Aanual;

	private decimal? _ATriI;

	private decimal? _ATriII;

	private decimal? _ATriIII;

	private decimal? _ATriIV;

	private decimal? _M01P;

	private decimal? _M02P;

	private decimal? _M03P;

	private decimal? _M04P;

	private decimal? _M05P;

	private decimal? _M06P;

	private decimal? _M07P;

	private decimal? _M08P;

	private decimal? _M09P;

	private decimal? _M10P;

	private decimal? _M11P;

	private decimal? _M12P;

	[Column(Storage = "_IdPresupuesto", DbType = "Int NOT NULL")]
	public int IdPresupuesto
	{
		get
		{
			return _IdPresupuesto;
		}
		set
		{
			if (_IdPresupuesto != value)
			{
				_IdPresupuesto = value;
			}
		}
	}

	[Column(Storage = "_PAnual", DbType = "Decimal(0,0)")]
	public decimal? PAnual
	{
		get
		{
			return _PAnual;
		}
		set
		{
			if (!_PAnual.Equals(value))
			{
				_PAnual = value;
			}
		}
	}

	[Column(Storage = "_PTriI", DbType = "Decimal(0,0)")]
	public decimal? PTriI
	{
		get
		{
			return _PTriI;
		}
		set
		{
			if (!_PTriI.Equals(value))
			{
				_PTriI = value;
			}
		}
	}

	[Column(Storage = "_PTriII", DbType = "Decimal(0,0)")]
	public decimal? PTriII
	{
		get
		{
			return _PTriII;
		}
		set
		{
			if (!_PTriII.Equals(value))
			{
				_PTriII = value;
			}
		}
	}

	[Column(Storage = "_PTriIII", DbType = "Decimal(0,0)")]
	public decimal? PTriIII
	{
		get
		{
			return _PTriIII;
		}
		set
		{
			if (!_PTriIII.Equals(value))
			{
				_PTriIII = value;
			}
		}
	}

	[Column(Storage = "_PTriIV", DbType = "Decimal(0,0)")]
	public decimal? PTriIV
	{
		get
		{
			return _PTriIV;
		}
		set
		{
			if (!_PTriIV.Equals(value))
			{
				_PTriIV = value;
			}
		}
	}

	[Column(Storage = "_Aanual", DbType = "Decimal(0,0)")]
	public decimal? Aanual
	{
		get
		{
			return _Aanual;
		}
		set
		{
			if (!_Aanual.Equals(value))
			{
				_Aanual = value;
			}
		}
	}

	[Column(Storage = "_ATriI", DbType = "Decimal(0,0)")]
	public decimal? ATriI
	{
		get
		{
			return _ATriI;
		}
		set
		{
			if (!_ATriI.Equals(value))
			{
				_ATriI = value;
			}
		}
	}

	[Column(Storage = "_ATriII", DbType = "Decimal(0,0)")]
	public decimal? ATriII
	{
		get
		{
			return _ATriII;
		}
		set
		{
			if (!_ATriII.Equals(value))
			{
				_ATriII = value;
			}
		}
	}

	[Column(Storage = "_ATriIII", DbType = "Decimal(0,0)")]
	public decimal? ATriIII
	{
		get
		{
			return _ATriIII;
		}
		set
		{
			if (!_ATriIII.Equals(value))
			{
				_ATriIII = value;
			}
		}
	}

	[Column(Storage = "_ATriIV", DbType = "Decimal(0,0)")]
	public decimal? ATriIV
	{
		get
		{
			return _ATriIV;
		}
		set
		{
			if (!_ATriIV.Equals(value))
			{
				_ATriIV = value;
			}
		}
	}

	[Column(Storage = "_M01P", DbType = "Decimal(0,0)")]
	public decimal? M01P
	{
		get
		{
			return _M01P;
		}
		set
		{
			if (!_M01P.Equals(value))
			{
				_M01P = value;
			}
		}
	}

	[Column(Storage = "_M02P", DbType = "Decimal(0,0)")]
	public decimal? M02P
	{
		get
		{
			return _M02P;
		}
		set
		{
			if (!_M02P.Equals(value))
			{
				_M02P = value;
			}
		}
	}

	[Column(Storage = "_M03P", DbType = "Decimal(0,0)")]
	public decimal? M03P
	{
		get
		{
			return _M03P;
		}
		set
		{
			if (!_M03P.Equals(value))
			{
				_M03P = value;
			}
		}
	}

	[Column(Storage = "_M04P", DbType = "Decimal(0,0)")]
	public decimal? M04P
	{
		get
		{
			return _M04P;
		}
		set
		{
			if (!_M04P.Equals(value))
			{
				_M04P = value;
			}
		}
	}

	[Column(Storage = "_M05P", DbType = "Decimal(0,0)")]
	public decimal? M05P
	{
		get
		{
			return _M05P;
		}
		set
		{
			if (!_M05P.Equals(value))
			{
				_M05P = value;
			}
		}
	}

	[Column(Storage = "_M06P", DbType = "Decimal(0,0)")]
	public decimal? M06P
	{
		get
		{
			return _M06P;
		}
		set
		{
			if (!_M06P.Equals(value))
			{
				_M06P = value;
			}
		}
	}

	[Column(Storage = "_M07P", DbType = "Decimal(0,0)")]
	public decimal? M07P
	{
		get
		{
			return _M07P;
		}
		set
		{
			if (!_M07P.Equals(value))
			{
				_M07P = value;
			}
		}
	}

	[Column(Storage = "_M08P", DbType = "Decimal(0,0)")]
	public decimal? M08P
	{
		get
		{
			return _M08P;
		}
		set
		{
			if (!_M08P.Equals(value))
			{
				_M08P = value;
			}
		}
	}

	[Column(Storage = "_M09P", DbType = "Decimal(0,0)")]
	public decimal? M09P
	{
		get
		{
			return _M09P;
		}
		set
		{
			if (!_M09P.Equals(value))
			{
				_M09P = value;
			}
		}
	}

	[Column(Storage = "_M10P", DbType = "Decimal(0,0)")]
	public decimal? M10P
	{
		get
		{
			return _M10P;
		}
		set
		{
			if (!_M10P.Equals(value))
			{
				_M10P = value;
			}
		}
	}

	[Column(Storage = "_M11P", DbType = "Decimal(0,0)")]
	public decimal? M11P
	{
		get
		{
			return _M11P;
		}
		set
		{
			if (!_M11P.Equals(value))
			{
				_M11P = value;
			}
		}
	}

	[Column(Storage = "_M12P", DbType = "Decimal(0,0)")]
	public decimal? M12P
	{
		get
		{
			return _M12P;
		}
		set
		{
			if (!_M12P.Equals(value))
			{
				_M12P = value;
			}
		}
	}
}
