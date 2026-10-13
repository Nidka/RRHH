using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Capacitacion")]
public class Capacitacion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdCapacitacion;

	private string _NombreCurso;

	private DateTime? _FechaInicio;

	private DateTime? _FechaFin;

	private string _NumHoras;

	private string _InstitucionOrganizadora;

	private int? _IdEmpleado;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_IdCapacitacion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdCapacitacion
	{
		get
		{
			return _IdCapacitacion;
		}
		set
		{
			if (_IdCapacitacion != value)
			{
				SendPropertyChanging();
				_IdCapacitacion = value;
				SendPropertyChanged("IdCapacitacion");
			}
		}
	}

	[Column(Storage = "_NombreCurso", DbType = "VarChar(300)")]
	public string NombreCurso
	{
		get
		{
			return _NombreCurso;
		}
		set
		{
			if (!string.Equals(_NombreCurso, value))
			{
				SendPropertyChanging();
				_NombreCurso = value;
				SendPropertyChanged("NombreCurso");
			}
		}
	}

	[Column(Storage = "_FechaInicio", DbType = "DateTime")]
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

	[Column(Storage = "_FechaFin", DbType = "DateTime")]
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

	[Column(Storage = "_NumHoras", DbType = "VarChar(5)")]
	public string NumHoras
	{
		get
		{
			return _NumHoras;
		}
		set
		{
			if (!string.Equals(_NumHoras, value))
			{
				SendPropertyChanging();
				_NumHoras = value;
				SendPropertyChanged("NumHoras");
			}
		}
	}

	[Column(Storage = "_InstitucionOrganizadora", DbType = "VarChar(300)")]
	public string InstitucionOrganizadora
	{
		get
		{
			return _InstitucionOrganizadora;
		}
		set
		{
			if (!string.Equals(_InstitucionOrganizadora, value))
			{
				SendPropertyChanging();
				_InstitucionOrganizadora = value;
				SendPropertyChanged("InstitucionOrganizadora");
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

	[Association(Name = "Empleado_Capacitacion", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.Capacitacions.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Capacitacions.Add(this);
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

	public Capacitacion()
	{
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
