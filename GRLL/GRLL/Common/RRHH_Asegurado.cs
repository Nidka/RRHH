using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_Asegurado")]
public class RRHH_Asegurado : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idEmpleado;

	private int _NroBeneficiario;

	private int? _idPersona;

	private int? _idEstadoCivil;

	private char? _Sexo;

	private string _VinculoFamiliar;

	private string _NroPartida;

	private string _NroResolMayorIndiscap;

	private DateTime? _FechaInicioVinculo;

	private int? _idMotivoBaja;

	private string _NroPartidaDef;

	private string _OtrosMotivos;

	private DateTime? _FechaFinVinculo;

	private char? _Reevaluar;

	private EntityRef<EstadoCivil> _EstadoCivil;

	private EntityRef<MotivoBaja> _MotivoBaja;

	private EntityRef<Persona> _Persona;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_idEmpleado", DbType = "Int NOT NULL", IsPrimaryKey = true)]
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
				if (_Empleado.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idEmpleado = value;
				SendPropertyChanged("idEmpleado");
			}
		}
	}

	[Column(Storage = "_NroBeneficiario", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int NroBeneficiario
	{
		get
		{
			return _NroBeneficiario;
		}
		set
		{
			if (_NroBeneficiario != value)
			{
				SendPropertyChanging();
				_NroBeneficiario = value;
				SendPropertyChanged("NroBeneficiario");
			}
		}
	}

	[Column(Storage = "_idPersona", DbType = "Int")]
	public int? idPersona
	{
		get
		{
			return _idPersona;
		}
		set
		{
			if (!_idPersona.Equals(value))
			{
				if (_Persona.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idPersona = value;
				SendPropertyChanged("idPersona");
			}
		}
	}

	[Column(Storage = "_idEstadoCivil", DbType = "Int")]
	public int? idEstadoCivil
	{
		get
		{
			return _idEstadoCivil;
		}
		set
		{
			if (!_idEstadoCivil.Equals(value))
			{
				if (_EstadoCivil.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idEstadoCivil = value;
				SendPropertyChanged("idEstadoCivil");
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

	[Column(Storage = "_VinculoFamiliar", DbType = "VarChar(50)")]
	public string VinculoFamiliar
	{
		get
		{
			return _VinculoFamiliar;
		}
		set
		{
			if (!string.Equals(_VinculoFamiliar, value))
			{
				SendPropertyChanging();
				_VinculoFamiliar = value;
				SendPropertyChanged("VinculoFamiliar");
			}
		}
	}

	[Column(Storage = "_NroPartida", DbType = "VarChar(50)")]
	public string NroPartida
	{
		get
		{
			return _NroPartida;
		}
		set
		{
			if (!string.Equals(_NroPartida, value))
			{
				SendPropertyChanging();
				_NroPartida = value;
				SendPropertyChanged("NroPartida");
			}
		}
	}

	[Column(Storage = "_NroResolMayorIndiscap", DbType = "VarChar(50)")]
	public string NroResolMayorIndiscap
	{
		get
		{
			return _NroResolMayorIndiscap;
		}
		set
		{
			if (!string.Equals(_NroResolMayorIndiscap, value))
			{
				SendPropertyChanging();
				_NroResolMayorIndiscap = value;
				SendPropertyChanged("NroResolMayorIndiscap");
			}
		}
	}

	[Column(Storage = "_FechaInicioVinculo", DbType = "DateTime")]
	public DateTime? FechaInicioVinculo
	{
		get
		{
			return _FechaInicioVinculo;
		}
		set
		{
			if (!_FechaInicioVinculo.Equals(value))
			{
				SendPropertyChanging();
				_FechaInicioVinculo = value;
				SendPropertyChanged("FechaInicioVinculo");
			}
		}
	}

	[Column(Storage = "_idMotivoBaja", DbType = "Int")]
	public int? idMotivoBaja
	{
		get
		{
			return _idMotivoBaja;
		}
		set
		{
			if (!_idMotivoBaja.Equals(value))
			{
				if (_MotivoBaja.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idMotivoBaja = value;
				SendPropertyChanged("idMotivoBaja");
			}
		}
	}

	[Column(Storage = "_NroPartidaDef", DbType = "VarChar(50)")]
	public string NroPartidaDef
	{
		get
		{
			return _NroPartidaDef;
		}
		set
		{
			if (!string.Equals(_NroPartidaDef, value))
			{
				SendPropertyChanging();
				_NroPartidaDef = value;
				SendPropertyChanged("NroPartidaDef");
			}
		}
	}

	[Column(Storage = "_OtrosMotivos", DbType = "VarChar(50)")]
	public string OtrosMotivos
	{
		get
		{
			return _OtrosMotivos;
		}
		set
		{
			if (!string.Equals(_OtrosMotivos, value))
			{
				SendPropertyChanging();
				_OtrosMotivos = value;
				SendPropertyChanged("OtrosMotivos");
			}
		}
	}

	[Column(Storage = "_FechaFinVinculo", DbType = "DateTime")]
	public DateTime? FechaFinVinculo
	{
		get
		{
			return _FechaFinVinculo;
		}
		set
		{
			if (!_FechaFinVinculo.Equals(value))
			{
				SendPropertyChanging();
				_FechaFinVinculo = value;
				SendPropertyChanged("FechaFinVinculo");
			}
		}
	}

	[Column(Storage = "_Reevaluar", DbType = "Char(1)")]
	public char? Reevaluar
	{
		get
		{
			return _Reevaluar;
		}
		set
		{
			if (!_Reevaluar.Equals(value))
			{
				SendPropertyChanging();
				_Reevaluar = value;
				SendPropertyChanged("Reevaluar");
			}
		}
	}

	[Association(Name = "EstadoCivil_RRHH_Asegurado", Storage = "_EstadoCivil", ThisKey = "idEstadoCivil", OtherKey = "IdEstadoCivil", IsForeignKey = true)]
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
					previousValue.RRHH_Asegurados.Remove(this);
				}
				_EstadoCivil.Entity = value;
				if (value != null)
				{
					value.RRHH_Asegurados.Add(this);
					_idEstadoCivil = value.IdEstadoCivil;
				}
				else
				{
					_idEstadoCivil = null;
				}
				SendPropertyChanged("EstadoCivil");
			}
		}
	}

	[Association(Name = "MotivoBaja_RRHH_Asegurado", Storage = "_MotivoBaja", ThisKey = "idMotivoBaja", OtherKey = "idMotivoBaja", IsForeignKey = true)]
	public MotivoBaja MotivoBaja
	{
		get
		{
			return _MotivoBaja.Entity;
		}
		set
		{
			MotivoBaja previousValue = _MotivoBaja.Entity;
			if (!object.Equals(previousValue, value) || !_MotivoBaja.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_MotivoBaja.Entity = null;
					previousValue.RRHH_Asegurados.Remove(this);
				}
				_MotivoBaja.Entity = value;
				if (value != null)
				{
					value.RRHH_Asegurados.Add(this);
					_idMotivoBaja = value.idMotivoBaja;
				}
				else
				{
					_idMotivoBaja = null;
				}
				SendPropertyChanged("MotivoBaja");
			}
		}
	}

	[Association(Name = "Persona_RRHH_Asegurado", Storage = "_Persona", ThisKey = "idPersona", OtherKey = "IdPersona", IsForeignKey = true)]
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
					previousValue.RRHH_Asegurados.Remove(this);
				}
				_Persona.Entity = value;
				if (value != null)
				{
					value.RRHH_Asegurados.Add(this);
					_idPersona = value.IdPersona;
				}
				else
				{
					_idPersona = null;
				}
				SendPropertyChanged("Persona");
			}
		}
	}

	[Association(Name = "Empleado_RRHH_Asegurado", Storage = "_Empleado", ThisKey = "idEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.RRHH_Asegurados.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.RRHH_Asegurados.Add(this);
					_idEmpleado = value.IdEmpleado;
				}
				else
				{
					_idEmpleado = 0;
				}
				SendPropertyChanged("Empleado");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public RRHH_Asegurado()
	{
		_EstadoCivil = default(EntityRef<EstadoCivil>);
		_MotivoBaja = default(EntityRef<MotivoBaja>);
		_Persona = default(EntityRef<Persona>);
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
