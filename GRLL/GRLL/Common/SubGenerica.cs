using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.SubGenerica")]
public class SubGenerica : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _Anio;

	private string _IdTipoTransaccion;

	private string _IdGenerica;

	private string _IdSubGenerica;

	private string _Descripcion;

	private EntitySet<SubGenerica_Det> _SubGenerica_Det;

	private EntityRef<Generica> _Generica;

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
				if (_Generica.HasLoadedOrAssignedValue)
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
				if (_Generica.HasLoadedOrAssignedValue)
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
				if (_Generica.HasLoadedOrAssignedValue)
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
				SendPropertyChanging();
				_IdSubGenerica = value;
				SendPropertyChanged("IdSubGenerica");
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

	[Association(Name = "SubGenerica_SubGenerica_Det", Storage = "_SubGenerica_Det", ThisKey = "Anio,IdTipoTransaccion,IdGenerica,IdSubGenerica", OtherKey = "IdSubGenerica,IdGenerica,IdTipoTransaccion,Anio")]
	public EntitySet<SubGenerica_Det> SubGenerica_Det
	{
		get
		{
			return _SubGenerica_Det;
		}
		set
		{
			_SubGenerica_Det.Assign(value);
		}
	}

	[Association(Name = "Generica_SubGenerica", Storage = "_Generica", ThisKey = "IdGenerica,IdTipoTransaccion,Anio", OtherKey = "Anio,idTipoTransaccion,IdGenerica", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public Generica Generica
	{
		get
		{
			return _Generica.Entity;
		}
		set
		{
			Generica previousValue = _Generica.Entity;
			if (!object.Equals(previousValue, value) || !_Generica.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Generica.Entity = null;
					previousValue.SubGenerica.Remove(this);
				}
				_Generica.Entity = value;
				if (value != null)
				{
					value.SubGenerica.Add(this);
					_IdGenerica = value.Anio;
					_IdTipoTransaccion = value.idTipoTransaccion;
					_Anio = value.IdGenerica;
				}
				else
				{
					_IdGenerica = null;
					_IdTipoTransaccion = null;
					_Anio = null;
				}
				SendPropertyChanged("Generica");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public SubGenerica()
	{
		_SubGenerica_Det = new EntitySet<SubGenerica_Det>(attach_SubGenerica_Det, detach_SubGenerica_Det);
		_Generica = default(EntityRef<Generica>);
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

	private void attach_SubGenerica_Det(SubGenerica_Det entity)
	{
		SendPropertyChanging();
		entity.SubGenerica = this;
	}

	private void detach_SubGenerica_Det(SubGenerica_Det entity)
	{
		SendPropertyChanging();
		entity.SubGenerica = null;
	}
}
