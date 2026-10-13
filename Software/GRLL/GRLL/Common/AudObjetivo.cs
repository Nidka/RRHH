using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.AudObjetivo")]
public class AudObjetivo : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdAudObjetivo;

	private int? _IdObjetivo;

	private int? _Year;

	private int? _idAreaOrganiz;

	private int? _IdEstrategia;

	private string _Objetivo;

	private DateTime _FechaInicio;

	private DateTime _FechaFin;

	private int? _IdPresupuesto;

	private decimal? _AvanceAnual;

	private decimal? _AvanceGlobal;

	private decimal _Meta;

	private int _Importancia;

	private int? _IdUnidMed;

	private string _Estacion;

	private string _User1;

	private DateTime? _Fecha;

	private string _Operacion;

	[Column(Storage = "_IdAudObjetivo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdAudObjetivo
	{
		get
		{
			return _IdAudObjetivo;
		}
		set
		{
			if (_IdAudObjetivo != value)
			{
				SendPropertyChanging();
				_IdAudObjetivo = value;
				SendPropertyChanged("IdAudObjetivo");
			}
		}
	}

	[Column(Storage = "_IdObjetivo", DbType = "Int")]
	public int? IdObjetivo
	{
		get
		{
			return _IdObjetivo;
		}
		set
		{
			if (!_IdObjetivo.Equals(value))
			{
				SendPropertyChanging();
				_IdObjetivo = value;
				SendPropertyChanged("IdObjetivo");
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

	[Column(Storage = "_Objetivo", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
	public string Objetivo
	{
		get
		{
			return _Objetivo;
		}
		set
		{
			if (!string.Equals(_Objetivo, value))
			{
				SendPropertyChanging();
				_Objetivo = value;
				SendPropertyChanged("Objetivo");
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

	[Column(Storage = "_FechaFin", DbType = "SmallDateTime NOT NULL")]
	public DateTime FechaFin
	{
		get
		{
			return _FechaFin;
		}
		set
		{
			if (DateTime.Compare(_FechaFin, value) != 0)
			{
				SendPropertyChanging();
				_FechaFin = value;
				SendPropertyChanged("FechaFin");
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

	[Column(Storage = "_AvanceAnual", DbType = "Decimal(11,2)")]
	public decimal? AvanceAnual
	{
		get
		{
			return _AvanceAnual;
		}
		set
		{
			if (!_AvanceAnual.Equals(value))
			{
				SendPropertyChanging();
				_AvanceAnual = value;
				SendPropertyChanged("AvanceAnual");
			}
		}
	}

	[Column(Storage = "_AvanceGlobal", DbType = "Decimal(11,2)")]
	public decimal? AvanceGlobal
	{
		get
		{
			return _AvanceGlobal;
		}
		set
		{
			if (!_AvanceGlobal.Equals(value))
			{
				SendPropertyChanging();
				_AvanceGlobal = value;
				SendPropertyChanged("AvanceGlobal");
			}
		}
	}

	[Column(Storage = "_Meta", DbType = "Decimal(9,2) NOT NULL")]
	public decimal Meta
	{
		get
		{
			return _Meta;
		}
		set
		{
			if (decimal.Compare(_Meta, value) != 0)
			{
				SendPropertyChanging();
				_Meta = value;
				SendPropertyChanged("Meta");
			}
		}
	}

	[Column(Storage = "_Importancia", DbType = "Int NOT NULL")]
	public int Importancia
	{
		get
		{
			return _Importancia;
		}
		set
		{
			if (_Importancia != value)
			{
				SendPropertyChanging();
				_Importancia = value;
				SendPropertyChanged("Importancia");
			}
		}
	}

	[Column(Storage = "_IdUnidMed", DbType = "Int")]
	public int? IdUnidMed
	{
		get
		{
			return _IdUnidMed;
		}
		set
		{
			if (!_IdUnidMed.Equals(value))
			{
				SendPropertyChanging();
				_IdUnidMed = value;
				SendPropertyChanged("IdUnidMed");
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
