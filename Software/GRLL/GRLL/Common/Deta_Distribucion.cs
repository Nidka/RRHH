using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Deta_Distribucion")]
public class Deta_Distribucion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private char _TipoOrden;

	private string _IdOrden;

	private string _IdBien;

	private string _IdMeta;

	private string _IdGasto;

	private decimal? _Cantidad;

	private decimal? _Importe;

	private decimal? _CantidadRecibida;

	private string _IdUnidad;

	private string _Observaciones;

	private string _Meta;

	private string _MetaAnio;

	private int _Item;

	private int? _IdAreaOrganiz;

	private EntityRef<Deta_Orden> _Deta_Orden;

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
				if (_Deta_Orden.HasLoadedOrAssignedValue)
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
				if (_Deta_Orden.HasLoadedOrAssignedValue)
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

	[Column(Storage = "_IdMeta", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdMeta
	{
		get
		{
			return _IdMeta;
		}
		set
		{
			if (!string.Equals(_IdMeta, value))
			{
				SendPropertyChanging();
				_IdMeta = value;
				SendPropertyChanged("IdMeta");
			}
		}
	}

	[Column(Storage = "_IdGasto", DbType = "Char(20) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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

	[Column(Storage = "_Importe", DbType = "Decimal(18,4)")]
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

	[Column(Storage = "_IdUnidad", DbType = "Char(10)")]
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

	[Column(Storage = "_Observaciones", DbType = "VarChar(600)")]
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

	[Column(Storage = "_Meta", DbType = "Char(255) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_MetaAnio", DbType = "Char(4) NOT NULL", CanBeNull = false)]
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
				if (_Deta_Orden.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Item = value;
				SendPropertyChanged("Item");
			}
		}
	}

	[Column(Storage = "_IdAreaOrganiz", DbType = "Int")]
	public int? IdAreaOrganiz
	{
		get
		{
			return _IdAreaOrganiz;
		}
		set
		{
			if (!_IdAreaOrganiz.Equals(value))
			{
				SendPropertyChanging();
				_IdAreaOrganiz = value;
				SendPropertyChanged("IdAreaOrganiz");
			}
		}
	}

	[Association(Name = "Deta_Orden_Deta_Distribucion", Storage = "_Deta_Orden", ThisKey = "Item,TipoOrden,IdOrden", OtherKey = "Item,TipoOrden,IdOrden", IsForeignKey = true)]
	public Deta_Orden Deta_Orden
	{
		get
		{
			return _Deta_Orden.Entity;
		}
		set
		{
			Deta_Orden previousValue = _Deta_Orden.Entity;
			if (!object.Equals(previousValue, value) || !_Deta_Orden.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Deta_Orden.Entity = null;
					previousValue.Deta_Distribucion.Remove(this);
				}
				_Deta_Orden.Entity = value;
				if (value != null)
				{
					value.Deta_Distribucion.Add(this);
					_Item = value.Item;
					_TipoOrden = value.TipoOrden;
					_IdOrden = value.IdOrden;
				}
				else
				{
					_Item = 0;
					_TipoOrden = '\0';
					_IdOrden = null;
				}
				SendPropertyChanged("Deta_Orden");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Deta_Distribucion()
	{
		_Deta_Orden = default(EntityRef<Deta_Orden>);
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
