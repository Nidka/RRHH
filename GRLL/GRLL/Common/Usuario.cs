using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Usuario")]
public class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdUsuario;

	private string _Login;

	private string _Descripcion;

	private DateTime? _Fecha;

	private bool? _Estado;

	private int? _IdEmpleado;

	private EntitySet<Alerta> _Alerta;

	private EntitySet<Alerta> _Alerta1;

	private EntitySet<Usuario_Rol> _Usuario_Rol;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_IdUsuario", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdUsuario
	{
		get
		{
			return _IdUsuario;
		}
		set
		{
			if (_IdUsuario != value)
			{
				SendPropertyChanging();
				_IdUsuario = value;
				SendPropertyChanged("IdUsuario");
			}
		}
	}

	[Column(Storage = "_Login", DbType = "Char(20)")]
	public string Login
	{
		get
		{
			return _Login;
		}
		set
		{
			if (!string.Equals(_Login, value))
			{
				SendPropertyChanging();
				_Login = value;
				SendPropertyChanged("Login");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(40)")]
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

	[Association(Name = "Usuario_Alerta", Storage = "_Alerta", ThisKey = "IdUsuario", OtherKey = "IdUsuario2")]
	public EntitySet<Alerta> Alerta
	{
		get
		{
			return _Alerta;
		}
		set
		{
			_Alerta.Assign(value);
		}
	}

	[Association(Name = "Usuario_Alerta1", Storage = "_Alerta1", ThisKey = "IdUsuario", OtherKey = "IdUsuario1")]
	public EntitySet<Alerta> Alerta1
	{
		get
		{
			return _Alerta1;
		}
		set
		{
			_Alerta1.Assign(value);
		}
	}

	[Association(Name = "Usuario_Usuario_Rol", Storage = "_Usuario_Rol", ThisKey = "IdUsuario", OtherKey = "IdUsuario")]
	public EntitySet<Usuario_Rol> Usuario_Rol
	{
		get
		{
			return _Usuario_Rol;
		}
		set
		{
			_Usuario_Rol.Assign(value);
		}
	}

	[Association(Name = "Empleado_Usuario", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.Usuarios.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Usuarios.Add(this);
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

	public Usuario()
	{
		_Alerta = new EntitySet<Alerta>(attach_Alerta, detach_Alerta);
		_Alerta1 = new EntitySet<Alerta>(attach_Alerta1, detach_Alerta1);
		_Usuario_Rol = new EntitySet<Usuario_Rol>(attach_Usuario_Rol, detach_Usuario_Rol);
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

	private void attach_Alerta(Alerta entity)
	{
		SendPropertyChanging();
		entity.Usuario = this;
	}

	private void detach_Alerta(Alerta entity)
	{
		SendPropertyChanging();
		entity.Usuario = null;
	}

	private void attach_Alerta1(Alerta entity)
	{
		SendPropertyChanging();
		entity.Usuario1 = this;
	}

	private void detach_Alerta1(Alerta entity)
	{
		SendPropertyChanging();
		entity.Usuario1 = null;
	}

	private void attach_Usuario_Rol(Usuario_Rol entity)
	{
		SendPropertyChanging();
		entity.Usuario = this;
	}

	private void detach_Usuario_Rol(Usuario_Rol entity)
	{
		SendPropertyChanging();
		entity.Usuario = null;
	}
}
