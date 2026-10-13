using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Deta_Orden")]
public class Deta_Orden : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _Item;

	private char _TipoOrden;

	private string _IdOrden;

	private string _IdBien;

	private decimal? _Cantidad;

	private decimal? _Precio;

	private decimal? _Igv;

	private decimal? _Importe;

	private string _IdUnidadMedida;

	private decimal? _CantidadRecibida;

	private string _IdContrato;

	private string _Observaciones;

	private string _Cuenta;

	private string _CuentaAnio;

	private string _IdUnidad;

	private string _IdGasto;

	private string _Meta;

	private string _MetaAnio;

	private EntitySet<Deta_Distribucion> _Deta_Distribucion;

	private EntityRef<OrdenCompra> _OrdenCompra;

	[Column(Storage = "_Item", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int Item
	{
		get
		{
			return _Item;
		}
		set
		{
			if (_Item != value)
			{
				SendPropertyChanging();
				_Item = value;
				SendPropertyChanged("Item");
			}
		}
	}

	[Column(Storage = "_TipoOrden", DbType = "Char(1) NOT NULL", IsPrimaryKey = true)]
	public char TipoOrden
	{
		get
		{
			return _TipoOrden;
		}
		set
		{
			if (_TipoOrden != value)
			{
				if (_OrdenCompra.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_TipoOrden = value;
				SendPropertyChanged("TipoOrden");
			}
		}
	}

	[Column(Storage = "_IdOrden", DbType = "Char(8) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdOrden
	{
		get
		{
			return _IdOrden;
		}
		set
		{
			if (!string.Equals(_IdOrden, value))
			{
				if (_OrdenCompra.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdOrden = value;
				SendPropertyChanged("IdOrden");
			}
		}
	}

	[Column(Storage = "_IdBien", DbType = "Char(13) NOT NULL", CanBeNull = false)]
	public string IdBien
	{
		get
		{
			return _IdBien;
		}
		set
		{
			if (!string.Equals(_IdBien, value))
			{
				SendPropertyChanging();
				_IdBien = value;
				SendPropertyChanged("IdBien");
			}
		}
	}

	[Column(Storage = "_Cantidad", DbType = "Decimal(11,4)")]
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

	[Column(Storage = "_Precio", DbType = "Decimal(11,4)")]
	public decimal? Precio
	{
		get
		{
			return _Precio;
		}
		set
		{
			if (!_Precio.Equals(value))
			{
				SendPropertyChanging();
				_Precio = value;
				SendPropertyChanged("Precio");
			}
		}
	}

	[Column(Storage = "_Igv", DbType = "Decimal(11,4)")]
	public decimal? Igv
	{
		get
		{
			return _Igv;
		}
		set
		{
			if (!_Igv.Equals(value))
			{
				SendPropertyChanging();
				_Igv = value;
				SendPropertyChanged("Igv");
			}
		}
	}

	[Column(Storage = "_Importe", DbType = "Decimal(11,4)")]
	public decimal? Importe
	{
		get
		{
			return _Importe;
		}
		set
		{
			if (!_Importe.Equals(value))
			{
				SendPropertyChanging();
				_Importe = value;
				SendPropertyChanged("Importe");
			}
		}
	}

	[Column(Storage = "_IdUnidadMedida", DbType = "Char(4)")]
	public string IdUnidadMedida
	{
		get
		{
			return _IdUnidadMedida;
		}
		set
		{
			if (!string.Equals(_IdUnidadMedida, value))
			{
				SendPropertyChanging();
				_IdUnidadMedida = value;
				SendPropertyChanged("IdUnidadMedida");
			}
		}
	}

	[Column(Storage = "_CantidadRecibida", DbType = "Decimal(9,4)")]
	public decimal? CantidadRecibida
	{
		get
		{
			return _CantidadRecibida;
		}
		set
		{
			if (!_CantidadRecibida.Equals(value))
			{
				SendPropertyChanging();
				_CantidadRecibida = value;
				SendPropertyChanged("CantidadRecibida");
			}
		}
	}

	[Column(Storage = "_IdContrato", DbType = "Char(8)")]
	public string IdContrato
	{
		get
		{
			return _IdContrato;
		}
		set
		{
			if (!string.Equals(_IdContrato, value))
			{
				SendPropertyChanging();
				_IdContrato = value;
				SendPropertyChanged("IdContrato");
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(400)")]
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

	[Column(Storage = "_Cuenta", DbType = "Char(10)")]
	public string Cuenta
	{
		get
		{
			return _Cuenta;
		}
		set
		{
			if (!string.Equals(_Cuenta, value))
			{
				SendPropertyChanging();
				_Cuenta = value;
				SendPropertyChanged("Cuenta");
			}
		}
	}

	[Column(Storage = "_CuentaAnio", DbType = "Char(4)")]
	public string CuentaAnio
	{
		get
		{
			return _CuentaAnio;
		}
		set
		{
			if (!string.Equals(_CuentaAnio, value))
			{
				SendPropertyChanging();
				_CuentaAnio = value;
				SendPropertyChanged("CuentaAnio");
			}
		}
	}

	[Column(Storage = "_IdUnidad", DbType = "Char(4)")]
	public string IdUnidad
	{
		get
		{
			return _IdUnidad;
		}
		set
		{
			if (!string.Equals(_IdUnidad, value))
			{
				SendPropertyChanging();
				_IdUnidad = value;
				SendPropertyChanged("IdUnidad");
			}
		}
	}

	[Column(Storage = "_IdGasto", DbType = "VarChar(17)")]
	public string IdGasto
	{
		get
		{
			return _IdGasto;
		}
		set
		{
			if (!string.Equals(_IdGasto, value))
			{
				SendPropertyChanging();
				_IdGasto = value;
				SendPropertyChanged("IdGasto");
			}
		}
	}

	[Column(Storage = "_Meta", DbType = "Char(6)")]
	public string Meta
	{
		get
		{
			return _Meta;
		}
		set
		{
			if (!string.Equals(_Meta, value))
			{
				SendPropertyChanging();
				_Meta = value;
				SendPropertyChanged("Meta");
			}
		}
	}

	[Column(Storage = "_MetaAnio", DbType = "Char(4)")]
	public string MetaAnio
	{
		get
		{
			return _MetaAnio;
		}
		set
		{
			if (!string.Equals(_MetaAnio, value))
			{
				SendPropertyChanging();
				_MetaAnio = value;
				SendPropertyChanged("MetaAnio");
			}
		}
	}

	[Association(Name = "Deta_Orden_Deta_Distribucion", Storage = "_Deta_Distribucion", ThisKey = "Item,TipoOrden,IdOrden", OtherKey = "Item,TipoOrden,IdOrden")]
	public EntitySet<Deta_Distribucion> Deta_Distribucion
	{
		get
		{
			return _Deta_Distribucion;
		}
		set
		{
			_Deta_Distribucion.Assign(value);
		}
	}

	[Association(Name = "OrdenCompra_Deta_Orden", Storage = "_OrdenCompra", ThisKey = "TipoOrden,IdOrden", OtherKey = "TipoOrden,IdOrden", IsForeignKey = true)]
	public OrdenCompra OrdenCompra
	{
		get
		{
			return _OrdenCompra.Entity;
		}
		set
		{
			OrdenCompra previousValue = _OrdenCompra.Entity;
			if (!object.Equals(previousValue, value) || !_OrdenCompra.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_OrdenCompra.Entity = null;
					previousValue.Deta_Orden.Remove(this);
				}
				_OrdenCompra.Entity = value;
				if (value != null)
				{
					value.Deta_Orden.Add(this);
					_TipoOrden = value.TipoOrden;
					_IdOrden = value.IdOrden;
				}
				else
				{
					_TipoOrden = '\0';
					_IdOrden = null;
				}
				SendPropertyChanged("OrdenCompra");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Deta_Orden()
	{
		_Deta_Distribucion = new EntitySet<Deta_Distribucion>(attach_Deta_Distribucion, detach_Deta_Distribucion);
		_OrdenCompra = default(EntityRef<OrdenCompra>);
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

	private void attach_Deta_Distribucion(Deta_Distribucion entity)
	{
		SendPropertyChanging();
		entity.Deta_Orden = this;
	}

	private void detach_Deta_Distribucion(Deta_Distribucion entity)
	{
		SendPropertyChanging();
		entity.Deta_Orden = null;
	}
}
