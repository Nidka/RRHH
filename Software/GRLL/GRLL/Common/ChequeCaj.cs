using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ChequeCaj")]
public class ChequeCaj : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdCheque;

	private int _IdBanco;

	private string _NroCheque;

	private string _GiradorNro;

	private char? _Plaza;

	private decimal? _Total;

	private char? _Estado;

	private int? _IdTipoMoneda;

	private EntitySet<IngresoCaj> _IngresoCaj;

	[Column(Storage = "_IdCheque", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdCheque
	{
		get
		{
			return _IdCheque;
		}
		set
		{
			if (_IdCheque != value)
			{
				SendPropertyChanging();
				_IdCheque = value;
				SendPropertyChanged("IdCheque");
			}
		}
	}

	[Column(Storage = "_IdBanco", DbType = "Int NOT NULL")]
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

	[Column(Storage = "_NroCheque", DbType = "VarChar(15) NOT NULL", CanBeNull = false)]
	public string NroCheque
	{
		get
		{
			return _NroCheque;
		}
		set
		{
			if (!string.Equals(_NroCheque, value))
			{
				SendPropertyChanging();
				_NroCheque = value;
				SendPropertyChanged("NroCheque");
			}
		}
	}

	[Column(Storage = "_GiradorNro", DbType = "VarChar(15)")]
	public string GiradorNro
	{
		get
		{
			return _GiradorNro;
		}
		set
		{
			if (!string.Equals(_GiradorNro, value))
			{
				SendPropertyChanging();
				_GiradorNro = value;
				SendPropertyChanged("GiradorNro");
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
				SendPropertyChanging();
				_IdTipoMoneda = value;
				SendPropertyChanged("IdTipoMoneda");
			}
		}
	}

	[Association(Name = "ChequeCaj_IngresoCaj", Storage = "_IngresoCaj", ThisKey = "IdCheque", OtherKey = "IdCheque")]
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

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public ChequeCaj()
	{
		_IngresoCaj = new EntitySet<IngresoCaj>(attach_IngresoCaj, detach_IngresoCaj);
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
		entity.ChequeCaj = this;
	}

	private void detach_IngresoCaj(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.ChequeCaj = null;
	}
}
