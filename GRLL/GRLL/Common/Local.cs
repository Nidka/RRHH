using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Local")]
public class Local : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idLocal;

	private string _NombreLocal;

	private bool? _Estado;

	private EntitySet<Empleado> _Empleados;

	[Column(Storage = "_idLocal", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idLocal
	{
		get
		{
			return _idLocal;
		}
		set
		{
			if (_idLocal != value)
			{
				SendPropertyChanging();
				_idLocal = value;
				SendPropertyChanged("idLocal");
			}
		}
	}

	[Column(Storage = "_NombreLocal", DbType = "NVarChar(50)")]
	public string NombreLocal
	{
		get
		{
			return _NombreLocal;
		}
		set
		{
			if (!string.Equals(_NombreLocal, value))
			{
				SendPropertyChanging();
				_NombreLocal = value;
				SendPropertyChanged("NombreLocal");
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

	[Association(Name = "Local_Empleado", Storage = "_Empleados", ThisKey = "idLocal", OtherKey = "idLocal")]
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

	public Local()
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
		entity.Local = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.Local = null;
	}
}
