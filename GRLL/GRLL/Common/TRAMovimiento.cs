using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRAMovimiento")]
public class TRAMovimiento : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdMovimiento;

	private string _IdEtapaProc;

	private string _IdTramite;

	private DateTime? _FechaIngreso;

	private decimal? _NumRecepcion;

	private int? _AreaIngreso;

	private int? _Anio;

	private int? _IdEmpleado;

	private string _Estado;

	private DateTime? _FechaSalida;

	private int? _AreaDestino;

	private int? _TiempoDias;

	private int? _TiempoHrs;

	private int? _TiempoMin;

	private string _MovimientoOrigen;

	private string _MovimientoDestino;

	private decimal? _AvisoHrs;

	private DateTime? _sysFecha;

	private string _sysUsuario;

	private string _sysPC;

	private bool? _Doc_Fisico;

	private string _Observacion;

	private EntitySet<TRAAdjunto> _TRAAdjunto;

	private EntityRef<TRAEtapa_Procedimiento> _TRAEtapa_Procedimiento;

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

	[Column(Storage = "_IdEtapaProc", DbType = "Char(8)")]
	public string IdEtapaProc
	{
		get
		{
			return _IdEtapaProc;
		}
		set
		{
			if (!string.Equals(_IdEtapaProc, value))
			{
				if (_TRAEtapa_Procedimiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdEtapaProc = value;
				SendPropertyChanged("IdEtapaProc");
			}
		}
	}

	[Column(Storage = "_IdTramite", DbType = "Char(10)")]
	public string IdTramite
	{
		get
		{
			return _IdTramite;
		}
		set
		{
			if (!string.Equals(_IdTramite, value))
			{
				SendPropertyChanging();
				_IdTramite = value;
				SendPropertyChanged("IdTramite");
			}
		}
	}

	[Column(Storage = "_FechaIngreso", DbType = "DateTime")]
	public DateTime? FechaIngreso
	{
		get
		{
			return _FechaIngreso;
		}
		set
		{
			if (!_FechaIngreso.Equals(value))
			{
				SendPropertyChanging();
				_FechaIngreso = value;
				SendPropertyChanged("FechaIngreso");
			}
		}
	}

	[Column(Storage = "_NumRecepcion", DbType = "Decimal(18,0)")]
	public decimal? NumRecepcion
	{
		get
		{
			return _NumRecepcion;
		}
		set
		{
			if (!_NumRecepcion.Equals(value))
			{
				SendPropertyChanging();
				_NumRecepcion = value;
				SendPropertyChanged("NumRecepcion");
			}
		}
	}

	[Column(Storage = "_AreaIngreso", DbType = "Int")]
	public int? AreaIngreso
	{
		get
		{
			return _AreaIngreso;
		}
		set
		{
			if (!_AreaIngreso.Equals(value))
			{
				SendPropertyChanging();
				_AreaIngreso = value;
				SendPropertyChanged("AreaIngreso");
			}
		}
	}

	[Column(Storage = "_Anio", DbType = "Int")]
	public int? Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!_Anio.Equals(value))
			{
				SendPropertyChanging();
				_Anio = value;
				SendPropertyChanged("Anio");
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

	[Column(Storage = "_Estado", DbType = "Char(2)")]
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

	[Column(Storage = "_FechaSalida", DbType = "DateTime")]
	public DateTime? FechaSalida
	{
		get
		{
			return _FechaSalida;
		}
		set
		{
			if (!_FechaSalida.Equals(value))
			{
				SendPropertyChanging();
				_FechaSalida = value;
				SendPropertyChanged("FechaSalida");
			}
		}
	}

	[Column(Storage = "_AreaDestino", DbType = "Int")]
	public int? AreaDestino
	{
		get
		{
			return _AreaDestino;
		}
		set
		{
			if (!_AreaDestino.Equals(value))
			{
				SendPropertyChanging();
				_AreaDestino = value;
				SendPropertyChanged("AreaDestino");
			}
		}
	}

	[Column(Storage = "_TiempoDias", DbType = "Int")]
	public int? TiempoDias
	{
		get
		{
			return _TiempoDias;
		}
		set
		{
			if (!_TiempoDias.Equals(value))
			{
				SendPropertyChanging();
				_TiempoDias = value;
				SendPropertyChanged("TiempoDias");
			}
		}
	}

	[Column(Storage = "_TiempoHrs", DbType = "Int")]
	public int? TiempoHrs
	{
		get
		{
			return _TiempoHrs;
		}
		set
		{
			if (!_TiempoHrs.Equals(value))
			{
				SendPropertyChanging();
				_TiempoHrs = value;
				SendPropertyChanged("TiempoHrs");
			}
		}
	}

	[Column(Storage = "_TiempoMin", DbType = "Int")]
	public int? TiempoMin
	{
		get
		{
			return _TiempoMin;
		}
		set
		{
			if (!_TiempoMin.Equals(value))
			{
				SendPropertyChanging();
				_TiempoMin = value;
				SendPropertyChanged("TiempoMin");
			}
		}
	}

	[Column(Storage = "_MovimientoOrigen", DbType = "Char(10)")]
	public string MovimientoOrigen
	{
		get
		{
			return _MovimientoOrigen;
		}
		set
		{
			if (!string.Equals(_MovimientoOrigen, value))
			{
				SendPropertyChanging();
				_MovimientoOrigen = value;
				SendPropertyChanged("MovimientoOrigen");
			}
		}
	}

	[Column(Storage = "_MovimientoDestino", DbType = "Char(10)")]
	public string MovimientoDestino
	{
		get
		{
			return _MovimientoDestino;
		}
		set
		{
			if (!string.Equals(_MovimientoDestino, value))
			{
				SendPropertyChanging();
				_MovimientoDestino = value;
				SendPropertyChanged("MovimientoDestino");
			}
		}
	}

	[Column(Storage = "_AvisoHrs", DbType = "Decimal(9,2)")]
	public decimal? AvisoHrs
	{
		get
		{
			return _AvisoHrs;
		}
		set
		{
			if (!_AvisoHrs.Equals(value))
			{
				SendPropertyChanging();
				_AvisoHrs = value;
				SendPropertyChanged("AvisoHrs");
			}
		}
	}

	[Column(Storage = "_sysFecha", DbType = "DateTime")]
	public DateTime? sysFecha
	{
		get
		{
			return _sysFecha;
		}
		set
		{
			if (!_sysFecha.Equals(value))
			{
				SendPropertyChanging();
				_sysFecha = value;
				SendPropertyChanged("sysFecha");
			}
		}
	}

	[Column(Storage = "_sysUsuario", DbType = "Char(20)")]
	public string sysUsuario
	{
		get
		{
			return _sysUsuario;
		}
		set
		{
			if (!string.Equals(_sysUsuario, value))
			{
				SendPropertyChanging();
				_sysUsuario = value;
				SendPropertyChanged("sysUsuario");
			}
		}
	}

	[Column(Storage = "_sysPC", DbType = "Char(20)")]
	public string sysPC
	{
		get
		{
			return _sysPC;
		}
		set
		{
			if (!string.Equals(_sysPC, value))
			{
				SendPropertyChanging();
				_sysPC = value;
				SendPropertyChanged("sysPC");
			}
		}
	}

	[Column(Storage = "_Doc_Fisico", DbType = "Bit")]
	public bool? Doc_Fisico
	{
		get
		{
			return _Doc_Fisico;
		}
		set
		{
			if (!_Doc_Fisico.Equals(value))
			{
				SendPropertyChanging();
				_Doc_Fisico = value;
				SendPropertyChanged("Doc_Fisico");
			}
		}
	}

	[Column(Storage = "_Observacion", DbType = "NVarChar(100)")]
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

	[Association(Name = "TRAMovimiento_TRAAdjunto", Storage = "_TRAAdjunto", ThisKey = "IdMovimiento", OtherKey = "IdMovimiento")]
	public EntitySet<TRAAdjunto> TRAAdjunto
	{
		get
		{
			return _TRAAdjunto;
		}
		set
		{
			_TRAAdjunto.Assign(value);
		}
	}

	[Association(Name = "TRAEtapa_Procedimiento_TRAMovimiento", Storage = "_TRAEtapa_Procedimiento", ThisKey = "IdEtapaProc", OtherKey = "IdEtapaProc", IsForeignKey = true, DeleteRule = "CASCADE")]
	public TRAEtapa_Procedimiento TRAEtapa_Procedimiento
	{
		get
		{
			return _TRAEtapa_Procedimiento.Entity;
		}
		set
		{
			TRAEtapa_Procedimiento previousValue = _TRAEtapa_Procedimiento.Entity;
			if (!object.Equals(previousValue, value) || !_TRAEtapa_Procedimiento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TRAEtapa_Procedimiento.Entity = null;
					previousValue.TRAMovimiento.Remove(this);
				}
				_TRAEtapa_Procedimiento.Entity = value;
				if (value != null)
				{
					value.TRAMovimiento.Add(this);
					_IdEtapaProc = value.IdEtapaProc;
				}
				else
				{
					_IdEtapaProc = null;
				}
				SendPropertyChanged("TRAEtapa_Procedimiento");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRAMovimiento()
	{
		_TRAAdjunto = new EntitySet<TRAAdjunto>(attach_TRAAdjunto, detach_TRAAdjunto);
		_TRAEtapa_Procedimiento = default(EntityRef<TRAEtapa_Procedimiento>);
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

	private void attach_TRAAdjunto(TRAAdjunto entity)
	{
		SendPropertyChanging();
		entity.TRAMovimiento = this;
	}

	private void detach_TRAAdjunto(TRAAdjunto entity)
	{
		SendPropertyChanging();
		entity.TRAMovimiento = null;
	}
}
