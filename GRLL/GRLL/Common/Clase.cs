using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Clase")]
public class Clase : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdClase;

	private string _Descripcion;

	private string _Observaciones;

	private string _IdGrupo;

	private EntitySet<Familia> _Familia;

	private EntityRef<Grupo> _Grupo;

	[Column(Storage = "_IdClase", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdClase
	{
		get
		{
			return _IdClase;
		}
		set
		{
			if (!string.Equals(_IdClase, value))
			{
				SendPropertyChanging();
				_IdClase = value;
				SendPropertyChanged("IdClase");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(120)")]
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

	[Column(Storage = "_Observaciones", DbType = "VarChar(120)")]
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

	[Column(Storage = "_IdGrupo", DbType = "Char(3) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdGrupo
	{
		get
		{
			return _IdGrupo;
		}
		set
		{
			if (!string.Equals(_IdGrupo, value))
			{
				if (_Grupo.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdGrupo = value;
				SendPropertyChanged("IdGrupo");
			}
		}
	}

	[Association(Name = "Clase_Familia", Storage = "_Familia", ThisKey = "IdClase,IdGrupo", OtherKey = "IdClase,IdGrupo")]
	public EntitySet<Familia> Familia
	{
		get
		{
			return _Familia;
		}
		set
		{
			_Familia.Assign(value);
		}
	}

	[Association(Name = "Grupo_Clase", Storage = "_Grupo", ThisKey = "IdGrupo", OtherKey = "IdGrupo", IsForeignKey = true)]
	public Grupo Grupo
	{
		get
		{
			return _Grupo.Entity;
		}
		set
		{
			Grupo previousValue = _Grupo.Entity;
			if (!object.Equals(previousValue, value) || !_Grupo.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Grupo.Entity = null;
					previousValue.Clase.Remove(this);
				}
				_Grupo.Entity = value;
				if (value != null)
				{
					value.Clase.Add(this);
					_IdGrupo = value.IdGrupo;
				}
				else
				{
					_IdGrupo = null;
				}
				SendPropertyChanged("Grupo");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Clase()
	{
		_Familia = new EntitySet<Familia>(attach_Familia, detach_Familia);
		_Grupo = default(EntityRef<Grupo>);
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

	private void attach_Familia(Familia entity)
	{
		SendPropertyChanging();
		entity.Clase = this;
	}

	private void detach_Familia(Familia entity)
	{
		SendPropertyChanging();
		entity.Clase = null;
	}
}
