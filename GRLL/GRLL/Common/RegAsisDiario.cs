using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RegAsisDiario")]
public class RegAsisDiario : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private DateTime _Fecha;

	private int _IdEmpleado;

	private string _MinNormales;

	private decimal? _MinTarde;

	private string _Estado;

	[Column(Storage = "_Fecha", DbType = "DateTime NOT NULL", IsPrimaryKey = true)]
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

	[Column(Storage = "_IdEmpleado", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (_IdEmpleado != value)
			{
				SendPropertyChanging();
				_IdEmpleado = value;
				SendPropertyChanged("IdEmpleado");
			}
		}
	}

	[Column(Storage = "_MinNormales", DbType = "VarChar(4)")]
	public string MinNormales
	{
		get
		{
			return _MinNormales;
		}
		set
		{
			if (!string.Equals(_MinNormales, value))
			{
				SendPropertyChanging();
				_MinNormales = value;
				SendPropertyChanged("MinNormales");
			}
		}
	}

	[Column(Storage = "_MinTarde", DbType = "Decimal(8,2)")]
	public decimal? MinTarde
	{
		get
		{
			return _MinTarde;
		}
		set
		{
			if (!_MinTarde.Equals(value))
			{
				SendPropertyChanging();
				_MinTarde = value;
				SendPropertyChanged("MinTarde");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "VarChar(2)")]
	public string Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!string.Equals(_Estado, value))
			{
				SendPropertyChanging();
				_Estado = value;
				SendPropertyChanged("Estado");
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
