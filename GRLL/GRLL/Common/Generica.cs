using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Generica")]
public class Generica : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _Anio;

	private string _idTipoTransaccion;

	private string _IdGenerica;

	private string _Descripcion;

	private EntitySet<SubGenerica> _SubGenerica;

	private EntityRef<TipoTransaccion> _TipoTransaccion;

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
				if (_TipoTransaccion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Anio = value;
				SendPropertyChanged("Anio");
			}
		}
	}

	[Column(Storage = "_idTipoTransaccion", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string idTipoTransaccion
	{
		get
		{
			return _idTipoTransaccion;
		}
		set
		{
			if (!string.Equals(_idTipoTransaccion, value))
			{
				if (_TipoTransaccion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idTipoTransaccion = value;
				SendPropertyChanged("idTipoTransaccion");
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
				SendPropertyChanging();
				_IdGenerica = value;
				SendPropertyChanged("IdGenerica");
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

	[Association(Name = "Generica_SubGenerica", Storage = "_SubGenerica", ThisKey = "Anio,idTipoTransaccion,IdGenerica", OtherKey = "IdGenerica,IdTipoTransaccion,Anio")]
	public EntitySet<SubGenerica> SubGenerica
	{
		get
		{
			return _SubGenerica;
		}
		set
		{
			_SubGenerica.Assign(value);
		}
	}

	[Association(Name = "TipoTransaccion_Generica", Storage = "_TipoTransaccion", ThisKey = "idTipoTransaccion,Anio", OtherKey = "Anio,IdTipoTransaccion", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public TipoTransaccion TipoTransaccion
	{
		get
		{
			return _TipoTransaccion.Entity;
		}
		set
		{
			TipoTransaccion previousValue = _TipoTransaccion.Entity;
			if (!object.Equals(previousValue, value) || !_TipoTransaccion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoTransaccion.Entity = null;
					previousValue.Generica.Remove(this);
				}
				_TipoTransaccion.Entity = value;
				if (value != null)
				{
					value.Generica.Add(this);
					_idTipoTransaccion = value.Anio;
					_Anio = value.IdTipoTransaccion;
				}
				else
				{
					_idTipoTransaccion = null;
					_Anio = null;
				}
				SendPropertyChanged("TipoTransaccion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Generica()
	{
		_SubGenerica = new EntitySet<SubGenerica>(attach_SubGenerica, detach_SubGenerica);
		_TipoTransaccion = default(EntityRef<TipoTransaccion>);
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

	private void attach_SubGenerica(SubGenerica entity)
	{
		SendPropertyChanging();
		entity.Generica = this;
	}

	private void detach_SubGenerica(SubGenerica entity)
	{
		SendPropertyChanging();
		entity.Generica = null;
	}
}
