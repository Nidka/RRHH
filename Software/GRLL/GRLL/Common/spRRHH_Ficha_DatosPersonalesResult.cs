using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spRRHH_Ficha_DatosPersonalesResult
{
	private int? _edadEmpleado;

	private string _Nombres;

	private string _Apellido_Paterno;

	private string _Apellido_Materno;

	private char? _sexo;

	private string _NumDocId;

	private string _TipoDoc;

	private string _Nacionalidad;

	private DateTime? _FechaNacimiento;

	private string _Telefono;

	private string _Fax;

	private string _NumCelular;

	private string _FonoCentroLab;

	private string _EstadoCivil;

	private string _Discapacidad;

	private string _gradoInstruccion;

	private string _desdepartamento;

	private string _desprovincia;

	private string _desdistrito;

	private string _depCasa;

	private string _ProvCasa;

	private string _DistCasa;

	private string _direccion;

	private string _NumRUC;

	private string _NumLibretaMilitar;

	private Binary _foto;

	private int _idempleado;

	private DateTime? _FechaRegistro;

	private string _ExpSocial;

	private string _brevete;

	private string _DescripTS;

	private string _Descripvivecon;

	private bool? _JefeHogar;

	private string _CargaFam;

	private string _Numhijos;

	private string _ObsFam;

	private string _TipoFamDescrip;

	private string _relacParejaDescrip;

	private string _RelacPHDescrip;

	private string _RelacHermanoDescrip;

	private string _com1;

	private string _com2;

	private string _afec1;

	private string _afec2;

	private string _decis1;

	private string _decis2;

	private string _soc1;

	private string _soc2;

	private string _soc3;

	private string _respues1;

	private string _respues2;

	private string _respues3;

	private string _PrincipProblemas;

	private string _PropMejoraInstitu;

	private string _hobby;

	private string _ActRecreaInstitu;

	private string _AcudeEnfermDescrip;

	private bool? _enfercronica;

	private string _enfercronicadescrip;

	private bool? _famdiscapacidad;

	private string _famdiscapdescrip;

	private bool? _alergico;

	private string _alergicodescrip;

	[Column(Storage = "_edadEmpleado", DbType = "Int")]
	public int? edadEmpleado
	{
		get
		{
			return _edadEmpleado;
		}
		set
		{
			if (!_edadEmpleado.Equals(value))
			{
				_edadEmpleado = value;
			}
		}
	}

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

	[Column(Storage = "_Apellido_Paterno", DbType = "VarChar(30)")]
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

	[Column(Storage = "_sexo", DbType = "Char(1)")]
	public char? sexo
	{
		get
		{
			return _sexo;
		}
		set
		{
			if (!_sexo.Equals(value))
			{
				_sexo = value;
			}
		}
	}

	[Column(Storage = "_NumDocId", DbType = "Char(12)")]
	public string NumDocId
	{
		get
		{
			return _NumDocId;
		}
		set
		{
			if (!string.Equals(_NumDocId, value))
			{
				_NumDocId = value;
			}
		}
	}

	[Column(Storage = "_TipoDoc", DbType = "VarChar(40)")]
	public string TipoDoc
	{
		get
		{
			return _TipoDoc;
		}
		set
		{
			if (!string.Equals(_TipoDoc, value))
			{
				_TipoDoc = value;
			}
		}
	}

	[Column(Storage = "_Nacionalidad", DbType = "VarChar(50)")]
	public string Nacionalidad
	{
		get
		{
			return _Nacionalidad;
		}
		set
		{
			if (!string.Equals(_Nacionalidad, value))
			{
				_Nacionalidad = value;
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

	[Column(Storage = "_NumCelular", DbType = "VarChar(15)")]
	public string NumCelular
	{
		get
		{
			return _NumCelular;
		}
		set
		{
			if (!string.Equals(_NumCelular, value))
			{
				_NumCelular = value;
			}
		}
	}

	[Column(Storage = "_FonoCentroLab", DbType = "VarChar(15)")]
	public string FonoCentroLab
	{
		get
		{
			return _FonoCentroLab;
		}
		set
		{
			if (!string.Equals(_FonoCentroLab, value))
			{
				_FonoCentroLab = value;
			}
		}
	}

	[Column(Storage = "_EstadoCivil", DbType = "VarChar(11)")]
	public string EstadoCivil
	{
		get
		{
			return _EstadoCivil;
		}
		set
		{
			if (!string.Equals(_EstadoCivil, value))
			{
				_EstadoCivil = value;
			}
		}
	}

	[Column(Storage = "_Discapacidad", DbType = "VarChar(12)")]
	public string Discapacidad
	{
		get
		{
			return _Discapacidad;
		}
		set
		{
			if (!string.Equals(_Discapacidad, value))
			{
				_Discapacidad = value;
			}
		}
	}

	[Column(Storage = "_gradoInstruccion", DbType = "VarChar(80)")]
	public string gradoInstruccion
	{
		get
		{
			return _gradoInstruccion;
		}
		set
		{
			if (!string.Equals(_gradoInstruccion, value))
			{
				_gradoInstruccion = value;
			}
		}
	}

	[Column(Storage = "_desdepartamento", DbType = "VarChar(120)")]
	public string desdepartamento
	{
		get
		{
			return _desdepartamento;
		}
		set
		{
			if (!string.Equals(_desdepartamento, value))
			{
				_desdepartamento = value;
			}
		}
	}

	[Column(Storage = "_desprovincia", DbType = "VarChar(120)")]
	public string desprovincia
	{
		get
		{
			return _desprovincia;
		}
		set
		{
			if (!string.Equals(_desprovincia, value))
			{
				_desprovincia = value;
			}
		}
	}

	[Column(Storage = "_desdistrito", DbType = "VarChar(120)")]
	public string desdistrito
	{
		get
		{
			return _desdistrito;
		}
		set
		{
			if (!string.Equals(_desdistrito, value))
			{
				_desdistrito = value;
			}
		}
	}

	[Column(Storage = "_depCasa", DbType = "VarChar(120)")]
	public string depCasa
	{
		get
		{
			return _depCasa;
		}
		set
		{
			if (!string.Equals(_depCasa, value))
			{
				_depCasa = value;
			}
		}
	}

	[Column(Storage = "_ProvCasa", DbType = "VarChar(120)")]
	public string ProvCasa
	{
		get
		{
			return _ProvCasa;
		}
		set
		{
			if (!string.Equals(_ProvCasa, value))
			{
				_ProvCasa = value;
			}
		}
	}

	[Column(Storage = "_DistCasa", DbType = "VarChar(120)")]
	public string DistCasa
	{
		get
		{
			return _DistCasa;
		}
		set
		{
			if (!string.Equals(_DistCasa, value))
			{
				_DistCasa = value;
			}
		}
	}

	[Column(Storage = "_direccion", DbType = "VarChar(100)")]
	public string direccion
	{
		get
		{
			return _direccion;
		}
		set
		{
			if (!string.Equals(_direccion, value))
			{
				_direccion = value;
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

	[Column(Storage = "_NumLibretaMilitar", DbType = "VarChar(10)")]
	public string NumLibretaMilitar
	{
		get
		{
			return _NumLibretaMilitar;
		}
		set
		{
			if (!string.Equals(_NumLibretaMilitar, value))
			{
				_NumLibretaMilitar = value;
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

	[Column(Storage = "_DescripTS", DbType = "VarChar(5)")]
	public string DescripTS
	{
		get
		{
			return _DescripTS;
		}
		set
		{
			if (!string.Equals(_DescripTS, value))
			{
				_DescripTS = value;
			}
		}
	}

	[Column(Storage = "_Descripvivecon", DbType = "VarChar(27)")]
	public string Descripvivecon
	{
		get
		{
			return _Descripvivecon;
		}
		set
		{
			if (!string.Equals(_Descripvivecon, value))
			{
				_Descripvivecon = value;
			}
		}
	}

	[Column(Storage = "_JefeHogar", DbType = "Bit")]
	public bool? JefeHogar
	{
		get
		{
			return _JefeHogar;
		}
		set
		{
			if (!_JefeHogar.Equals(value))
			{
				_JefeHogar = value;
			}
		}
	}

	[Column(Storage = "_CargaFam", DbType = "VarChar(2)")]
	public string CargaFam
	{
		get
		{
			return _CargaFam;
		}
		set
		{
			if (!string.Equals(_CargaFam, value))
			{
				_CargaFam = value;
			}
		}
	}

	[Column(Storage = "_Numhijos", DbType = "VarChar(2)")]
	public string Numhijos
	{
		get
		{
			return _Numhijos;
		}
		set
		{
			if (!string.Equals(_Numhijos, value))
			{
				_Numhijos = value;
			}
		}
	}

	[Column(Storage = "_ObsFam", DbType = "NVarChar(500)")]
	public string ObsFam
	{
		get
		{
			return _ObsFam;
		}
		set
		{
			if (!string.Equals(_ObsFam, value))
			{
				_ObsFam = value;
			}
		}
	}

	[Column(Storage = "_TipoFamDescrip", DbType = "VarChar(10)")]
	public string TipoFamDescrip
	{
		get
		{
			return _TipoFamDescrip;
		}
		set
		{
			if (!string.Equals(_TipoFamDescrip, value))
			{
				_TipoFamDescrip = value;
			}
		}
	}

	[Column(Storage = "_relacParejaDescrip", DbType = "VarChar(12)")]
	public string relacParejaDescrip
	{
		get
		{
			return _relacParejaDescrip;
		}
		set
		{
			if (!string.Equals(_relacParejaDescrip, value))
			{
				_relacParejaDescrip = value;
			}
		}
	}

	[Column(Storage = "_RelacPHDescrip", DbType = "VarChar(14)")]
	public string RelacPHDescrip
	{
		get
		{
			return _RelacPHDescrip;
		}
		set
		{
			if (!string.Equals(_RelacPHDescrip, value))
			{
				_RelacPHDescrip = value;
			}
		}
	}

	[Column(Storage = "_RelacHermanoDescrip", DbType = "VarChar(12)")]
	public string RelacHermanoDescrip
	{
		get
		{
			return _RelacHermanoDescrip;
		}
		set
		{
			if (!string.Equals(_RelacHermanoDescrip, value))
			{
				_RelacHermanoDescrip = value;
			}
		}
	}

	[Column(Storage = "_com1", DbType = "VarChar(2)")]
	public string com1
	{
		get
		{
			return _com1;
		}
		set
		{
			if (!string.Equals(_com1, value))
			{
				_com1 = value;
			}
		}
	}

	[Column(Storage = "_com2", DbType = "VarChar(2)")]
	public string com2
	{
		get
		{
			return _com2;
		}
		set
		{
			if (!string.Equals(_com2, value))
			{
				_com2 = value;
			}
		}
	}

	[Column(Storage = "_afec1", DbType = "VarChar(2)")]
	public string afec1
	{
		get
		{
			return _afec1;
		}
		set
		{
			if (!string.Equals(_afec1, value))
			{
				_afec1 = value;
			}
		}
	}

	[Column(Storage = "_afec2", DbType = "VarChar(2)")]
	public string afec2
	{
		get
		{
			return _afec2;
		}
		set
		{
			if (!string.Equals(_afec2, value))
			{
				_afec2 = value;
			}
		}
	}

	[Column(Storage = "_decis1", DbType = "VarChar(2)")]
	public string decis1
	{
		get
		{
			return _decis1;
		}
		set
		{
			if (!string.Equals(_decis1, value))
			{
				_decis1 = value;
			}
		}
	}

	[Column(Storage = "_decis2", DbType = "VarChar(2)")]
	public string decis2
	{
		get
		{
			return _decis2;
		}
		set
		{
			if (!string.Equals(_decis2, value))
			{
				_decis2 = value;
			}
		}
	}

	[Column(Storage = "_soc1", DbType = "VarChar(2)")]
	public string soc1
	{
		get
		{
			return _soc1;
		}
		set
		{
			if (!string.Equals(_soc1, value))
			{
				_soc1 = value;
			}
		}
	}

	[Column(Storage = "_soc2", DbType = "VarChar(2)")]
	public string soc2
	{
		get
		{
			return _soc2;
		}
		set
		{
			if (!string.Equals(_soc2, value))
			{
				_soc2 = value;
			}
		}
	}

	[Column(Storage = "_soc3", DbType = "VarChar(2)")]
	public string soc3
	{
		get
		{
			return _soc3;
		}
		set
		{
			if (!string.Equals(_soc3, value))
			{
				_soc3 = value;
			}
		}
	}

	[Column(Storage = "_respues1", DbType = "VarChar(83)")]
	public string respues1
	{
		get
		{
			return _respues1;
		}
		set
		{
			if (!string.Equals(_respues1, value))
			{
				_respues1 = value;
			}
		}
	}

	[Column(Storage = "_respues2", DbType = "VarChar(22)")]
	public string respues2
	{
		get
		{
			return _respues2;
		}
		set
		{
			if (!string.Equals(_respues2, value))
			{
				_respues2 = value;
			}
		}
	}

	[Column(Storage = "_respues3", DbType = "VarChar(23)")]
	public string respues3
	{
		get
		{
			return _respues3;
		}
		set
		{
			if (!string.Equals(_respues3, value))
			{
				_respues3 = value;
			}
		}
	}

	[Column(Storage = "_PrincipProblemas", DbType = "VarChar(400)")]
	public string PrincipProblemas
	{
		get
		{
			return _PrincipProblemas;
		}
		set
		{
			if (!string.Equals(_PrincipProblemas, value))
			{
				_PrincipProblemas = value;
			}
		}
	}

	[Column(Storage = "_PropMejoraInstitu", DbType = "VarChar(400)")]
	public string PropMejoraInstitu
	{
		get
		{
			return _PropMejoraInstitu;
		}
		set
		{
			if (!string.Equals(_PropMejoraInstitu, value))
			{
				_PropMejoraInstitu = value;
			}
		}
	}

	[Column(Storage = "_hobby", DbType = "VarChar(400)")]
	public string hobby
	{
		get
		{
			return _hobby;
		}
		set
		{
			if (!string.Equals(_hobby, value))
			{
				_hobby = value;
			}
		}
	}

	[Column(Storage = "_ActRecreaInstitu", DbType = "VarChar(400)")]
	public string ActRecreaInstitu
	{
		get
		{
			return _ActRecreaInstitu;
		}
		set
		{
			if (!string.Equals(_ActRecreaInstitu, value))
			{
				_ActRecreaInstitu = value;
			}
		}
	}

	[Column(Storage = "_AcudeEnfermDescrip", DbType = "VarChar(16)")]
	public string AcudeEnfermDescrip
	{
		get
		{
			return _AcudeEnfermDescrip;
		}
		set
		{
			if (!string.Equals(_AcudeEnfermDescrip, value))
			{
				_AcudeEnfermDescrip = value;
			}
		}
	}

	[Column(Storage = "_enfercronica", DbType = "Bit")]
	public bool? enfercronica
	{
		get
		{
			return _enfercronica;
		}
		set
		{
			if (!_enfercronica.Equals(value))
			{
				_enfercronica = value;
			}
		}
	}

	[Column(Storage = "_enfercronicadescrip", DbType = "VarChar(200)")]
	public string enfercronicadescrip
	{
		get
		{
			return _enfercronicadescrip;
		}
		set
		{
			if (!string.Equals(_enfercronicadescrip, value))
			{
				_enfercronicadescrip = value;
			}
		}
	}

	[Column(Storage = "_famdiscapacidad", DbType = "Bit")]
	public bool? famdiscapacidad
	{
		get
		{
			return _famdiscapacidad;
		}
		set
		{
			if (!_famdiscapacidad.Equals(value))
			{
				_famdiscapacidad = value;
			}
		}
	}

	[Column(Storage = "_famdiscapdescrip", DbType = "VarChar(200)")]
	public string famdiscapdescrip
	{
		get
		{
			return _famdiscapdescrip;
		}
		set
		{
			if (!string.Equals(_famdiscapdescrip, value))
			{
				_famdiscapdescrip = value;
			}
		}
	}

	[Column(Storage = "_alergico", DbType = "Bit")]
	public bool? alergico
	{
		get
		{
			return _alergico;
		}
		set
		{
			if (!_alergico.Equals(value))
			{
				_alergico = value;
			}
		}
	}

	[Column(Storage = "_alergicodescrip", DbType = "VarChar(200)")]
	public string alergicodescrip
	{
		get
		{
			return _alergicodescrip;
		}
		set
		{
			if (!string.Equals(_alergicodescrip, value))
			{
				_alergicodescrip = value;
			}
		}
	}
}
