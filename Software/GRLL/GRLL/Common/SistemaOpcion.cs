using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.SistemaOpcion")]
public class SistemaOpcion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdSistemaOpcion;

	private string _Descripcion;

	private bool? _ConClave;

	private string _Clave;

	private EntitySet<Operacion> _Operacion;

	private EntitySet<Rol_Acceso> _Rol_Acceso;

	[Column(Storage = "_IdSistemaOpcion", DbType = "Char(7) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdSistemaOpcion
	{
		get
		{
			return _IdSistemaOpcion;
		}
		set
		{
			if (!string.Equals(_IdSistemaOpcion, value))
			{
				SendPropertyChanging();
				_IdSistemaOpcion = value;
				SendPropertyChanged("IdSistemaOpcion");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(150)")]
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

	[Column(Storage = "_ConClave", DbType = "Bit")]
	public bool? ConClave
	{
		get
		{
			return _ConClave;
		}
		set
		{
			if (!_ConClave.Equals(value))
			{
				SendPropertyChanging();
				_ConClave = value;
				SendPropertyChanged("ConClave");
			}
		}
	}

	[Column(Storage = "_Clave", DbType = "VarChar(30)")]
	public string Clave
	{
		get
		{
			return _Clave;
		}
		set
		{
			if (!string.Equals(_Clave, value))
			{
				SendPropertyChanging();
				_Clave = value;
				SendPropertyChanged("Clave");
			}
		}
	}

	[Association(Name = "SistemaOpcion_Operacion", Storage = "_Operacion", ThisKey = "IdSistemaOpcion", OtherKey = "IdSistemaOpcion")]
	public EntitySet<Operacion> Operacion
	{
		get
		{
			return _Operacion;
		}
		set
		{
			_Operacion.Assign(value);
		}
	}

	[Association(Name = "SistemaOpcion_Rol_Acceso", Storage = "_Rol_Acceso", ThisKey = "IdSistemaOpcion", OtherKey = "IdSistemaOpcion")]
	public EntitySet<Rol_Acceso> Rol_Acceso
	{
		get
		{
			return _Rol_Acceso;
		}
		set
		{
			_Rol_Acceso.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public SistemaOpcion()
	{
		_Operacion = new EntitySet<Operacion>(attach_Operacion, detach_Operacion);
		_Rol_Acceso = new EntitySet<Rol_Acceso>(attach_Rol_Acceso, detach_Rol_Acceso);
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

	private void attach_Operacion(Operacion entity)
	{
		SendPropertyChanging();
		entity.SistemaOpcion = this;
	}

	private void detach_Operacion(Operacion entity)
	{
		SendPropertyChanging();
		entity.SistemaOpcion = null;
	}

	private void attach_Rol_Acceso(Rol_Acceso entity)
	{
		SendPropertyChanging();
		entity.SistemaOpcion = this;
	}

	private void detach_Rol_Acceso(Rol_Acceso entity)
	{
		SendPropertyChanging();
		entity.SistemaOpcion = null;
	}
}
