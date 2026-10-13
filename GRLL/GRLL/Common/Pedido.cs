using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Pedido")]
public class Pedido : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdPedido;

	private int? _IdAreaOrganiz;

	private DateTime? _Fecha;

	private string _Responsable;

	private string _Estado;

	private DateTime? _FechaAprobacion;

	private DateTime? _FechaAutorizacion;

	private DateTime? _FechaDespacho;

	private char? _Tipo;

	private string _Anio;

	private string _IdTipoDoc;

	private decimal? _MontoPedido;

	private decimal? _MontoAprobado;

	private int? _IdAreaUbicacion;

	private int? _IdAreaAutorizacion;

	private string _IdFinanciamiento;

	private string _IdTipoRecurso;

	private string _Observaciones;

	private string _ObservacionesAprob;

	private string _ObservacionesAuto;

	private string _Especificaciones;

	private EntitySet<Aprobacion_Pedido> _Aprobacion_Pedido;

	private EntitySet<Pedido_Despacho> _Pedido_Despacho;

	private EntitySet<Deta_Pedido> _Deta_Pedido;

	private EntityRef<Financiamiento> _Financiamiento;

	private EntityRef<TipoRecurso> _TipoRecurso;

	[Column(Storage = "_IdPedido", DbType = "Char(6) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdPedido
	{
		get
		{
			return _IdPedido;
		}
		set
		{
			if (!string.Equals(_IdPedido, value))
			{
				SendPropertyChanging();
				_IdPedido = value;
				SendPropertyChanged("IdPedido");
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

	[Column(Storage = "_Fecha", DbType = "DateTime")]
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

	[Column(Storage = "_Responsable", DbType = "Char(8)")]
	public string Responsable
	{
		get
		{
			return _Responsable;
		}
		set
		{
			if (!string.Equals(_Responsable, value))
			{
				SendPropertyChanging();
				_Responsable = value;
				SendPropertyChanged("Responsable");
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

	[Column(Storage = "_FechaAutorizacion", DbType = "DateTime")]
	public DateTime? FechaAutorizacion
	{
		get
		{
			return _FechaAutorizacion;
		}
		set
		{
			if (!_FechaAutorizacion.Equals(value))
			{
				SendPropertyChanging();
				_FechaAutorizacion = value;
				SendPropertyChanged("FechaAutorizacion");
			}
		}
	}

	[Column(Storage = "_FechaDespacho", DbType = "DateTime")]
	public DateTime? FechaDespacho
	{
		get
		{
			return _FechaDespacho;
		}
		set
		{
			if (!_FechaDespacho.Equals(value))
			{
				SendPropertyChanging();
				_FechaDespacho = value;
				SendPropertyChanged("FechaDespacho");
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
				SendPropertyChanging();
				_IdTipoDoc = value;
				SendPropertyChanged("IdTipoDoc");
			}
		}
	}

	[Column(Storage = "_MontoPedido", DbType = "Decimal(18,2)")]
	public decimal? MontoPedido
	{
		get
		{
			return _MontoPedido;
		}
		set
		{
			if (!_MontoPedido.Equals(value))
			{
				SendPropertyChanging();
				_MontoPedido = value;
				SendPropertyChanged("MontoPedido");
			}
		}
	}

	[Column(Storage = "_MontoAprobado", DbType = "Decimal(18,2)")]
	public decimal? MontoAprobado
	{
		get
		{
			return _MontoAprobado;
		}
		set
		{
			if (!_MontoAprobado.Equals(value))
			{
				SendPropertyChanging();
				_MontoAprobado = value;
				SendPropertyChanged("MontoAprobado");
			}
		}
	}

	[Column(Storage = "_IdAreaUbicacion", DbType = "Int")]
	public int? IdAreaUbicacion
	{
		get
		{
			return _IdAreaUbicacion;
		}
		set
		{
			if (!_IdAreaUbicacion.Equals(value))
			{
				SendPropertyChanging();
				_IdAreaUbicacion = value;
				SendPropertyChanged("IdAreaUbicacion");
			}
		}
	}

	[Column(Storage = "_IdAreaAutorizacion", DbType = "Int")]
	public int? IdAreaAutorizacion
	{
		get
		{
			return _IdAreaAutorizacion;
		}
		set
		{
			if (!_IdAreaAutorizacion.Equals(value))
			{
				SendPropertyChanging();
				_IdAreaAutorizacion = value;
				SendPropertyChanged("IdAreaAutorizacion");
			}
		}
	}

	[Column(Storage = "_IdFinanciamiento", DbType = "Char(2)")]
	public string IdFinanciamiento
	{
		get
		{
			return _IdFinanciamiento;
		}
		set
		{
			if (!string.Equals(_IdFinanciamiento, value))
			{
				if (_Financiamiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdFinanciamiento = value;
				SendPropertyChanged("IdFinanciamiento");
			}
		}
	}

	[Column(Storage = "_IdTipoRecurso", DbType = "Char(3)")]
	public string IdTipoRecurso
	{
		get
		{
			return _IdTipoRecurso;
		}
		set
		{
			if (!string.Equals(_IdTipoRecurso, value))
			{
				if (_TipoRecurso.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdTipoRecurso = value;
				SendPropertyChanged("IdTipoRecurso");
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(120)")]
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

	[Column(Storage = "_ObservacionesAprob", DbType = "VarChar(120)")]
	public string ObservacionesAprob
	{
		get
		{
			return _ObservacionesAprob;
		}
		set
		{
			if (!string.Equals(_ObservacionesAprob, value))
			{
				SendPropertyChanging();
				_ObservacionesAprob = value;
				SendPropertyChanged("ObservacionesAprob");
			}
		}
	}

	[Column(Storage = "_ObservacionesAuto", DbType = "VarChar(120)")]
	public string ObservacionesAuto
	{
		get
		{
			return _ObservacionesAuto;
		}
		set
		{
			if (!string.Equals(_ObservacionesAuto, value))
			{
				SendPropertyChanging();
				_ObservacionesAuto = value;
				SendPropertyChanged("ObservacionesAuto");
			}
		}
	}

	[Column(Storage = "_Especificaciones", DbType = "VarChar(80)")]
	public string Especificaciones
	{
		get
		{
			return _Especificaciones;
		}
		set
		{
			if (!string.Equals(_Especificaciones, value))
			{
				SendPropertyChanging();
				_Especificaciones = value;
				SendPropertyChanged("Especificaciones");
			}
		}
	}

	[Association(Name = "Pedido_Aprobacion_Pedido", Storage = "_Aprobacion_Pedido", ThisKey = "IdPedido", OtherKey = "IdPedido")]
	public EntitySet<Aprobacion_Pedido> Aprobacion_Pedido
	{
		get
		{
			return _Aprobacion_Pedido;
		}
		set
		{
			_Aprobacion_Pedido.Assign(value);
		}
	}

	[Association(Name = "Pedido_Pedido_Despacho", Storage = "_Pedido_Despacho", ThisKey = "IdPedido", OtherKey = "IdPedido")]
	public EntitySet<Pedido_Despacho> Pedido_Despacho
	{
		get
		{
			return _Pedido_Despacho;
		}
		set
		{
			_Pedido_Despacho.Assign(value);
		}
	}

	[Association(Name = "Pedido_Deta_Pedido", Storage = "_Deta_Pedido", ThisKey = "IdPedido", OtherKey = "IdPedido")]
	public EntitySet<Deta_Pedido> Deta_Pedido
	{
		get
		{
			return _Deta_Pedido;
		}
		set
		{
			_Deta_Pedido.Assign(value);
		}
	}

	[Association(Name = "Financiamiento_Pedido", Storage = "_Financiamiento", ThisKey = "IdFinanciamiento", OtherKey = "IdFinanciamiento", IsForeignKey = true)]
	public Financiamiento Financiamiento
	{
		get
		{
			return _Financiamiento.Entity;
		}
		set
		{
			Financiamiento previousValue = _Financiamiento.Entity;
			if (!object.Equals(previousValue, value) || !_Financiamiento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Financiamiento.Entity = null;
					previousValue.Pedido.Remove(this);
				}
				_Financiamiento.Entity = value;
				if (value != null)
				{
					value.Pedido.Add(this);
					_IdFinanciamiento = value.IdFinanciamiento;
				}
				else
				{
					_IdFinanciamiento = null;
				}
				SendPropertyChanged("Financiamiento");
			}
		}
	}

	[Association(Name = "TipoRecurso_Pedido", Storage = "_TipoRecurso", ThisKey = "IdTipoRecurso", OtherKey = "IdTipoRecurso", IsForeignKey = true)]
	public TipoRecurso TipoRecurso
	{
		get
		{
			return _TipoRecurso.Entity;
		}
		set
		{
			TipoRecurso previousValue = _TipoRecurso.Entity;
			if (!object.Equals(previousValue, value) || !_TipoRecurso.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TipoRecurso.Entity = null;
					previousValue.Pedido.Remove(this);
				}
				_TipoRecurso.Entity = value;
				if (value != null)
				{
					value.Pedido.Add(this);
					_IdTipoRecurso = value.IdTipoRecurso;
				}
				else
				{
					_IdTipoRecurso = null;
				}
				SendPropertyChanged("TipoRecurso");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Pedido()
	{
		_Aprobacion_Pedido = new EntitySet<Aprobacion_Pedido>(attach_Aprobacion_Pedido, detach_Aprobacion_Pedido);
		_Pedido_Despacho = new EntitySet<Pedido_Despacho>(attach_Pedido_Despacho, detach_Pedido_Despacho);
		_Deta_Pedido = new EntitySet<Deta_Pedido>(attach_Deta_Pedido, detach_Deta_Pedido);
		_Financiamiento = default(EntityRef<Financiamiento>);
		_TipoRecurso = default(EntityRef<TipoRecurso>);
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

	private void attach_Aprobacion_Pedido(Aprobacion_Pedido entity)
	{
		SendPropertyChanging();
		entity.Pedido = this;
	}

	private void detach_Aprobacion_Pedido(Aprobacion_Pedido entity)
	{
		SendPropertyChanging();
		entity.Pedido = null;
	}

	private void attach_Pedido_Despacho(Pedido_Despacho entity)
	{
		SendPropertyChanging();
		entity.Pedido = this;
	}

	private void detach_Pedido_Despacho(Pedido_Despacho entity)
	{
		SendPropertyChanging();
		entity.Pedido = null;
	}

	private void attach_Deta_Pedido(Deta_Pedido entity)
	{
		SendPropertyChanging();
		entity.Pedido = this;
	}

	private void detach_Deta_Pedido(Deta_Pedido entity)
	{
		SendPropertyChanging();
		entity.Pedido = null;
	}
}
