using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.AudActividad")]
public class AudActividad : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdAudActividad;

	private int? _IdObjetivo;

	private int? _IdActividad;

	private int? _NroActividad;

	private string _Actividad;

	private int? _IdEmpleado;

	private int? _IdUnidMed;

	private decimal _Meta;

	private char? _IsMeta;

	private decimal? _MetaMin;

	private int? _TrabXActiv;

	private decimal? _HH;

	private decimal? _BienServ;

	private int _Importancia;

	private decimal? _Avance;

	private decimal? _AvanceAnual;

	private DateTime _FechaInicio;

	private DateTime _FechaFin;

	private string _UnidsOrgs;

	private int? _IdPresupuesto;

	private string _Observacion;

	private string _Estacion;

	private string _User1;

	private DateTime? _Fecha;

	private string _Operacion;

	[Column(Storage = "_IdAudActividad", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdAudActividad
	{
		get
		{
			return _IdAudActividad;
		}
		set
		{
			if (_IdAudActividad != value)
			{
				SendPropertyChanging();
				_IdAudActividad = value;
				SendPropertyChanged("IdAudActividad");
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

	[Column(Storage = "_IdActividad", DbType = "Int")]
	public int? IdActividad
	{
		get
		{
			return _IdActividad;
		}
		set
		{
			if (!_IdActividad.Equals(value))
			{
				SendPropertyChanging();
				_IdActividad = value;
				SendPropertyChanged("IdActividad");
			}
		}
	}

	[Column(Storage = "_NroActividad", DbType = "Int")]
	public int? NroActividad
	{
		get
		{
			return _NroActividad;
		}
		set
		{
			if (!_NroActividad.Equals(value))
			{
				SendPropertyChanging();
				_NroActividad = value;
				SendPropertyChanged("NroActividad");
			}
		}
	}

	[Column(Storage = "_Actividad", DbType = "VarChar(300) NOT NULL", CanBeNull = false)]
	public string Actividad
	{
		get
		{
			return _Actividad;
		}
		set
		{
			if (!string.Equals(_Actividad, value))
			{
				SendPropertyChanging();
				_Actividad = value;
				SendPropertyChanged("Actividad");
			}
		}
	}

	[Column(Storage = "_IdEmpleado", DbType = "Int")]
	public int? IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (!_IdEmpleado.Equals(value))
			{
				SendPropertyChanging();
				_IdEmpleado = value;
				SendPropertyChanged("IdEmpleado");
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

	[Column(Storage = "_Meta", DbType = "Decimal(11,2) NOT NULL")]
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

	[Column(Storage = "_IsMeta", DbType = "VarChar(1)")]
	public char? IsMeta
	{
		get
		{
			return _IsMeta;
		}
		set
		{
			if (!_IsMeta.Equals(value))
			{
				SendPropertyChanging();
				_IsMeta = value;
				SendPropertyChanged("IsMeta");
			}
		}
	}

	[Column(Storage = "_MetaMin", DbType = "Decimal(11,2)")]
	public decimal? MetaMin
	{
		get
		{
			return _MetaMin;
		}
		set
		{
			if (!_MetaMin.Equals(value))
			{
				SendPropertyChanging();
				_MetaMin = value;
				SendPropertyChanged("MetaMin");
			}
		}
	}

	[Column(Storage = "_TrabXActiv", DbType = "Int")]
	public int? TrabXActiv
	{
		get
		{
			return _TrabXActiv;
		}
		set
		{
			if (!_TrabXActiv.Equals(value))
			{
				SendPropertyChanging();
				_TrabXActiv = value;
				SendPropertyChanged("TrabXActiv");
			}
		}
	}

	[Column(Storage = "_HH", DbType = "Decimal(11,2)")]
	public decimal? HH
	{
		get
		{
			return _HH;
		}
		set
		{
			if (!_HH.Equals(value))
			{
				SendPropertyChanging();
				_HH = value;
				SendPropertyChanged("HH");
			}
		}
	}

	[Column(Storage = "_BienServ", DbType = "Decimal(11,2)")]
	public decimal? BienServ
	{
		get
		{
			return _BienServ;
		}
		set
		{
			if (!_BienServ.Equals(value))
			{
				SendPropertyChanging();
				_BienServ = value;
				SendPropertyChanged("BienServ");
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

	[Column(Storage = "_Avance", DbType = "Decimal(11,2)")]
	public decimal? Avance
	{
		get
		{
			return _Avance;
		}
		set
		{
			if (!_Avance.Equals(value))
			{
				SendPropertyChanging();
				_Avance = value;
				SendPropertyChanged("Avance");
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

	[Column(Storage = "_UnidsOrgs", DbType = "VarChar(20)")]
	public string UnidsOrgs
	{
		get
		{
			return _UnidsOrgs;
		}
		set
		{
			if (!string.Equals(_UnidsOrgs, value))
			{
				SendPropertyChanging();
				_UnidsOrgs = value;
				SendPropertyChanged("UnidsOrgs");
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

	[Column(Storage = "_Observacion", DbType = "VarChar(500)")]
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
