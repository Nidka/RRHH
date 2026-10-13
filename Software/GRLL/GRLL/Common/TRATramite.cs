using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRATramite")]
public class TRATramite : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdTramite;

	private string _Anio;

	private string _IdProcedimiento;

	private string _Estado;

	private string _IdDocumento;

	private string _IdTipoDoc;

	private int? _IdAreaOrganiz;

	private int? _TiempoDias;

	private int? _TiempoHrs;

	private int? _TiempoMin;

	private string _MotivoRechazo;

	private int? _PersonaRechazo;

	private DateTime? _FechaRechazo;

	private int? _AreaRechazo;

	private DateTime? _FechaAprobacion;

	private DateTime? _FechaTramite;

	private EntitySet<TRAAdjunto> _TRAAdjunto;

	private EntitySet<TRATramite_Requisito> _TRATramite_Requisito;

	private EntityRef<TRATipoDoc> _TRATipoDoc;

	private EntityRef<TRADocumento> _TRADocumento;

	[Column(Storage = "_IdTramite", DbType = "Char(10) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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

	[Column(Storage = "_Anio", DbType = "Char(4)")]
	public string Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!string.Equals(_Anio, value))
			{
				SendPropertyChanging();
				_Anio = value;
				SendPropertyChanged("Anio");
			}
		}
	}

	[Column(Storage = "_IdProcedimiento", DbType = "Char(6)")]
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

	[Column(Storage = "_IdDocumento", DbType = "Char(13)")]
	public string IdDocumento
	{
		get
		{
			return _IdDocumento;
		}
		set
		{
			if (!string.Equals(_IdDocumento, value))
			{
				if (_TRADocumento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdDocumento = value;
				SendPropertyChanged("IdDocumento");
			}
		}
	}

	[Column(Storage = "_IdTipoDoc", DbType = "Char(2)")]
	public string IdTipoDoc
	{
		get
		{
			return _IdTipoDoc;
		}
		set
		{
			if (!string.Equals(_IdTipoDoc, value))
			{
				if (_TRATipoDoc.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoDoc = value;
				SendPropertyChanged("IdTipoDoc");
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
				if (_TRADocumento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdAreaOrganiz = value;
				SendPropertyChanged("IdAreaOrganiz");
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

	[Column(Storage = "_MotivoRechazo", DbType = "VarChar(200)")]
	public string MotivoRechazo
	{
		get
		{
			return _MotivoRechazo;
		}
		set
		{
			if (!string.Equals(_MotivoRechazo, value))
			{
				SendPropertyChanging();
				_MotivoRechazo = value;
				SendPropertyChanged("MotivoRechazo");
			}
		}
	}

	[Column(Storage = "_PersonaRechazo", DbType = "Int")]
	public int? PersonaRechazo
	{
		get
		{
			return _PersonaRechazo;
		}
		set
		{
			if (!_PersonaRechazo.Equals(value))
			{
				SendPropertyChanging();
				_PersonaRechazo = value;
				SendPropertyChanged("PersonaRechazo");
			}
		}
	}

	[Column(Storage = "_FechaRechazo", DbType = "DateTime")]
	public DateTime? FechaRechazo
	{
		get
		{
			return _FechaRechazo;
		}
		set
		{
			if (!_FechaRechazo.Equals(value))
			{
				SendPropertyChanging();
				_FechaRechazo = value;
				SendPropertyChanged("FechaRechazo");
			}
		}
	}

	[Column(Storage = "_AreaRechazo", DbType = "Int")]
	public int? AreaRechazo
	{
		get
		{
			return _AreaRechazo;
		}
		set
		{
			if (!_AreaRechazo.Equals(value))
			{
				SendPropertyChanging();
				_AreaRechazo = value;
				SendPropertyChanged("AreaRechazo");
			}
		}
	}

	[Column(Storage = "_FechaAprobacion", DbType = "DateTime")]
	public DateTime? FechaAprobacion
	{
		get
		{
			return _FechaAprobacion;
		}
		set
		{
			if (!_FechaAprobacion.Equals(value))
			{
				SendPropertyChanging();
				_FechaAprobacion = value;
				SendPropertyChanged("FechaAprobacion");
			}
		}
	}

	[Column(Storage = "_FechaTramite", DbType = "DateTime")]
	public DateTime? FechaTramite
	{
		get
		{
			return _FechaTramite;
		}
		set
		{
			if (!_FechaTramite.Equals(value))
			{
				SendPropertyChanging();
				_FechaTramite = value;
				SendPropertyChanged("FechaTramite");
			}
		}
	}

	[Association(Name = "TRATramite_TRAAdjunto", Storage = "_TRAAdjunto", ThisKey = "IdTramite", OtherKey = "IdTramite")]
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

	[Association(Name = "TRATramite_TRATramite_Requisito", Storage = "_TRATramite_Requisito", ThisKey = "IdTramite", OtherKey = "IdTramite")]
	public EntitySet<TRATramite_Requisito> TRATramite_Requisito
	{
		get
		{
			return _TRATramite_Requisito;
		}
		set
		{
			_TRATramite_Requisito.Assign(value);
		}
	}

	[Association(Name = "TRATipoDoc_TRATramite", Storage = "_TRATipoDoc", ThisKey = "IdTipoDoc", OtherKey = "IdTipoDoc", IsForeignKey = true)]
	public TRATipoDoc TRATipoDoc
	{
		get
		{
			return _TRATipoDoc.Entity;
		}
		set
		{
			TRATipoDoc previousValue = _TRATipoDoc.Entity;
			if (!object.Equals(previousValue, value) || !_TRATipoDoc.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TRATipoDoc.Entity = null;
					previousValue.TRATramite.Remove(this);
				}
				_TRATipoDoc.Entity = value;
				if (value != null)
				{
					value.TRATramite.Add(this);
					_IdTipoDoc = value.IdTipoDoc;
				}
				else
				{
					_IdTipoDoc = null;
				}
				SendPropertyChanged("TRATipoDoc");
			}
		}
	}

	[Association(Name = "TRADocumento_TRATramite", Storage = "_TRADocumento", ThisKey = "IdDocumento,IdTipoDoc,IdAreaOrganiz", OtherKey = "IdDocumento,IdTipoDoc,IdAreaOrganiz", IsForeignKey = true)]
	public TRADocumento TRADocumento
	{
		get
		{
			return _TRADocumento.Entity;
		}
		set
		{
			TRADocumento previousValue = _TRADocumento.Entity;
			if (!object.Equals(previousValue, value) || !_TRADocumento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TRADocumento.Entity = null;
					previousValue.TRATramite.Remove(this);
				}
				_TRADocumento.Entity = value;
				if (value != null)
				{
					value.TRATramite.Add(this);
					_IdDocumento = value.IdDocumento;
					_IdTipoDoc = value.IdTipoDoc;
					_IdAreaOrganiz = value.IdAreaOrganiz;
				}
				else
				{
					_IdDocumento = null;
					_IdTipoDoc = null;
					_IdAreaOrganiz = null;
				}
				SendPropertyChanged("TRADocumento");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRATramite()
	{
		_TRAAdjunto = new EntitySet<TRAAdjunto>(attach_TRAAdjunto, detach_TRAAdjunto);
		_TRATramite_Requisito = new EntitySet<TRATramite_Requisito>(attach_TRATramite_Requisito, detach_TRATramite_Requisito);
		_TRATipoDoc = default(EntityRef<TRATipoDoc>);
		_TRADocumento = default(EntityRef<TRADocumento>);
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
		entity.TRATramite = this;
	}

	private void detach_TRAAdjunto(TRAAdjunto entity)
	{
		SendPropertyChanging();
		entity.TRATramite = null;
	}

	private void attach_TRATramite_Requisito(TRATramite_Requisito entity)
	{
		SendPropertyChanging();
		entity.TRATramite = this;
	}

	private void detach_TRATramite_Requisito(TRATramite_Requisito entity)
	{
		SendPropertyChanging();
		entity.TRATramite = null;
	}
}
