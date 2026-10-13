using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spEstructOrganiz_SelectResult
{
	private int _idAreaOrganiz;

	private int _Year;

	private string _AreaOrganizacional;

	private string _Abrev;

	private string _Sigla;

	private decimal? _PresupAnual;

	private decimal? _PromedMensSueld;

	private int _NroTrabajaUO;

	private int _idDependeDe;

	private int? _YearDe;

	private int _IdPresupuesto;

	private string _Mision;

	private string _Vision;

	private string _DependeDe;

	private string _LstAreaO;

	private int _IdEmpleado;

	private string _Empleado;

	private string _SiglaDependeDe;

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

	private decimal _InversPublic;

	private decimal _TotalIP;

	private int _IdInverPublica;

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

	[Column(Storage = "_idAreaOrganiz", DbType = "Int NOT NULL")]
	public int idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (_idAreaOrganiz != value)
			{
				_idAreaOrganiz = value;
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

	[Column(Storage = "_AreaOrganizacional", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string AreaOrganizacional
	{
		get
		{
			return _AreaOrganizacional;
		}
		set
		{
			if (!string.Equals(_AreaOrganizacional, value))
			{
				_AreaOrganizacional = value;
			}
		}
	}

	[Column(Storage = "_Abrev", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
	public string Abrev
	{
		get
		{
			return _Abrev;
		}
		set
		{
			if (!string.Equals(_Abrev, value))
			{
				_Abrev = value;
			}
		}
	}

	[Column(Storage = "_Sigla", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
	public string Sigla
	{
		get
		{
			return _Sigla;
		}
		set
		{
			if (!string.Equals(_Sigla, value))
			{
				_Sigla = value;
			}
		}
	}

	[Column(Storage = "_PresupAnual", DbType = "Decimal(0,0)")]
	public decimal? PresupAnual
	{
		get
		{
			return _PresupAnual;
		}
		set
		{
			if (!_PresupAnual.Equals(value))
			{
				_PresupAnual = value;
			}
		}
	}

	[Column(Storage = "_PromedMensSueld", DbType = "Decimal(0,0)")]
	public decimal? PromedMensSueld
	{
		get
		{
			return _PromedMensSueld;
		}
		set
		{
			if (!_PromedMensSueld.Equals(value))
			{
				_PromedMensSueld = value;
			}
		}
	}

	[Column(Storage = "_NroTrabajaUO", DbType = "Int NOT NULL")]
	public int NroTrabajaUO
	{
		get
		{
			return _NroTrabajaUO;
		}
		set
		{
			if (_NroTrabajaUO != value)
			{
				_NroTrabajaUO = value;
			}
		}
	}

	[Column(Storage = "_idDependeDe", DbType = "Int NOT NULL")]
	public int idDependeDe
	{
		get
		{
			return _idDependeDe;
		}
		set
		{
			if (_idDependeDe != value)
			{
				_idDependeDe = value;
			}
		}
	}

	[Column(Storage = "_YearDe", DbType = "Int")]
	public int? YearDe
	{
		get
		{
			return _YearDe;
		}
		set
		{
			if (!_YearDe.Equals(value))
			{
				_YearDe = value;
			}
		}
	}

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

	[Column(Storage = "_Mision", DbType = "VarChar(1000)")]
	public string Mision
	{
		get
		{
			return _Mision;
		}
		set
		{
			if (!string.Equals(_Mision, value))
			{
				_Mision = value;
			}
		}
	}

	[Column(Storage = "_Vision", DbType = "VarChar(1000)")]
	public string Vision
	{
		get
		{
			return _Vision;
		}
		set
		{
			if (!string.Equals(_Vision, value))
			{
				_Vision = value;
			}
		}
	}

	[Column(Storage = "_DependeDe", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string DependeDe
	{
		get
		{
			return _DependeDe;
		}
		set
		{
			if (!string.Equals(_DependeDe, value))
			{
				_DependeDe = value;
			}
		}
	}

	[Column(Storage = "_LstAreaO", DbType = "VarChar(205)")]
	public string LstAreaO
	{
		get
		{
			return _LstAreaO;
		}
		set
		{
			if (!string.Equals(_LstAreaO, value))
			{
				_LstAreaO = value;
			}
		}
	}

	[Column(Storage = "_IdEmpleado", DbType = "Int NOT NULL")]
	public int IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (_IdEmpleado != value)
			{
				_IdEmpleado = value;
			}
		}
	}

	[Column(Storage = "_Empleado", DbType = "VarChar(163) NOT NULL", CanBeNull = false)]
	public string Empleado
	{
		get
		{
			return _Empleado;
		}
		set
		{
			if (!string.Equals(_Empleado, value))
			{
				_Empleado = value;
			}
		}
	}

	[Column(Storage = "_SiglaDependeDe", DbType = "VarChar(30) NOT NULL", CanBeNull = false)]
	public string SiglaDependeDe
	{
		get
		{
			return _SiglaDependeDe;
		}
		set
		{
			if (!string.Equals(_SiglaDependeDe, value))
			{
				_SiglaDependeDe = value;
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

	[Column(Storage = "_InversPublic", DbType = "Decimal(0,0) NOT NULL")]
	public decimal InversPublic
	{
		get
		{
			return _InversPublic;
		}
		set
		{
			if (decimal.Compare(_InversPublic, value) != 0)
			{
				_InversPublic = value;
			}
		}
	}

	[Column(Storage = "_TotalIP", DbType = "Decimal(0,0) NOT NULL")]
	public decimal TotalIP
	{
		get
		{
			return _TotalIP;
		}
		set
		{
			if (decimal.Compare(_TotalIP, value) != 0)
			{
				_TotalIP = value;
			}
		}
	}

	[Column(Storage = "_IdInverPublica", DbType = "Int NOT NULL")]
	public int IdInverPublica
	{
		get
		{
			return _IdInverPublica;
		}
		set
		{
			if (_IdInverPublica != value)
			{
				_IdInverPublica = value;
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
