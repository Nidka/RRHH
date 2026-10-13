using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Rol")]
public class Rol : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdRol;

	private string _Descripcion;

	private string _IdSistema;

	private EntitySet<Rol_Acceso> _Rol_Acceso;

	private EntitySet<Usuario_Rol> _Usuario_Rol;

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
				SendPropertyChanging();
				_IdRol = value;
				SendPropertyChanged("IdRol");
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

	[Column(Storage = "_IdSistema", DbType = "Char(7)")]
	public string IdSistema
	{
		get
		{
			return _IdSistema;
		}
		set
		{
			if (!string.Equals(_IdSistema, value))
			{
				SendPropertyChanging();
				_IdSistema = value;
				SendPropertyChanged("IdSistema");
			}
		}
	}

	[Association(Name = "Rol_Rol_Acceso", Storage = "_Rol_Acceso", ThisKey = "IdRol", OtherKey = "IdRol")]
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

	[Association(Name = "Rol_Usuario_Rol", Storage = "_Usuario_Rol", ThisKey = "IdRol", OtherKey = "IdRol")]
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

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Rol()
	{
		_Rol_Acceso = new EntitySet<Rol_Acceso>(attach_Rol_Acceso, detach_Rol_Acceso);
		_Usuario_Rol = new EntitySet<Usuario_Rol>(attach_Usuario_Rol, detach_Usuario_Rol);
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

	private void attach_Rol_Acceso(Rol_Acceso entity)
	{
		SendPropertyChanging();
		entity.Rol = this;
	}

	private void detach_Rol_Acceso(Rol_Acceso entity)
	{
		SendPropertyChanging();
		entity.Rol = null;
	}

	private void attach_Usuario_Rol(Usuario_Rol entity)
	{
		SendPropertyChanging();
		entity.Rol = this;
	}

	private void detach_Usuario_Rol(Usuario_Rol entity)
	{
		SendPropertyChanging();
		entity.Rol = null;
	}
}
