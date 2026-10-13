using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.PresupuestoT")]
public class PresupuestoT : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

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

	[Column(Storage = "_IdPresupuesto", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_IdPresupuesto = value;
				SendPropertyChanged("IdPresupuesto");
			}
		}
	}

	[Column(Storage = "_PAnual", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_PAnual = value;
				SendPropertyChanged("PAnual");
			}
		}
	}

	[Column(Storage = "_PTriI", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_PTriI = value;
				SendPropertyChanged("PTriI");
			}
		}
	}

	[Column(Storage = "_PTriII", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_PTriII = value;
				SendPropertyChanged("PTriII");
			}
		}
	}

	[Column(Storage = "_PTriIII", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_PTriIII = value;
				SendPropertyChanged("PTriIII");
			}
		}
	}

	[Column(Storage = "_PTriIV", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_PTriIV = value;
				SendPropertyChanged("PTriIV");
			}
		}
	}

	[Column(Storage = "_Aanual", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_Aanual = value;
				SendPropertyChanged("Aanual");
			}
		}
	}

	[Column(Storage = "_ATriI", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_ATriI = value;
				SendPropertyChanged("ATriI");
			}
		}
	}

	[Column(Storage = "_ATriII", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_ATriII = value;
				SendPropertyChanged("ATriII");
			}
		}
	}

	[Column(Storage = "_ATriIII", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_ATriIII = value;
				SendPropertyChanged("ATriIII");
			}
		}
	}

	[Column(Storage = "_ATriIV", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_ATriIV = value;
				SendPropertyChanged("ATriIV");
			}
		}
	}

	[Column(Storage = "_M01P", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_M01P = value;
				SendPropertyChanged("M01P");
			}
		}
	}

	[Column(Storage = "_M02P", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_M02P = value;
				SendPropertyChanged("M02P");
			}
		}
	}

	[Column(Storage = "_M03P", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_M03P = value;
				SendPropertyChanged("M03P");
			}
		}
	}

	[Column(Storage = "_M04P", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_M04P = value;
				SendPropertyChanged("M04P");
			}
		}
	}

	[Column(Storage = "_M05P", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_M05P = value;
				SendPropertyChanged("M05P");
			}
		}
	}

	[Column(Storage = "_M06P", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_M06P = value;
				SendPropertyChanged("M06P");
			}
		}
	}

	[Column(Storage = "_M07P", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_M07P = value;
				SendPropertyChanged("M07P");
			}
		}
	}

	[Column(Storage = "_M08P", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_M08P = value;
				SendPropertyChanged("M08P");
			}
		}
	}

	[Column(Storage = "_M09P", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_M09P = value;
				SendPropertyChanged("M09P");
			}
		}
	}

	[Column(Storage = "_M10P", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_M10P = value;
				SendPropertyChanged("M10P");
			}
		}
	}

	[Column(Storage = "_M11P", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_M11P = value;
				SendPropertyChanged("M11P");
			}
		}
	}

	[Column(Storage = "_M12P", DbType = "Decimal(11,2)")]
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
				SendPropertyChanging();
				_M12P = value;
				SendPropertyChanged("M12P");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void SendPropertyChanging()
	{
		if (PropertyChanging != null)
		{
			PropertyChanging?.Invoke(this, emptyChangingEventArgs);
		}
	}

	protected virtual void SendPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
