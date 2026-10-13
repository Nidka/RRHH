using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.EstudiosRealizado")]
public class EstudiosRealizado : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdTipoEstudios;

	private int _IdEmpleado;

	private int _Correlativo;

	private string _CentroEstudios;

	private DateTime? _AñoInicio;

	private string _Especialidad;

	private DateTime? _AñoTermino;

	private int? _IdEstadoEstudio;

	private EntityRef<EstadoEstudio> _EstadoEstudio;

	private EntityRef<TipoEstudio> _TipoEstudio;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_IdTipoEstudios", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTipoEstudios
	{
		get
		{
			return _IdTipoEstudios;
		}
		set
		{
			if (_IdTipoEstudios != value)
			{
				if (_TipoEstudio.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoEstudios = value;
				SendPropertyChanged("IdTipoEstudios");
			}
		}
	}

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

	[Column(Storage = "_Correlativo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int Correlativo
	{
		get
		{
			return _Correlativo;
		}
		set
		{
			if (_Correlativo != value)
			{
				SendPropertyChanging();
				_Correlativo = value;
				SendPropertyChanged("Correlativo");
			}
		}
	}

	[Column(Storage = "_CentroEstudios", DbType = "VarChar(150)")]
	public string CentroEstudios
	{
		get
		{
			return _CentroEstudios;
		}
		set
		{
			if (!string.Equals(_CentroEstudios, value))
			{
				SendPropertyChanging();
				_CentroEstudios = value;
				SendPropertyChanged("CentroEstudios");
			}
		}
	}

	[Column(Storage = "_AñoInicio", DbType = "DateTime")]
	public DateTime? AñoInicio
	{
		get
		{
			return _AñoInicio;
		}
		set
		{
			if (!_AñoInicio.Equals(value))
			{
				SendPropertyChanging();
				_AñoInicio = value;
				SendPropertyChanged("AñoInicio");
			}
		}
	}

	[Column(Storage = "_Especialidad", DbType = "VarChar(100)")]
	public string Especialidad
	{
		get
		{
			return _Especialidad;
		}
		set
		{
			if (!string.Equals(_Especialidad, value))
			{
				SendPropertyChanging();
				_Especialidad = value;
				SendPropertyChanged("Especialidad");
			}
		}
	}

	[Column(Storage = "_AñoTermino", DbType = "DateTime")]
	public DateTime? AñoTermino
	{
		get
		{
			return _AñoTermino;
		}
		set
		{
			if (!_AñoTermino.Equals(value))
			{
				SendPropertyChanging();
				_AñoTermino = value;
				SendPropertyChanged("AñoTermino");
			}
		}
	}

	[Column(Storage = "_IdEstadoEstudio", DbType = "Int")]
	public int? IdEstadoEstudio
	{
		get
		{
			return _IdEstadoEstudio;
		}
		set
		{
			if (!_IdEstadoEstudio.Equals(value))
			{
				if (_EstadoEstudio.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdEstadoEstudio = value;
				SendPropertyChanged("IdEstadoEstudio");
			}
		}
	}

	[Association(Name = "EstadoEstudio_EstudiosRealizado", Storage = "_EstadoEstudio", ThisKey = "IdEstadoEstudio", OtherKey = "IdEstadoEstudio", IsForeignKey = true)]
	public EstadoEstudio EstadoEstudio
	{
		get
		{
			return _EstadoEstudio.Entity;
		}
		set
		{
			EstadoEstudio previousValue = _EstadoEstudio.Entity;
			if (!object.Equals(previousValue, value) || !_EstadoEstudio.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_EstadoEstudio.Entity = null;
					previousValue.EstudiosRealizados.Remove(this);
				}
				_EstadoEstudio.Entity = value;
				if (value != null)
				{
					value.EstudiosRealizados.Add(this);
					_IdEstadoEstudio = value.IdEstadoEstudio;
				}
				else
				{
					_IdEstadoEstudio = null;
				}
				SendPropertyChanged("EstadoEstudio");
			}
		}
	}

	[Association(Name = "TipoEstudio_EstudiosRealizado", Storage = "_TipoEstudio", ThisKey = "IdTipoEstudios", OtherKey = "IdTipoEstudios", IsForeignKey = true)]
	public TipoEstudio TipoEstudio
	{
		get
		{
			return _TipoEstudio.Entity;
		}
		set
		{
			TipoEstudio previousValue = _TipoEstudio.Entity;
			if (!object.Equals(previousValue, value) || !_TipoEstudio.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoEstudio.Entity = null;
					previousValue.EstudiosRealizados.Remove(this);
				}
				_TipoEstudio.Entity = value;
				if (value != null)
				{
					value.EstudiosRealizados.Add(this);
					_IdTipoEstudios = value.IdTipoEstudios;
				}
				else
				{
					_IdTipoEstudios = 0;
				}
				SendPropertyChanged("TipoEstudio");
			}
		}
	}

	[Association(Name = "Empleado_EstudiosRealizado", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.EstudiosRealizados.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.EstudiosRealizados.Add(this);
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

	public EstudiosRealizado()
	{
		_EstadoEstudio = default(EntityRef<EstadoEstudio>);
		_TipoEstudio = default(EntityRef<TipoEstudio>);
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
