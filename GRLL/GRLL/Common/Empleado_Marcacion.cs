using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.Empleado_Marcacion")]
public class Empleado_Marcacion
{
	private int _idEmpleado;

	private string _pers_nombres;

	private string _pers_apelpat;

	private string _pers_apelmat;

	private string _numDocId;

	private string _pers_telef;

	private string _pers_direc;

	private string _pers_email;

	private DateTime? _pers_fecNac;

	private string _pers_LM;

	private string _pers_brevete;

	private char? _pers_estCivil;

	private char? _pers_sexo;

	private string _pers_cuentaCorriente;

	private string _pers_nroAFP;

	private string _pers_nroSeguro;

	private int? _cod_inst_salud;

	private int? _cod_afp;

	private string _ubi_cod;

	private Binary _Foto;

	private DateTime? _pers_fec_afilia_afp;

	private string _tipo_sangre;

	private char? _pers_estado;

	private string _DEC_LEY;

	private short? _idHorario;

	private char? _TipoEmpleado;

	[Column(Storage = "_idEmpleado", DbType = "Int NOT NULL")]
	public int idEmpleado
	{
		get
		{
			return _idEmpleado;
		}
		set
		{
			if (_idEmpleado != value)
			{
				_idEmpleado = value;
			}
		}
	}

	[Column(Storage = "_pers_nombres", DbType = "VarChar(40) NOT NULL", CanBeNull = false)]
	public string pers_nombres
	{
		get
		{
			return _pers_nombres;
		}
		set
		{
			if (!string.Equals(_pers_nombres, value))
			{
				_pers_nombres = value;
			}
		}
	}

	[Column(Storage = "_pers_apelpat", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
	public string pers_apelpat
	{
		get
		{
			return _pers_apelpat;
		}
		set
		{
			if (!string.Equals(_pers_apelpat, value))
			{
				_pers_apelpat = value;
			}
		}
	}

	[Column(Storage = "_pers_apelmat", DbType = "VarChar(20) NOT NULL", CanBeNull = false)]
	public string pers_apelmat
	{
		get
		{
			return _pers_apelmat;
		}
		set
		{
			if (!string.Equals(_pers_apelmat, value))
			{
				_pers_apelmat = value;
			}
		}
	}

	[Column(Storage = "_numDocId", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string numDocId
	{
		get
		{
			return _numDocId;
		}
		set
		{
			if (!string.Equals(_numDocId, value))
			{
				_numDocId = value;
			}
		}
	}

	[Column(Storage = "_pers_telef", DbType = "Char(10)")]
	public string pers_telef
	{
		get
		{
			return _pers_telef;
		}
		set
		{
			if (!string.Equals(_pers_telef, value))
			{
				_pers_telef = value;
			}
		}
	}

	[Column(Storage = "_pers_direc", DbType = "VarChar(50)")]
	public string pers_direc
	{
		get
		{
			return _pers_direc;
		}
		set
		{
			if (!string.Equals(_pers_direc, value))
			{
				_pers_direc = value;
			}
		}
	}

	[Column(Storage = "_pers_email", DbType = "VarChar(40)")]
	public string pers_email
	{
		get
		{
			return _pers_email;
		}
		set
		{
			if (!string.Equals(_pers_email, value))
			{
				_pers_email = value;
			}
		}
	}

	[Column(Storage = "_pers_fecNac", DbType = "DateTime")]
	public DateTime? pers_fecNac
	{
		get
		{
			return _pers_fecNac;
		}
		set
		{
			if (!_pers_fecNac.Equals(value))
			{
				_pers_fecNac = value;
			}
		}
	}

	[Column(Storage = "_pers_LM", DbType = "Char(10)")]
	public string pers_LM
	{
		get
		{
			return _pers_LM;
		}
		set
		{
			if (!string.Equals(_pers_LM, value))
			{
				_pers_LM = value;
			}
		}
	}

	[Column(Storage = "_pers_brevete", DbType = "Char(10)")]
	public string pers_brevete
	{
		get
		{
			return _pers_brevete;
		}
		set
		{
			if (!string.Equals(_pers_brevete, value))
			{
				_pers_brevete = value;
			}
		}
	}

	[Column(Storage = "_pers_estCivil", DbType = "Char(1)")]
	public char? pers_estCivil
	{
		get
		{
			return _pers_estCivil;
		}
		set
		{
			if (!_pers_estCivil.Equals(value))
			{
				_pers_estCivil = value;
			}
		}
	}

	[Column(Storage = "_pers_sexo", DbType = "Char(1)")]
	public char? pers_sexo
	{
		get
		{
			return _pers_sexo;
		}
		set
		{
			if (!_pers_sexo.Equals(value))
			{
				_pers_sexo = value;
			}
		}
	}

	[Column(Storage = "_pers_cuentaCorriente", DbType = "VarChar(15)")]
	public string pers_cuentaCorriente
	{
		get
		{
			return _pers_cuentaCorriente;
		}
		set
		{
			if (!string.Equals(_pers_cuentaCorriente, value))
			{
				_pers_cuentaCorriente = value;
			}
		}
	}

	[Column(Storage = "_pers_nroAFP", DbType = "VarChar(20)")]
	public string pers_nroAFP
	{
		get
		{
			return _pers_nroAFP;
		}
		set
		{
			if (!string.Equals(_pers_nroAFP, value))
			{
				_pers_nroAFP = value;
			}
		}
	}

	[Column(Storage = "_pers_nroSeguro", DbType = "VarChar(20)")]
	public string pers_nroSeguro
	{
		get
		{
			return _pers_nroSeguro;
		}
		set
		{
			if (!string.Equals(_pers_nroSeguro, value))
			{
				_pers_nroSeguro = value;
			}
		}
	}

	[Column(Storage = "_cod_inst_salud", DbType = "Int")]
	public int? cod_inst_salud
	{
		get
		{
			return _cod_inst_salud;
		}
		set
		{
			if (!_cod_inst_salud.Equals(value))
			{
				_cod_inst_salud = value;
			}
		}
	}

	[Column(Storage = "_cod_afp", DbType = "Int")]
	public int? cod_afp
	{
		get
		{
			return _cod_afp;
		}
		set
		{
			if (!_cod_afp.Equals(value))
			{
				_cod_afp = value;
			}
		}
	}

	[Column(Storage = "_ubi_cod", DbType = "Char(8)")]
	public string ubi_cod
	{
		get
		{
			return _ubi_cod;
		}
		set
		{
			if (!string.Equals(_ubi_cod, value))
			{
				_ubi_cod = value;
			}
		}
	}

	[Column(Storage = "_Foto", DbType = "Image", UpdateCheck = UpdateCheck.Never)]
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

	[Column(Storage = "_pers_fec_afilia_afp", DbType = "DateTime")]
	public DateTime? pers_fec_afilia_afp
	{
		get
		{
			return _pers_fec_afilia_afp;
		}
		set
		{
			if (!_pers_fec_afilia_afp.Equals(value))
			{
				_pers_fec_afilia_afp = value;
			}
		}
	}

	[Column(Storage = "_tipo_sangre", DbType = "Char(2)")]
	public string tipo_sangre
	{
		get
		{
			return _tipo_sangre;
		}
		set
		{
			if (!string.Equals(_tipo_sangre, value))
			{
				_tipo_sangre = value;
			}
		}
	}

	[Column(Storage = "_pers_estado", DbType = "Char(1)")]
	public char? pers_estado
	{
		get
		{
			return _pers_estado;
		}
		set
		{
			if (!_pers_estado.Equals(value))
			{
				_pers_estado = value;
			}
		}
	}

	[Column(Storage = "_DEC_LEY", DbType = "Char(5)")]
	public string DEC_LEY
	{
		get
		{
			return _DEC_LEY;
		}
		set
		{
			if (!string.Equals(_DEC_LEY, value))
			{
				_DEC_LEY = value;
			}
		}
	}

	[Column(Storage = "_idHorario", DbType = "SmallInt")]
	public short? idHorario
	{
		get
		{
			return _idHorario;
		}
		set
		{
			if (!_idHorario.Equals(value))
			{
				_idHorario = value;
			}
		}
	}

	[Column(Storage = "_TipoEmpleado", DbType = "Char(1)")]
	public char? TipoEmpleado
	{
		get
		{
			return _TipoEmpleado;
		}
		set
		{
			if (!_TipoEmpleado.Equals(value))
			{
				_TipoEmpleado = value;
			}
		}
	}
}
