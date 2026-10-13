using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.AudTablas")]
public class AudTablas : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdAudTablas;

	private string _Tablas;

	private string _Campos;

	private string _Datos;

	private string _Estacion;

	private string _User1;

	private DateTime? _Fecha;

	private string _Operacion;

	[Column(Storage = "_IdAudTablas", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdAudTablas
	{
		get
		{
			return _IdAudTablas;
		}
		set
		{
			if (_IdAudTablas != value)
			{
				SendPropertyChanging();
				_IdAudTablas = value;
				SendPropertyChanged("IdAudTablas");
			}
		}
	}

	[Column(Storage = "_Tablas", DbType = "VarChar(25)")]
	public string Tablas
	{
		get
		{
			return _Tablas;
		}
		set
		{
			if (!string.Equals(_Tablas, value))
			{
				SendPropertyChanging();
				_Tablas = value;
				SendPropertyChanged("Tablas");
			}
		}
	}

	[Column(Storage = "_Campos", DbType = "VarChar(200)")]
	public string Campos
	{
		get
		{
			return _Campos;
		}
		set
		{
			if (!string.Equals(_Campos, value))
			{
				SendPropertyChanging();
				_Campos = value;
				SendPropertyChanged("Campos");
			}
		}
	}

	[Column(Storage = "_Datos", DbType = "VarChar(1000)")]
	public string Datos
	{
		get
		{
			return _Datos;
		}
		set
		{
			if (!string.Equals(_Datos, value))
			{
				SendPropertyChanging();
				_Datos = value;
				SendPropertyChanged("Datos");
			}
		}
	}

	[Column(Storage = "_Estacion", DbType = "VarChar(100)")]
	public string Estacion
	{
		get
		{
			return _Estacion;
		}
		set
		{
			if (!string.Equals(_Estacion, value))
			{
				SendPropertyChanging();
				_Estacion = value;
				SendPropertyChanged("Estacion");
			}
		}
	}

	[Column(Storage = "_User1", DbType = "VarChar(100)")]
	public string User1
	{
		get
		{
			return _User1;
		}
		set
		{
			if (!string.Equals(_User1, value))
			{
				SendPropertyChanging();
				_User1 = value;
				SendPropertyChanged("User1");
			}
		}
	}

	[Column(Storage = "_Fecha", DbType = "SmallDateTime")]
	public DateTime? Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!_Fecha.Equals(value))
			{
				SendPropertyChanging();
				_Fecha = value;
				SendPropertyChanged("Fecha");
			}
		}
	}

	[Column(Storage = "_Operacion", DbType = "VarChar(2)")]
	public string Operacion
	{
		get
		{
			return _Operacion;
		}
		set
		{
			if (!string.Equals(_Operacion, value))
			{
				SendPropertyChanging();
				_Operacion = value;
				SendPropertyChanged("Operacion");
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
