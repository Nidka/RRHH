using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spEmpleado_SelectResult
{
	private int _IdEmpleado;

	private int _Year;

	private int _idAreaOrganiz;

	private int _IdPersona;

	private string _Nombres;

	private string _Apellido_Paterno;

	private string _Apellido_Materno;

	private string _Persona;

	private string _Personal_Tipo;

	private int _TipoDocID;

	private string _TipoDocID1;

	private string _NumDocID;

	private int _IdTipoTrabajador;

	private string _TipoTrabajador;

	private string _FechaIngreso;

	private int _IdCargo;

	private char? _Estado;

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

	[Column(Storage = "_IdPersona", DbType = "Int NOT NULL")]
	public int IdPersona
	{
		get
		{
			return _IdPersona;
		}
		set
		{
			if (_IdPersona != value)
			{
				_IdPersona = value;
			}
		}
	}

	[Column(Storage = "_Nombres", DbType = "VarChar(100) NOT NULL", CanBeNull = false)]
	public string Nombres
	{
		get
		{
			return _Nombres;
		}
		set
		{
			if (!string.Equals(_Nombres, value))
			{
				_Nombres = value;
			}
		}
	}

	[Column(Storage = "_Apellido_Paterno", DbType = "VarChar(30) NOT NULL", CanBeNull = false)]
	public string Apellido_Paterno
	{
		get
		{
			return _Apellido_Paterno;
		}
		set
		{
			if (!string.Equals(_Apellido_Paterno, value))
			{
				_Apellido_Paterno = value;
			}
		}
	}

	[Column(Storage = "_Apellido_Materno", DbType = "VarChar(30) NOT NULL", CanBeNull = false)]
	public string Apellido_Materno
	{
		get
		{
			return _Apellido_Materno;
		}
		set
		{
			if (!string.Equals(_Apellido_Materno, value))
			{
				_Apellido_Materno = value;
			}
		}
	}

	[Column(Storage = "_Persona", DbType = "VarChar(163) NOT NULL", CanBeNull = false)]
	public string Persona
	{
		get
		{
			return _Persona;
		}
		set
		{
			if (!string.Equals(_Persona, value))
			{
				_Persona = value;
			}
		}
	}

	[Column(Storage = "_Personal_Tipo", DbType = "VarChar(169)")]
	public string Personal_Tipo
	{
		get
		{
			return _Personal_Tipo;
		}
		set
		{
			if (!string.Equals(_Personal_Tipo, value))
			{
				_Personal_Tipo = value;
			}
		}
	}

	[Column(Storage = "_TipoDocID", DbType = "Int NOT NULL")]
	public int TipoDocID
	{
		get
		{
			return _TipoDocID;
		}
		set
		{
			if (_TipoDocID != value)
			{
				_TipoDocID = value;
			}
		}
	}

	[Column(Storage = "_TipoDocID1", DbType = "VarChar(40)")]
	public string TipoDocID1
	{
		get
		{
			return _TipoDocID1;
		}
		set
		{
			if (!string.Equals(_TipoDocID1, value))
			{
				_TipoDocID1 = value;
			}
		}
	}

	[Column(Storage = "_NumDocID", DbType = "Char(12) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_IdTipoTrabajador", DbType = "Int NOT NULL")]
	public int IdTipoTrabajador
	{
		get
		{
			return _IdTipoTrabajador;
		}
		set
		{
			if (_IdTipoTrabajador != value)
			{
				_IdTipoTrabajador = value;
			}
		}
	}

	[Column(Storage = "_TipoTrabajador", DbType = "VarChar(30)")]
	public string TipoTrabajador
	{
		get
		{
			return _TipoTrabajador;
		}
		set
		{
			if (!string.Equals(_TipoTrabajador, value))
			{
				_TipoTrabajador = value;
			}
		}
	}

	[Column(Storage = "_FechaIngreso", DbType = "VarChar(10)")]
	public string FechaIngreso
	{
		get
		{
			return _FechaIngreso;
		}
		set
		{
			if (!string.Equals(_FechaIngreso, value))
			{
				_FechaIngreso = value;
			}
		}
	}

	[Column(Storage = "_IdCargo", DbType = "Int NOT NULL")]
	public int IdCargo
	{
		get
		{
			return _IdCargo;
		}
		set
		{
			if (_IdCargo != value)
			{
				_IdCargo = value;
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
}
