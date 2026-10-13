using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TransferenciaBco")]
public class TransferenciaBco : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdTransferencia;

	private int? _IdBancoDe;

	private string _NroCtaDe;

	private int? _IdBancoA;

	private string _NroCtaA;

	private decimal? _Total;

	private int? _IdTipoMonedaA;

	private EntitySet<IngresoCaj> _IngresoCaj;

	private EntityRef<Banco> _Banco;

	private EntityRef<NroCuenta> _NroCuenta;

	[Column(Storage = "_IdTransferencia", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTransferencia
	{
		get
		{
			return _IdTransferencia;
		}
		set
		{
			if (_IdTransferencia != value)
			{
				SendPropertyChanging();
				_IdTransferencia = value;
				SendPropertyChanged("IdTransferencia");
			}
		}
	}

	[Column(Storage = "_IdBancoDe", DbType = "Int")]
	public int? IdBancoDe
	{
		get
		{
			return _IdBancoDe;
		}
		set
		{
			if (!_IdBancoDe.Equals(value))
			{
				if (_Banco.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdBancoDe = value;
				SendPropertyChanged("IdBancoDe");
			}
		}
	}

	[Column(Storage = "_NroCtaDe", DbType = "VarChar(12)")]
	public string NroCtaDe
	{
		get
		{
			return _NroCtaDe;
		}
		set
		{
			if (!string.Equals(_NroCtaDe, value))
			{
				SendPropertyChanging();
				_NroCtaDe = value;
				SendPropertyChanged("NroCtaDe");
			}
		}
	}

	[Column(Storage = "_IdBancoA", DbType = "Int")]
	public int? IdBancoA
	{
		get
		{
			return _IdBancoA;
		}
		set
		{
			if (!_IdBancoA.Equals(value))
			{
				if (_NroCuenta.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdBancoA = value;
				SendPropertyChanged("IdBancoA");
			}
		}
	}

	[Column(Storage = "_NroCtaA", DbType = "VarChar(12)")]
	public string NroCtaA
	{
		get
		{
			return _NroCtaA;
		}
		set
		{
			if (!string.Equals(_NroCtaA, value))
			{
				if (_NroCuenta.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NroCtaA = value;
				SendPropertyChanged("NroCtaA");
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

	[Column(Storage = "_IdTipoMonedaA", DbType = "Int")]
	public int? IdTipoMonedaA
	{
		get
		{
			return _IdTipoMonedaA;
		}
		set
		{
			if (!_IdTipoMonedaA.Equals(value))
			{
				if (_NroCuenta.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoMonedaA = value;
				SendPropertyChanged("IdTipoMonedaA");
			}
		}
	}

	[Association(Name = "TransferenciaBco_IngresoCaj", Storage = "_IngresoCaj", ThisKey = "IdTransferencia", OtherKey = "IdTransferencia")]
	public EntitySet<IngresoCaj> IngresoCaj
	{
		get
		{
			return _IngresoCaj;
		}
		set
		{
			_IngresoCaj.Assign(value);
		}
	}

	[Association(Name = "Banco_TransferenciaBco", Storage = "_Banco", ThisKey = "IdBancoDe", OtherKey = "IdBanco", IsForeignKey = true)]
	public Banco Banco
	{
		get
		{
			return _Banco.Entity;
		}
		set
		{
			Banco previousValue = _Banco.Entity;
			if (!object.Equals(previousValue, value) || !_Banco.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Banco.Entity = null;
					previousValue.TransferenciaBco.Remove(this);
				}
				_Banco.Entity = value;
				if (value != null)
				{
					value.TransferenciaBco.Add(this);
					_IdBancoDe = value.IdBanco;
				}
				else
				{
					_IdBancoDe = null;
				}
				SendPropertyChanged("Banco");
			}
		}
	}

	[Association(Name = "NroCuenta_TransferenciaBco", Storage = "_NroCuenta", ThisKey = "IdBancoA,NroCtaA,IdTipoMonedaA", OtherKey = "IdBanco,NroCta,IdTipoMoneda", IsForeignKey = true)]
	public NroCuenta NroCuenta
	{
		get
		{
			return _NroCuenta.Entity;
		}
		set
		{
			NroCuenta previousValue = _NroCuenta.Entity;
			if (!object.Equals(previousValue, value) || !_NroCuenta.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_NroCuenta.Entity = null;
					previousValue.TransferenciaBco.Remove(this);
				}
				_NroCuenta.Entity = value;
				if (value != null)
				{
					value.TransferenciaBco.Add(this);
					_IdBancoA = value.IdBanco;
					_NroCtaA = value.NroCta;
					_IdTipoMonedaA = value.IdTipoMoneda;
				}
				else
				{
					_IdBancoA = null;
					_NroCtaA = null;
					_IdTipoMonedaA = null;
				}
				SendPropertyChanged("NroCuenta");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TransferenciaBco()
	{
		_IngresoCaj = new EntitySet<IngresoCaj>(attach_IngresoCaj, detach_IngresoCaj);
		_Banco = default(EntityRef<Banco>);
		_NroCuenta = default(EntityRef<NroCuenta>);
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

	private void attach_IngresoCaj(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.TransferenciaBco = this;
	}

	private void detach_IngresoCaj(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.TransferenciaBco = null;
	}
}
