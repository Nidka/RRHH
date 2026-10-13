using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRSolicitudOpinion")]
public class CJRSolicitudOpinion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _NumOficio;

	private string _NumOficioIniciativa;

	private int? _NumTema;

	private string _Destino;

	private bool? _esTecnico;

	private EntitySet<CJRResSolicitudOpinion> _CJRResSolicitudOpinion;

	private EntityRef<CJROficio> _CJROficio;

	private EntityRef<CJROficio> _CJROficio1;

	private EntityRef<CJRTemaIniciativa> _CJRTemaIniciativa;

	private EntityRef<CJRTemaIniciativa> _CJRTemaIniciativa1;

	[Column(Storage = "_NumOficio", DbType = "VarChar(120) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string NumOficio
	{
		get
		{
			return _NumOficio;
		}
		set
		{
			if (!string.Equals(_NumOficio, value))
			{
				if (_CJROficio.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NumOficio = value;
				SendPropertyChanged("NumOficio");
			}
		}
	}

	[Column(Storage = "_NumOficioIniciativa", DbType = "VarChar(120)")]
	public string NumOficioIniciativa
	{
		get
		{
			return _NumOficioIniciativa;
		}
		set
		{
			if (!string.Equals(_NumOficioIniciativa, value))
			{
				if (_CJRTemaIniciativa.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NumOficioIniciativa = value;
				SendPropertyChanged("NumOficioIniciativa");
			}
		}
	}

	[Column(Storage = "_NumTema", DbType = "Int")]
	public int? NumTema
	{
		get
		{
			return _NumTema;
		}
		set
		{
			if (!_NumTema.Equals(value))
			{
				if (_CJRTemaIniciativa.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NumTema = value;
				SendPropertyChanged("NumTema");
			}
		}
	}

	[Column(Storage = "_Destino", DbType = "VarChar(200)")]
	public string Destino
	{
		get
		{
			return _Destino;
		}
		set
		{
			if (!string.Equals(_Destino, value))
			{
				SendPropertyChanging();
				_Destino = value;
				SendPropertyChanged("Destino");
			}
		}
	}

	[Column(Storage = "_esTecnico", DbType = "Bit")]
	public bool? esTecnico
	{
		get
		{
			return _esTecnico;
		}
		set
		{
			if (!_esTecnico.Equals(value))
			{
				SendPropertyChanging();
				_esTecnico = value;
				SendPropertyChanged("esTecnico");
			}
		}
	}

	[Association(Name = "CJRSolicitudOpinion_CJRResSolicitudOpinion", Storage = "_CJRResSolicitudOpinion", ThisKey = "NumOficio", OtherKey = "NumOficioSolicitud")]
	public EntitySet<CJRResSolicitudOpinion> CJRResSolicitudOpinion
	{
		get
		{
			return _CJRResSolicitudOpinion;
		}
		set
		{
			_CJRResSolicitudOpinion.Assign(value);
		}
	}

	[Association(Name = "CJROficio_CJRSolicitudOpinion", Storage = "_CJROficio", ThisKey = "NumOficio", OtherKey = "NumOficio", IsForeignKey = true)]
	public CJROficio CJROficio
	{
		get
		{
			return _CJROficio.Entity;
		}
		set
		{
			CJROficio previousValue = _CJROficio.Entity;
			if (!object.Equals(previousValue, value) || !_CJROficio.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJROficio.Entity = null;
					previousValue.CJRSolicitudOpinion = null;
				}
				_CJROficio.Entity = value;
				if (value != null)
				{
					value.CJRSolicitudOpinion = this;
					_NumOficio = value.NumOficio;
				}
				else
				{
					_NumOficio = null;
				}
				SendPropertyChanged("CJROficio");
			}
		}
	}

	[Association(Name = "CJROficio_CJRSolicitudOpinion1", Storage = "_CJROficio1", ThisKey = "NumOficio", OtherKey = "NumOficio", IsForeignKey = true)]
	public CJROficio CJROficio1
	{
		get
		{
			return _CJROficio1.Entity;
		}
		set
		{
			CJROficio previousValue = _CJROficio1.Entity;
			if (!object.Equals(previousValue, value) || !_CJROficio1.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJROficio1.Entity = null;
					previousValue.CJRSolicitudOpinion1 = null;
				}
				_CJROficio1.Entity = value;
				if (value != null)
				{
					value.CJRSolicitudOpinion1 = this;
					_NumOficio = value.NumOficio;
				}
				else
				{
					_NumOficio = null;
				}
				SendPropertyChanged("CJROficio1");
			}
		}
	}

	[Association(Name = "CJRTemaIniciativa_CJRSolicitudOpinion", Storage = "_CJRTemaIniciativa", ThisKey = "NumOficioIniciativa,NumTema", OtherKey = "NumOficioIniciativa,NumTema", IsForeignKey = true)]
	public CJRTemaIniciativa CJRTemaIniciativa
	{
		get
		{
			return _CJRTemaIniciativa.Entity;
		}
		set
		{
			CJRTemaIniciativa previousValue = _CJRTemaIniciativa.Entity;
			if (!object.Equals(previousValue, value) || !_CJRTemaIniciativa.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRTemaIniciativa.Entity = null;
					previousValue.CJRSolicitudOpinion.Remove(this);
				}
				_CJRTemaIniciativa.Entity = value;
				if (value != null)
				{
					value.CJRSolicitudOpinion.Add(this);
					_NumOficioIniciativa = value.NumOficioIniciativa;
					_NumTema = value.NumTema;
				}
				else
				{
					_NumOficioIniciativa = null;
					_NumTema = null;
				}
				SendPropertyChanged("CJRTemaIniciativa");
			}
		}
	}

	[Association(Name = "CJRTemaIniciativa_CJRSolicitudOpinion1", Storage = "_CJRTemaIniciativa1", ThisKey = "NumOficioIniciativa,NumTema", OtherKey = "NumOficioIniciativa,NumTema", IsForeignKey = true)]
	public CJRTemaIniciativa CJRTemaIniciativa1
	{
		get
		{
			return _CJRTemaIniciativa1.Entity;
		}
		set
		{
			CJRTemaIniciativa previousValue = _CJRTemaIniciativa1.Entity;
			if (!object.Equals(previousValue, value) || !_CJRTemaIniciativa1.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRTemaIniciativa1.Entity = null;
					previousValue.CJRSolicitudOpinion1.Remove(this);
				}
				_CJRTemaIniciativa1.Entity = value;
				if (value != null)
				{
					value.CJRSolicitudOpinion1.Add(this);
					_NumOficioIniciativa = value.NumOficioIniciativa;
					_NumTema = value.NumTema;
				}
				else
				{
					_NumOficioIniciativa = null;
					_NumTema = null;
				}
				SendPropertyChanged("CJRTemaIniciativa1");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRSolicitudOpinion()
	{
		_CJRResSolicitudOpinion = new EntitySet<CJRResSolicitudOpinion>(attach_CJRResSolicitudOpinion, detach_CJRResSolicitudOpinion);
		_CJROficio = default(EntityRef<CJROficio>);
		_CJROficio1 = default(EntityRef<CJROficio>);
		_CJRTemaIniciativa = default(EntityRef<CJRTemaIniciativa>);
		_CJRTemaIniciativa1 = default(EntityRef<CJRTemaIniciativa>);
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

	private void attach_CJRResSolicitudOpinion(CJRResSolicitudOpinion entity)
	{
		SendPropertyChanging();
		entity.CJRSolicitudOpinion = this;
	}

	private void detach_CJRResSolicitudOpinion(CJRResSolicitudOpinion entity)
	{
		SendPropertyChanging();
		entity.CJRSolicitudOpinion = null;
	}
}
