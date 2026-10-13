using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_RRHH_FichaSocial")]
public class vs_RRHH_FichaSocial
{
	private int? _edad;

	private int _IdEmpleado;

	private string _Apellido_Paterno;

	private string _Apellido_Materno;

	private string _Nombres;

	private char? _Sexo;

	private string _Descripcion;

	private string _NumDocID;

	private DateTime? _FechaNacimiento;

	private string _Telefono;

	private string _Fax;

	private string _NumCelular;

	private string _FonoCentroLab;

	private Binary _Foto;

	private string _Nacionalidad;

	private decimal? _Remuneracion;

	private decimal? _Honorarios;

	private decimal? _AlqPredio;

	private decimal? _AlqBienes;

	private decimal? _CapitalesColocados;

	private decimal? _Dietas;

	private decimal? _Negocios;

	private decimal? _IngreOtro;

	private decimal? _TotalIngresos;

	private decimal? _IngresoMiembros;

	private string _NumPersonaAportan;

	private decimal? _Alimentacion;

	private decimal? _Vivienda;

	private decimal? _Educacion;

	private decimal? _Salud;

	private decimal? _Vestido;

	private decimal? _Recreacion;

	private decimal? _Prestamos;

	private decimal? _otrosegreso;

	private decimal? _TotalEgresos;

	private string _DescripEstCivil;

	private string _Descrip_Discapacidad;

	private string _desdepartamento;

	private string _desprovincia;

	private string _desdistrito;

	private string _desdepartamentoCasa;

	private string _desprovinciaCasa;

	private string _desdistritoCasa;

	private string _AreaOrganizacional;

	private string _CondicionLaboral;

	private DateTime? _FechaIngreso;

	private string _Profesion;

	private string _Cargo;

	private DateTime? _FechaRegistro;

	private string _DescripViveCon;

	private bool? _JefeHogar;

	private string _CargaFam;

	private string _NumHijos;

	private string _ObsFam;

	private string _DescripTenencia;

	private string _DescripTipo;

	private string _DescripMaterial;

	private string _DescripConserva;

	private string _NumDormitorio;

	private string _NumServHig;

	private string _DescripUbicacion;

	private string _DescripAlumbrado;

	private string _DescripAgua;

	private string _DescripExcretas;

	private string _GradoInstruccion;

	private string _ExpSocial;

	private string _Direccion;

	private string _AspecSalud;

	private string _AspecRecreacion;

	private string _AspecEducacion;

	private string _AspecPsico;

	private string _AspecSocial;

	private string _DiagnosSocial;

	[Column(Storage = "_edad", DbType = "Int")]
	public int? edad
	{
		get
		{
			return _edad;
		}
		set
		{
			if (!_edad.Equals(value))
			{
				_edad = value;
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

	[Column(Storage = "_Descripcion", DbType = "VarChar(40)")]
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

	[Column(Storage = "_Remuneracion", DbType = "Decimal(8,2)")]
	public decimal? Remuneracion
	{
		get
		{
			return _Remuneracion;
		}
		set
		{
			if (!_Remuneracion.Equals(value))
			{
				_Remuneracion = value;
			}
		}
	}

	[Column(Storage = "_Honorarios", DbType = "Decimal(8,2)")]
	public decimal? Honorarios
	{
		get
		{
			return _Honorarios;
		}
		set
		{
			if (!_Honorarios.Equals(value))
			{
				_Honorarios = value;
			}
		}
	}

	[Column(Storage = "_AlqPredio", DbType = "Decimal(8,2)")]
	public decimal? AlqPredio
	{
		get
		{
			return _AlqPredio;
		}
		set
		{
			if (!_AlqPredio.Equals(value))
			{
				_AlqPredio = value;
			}
		}
	}

	[Column(Storage = "_AlqBienes", DbType = "Decimal(8,2)")]
	public decimal? AlqBienes
	{
		get
		{
			return _AlqBienes;
		}
		set
		{
			if (!_AlqBienes.Equals(value))
			{
				_AlqBienes = value;
			}
		}
	}

	[Column(Storage = "_CapitalesColocados", DbType = "Decimal(8,2)")]
	public decimal? CapitalesColocados
	{
		get
		{
			return _CapitalesColocados;
		}
		set
		{
			if (!_CapitalesColocados.Equals(value))
			{
				_CapitalesColocados = value;
			}
		}
	}

	[Column(Storage = "_Dietas", DbType = "Decimal(8,2)")]
	public decimal? Dietas
	{
		get
		{
			return _Dietas;
		}
		set
		{
			if (!_Dietas.Equals(value))
			{
				_Dietas = value;
			}
		}
	}

	[Column(Storage = "_Negocios", DbType = "Decimal(8,2)")]
	public decimal? Negocios
	{
		get
		{
			return _Negocios;
		}
		set
		{
			if (!_Negocios.Equals(value))
			{
				_Negocios = value;
			}
		}
	}

	[Column(Storage = "_IngreOtro", DbType = "Decimal(8,2)")]
	public decimal? IngreOtro
	{
		get
		{
			return _IngreOtro;
		}
		set
		{
			if (!_IngreOtro.Equals(value))
			{
				_IngreOtro = value;
			}
		}
	}

	[Column(Storage = "_TotalIngresos", DbType = "Decimal(15,2)")]
	public decimal? TotalIngresos
	{
		get
		{
			return _TotalIngresos;
		}
		set
		{
			if (!_TotalIngresos.Equals(value))
			{
				_TotalIngresos = value;
			}
		}
	}

	[Column(Storage = "_IngresoMiembros", DbType = "Decimal(8,2)")]
	public decimal? IngresoMiembros
	{
		get
		{
			return _IngresoMiembros;
		}
		set
		{
			if (!_IngresoMiembros.Equals(value))
			{
				_IngresoMiembros = value;
			}
		}
	}

	[Column(Storage = "_NumPersonaAportan", DbType = "VarChar(2)")]
	public string NumPersonaAportan
	{
		get
		{
			return _NumPersonaAportan;
		}
		set
		{
			if (!string.Equals(_NumPersonaAportan, value))
			{
				_NumPersonaAportan = value;
			}
		}
	}

	[Column(Storage = "_Alimentacion", DbType = "Decimal(8,2)")]
	public decimal? Alimentacion
	{
		get
		{
			return _Alimentacion;
		}
		set
		{
			if (!_Alimentacion.Equals(value))
			{
				_Alimentacion = value;
			}
		}
	}

	[Column(Storage = "_Vivienda", DbType = "Decimal(8,2)")]
	public decimal? Vivienda
	{
		get
		{
			return _Vivienda;
		}
		set
		{
			if (!_Vivienda.Equals(value))
			{
				_Vivienda = value;
			}
		}
	}

	[Column(Storage = "_Educacion", DbType = "Decimal(8,2)")]
	public decimal? Educacion
	{
		get
		{
			return _Educacion;
		}
		set
		{
			if (!_Educacion.Equals(value))
			{
				_Educacion = value;
			}
		}
	}

	[Column(Storage = "_Salud", DbType = "Decimal(8,2)")]
	public decimal? Salud
	{
		get
		{
			return _Salud;
		}
		set
		{
			if (!_Salud.Equals(value))
			{
				_Salud = value;
			}
		}
	}

	[Column(Storage = "_Vestido", DbType = "Decimal(8,2)")]
	public decimal? Vestido
	{
		get
		{
			return _Vestido;
		}
		set
		{
			if (!_Vestido.Equals(value))
			{
				_Vestido = value;
			}
		}
	}

	[Column(Storage = "_Recreacion", DbType = "Decimal(8,2)")]
	public decimal? Recreacion
	{
		get
		{
			return _Recreacion;
		}
		set
		{
			if (!_Recreacion.Equals(value))
			{
				_Recreacion = value;
			}
		}
	}

	[Column(Storage = "_Prestamos", DbType = "Decimal(8,2)")]
	public decimal? Prestamos
	{
		get
		{
			return _Prestamos;
		}
		set
		{
			if (!_Prestamos.Equals(value))
			{
				_Prestamos = value;
			}
		}
	}

	[Column(Storage = "_otrosegreso", DbType = "Decimal(8,2)")]
	public decimal? otrosegreso
	{
		get
		{
			return _otrosegreso;
		}
		set
		{
			if (!_otrosegreso.Equals(value))
			{
				_otrosegreso = value;
			}
		}
	}

	[Column(Storage = "_TotalEgresos", DbType = "Decimal(15,2)")]
	public decimal? TotalEgresos
	{
		get
		{
			return _TotalEgresos;
		}
		set
		{
			if (!_TotalEgresos.Equals(value))
			{
				_TotalEgresos = value;
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

	[Column(Storage = "_Descrip_Discapacidad", DbType = "VarChar(12)")]
	public string Descrip_Discapacidad
	{
		get
		{
			return _Descrip_Discapacidad;
		}
		set
		{
			if (!string.Equals(_Descrip_Discapacidad, value))
			{
				_Descrip_Discapacidad = value;
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

	[Column(Storage = "_desdepartamentoCasa", DbType = "VarChar(120)")]
	public string desdepartamentoCasa
	{
		get
		{
			return _desdepartamentoCasa;
		}
		set
		{
			if (!string.Equals(_desdepartamentoCasa, value))
			{
				_desdepartamentoCasa = value;
			}
		}
	}

	[Column(Storage = "_desprovinciaCasa", DbType = "VarChar(120)")]
	public string desprovinciaCasa
	{
		get
		{
			return _desprovinciaCasa;
		}
		set
		{
			if (!string.Equals(_desprovinciaCasa, value))
			{
				_desprovinciaCasa = value;
			}
		}
	}

	[Column(Storage = "_desdistritoCasa", DbType = "VarChar(120)")]
	public string desdistritoCasa
	{
		get
		{
			return _desdistritoCasa;
		}
		set
		{
			if (!string.Equals(_desdistritoCasa, value))
			{
				_desdistritoCasa = value;
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

	[Column(Storage = "_CondicionLaboral", DbType = "VarChar(30)")]
	public string CondicionLaboral
	{
		get
		{
			return _CondicionLaboral;
		}
		set
		{
			if (!string.Equals(_CondicionLaboral, value))
			{
				_CondicionLaboral = value;
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

	[Column(Storage = "_Profesion", DbType = "VarChar(80)")]
	public string Profesion
	{
		get
		{
			return _Profesion;
		}
		set
		{
			if (!string.Equals(_Profesion, value))
			{
				_Profesion = value;
			}
		}
	}

	[Column(Storage = "_Cargo", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string Cargo
	{
		get
		{
			return _Cargo;
		}
		set
		{
			if (!string.Equals(_Cargo, value))
			{
				_Cargo = value;
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

	[Column(Storage = "_DescripViveCon", DbType = "VarChar(27)")]
	public string DescripViveCon
	{
		get
		{
			return _DescripViveCon;
		}
		set
		{
			if (!string.Equals(_DescripViveCon, value))
			{
				_DescripViveCon = value;
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

	[Column(Storage = "_NumHijos", DbType = "VarChar(2)")]
	public string NumHijos
	{
		get
		{
			return _NumHijos;
		}
		set
		{
			if (!string.Equals(_NumHijos, value))
			{
				_NumHijos = value;
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

	[Column(Storage = "_DescripTenencia", DbType = "VarChar(30)")]
	public string DescripTenencia
	{
		get
		{
			return _DescripTenencia;
		}
		set
		{
			if (!string.Equals(_DescripTenencia, value))
			{
				_DescripTenencia = value;
			}
		}
	}

	[Column(Storage = "_DescripTipo", DbType = "VarChar(20)")]
	public string DescripTipo
	{
		get
		{
			return _DescripTipo;
		}
		set
		{
			if (!string.Equals(_DescripTipo, value))
			{
				_DescripTipo = value;
			}
		}
	}

	[Column(Storage = "_DescripMaterial", DbType = "VarChar(12)")]
	public string DescripMaterial
	{
		get
		{
			return _DescripMaterial;
		}
		set
		{
			if (!string.Equals(_DescripMaterial, value))
			{
				_DescripMaterial = value;
			}
		}
	}

	[Column(Storage = "_DescripConserva", DbType = "VarChar(17)")]
	public string DescripConserva
	{
		get
		{
			return _DescripConserva;
		}
		set
		{
			if (!string.Equals(_DescripConserva, value))
			{
				_DescripConserva = value;
			}
		}
	}

	[Column(Storage = "_NumDormitorio", DbType = "VarChar(2)")]
	public string NumDormitorio
	{
		get
		{
			return _NumDormitorio;
		}
		set
		{
			if (!string.Equals(_NumDormitorio, value))
			{
				_NumDormitorio = value;
			}
		}
	}

	[Column(Storage = "_NumServHig", DbType = "VarChar(2)")]
	public string NumServHig
	{
		get
		{
			return _NumServHig;
		}
		set
		{
			if (!string.Equals(_NumServHig, value))
			{
				_NumServHig = value;
			}
		}
	}

	[Column(Storage = "_DescripUbicacion", DbType = "VarChar(22)")]
	public string DescripUbicacion
	{
		get
		{
			return _DescripUbicacion;
		}
		set
		{
			if (!string.Equals(_DescripUbicacion, value))
			{
				_DescripUbicacion = value;
			}
		}
	}

	[Column(Storage = "_DescripAlumbrado", DbType = "VarChar(20)")]
	public string DescripAlumbrado
	{
		get
		{
			return _DescripAlumbrado;
		}
		set
		{
			if (!string.Equals(_DescripAlumbrado, value))
			{
				_DescripAlumbrado = value;
			}
		}
	}

	[Column(Storage = "_DescripAgua", DbType = "VarChar(33)")]
	public string DescripAgua
	{
		get
		{
			return _DescripAgua;
		}
		set
		{
			if (!string.Equals(_DescripAgua, value))
			{
				_DescripAgua = value;
			}
		}
	}

	[Column(Storage = "_DescripExcretas", DbType = "VarChar(33)")]
	public string DescripExcretas
	{
		get
		{
			return _DescripExcretas;
		}
		set
		{
			if (!string.Equals(_DescripExcretas, value))
			{
				_DescripExcretas = value;
			}
		}
	}

	[Column(Storage = "_GradoInstruccion", DbType = "VarChar(80)")]
	public string GradoInstruccion
	{
		get
		{
			return _GradoInstruccion;
		}
		set
		{
			if (!string.Equals(_GradoInstruccion, value))
			{
				_GradoInstruccion = value;
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

	[Column(Storage = "_AspecSalud", DbType = "VarChar(1000)")]
	public string AspecSalud
	{
		get
		{
			return _AspecSalud;
		}
		set
		{
			if (!string.Equals(_AspecSalud, value))
			{
				_AspecSalud = value;
			}
		}
	}

	[Column(Storage = "_AspecRecreacion", DbType = "VarChar(1000)")]
	public string AspecRecreacion
	{
		get
		{
			return _AspecRecreacion;
		}
		set
		{
			if (!string.Equals(_AspecRecreacion, value))
			{
				_AspecRecreacion = value;
			}
		}
	}

	[Column(Storage = "_AspecEducacion", DbType = "VarChar(1000)")]
	public string AspecEducacion
	{
		get
		{
			return _AspecEducacion;
		}
		set
		{
			if (!string.Equals(_AspecEducacion, value))
			{
				_AspecEducacion = value;
			}
		}
	}

	[Column(Storage = "_AspecPsico", DbType = "VarChar(1000)")]
	public string AspecPsico
	{
		get
		{
			return _AspecPsico;
		}
		set
		{
			if (!string.Equals(_AspecPsico, value))
			{
				_AspecPsico = value;
			}
		}
	}

	[Column(Storage = "_AspecSocial", DbType = "VarChar(1000)")]
	public string AspecSocial
	{
		get
		{
			return _AspecSocial;
		}
		set
		{
			if (!string.Equals(_AspecSocial, value))
			{
				_AspecSocial = value;
			}
		}
	}

	[Column(Storage = "_DiagnosSocial", DbType = "VarChar(1000)")]
	public string DiagnosSocial
	{
		get
		{
			return _DiagnosSocial;
		}
		set
		{
			if (!string.Equals(_DiagnosSocial, value))
			{
				_DiagnosSocial = value;
			}
		}
	}
}
