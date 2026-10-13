using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ANT_Movimiento")]
public class ANT_Movimiento : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdMovimiento;

	private string _IdAnticipo;

	private DateTime _Fecha;

	private decimal _Monto;

	private decimal _Saldo;

	[Column(Storage = "_IdMovimiento", DbType = "Char(10) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_IdMovimiento = value;
				SendPropertyChanged("IdMovimiento");
			}
		}
	}

	[Column(Storage = "_IdAnticipo", DbType = "Char(10) NOT NULL", CanBeNull = false)]
	public string IdAnticipo
	{
		get
		{
			return _IdAnticipo;
		}
		set
		{
			if (!string.Equals(_IdAnticipo, value))
			{
				SendPropertyChanging();
				_IdAnticipo = value;
				SendPropertyChanged("IdAnticipo");
			}
		}
	}

	[Column(Storage = "_Fecha", DbType = "DateTime NOT NULL")]
	public DateTime Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (DateTime.Compare(_Fecha, value) != 0)
			{
				SendPropertyChanging();
				_Fecha = value;
				SendPropertyChanged("Fecha");
			}
		}
	}

	[Column(Storage = "_Monto", DbType = "Money NOT NULL")]
	public decimal Monto
	{
		get
		{
			return _Monto;
		}
		set
		{
			if (decimal.Compare(_Monto, value) != 0)
			{
				SendPropertyChanging();
				_Monto = value;
				SendPropertyChanged("Monto");
			}
		}
	}

	[Column(Storage = "_Saldo", DbType = "Money NOT NULL")]
	public decimal Saldo
	{
		get
		{
			return _Saldo;
		}
		set
		{
			if (decimal.Compare(_Saldo, value) != 0)
			{
				SendPropertyChanging();
				_Saldo = value;
				SendPropertyChanged("Saldo");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

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
