using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spEstructOrganiz_ExpResult
{
	private int _Year;

	private int _idAreaOrganiz;

	private string _AreaOrganizacional;

	private string _Abrev;

	private string _Sigla;

	private decimal? _PresupAnual;

	private decimal? _PromedMensSueld;

	private int? _NroTrabajaUO;

	private string _Mision;

	private string _Vision;

	private int? _IdPresupuesto;

	private int? _YearDe;

	private int? _idDependeDe;

	private int? _IdEmpleado;

	private decimal? _InversPublic;

	private char? _ApruebaPedido;

	private decimal? _MontoAprobacion;

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

	[Column(Storage = "_IdPresupuesto", DbType = "Int")]
	public int? IdPresupuesto
	{
		get
		{
			return _IdPresupuesto;
		}
		set
		{
			if (!_IdPresupuesto.Equals(value))
			{
				_IdPresupuesto = value;
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

	[Column(Storage = "_IdEmpleado", DbType = "Int")]
	public int? IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (!_IdEmpleado.Equals(value))
			{
				_IdEmpleado = value;
			}
		}
	}

	[Column(Storage = "_InversPublic", DbType = "Decimal(0,0)")]
	public decimal? InversPublic
	{
		get
		{
			return _InversPublic;
		}
		set
		{
			if (!_InversPublic.Equals(value))
			{
				_InversPublic = value;
			}
		}
	}

	[Column(Storage = "_ApruebaPedido", DbType = "Char(1)")]
	public char? ApruebaPedido
	{
		get
		{
			return _ApruebaPedido;
		}
		set
		{
			if (!_ApruebaPedido.Equals(value))
			{
				_ApruebaPedido = value;
			}
		}
	}

	[Column(Storage = "_MontoAprobacion", DbType = "Decimal(0,0)")]
	public decimal? MontoAprobacion
	{
		get
		{
			return _MontoAprobacion;
		}
		set
		{
			if (!_MontoAprobacion.Equals(value))
			{
				_MontoAprobacion = value;
			}
		}
	}
}
