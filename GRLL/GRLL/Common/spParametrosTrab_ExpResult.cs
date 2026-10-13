using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spParametrosTrab_ExpResult
{
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

	[Column(Storage = "_IdParametros", DbType = "Int NOT NULL")]
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
				_IdParametros = value;
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
				_Year = value;
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
				_HorasTrabajo = value;
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
				_SemasTrabajo = value;
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
				_DiasTrabajo = value;
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
				_ProgramaP = value;
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
				_M1 = value;
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
				_M2 = value;
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
				_M3 = value;
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
				_M4 = value;
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
				_M5 = value;
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
				_M6 = value;
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
				_M7 = value;
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
				_M8 = value;
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
				_M9 = value;
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
				_M10 = value;
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
				_M11 = value;
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
				_M12 = value;
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
				_AlmacenPrincipal = value;
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
				_AreaAutorizacion = value;
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
				_Activo = value;
			}
		}
	}
}
