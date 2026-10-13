using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ParametrosTrab")]
public class ParametrosTrab : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdParametros;

	private int _Year;

	private short? _HorasTrabajo;

	private byte? _SemasTrabajo;

	private short? _DiasTrabajo;

	private short? _ProgramaP;

	private short? _M1;

	private short? _M2;

	private short? _M3;

	private short? _M4;

	private short? _M5;

	private short? _M6;

	private short? _M7;

	private short? _M8;

	private short? _M9;

	private short? _M10;

	private short? _M11;

	private short? _M12;

	private string _AlmacenPrincipal;

	private int? _AreaAutorizacion;

	private bool? _Activo;

	[Column(Storage = "_IdParametros", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdParametros
	{
		get
		{
			return _IdParametros;
		}
		set
		{
			if (_IdParametros != value)
			{
				SendPropertyChanging();
				_IdParametros = value;
				SendPropertyChanged("IdParametros");
			}
		}
	}

	[Column(Storage = "_Year", DbType = "Int NOT NULL")]
	public int Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (_Year != value)
			{
				SendPropertyChanging();
				_Year = value;
				SendPropertyChanged("Year");
			}
		}
	}

	[Column(Storage = "_HorasTrabajo", DbType = "SmallInt")]
	public short? HorasTrabajo
	{
		get
		{
			return _HorasTrabajo;
		}
		set
		{
			if (!_HorasTrabajo.Equals(value))
			{
				SendPropertyChanging();
				_HorasTrabajo = value;
				SendPropertyChanged("HorasTrabajo");
			}
		}
	}

	[Column(Storage = "_SemasTrabajo", DbType = "TinyInt")]
	public byte? SemasTrabajo
	{
		get
		{
			return _SemasTrabajo;
		}
		set
		{
			if (!_SemasTrabajo.Equals(value))
			{
				SendPropertyChanging();
				_SemasTrabajo = value;
				SendPropertyChanged("SemasTrabajo");
			}
		}
	}

	[Column(Storage = "_DiasTrabajo", DbType = "SmallInt")]
	public short? DiasTrabajo
	{
		get
		{
			return _DiasTrabajo;
		}
		set
		{
			if (!_DiasTrabajo.Equals(value))
			{
				SendPropertyChanging();
				_DiasTrabajo = value;
				SendPropertyChanged("DiasTrabajo");
			}
		}
	}

	[Column(Storage = "_ProgramaP", DbType = "SmallInt")]
	public short? ProgramaP
	{
		get
		{
			return _ProgramaP;
		}
		set
		{
			if (!_ProgramaP.Equals(value))
			{
				SendPropertyChanging();
				_ProgramaP = value;
				SendPropertyChanged("ProgramaP");
			}
		}
	}

	[Column(Storage = "_M1", DbType = "SmallInt")]
	public short? M1
	{
		get
		{
			return _M1;
		}
		set
		{
			if (!_M1.Equals(value))
			{
				SendPropertyChanging();
				_M1 = value;
				SendPropertyChanged("M1");
			}
		}
	}

	[Column(Storage = "_M2", DbType = "SmallInt")]
	public short? M2
	{
		get
		{
			return _M2;
		}
		set
		{
			if (!_M2.Equals(value))
			{
				SendPropertyChanging();
				_M2 = value;
				SendPropertyChanged("M2");
			}
		}
	}

	[Column(Storage = "_M3", DbType = "SmallInt")]
	public short? M3
	{
		get
		{
			return _M3;
		}
		set
		{
			if (!_M3.Equals(value))
			{
				SendPropertyChanging();
				_M3 = value;
				SendPropertyChanged("M3");
			}
		}
	}

	[Column(Storage = "_M4", DbType = "SmallInt")]
	public short? M4
	{
		get
		{
			return _M4;
		}
		set
		{
			if (!_M4.Equals(value))
			{
				SendPropertyChanging();
				_M4 = value;
				SendPropertyChanged("M4");
			}
		}
	}

	[Column(Storage = "_M5", DbType = "SmallInt")]
	public short? M5
	{
		get
		{
			return _M5;
		}
		set
		{
			if (!_M5.Equals(value))
			{
				SendPropertyChanging();
				_M5 = value;
				SendPropertyChanged("M5");
			}
		}
	}

	[Column(Storage = "_M6", DbType = "SmallInt")]
	public short? M6
	{
		get
		{
			return _M6;
		}
		set
		{
			if (!_M6.Equals(value))
			{
				SendPropertyChanging();
				_M6 = value;
				SendPropertyChanged("M6");
			}
		}
	}

	[Column(Storage = "_M7", DbType = "SmallInt")]
	public short? M7
	{
		get
		{
			return _M7;
		}
		set
		{
			if (!_M7.Equals(value))
			{
				SendPropertyChanging();
				_M7 = value;
				SendPropertyChanged("M7");
			}
		}
	}

	[Column(Storage = "_M8", DbType = "SmallInt")]
	public short? M8
	{
		get
		{
			return _M8;
		}
		set
		{
			if (!_M8.Equals(value))
			{
				SendPropertyChanging();
				_M8 = value;
				SendPropertyChanged("M8");
			}
		}
	}

	[Column(Storage = "_M9", DbType = "SmallInt")]
	public short? M9
	{
		get
		{
			return _M9;
		}
		set
		{
			if (!_M9.Equals(value))
			{
				SendPropertyChanging();
				_M9 = value;
				SendPropertyChanged("M9");
			}
		}
	}

	[Column(Storage = "_M10", DbType = "SmallInt")]
	public short? M10
	{
		get
		{
			return _M10;
		}
		set
		{
			if (!_M10.Equals(value))
			{
				SendPropertyChanging();
				_M10 = value;
				SendPropertyChanged("M10");
			}
		}
	}

	[Column(Storage = "_M11", DbType = "SmallInt")]
	public short? M11
	{
		get
		{
			return _M11;
		}
		set
		{
			if (!_M11.Equals(value))
			{
				SendPropertyChanging();
				_M11 = value;
				SendPropertyChanged("M11");
			}
		}
	}

	[Column(Storage = "_M12", DbType = "SmallInt")]
	public short? M12
	{
		get
		{
			return _M12;
		}
		set
		{
			if (!_M12.Equals(value))
			{
				SendPropertyChanging();
				_M12 = value;
				SendPropertyChanged("M12");
			}
		}
	}

	[Column(Storage = "_AlmacenPrincipal", DbType = "Char(2)")]
	public string AlmacenPrincipal
	{
		get
		{
			return _AlmacenPrincipal;
		}
		set
		{
			if (!string.Equals(_AlmacenPrincipal, value))
			{
				SendPropertyChanging();
				_AlmacenPrincipal = value;
				SendPropertyChanged("AlmacenPrincipal");
			}
		}
	}

	[Column(Storage = "_AreaAutorizacion", DbType = "Int")]
	public int? AreaAutorizacion
	{
		get
		{
			return _AreaAutorizacion;
		}
		set
		{
			if (!_AreaAutorizacion.Equals(value))
			{
				SendPropertyChanging();
				_AreaAutorizacion = value;
				SendPropertyChanged("AreaAutorizacion");
			}
		}
	}

	[Column(Storage = "_Activo", DbType = "Bit")]
	public bool? Activo
	{
		get
		{
			return _Activo;
		}
		set
		{
			if (!_Activo.Equals(value))
			{
				SendPropertyChanging();
				_Activo = value;
				SendPropertyChanged("Activo");
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
