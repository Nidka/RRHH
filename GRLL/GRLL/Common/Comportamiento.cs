using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Comportamiento")]
public class Comportamiento : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idComportamiento;

	private DateTime? _Fecha;

	private int? _IdEmpleado;

	private string _NumResol;

	private string _Titulo;

	private string _Descripcion;

	private int? _idTipoComportamiento;

	private EntityRef<TipoComportamiento> _TipoComportamiento;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_idComportamiento", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idComportamiento
	{
		get
		{
			return _idComportamiento;
		}
		set
		{
			if (_idComportamiento != value)
			{
				SendPropertyChanging();
				_idComportamiento = value;
				SendPropertyChanged("idComportamiento");
			}
		}
	}

	[Column(Storage = "_Fecha", DbType = "DateTime")]
	public DateTime? Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!_Fecha.Equals(value))
			{
				SendPropertyChanging();
				_Fecha = value;
				SendPropertyChanged("Fecha");
			}
		}
	}

	[Column(Storage = "_IdEmpleado", DbType = "Int")]
	public int? IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (!_IdEmpleado.Equals(value))
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

	[Column(Storage = "_NumResol", DbType = "VarChar(200)")]
	public string NumResol
	{
		get
		{
			return _NumResol;
		}
		set
		{
			if (!string.Equals(_NumResol, value))
			{
				SendPropertyChanging();
				_NumResol = value;
				SendPropertyChanged("NumResol");
			}
		}
	}

	[Column(Storage = "_Titulo", DbType = "VarChar(1000)")]
	public string Titulo
	{
		get
		{
			return _Titulo;
		}
		set
		{
			if (!string.Equals(_Titulo, value))
			{
				SendPropertyChanging();
				_Titulo = value;
				SendPropertyChanged("Titulo");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(2000)")]
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
				SendPropertyChanging();
				_Descripcion = value;
				SendPropertyChanged("Descripcion");
			}
		}
	}

	[Column(Storage = "_idTipoComportamiento", DbType = "Int")]
	public int? idTipoComportamiento
	{
		get
		{
			return _idTipoComportamiento;
		}
		set
		{
			if (!_idTipoComportamiento.Equals(value))
			{
				if (_TipoComportamiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idTipoComportamiento = value;
				SendPropertyChanged("idTipoComportamiento");
			}
		}
	}

	[Association(Name = "TipoComportamiento_Comportamiento", Storage = "_TipoComportamiento", ThisKey = "idTipoComportamiento", OtherKey = "idTipoComportamiento", IsForeignKey = true)]
	public TipoComportamiento TipoComportamiento
	{
		get
		{
			return _TipoComportamiento.Entity;
		}
		set
		{
			TipoComportamiento previousValue = _TipoComportamiento.Entity;
			if (!object.Equals(previousValue, value) || !_TipoComportamiento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoComportamiento.Entity = null;
					previousValue.Comportamiento.Remove(this);
				}
				_TipoComportamiento.Entity = value;
				if (value != null)
				{
					value.Comportamiento.Add(this);
					_idTipoComportamiento = value.idTipoComportamiento;
				}
				else
				{
					_idTipoComportamiento = null;
				}
				SendPropertyChanged("TipoComportamiento");
			}
		}
	}

	[Association(Name = "Empleado_Comportamiento", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.Comportamientos.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Comportamientos.Add(this);
					_IdEmpleado = value.IdEmpleado;
				}
				else
				{
					_IdEmpleado = null;
				}
				SendPropertyChanged("Empleado");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Comportamiento()
	{
		_TipoComportamiento = default(EntityRef<TipoComportamiento>);
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
