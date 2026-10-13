using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Empleado")]
public class Empleado : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdEmpleado;

	private int _Year;

	private int _idAreaOrganiz;

	private int? _IdPersona;

	private string _ExpSocial;

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

	private int? _IdDiscapacidad;

	private string _Profesion;

	private bool? _JefeHogar;

	private string _CargaFam;

	private string _NumHijos;

	private int? _IdViveCon;

	private string _ObsFam;

	private string _AspecSalud;

	private string _AspecEducacion;

	private string _AspecRecreacion;

	private string _AspecPsico;

	private string _AspecSocial;

	private string _DiagnosSocial;

	private int? _IdNacionalidad;

	private string _NumLibretaMilitar;

	private string _GradoInstruccion;

	private int? _IdRegimenPen;

	private string _NumRUC;

	private string _NumAutogenSalud;

	private string _NumResolCese;

	private DateTime? _FechaResolCese;

	private string _NumResol20530;

	private DateTime? _FechaResol20530;

	private string _NumResolPenMen;

	private DateTime? _FechaResolPenMen;

	private string _NumResoIngreEsta;

	private DateTime? _FechaIngreEstado;

	private DateTime? _FechaResolIngreEsta;

	private string _NumResoIngreInstitu;

	private DateTime? _FechaResoIngreInstitu;

	private int? _idHorario;

	private Guid? _Userid;

	private int? _idLocal;

	private EntitySet<Vivienda> _Viviendas;

	private EntitySet<Actividad> _Actividads;

	private EntitySet<Archivo> _Archivos;

	private EntitySet<Capacitacion> _Capacitacions;

	private EntitySet<CJROperador> _CJROperadors;

	private EntitySet<Comportamiento> _Comportamientos;

	private EntitySet<Egreso> _Egresos;

	private EntitySet<Empleado_Area> _Empleado_Areas;

	private EntitySet<ExpLaboral> _ExpLaborals;

	private EntitySet<Familiar> _Familiars;

	private EntitySet<Ingreso> _Ingresos;

	private EntitySet<Marcacion> _Marcacions;

	private EntitySet<PeriodoLaboral> _PeriodoLaborals;

	private EntitySet<Permiso> _Permisos;

	private EntitySet<RRHH_AspSocio> _RRHH_AspSocios;

	private EntitySet<RRHH_DinamicaFamiliar> _RRHH_DinamicaFamiliars;

	private EntitySet<RRHH_FuncFam> _RRHH_FuncFams;

	private EntitySet<RRHH_Salud> _RRHH_Saluds;

	private EntitySet<TitulosEmpleado> _TitulosEmpleados;

	private EntitySet<Usuario> _Usuarios;

	private EntitySet<RRHH_Asegurado> _RRHH_Asegurados;

	private EntitySet<EstudiosRealizado> _EstudiosRealizados;

	private EntitySet<Asistencia> _Asistencias;

	private EntitySet<Rotacion> _Rotacions;

	private EntitySet<Resolucion> _Resolucions;

	private EntitySet<HorarioTemporal> _HorarioTemporals;

	private EntityRef<EstructOrganiz> _EstructOrganiz;

	private EntityRef<AFP> _AFP;

	private EntityRef<Cargo> _Cargo;

	private EntityRef<Discapacidad> _Discapacidad;

	private EntityRef<EstadoCivil> _EstadoCivil;

	private EntityRef<Horario> _Horario;

	private EntityRef<Nacionalidad> _Nacionalidad;

	private EntityRef<Persona> _Persona;

	private EntityRef<RegimenPension> _RegimenPension;

	private EntityRef<Seguro> _Seguro;

	private EntityRef<TipoTrabajador> _TipoTrabajador;

	private EntityRef<TipoSangre> _TipoSangre;

	private EntityRef<ViveCon> _ViveCon;

	private EntityRef<Local> _Local;

	[Column(Storage = "_IdEmpleado", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_IdEmpleado = value;
				SendPropertyChanged("IdEmpleado");
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
				if (_EstructOrganiz.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Year = value;
				SendPropertyChanged("Year");
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
				if (_EstructOrganiz.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idAreaOrganiz = value;
				SendPropertyChanged("idAreaOrganiz");
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
				if (_Persona.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdPersona = value;
				SendPropertyChanged("IdPersona");
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
				SendPropertyChanging();
				_ExpSocial = value;
				SendPropertyChanged("ExpSocial");
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
				SendPropertyChanging();
				_FechaIngreso = value;
				SendPropertyChanged("FechaIngreso");
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
				if (_AFP.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdAFP = value;
				SendPropertyChanged("IdAFP");
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
				SendPropertyChanging();
				_Brevete = value;
				SendPropertyChanged("Brevete");
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
				if (_EstadoCivil.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdEstadoCivil = value;
				SendPropertyChanged("IdEstadoCivil");
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
				SendPropertyChanging();
				_Sexo = value;
				SendPropertyChanged("Sexo");
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
				SendPropertyChanging();
				_CtaCorriente = value;
				SendPropertyChanged("CtaCorriente");
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
				SendPropertyChanging();
				_NroAFP = value;
				SendPropertyChanged("NroAFP");
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
				SendPropertyChanging();
				_FechaAFP = value;
				SendPropertyChanged("FechaAFP");
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
				if (_Seguro.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdSeguro = value;
				SendPropertyChanged("IdSeguro");
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
				SendPropertyChanging();
				_NroSeguro = value;
				SendPropertyChanged("NroSeguro");
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
				if (_TipoSangre.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoSangre = value;
				SendPropertyChanged("IdTipoSangre");
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
				SendPropertyChanging();
				_DecLey = value;
				SendPropertyChanged("DecLey");
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
				SendPropertyChanging();
				_Foto = value;
				SendPropertyChanged("Foto");
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
				if (_TipoTrabajador.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoTrabajador = value;
				SendPropertyChanged("IdTipoTrabajador");
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
				SendPropertyChanging();
				_Estado = value;
				SendPropertyChanged("Estado");
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
				if (_Cargo.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdCargo = value;
				SendPropertyChanged("IdCargo");
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
				if (_Discapacidad.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdDiscapacidad = value;
				SendPropertyChanged("IdDiscapacidad");
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
				SendPropertyChanging();
				_Profesion = value;
				SendPropertyChanged("Profesion");
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
				SendPropertyChanging();
				_JefeHogar = value;
				SendPropertyChanged("JefeHogar");
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
				SendPropertyChanging();
				_CargaFam = value;
				SendPropertyChanged("CargaFam");
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
				SendPropertyChanging();
				_NumHijos = value;
				SendPropertyChanged("NumHijos");
			}
		}
	}

	[Column(Storage = "_IdViveCon", DbType = "Int")]
	public int? IdViveCon
	{
		get
		{
			return _IdViveCon;
		}
		set
		{
			if (!_IdViveCon.Equals(value))
			{
				if (_ViveCon.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdViveCon = value;
				SendPropertyChanged("IdViveCon");
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
				SendPropertyChanging();
				_ObsFam = value;
				SendPropertyChanged("ObsFam");
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
				SendPropertyChanging();
				_AspecSalud = value;
				SendPropertyChanged("AspecSalud");
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
				SendPropertyChanging();
				_AspecEducacion = value;
				SendPropertyChanged("AspecEducacion");
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
				SendPropertyChanging();
				_AspecRecreacion = value;
				SendPropertyChanged("AspecRecreacion");
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
				SendPropertyChanging();
				_AspecPsico = value;
				SendPropertyChanged("AspecPsico");
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
				SendPropertyChanging();
				_AspecSocial = value;
				SendPropertyChanged("AspecSocial");
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
				SendPropertyChanging();
				_DiagnosSocial = value;
				SendPropertyChanged("DiagnosSocial");
			}
		}
	}

	[Column(Storage = "_IdNacionalidad", DbType = "Int")]
	public int? IdNacionalidad
	{
		get
		{
			return _IdNacionalidad;
		}
		set
		{
			if (!_IdNacionalidad.Equals(value))
			{
				if (_Nacionalidad.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdNacionalidad = value;
				SendPropertyChanged("IdNacionalidad");
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
				SendPropertyChanging();
				_NumLibretaMilitar = value;
				SendPropertyChanged("NumLibretaMilitar");
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
				SendPropertyChanging();
				_GradoInstruccion = value;
				SendPropertyChanged("GradoInstruccion");
			}
		}
	}

	[Column(Storage = "_IdRegimenPen", DbType = "Int")]
	public int? IdRegimenPen
	{
		get
		{
			return _IdRegimenPen;
		}
		set
		{
			if (!_IdRegimenPen.Equals(value))
			{
				if (_RegimenPension.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdRegimenPen = value;
				SendPropertyChanged("IdRegimenPen");
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
				SendPropertyChanging();
				_NumRUC = value;
				SendPropertyChanged("NumRUC");
			}
		}
	}

	[Column(Storage = "_NumAutogenSalud", DbType = "VarChar(15)")]
	public string NumAutogenSalud
	{
		get
		{
			return _NumAutogenSalud;
		}
		set
		{
			if (!string.Equals(_NumAutogenSalud, value))
			{
				SendPropertyChanging();
				_NumAutogenSalud = value;
				SendPropertyChanged("NumAutogenSalud");
			}
		}
	}

	[Column(Storage = "_NumResolCese", DbType = "VarChar(20)")]
	public string NumResolCese
	{
		get
		{
			return _NumResolCese;
		}
		set
		{
			if (!string.Equals(_NumResolCese, value))
			{
				SendPropertyChanging();
				_NumResolCese = value;
				SendPropertyChanged("NumResolCese");
			}
		}
	}

	[Column(Storage = "_FechaResolCese", DbType = "DateTime")]
	public DateTime? FechaResolCese
	{
		get
		{
			return _FechaResolCese;
		}
		set
		{
			if (!_FechaResolCese.Equals(value))
			{
				SendPropertyChanging();
				_FechaResolCese = value;
				SendPropertyChanged("FechaResolCese");
			}
		}
	}

	[Column(Storage = "_NumResol20530", DbType = "VarChar(20)")]
	public string NumResol20530
	{
		get
		{
			return _NumResol20530;
		}
		set
		{
			if (!string.Equals(_NumResol20530, value))
			{
				SendPropertyChanging();
				_NumResol20530 = value;
				SendPropertyChanged("NumResol20530");
			}
		}
	}

	[Column(Storage = "_FechaResol20530", DbType = "DateTime")]
	public DateTime? FechaResol20530
	{
		get
		{
			return _FechaResol20530;
		}
		set
		{
			if (!_FechaResol20530.Equals(value))
			{
				SendPropertyChanging();
				_FechaResol20530 = value;
				SendPropertyChanged("FechaResol20530");
			}
		}
	}

	[Column(Storage = "_NumResolPenMen", DbType = "VarChar(20)")]
	public string NumResolPenMen
	{
		get
		{
			return _NumResolPenMen;
		}
		set
		{
			if (!string.Equals(_NumResolPenMen, value))
			{
				SendPropertyChanging();
				_NumResolPenMen = value;
				SendPropertyChanged("NumResolPenMen");
			}
		}
	}

	[Column(Storage = "_FechaResolPenMen", DbType = "DateTime")]
	public DateTime? FechaResolPenMen
	{
		get
		{
			return _FechaResolPenMen;
		}
		set
		{
			if (!_FechaResolPenMen.Equals(value))
			{
				SendPropertyChanging();
				_FechaResolPenMen = value;
				SendPropertyChanged("FechaResolPenMen");
			}
		}
	}

	[Column(Storage = "_NumResoIngreEsta", DbType = "VarChar(30)")]
	public string NumResoIngreEsta
	{
		get
		{
			return _NumResoIngreEsta;
		}
		set
		{
			if (!string.Equals(_NumResoIngreEsta, value))
			{
				SendPropertyChanging();
				_NumResoIngreEsta = value;
				SendPropertyChanged("NumResoIngreEsta");
			}
		}
	}

	[Column(Storage = "_FechaIngreEstado", DbType = "DateTime")]
	public DateTime? FechaIngreEstado
	{
		get
		{
			return _FechaIngreEstado;
		}
		set
		{
			if (!_FechaIngreEstado.Equals(value))
			{
				SendPropertyChanging();
				_FechaIngreEstado = value;
				SendPropertyChanged("FechaIngreEstado");
			}
		}
	}

	[Column(Storage = "_FechaResolIngreEsta", DbType = "DateTime")]
	public DateTime? FechaResolIngreEsta
	{
		get
		{
			return _FechaResolIngreEsta;
		}
		set
		{
			if (!_FechaResolIngreEsta.Equals(value))
			{
				SendPropertyChanging();
				_FechaResolIngreEsta = value;
				SendPropertyChanged("FechaResolIngreEsta");
			}
		}
	}

	[Column(Storage = "_NumResoIngreInstitu", DbType = "VarChar(30)")]
	public string NumResoIngreInstitu
	{
		get
		{
			return _NumResoIngreInstitu;
		}
		set
		{
			if (!string.Equals(_NumResoIngreInstitu, value))
			{
				SendPropertyChanging();
				_NumResoIngreInstitu = value;
				SendPropertyChanged("NumResoIngreInstitu");
			}
		}
	}

	[Column(Storage = "_FechaResoIngreInstitu", DbType = "DateTime")]
	public DateTime? FechaResoIngreInstitu
	{
		get
		{
			return _FechaResoIngreInstitu;
		}
		set
		{
			if (!_FechaResoIngreInstitu.Equals(value))
			{
				SendPropertyChanging();
				_FechaResoIngreInstitu = value;
				SendPropertyChanged("FechaResoIngreInstitu");
			}
		}
	}

	[Column(Storage = "_idHorario", DbType = "Int")]
	public int? idHorario
	{
		get
		{
			return _idHorario;
		}
		set
		{
			if (!_idHorario.Equals(value))
			{
				if (_Horario.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idHorario = value;
				SendPropertyChanged("idHorario");
			}
		}
	}

	[Column(Storage = "_Userid", DbType = "UniqueIdentifier")]
	public Guid? Userid
	{
		get
		{
			return _Userid;
		}
		set
		{
			if (!_Userid.Equals(value))
			{
				SendPropertyChanging();
				_Userid = value;
				SendPropertyChanged("Userid");
			}
		}
	}

	[Column(Storage = "_idLocal", DbType = "Int")]
	public int? idLocal
	{
		get
		{
			return _idLocal;
		}
		set
		{
			if (!_idLocal.Equals(value))
			{
				if (_Local.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idLocal = value;
				SendPropertyChanged("idLocal");
			}
		}
	}

	[Association(Name = "Empleado_Vivienda", Storage = "_Viviendas", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Vivienda> Viviendas
	{
		get
		{
			return _Viviendas;
		}
		set
		{
			_Viviendas.Assign(value);
		}
	}

	[Association(Name = "Empleado_Actividad", Storage = "_Actividads", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Actividad> Actividads
	{
		get
		{
			return _Actividads;
		}
		set
		{
			_Actividads.Assign(value);
		}
	}

	[Association(Name = "Empleado_Archivo", Storage = "_Archivos", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Archivo> Archivos
	{
		get
		{
			return _Archivos;
		}
		set
		{
			_Archivos.Assign(value);
		}
	}

	[Association(Name = "Empleado_Capacitacion", Storage = "_Capacitacions", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Capacitacion> Capacitacions
	{
		get
		{
			return _Capacitacions;
		}
		set
		{
			_Capacitacions.Assign(value);
		}
	}

	[Association(Name = "Empleado_CJROperador", Storage = "_CJROperadors", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<CJROperador> CJROperadors
	{
		get
		{
			return _CJROperadors;
		}
		set
		{
			_CJROperadors.Assign(value);
		}
	}

	[Association(Name = "Empleado_Comportamiento", Storage = "_Comportamientos", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Comportamiento> Comportamientos
	{
		get
		{
			return _Comportamientos;
		}
		set
		{
			_Comportamientos.Assign(value);
		}
	}

	[Association(Name = "Empleado_Egreso", Storage = "_Egresos", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Egreso> Egresos
	{
		get
		{
			return _Egresos;
		}
		set
		{
			_Egresos.Assign(value);
		}
	}

	[Association(Name = "Empleado_Empleado_Area", Storage = "_Empleado_Areas", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Empleado_Area> Empleado_Areas
	{
		get
		{
			return _Empleado_Areas;
		}
		set
		{
			_Empleado_Areas.Assign(value);
		}
	}

	[Association(Name = "Empleado_ExpLaboral", Storage = "_ExpLaborals", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<ExpLaboral> ExpLaborals
	{
		get
		{
			return _ExpLaborals;
		}
		set
		{
			_ExpLaborals.Assign(value);
		}
	}

	[Association(Name = "Empleado_Familiar", Storage = "_Familiars", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Familiar> Familiars
	{
		get
		{
			return _Familiars;
		}
		set
		{
			_Familiars.Assign(value);
		}
	}

	[Association(Name = "Empleado_Ingreso", Storage = "_Ingresos", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Ingreso> Ingresos
	{
		get
		{
			return _Ingresos;
		}
		set
		{
			_Ingresos.Assign(value);
		}
	}

	[Association(Name = "Empleado_Marcacion", Storage = "_Marcacions", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Marcacion> Marcacions
	{
		get
		{
			return _Marcacions;
		}
		set
		{
			_Marcacions.Assign(value);
		}
	}

	[Association(Name = "Empleado_PeriodoLaboral", Storage = "_PeriodoLaborals", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<PeriodoLaboral> PeriodoLaborals
	{
		get
		{
			return _PeriodoLaborals;
		}
		set
		{
			_PeriodoLaborals.Assign(value);
		}
	}

	[Association(Name = "Empleado_Permiso", Storage = "_Permisos", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Permiso> Permisos
	{
		get
		{
			return _Permisos;
		}
		set
		{
			_Permisos.Assign(value);
		}
	}

	[Association(Name = "Empleado_RRHH_AspSocio", Storage = "_RRHH_AspSocios", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<RRHH_AspSocio> RRHH_AspSocios
	{
		get
		{
			return _RRHH_AspSocios;
		}
		set
		{
			_RRHH_AspSocios.Assign(value);
		}
	}

	[Association(Name = "Empleado_RRHH_DinamicaFamiliar", Storage = "_RRHH_DinamicaFamiliars", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<RRHH_DinamicaFamiliar> RRHH_DinamicaFamiliars
	{
		get
		{
			return _RRHH_DinamicaFamiliars;
		}
		set
		{
			_RRHH_DinamicaFamiliars.Assign(value);
		}
	}

	[Association(Name = "Empleado_RRHH_FuncFam", Storage = "_RRHH_FuncFams", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<RRHH_FuncFam> RRHH_FuncFams
	{
		get
		{
			return _RRHH_FuncFams;
		}
		set
		{
			_RRHH_FuncFams.Assign(value);
		}
	}

	[Association(Name = "Empleado_RRHH_Salud", Storage = "_RRHH_Saluds", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<RRHH_Salud> RRHH_Saluds
	{
		get
		{
			return _RRHH_Saluds;
		}
		set
		{
			_RRHH_Saluds.Assign(value);
		}
	}

	[Association(Name = "Empleado_TitulosEmpleado", Storage = "_TitulosEmpleados", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<TitulosEmpleado> TitulosEmpleados
	{
		get
		{
			return _TitulosEmpleados;
		}
		set
		{
			_TitulosEmpleados.Assign(value);
		}
	}

	[Association(Name = "Empleado_Usuario", Storage = "_Usuarios", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Usuario> Usuarios
	{
		get
		{
			return _Usuarios;
		}
		set
		{
			_Usuarios.Assign(value);
		}
	}

	[Association(Name = "Empleado_RRHH_Asegurado", Storage = "_RRHH_Asegurados", ThisKey = "IdEmpleado", OtherKey = "idEmpleado")]
	public EntitySet<RRHH_Asegurado> RRHH_Asegurados
	{
		get
		{
			return _RRHH_Asegurados;
		}
		set
		{
			_RRHH_Asegurados.Assign(value);
		}
	}

	[Association(Name = "Empleado_EstudiosRealizado", Storage = "_EstudiosRealizados", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<EstudiosRealizado> EstudiosRealizados
	{
		get
		{
			return _EstudiosRealizados;
		}
		set
		{
			_EstudiosRealizados.Assign(value);
		}
	}

	[Association(Name = "Empleado_Asistencia", Storage = "_Asistencias", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado")]
	public EntitySet<Asistencia> Asistencias
	{
		get
		{
			return _Asistencias;
		}
		set
		{
			_Asistencias.Assign(value);
		}
	}

	[Association(Name = "Empleado_Rotacion", Storage = "_Rotacions", ThisKey = "IdEmpleado", OtherKey = "idEmpleado")]
	public EntitySet<Rotacion> Rotacions
	{
		get
		{
			return _Rotacions;
		}
		set
		{
			_Rotacions.Assign(value);
		}
	}

	[Association(Name = "Empleado_Resolucion", Storage = "_Resolucions", ThisKey = "IdEmpleado", OtherKey = "idEmpleado")]
	public EntitySet<Resolucion> Resolucions
	{
		get
		{
			return _Resolucions;
		}
		set
		{
			_Resolucions.Assign(value);
		}
	}

	[Association(Name = "Empleado_HorarioTemporal", Storage = "_HorarioTemporals", ThisKey = "IdEmpleado", OtherKey = "idEmpleado")]
	public EntitySet<HorarioTemporal> HorarioTemporals
	{
		get
		{
			return _HorarioTemporals;
		}
		set
		{
			_HorarioTemporals.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_Empleado", Storage = "_EstructOrganiz", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz", IsForeignKey = true)]
	public EstructOrganiz EstructOrganiz
	{
		get
		{
			return _EstructOrganiz.Entity;
		}
		set
		{
			EstructOrganiz previousValue = _EstructOrganiz.Entity;
			if (!object.Equals(previousValue, value) || !_EstructOrganiz.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_EstructOrganiz.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_EstructOrganiz.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_Year = value.Year;
					_idAreaOrganiz = value.idAreaOrganiz;
				}
				else
				{
					_Year = 0;
					_idAreaOrganiz = 0;
				}
				SendPropertyChanged("EstructOrganiz");
			}
		}
	}

	[Association(Name = "AFP_Empleado", Storage = "_AFP", ThisKey = "IdAFP", OtherKey = "IdAFP", IsForeignKey = true)]
	public AFP AFP
	{
		get
		{
			return _AFP.Entity;
		}
		set
		{
			AFP previousValue = _AFP.Entity;
			if (!object.Equals(previousValue, value) || !_AFP.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_AFP.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_AFP.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_IdAFP = value.IdAFP;
				}
				else
				{
					_IdAFP = null;
				}
				SendPropertyChanged("AFP");
			}
		}
	}

	[Association(Name = "Cargo_Empleado", Storage = "_Cargo", ThisKey = "IdCargo", OtherKey = "IdCargo", IsForeignKey = true)]
	public Cargo Cargo
	{
		get
		{
			return _Cargo.Entity;
		}
		set
		{
			Cargo previousValue = _Cargo.Entity;
			if (!object.Equals(previousValue, value) || !_Cargo.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Cargo.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_Cargo.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_IdCargo = value.IdCargo;
				}
				else
				{
					_IdCargo = null;
				}
				SendPropertyChanged("Cargo");
			}
		}
	}

	[Association(Name = "Discapacidad_Empleado", Storage = "_Discapacidad", ThisKey = "IdDiscapacidad", OtherKey = "IdDiscapacidad", IsForeignKey = true)]
	public Discapacidad Discapacidad
	{
		get
		{
			return _Discapacidad.Entity;
		}
		set
		{
			Discapacidad previousValue = _Discapacidad.Entity;
			if (!object.Equals(previousValue, value) || !_Discapacidad.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Discapacidad.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_Discapacidad.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_IdDiscapacidad = value.IdDiscapacidad;
				}
				else
				{
					_IdDiscapacidad = null;
				}
				SendPropertyChanged("Discapacidad");
			}
		}
	}

	[Association(Name = "EstadoCivil_Empleado", Storage = "_EstadoCivil", ThisKey = "IdEstadoCivil", OtherKey = "IdEstadoCivil", IsForeignKey = true)]
	public EstadoCivil EstadoCivil
	{
		get
		{
			return _EstadoCivil.Entity;
		}
		set
		{
			EstadoCivil previousValue = _EstadoCivil.Entity;
			if (!object.Equals(previousValue, value) || !_EstadoCivil.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_EstadoCivil.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_EstadoCivil.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_IdEstadoCivil = value.IdEstadoCivil;
				}
				else
				{
					_IdEstadoCivil = null;
				}
				SendPropertyChanged("EstadoCivil");
			}
		}
	}

	[Association(Name = "Horario_Empleado", Storage = "_Horario", ThisKey = "idHorario", OtherKey = "idHorario", IsForeignKey = true)]
	public Horario Horario
	{
		get
		{
			return _Horario.Entity;
		}
		set
		{
			Horario previousValue = _Horario.Entity;
			if (!object.Equals(previousValue, value) || !_Horario.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Horario.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_Horario.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_idHorario = value.idHorario;
				}
				else
				{
					_idHorario = null;
				}
				SendPropertyChanged("Horario");
			}
		}
	}

	[Association(Name = "Nacionalidad_Empleado", Storage = "_Nacionalidad", ThisKey = "IdNacionalidad", OtherKey = "IdNacionalidad", IsForeignKey = true)]
	public Nacionalidad Nacionalidad
	{
		get
		{
			return _Nacionalidad.Entity;
		}
		set
		{
			Nacionalidad previousValue = _Nacionalidad.Entity;
			if (!object.Equals(previousValue, value) || !_Nacionalidad.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Nacionalidad.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_Nacionalidad.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_IdNacionalidad = value.IdNacionalidad;
				}
				else
				{
					_IdNacionalidad = null;
				}
				SendPropertyChanged("Nacionalidad");
			}
		}
	}

	[Association(Name = "Persona_Empleado", Storage = "_Persona", ThisKey = "IdPersona", OtherKey = "IdPersona", IsForeignKey = true)]
	public Persona Persona
	{
		get
		{
			return _Persona.Entity;
		}
		set
		{
			Persona previousValue = _Persona.Entity;
			if (!object.Equals(previousValue, value) || !_Persona.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Persona.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_Persona.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_IdPersona = value.IdPersona;
				}
				else
				{
					_IdPersona = null;
				}
				SendPropertyChanged("Persona");
			}
		}
	}

	[Association(Name = "RegimenPension_Empleado", Storage = "_RegimenPension", ThisKey = "IdRegimenPen", OtherKey = "IdRegimenPen", IsForeignKey = true)]
	public RegimenPension RegimenPension
	{
		get
		{
			return _RegimenPension.Entity;
		}
		set
		{
			RegimenPension previousValue = _RegimenPension.Entity;
			if (!object.Equals(previousValue, value) || !_RegimenPension.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_RegimenPension.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_RegimenPension.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_IdRegimenPen = value.IdRegimenPen;
				}
				else
				{
					_IdRegimenPen = null;
				}
				SendPropertyChanged("RegimenPension");
			}
		}
	}

	[Association(Name = "Seguro_Empleado", Storage = "_Seguro", ThisKey = "IdSeguro", OtherKey = "IdSeguro", IsForeignKey = true)]
	public Seguro Seguro
	{
		get
		{
			return _Seguro.Entity;
		}
		set
		{
			Seguro previousValue = _Seguro.Entity;
			if (!object.Equals(previousValue, value) || !_Seguro.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Seguro.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_Seguro.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_IdSeguro = value.IdSeguro;
				}
				else
				{
					_IdSeguro = null;
				}
				SendPropertyChanged("Seguro");
			}
		}
	}

	[Association(Name = "TipoTrabajador_Empleado", Storage = "_TipoTrabajador", ThisKey = "IdTipoTrabajador", OtherKey = "IdTipoTrabajador", IsForeignKey = true)]
	public TipoTrabajador TipoTrabajador
	{
		get
		{
			return _TipoTrabajador.Entity;
		}
		set
		{
			TipoTrabajador previousValue = _TipoTrabajador.Entity;
			if (!object.Equals(previousValue, value) || !_TipoTrabajador.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoTrabajador.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_TipoTrabajador.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_IdTipoTrabajador = value.IdTipoTrabajador;
				}
				else
				{
					_IdTipoTrabajador = null;
				}
				SendPropertyChanged("TipoTrabajador");
			}
		}
	}

	[Association(Name = "TipoSangre_Empleado", Storage = "_TipoSangre", ThisKey = "IdTipoSangre", OtherKey = "IdTipoSangre", IsForeignKey = true)]
	public TipoSangre TipoSangre
	{
		get
		{
			return _TipoSangre.Entity;
		}
		set
		{
			TipoSangre previousValue = _TipoSangre.Entity;
			if (!object.Equals(previousValue, value) || !_TipoSangre.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoSangre.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_TipoSangre.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_IdTipoSangre = value.IdTipoSangre;
				}
				else
				{
					_IdTipoSangre = null;
				}
				SendPropertyChanged("TipoSangre");
			}
		}
	}

	[Association(Name = "ViveCon_Empleado", Storage = "_ViveCon", ThisKey = "IdViveCon", OtherKey = "IdViveCon", IsForeignKey = true)]
	public ViveCon ViveCon
	{
		get
		{
			return _ViveCon.Entity;
		}
		set
		{
			ViveCon previousValue = _ViveCon.Entity;
			if (!object.Equals(previousValue, value) || !_ViveCon.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_ViveCon.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_ViveCon.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_IdViveCon = value.IdViveCon;
				}
				else
				{
					_IdViveCon = null;
				}
				SendPropertyChanged("ViveCon");
			}
		}
	}

	[Association(Name = "Local_Empleado", Storage = "_Local", ThisKey = "idLocal", OtherKey = "idLocal", IsForeignKey = true)]
	public Local Local
	{
		get
		{
			return _Local.Entity;
		}
		set
		{
			Local previousValue = _Local.Entity;
			if (!object.Equals(previousValue, value) || !_Local.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Local.Entity = null;
					previousValue.Empleados.Remove(this);
				}
				_Local.Entity = value;
				if (value != null)
				{
					value.Empleados.Add(this);
					_idLocal = value.idLocal;
				}
				else
				{
					_idLocal = null;
				}
				SendPropertyChanged("Local");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Empleado()
	{
		_Viviendas = new EntitySet<Vivienda>(attach_Viviendas, detach_Viviendas);
		_Actividads = new EntitySet<Actividad>(attach_Actividads, detach_Actividads);
		_Archivos = new EntitySet<Archivo>(attach_Archivos, detach_Archivos);
		_Capacitacions = new EntitySet<Capacitacion>(attach_Capacitacions, detach_Capacitacions);
		_CJROperadors = new EntitySet<CJROperador>(attach_CJROperadors, detach_CJROperadors);
		_Comportamientos = new EntitySet<Comportamiento>(attach_Comportamientos, detach_Comportamientos);
		_Egresos = new EntitySet<Egreso>(attach_Egresos, detach_Egresos);
		_Empleado_Areas = new EntitySet<Empleado_Area>(attach_Empleado_Areas, detach_Empleado_Areas);
		_ExpLaborals = new EntitySet<ExpLaboral>(attach_ExpLaborals, detach_ExpLaborals);
		_Familiars = new EntitySet<Familiar>(attach_Familiars, detach_Familiars);
		_Ingresos = new EntitySet<Ingreso>(attach_Ingresos, detach_Ingresos);
		_Marcacions = new EntitySet<Marcacion>(attach_Marcacions, detach_Marcacions);
		_PeriodoLaborals = new EntitySet<PeriodoLaboral>(attach_PeriodoLaborals, detach_PeriodoLaborals);
		_Permisos = new EntitySet<Permiso>(attach_Permisos, detach_Permisos);
		_RRHH_AspSocios = new EntitySet<RRHH_AspSocio>(attach_RRHH_AspSocios, detach_RRHH_AspSocios);
		_RRHH_DinamicaFamiliars = new EntitySet<RRHH_DinamicaFamiliar>(attach_RRHH_DinamicaFamiliars, detach_RRHH_DinamicaFamiliars);
		_RRHH_FuncFams = new EntitySet<RRHH_FuncFam>(attach_RRHH_FuncFams, detach_RRHH_FuncFams);
		_RRHH_Saluds = new EntitySet<RRHH_Salud>(attach_RRHH_Saluds, detach_RRHH_Saluds);
		_TitulosEmpleados = new EntitySet<TitulosEmpleado>(attach_TitulosEmpleados, detach_TitulosEmpleados);
		_Usuarios = new EntitySet<Usuario>(attach_Usuarios, detach_Usuarios);
		_RRHH_Asegurados = new EntitySet<RRHH_Asegurado>(attach_RRHH_Asegurados, detach_RRHH_Asegurados);
		_EstudiosRealizados = new EntitySet<EstudiosRealizado>(attach_EstudiosRealizados, detach_EstudiosRealizados);
		_Asistencias = new EntitySet<Asistencia>(attach_Asistencias, detach_Asistencias);
		_Rotacions = new EntitySet<Rotacion>(attach_Rotacions, detach_Rotacions);
		_Resolucions = new EntitySet<Resolucion>(attach_Resolucions, detach_Resolucions);
		_HorarioTemporals = new EntitySet<HorarioTemporal>(attach_HorarioTemporals, detach_HorarioTemporals);
		_EstructOrganiz = default(EntityRef<EstructOrganiz>);
		_AFP = default(EntityRef<AFP>);
		_Cargo = default(EntityRef<Cargo>);
		_Discapacidad = default(EntityRef<Discapacidad>);
		_EstadoCivil = default(EntityRef<EstadoCivil>);
		_Horario = default(EntityRef<Horario>);
		_Nacionalidad = default(EntityRef<Nacionalidad>);
		_Persona = default(EntityRef<Persona>);
		_RegimenPension = default(EntityRef<RegimenPension>);
		_Seguro = default(EntityRef<Seguro>);
		_TipoTrabajador = default(EntityRef<TipoTrabajador>);
		_TipoSangre = default(EntityRef<TipoSangre>);
		_ViveCon = default(EntityRef<ViveCon>);
		_Local = default(EntityRef<Local>);
	}

	protected virtual void SendPropertyChanging()
	{
		if (PropertyChanging != null)
		{
			PropertyChanging?.Invoke(this, emptyChangingEventArgs);
		}
	}

	protected virtual void SendPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	private void attach_Viviendas(Vivienda entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Viviendas(Vivienda entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Actividads(Actividad entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Actividads(Actividad entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Archivos(Archivo entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Archivos(Archivo entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Capacitacions(Capacitacion entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Capacitacions(Capacitacion entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_CJROperadors(CJROperador entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_CJROperadors(CJROperador entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Comportamientos(Comportamiento entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Comportamientos(Comportamiento entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Egresos(Egreso entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Egresos(Egreso entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Empleado_Areas(Empleado_Area entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Empleado_Areas(Empleado_Area entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_ExpLaborals(ExpLaboral entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_ExpLaborals(ExpLaboral entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Familiars(Familiar entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Familiars(Familiar entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Ingresos(Ingreso entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Ingresos(Ingreso entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Marcacions(Marcacion entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Marcacions(Marcacion entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_PeriodoLaborals(PeriodoLaboral entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_PeriodoLaborals(PeriodoLaboral entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Permisos(Permiso entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Permisos(Permiso entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_RRHH_AspSocios(RRHH_AspSocio entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_RRHH_AspSocios(RRHH_AspSocio entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_RRHH_DinamicaFamiliars(RRHH_DinamicaFamiliar entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_RRHH_DinamicaFamiliars(RRHH_DinamicaFamiliar entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_RRHH_FuncFams(RRHH_FuncFam entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_RRHH_FuncFams(RRHH_FuncFam entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_RRHH_Saluds(RRHH_Salud entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_RRHH_Saluds(RRHH_Salud entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_TitulosEmpleados(TitulosEmpleado entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_TitulosEmpleados(TitulosEmpleado entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Usuarios(Usuario entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Usuarios(Usuario entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_RRHH_Asegurados(RRHH_Asegurado entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_RRHH_Asegurados(RRHH_Asegurado entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_EstudiosRealizados(EstudiosRealizado entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_EstudiosRealizados(EstudiosRealizado entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Asistencias(Asistencia entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Asistencias(Asistencia entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Rotacions(Rotacion entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Rotacions(Rotacion entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_Resolucions(Resolucion entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_Resolucions(Resolucion entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}

	private void attach_HorarioTemporals(HorarioTemporal entity)
	{
		SendPropertyChanging();
		entity.Empleado = this;
	}

	private void detach_HorarioTemporals(HorarioTemporal entity)
	{
		SendPropertyChanging();
		entity.Empleado = null;
	}
}
