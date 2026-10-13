using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.PeriodoLaboral")]
public class PeriodoLaboral : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdEmpleado;

	private int _NroPeriodo;

	private string _NumResoIngreInstitu;

	private DateTime? _FechaSalida;

	private DateTime? _FechaResoIngreInstitu;

	private DateTime? _FechaIngreso;

	private bool? _Judicial;

	private string _Obs;

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

	[Column(Storage = "_NroPeriodo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int NroPeriodo
	{
		get
		{
			return _NroPeriodo;
		}
		set
		{
			if (_NroPeriodo != value)
			{
				SendPropertyChanging();
				_NroPeriodo = value;
				SendPropertyChanged("NroPeriodo");
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

	[Column(Storage = "_FechaSalida", DbType = "SmallDateTime")]
	public DateTime? FechaSalida
	{
		get
		{
			return _FechaSalida;
		}
		set
		{
			if (!_FechaSalida.Equals(value))
			{
				SendPropertyChanging();
				_FechaSalida = value;
				SendPropertyChanged("FechaSalida");
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

	[Column(Storage = "_Judicial", DbType = "Bit")]
	public bool? Judicial
	{
		get
		{
			return _Judicial;
		}
		set
		{
			if (!_Judicial.Equals(value))
			{
				SendPropertyChanging();
				_Judicial = value;
				SendPropertyChanged("Judicial");
			}
		}
	}

	[Column(Storage = "_Obs", DbType = "VarChar(2000)")]
	public string Obs
	{
		get
		{
			return _Obs;
		}
		set
		{
			if (!string.Equals(_Obs, value))
			{
				SendPropertyChanging();
				_Obs = value;
				SendPropertyChanged("Obs");
			}
		}
	}

	[Association(Name = "Empleado_PeriodoLaboral", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.PeriodoLaborals.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.PeriodoLaborals.Add(this);
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

	public PeriodoLaboral()
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
