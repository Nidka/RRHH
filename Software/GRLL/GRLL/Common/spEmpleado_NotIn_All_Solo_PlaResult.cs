using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spEmpleado_NotIn_All_Solo_PlaResult
{
	private int? _IdPersona;

	private string _Nombres;

	private string _Apellido_Paterno;

	private string _Apellido_Materno;

	private string _Personal;

	private string _NumDocID;

	private string _Telefono;

	private string _Direccion;

	private string _Email;

	private DateTime? _FechaNacimiento;

	private string _Brevete;

	private int? _IdEstadoCivil;

	private string _DescripEstCivil;

	private char? _Sexo;

	private string _CtaCorriente;

	private string _NroAFP;

	private string _NroSeguro;

	private int? _IdTipoSangre;

	private char? _Estado;

	private string _DecLey;

	[Column(Storage = "_IdPersona", DbType = "Int")]
	public int? IdPersona
	{
		get
		{
			return _IdPersona;
		}
		set
		{
			if (!_IdPersona.Equals(value))
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

	[Column(Storage = "_Personal", DbType = "VarChar(163) NOT NULL", CanBeNull = false)]
	public string Personal
	{
		get
		{
			return _Personal;
		}
		set
		{
			if (!string.Equals(_Personal, value))
			{
				_Personal = value;
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

	[Column(Storage = "_Email", DbType = "VarChar(50)")]
	public string Email
	{
		get
		{
			return _Email;
		}
		set
		{
			if (!string.Equals(_Email, value))
			{
				_Email = value;
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

	[Column(Storage = "_Brevete", DbType = "VarChar(12)")]
	public string Brevete
	{
		get
		{
			return _Brevete;
		}
		set
		{
			if (!string.Equals(_Brevete, value))
			{
				_Brevete = value;
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

	[Column(Storage = "_DescripEstCivil", DbType = "VarChar(11)")]
	public string DescripEstCivil
	{
		get
		{
			return _DescripEstCivil;
		}
		set
		{
			if (!string.Equals(_DescripEstCivil, value))
			{
				_DescripEstCivil = value;
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

	[Column(Storage = "_CtaCorriente", DbType = "VarChar(16)")]
	public string CtaCorriente
	{
		get
		{
			return _CtaCorriente;
		}
		set
		{
			if (!string.Equals(_CtaCorriente, value))
			{
				_CtaCorriente = value;
			}
		}
	}

	[Column(Storage = "_NroAFP", DbType = "VarChar(20)")]
	public string NroAFP
	{
		get
		{
			return _NroAFP;
		}
		set
		{
			if (!string.Equals(_NroAFP, value))
			{
				_NroAFP = value;
			}
		}
	}

	[Column(Storage = "_NroSeguro", DbType = "VarChar(20)")]
	public string NroSeguro
	{
		get
		{
			return _NroSeguro;
		}
		set
		{
			if (!string.Equals(_NroSeguro, value))
			{
				_NroSeguro = value;
			}
		}
	}

	[Column(Storage = "_IdTipoSangre", DbType = "Int")]
	public int? IdTipoSangre
	{
		get
		{
			return _IdTipoSangre;
		}
		set
		{
			if (!_IdTipoSangre.Equals(value))
			{
				_IdTipoSangre = value;
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

	[Column(Storage = "_DecLey", DbType = "VarChar(10)")]
	public string DecLey
	{
		get
		{
			return _DecLey;
		}
		set
		{
			if (!string.Equals(_DecLey, value))
			{
				_DecLey = value;
			}
		}
	}
}
