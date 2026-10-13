using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Motivo_Perm")]
public class Motivo_Perm : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idMotivo;

	private string _Descrip_Motivo;

	private bool? _Salario;

	private int? _idTipoPermiso;

	private string _Abrev;

	private char? _TipoModalidad;

	private bool? _Activo;

	private EntitySet<Permiso> _Permisos;

	private EntityRef<TipoPermiso> _TipoPermiso;

	[Column(Storage = "_idMotivo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idMotivo
	{
		get
		{
			return _idMotivo;
		}
		set
		{
			if (_idMotivo != value)
			{
				SendPropertyChanging();
				_idMotivo = value;
				SendPropertyChanged("idMotivo");
			}
		}
	}

	[Column(Storage = "_Descrip_Motivo", DbType = "VarChar(50)")]
	public string Descrip_Motivo
	{
		get
		{
			return _Descrip_Motivo;
		}
		set
		{
			if (!string.Equals(_Descrip_Motivo, value))
			{
				SendPropertyChanging();
				_Descrip_Motivo = value;
				SendPropertyChanged("Descrip_Motivo");
			}
		}
	}

	[Column(Storage = "_Salario", DbType = "Bit")]
	public bool? Salario
	{
		get
		{
			return _Salario;
		}
		set
		{
			if (!_Salario.Equals(value))
			{
				SendPropertyChanging();
				_Salario = value;
				SendPropertyChanged("Salario");
			}
		}
	}

	[Column(Storage = "_idTipoPermiso", DbType = "Int")]
	public int? idTipoPermiso
	{
		get
		{
			return _idTipoPermiso;
		}
		set
		{
			if (!_idTipoPermiso.Equals(value))
			{
				if (_TipoPermiso.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idTipoPermiso = value;
				SendPropertyChanged("idTipoPermiso");
			}
		}
	}

	[Column(Storage = "_Abrev", DbType = "Char(2)")]
	public string Abrev
	{
		get
		{
			return _Abrev;
		}
		set
		{
			if (!string.Equals(_Abrev, value))
			{
				SendPropertyChanging();
				_Abrev = value;
				SendPropertyChanged("Abrev");
			}
		}
	}

	[Column(Storage = "_TipoModalidad", DbType = "Char(1)")]
	public char? TipoModalidad
	{
		get
		{
			return _TipoModalidad;
		}
		set
		{
			if (!_TipoModalidad.Equals(value))
			{
				SendPropertyChanging();
				_TipoModalidad = value;
				SendPropertyChanged("TipoModalidad");
			}
		}
	}

	[Column(Storage = "_Activo", DbType = "Bit")]
	public bool? Activo
	{
		get
		{
			return _Activo;
		}
		set
		{
			if (!_Activo.Equals(value))
			{
				SendPropertyChanging();
				_Activo = value;
				SendPropertyChanged("Activo");
			}
		}
	}

	[Association(Name = "Motivo_Perm_Permiso", Storage = "_Permisos", ThisKey = "idMotivo", OtherKey = "idMotivo")]
	public EntitySet<Permiso> Permisos
	{
		get
		{
			return _Permisos;
		}
		set
		{
			_Permisos.Assign(value);
		}
	}

	[Association(Name = "TipoPermiso_Motivo_Perm", Storage = "_TipoPermiso", ThisKey = "idTipoPermiso", OtherKey = "idTipoPermiso", IsForeignKey = true)]
	public TipoPermiso TipoPermiso
	{
		get
		{
			return _TipoPermiso.Entity;
		}
		set
		{
			TipoPermiso previousValue = _TipoPermiso.Entity;
			if (!object.Equals(previousValue, value) || !_TipoPermiso.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoPermiso.Entity = null;
					previousValue.Motivo_Perms.Remove(this);
				}
				_TipoPermiso.Entity = value;
				if (value != null)
				{
					value.Motivo_Perms.Add(this);
					_idTipoPermiso = value.idTipoPermiso;
				}
				else
				{
					_idTipoPermiso = null;
				}
				SendPropertyChanged("TipoPermiso");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Motivo_Perm()
	{
		_Permisos = new EntitySet<Permiso>(attach_Permisos, detach_Permisos);
		_TipoPermiso = default(EntityRef<TipoPermiso>);
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

	private void attach_Permisos(Permiso entity)
	{
		SendPropertyChanging();
		entity.Motivo_Perm = this;
	}

	private void detach_Permisos(Permiso entity)
	{
		SendPropertyChanging();
		entity.Motivo_Perm = null;
	}
}
