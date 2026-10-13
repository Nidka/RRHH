using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Especifica_Det")]
public class Especifica_Det : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _Anio;

	private string _IdTipoTransaccion;

	private string _IdGenerica;

	private string _IdSubGenerica;

	private string _IdSubGenerica_Det;

	private string _IdEspecifica;

	private string _IdEspecifica_Det;

	private string _Descripcion;

	private EntityRef<Especifica> _Especifica;

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
				if (_Especifica.HasLoadedOrAssignedValue)
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
				if (_Especifica.HasLoadedOrAssignedValue)
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
				if (_Especifica.HasLoadedOrAssignedValue)
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
				if (_Especifica.HasLoadedOrAssignedValue)
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
				if (_Especifica.HasLoadedOrAssignedValue)
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
				if (_Especifica.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdEspecifica = value;
				SendPropertyChanged("IdEspecifica");
			}
		}
	}

	[Column(Storage = "_IdEspecifica_Det", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdEspecifica_Det
	{
		get
		{
			return _IdEspecifica_Det;
		}
		set
		{
			if (!string.Equals(_IdEspecifica_Det, value))
			{
				SendPropertyChanging();
				_IdEspecifica_Det = value;
				SendPropertyChanged("IdEspecifica_Det");
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

	[Association(Name = "Especifica_Especifica_Det", Storage = "_Especifica", ThisKey = "IdEspecifica,IdSubGenerica_Det,IdSubGenerica,IdGenerica,IdTipoTransaccion,Anio", OtherKey = "Anio,IdTipoTransaccion,IdGenerica,IdSubGenerica,IdSubGenerica_Det,IdEspecifica", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public Especifica Especifica
	{
		get
		{
			return _Especifica.Entity;
		}
		set
		{
			Especifica previousValue = _Especifica.Entity;
			if (!object.Equals(previousValue, value) || !_Especifica.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Especifica.Entity = null;
					previousValue.Especifica_Det.Remove(this);
				}
				_Especifica.Entity = value;
				if (value != null)
				{
					value.Especifica_Det.Add(this);
					_IdEspecifica = value.Anio;
					_IdSubGenerica_Det = value.IdTipoTransaccion;
					_IdSubGenerica = value.IdGenerica;
					_IdGenerica = value.IdSubGenerica;
					_IdTipoTransaccion = value.IdSubGenerica_Det;
					_Anio = value.IdEspecifica;
				}
				else
				{
					_IdEspecifica = null;
					_IdSubGenerica_Det = null;
					_IdSubGenerica = null;
					_IdGenerica = null;
					_IdTipoTransaccion = null;
					_Anio = null;
				}
				SendPropertyChanged("Especifica");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Especifica_Det()
	{
		_Especifica = default(EntityRef<Especifica>);
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
