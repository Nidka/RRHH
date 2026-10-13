using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRADocumento")]
public class TRADocumento : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdDocumento;

	private string _Anio;

	private string _Codigo;

	private string _IdTipoDoc;

	private DateTime? _FechaEmision;

	private string _HoraEmision;

	private string _Asunto;

	private string _Referencia;

	private int? _Folio;

	private int _IdAreaOrganiz;

	private string _SuscritoPor;

	private EntitySet<TRAAdjunto> _TRAAdjunto;

	private EntitySet<TRATramite> _TRATramite;

	[Column(Storage = "_IdDocumento", DbType = "Char(13) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_IdDocumento = value;
				SendPropertyChanged("IdDocumento");
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

	[Column(Storage = "_Codigo", DbType = "VarChar(60)")]
	public string Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			if (!string.Equals(_Codigo, value))
			{
				SendPropertyChanging();
				_Codigo = value;
				SendPropertyChanged("Codigo");
			}
		}
	}

	[Column(Storage = "_IdTipoDoc", DbType = "Char(2) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				SendPropertyChanging();
				_IdTipoDoc = value;
				SendPropertyChanged("IdTipoDoc");
			}
		}
	}

	[Column(Storage = "_FechaEmision", DbType = "DateTime")]
	public DateTime? FechaEmision
	{
		get
		{
			return _FechaEmision;
		}
		set
		{
			if (!_FechaEmision.Equals(value))
			{
				SendPropertyChanging();
				_FechaEmision = value;
				SendPropertyChanged("FechaEmision");
			}
		}
	}

	[Column(Storage = "_HoraEmision", DbType = "Char(10)")]
	public string HoraEmision
	{
		get
		{
			return _HoraEmision;
		}
		set
		{
			if (!string.Equals(_HoraEmision, value))
			{
				SendPropertyChanging();
				_HoraEmision = value;
				SendPropertyChanged("HoraEmision");
			}
		}
	}

	[Column(Storage = "_Asunto", DbType = "VarChar(250)")]
	public string Asunto
	{
		get
		{
			return _Asunto;
		}
		set
		{
			if (!string.Equals(_Asunto, value))
			{
				SendPropertyChanging();
				_Asunto = value;
				SendPropertyChanged("Asunto");
			}
		}
	}

	[Column(Storage = "_Referencia", DbType = "VarChar(250)")]
	public string Referencia
	{
		get
		{
			return _Referencia;
		}
		set
		{
			if (!string.Equals(_Referencia, value))
			{
				SendPropertyChanging();
				_Referencia = value;
				SendPropertyChanged("Referencia");
			}
		}
	}

	[Column(Storage = "_Folio", DbType = "Int")]
	public int? Folio
	{
		get
		{
			return _Folio;
		}
		set
		{
			if (!_Folio.Equals(value))
			{
				SendPropertyChanging();
				_Folio = value;
				SendPropertyChanged("Folio");
			}
		}
	}

	[Column(Storage = "_IdAreaOrganiz", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdAreaOrganiz
	{
		get
		{
			return _IdAreaOrganiz;
		}
		set
		{
			if (_IdAreaOrganiz != value)
			{
				SendPropertyChanging();
				_IdAreaOrganiz = value;
				SendPropertyChanged("IdAreaOrganiz");
			}
		}
	}

	[Column(Storage = "_SuscritoPor", DbType = "VarChar(200)")]
	public string SuscritoPor
	{
		get
		{
			return _SuscritoPor;
		}
		set
		{
			if (!string.Equals(_SuscritoPor, value))
			{
				SendPropertyChanging();
				_SuscritoPor = value;
				SendPropertyChanged("SuscritoPor");
			}
		}
	}

	[Association(Name = "TRADocumento_TRAAdjunto", Storage = "_TRAAdjunto", ThisKey = "IdDocumento,IdTipoDoc,IdAreaOrganiz", OtherKey = "Referencia,ReferenciaTipo,ReferenciaArea")]
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

	[Association(Name = "TRADocumento_TRATramite", Storage = "_TRATramite", ThisKey = "IdDocumento,IdTipoDoc,IdAreaOrganiz", OtherKey = "IdDocumento,IdTipoDoc,IdAreaOrganiz")]
	public EntitySet<TRATramite> TRATramite
	{
		get
		{
			return _TRATramite;
		}
		set
		{
			_TRATramite.Assign(value);
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRADocumento()
	{
		_TRAAdjunto = new EntitySet<TRAAdjunto>(attach_TRAAdjunto, detach_TRAAdjunto);
		_TRATramite = new EntitySet<TRATramite>(attach_TRATramite, detach_TRATramite);
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
		entity.TRADocumento = this;
	}

	private void detach_TRAAdjunto(TRAAdjunto entity)
	{
		SendPropertyChanging();
		entity.TRADocumento = null;
	}

	private void attach_TRATramite(TRATramite entity)
	{
		SendPropertyChanging();
		entity.TRADocumento = this;
	}

	private void detach_TRATramite(TRATramite entity)
	{
		SendPropertyChanging();
		entity.TRADocumento = null;
	}
}
