using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TipoTrabajador")]
public class TipoTrabajador : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdTipoTrabajador;

	private string _Descripcion;

	private string _Observaciones;

	private EntitySet<Empleado> _Empleados;

	[Column(Storage = "_IdTipoTrabajador", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTipoTrabajador
	{
		get
		{
			return _IdTipoTrabajador;
		}
		set
		{
			if (_IdTipoTrabajador != value)
			{
				SendPropertyChanging();
				_IdTipoTrabajador = value;
				SendPropertyChanged("IdTipoTrabajador");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(30)")]
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

	[Column(Storage = "_Observaciones", DbType = "VarChar(150)")]
	public string Observaciones
	{
		get
		{
			return _Observaciones;
		}
		set
		{
			if (!string.Equals(_Observaciones, value))
			{
				SendPropertyChanging();
				_Observaciones = value;
				SendPropertyChanged("Observaciones");
			}
		}
	}

	[Association(Name = "TipoTrabajador_Empleado", Storage = "_Empleados", ThisKey = "IdTipoTrabajador", OtherKey = "IdTipoTrabajador")]
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

	public TipoTrabajador()
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
		entity.TipoTrabajador = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.TipoTrabajador = null;
	}
}
