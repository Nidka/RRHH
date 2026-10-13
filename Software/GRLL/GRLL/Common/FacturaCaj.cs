using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.FacturaCaj")]
public class FacturaCaj : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _Serie;

	private string _Factura;

	private int? _IdPersona;

	private int? _NroIngreso;

	private decimal? _Total;

	private decimal? _IGV;

	private char? _Estado;

	private int? _Years;

	private EntitySet<DetFacturaCaj> _DetFacturaCaj;

	private EntityRef<IngresoCaj> _IngresoCaj;

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
				SendPropertyChanging();
				_Factura = value;
				SendPropertyChanged("Factura");
			}
		}
	}

	[Column(Storage = "_IdPersona", DbType = "Int")]
	public int? IdPersona
	{
		get
		{
			return _IdPersona;
		}
		set
		{
			if (!_IdPersona.Equals(value))
			{
				if (_IngresoCaj.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdPersona = value;
				SendPropertyChanged("IdPersona");
			}
		}
	}

	[Column(Storage = "_NroIngreso", DbType = "Int")]
	public int? NroIngreso
	{
		get
		{
			return _NroIngreso;
		}
		set
		{
			if (!_NroIngreso.Equals(value))
			{
				if (_IngresoCaj.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NroIngreso = value;
				SendPropertyChanged("NroIngreso");
			}
		}
	}

	[Column(Storage = "_Total", DbType = "Decimal(11,2)")]
	public decimal? Total
	{
		get
		{
			return _Total;
		}
		set
		{
			if (!_Total.Equals(value))
			{
				SendPropertyChanging();
				_Total = value;
				SendPropertyChanged("Total");
			}
		}
	}

	[Column(Storage = "_IGV", DbType = "Decimal(11,2)")]
	public decimal? IGV
	{
		get
		{
			return _IGV;
		}
		set
		{
			if (!_IGV.Equals(value))
			{
				SendPropertyChanging();
				_IGV = value;
				SendPropertyChanged("IGV");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "VarChar(1)")]
	public char? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				SendPropertyChanging();
				_Estado = value;
				SendPropertyChanged("Estado");
			}
		}
	}

	[Column(Storage = "_Years", DbType = "Int")]
	public int? Years
	{
		get
		{
			return _Years;
		}
		set
		{
			if (!_Years.Equals(value))
			{
				if (_IngresoCaj.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Years = value;
				SendPropertyChanged("Years");
			}
		}
	}

	[Association(Name = "FacturaCaj_DetFacturaCaj", Storage = "_DetFacturaCaj", ThisKey = "Serie,Factura", OtherKey = "Serie,Factura")]
	public EntitySet<DetFacturaCaj> DetFacturaCaj
	{
		get
		{
			return _DetFacturaCaj;
		}
		set
		{
			_DetFacturaCaj.Assign(value);
		}
	}

	[Association(Name = "IngresoCaj_FacturaCaj", Storage = "_IngresoCaj", ThisKey = "IdPersona,Years,NroIngreso", OtherKey = "IdPersona,NroIngreso,Years", IsForeignKey = true)]
	public IngresoCaj IngresoCaj
	{
		get
		{
			return _IngresoCaj.Entity;
		}
		set
		{
			IngresoCaj previousValue = _IngresoCaj.Entity;
			if (!object.Equals(previousValue, value) || !_IngresoCaj.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_IngresoCaj.Entity = null;
					previousValue.FacturaCaj.Remove(this);
				}
				_IngresoCaj.Entity = value;
				if (value != null)
				{
					value.FacturaCaj.Add(this);
					_IdPersona = value.IdPersona;
					_Years = value.NroIngreso;
					_NroIngreso = value.Years;
				}
				else
				{
					_IdPersona = null;
					_Years = null;
					_NroIngreso = null;
				}
				SendPropertyChanged("IngresoCaj");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public FacturaCaj()
	{
		_DetFacturaCaj = new EntitySet<DetFacturaCaj>(attach_DetFacturaCaj, detach_DetFacturaCaj);
		_IngresoCaj = default(EntityRef<IngresoCaj>);
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

	private void attach_DetFacturaCaj(DetFacturaCaj entity)
	{
		SendPropertyChanging();
		entity.FacturaCaj = this;
	}

	private void detach_DetFacturaCaj(DetFacturaCaj entity)
	{
		SendPropertyChanging();
		entity.FacturaCaj = null;
	}
}
