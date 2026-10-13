using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Especifica")]
public class Especifica : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _Anio;

	private string _IdTipoTransaccion;

	private string _IdGenerica;

	private string _IdSubGenerica;

	private string _IdSubGenerica_Det;

	private string _IdEspecifica;

	private string _Descripcion;

	private EntitySet<Especifica_Det> _Especifica_Det;

	private EntityRef<SubGenerica_Det> _SubGenerica_Det;

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
				if (_SubGenerica_Det.HasLoadedOrAssignedValue)
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
				if (_SubGenerica_Det.HasLoadedOrAssignedValue)
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
				if (_SubGenerica_Det.HasLoadedOrAssignedValue)
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
				if (_SubGenerica_Det.HasLoadedOrAssignedValue)
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
				if (_SubGenerica_Det.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdSubGenerica_Det = value;
				SendPropertyChanged("IdSubGenerica_Det");
			}
		}
	}

	[Column(Storage = "_IdEspecifica", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdEspecifica
	{
		get
		{
			return _IdEspecifica;
		}
		set
		{
			if (!string.Equals(_IdEspecifica, value))
			{
				SendPropertyChanging();
				_IdEspecifica = value;
				SendPropertyChanged("IdEspecifica");
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

	[Association(Name = "Especifica_Especifica_Det", Storage = "_Especifica_Det", ThisKey = "Anio,IdTipoTransaccion,IdGenerica,IdSubGenerica,IdSubGenerica_Det,IdEspecifica", OtherKey = "IdEspecifica,IdSubGenerica_Det,IdSubGenerica,IdGenerica,IdTipoTransaccion,Anio")]
	public EntitySet<Especifica_Det> Especifica_Det
	{
		get
		{
			return _Especifica_Det;
		}
		set
		{
			_Especifica_Det.Assign(value);
		}
	}

	[Association(Name = "SubGenerica_Det_Especifica", Storage = "_SubGenerica_Det", ThisKey = "IdSubGenerica_Det,IdSubGenerica,IdGenerica,IdTipoTransaccion,Anio", OtherKey = "Anio,IdTipoTransaccion,IdGenerica,IdSubGenerica,IdSubGenerica_Det", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public SubGenerica_Det SubGenerica_Det
	{
		get
		{
			return _SubGenerica_Det.Entity;
		}
		set
		{
			SubGenerica_Det previousValue = _SubGenerica_Det.Entity;
			if (!object.Equals(previousValue, value) || !_SubGenerica_Det.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_SubGenerica_Det.Entity = null;
					previousValue.Especifica.Remove(this);
				}
				_SubGenerica_Det.Entity = value;
				if (value != null)
				{
					value.Especifica.Add(this);
					_IdSubGenerica_Det = value.Anio;
					_IdSubGenerica = value.IdTipoTransaccion;
					_IdGenerica = value.IdGenerica;
					_IdTipoTransaccion = value.IdSubGenerica;
					_Anio = value.IdSubGenerica_Det;
				}
				else
				{
					_IdSubGenerica_Det = null;
					_IdSubGenerica = null;
					_IdGenerica = null;
					_IdTipoTransaccion = null;
					_Anio = null;
				}
				SendPropertyChanged("SubGenerica_Det");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Especifica()
	{
		_Especifica_Det = new EntitySet<Especifica_Det>(attach_Especifica_Det, detach_Especifica_Det);
		_SubGenerica_Det = default(EntityRef<SubGenerica_Det>);
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

	private void attach_Especifica_Det(Especifica_Det entity)
	{
		SendPropertyChanging();
		entity.Especifica = this;
	}

	private void detach_Especifica_Det(Especifica_Det entity)
	{
		SendPropertyChanging();
		entity.Especifica = null;
	}
}
