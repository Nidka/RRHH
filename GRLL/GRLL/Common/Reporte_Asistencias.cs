using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Reporte_Asistencias")]
public class Reporte_Asistencias : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private DateTime _Fecha;

	private int _IdEmpleado;

	private char? _Estado;

	private decimal? _Mt;

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

	[Column(Storage = "_Estado", DbType = "Char(1)")]
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

	[Column(Storage = "_Mt", DbType = "Decimal(18,2)")]
	public decimal? Mt
	{
		get
		{
			return _Mt;
		}
		set
		{
			if (!_Mt.Equals(value))
			{
				SendPropertyChanging();
				_Mt = value;
				SendPropertyChanged("Mt");
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
