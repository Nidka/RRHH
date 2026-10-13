using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Resolucion")]
public class Resolucion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idEmpleado;

	private int _idResolucion;

	private int? _idTipoResolucion;

	private DateTime? _FechaResolucion;

	private string _NumeroResolucion;

	private EntityRef<Empleado> _Empleado;

	private EntityRef<TipoResolucion> _TipoResolucion;

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

	[Column(Storage = "_idResolucion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idResolucion
	{
		get
		{
			return _idResolucion;
		}
		set
		{
			if (_idResolucion != value)
			{
				SendPropertyChanging();
				_idResolucion = value;
				SendPropertyChanged("idResolucion");
			}
		}
	}

	[Column(Storage = "_idTipoResolucion", DbType = "Int")]
	public int? idTipoResolucion
	{
		get
		{
			return _idTipoResolucion;
		}
		set
		{
			if (!_idTipoResolucion.Equals(value))
			{
				if (_TipoResolucion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idTipoResolucion = value;
				SendPropertyChanged("idTipoResolucion");
			}
		}
	}

	[Column(Storage = "_FechaResolucion", DbType = "Date")]
	public DateTime? FechaResolucion
	{
		get
		{
			return _FechaResolucion;
		}
		set
		{
			if (!_FechaResolucion.Equals(value))
			{
				SendPropertyChanging();
				_FechaResolucion = value;
				SendPropertyChanged("FechaResolucion");
			}
		}
	}

	[Column(Storage = "_NumeroResolucion", DbType = "NVarChar(50)")]
	public string NumeroResolucion
	{
		get
		{
			return _NumeroResolucion;
		}
		set
		{
			if (!string.Equals(_NumeroResolucion, value))
			{
				SendPropertyChanging();
				_NumeroResolucion = value;
				SendPropertyChanged("NumeroResolucion");
			}
		}
	}

	[Association(Name = "Empleado_Resolucion", Storage = "_Empleado", ThisKey = "idEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.Resolucions.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Resolucions.Add(this);
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

	[Association(Name = "TipoResolucion_Resolucion", Storage = "_TipoResolucion", ThisKey = "idTipoResolucion", OtherKey = "idTipoResolucion", IsForeignKey = true)]
	public TipoResolucion TipoResolucion
	{
		get
		{
			return _TipoResolucion.Entity;
		}
		set
		{
			TipoResolucion previousValue = _TipoResolucion.Entity;
			if (!object.Equals(previousValue, value) || !_TipoResolucion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoResolucion.Entity = null;
					previousValue.Resolucions.Remove(this);
				}
				_TipoResolucion.Entity = value;
				if (value != null)
				{
					value.Resolucions.Add(this);
					_idTipoResolucion = value.idTipoResolucion;
				}
				else
				{
					_idTipoResolucion = null;
				}
				SendPropertyChanged("TipoResolucion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Resolucion()
	{
		_Empleado = default(EntityRef<Empleado>);
		_TipoResolucion = default(EntityRef<TipoResolucion>);
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
