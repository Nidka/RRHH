using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Familiar")]
public class Familiar : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdEmpleado;

	private int _IdPersona;

	private char? _FamSexo;

	private string _FamLugTrab;

	private int? _IdEstadoCivil;

	private string _NumAutogenSalud;

	private string _FamOcupacion;

	private string _FamGradoInstruc;

	private int? _IdTipoFam;

	private bool? _ViveCasa;

	private bool? _LaboraInstitucion;

	private int? _IdDiscapacidad;

	private string _Procedencia;

	private string _Enfermedad;

	private string _TiempoEnfermedad;

	private int? _IdTipoSangre;

	private EntityRef<Discapacidad> _Discapacidad;

	private EntityRef<EstadoCivil> _EstadoCivil;

	private EntityRef<Persona> _Persona;

	private EntityRef<TipoFamiliar> _TipoFamiliar;

	private EntityRef<TipoSangre> _TipoSangre;

	private EntityRef<Empleado> _Empleado;

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
				if (_Empleado.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdEmpleado = value;
				SendPropertyChanged("IdEmpleado");
			}
		}
	}

	[Column(Storage = "_IdPersona", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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

	[Column(Storage = "_FamSexo", DbType = "Char(1)")]
	public char? FamSexo
	{
		get
		{
			return _FamSexo;
		}
		set
		{
			if (!_FamSexo.Equals(value))
			{
				SendPropertyChanging();
				_FamSexo = value;
				SendPropertyChanged("FamSexo");
			}
		}
	}

	[Column(Storage = "_FamLugTrab", DbType = "VarChar(50)")]
	public string FamLugTrab
	{
		get
		{
			return _FamLugTrab;
		}
		set
		{
			if (!string.Equals(_FamLugTrab, value))
			{
				SendPropertyChanging();
				_FamLugTrab = value;
				SendPropertyChanged("FamLugTrab");
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

	[Column(Storage = "_FamOcupacion", DbType = "VarChar(20)")]
	public string FamOcupacion
	{
		get
		{
			return _FamOcupacion;
		}
		set
		{
			if (!string.Equals(_FamOcupacion, value))
			{
				SendPropertyChanging();
				_FamOcupacion = value;
				SendPropertyChanged("FamOcupacion");
			}
		}
	}

	[Column(Storage = "_FamGradoInstruc", DbType = "VarChar(15)")]
	public string FamGradoInstruc
	{
		get
		{
			return _FamGradoInstruc;
		}
		set
		{
			if (!string.Equals(_FamGradoInstruc, value))
			{
				SendPropertyChanging();
				_FamGradoInstruc = value;
				SendPropertyChanged("FamGradoInstruc");
			}
		}
	}

	[Column(Storage = "_IdTipoFam", DbType = "Int")]
	public int? IdTipoFam
	{
		get
		{
			return _IdTipoFam;
		}
		set
		{
			if (!_IdTipoFam.Equals(value))
			{
				if (_TipoFamiliar.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoFam = value;
				SendPropertyChanged("IdTipoFam");
			}
		}
	}

	[Column(Storage = "_ViveCasa", DbType = "Bit")]
	public bool? ViveCasa
	{
		get
		{
			return _ViveCasa;
		}
		set
		{
			if (!_ViveCasa.Equals(value))
			{
				SendPropertyChanging();
				_ViveCasa = value;
				SendPropertyChanged("ViveCasa");
			}
		}
	}

	[Column(Storage = "_LaboraInstitucion", DbType = "Bit")]
	public bool? LaboraInstitucion
	{
		get
		{
			return _LaboraInstitucion;
		}
		set
		{
			if (!_LaboraInstitucion.Equals(value))
			{
				SendPropertyChanging();
				_LaboraInstitucion = value;
				SendPropertyChanged("LaboraInstitucion");
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

	[Column(Storage = "_Procedencia", DbType = "VarChar(50)")]
	public string Procedencia
	{
		get
		{
			return _Procedencia;
		}
		set
		{
			if (!string.Equals(_Procedencia, value))
			{
				SendPropertyChanging();
				_Procedencia = value;
				SendPropertyChanged("Procedencia");
			}
		}
	}

	[Column(Storage = "_Enfermedad", DbType = "VarChar(200)")]
	public string Enfermedad
	{
		get
		{
			return _Enfermedad;
		}
		set
		{
			if (!string.Equals(_Enfermedad, value))
			{
				SendPropertyChanging();
				_Enfermedad = value;
				SendPropertyChanged("Enfermedad");
			}
		}
	}

	[Column(Storage = "_TiempoEnfermedad", DbType = "VarChar(200)")]
	public string TiempoEnfermedad
	{
		get
		{
			return _TiempoEnfermedad;
		}
		set
		{
			if (!string.Equals(_TiempoEnfermedad, value))
			{
				SendPropertyChanging();
				_TiempoEnfermedad = value;
				SendPropertyChanged("TiempoEnfermedad");
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

	[Association(Name = "Discapacidad_Familiar", Storage = "_Discapacidad", ThisKey = "IdDiscapacidad", OtherKey = "IdDiscapacidad", IsForeignKey = true)]
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
					previousValue.Familiar.Remove(this);
				}
				_Discapacidad.Entity = value;
				if (value != null)
				{
					value.Familiar.Add(this);
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

	[Association(Name = "EstadoCivil_Familiar", Storage = "_EstadoCivil", ThisKey = "IdEstadoCivil", OtherKey = "IdEstadoCivil", IsForeignKey = true)]
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
					previousValue.Familiar.Remove(this);
				}
				_EstadoCivil.Entity = value;
				if (value != null)
				{
					value.Familiar.Add(this);
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

	[Association(Name = "Persona_Familiar", Storage = "_Persona", ThisKey = "IdPersona", OtherKey = "IdPersona", IsForeignKey = true)]
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
					previousValue.Familiar.Remove(this);
				}
				_Persona.Entity = value;
				if (value != null)
				{
					value.Familiar.Add(this);
					_IdPersona = value.IdPersona;
				}
				else
				{
					_IdPersona = 0;
				}
				SendPropertyChanged("Persona");
			}
		}
	}

	[Association(Name = "TipoFamiliar_Familiar", Storage = "_TipoFamiliar", ThisKey = "IdTipoFam", OtherKey = "IdTipoFam", IsForeignKey = true)]
	public TipoFamiliar TipoFamiliar
	{
		get
		{
			return _TipoFamiliar.Entity;
		}
		set
		{
			TipoFamiliar previousValue = _TipoFamiliar.Entity;
			if (!object.Equals(previousValue, value) || !_TipoFamiliar.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoFamiliar.Entity = null;
					previousValue.Familiar.Remove(this);
				}
				_TipoFamiliar.Entity = value;
				if (value != null)
				{
					value.Familiar.Add(this);
					_IdTipoFam = value.IdTipoFam;
				}
				else
				{
					_IdTipoFam = null;
				}
				SendPropertyChanged("TipoFamiliar");
			}
		}
	}

	[Association(Name = "TipoSangre_Familiar", Storage = "_TipoSangre", ThisKey = "IdTipoSangre", OtherKey = "IdTipoSangre", IsForeignKey = true)]
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
					previousValue.Familiar.Remove(this);
				}
				_TipoSangre.Entity = value;
				if (value != null)
				{
					value.Familiar.Add(this);
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

	[Association(Name = "Empleado_Familiar", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
	public Empleado Empleado
	{
		get
		{
			return _Empleado.Entity;
		}
		set
		{
			Empleado previousValue = _Empleado.Entity;
			if (!object.Equals(previousValue, value) || !_Empleado.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Empleado.Entity = null;
					previousValue.Familiars.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Familiars.Add(this);
					_IdEmpleado = value.IdEmpleado;
				}
				else
				{
					_IdEmpleado = 0;
				}
				SendPropertyChanged("Empleado");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Familiar()
	{
		_Discapacidad = default(EntityRef<Discapacidad>);
		_EstadoCivil = default(EntityRef<EstadoCivil>);
		_Persona = default(EntityRef<Persona>);
		_TipoFamiliar = default(EntityRef<TipoFamiliar>);
		_TipoSangre = default(EntityRef<TipoSangre>);
		_Empleado = default(EntityRef<Empleado>);
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
}
