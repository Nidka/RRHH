using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Tra_Articulo_Acuerdo")]
public class Tra_Articulo_Acuerdo : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _Nro_Acuerdo;

	private string _Nro_Articulo;

	private string _Sumilla_Articulo;

	private bool _Tramite;

	private string _Nro_Tramite;

	private EntityRef<Tra_Acuerdo> _Tra_Acuerdo;

	[Column(Storage = "_Nro_Acuerdo", DbType = "Char(10) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Nro_Acuerdo
	{
		get
		{
			return _Nro_Acuerdo;
		}
		set
		{
			if (!string.Equals(_Nro_Acuerdo, value))
			{
				if (_Tra_Acuerdo.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Nro_Acuerdo = value;
				SendPropertyChanged("Nro_Acuerdo");
			}
		}
	}

	[Column(Storage = "_Nro_Articulo", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Nro_Articulo
	{
		get
		{
			return _Nro_Articulo;
		}
		set
		{
			if (!string.Equals(_Nro_Articulo, value))
			{
				SendPropertyChanging();
				_Nro_Articulo = value;
				SendPropertyChanged("Nro_Articulo");
			}
		}
	}

	[Column(Storage = "_Sumilla_Articulo", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string Sumilla_Articulo
	{
		get
		{
			return _Sumilla_Articulo;
		}
		set
		{
			if (!string.Equals(_Sumilla_Articulo, value))
			{
				SendPropertyChanging();
				_Sumilla_Articulo = value;
				SendPropertyChanged("Sumilla_Articulo");
			}
		}
	}

	[Column(Storage = "_Tramite", DbType = "Bit NOT NULL")]
	public bool Tramite
	{
		get
		{
			return _Tramite;
		}
		set
		{
			if (_Tramite != value)
			{
				SendPropertyChanging();
				_Tramite = value;
				SendPropertyChanged("Tramite");
			}
		}
	}

	[Column(Storage = "_Nro_Tramite", DbType = "VarChar(10)")]
	public string Nro_Tramite
	{
		get
		{
			return _Nro_Tramite;
		}
		set
		{
			if (!string.Equals(_Nro_Tramite, value))
			{
				SendPropertyChanging();
				_Nro_Tramite = value;
				SendPropertyChanged("Nro_Tramite");
			}
		}
	}

	[Association(Name = "Tra_Acuerdo_Tra_Articulo_Acuerdo", Storage = "_Tra_Acuerdo", ThisKey = "Nro_Acuerdo", OtherKey = "Nro_Acuerdo", IsForeignKey = true)]
	public Tra_Acuerdo Tra_Acuerdo
	{
		get
		{
			return _Tra_Acuerdo.Entity;
		}
		set
		{
			Tra_Acuerdo previousValue = _Tra_Acuerdo.Entity;
			if (!object.Equals(previousValue, value) || !_Tra_Acuerdo.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Tra_Acuerdo.Entity = null;
					previousValue.Tra_Articulo_Acuerdo.Remove(this);
				}
				_Tra_Acuerdo.Entity = value;
				if (value != null)
				{
					value.Tra_Articulo_Acuerdo.Add(this);
					_Nro_Acuerdo = value.Nro_Acuerdo;
				}
				else
				{
					_Nro_Acuerdo = null;
				}
				SendPropertyChanged("Tra_Acuerdo");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Tra_Articulo_Acuerdo()
	{
		_Tra_Acuerdo = default(EntityRef<Tra_Acuerdo>);
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
