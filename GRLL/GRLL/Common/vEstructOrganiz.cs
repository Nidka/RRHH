using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vEstructOrganiz")]
public class vEstructOrganiz
{
	private int _Year;

	private int _idAreaOrganiz;

	private string _AreaOrganizacional;

	private string _Abrev;

	private string _Sigla;

	private string _SiglaFull;

	private string _SiglaDependeDe;

	private decimal? _PresupAnual;

	private decimal? _PromedMensSueld;

	private int? _NroTrabajaUO;

	private int? _idDependeDe;

	private int? _YearDe;

	private int _IdPresupuesto;

	private string _Mision;

	private string _Vision;

	private string _DependeDe;

	private int? _SubAreas;

	private string _YearId;

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

	private string _Responsable;

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

	[Column(Storage = "_AreaOrganizacional", DbType = "VarChar(80)")]
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

	[Column(Storage = "_Sigla", DbType = "VarChar(6) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_SiglaFull", DbType = "VarChar(30)")]
	public string SiglaFull
	{
		get
		{
			return _SiglaFull;
		}
		set
		{
			if (!string.Equals(_SiglaFull, value))
			{
				_SiglaFull = value;
			}
		}
	}

	[Column(Storage = "_SiglaDependeDe", DbType = "VarChar(30)")]
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

	[Column(Storage = "_PresupAnual", DbType = "Decimal(9,2)")]
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

	[Column(Storage = "_PromedMensSueld", DbType = "Decimal(9,2)")]
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

	[Column(Storage = "_NroTrabajaUO", DbType = "Int")]
	public int? NroTrabajaUO
	{
		get
		{
			return _NroTrabajaUO;
		}
		set
		{
			if (!_NroTrabajaUO.Equals(value))
			{
				_NroTrabajaUO = value;
			}
		}
	}

	[Column(Storage = "_idDependeDe", DbType = "Int")]
	public int? idDependeDe
	{
		get
		{
			return _idDependeDe;
		}
		set
		{
			if (!_idDependeDe.Equals(value))
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

	[Column(Storage = "_DependeDe", DbType = "VarChar(80)")]
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

	[Column(Storage = "_SubAreas", DbType = "Int")]
	public int? SubAreas
	{
		get
		{
			return _SubAreas;
		}
		set
		{
			if (!_SubAreas.Equals(value))
			{
				_SubAreas = value;
			}
		}
	}

	[Column(Storage = "_YearId", DbType = "VarChar(11)")]
	public string YearId
	{
		get
		{
			return _YearId;
		}
		set
		{
			if (!string.Equals(_YearId, value))
			{
				_YearId = value;
			}
		}
	}

	[Column(Storage = "_PAnual", DbType = "Decimal(9,2) NOT NULL")]
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

	[Column(Storage = "_PTriI", DbType = "Decimal(9,2) NOT NULL")]
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

	[Column(Storage = "_PTriII", DbType = "Decimal(9,2) NOT NULL")]
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

	[Column(Storage = "_PTriIII", DbType = "Decimal(9,2) NOT NULL")]
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

	[Column(Storage = "_PTriIV", DbType = "Decimal(9,2) NOT NULL")]
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

	[Column(Storage = "_Aanual", DbType = "Decimal(9,2) NOT NULL")]
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

	[Column(Storage = "_ATriI", DbType = "Decimal(9,2) NOT NULL")]
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

	[Column(Storage = "_ATriII", DbType = "Decimal(9,2) NOT NULL")]
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

	[Column(Storage = "_ATriIII", DbType = "Decimal(9,2) NOT NULL")]
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

	[Column(Storage = "_ATriIV", DbType = "Decimal(9,2) NOT NULL")]
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

	[Column(Storage = "_Responsable", DbType = "VarChar(80)")]
	public string Responsable
	{
		get
		{
			return _Responsable;
		}
		set
		{
			if (!string.Equals(_Responsable, value))
			{
				_Responsable = value;
			}
		}
	}
}
