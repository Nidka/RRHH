using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.SubGenerica_Det")]
public class SubGenerica_Det : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _Anio;

	private string _IdTipoTransaccion;

	private string _IdGenerica;

	private string _IdSubGenerica;

	private string _IdSubGenerica_Det;

	private string _Descripcion;

	private EntitySet<Especifica> _Especifica;

	private EntityRef<SubGenerica> _SubGenerica;

	[Column(Storage = "_Anio", DbType = "Char(5) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!string.Equals(_Anio, value))
			{
				if (_SubGenerica.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Anio = value;
				SendPropertyChanged("Anio");
			}
		}
	}

	[Column(Storage = "_IdTipoTransaccion", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdTipoTransaccion
	{
		get
		{
			return _IdTipoTransaccion;
		}
		set
		{
			if (!string.Equals(_IdTipoTransaccion, value))
			{
				if (_SubGenerica.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoTransaccion = value;
				SendPropertyChanged("IdTipoTransaccion");
			}
		}
	}

	[Column(Storage = "_IdGenerica", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdGenerica
	{
		get
		{
			return _IdGenerica;
		}
		set
		{
			if (!string.Equals(_IdGenerica, value))
			{
				if (_SubGenerica.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdGenerica = value;
				SendPropertyChanged("IdGenerica");
			}
		}
	}

	[Column(Storage = "_IdSubGenerica", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdSubGenerica
	{
		get
		{
			return _IdSubGenerica;
		}
		set
		{
			if (!string.Equals(_IdSubGenerica, value))
			{
				if (_SubGenerica.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdSubGenerica = value;
				SendPropertyChanged("IdSubGenerica");
			}
		}
	}

	[Column(Storage = "_IdSubGenerica_Det", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdSubGenerica_Det
	{
		get
		{
			return _IdSubGenerica_Det;
		}
		set
		{
			if (!string.Equals(_IdSubGenerica_Det, value))
			{
				SendPropertyChanging();
				_IdSubGenerica_Det = value;
				SendPropertyChanged("IdSubGenerica_Det");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(100)")]
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

	[Association(Name = "SubGenerica_Det_Especifica", Storage = "_Especifica", ThisKey = "Anio,IdTipoTransaccion,IdGenerica,IdSubGenerica,IdSubGenerica_Det", OtherKey = "IdSubGenerica_Det,IdSubGenerica,IdGenerica,IdTipoTransaccion,Anio")]
	public EntitySet<Especifica> Especifica
	{
		get
		{
			return _Especifica;
		}
		set
		{
			_Especifica.Assign(value);
		}
	}

	[Association(Name = "SubGenerica_SubGenerica_Det", Storage = "_SubGenerica", ThisKey = "IdSubGenerica,IdGenerica,IdTipoTransaccion,Anio", OtherKey = "Anio,IdTipoTransaccion,IdGenerica,IdSubGenerica", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public SubGenerica SubGenerica
	{
		get
		{
			return _SubGenerica.Entity;
		}
		set
		{
			SubGenerica previousValue = _SubGenerica.Entity;
			if (!object.Equals(previousValue, value) || !_SubGenerica.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_SubGenerica.Entity = null;
					previousValue.SubGenerica_Det.Remove(this);
				}
				_SubGenerica.Entity = value;
				if (value != null)
				{
					value.SubGenerica_Det.Add(this);
					_IdSubGenerica = value.Anio;
					_IdGenerica = value.IdTipoTransaccion;
					_IdTipoTransaccion = value.IdGenerica;
					_Anio = value.IdSubGenerica;
				}
				else
				{
					_IdSubGenerica = null;
					_IdGenerica = null;
					_IdTipoTransaccion = null;
					_Anio = null;
				}
				SendPropertyChanged("SubGenerica");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public SubGenerica_Det()
	{
		_Especifica = new EntitySet<Especifica>(attach_Especifica, detach_Especifica);
		_SubGenerica = default(EntityRef<SubGenerica>);
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

	private void attach_Especifica(Especifica entity)
	{
		SendPropertyChanging();
		entity.SubGenerica_Det = this;
	}

	private void detach_Especifica(Especifica entity)
	{
		SendPropertyChanging();
		entity.SubGenerica_Det = null;
	}
}
