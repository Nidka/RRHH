using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TitulosEmpleado")]
public class TitulosEmpleado : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _NumColegiatura;

	private string _DenominacionGrado;

	private string _Institucion;

	private DateTime? _Fecha;

	private int? _IdEmpleado;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_NumColegiatura", DbType = "VarChar(20) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string NumColegiatura
	{
		get
		{
			return _NumColegiatura;
		}
		set
		{
			if (!string.Equals(_NumColegiatura, value))
			{
				SendPropertyChanging();
				_NumColegiatura = value;
				SendPropertyChanged("NumColegiatura");
			}
		}
	}

	[Column(Storage = "_DenominacionGrado", DbType = "VarChar(100)")]
	public string DenominacionGrado
	{
		get
		{
			return _DenominacionGrado;
		}
		set
		{
			if (!string.Equals(_DenominacionGrado, value))
			{
				SendPropertyChanging();
				_DenominacionGrado = value;
				SendPropertyChanged("DenominacionGrado");
			}
		}
	}

	[Column(Storage = "_Institucion", DbType = "VarChar(60)")]
	public string Institucion
	{
		get
		{
			return _Institucion;
		}
		set
		{
			if (!string.Equals(_Institucion, value))
			{
				SendPropertyChanging();
				_Institucion = value;
				SendPropertyChanged("Institucion");
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

	[Association(Name = "Empleado_TitulosEmpleado", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.TitulosEmpleados.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.TitulosEmpleados.Add(this);
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

	public TitulosEmpleado()
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
