using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_FuncFam")]
public class RRHH_FuncFam : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idFuncFamiliar;

	private int? _IdEmpleado;

	private string _Com1;

	private string _Com2;

	private string _Afec1;

	private string _Afec2;

	private string _Decis1;

	private string _Decis2;

	private string _Soc1;

	private string _Soc2;

	private string _Soc3;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_idFuncFamiliar", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idFuncFamiliar
	{
		get
		{
			return _idFuncFamiliar;
		}
		set
		{
			if (_idFuncFamiliar != value)
			{
				SendPropertyChanging();
				_idFuncFamiliar = value;
				SendPropertyChanged("idFuncFamiliar");
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

	[Column(Storage = "_Com1", DbType = "VarChar(2)")]
	public string Com1
	{
		get
		{
			return _Com1;
		}
		set
		{
			if (!string.Equals(_Com1, value))
			{
				SendPropertyChanging();
				_Com1 = value;
				SendPropertyChanged("Com1");
			}
		}
	}

	[Column(Storage = "_Com2", DbType = "VarChar(2)")]
	public string Com2
	{
		get
		{
			return _Com2;
		}
		set
		{
			if (!string.Equals(_Com2, value))
			{
				SendPropertyChanging();
				_Com2 = value;
				SendPropertyChanged("Com2");
			}
		}
	}

	[Column(Storage = "_Afec1", DbType = "VarChar(2)")]
	public string Afec1
	{
		get
		{
			return _Afec1;
		}
		set
		{
			if (!string.Equals(_Afec1, value))
			{
				SendPropertyChanging();
				_Afec1 = value;
				SendPropertyChanged("Afec1");
			}
		}
	}

	[Column(Storage = "_Afec2", DbType = "VarChar(2)")]
	public string Afec2
	{
		get
		{
			return _Afec2;
		}
		set
		{
			if (!string.Equals(_Afec2, value))
			{
				SendPropertyChanging();
				_Afec2 = value;
				SendPropertyChanged("Afec2");
			}
		}
	}

	[Column(Storage = "_Decis1", DbType = "VarChar(2)")]
	public string Decis1
	{
		get
		{
			return _Decis1;
		}
		set
		{
			if (!string.Equals(_Decis1, value))
			{
				SendPropertyChanging();
				_Decis1 = value;
				SendPropertyChanged("Decis1");
			}
		}
	}

	[Column(Storage = "_Decis2", DbType = "VarChar(2)")]
	public string Decis2
	{
		get
		{
			return _Decis2;
		}
		set
		{
			if (!string.Equals(_Decis2, value))
			{
				SendPropertyChanging();
				_Decis2 = value;
				SendPropertyChanged("Decis2");
			}
		}
	}

	[Column(Storage = "_Soc1", DbType = "VarChar(2)")]
	public string Soc1
	{
		get
		{
			return _Soc1;
		}
		set
		{
			if (!string.Equals(_Soc1, value))
			{
				SendPropertyChanging();
				_Soc1 = value;
				SendPropertyChanged("Soc1");
			}
		}
	}

	[Column(Storage = "_Soc2", DbType = "VarChar(2)")]
	public string Soc2
	{
		get
		{
			return _Soc2;
		}
		set
		{
			if (!string.Equals(_Soc2, value))
			{
				SendPropertyChanging();
				_Soc2 = value;
				SendPropertyChanged("Soc2");
			}
		}
	}

	[Column(Storage = "_Soc3", DbType = "VarChar(2)")]
	public string Soc3
	{
		get
		{
			return _Soc3;
		}
		set
		{
			if (!string.Equals(_Soc3, value))
			{
				SendPropertyChanging();
				_Soc3 = value;
				SendPropertyChanged("Soc3");
			}
		}
	}

	[Association(Name = "Empleado_RRHH_FuncFam", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.RRHH_FuncFams.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.RRHH_FuncFams.Add(this);
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

	public RRHH_FuncFam()
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
