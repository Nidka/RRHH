using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Deta_Movimiento")]
public class Deta_Movimiento : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdBien;

	private string _IdMeta;

	private decimal? _Cantidad;

	private decimal? _Precio_Costo;

	private int _Item;

	private string _IdMovimiento;

	private short? _Signo;

	private decimal? _stockIni;

	private EntityRef<Bien> _Bien;

	private EntityRef<Movimiento> _Movimiento;

	[Column(Storage = "_IdBien", DbType = "Char(13) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				if (_Bien.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
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

	[Column(Storage = "_Precio_Costo", DbType = "Decimal(11,4)")]
	public decimal? Precio_Costo
	{
		get
		{
			return _Precio_Costo;
		}
		set
		{
			if (!_Precio_Costo.Equals(value))
			{
				SendPropertyChanging();
				_Precio_Costo = value;
				SendPropertyChanged("Precio_Costo");
			}
		}
	}

	[Column(Storage = "_Item", DbType = "Int NOT NULL")]
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

	[Column(Storage = "_IdMovimiento", DbType = "Char(8) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdMovimiento
	{
		get
		{
			return _IdMovimiento;
		}
		set
		{
			if (!string.Equals(_IdMovimiento, value))
			{
				if (_Movimiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdMovimiento = value;
				SendPropertyChanged("IdMovimiento");
			}
		}
	}

	[Column(Storage = "_Signo", DbType = "SmallInt")]
	public short? Signo
	{
		get
		{
			return _Signo;
		}
		set
		{
			if (!_Signo.Equals(value))
			{
				SendPropertyChanging();
				_Signo = value;
				SendPropertyChanged("Signo");
			}
		}
	}

	[Column(Storage = "_stockIni", DbType = "Decimal(9,2)")]
	public decimal? stockIni
	{
		get
		{
			return _stockIni;
		}
		set
		{
			if (!_stockIni.Equals(value))
			{
				SendPropertyChanging();
				_stockIni = value;
				SendPropertyChanged("stockIni");
			}
		}
	}

	[Association(Name = "Bien_Deta_Movimiento", Storage = "_Bien", ThisKey = "IdBien", OtherKey = "IdBien", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
	public Bien Bien
	{
		get
		{
			return _Bien.Entity;
		}
		set
		{
			Bien previousValue = _Bien.Entity;
			if (!object.Equals(previousValue, value) || !_Bien.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Bien.Entity = null;
					previousValue.Deta_Movimiento.Remove(this);
				}
				_Bien.Entity = value;
				if (value != null)
				{
					value.Deta_Movimiento.Add(this);
					_IdBien = value.IdBien;
				}
				else
				{
					_IdBien = null;
				}
				SendPropertyChanged("Bien");
			}
		}
	}

	[Association(Name = "Movimiento_Deta_Movimiento", Storage = "_Movimiento", ThisKey = "IdMovimiento", OtherKey = "IdMovimiento", IsForeignKey = true)]
	public Movimiento Movimiento
	{
		get
		{
			return _Movimiento.Entity;
		}
		set
		{
			Movimiento previousValue = _Movimiento.Entity;
			if (!object.Equals(previousValue, value) || !_Movimiento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Movimiento.Entity = null;
					previousValue.Deta_Movimiento.Remove(this);
				}
				_Movimiento.Entity = value;
				if (value != null)
				{
					value.Deta_Movimiento.Add(this);
					_IdMovimiento = value.IdMovimiento;
				}
				else
				{
					_IdMovimiento = null;
				}
				SendPropertyChanged("Movimiento");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Deta_Movimiento()
	{
		_Bien = default(EntityRef<Bien>);
		_Movimiento = default(EntityRef<Movimiento>);
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
