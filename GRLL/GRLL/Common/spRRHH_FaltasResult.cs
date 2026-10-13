using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_FaltasResult
{
	private string _NombresC;

	private string _NumDocID;

	private int _Idpersona;

	private int _IdEmpleado;

	private int _year;

	private int _idAreaOrganiz;

	private int? _idTipoTrabajador;

	private char? _Estado;

	private string _AreaOrganizacional;

	private string _Descripcion;

	private int? _Fecha;

	[Column(Storage = "_NombresC", DbType = "VarChar(162)")]
	public string NombresC
	{
		get
		{
			return _NombresC;
		}
		set
		{
			if (!string.Equals(_NombresC, value))
			{
				_NombresC = value;
			}
		}
	}

	[Column(Storage = "_NumDocID", DbType = "Char(12)")]
	public string NumDocID
	{
		get
		{
			return _NumDocID;
		}
		set
		{
			if (!string.Equals(_NumDocID, value))
			{
				_NumDocID = value;
			}
		}
	}

	[Column(Storage = "_Idpersona", DbType = "Int NOT NULL")]
	public int Idpersona
	{
		get
		{
			return _Idpersona;
		}
		set
		{
			if (_Idpersona != value)
			{
				_Idpersona = value;
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

	[Column(Storage = "_year", DbType = "Int NOT NULL")]
	public int year
	{
		get
		{
			return _year;
		}
		set
		{
			if (_year != value)
			{
				_year = value;
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

	[Column(Storage = "_idTipoTrabajador", DbType = "Int")]
	public int? idTipoTrabajador
	{
		get
		{
			return _idTipoTrabajador;
		}
		set
		{
			if (!_idTipoTrabajador.Equals(value))
			{
				_idTipoTrabajador = value;
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Char(1)")]
	public char? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				_Estado = value;
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

	[Column(Storage = "_Descripcion", DbType = "VarChar(30)")]
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

	[Column(Storage = "_Fecha", DbType = "Int")]
	public int? Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!_Fecha.Equals(value))
			{
				_Fecha = value;
			}
		}
	}
}
