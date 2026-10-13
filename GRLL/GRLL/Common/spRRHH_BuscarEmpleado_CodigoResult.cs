using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_BuscarEmpleado_CodigoResult
{
	private string _Nombres;

	private string _Apellido_paterno;

	private string _Apellido_Materno;

	private char? _Sexo;

	private int? _TipoDocID;

	private string _NumDocID;

	private int? _idNacionalidad;

	private DateTime? _FechaNacimiento;

	private string _Telefono;

	private string _Numcelular;

	private string _FonoCentrolab;

	private string _Fax;

	private int? _IdEstadoCivil;

	private int? _IdDiscapacidad;

	private string _IdUbigeo;

	private string _Direccion;

	private string _UbigeoDireccion;

	private string _ExpSocial;

	private Binary _foto;

	private int? _idpersona;

	private int _year;

	private int _idAreaOrganiz;

	private DateTime? _FechaRegistro;

	private string _email;

	private int? _idtiposangre;

	private string _gradoinstruccion;

	private string _numlibretamilitar;

	private string _brevete;

	private string _NumRUC;

	[Column(Storage = "_Nombres", DbType = "VarChar(100)")]
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

	[Column(Storage = "_Apellido_paterno", DbType = "VarChar(30)")]
	public string Apellido_paterno
	{
		get
		{
			return _Apellido_paterno;
		}
		set
		{
			if (!string.Equals(_Apellido_paterno, value))
			{
				_Apellido_paterno = value;
			}
		}
	}

	[Column(Storage = "_Apellido_Materno", DbType = "VarChar(30)")]
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

	[Column(Storage = "_Sexo", DbType = "Char(1)")]
	public char? Sexo
	{
		get
		{
			return _Sexo;
		}
		set
		{
			if (!_Sexo.Equals(value))
			{
				_Sexo = value;
			}
		}
	}

	[Column(Storage = "_TipoDocID", DbType = "Int")]
	public int? TipoDocID
	{
		get
		{
			return _TipoDocID;
		}
		set
		{
			if (!_TipoDocID.Equals(value))
			{
				_TipoDocID = value;
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

	[Column(Storage = "_idNacionalidad", DbType = "Int")]
	public int? idNacionalidad
	{
		get
		{
			return _idNacionalidad;
		}
		set
		{
			if (!_idNacionalidad.Equals(value))
			{
				_idNacionalidad = value;
			}
		}
	}

	[Column(Storage = "_FechaNacimiento", DbType = "DateTime")]
	public DateTime? FechaNacimiento
	{
		get
		{
			return _FechaNacimiento;
		}
		set
		{
			if (!_FechaNacimiento.Equals(value))
			{
				_FechaNacimiento = value;
			}
		}
	}

	[Column(Storage = "_Telefono", DbType = "VarChar(15)")]
	public string Telefono
	{
		get
		{
			return _Telefono;
		}
		set
		{
			if (!string.Equals(_Telefono, value))
			{
				_Telefono = value;
			}
		}
	}

	[Column(Storage = "_Numcelular", DbType = "VarChar(15)")]
	public string Numcelular
	{
		get
		{
			return _Numcelular;
		}
		set
		{
			if (!string.Equals(_Numcelular, value))
			{
				_Numcelular = value;
			}
		}
	}

	[Column(Storage = "_FonoCentrolab", DbType = "VarChar(15)")]
	public string FonoCentrolab
	{
		get
		{
			return _FonoCentrolab;
		}
		set
		{
			if (!string.Equals(_FonoCentrolab, value))
			{
				_FonoCentrolab = value;
			}
		}
	}

	[Column(Storage = "_Fax", DbType = "VarChar(15)")]
	public string Fax
	{
		get
		{
			return _Fax;
		}
		set
		{
			if (!string.Equals(_Fax, value))
			{
				_Fax = value;
			}
		}
	}

	[Column(Storage = "_IdEstadoCivil", DbType = "Int")]
	public int? IdEstadoCivil
	{
		get
		{
			return _IdEstadoCivil;
		}
		set
		{
			if (!_IdEstadoCivil.Equals(value))
			{
				_IdEstadoCivil = value;
			}
		}
	}

	[Column(Storage = "_IdDiscapacidad", DbType = "Int")]
	public int? IdDiscapacidad
	{
		get
		{
			return _IdDiscapacidad;
		}
		set
		{
			if (!_IdDiscapacidad.Equals(value))
			{
				_IdDiscapacidad = value;
			}
		}
	}

	[Column(Storage = "_IdUbigeo", DbType = "Char(6)")]
	public string IdUbigeo
	{
		get
		{
			return _IdUbigeo;
		}
		set
		{
			if (!string.Equals(_IdUbigeo, value))
			{
				_IdUbigeo = value;
			}
		}
	}

	[Column(Storage = "_Direccion", DbType = "VarChar(100)")]
	public string Direccion
	{
		get
		{
			return _Direccion;
		}
		set
		{
			if (!string.Equals(_Direccion, value))
			{
				_Direccion = value;
			}
		}
	}

	[Column(Storage = "_UbigeoDireccion", DbType = "Char(6)")]
	public string UbigeoDireccion
	{
		get
		{
			return _UbigeoDireccion;
		}
		set
		{
			if (!string.Equals(_UbigeoDireccion, value))
			{
				_UbigeoDireccion = value;
			}
		}
	}

	[Column(Storage = "_ExpSocial", DbType = "VarChar(20)")]
	public string ExpSocial
	{
		get
		{
			return _ExpSocial;
		}
		set
		{
			if (!string.Equals(_ExpSocial, value))
			{
				_ExpSocial = value;
			}
		}
	}

	[Column(Storage = "_foto", DbType = "Image")]
	public Binary foto
	{
		get
		{
			return _foto;
		}
		set
		{
			if (!object.Equals(_foto, value))
			{
				_foto = value;
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

	[Column(Storage = "_FechaRegistro", DbType = "DateTime")]
	public DateTime? FechaRegistro
	{
		get
		{
			return _FechaRegistro;
		}
		set
		{
			if (!_FechaRegistro.Equals(value))
			{
				_FechaRegistro = value;
			}
		}
	}

	[Column(Storage = "_email", DbType = "VarChar(50)")]
	public string email
	{
		get
		{
			return _email;
		}
		set
		{
			if (!string.Equals(_email, value))
			{
				_email = value;
			}
		}
	}

	[Column(Storage = "_idtiposangre", DbType = "Int")]
	public int? idtiposangre
	{
		get
		{
			return _idtiposangre;
		}
		set
		{
			if (!_idtiposangre.Equals(value))
			{
				_idtiposangre = value;
			}
		}
	}

	[Column(Storage = "_gradoinstruccion", DbType = "VarChar(80)")]
	public string gradoinstruccion
	{
		get
		{
			return _gradoinstruccion;
		}
		set
		{
			if (!string.Equals(_gradoinstruccion, value))
			{
				_gradoinstruccion = value;
			}
		}
	}

	[Column(Storage = "_numlibretamilitar", DbType = "VarChar(10)")]
	public string numlibretamilitar
	{
		get
		{
			return _numlibretamilitar;
		}
		set
		{
			if (!string.Equals(_numlibretamilitar, value))
			{
				_numlibretamilitar = value;
			}
		}
	}

	[Column(Storage = "_brevete", DbType = "VarChar(12)")]
	public string brevete
	{
		get
		{
			return _brevete;
		}
		set
		{
			if (!string.Equals(_brevete, value))
			{
				_brevete = value;
			}
		}
	}

	[Column(Storage = "_NumRUC", DbType = "VarChar(12)")]
	public string NumRUC
	{
		get
		{
			return _NumRUC;
		}
		set
		{
			if (!string.Equals(_NumRUC, value))
			{
				_NumRUC = value;
			}
		}
	}
}
