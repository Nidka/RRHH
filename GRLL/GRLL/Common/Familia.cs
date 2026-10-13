using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Familia")]
public class Familia : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdFamilia;

	private string _Descripcion;

	private string _Observaciones;

	private string _IdClase;

	private string _IdGrupo;

	private EntitySet<Bien> _Bien;

	private EntityRef<Clase> _Clase;

	[Column(Storage = "_IdFamilia", DbType = "Char(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdFamilia
	{
		get
		{
			return _IdFamilia;
		}
		set
		{
			if (!string.Equals(_IdFamilia, value))
			{
				SendPropertyChanging();
				_IdFamilia = value;
				SendPropertyChanged("IdFamilia");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(140)")]
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
				if (_Clase.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdClase = value;
				SendPropertyChanged("IdClase");
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
				if (_Clase.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdGrupo = value;
				SendPropertyChanged("IdGrupo");
			}
		}
	}

	[Association(Name = "Familia_Bien", Storage = "_Bien", ThisKey = "IdFamilia,IdClase,IdGrupo", OtherKey = "IdFamilia,IdClase,IdGrupo")]
	public EntitySet<Bien> Bien
	{
		get
		{
			return _Bien;
		}
		set
		{
			_Bien.Assign(value);
		}
	}

	[Association(Name = "Clase_Familia", Storage = "_Clase", ThisKey = "IdClase,IdGrupo", OtherKey = "IdClase,IdGrupo", IsForeignKey = true)]
	public Clase Clase
	{
		get
		{
			return _Clase.Entity;
		}
		set
		{
			Clase previousValue = _Clase.Entity;
			if (!object.Equals(previousValue, value) || !_Clase.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Clase.Entity = null;
					previousValue.Familia.Remove(this);
				}
				_Clase.Entity = value;
				if (value != null)
				{
					value.Familia.Add(this);
					_IdClase = value.IdClase;
					_IdGrupo = value.IdGrupo;
				}
				else
				{
					_IdClase = null;
					_IdGrupo = null;
				}
				SendPropertyChanged("Clase");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Familia()
	{
		_Bien = new EntitySet<Bien>(attach_Bien, detach_Bien);
		_Clase = default(EntityRef<Clase>);
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

	private void attach_Bien(Bien entity)
	{
		SendPropertyChanging();
		entity.Familia = this;
	}

	private void detach_Bien(Bien entity)
	{
		SendPropertyChanging();
		entity.Familia = null;
	}
}
