using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRTemaIniciativa")]
public class CJRTemaIniciativa : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _NumOficioIniciativa;

	private int _NumTema;

	private string _TemaDescrip;

	private EntitySet<CJRProyectoNormativo> _CJRProyectoNormativo;

	private EntitySet<CJRSolicitudOpinion> _CJRSolicitudOpinion;

	private EntitySet<CJRSolicitudOpinion> _CJRSolicitudOpinion1;

	private EntityRef<CJRIniciativa> _CJRIniciativa;

	private EntityRef<CJRIniciativa> _CJRIniciativa1;

	private EntityRef<CJRIniciativa> _CJRIniciativa2;

	[Column(Storage = "_NumOficioIniciativa", DbType = "VarChar(120) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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
				if (_CJRIniciativa.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NumOficioIniciativa = value;
				SendPropertyChanged("NumOficioIniciativa");
			}
		}
	}

	[Column(Storage = "_NumTema", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int NumTema
	{
		get
		{
			return _NumTema;
		}
		set
		{
			if (_NumTema != value)
			{
				SendPropertyChanging();
				_NumTema = value;
				SendPropertyChanged("NumTema");
			}
		}
	}

	[Column(Storage = "_TemaDescrip", DbType = "VarChar(2000)")]
	public string TemaDescrip
	{
		get
		{
			return _TemaDescrip;
		}
		set
		{
			if (!string.Equals(_TemaDescrip, value))
			{
				SendPropertyChanging();
				_TemaDescrip = value;
				SendPropertyChanged("TemaDescrip");
			}
		}
	}

	[Association(Name = "CJRTemaIniciativa_CJRProyectoNormativo", Storage = "_CJRProyectoNormativo", ThisKey = "NumOficioIniciativa,NumTema", OtherKey = "NumOficioIniciativa,NumTema")]
	public EntitySet<CJRProyectoNormativo> CJRProyectoNormativo
	{
		get
		{
			return _CJRProyectoNormativo;
		}
		set
		{
			_CJRProyectoNormativo.Assign(value);
		}
	}

	[Association(Name = "CJRTemaIniciativa_CJRSolicitudOpinion", Storage = "_CJRSolicitudOpinion", ThisKey = "NumOficioIniciativa,NumTema", OtherKey = "NumOficioIniciativa,NumTema")]
	public EntitySet<CJRSolicitudOpinion> CJRSolicitudOpinion
	{
		get
		{
			return _CJRSolicitudOpinion;
		}
		set
		{
			_CJRSolicitudOpinion.Assign(value);
		}
	}

	[Association(Name = "CJRTemaIniciativa_CJRSolicitudOpinion1", Storage = "_CJRSolicitudOpinion1", ThisKey = "NumOficioIniciativa,NumTema", OtherKey = "NumOficioIniciativa,NumTema")]
	public EntitySet<CJRSolicitudOpinion> CJRSolicitudOpinion1
	{
		get
		{
			return _CJRSolicitudOpinion1;
		}
		set
		{
			_CJRSolicitudOpinion1.Assign(value);
		}
	}

	[Association(Name = "CJRIniciativa_CJRTemaIniciativa", Storage = "_CJRIniciativa", ThisKey = "NumOficioIniciativa", OtherKey = "NumOficioIniciativa", IsForeignKey = true)]
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
					previousValue.CJRTemaIniciativa.Remove(this);
				}
				_CJRIniciativa.Entity = value;
				if (value != null)
				{
					value.CJRTemaIniciativa.Add(this);
					_NumOficioIniciativa = value.NumOficioIniciativa;
				}
				else
				{
					_NumOficioIniciativa = null;
				}
				SendPropertyChanged("CJRIniciativa");
			}
		}
	}

	[Association(Name = "CJRIniciativa_CJRTemaIniciativa1", Storage = "_CJRIniciativa1", ThisKey = "NumOficioIniciativa", OtherKey = "NumOficioIniciativa", IsForeignKey = true)]
	public CJRIniciativa CJRIniciativa1
	{
		get
		{
			return _CJRIniciativa1.Entity;
		}
		set
		{
			CJRIniciativa previousValue = _CJRIniciativa1.Entity;
			if (!object.Equals(previousValue, value) || !_CJRIniciativa1.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRIniciativa1.Entity = null;
					previousValue.CJRTemaIniciativa1.Remove(this);
				}
				_CJRIniciativa1.Entity = value;
				if (value != null)
				{
					value.CJRTemaIniciativa1.Add(this);
					_NumOficioIniciativa = value.NumOficioIniciativa;
				}
				else
				{
					_NumOficioIniciativa = null;
				}
				SendPropertyChanged("CJRIniciativa1");
			}
		}
	}

	[Association(Name = "CJRIniciativa_CJRTemaIniciativa2", Storage = "_CJRIniciativa2", ThisKey = "NumOficioIniciativa", OtherKey = "NumOficioIniciativa", IsForeignKey = true)]
	public CJRIniciativa CJRIniciativa2
	{
		get
		{
			return _CJRIniciativa2.Entity;
		}
		set
		{
			CJRIniciativa previousValue = _CJRIniciativa2.Entity;
			if (!object.Equals(previousValue, value) || !_CJRIniciativa2.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRIniciativa2.Entity = null;
					previousValue.CJRTemaIniciativa2.Remove(this);
				}
				_CJRIniciativa2.Entity = value;
				if (value != null)
				{
					value.CJRTemaIniciativa2.Add(this);
					_NumOficioIniciativa = value.NumOficioIniciativa;
				}
				else
				{
					_NumOficioIniciativa = null;
				}
				SendPropertyChanged("CJRIniciativa2");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRTemaIniciativa()
	{
		_CJRProyectoNormativo = new EntitySet<CJRProyectoNormativo>(attach_CJRProyectoNormativo, detach_CJRProyectoNormativo);
		_CJRSolicitudOpinion = new EntitySet<CJRSolicitudOpinion>(attach_CJRSolicitudOpinion, detach_CJRSolicitudOpinion);
		_CJRSolicitudOpinion1 = new EntitySet<CJRSolicitudOpinion>(attach_CJRSolicitudOpinion1, detach_CJRSolicitudOpinion1);
		_CJRIniciativa = default(EntityRef<CJRIniciativa>);
		_CJRIniciativa1 = default(EntityRef<CJRIniciativa>);
		_CJRIniciativa2 = default(EntityRef<CJRIniciativa>);
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

	private void attach_CJRProyectoNormativo(CJRProyectoNormativo entity)
	{
		SendPropertyChanging();
		entity.CJRTemaIniciativa = this;
	}

	private void detach_CJRProyectoNormativo(CJRProyectoNormativo entity)
	{
		SendPropertyChanging();
		entity.CJRTemaIniciativa = null;
	}

	private void attach_CJRSolicitudOpinion(CJRSolicitudOpinion entity)
	{
		SendPropertyChanging();
		entity.CJRTemaIniciativa = this;
	}

	private void detach_CJRSolicitudOpinion(CJRSolicitudOpinion entity)
	{
		SendPropertyChanging();
		entity.CJRTemaIniciativa = null;
	}

	private void attach_CJRSolicitudOpinion1(CJRSolicitudOpinion entity)
	{
		SendPropertyChanging();
		entity.CJRTemaIniciativa1 = this;
	}

	private void detach_CJRSolicitudOpinion1(CJRSolicitudOpinion entity)
	{
		SendPropertyChanging();
		entity.CJRTemaIniciativa1 = null;
	}
}
