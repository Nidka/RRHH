using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Rol_Acceso")]
public class Rol_Acceso : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdRol;

	private string _Permiso;

	private string _IdSistemaOpcion;

	private EntityRef<Rol> _Rol;

	private EntityRef<SistemaOpcion> _SistemaOpcion;

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

	[Column(Storage = "_Permiso", DbType = "Char(8)")]
	public string Permiso
	{
		get
		{
			return _Permiso;
		}
		set
		{
			if (!string.Equals(_Permiso, value))
			{
				SendPropertyChanging();
				_Permiso = value;
				SendPropertyChanged("Permiso");
			}
		}
	}

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
				if (_SistemaOpcion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdSistemaOpcion = value;
				SendPropertyChanged("IdSistemaOpcion");
			}
		}
	}

	[Association(Name = "Rol_Rol_Acceso", Storage = "_Rol", ThisKey = "IdRol", OtherKey = "IdRol", IsForeignKey = true)]
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
					previousValue.Rol_Acceso.Remove(this);
				}
				_Rol.Entity = value;
				if (value != null)
				{
					value.Rol_Acceso.Add(this);
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

	[Association(Name = "SistemaOpcion_Rol_Acceso", Storage = "_SistemaOpcion", ThisKey = "IdSistemaOpcion", OtherKey = "IdSistemaOpcion", IsForeignKey = true)]
	public SistemaOpcion SistemaOpcion
	{
		get
		{
			return _SistemaOpcion.Entity;
		}
		set
		{
			SistemaOpcion previousValue = _SistemaOpcion.Entity;
			if (!object.Equals(previousValue, value) || !_SistemaOpcion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_SistemaOpcion.Entity = null;
					previousValue.Rol_Acceso.Remove(this);
				}
				_SistemaOpcion.Entity = value;
				if (value != null)
				{
					value.Rol_Acceso.Add(this);
					_IdSistemaOpcion = value.IdSistemaOpcion;
				}
				else
				{
					_IdSistemaOpcion = null;
				}
				SendPropertyChanged("SistemaOpcion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Rol_Acceso()
	{
		_Rol = default(EntityRef<Rol>);
		_SistemaOpcion = default(EntityRef<SistemaOpcion>);
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
