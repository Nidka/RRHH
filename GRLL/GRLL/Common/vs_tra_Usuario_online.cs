using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_tra_Usuario_online")]
public class vs_tra_Usuario_online
{
	private int _idusuario;

	private string _login;

	private string _nombres;

	private string _apellido_paterno;

	private string _apellido_materno;

	private string _areaorganizacional;

	private string _cargo;

	private int _idempleado;

	private int? _idpersona;

	private int _idareaorganiz;

	private int? _idcargo;

	private string _pc_name;

	private string _ip_address;

	private bool _estado;

	[Column(Storage = "_idusuario", DbType = "Int NOT NULL")]
	public int idusuario
	{
		get
		{
			return _idusuario;
		}
		set
		{
			if (_idusuario != value)
			{
				_idusuario = value;
			}
		}
	}

	[Column(Storage = "_login", DbType = "Char(20)")]
	public string login
	{
		get
		{
			return _login;
		}
		set
		{
			if (!string.Equals(_login, value))
			{
				_login = value;
			}
		}
	}

	[Column(Storage = "_nombres", DbType = "VarChar(100)")]
	public string nombres
	{
		get
		{
			return _nombres;
		}
		set
		{
			if (!string.Equals(_nombres, value))
			{
				_nombres = value;
			}
		}
	}

	[Column(Storage = "_apellido_paterno", DbType = "VarChar(30)")]
	public string apellido_paterno
	{
		get
		{
			return _apellido_paterno;
		}
		set
		{
			if (!string.Equals(_apellido_paterno, value))
			{
				_apellido_paterno = value;
			}
		}
	}

	[Column(Storage = "_apellido_materno", DbType = "VarChar(30)")]
	public string apellido_materno
	{
		get
		{
			return _apellido_materno;
		}
		set
		{
			if (!string.Equals(_apellido_materno, value))
			{
				_apellido_materno = value;
			}
		}
	}

	[Column(Storage = "_areaorganizacional", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string areaorganizacional
	{
		get
		{
			return _areaorganizacional;
		}
		set
		{
			if (!string.Equals(_areaorganizacional, value))
			{
				_areaorganizacional = value;
			}
		}
	}

	[Column(Storage = "_cargo", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string cargo
	{
		get
		{
			return _cargo;
		}
		set
		{
			if (!string.Equals(_cargo, value))
			{
				_cargo = value;
			}
		}
	}

	[Column(Storage = "_idempleado", DbType = "Int NOT NULL")]
	public int idempleado
	{
		get
		{
			return _idempleado;
		}
		set
		{
			if (_idempleado != value)
			{
				_idempleado = value;
			}
		}
	}

	[Column(Storage = "_idpersona", DbType = "Int")]
	public int? idpersona
	{
		get
		{
			return _idpersona;
		}
		set
		{
			if (!_idpersona.Equals(value))
			{
				_idpersona = value;
			}
		}
	}

	[Column(Storage = "_idareaorganiz", DbType = "Int NOT NULL")]
	public int idareaorganiz
	{
		get
		{
			return _idareaorganiz;
		}
		set
		{
			if (_idareaorganiz != value)
			{
				_idareaorganiz = value;
			}
		}
	}

	[Column(Storage = "_idcargo", DbType = "Int")]
	public int? idcargo
	{
		get
		{
			return _idcargo;
		}
		set
		{
			if (!_idcargo.Equals(value))
			{
				_idcargo = value;
			}
		}
	}

	[Column(Storage = "_pc_name", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string pc_name
	{
		get
		{
			return _pc_name;
		}
		set
		{
			if (!string.Equals(_pc_name, value))
			{
				_pc_name = value;
			}
		}
	}

	[Column(Storage = "_ip_address", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string ip_address
	{
		get
		{
			return _ip_address;
		}
		set
		{
			if (!string.Equals(_ip_address, value))
			{
				_ip_address = value;
			}
		}
	}

	[Column(Storage = "_estado", DbType = "Bit NOT NULL")]
	public bool estado
	{
		get
		{
			return _estado;
		}
		set
		{
			if (_estado != value)
			{
				_estado = value;
			}
		}
	}
}
