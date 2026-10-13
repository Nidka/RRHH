using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.AudEstrategia")]
public class AudEstrategia : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdAudEstrategia;

	private int? _Year;

	private int? _idAreaOrganiz;

	private int? _IdEstrategia;

	private string _Estrategia;

	private DateTime _FechaInicio;

	private DateTime _FechaCulminacion;

	private int? _IdPresupuesto;

	private string _Estacion;

	private string _User1;

	private DateTime? _Fecha;

	private string _Operacion;

	[Column(Storage = "_IdAudEstrategia", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdAudEstrategia
	{
		get
		{
			return _IdAudEstrategia;
		}
		set
		{
			if (_IdAudEstrategia != value)
			{
				SendPropertyChanging();
				_IdAudEstrategia = value;
				SendPropertyChanged("IdAudEstrategia");
			}
		}
	}

	[Column(Storage = "_Year", DbType = "Int")]
	public int? Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (!_Year.Equals(value))
			{
				SendPropertyChanging();
				_Year = value;
				SendPropertyChanged("Year");
			}
		}
	}

	[Column(Storage = "_idAreaOrganiz", DbType = "Int")]
	public int? idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (!_idAreaOrganiz.Equals(value))
			{
				SendPropertyChanging();
				_idAreaOrganiz = value;
				SendPropertyChanged("idAreaOrganiz");
			}
		}
	}

	[Column(Storage = "_IdEstrategia", DbType = "Int")]
	public int? IdEstrategia
	{
		get
		{
			return _IdEstrategia;
		}
		set
		{
			if (!_IdEstrategia.Equals(value))
			{
				SendPropertyChanging();
				_IdEstrategia = value;
				SendPropertyChanged("IdEstrategia");
			}
		}
	}

	[Column(Storage = "_Estrategia", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
	public string Estrategia
	{
		get
		{
			return _Estrategia;
		}
		set
		{
			if (!string.Equals(_Estrategia, value))
			{
				SendPropertyChanging();
				_Estrategia = value;
				SendPropertyChanged("Estrategia");
			}
		}
	}

	[Column(Storage = "_FechaInicio", DbType = "SmallDateTime NOT NULL")]
	public DateTime FechaInicio
	{
		get
		{
			return _FechaInicio;
		}
		set
		{
			if (DateTime.Compare(_FechaInicio, value) != 0)
			{
				SendPropertyChanging();
				_FechaInicio = value;
				SendPropertyChanged("FechaInicio");
			}
		}
	}

	[Column(Storage = "_FechaCulminacion", DbType = "SmallDateTime NOT NULL")]
	public DateTime FechaCulminacion
	{
		get
		{
			return _FechaCulminacion;
		}
		set
		{
			if (DateTime.Compare(_FechaCulminacion, value) != 0)
			{
				SendPropertyChanging();
				_FechaCulminacion = value;
				SendPropertyChanged("FechaCulminacion");
			}
		}
	}

	[Column(Storage = "_IdPresupuesto", DbType = "Int")]
	public int? IdPresupuesto
	{
		get
		{
			return _IdPresupuesto;
		}
		set
		{
			if (!_IdPresupuesto.Equals(value))
			{
				SendPropertyChanging();
				_IdPresupuesto = value;
				SendPropertyChanged("IdPresupuesto");
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
