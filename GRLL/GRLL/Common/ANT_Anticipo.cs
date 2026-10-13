using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ANT_Anticipo")]
public class ANT_Anticipo : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdAnticipo;

	private string _IdEmpleado;

	private DateTime _Fecha;

	private decimal _Monto;

	private string _Motivo;

	private string _Observacion;

	private string _SIAF;

	private string _CP;

	[Column(Storage = "_IdAnticipo", DbType = "Char(10) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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

	[Column(Storage = "_IdEmpleado", DbType = "Char(10) NOT NULL", CanBeNull = false)]
	public string IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (!string.Equals(_IdEmpleado, value))
			{
				SendPropertyChanging();
				_IdEmpleado = value;
				SendPropertyChanged("IdEmpleado");
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

	[Column(Storage = "_Motivo", DbType = "Char(50) NOT NULL", CanBeNull = false)]
	public string Motivo
	{
		get
		{
			return _Motivo;
		}
		set
		{
			if (!string.Equals(_Motivo, value))
			{
				SendPropertyChanging();
				_Motivo = value;
				SendPropertyChanged("Motivo");
			}
		}
	}

	[Column(Storage = "_Observacion", DbType = "Char(100)")]
	public string Observacion
	{
		get
		{
			return _Observacion;
		}
		set
		{
			if (!string.Equals(_Observacion, value))
			{
				SendPropertyChanging();
				_Observacion = value;
				SendPropertyChanged("Observacion");
			}
		}
	}

	[Column(Storage = "_SIAF", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string SIAF
	{
		get
		{
			return _SIAF;
		}
		set
		{
			if (!string.Equals(_SIAF, value))
			{
				SendPropertyChanging();
				_SIAF = value;
				SendPropertyChanged("SIAF");
			}
		}
	}

	[Column(Storage = "_CP", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string CP
	{
		get
		{
			return _CP;
		}
		set
		{
			if (!string.Equals(_CP, value))
			{
				SendPropertyChanging();
				_CP = value;
				SendPropertyChanged("CP");
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
