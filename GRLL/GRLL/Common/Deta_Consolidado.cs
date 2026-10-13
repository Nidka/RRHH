using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Deta_Consolidado")]
public class Deta_Consolidado : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private byte _Item;

	private string _IdConsolidado;

	private string _IdBien;

	private decimal? _Cantidad;

	private decimal? _Precio;

	private decimal? _Importe;

	private string _BuenaPro;

	private string _IdContrato;

	private string _Observaciones;

	private decimal? _Saldo;

	private decimal? _PrecioPro;

	private decimal? _ImportePro;

	private decimal? _CantidadPro;

	private EntityRef<Consolidado> _Consolidado;

	private EntityRef<Contrato> _Contrato;

	[Column(Storage = "_Item", DbType = "TinyInt NOT NULL", IsPrimaryKey = true)]
	public byte Item
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

	[Column(Storage = "_IdConsolidado", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdConsolidado
	{
		get
		{
			return _IdConsolidado;
		}
		set
		{
			if (!string.Equals(_IdConsolidado, value))
			{
				if (_Consolidado.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdConsolidado = value;
				SendPropertyChanged("IdConsolidado");
			}
		}
	}

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
				SendPropertyChanging();
				_IdBien = value;
				SendPropertyChanged("IdBien");
			}
		}
	}

	[Column(Storage = "_Cantidad", DbType = "Decimal(18,2)")]
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

	[Column(Storage = "_Precio", DbType = "Decimal(18,2)")]
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

	[Column(Storage = "_Importe", DbType = "Decimal(18,2)")]
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

	[Column(Storage = "_BuenaPro", DbType = "Char(11)")]
	public string BuenaPro
	{
		get
		{
			return _BuenaPro;
		}
		set
		{
			if (!string.Equals(_BuenaPro, value))
			{
				SendPropertyChanging();
				_BuenaPro = value;
				SendPropertyChanged("BuenaPro");
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
				if (_Contrato.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdContrato = value;
				SendPropertyChanged("IdContrato");
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(120)")]
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

	[Column(Storage = "_Saldo", DbType = "Decimal(18,2)")]
	public decimal? Saldo
	{
		get
		{
			return _Saldo;
		}
		set
		{
			if (!_Saldo.Equals(value))
			{
				SendPropertyChanging();
				_Saldo = value;
				SendPropertyChanged("Saldo");
			}
		}
	}

	[Column(Storage = "_PrecioPro", DbType = "Decimal(18,2)")]
	public decimal? PrecioPro
	{
		get
		{
			return _PrecioPro;
		}
		set
		{
			if (!_PrecioPro.Equals(value))
			{
				SendPropertyChanging();
				_PrecioPro = value;
				SendPropertyChanged("PrecioPro");
			}
		}
	}

	[Column(Storage = "_ImportePro", DbType = "Decimal(18,2)")]
	public decimal? ImportePro
	{
		get
		{
			return _ImportePro;
		}
		set
		{
			if (!_ImportePro.Equals(value))
			{
				SendPropertyChanging();
				_ImportePro = value;
				SendPropertyChanged("ImportePro");
			}
		}
	}

	[Column(Storage = "_CantidadPro", DbType = "Decimal(18,2)")]
	public decimal? CantidadPro
	{
		get
		{
			return _CantidadPro;
		}
		set
		{
			if (!_CantidadPro.Equals(value))
			{
				SendPropertyChanging();
				_CantidadPro = value;
				SendPropertyChanged("CantidadPro");
			}
		}
	}

	[Association(Name = "Consolidado_Deta_Consolidado", Storage = "_Consolidado", ThisKey = "IdConsolidado", OtherKey = "IdConsolidado", IsForeignKey = true)]
	public Consolidado Consolidado
	{
		get
		{
			return _Consolidado.Entity;
		}
		set
		{
			Consolidado previousValue = _Consolidado.Entity;
			if (!object.Equals(previousValue, value) || !_Consolidado.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Consolidado.Entity = null;
					previousValue.Deta_Consolidado.Remove(this);
				}
				_Consolidado.Entity = value;
				if (value != null)
				{
					value.Deta_Consolidado.Add(this);
					_IdConsolidado = value.IdConsolidado;
				}
				else
				{
					_IdConsolidado = null;
				}
				SendPropertyChanged("Consolidado");
			}
		}
	}

	[Association(Name = "Contrato_Deta_Consolidado", Storage = "_Contrato", ThisKey = "IdContrato", OtherKey = "IdContrato", IsForeignKey = true)]
	public Contrato Contrato
	{
		get
		{
			return _Contrato.Entity;
		}
		set
		{
			Contrato previousValue = _Contrato.Entity;
			if (!object.Equals(previousValue, value) || !_Contrato.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Contrato.Entity = null;
					previousValue.Deta_Consolidado.Remove(this);
				}
				_Contrato.Entity = value;
				if (value != null)
				{
					value.Deta_Consolidado.Add(this);
					_IdContrato = value.IdContrato;
				}
				else
				{
					_IdContrato = null;
				}
				SendPropertyChanged("Contrato");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Deta_Consolidado()
	{
		_Consolidado = default(EntityRef<Consolidado>);
		_Contrato = default(EntityRef<Contrato>);
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
