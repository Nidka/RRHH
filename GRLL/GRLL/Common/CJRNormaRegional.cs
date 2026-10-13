using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRNormaRegional")]
public class CJRNormaRegional : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _NumOrdenanza;

	private DateTime? _FechaOrdenanza;

	private int _idTipoNorma;

	private string _NumProyecto;

	private int? _idTipoProyec;

	private EntitySet<CJRNotificacionNorma> _CJRNotificacionNorma;

	private EntitySet<CJRPublicacion> _CJRPublicacion;

	private EntitySet<CJRPublicacionNorma> _CJRPublicacionNorma;

	private EntityRef<CJRProyectoNormativo> _CJRProyectoNormativo;

	private EntityRef<CJRTipoNorma> _CJRTipoNorma;

	[Column(Storage = "_NumOrdenanza", DbType = "VarChar(120) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string NumOrdenanza
	{
		get
		{
			return _NumOrdenanza;
		}
		set
		{
			if (!string.Equals(_NumOrdenanza, value))
			{
				SendPropertyChanging();
				_NumOrdenanza = value;
				SendPropertyChanged("NumOrdenanza");
			}
		}
	}

	[Column(Storage = "_FechaOrdenanza", DbType = "DateTime")]
	public DateTime? FechaOrdenanza
	{
		get
		{
			return _FechaOrdenanza;
		}
		set
		{
			if (!_FechaOrdenanza.Equals(value))
			{
				SendPropertyChanging();
				_FechaOrdenanza = value;
				SendPropertyChanged("FechaOrdenanza");
			}
		}
	}

	[Column(Storage = "_idTipoNorma", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoNorma
	{
		get
		{
			return _idTipoNorma;
		}
		set
		{
			if (_idTipoNorma != value)
			{
				if (_CJRTipoNorma.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idTipoNorma = value;
				SendPropertyChanged("idTipoNorma");
			}
		}
	}

	[Column(Storage = "_NumProyecto", DbType = "VarChar(120)")]
	public string NumProyecto
	{
		get
		{
			return _NumProyecto;
		}
		set
		{
			if (!string.Equals(_NumProyecto, value))
			{
				if (_CJRProyectoNormativo.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NumProyecto = value;
				SendPropertyChanged("NumProyecto");
			}
		}
	}

	[Column(Storage = "_idTipoProyec", DbType = "Int")]
	public int? idTipoProyec
	{
		get
		{
			return _idTipoProyec;
		}
		set
		{
			if (!_idTipoProyec.Equals(value))
			{
				if (_CJRProyectoNormativo.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idTipoProyec = value;
				SendPropertyChanged("idTipoProyec");
			}
		}
	}

	[Association(Name = "CJRNormaRegional_CJRNotificacionNorma", Storage = "_CJRNotificacionNorma", ThisKey = "NumOrdenanza,idTipoNorma", OtherKey = "NumOrdenanza,idTipoNorma")]
	public EntitySet<CJRNotificacionNorma> CJRNotificacionNorma
	{
		get
		{
			return _CJRNotificacionNorma;
		}
		set
		{
			_CJRNotificacionNorma.Assign(value);
		}
	}

	[Association(Name = "CJRNormaRegional_CJRPublicacion", Storage = "_CJRPublicacion", ThisKey = "NumOrdenanza,idTipoNorma", OtherKey = "NumOrdenanza,idTipoNorma")]
	public EntitySet<CJRPublicacion> CJRPublicacion
	{
		get
		{
			return _CJRPublicacion;
		}
		set
		{
			_CJRPublicacion.Assign(value);
		}
	}

	[Association(Name = "CJRNormaRegional_CJRPublicacionNorma", Storage = "_CJRPublicacionNorma", ThisKey = "NumOrdenanza,idTipoNorma", OtherKey = "NumOrdenanza,idTipoNorma")]
	public EntitySet<CJRPublicacionNorma> CJRPublicacionNorma
	{
		get
		{
			return _CJRPublicacionNorma;
		}
		set
		{
			_CJRPublicacionNorma.Assign(value);
		}
	}

	[Association(Name = "CJRProyectoNormativo_CJRNormaRegional", Storage = "_CJRProyectoNormativo", ThisKey = "NumProyecto,idTipoProyec", OtherKey = "NumProyecto,idTipoProyec", IsForeignKey = true)]
	public CJRProyectoNormativo CJRProyectoNormativo
	{
		get
		{
			return _CJRProyectoNormativo.Entity;
		}
		set
		{
			CJRProyectoNormativo previousValue = _CJRProyectoNormativo.Entity;
			if (!object.Equals(previousValue, value) || !_CJRProyectoNormativo.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRProyectoNormativo.Entity = null;
					previousValue.CJRNormaRegional.Remove(this);
				}
				_CJRProyectoNormativo.Entity = value;
				if (value != null)
				{
					value.CJRNormaRegional.Add(this);
					_NumProyecto = value.NumProyecto;
					_idTipoProyec = value.idTipoProyec;
				}
				else
				{
					_NumProyecto = null;
					_idTipoProyec = null;
				}
				SendPropertyChanged("CJRProyectoNormativo");
			}
		}
	}

	[Association(Name = "CJRTipoNorma_CJRNormaRegional", Storage = "_CJRTipoNorma", ThisKey = "idTipoNorma", OtherKey = "idTipoNorma", IsForeignKey = true)]
	public CJRTipoNorma CJRTipoNorma
	{
		get
		{
			return _CJRTipoNorma.Entity;
		}
		set
		{
			CJRTipoNorma previousValue = _CJRTipoNorma.Entity;
			if (!object.Equals(previousValue, value) || !_CJRTipoNorma.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRTipoNorma.Entity = null;
					previousValue.CJRNormaRegional.Remove(this);
				}
				_CJRTipoNorma.Entity = value;
				if (value != null)
				{
					value.CJRNormaRegional.Add(this);
					_idTipoNorma = value.idTipoNorma;
				}
				else
				{
					_idTipoNorma = 0;
				}
				SendPropertyChanged("CJRTipoNorma");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRNormaRegional()
	{
		_CJRNotificacionNorma = new EntitySet<CJRNotificacionNorma>(attach_CJRNotificacionNorma, detach_CJRNotificacionNorma);
		_CJRPublicacion = new EntitySet<CJRPublicacion>(attach_CJRPublicacion, detach_CJRPublicacion);
		_CJRPublicacionNorma = new EntitySet<CJRPublicacionNorma>(attach_CJRPublicacionNorma, detach_CJRPublicacionNorma);
		_CJRProyectoNormativo = default(EntityRef<CJRProyectoNormativo>);
		_CJRTipoNorma = default(EntityRef<CJRTipoNorma>);
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

	private void attach_CJRNotificacionNorma(CJRNotificacionNorma entity)
	{
		SendPropertyChanging();
		entity.CJRNormaRegional = this;
	}

	private void detach_CJRNotificacionNorma(CJRNotificacionNorma entity)
	{
		SendPropertyChanging();
		entity.CJRNormaRegional = null;
	}

	private void attach_CJRPublicacion(CJRPublicacion entity)
	{
		SendPropertyChanging();
		entity.CJRNormaRegional = this;
	}

	private void detach_CJRPublicacion(CJRPublicacion entity)
	{
		SendPropertyChanging();
		entity.CJRNormaRegional = null;
	}

	private void attach_CJRPublicacionNorma(CJRPublicacionNorma entity)
	{
		SendPropertyChanging();
		entity.CJRNormaRegional = this;
	}

	private void detach_CJRPublicacionNorma(CJRPublicacionNorma entity)
	{
		SendPropertyChanging();
		entity.CJRNormaRegional = null;
	}
}
