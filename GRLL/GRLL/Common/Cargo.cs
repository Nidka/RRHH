using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Cargo")]
public class Cargo : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdCargo;

	private string _Cargo;

	private string _Abreviatura;

	private EntitySet<Empleado> _Empleados;

	[Column(Storage = "_IdCargo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdCargo
	{
		get
		{
			return _IdCargo;
		}
		set
		{
			if (_IdCargo != value)
			{
				SendPropertyChanging();
				_IdCargo = value;
				SendPropertyChanged("IdCargo");
			}
		}
	}

	[Column(Name = "Cargo", Storage = "_Cargo", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string CargoValue
	{
		get
		{
			return _Cargo;
		}
		set
		{
			if (!string.Equals(_Cargo, value))
			{
				SendPropertyChanging();
				_Cargo = value;
				SendPropertyChanged("Cargo");
			}
		}
	}

	[Column(Storage = "_Abreviatura", DbType = "VarChar(8)")]
	public string Abreviatura
	{
		get
		{
			return _Abreviatura;
		}
		set
		{
			if (!string.Equals(_Abreviatura, value))
			{
				SendPropertyChanging();
				_Abreviatura = value;
				SendPropertyChanged("Abreviatura");
			}
		}
	}

	[Association(Name = "Cargo_Empleado", Storage = "_Empleados", ThisKey = "IdCargo", OtherKey = "IdCargo")]
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

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Cargo()
	{
		_Empleados = new EntitySet<Empleado>(attach_Empleados, detach_Empleados);
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
		entity.Cargo = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.Cargo = null;
	}
}
