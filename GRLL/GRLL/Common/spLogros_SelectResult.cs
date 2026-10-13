using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spLogros_SelectResult
{
	private int _Year;

	private int _idAreaOrganiz;

	private short _Trimestre;

	private int _IdLogros;

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

	[Column(Storage = "_IdLogros", DbType = "Int NOT NULL")]
	public int IdLogros
	{
		get
		{
			return _IdLogros;
		}
		set
		{
			if (_IdLogros != value)
			{
				_IdLogros = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(8000) NOT NULL", CanBeNull = false)]
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
