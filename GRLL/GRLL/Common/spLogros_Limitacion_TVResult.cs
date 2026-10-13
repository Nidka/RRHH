using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spLogros_Limitacion_TVResult
{
	private int _Year;

	private int _idAreaOrganiz;

	private short _Trimestre;

	private int _Id;

	private string _Descripcion;

	private string _Ids;

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

	[Column(Storage = "_Id", DbType = "Int NOT NULL")]
	public int Id
	{
		get
		{
			return _Id;
		}
		set
		{
			if (_Id != value)
			{
				_Id = value;
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

	[Column(Storage = "_Ids", DbType = "VarChar(41)")]
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
}
