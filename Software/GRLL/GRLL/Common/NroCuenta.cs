using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.NroCuenta")]
public class NroCuenta : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdBanco;

	private string _NroCta;

	private int _IdTipoMoneda;

	private char? _Estado;

	private EntitySet<PapeletDepositCaj> _PapeletDepositCaj;

	private EntitySet<TransferenciaBco> _TransferenciaBco;

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
				SendPropertyChanging();
				_IdBanco = value;
				SendPropertyChanged("IdBanco");
			}
		}
	}

	[Column(Storage = "_NroCta", DbType = "VarChar(12) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_NroCta = value;
				SendPropertyChanged("NroCta");
			}
		}
	}

	[Column(Storage = "_IdTipoMoneda", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdTipoMoneda
	{
		get
		{
			return _IdTipoMoneda;
		}
		set
		{
			if (_IdTipoMoneda != value)
			{
				SendPropertyChanging();
				_IdTipoMoneda = value;
				SendPropertyChanged("IdTipoMoneda");
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

	[Association(Name = "NroCuenta_PapeletDepositCaj", Storage = "_PapeletDepositCaj", ThisKey = "IdBanco,NroCta,IdTipoMoneda", OtherKey = "IdBanco,NroCta,IdTipoMoneda")]
	public EntitySet<PapeletDepositCaj> PapeletDepositCaj
	{
		get
		{
			return _PapeletDepositCaj;
		}
		set
		{
			_PapeletDepositCaj.Assign(value);
		}
	}

	[Association(Name = "NroCuenta_TransferenciaBco", Storage = "_TransferenciaBco", ThisKey = "IdBanco,NroCta,IdTipoMoneda", OtherKey = "IdBancoA,NroCtaA,IdTipoMonedaA")]
	public EntitySet<TransferenciaBco> TransferenciaBco
	{
		get
		{
			return _TransferenciaBco;
		}
		set
		{
			_TransferenciaBco.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public NroCuenta()
	{
		_PapeletDepositCaj = new EntitySet<PapeletDepositCaj>(attach_PapeletDepositCaj, detach_PapeletDepositCaj);
		_TransferenciaBco = new EntitySet<TransferenciaBco>(attach_TransferenciaBco, detach_TransferenciaBco);
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

	private void attach_PapeletDepositCaj(PapeletDepositCaj entity)
	{
		SendPropertyChanging();
		entity.NroCuenta = this;
	}

	private void detach_PapeletDepositCaj(PapeletDepositCaj entity)
	{
		SendPropertyChanging();
		entity.NroCuenta = null;
	}

	private void attach_TransferenciaBco(TransferenciaBco entity)
	{
		SendPropertyChanging();
		entity.NroCuenta = this;
	}

	private void detach_TransferenciaBco(TransferenciaBco entity)
	{
		SendPropertyChanging();
		entity.NroCuenta = null;
	}
}
