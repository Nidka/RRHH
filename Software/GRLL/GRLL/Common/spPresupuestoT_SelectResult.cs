using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spPresupuestoT_SelectResult
{
	private int _IdPresupuesto;

	private decimal _PAnual;

	private decimal _PTriI;

	private decimal _PTriII;

	private decimal _PTriIII;

	private decimal _PTriIV;

	private decimal _Aanual;

	private decimal _ATriI;

	private decimal _ATriII;

	private decimal _ATriIII;

	private decimal _ATriIV;

	private decimal _M01P;

	private decimal _M02P;

	private decimal _M03P;

	private decimal _M04P;

	private decimal _M05P;

	private decimal _M06P;

	private decimal _M07P;

	private decimal _M08P;

	private decimal _M09P;

	private decimal _M10P;

	private decimal _M11P;

	private decimal _M12P;

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

	[Column(Storage = "_PAnual", DbType = "Decimal(0,0) NOT NULL")]
	public decimal PAnual
	{
		get
		{
			return _PAnual;
		}
		set
		{
			if (decimal.Compare(_PAnual, value) != 0)
			{
				_PAnual = value;
			}
		}
	}

	[Column(Storage = "_PTriI", DbType = "Decimal(0,0) NOT NULL")]
	public decimal PTriI
	{
		get
		{
			return _PTriI;
		}
		set
		{
			if (decimal.Compare(_PTriI, value) != 0)
			{
				_PTriI = value;
			}
		}
	}

	[Column(Storage = "_PTriII", DbType = "Decimal(0,0) NOT NULL")]
	public decimal PTriII
	{
		get
		{
			return _PTriII;
		}
		set
		{
			if (decimal.Compare(_PTriII, value) != 0)
			{
				_PTriII = value;
			}
		}
	}

	[Column(Storage = "_PTriIII", DbType = "Decimal(0,0) NOT NULL")]
	public decimal PTriIII
	{
		get
		{
			return _PTriIII;
		}
		set
		{
			if (decimal.Compare(_PTriIII, value) != 0)
			{
				_PTriIII = value;
			}
		}
	}

	[Column(Storage = "_PTriIV", DbType = "Decimal(0,0) NOT NULL")]
	public decimal PTriIV
	{
		get
		{
			return _PTriIV;
		}
		set
		{
			if (decimal.Compare(_PTriIV, value) != 0)
			{
				_PTriIV = value;
			}
		}
	}

	[Column(Storage = "_Aanual", DbType = "Decimal(0,0) NOT NULL")]
	public decimal Aanual
	{
		get
		{
			return _Aanual;
		}
		set
		{
			if (decimal.Compare(_Aanual, value) != 0)
			{
				_Aanual = value;
			}
		}
	}

	[Column(Storage = "_ATriI", DbType = "Decimal(0,0) NOT NULL")]
	public decimal ATriI
	{
		get
		{
			return _ATriI;
		}
		set
		{
			if (decimal.Compare(_ATriI, value) != 0)
			{
				_ATriI = value;
			}
		}
	}

	[Column(Storage = "_ATriII", DbType = "Decimal(0,0) NOT NULL")]
	public decimal ATriII
	{
		get
		{
			return _ATriII;
		}
		set
		{
			if (decimal.Compare(_ATriII, value) != 0)
			{
				_ATriII = value;
			}
		}
	}

	[Column(Storage = "_ATriIII", DbType = "Decimal(0,0) NOT NULL")]
	public decimal ATriIII
	{
		get
		{
			return _ATriIII;
		}
		set
		{
			if (decimal.Compare(_ATriIII, value) != 0)
			{
				_ATriIII = value;
			}
		}
	}

	[Column(Storage = "_ATriIV", DbType = "Decimal(0,0) NOT NULL")]
	public decimal ATriIV
	{
		get
		{
			return _ATriIV;
		}
		set
		{
			if (decimal.Compare(_ATriIV, value) != 0)
			{
				_ATriIV = value;
			}
		}
	}

	[Column(Storage = "_M01P", DbType = "Decimal(0,0) NOT NULL")]
	public decimal M01P
	{
		get
		{
			return _M01P;
		}
		set
		{
			if (decimal.Compare(_M01P, value) != 0)
			{
				_M01P = value;
			}
		}
	}

	[Column(Storage = "_M02P", DbType = "Decimal(0,0) NOT NULL")]
	public decimal M02P
	{
		get
		{
			return _M02P;
		}
		set
		{
			if (decimal.Compare(_M02P, value) != 0)
			{
				_M02P = value;
			}
		}
	}

	[Column(Storage = "_M03P", DbType = "Decimal(0,0) NOT NULL")]
	public decimal M03P
	{
		get
		{
			return _M03P;
		}
		set
		{
			if (decimal.Compare(_M03P, value) != 0)
			{
				_M03P = value;
			}
		}
	}

	[Column(Storage = "_M04P", DbType = "Decimal(0,0) NOT NULL")]
	public decimal M04P
	{
		get
		{
			return _M04P;
		}
		set
		{
			if (decimal.Compare(_M04P, value) != 0)
			{
				_M04P = value;
			}
		}
	}

	[Column(Storage = "_M05P", DbType = "Decimal(0,0) NOT NULL")]
	public decimal M05P
	{
		get
		{
			return _M05P;
		}
		set
		{
			if (decimal.Compare(_M05P, value) != 0)
			{
				_M05P = value;
			}
		}
	}

	[Column(Storage = "_M06P", DbType = "Decimal(0,0) NOT NULL")]
	public decimal M06P
	{
		get
		{
			return _M06P;
		}
		set
		{
			if (decimal.Compare(_M06P, value) != 0)
			{
				_M06P = value;
			}
		}
	}

	[Column(Storage = "_M07P", DbType = "Decimal(0,0) NOT NULL")]
	public decimal M07P
	{
		get
		{
			return _M07P;
		}
		set
		{
			if (decimal.Compare(_M07P, value) != 0)
			{
				_M07P = value;
			}
		}
	}

	[Column(Storage = "_M08P", DbType = "Decimal(0,0) NOT NULL")]
	public decimal M08P
	{
		get
		{
			return _M08P;
		}
		set
		{
			if (decimal.Compare(_M08P, value) != 0)
			{
				_M08P = value;
			}
		}
	}

	[Column(Storage = "_M09P", DbType = "Decimal(0,0) NOT NULL")]
	public decimal M09P
	{
		get
		{
			return _M09P;
		}
		set
		{
			if (decimal.Compare(_M09P, value) != 0)
			{
				_M09P = value;
			}
		}
	}

	[Column(Storage = "_M10P", DbType = "Decimal(0,0) NOT NULL")]
	public decimal M10P
	{
		get
		{
			return _M10P;
		}
		set
		{
			if (decimal.Compare(_M10P, value) != 0)
			{
				_M10P = value;
			}
		}
	}

	[Column(Storage = "_M11P", DbType = "Decimal(0,0) NOT NULL")]
	public decimal M11P
	{
		get
		{
			return _M11P;
		}
		set
		{
			if (decimal.Compare(_M11P, value) != 0)
			{
				_M11P = value;
			}
		}
	}

	[Column(Storage = "_M12P", DbType = "Decimal(0,0) NOT NULL")]
	public decimal M12P
	{
		get
		{
			return _M12P;
		}
		set
		{
			if (decimal.Compare(_M12P, value) != 0)
			{
				_M12P = value;
			}
		}
	}
}
