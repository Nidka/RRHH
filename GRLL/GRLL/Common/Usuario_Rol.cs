using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Usuario_Rol")]
public class Usuario_Rol : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdUsuario;

	private int _IdRol;

	private EntityRef<Rol> _Rol;

	private EntityRef<Usuario> _Usuario;

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
				if (_Usuario.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdUsuario = value;
				SendPropertyChanged("IdUsuario");
			}
		}
	}

	[Column(Storage = "_IdRol", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdRol
	{
		get
		{
			return _IdRol;
		}
		set
		{
			if (_IdRol != value)
			{
				if (_Rol.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdRol = value;
				SendPropertyChanged("IdRol");
			}
		}
	}

	[Association(Name = "Rol_Usuario_Rol", Storage = "_Rol", ThisKey = "IdRol", OtherKey = "IdRol", IsForeignKey = true)]
	public Rol Rol
	{
		get
		{
			return _Rol.Entity;
		}
		set
		{
			Rol previousValue = _Rol.Entity;
			if (!object.Equals(previousValue, value) || !_Rol.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Rol.Entity = null;
					previousValue.Usuario_Rol.Remove(this);
				}
				_Rol.Entity = value;
				if (value != null)
				{
					value.Usuario_Rol.Add(this);
					_IdRol = value.IdRol;
				}
				else
				{
					_IdRol = 0;
				}
				SendPropertyChanged("Rol");
			}
		}
	}

	[Association(Name = "Usuario_Usuario_Rol", Storage = "_Usuario", ThisKey = "IdUsuario", OtherKey = "IdUsuario", IsForeignKey = true)]
	public Usuario Usuario
	{
		get
		{
			return _Usuario.Entity;
		}
		set
		{
			Usuario previousValue = _Usuario.Entity;
			if (!object.Equals(previousValue, value) || !_Usuario.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Usuario.Entity = null;
					previousValue.Usuario_Rol.Remove(this);
				}
				_Usuario.Entity = value;
				if (value != null)
				{
					value.Usuario_Rol.Add(this);
					_IdUsuario = value.IdUsuario;
				}
				else
				{
					_IdUsuario = 0;
				}
				SendPropertyChanged("Usuario");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Usuario_Rol()
	{
		_Rol = default(EntityRef<Rol>);
		_Usuario = default(EntityRef<Usuario>);
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
