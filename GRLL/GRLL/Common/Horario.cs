using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Horario")]
public class Horario : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idHorario;

	private string _Ingreso1;

	private string _Salida1;

	private string _Ingreso2;

	private string _Salida2;

	private string _Descrip_Horario;

	private bool? _Estado;

	private EntitySet<Empleado> _Empleados;

	private EntitySet<HorarioTemporal> _HorarioTemporals;

	[Column(Storage = "_idHorario", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idHorario
	{
		get
		{
			return _idHorario;
		}
		set
		{
			if (_idHorario != value)
			{
				SendPropertyChanging();
				_idHorario = value;
				SendPropertyChanged("idHorario");
			}
		}
	}

	[Column(Storage = "_Ingreso1", DbType = "Char(8)")]
	public string Ingreso1
	{
		get
		{
			return _Ingreso1;
		}
		set
		{
			if (!string.Equals(_Ingreso1, value))
			{
				SendPropertyChanging();
				_Ingreso1 = value;
				SendPropertyChanged("Ingreso1");
			}
		}
	}

	[Column(Storage = "_Salida1", DbType = "Char(8)")]
	public string Salida1
	{
		get
		{
			return _Salida1;
		}
		set
		{
			if (!string.Equals(_Salida1, value))
			{
				SendPropertyChanging();
				_Salida1 = value;
				SendPropertyChanged("Salida1");
			}
		}
	}

	[Column(Storage = "_Ingreso2", DbType = "Char(8)")]
	public string Ingreso2
	{
		get
		{
			return _Ingreso2;
		}
		set
		{
			if (!string.Equals(_Ingreso2, value))
			{
				SendPropertyChanging();
				_Ingreso2 = value;
				SendPropertyChanged("Ingreso2");
			}
		}
	}

	[Column(Storage = "_Salida2", DbType = "Char(8)")]
	public string Salida2
	{
		get
		{
			return _Salida2;
		}
		set
		{
			if (!string.Equals(_Salida2, value))
			{
				SendPropertyChanging();
				_Salida2 = value;
				SendPropertyChanged("Salida2");
			}
		}
	}

	[Column(Storage = "_Descrip_Horario", DbType = "VarChar(20)")]
	public string Descrip_Horario
	{
		get
		{
			return _Descrip_Horario;
		}
		set
		{
			if (!string.Equals(_Descrip_Horario, value))
			{
				SendPropertyChanging();
				_Descrip_Horario = value;
				SendPropertyChanged("Descrip_Horario");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Bit")]
	public bool? Estado
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

	[Association(Name = "Horario_Empleado", Storage = "_Empleados", ThisKey = "idHorario", OtherKey = "idHorario")]
	public EntitySet<Empleado> Empleados
	{
		get
		{
			return _Empleados;
		}
		set
		{
			_Empleados.Assign(value);
		}
	}

	[Association(Name = "Horario_HorarioTemporal", Storage = "_HorarioTemporals", ThisKey = "idHorario", OtherKey = "HorarioAsignado")]
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

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Horario()
	{
		_Empleados = new EntitySet<Empleado>(attach_Empleados, detach_Empleados);
		_HorarioTemporals = new EntitySet<HorarioTemporal>(attach_HorarioTemporals, detach_HorarioTemporals);
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

	private void attach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.Horario = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.Horario = null;
	}

	private void attach_HorarioTemporals(HorarioTemporal entity)
	{
		SendPropertyChanging();
		entity.Horario = this;
	}

	private void detach_HorarioTemporals(HorarioTemporal entity)
	{
		SendPropertyChanging();
		entity.Horario = null;
	}
}
