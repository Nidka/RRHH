using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spEmpleado_ExpResult
{
	private int _IdEmpleado;

	private int _Year;

	private int _idAreaOrganiz;

	private int? _IdPersona;

	private DateTime? _FechaIngreso;

	private int? _IdAFP;

	private string _Brevete;

	private int? _IdEstadoCivil;

	private char? _Sexo;

	private string _CtaCorriente;

	private string _NroAFP;

	private DateTime? _FechaAFP;

	private int? _IdSeguro;

	private string _NroSeguro;

	private int? _IdTipoSangre;

	private string _DecLey;

	private Binary _Foto;

	private int? _IdTipoTrabajador;

	private char? _Estado;

	private int? _IdCargo;

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

	[Column(Storage = "_FechaIngreso", DbType = "SmallDateTime")]
	public DateTime? FechaIngreso
	{
		get
		{
			return _FechaIngreso;
		}
		set
		{
			if (!_FechaIngreso.Equals(value))
			{
				_FechaIngreso = value;
			}
		}
	}

	[Column(Storage = "_IdAFP", DbType = "Int")]
	public int? IdAFP
	{
		get
		{
			return _IdAFP;
		}
		set
		{
			if (!_IdAFP.Equals(value))
			{
				_IdAFP = value;
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

	[Column(Storage = "_FechaAFP", DbType = "DateTime")]
	public DateTime? FechaAFP
	{
		get
		{
			return _FechaAFP;
		}
		set
		{
			if (!_FechaAFP.Equals(value))
			{
				_FechaAFP = value;
			}
		}
	}

	[Column(Storage = "_IdSeguro", DbType = "Int")]
	public int? IdSeguro
	{
		get
		{
			return _IdSeguro;
		}
		set
		{
			if (!_IdSeguro.Equals(value))
			{
				_IdSeguro = value;
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

	[Column(Storage = "_Foto", DbType = "Image")]
	public Binary Foto
	{
		get
		{
			return _Foto;
		}
		set
		{
			if (!object.Equals(_Foto, value))
			{
				_Foto = value;
			}
		}
	}

	[Column(Storage = "_IdTipoTrabajador", DbType = "Int")]
	public int? IdTipoTrabajador
	{
		get
		{
			return _IdTipoTrabajador;
		}
		set
		{
			if (!_IdTipoTrabajador.Equals(value))
			{
				_IdTipoTrabajador = value;
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

	[Column(Storage = "_IdCargo", DbType = "Int")]
	public int? IdCargo
	{
		get
		{
			return _IdCargo;
		}
		set
		{
			if (!_IdCargo.Equals(value))
			{
				_IdCargo = value;
			}
		}
	}
}
