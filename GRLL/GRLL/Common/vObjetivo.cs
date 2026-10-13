using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vObjetivo")]
public class vObjetivo
{
	private int? _idAreaOrganiz;

	private int? _Year;

	private int? _IdEstrategia;

	private int _IdObjetivo;

	private string _Objetivo;

	private string _FechaInicio;

	private string _FechaFin;

	private int? _IdPresupuesto;

	private string _Ids;

	private string _IdsE;

	private string _IdsO;

	[Column(Storage = "_idAreaOrganiz", DbType = "Int")]
	public int? idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (!_idAreaOrganiz.Equals(value))
			{
				_idAreaOrganiz = value;
			}
		}
	}

	[Column(Storage = "_Year", DbType = "Int")]
	public int? Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (!_Year.Equals(value))
			{
				_Year = value;
			}
		}
	}

	[Column(Storage = "_IdEstrategia", DbType = "Int")]
	public int? IdEstrategia
	{
		get
		{
			return _IdEstrategia;
		}
		set
		{
			if (!_IdEstrategia.Equals(value))
			{
				_IdEstrategia = value;
			}
		}
	}

	[Column(Storage = "_IdObjetivo", DbType = "Int NOT NULL")]
	public int IdObjetivo
	{
		get
		{
			return _IdObjetivo;
		}
		set
		{
			if (_IdObjetivo != value)
			{
				_IdObjetivo = value;
			}
		}
	}

	[Column(Storage = "_Objetivo", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
	public string Objetivo
	{
		get
		{
			return _Objetivo;
		}
		set
		{
			if (!string.Equals(_Objetivo, value))
			{
				_Objetivo = value;
			}
		}
	}

	[Column(Storage = "_FechaInicio", DbType = "VarChar(10)")]
	public string FechaInicio
	{
		get
		{
			return _FechaInicio;
		}
		set
		{
			if (!string.Equals(_FechaInicio, value))
			{
				_FechaInicio = value;
			}
		}
	}

	[Column(Storage = "_FechaFin", DbType = "VarChar(10)")]
	public string FechaFin
	{
		get
		{
			return _FechaFin;
		}
		set
		{
			if (!string.Equals(_FechaFin, value))
			{
				_FechaFin = value;
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

	[Column(Storage = "_Ids", DbType = "VarChar(15)")]
	public string Ids
	{
		get
		{
			return _Ids;
		}
		set
		{
			if (!string.Equals(_Ids, value))
			{
				_Ids = value;
			}
		}
	}

	[Column(Storage = "_IdsE", DbType = "VarChar(26)")]
	public string IdsE
	{
		get
		{
			return _IdsE;
		}
		set
		{
			if (!string.Equals(_IdsE, value))
			{
				_IdsE = value;
			}
		}
	}

	[Column(Storage = "_IdsO", DbType = "VarChar(37)")]
	public string IdsO
	{
		get
		{
			return _IdsO;
		}
		set
		{
			if (!string.Equals(_IdsO, value))
			{
				_IdsO = value;
			}
		}
	}
}
