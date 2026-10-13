using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRecomendacion_SelectResult
{
	private int _Year;

	private int _idAreaOrganiz;

	private short _Trimestre;

	private int _IdRecomend;

	private int _IdLimitacion;

	private string _Limitacion;

	private string _Descripcion;

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

	[Column(Storage = "_Trimestre", DbType = "SmallInt NOT NULL")]
	public short Trimestre
	{
		get
		{
			return _Trimestre;
		}
		set
		{
			if (_Trimestre != value)
			{
				_Trimestre = value;
			}
		}
	}

	[Column(Storage = "_IdRecomend", DbType = "Int NOT NULL")]
	public int IdRecomend
	{
		get
		{
			return _IdRecomend;
		}
		set
		{
			if (_IdRecomend != value)
			{
				_IdRecomend = value;
			}
		}
	}

	[Column(Storage = "_IdLimitacion", DbType = "Int NOT NULL")]
	public int IdLimitacion
	{
		get
		{
			return _IdLimitacion;
		}
		set
		{
			if (_IdLimitacion != value)
			{
				_IdLimitacion = value;
			}
		}
	}

	[Column(Storage = "_Limitacion", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
	public string Limitacion
	{
		get
		{
			return _Limitacion;
		}
		set
		{
			if (!string.Equals(_Limitacion, value))
			{
				_Limitacion = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
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
}
