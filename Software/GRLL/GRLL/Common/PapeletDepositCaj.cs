using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.PapeletDepositCaj")]
public class PapeletDepositCaj : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdBanco;

	private string _NroPapeleta;

	private string _NroCta;

	private DateTime _FechaPapelDep;

	private decimal? _Total;

	private string _DNIDepositante;

	private DateTime _FechaDeposito;

	private char? _TipoDeposito;

	private char? _Plaza;

	private string _ReferSIAF;

	private int? _IdTipoMoneda;

	private EntitySet<IngresoCaj> _IngresoCaj;

	private EntityRef<NroCuenta> _NroCuenta;

	[Column(Storage = "_IdBanco", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdBanco
	{
		get
		{
			return _IdBanco;
		}
		set
		{
			if (_IdBanco != value)
			{
				if (_NroCuenta.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdBanco = value;
				SendPropertyChanged("IdBanco");
			}
		}
	}

	[Column(Storage = "_NroPapeleta", DbType = "VarChar(10) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string NroPapeleta
	{
		get
		{
			return _NroPapeleta;
		}
		set
		{
			if (!string.Equals(_NroPapeleta, value))
			{
				SendPropertyChanging();
				_NroPapeleta = value;
				SendPropertyChanged("NroPapeleta");
			}
		}
	}

	[Column(Storage = "_NroCta", DbType = "VarChar(12)")]
	public string NroCta
	{
		get
		{
			return _NroCta;
		}
		set
		{
			if (!string.Equals(_NroCta, value))
			{
				if (_NroCuenta.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NroCta = value;
				SendPropertyChanged("NroCta");
			}
		}
	}

	[Column(Storage = "_FechaPapelDep", DbType = "SmallDateTime NOT NULL")]
	public DateTime FechaPapelDep
	{
		get
		{
			return _FechaPapelDep;
		}
		set
		{
			if (DateTime.Compare(_FechaPapelDep, value) != 0)
			{
				SendPropertyChanging();
				_FechaPapelDep = value;
				SendPropertyChanged("FechaPapelDep");
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

	[Column(Storage = "_DNIDepositante", DbType = "VarChar(8) NOT NULL", CanBeNull = false)]
	public string DNIDepositante
	{
		get
		{
			return _DNIDepositante;
		}
		set
		{
			if (!string.Equals(_DNIDepositante, value))
			{
				SendPropertyChanging();
				_DNIDepositante = value;
				SendPropertyChanged("DNIDepositante");
			}
		}
	}

	[Column(Storage = "_FechaDeposito", DbType = "SmallDateTime NOT NULL")]
	public DateTime FechaDeposito
	{
		get
		{
			return _FechaDeposito;
		}
		set
		{
			if (DateTime.Compare(_FechaDeposito, value) != 0)
			{
				SendPropertyChanging();
				_FechaDeposito = value;
				SendPropertyChanged("FechaDeposito");
			}
		}
	}

	[Column(Storage = "_TipoDeposito", DbType = "VarChar(1)")]
	public char? TipoDeposito
	{
		get
		{
			return _TipoDeposito;
		}
		set
		{
			if (!_TipoDeposito.Equals(value))
			{
				SendPropertyChanging();
				_TipoDeposito = value;
				SendPropertyChanged("TipoDeposito");
			}
		}
	}

	[Column(Storage = "_Plaza", DbType = "VarChar(1)")]
	public char? Plaza
	{
		get
		{
			return _Plaza;
		}
		set
		{
			if (!_Plaza.Equals(value))
			{
				SendPropertyChanging();
				_Plaza = value;
				SendPropertyChanged("Plaza");
			}
		}
	}

	[Column(Storage = "_ReferSIAF", DbType = "VarChar(6)")]
	public string ReferSIAF
	{
		get
		{
			return _ReferSIAF;
		}
		set
		{
			if (!string.Equals(_ReferSIAF, value))
			{
				SendPropertyChanging();
				_ReferSIAF = value;
				SendPropertyChanged("ReferSIAF");
			}
		}
	}

	[Column(Storage = "_IdTipoMoneda", DbType = "Int")]
	public int? IdTipoMoneda
	{
		get
		{
			return _IdTipoMoneda;
		}
		set
		{
			if (!_IdTipoMoneda.Equals(value))
			{
				if (_NroCuenta.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoMoneda = value;
				SendPropertyChanged("IdTipoMoneda");
			}
		}
	}

	[Association(Name = "PapeletDepositCaj_IngresoCaj", Storage = "_IngresoCaj", ThisKey = "IdBanco,NroPapeleta", OtherKey = "IdBanco,NroPapeleta")]
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

	[Association(Name = "NroCuenta_PapeletDepositCaj", Storage = "_NroCuenta", ThisKey = "IdBanco,NroCta,IdTipoMoneda", OtherKey = "IdBanco,NroCta,IdTipoMoneda", IsForeignKey = true)]
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
					previousValue.PapeletDepositCaj.Remove(this);
				}
				_NroCuenta.Entity = value;
				if (value != null)
				{
					value.PapeletDepositCaj.Add(this);
					_IdBanco = value.IdBanco;
					_NroCta = value.NroCta;
					_IdTipoMoneda = value.IdTipoMoneda;
				}
				else
				{
					_IdBanco = 0;
					_NroCta = null;
					_IdTipoMoneda = null;
				}
				SendPropertyChanged("NroCuenta");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public PapeletDepositCaj()
	{
		_IngresoCaj = new EntitySet<IngresoCaj>(attach_IngresoCaj, detach_IngresoCaj);
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
		entity.PapeletDepositCaj = this;
	}

	private void detach_IngresoCaj(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.PapeletDepositCaj = null;
	}
}
