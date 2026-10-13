using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.HorarioTemporal")]
public class HorarioTemporal : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idEmpleado;

	private int _N;

	private DateTime? _FechaInicio;

	private DateTime? _FechaFin;

	private int? _HorarioAsignado;

	private string _NroDocumento;

	private string _Sisgedo;

	private EntityRef<Empleado> _Empleado;

	private EntityRef<Horario> _Horario;

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

	[Column(Storage = "_N", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int N
	{
		get
		{
			return _N;
		}
		set
		{
			if (_N != value)
			{
				SendPropertyChanging();
				_N = value;
				SendPropertyChanged("N");
			}
		}
	}

	[Column(Storage = "_FechaInicio", DbType = "Date")]
	public DateTime? FechaInicio
	{
		get
		{
			return _FechaInicio;
		}
		set
		{
			if (!_FechaInicio.Equals(value))
			{
				SendPropertyChanging();
				_FechaInicio = value;
				SendPropertyChanged("FechaInicio");
			}
		}
	}

	[Column(Storage = "_FechaFin", DbType = "Date")]
	public DateTime? FechaFin
	{
		get
		{
			return _FechaFin;
		}
		set
		{
			if (!_FechaFin.Equals(value))
			{
				SendPropertyChanging();
				_FechaFin = value;
				SendPropertyChanged("FechaFin");
			}
		}
	}

	[Column(Storage = "_HorarioAsignado", DbType = "Int")]
	public int? HorarioAsignado
	{
		get
		{
			return _HorarioAsignado;
		}
		set
		{
			if (!_HorarioAsignado.Equals(value))
			{
				if (_Horario.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_HorarioAsignado = value;
				SendPropertyChanged("HorarioAsignado");
			}
		}
	}

	[Column(Storage = "_NroDocumento", DbType = "NVarChar(50)")]
	public string NroDocumento
	{
		get
		{
			return _NroDocumento;
		}
		set
		{
			if (!string.Equals(_NroDocumento, value))
			{
				SendPropertyChanging();
				_NroDocumento = value;
				SendPropertyChanged("NroDocumento");
			}
		}
	}

	[Column(Storage = "_Sisgedo", DbType = "NVarChar(50)")]
	public string Sisgedo
	{
		get
		{
			return _Sisgedo;
		}
		set
		{
			if (!string.Equals(_Sisgedo, value))
			{
				SendPropertyChanging();
				_Sisgedo = value;
				SendPropertyChanged("Sisgedo");
			}
		}
	}

	[Association(Name = "Empleado_HorarioTemporal", Storage = "_Empleado", ThisKey = "idEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.HorarioTemporals.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.HorarioTemporals.Add(this);
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

	[Association(Name = "Horario_HorarioTemporal", Storage = "_Horario", ThisKey = "HorarioAsignado", OtherKey = "idHorario", IsForeignKey = true)]
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
					previousValue.HorarioTemporals.Remove(this);
				}
				_Horario.Entity = value;
				if (value != null)
				{
					value.HorarioTemporals.Add(this);
					_HorarioAsignado = value.idHorario;
				}
				else
				{
					_HorarioAsignado = null;
				}
				SendPropertyChanged("Horario");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public HorarioTemporal()
	{
		_Empleado = default(EntityRef<Empleado>);
		_Horario = default(EntityRef<Horario>);
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
