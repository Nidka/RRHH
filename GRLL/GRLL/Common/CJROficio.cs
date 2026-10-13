using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJROficio")]
public class CJROficio : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _NumOficio;

	private DateTime? _FechaEmision;

	private EntityRef<CJRDevolucionNorma> _CJRDevolucionNorma;

	private EntityRef<CJRIniciativa> _CJRIniciativa;

	private EntityRef<CJRNotificacionNorma> _CJRNotificacionNorma;

	private EntityRef<CJRPromulgacionNorma> _CJRPromulgacionNorma;

	private EntityRef<CJRPublicacionNorma> _CJRPublicacionNorma;

	private EntityRef<CJRResSolicitudOpinion> _CJRResSolicitudOpinion;

	private EntityRef<CJRSolicitudOpinion> _CJRSolicitudOpinion;

	private EntityRef<CJRSolicitudOpinion> _CJRSolicitudOpinion1;

	private EntityRef<CJRTrasladoComision> _CJRTrasladoComision;

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
				SendPropertyChanging();
				_NumOficio = value;
				SendPropertyChanged("NumOficio");
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

	[Association(Name = "CJROficio_CJRDevolucionNorma", Storage = "_CJRDevolucionNorma", ThisKey = "NumOficio", OtherKey = "NumOficio", IsUnique = true, IsForeignKey = false)]
	public CJRDevolucionNorma CJRDevolucionNorma
	{
		get
		{
			return _CJRDevolucionNorma.Entity;
		}
		set
		{
			CJRDevolucionNorma previousValue = _CJRDevolucionNorma.Entity;
			if (!object.Equals(previousValue, value) || !_CJRDevolucionNorma.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRDevolucionNorma.Entity = null;
					previousValue.CJROficio = null;
				}
				_CJRDevolucionNorma.Entity = value;
				if (!object.Equals(value, null))
				{
					value.CJROficio = this;
				}
				SendPropertyChanged("CJRDevolucionNorma");
			}
		}
	}

	[Association(Name = "CJROficio_CJRIniciativa", Storage = "_CJRIniciativa", ThisKey = "NumOficio", OtherKey = "NumOficioIniciativa", IsUnique = true, IsForeignKey = false)]
	public CJRIniciativa CJRIniciativa
	{
		get
		{
			return _CJRIniciativa.Entity;
		}
		set
		{
			CJRIniciativa previousValue = _CJRIniciativa.Entity;
			if (!object.Equals(previousValue, value) || !_CJRIniciativa.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRIniciativa.Entity = null;
					previousValue.CJROficio = null;
				}
				_CJRIniciativa.Entity = value;
				if (!object.Equals(value, null))
				{
					value.CJROficio = this;
				}
				SendPropertyChanged("CJRIniciativa");
			}
		}
	}

	[Association(Name = "CJROficio_CJRNotificacionNorma", Storage = "_CJRNotificacionNorma", ThisKey = "NumOficio", OtherKey = "NumOficio", IsUnique = true, IsForeignKey = false)]
	public CJRNotificacionNorma CJRNotificacionNorma
	{
		get
		{
			return _CJRNotificacionNorma.Entity;
		}
		set
		{
			CJRNotificacionNorma previousValue = _CJRNotificacionNorma.Entity;
			if (!object.Equals(previousValue, value) || !_CJRNotificacionNorma.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRNotificacionNorma.Entity = null;
					previousValue.CJROficio = null;
				}
				_CJRNotificacionNorma.Entity = value;
				if (!object.Equals(value, null))
				{
					value.CJROficio = this;
				}
				SendPropertyChanged("CJRNotificacionNorma");
			}
		}
	}

	[Association(Name = "CJROficio_CJRPromulgacionNorma", Storage = "_CJRPromulgacionNorma", ThisKey = "NumOficio", OtherKey = "NumOficio", IsUnique = true, IsForeignKey = false)]
	public CJRPromulgacionNorma CJRPromulgacionNorma
	{
		get
		{
			return _CJRPromulgacionNorma.Entity;
		}
		set
		{
			CJRPromulgacionNorma previousValue = _CJRPromulgacionNorma.Entity;
			if (!object.Equals(previousValue, value) || !_CJRPromulgacionNorma.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRPromulgacionNorma.Entity = null;
					previousValue.CJROficio = null;
				}
				_CJRPromulgacionNorma.Entity = value;
				if (!object.Equals(value, null))
				{
					value.CJROficio = this;
				}
				SendPropertyChanged("CJRPromulgacionNorma");
			}
		}
	}

	[Association(Name = "CJROficio_CJRPublicacionNorma", Storage = "_CJRPublicacionNorma", ThisKey = "NumOficio", OtherKey = "NumOficio", IsUnique = true, IsForeignKey = false)]
	public CJRPublicacionNorma CJRPublicacionNorma
	{
		get
		{
			return _CJRPublicacionNorma.Entity;
		}
		set
		{
			CJRPublicacionNorma previousValue = _CJRPublicacionNorma.Entity;
			if (!object.Equals(previousValue, value) || !_CJRPublicacionNorma.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRPublicacionNorma.Entity = null;
					previousValue.CJROficio = null;
				}
				_CJRPublicacionNorma.Entity = value;
				if (!object.Equals(value, null))
				{
					value.CJROficio = this;
				}
				SendPropertyChanged("CJRPublicacionNorma");
			}
		}
	}

	[Association(Name = "CJROficio_CJRResSolicitudOpinion", Storage = "_CJRResSolicitudOpinion", ThisKey = "NumOficio", OtherKey = "NumOficio", IsUnique = true, IsForeignKey = false)]
	public CJRResSolicitudOpinion CJRResSolicitudOpinion
	{
		get
		{
			return _CJRResSolicitudOpinion.Entity;
		}
		set
		{
			CJRResSolicitudOpinion previousValue = _CJRResSolicitudOpinion.Entity;
			if (!object.Equals(previousValue, value) || !_CJRResSolicitudOpinion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRResSolicitudOpinion.Entity = null;
					previousValue.CJROficio = null;
				}
				_CJRResSolicitudOpinion.Entity = value;
				if (!object.Equals(value, null))
				{
					value.CJROficio = this;
				}
				SendPropertyChanged("CJRResSolicitudOpinion");
			}
		}
	}

	[Association(Name = "CJROficio_CJRSolicitudOpinion", Storage = "_CJRSolicitudOpinion", ThisKey = "NumOficio", OtherKey = "NumOficio", IsUnique = true, IsForeignKey = false)]
	public CJRSolicitudOpinion CJRSolicitudOpinion
	{
		get
		{
			return _CJRSolicitudOpinion.Entity;
		}
		set
		{
			CJRSolicitudOpinion previousValue = _CJRSolicitudOpinion.Entity;
			if (!object.Equals(previousValue, value) || !_CJRSolicitudOpinion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRSolicitudOpinion.Entity = null;
					previousValue.CJROficio = null;
				}
				_CJRSolicitudOpinion.Entity = value;
				if (!object.Equals(value, null))
				{
					value.CJROficio = this;
				}
				SendPropertyChanged("CJRSolicitudOpinion");
			}
		}
	}

	[Association(Name = "CJROficio_CJRSolicitudOpinion1", Storage = "_CJRSolicitudOpinion1", ThisKey = "NumOficio", OtherKey = "NumOficio", IsUnique = true, IsForeignKey = false)]
	public CJRSolicitudOpinion CJRSolicitudOpinion1
	{
		get
		{
			return _CJRSolicitudOpinion1.Entity;
		}
		set
		{
			CJRSolicitudOpinion previousValue = _CJRSolicitudOpinion1.Entity;
			if (!object.Equals(previousValue, value) || !_CJRSolicitudOpinion1.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRSolicitudOpinion1.Entity = null;
					previousValue.CJROficio1 = null;
				}
				_CJRSolicitudOpinion1.Entity = value;
				if (!object.Equals(value, null))
				{
					value.CJROficio1 = this;
				}
				SendPropertyChanged("CJRSolicitudOpinion1");
			}
		}
	}

	[Association(Name = "CJROficio_CJRTrasladoComision", Storage = "_CJRTrasladoComision", ThisKey = "NumOficio", OtherKey = "NumOficio", IsUnique = true, IsForeignKey = false)]
	public CJRTrasladoComision CJRTrasladoComision
	{
		get
		{
			return _CJRTrasladoComision.Entity;
		}
		set
		{
			CJRTrasladoComision previousValue = _CJRTrasladoComision.Entity;
			if (!object.Equals(previousValue, value) || !_CJRTrasladoComision.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRTrasladoComision.Entity = null;
					previousValue.CJROficio = null;
				}
				_CJRTrasladoComision.Entity = value;
				if (!object.Equals(value, null))
				{
					value.CJROficio = this;
				}
				SendPropertyChanged("CJRTrasladoComision");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJROficio()
	{
		_CJRDevolucionNorma = default(EntityRef<CJRDevolucionNorma>);
		_CJRIniciativa = default(EntityRef<CJRIniciativa>);
		_CJRNotificacionNorma = default(EntityRef<CJRNotificacionNorma>);
		_CJRPromulgacionNorma = default(EntityRef<CJRPromulgacionNorma>);
		_CJRPublicacionNorma = default(EntityRef<CJRPublicacionNorma>);
		_CJRResSolicitudOpinion = default(EntityRef<CJRResSolicitudOpinion>);
		_CJRSolicitudOpinion = default(EntityRef<CJRSolicitudOpinion>);
		_CJRSolicitudOpinion1 = default(EntityRef<CJRSolicitudOpinion>);
		_CJRTrasladoComision = default(EntityRef<CJRTrasladoComision>);
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
}
