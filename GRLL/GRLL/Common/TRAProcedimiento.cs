using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRAProcedimiento")]
public class TRAProcedimiento : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdProcedimiento;

	private string _TraCodigo;

	private string _Descripcion;

	private int? _TiempoDias;

	private int? _TiempoMin;

	private int? _TiempoHrs;

	private byte? _IdTipoSilencio;

	private string _Observaciones;

	private int? _Anio;

	private char? _Estado;

	private int? _IdAreaOrganiz;

	private char? _Ambito;

	private char? _Tipo;

	private DateTime? _sysFecha;

	private string _sysUsuario;

	private string _sysPC;

	private EntitySet<TRAProcedimiento_Requisito> _TRAProcedimiento_Requisito;

	private EntitySet<TRAEtapa_Procedimiento> _TRAEtapa_Procedimiento;

	private EntityRef<TRATipoSilencio> _TRATipoSilencio;

	[Column(Storage = "_IdProcedimiento", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdProcedimiento
	{
		get
		{
			return _IdProcedimiento;
		}
		set
		{
			if (!string.Equals(_IdProcedimiento, value))
			{
				SendPropertyChanging();
				_IdProcedimiento = value;
				SendPropertyChanged("IdProcedimiento");
			}
		}
	}

	[Column(Storage = "_TraCodigo", DbType = "Char(20) NOT NULL", CanBeNull = false)]
	public string TraCodigo
	{
		get
		{
			return _TraCodigo;
		}
		set
		{
			if (!string.Equals(_TraCodigo, value))
			{
				SendPropertyChanging();
				_TraCodigo = value;
				SendPropertyChanged("TraCodigo");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(300)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				SendPropertyChanging();
				_Descripcion = value;
				SendPropertyChanged("Descripcion");
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

	[Column(Storage = "_IdTipoSilencio", DbType = "TinyInt")]
	public byte? IdTipoSilencio
	{
		get
		{
			return _IdTipoSilencio;
		}
		set
		{
			if (!_IdTipoSilencio.Equals(value))
			{
				if (_TRATipoSilencio.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoSilencio = value;
				SendPropertyChanged("IdTipoSilencio");
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(400)")]
	public string Observaciones
	{
		get
		{
			return _Observaciones;
		}
		set
		{
			if (!string.Equals(_Observaciones, value))
			{
				SendPropertyChanging();
				_Observaciones = value;
				SendPropertyChanged("Observaciones");
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

	[Column(Storage = "_IdAreaOrganiz", DbType = "Int")]
	public int? IdAreaOrganiz
	{
		get
		{
			return _IdAreaOrganiz;
		}
		set
		{
			if (!_IdAreaOrganiz.Equals(value))
			{
				SendPropertyChanging();
				_IdAreaOrganiz = value;
				SendPropertyChanged("IdAreaOrganiz");
			}
		}
	}

	[Column(Storage = "_Ambito", DbType = "Char(1)")]
	public char? Ambito
	{
		get
		{
			return _Ambito;
		}
		set
		{
			if (!_Ambito.Equals(value))
			{
				SendPropertyChanging();
				_Ambito = value;
				SendPropertyChanged("Ambito");
			}
		}
	}

	[Column(Storage = "_Tipo", DbType = "Char(1)")]
	public char? Tipo
	{
		get
		{
			return _Tipo;
		}
		set
		{
			if (!_Tipo.Equals(value))
			{
				SendPropertyChanging();
				_Tipo = value;
				SendPropertyChanged("Tipo");
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

	[Association(Name = "TRAProcedimiento_TRAProcedimiento_Requisito", Storage = "_TRAProcedimiento_Requisito", ThisKey = "IdProcedimiento", OtherKey = "IdProcedimiento")]
	public EntitySet<TRAProcedimiento_Requisito> TRAProcedimiento_Requisito
	{
		get
		{
			return _TRAProcedimiento_Requisito;
		}
		set
		{
			_TRAProcedimiento_Requisito.Assign(value);
		}
	}

	[Association(Name = "TRAProcedimiento_TRAEtapa_Procedimiento", Storage = "_TRAEtapa_Procedimiento", ThisKey = "IdProcedimiento", OtherKey = "IdProcedimiento")]
	public EntitySet<TRAEtapa_Procedimiento> TRAEtapa_Procedimiento
	{
		get
		{
			return _TRAEtapa_Procedimiento;
		}
		set
		{
			_TRAEtapa_Procedimiento.Assign(value);
		}
	}

	[Association(Name = "TRATipoSilencio_TRAProcedimiento", Storage = "_TRATipoSilencio", ThisKey = "IdTipoSilencio", OtherKey = "IdTipoSilencio", IsForeignKey = true)]
	public TRATipoSilencio TRATipoSilencio
	{
		get
		{
			return _TRATipoSilencio.Entity;
		}
		set
		{
			TRATipoSilencio previousValue = _TRATipoSilencio.Entity;
			if (!object.Equals(previousValue, value) || !_TRATipoSilencio.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TRATipoSilencio.Entity = null;
					previousValue.TRAProcedimiento.Remove(this);
				}
				_TRATipoSilencio.Entity = value;
				if (value != null)
				{
					value.TRAProcedimiento.Add(this);
					_IdTipoSilencio = value.IdTipoSilencio;
				}
				else
				{
					_IdTipoSilencio = null;
				}
				SendPropertyChanged("TRATipoSilencio");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRAProcedimiento()
	{
		_TRAProcedimiento_Requisito = new EntitySet<TRAProcedimiento_Requisito>(attach_TRAProcedimiento_Requisito, detach_TRAProcedimiento_Requisito);
		_TRAEtapa_Procedimiento = new EntitySet<TRAEtapa_Procedimiento>(attach_TRAEtapa_Procedimiento, detach_TRAEtapa_Procedimiento);
		_TRATipoSilencio = default(EntityRef<TRATipoSilencio>);
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

	private void attach_TRAProcedimiento_Requisito(TRAProcedimiento_Requisito entity)
	{
		SendPropertyChanging();
		entity.TRAProcedimiento = this;
	}

	private void detach_TRAProcedimiento_Requisito(TRAProcedimiento_Requisito entity)
	{
		SendPropertyChanging();
		entity.TRAProcedimiento = null;
	}

	private void attach_TRAEtapa_Procedimiento(TRAEtapa_Procedimiento entity)
	{
		SendPropertyChanging();
		entity.TRAProcedimiento = this;
	}

	private void detach_TRAEtapa_Procedimiento(TRAEtapa_Procedimiento entity)
	{
		SendPropertyChanging();
		entity.TRAProcedimiento = null;
	}
}
