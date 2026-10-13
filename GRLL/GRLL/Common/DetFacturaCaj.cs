using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.DetFacturaCaj")]
public class DetFacturaCaj : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _Serie;

	private string _Factura;

	private int _IdDetFact;

	private decimal? _Cantidad;

	private string _UnidMedida;

	private string _Descripcion;

	private decimal? _PrecioUnit;

	private EntityRef<FacturaCaj> _FacturaCaj;

	[Column(Storage = "_Serie", DbType = "VarChar(4) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Serie
	{
		get
		{
			return _Serie;
		}
		set
		{
			if (!string.Equals(_Serie, value))
			{
				if (_FacturaCaj.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Serie = value;
				SendPropertyChanged("Serie");
			}
		}
	}

	[Column(Storage = "_Factura", DbType = "VarChar(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string Factura
	{
		get
		{
			return _Factura;
		}
		set
		{
			if (!string.Equals(_Factura, value))
			{
				if (_FacturaCaj.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Factura = value;
				SendPropertyChanged("Factura");
			}
		}
	}

	[Column(Storage = "_IdDetFact", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdDetFact
	{
		get
		{
			return _IdDetFact;
		}
		set
		{
			if (_IdDetFact != value)
			{
				SendPropertyChanging();
				_IdDetFact = value;
				SendPropertyChanged("IdDetFact");
			}
		}
	}

	[Column(Storage = "_Cantidad", DbType = "Decimal(6,2)")]
	public decimal? Cantidad
	{
		get
		{
			return _Cantidad;
		}
		set
		{
			if (!_Cantidad.Equals(value))
			{
				SendPropertyChanging();
				_Cantidad = value;
				SendPropertyChanged("Cantidad");
			}
		}
	}

	[Column(Storage = "_UnidMedida", DbType = "VarChar(6)")]
	public string UnidMedida
	{
		get
		{
			return _UnidMedida;
		}
		set
		{
			if (!string.Equals(_UnidMedida, value))
			{
				SendPropertyChanging();
				_UnidMedida = value;
				SendPropertyChanged("UnidMedida");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(500)")]
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

	[Column(Storage = "_PrecioUnit", DbType = "Decimal(11,2)")]
	public decimal? PrecioUnit
	{
		get
		{
			return _PrecioUnit;
		}
		set
		{
			if (!_PrecioUnit.Equals(value))
			{
				SendPropertyChanging();
				_PrecioUnit = value;
				SendPropertyChanged("PrecioUnit");
			}
		}
	}

	[Association(Name = "FacturaCaj_DetFacturaCaj", Storage = "_FacturaCaj", ThisKey = "Serie,Factura", OtherKey = "Serie,Factura", IsForeignKey = true)]
	public FacturaCaj FacturaCaj
	{
		get
		{
			return _FacturaCaj.Entity;
		}
		set
		{
			FacturaCaj previousValue = _FacturaCaj.Entity;
			if (!object.Equals(previousValue, value) || !_FacturaCaj.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_FacturaCaj.Entity = null;
					previousValue.DetFacturaCaj.Remove(this);
				}
				_FacturaCaj.Entity = value;
				if (value != null)
				{
					value.DetFacturaCaj.Add(this);
					_Serie = value.Serie;
					_Factura = value.Factura;
				}
				else
				{
					_Serie = null;
					_Factura = null;
				}
				SendPropertyChanged("FacturaCaj");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public DetFacturaCaj()
	{
		_FacturaCaj = default(EntityRef<FacturaCaj>);
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
