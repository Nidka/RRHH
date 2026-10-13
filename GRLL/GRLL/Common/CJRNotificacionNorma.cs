using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRNotificacionNorma")]
public class CJRNotificacionNorma : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _NumOrdenanza;

	private string _NumOficio;

	private int? _idTipoNorma;

	private EntityRef<CJRNormaRegional> _CJRNormaRegional;

	private EntityRef<CJROficio> _CJROficio;

	[Column(Storage = "_NumOrdenanza", DbType = "VarChar(120)")]
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
				if (_CJRNormaRegional.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_NumOrdenanza = value;
				SendPropertyChanged("NumOrdenanza");
			}
		}
	}

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

	[Column(Storage = "_idTipoNorma", DbType = "Int")]
	public int? idTipoNorma
	{
		get
		{
			return _idTipoNorma;
		}
		set
		{
			if (!_idTipoNorma.Equals(value))
			{
				if (_CJRNormaRegional.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idTipoNorma = value;
				SendPropertyChanged("idTipoNorma");
			}
		}
	}

	[Association(Name = "CJRNormaRegional_CJRNotificacionNorma", Storage = "_CJRNormaRegional", ThisKey = "NumOrdenanza,idTipoNorma", OtherKey = "NumOrdenanza,idTipoNorma", IsForeignKey = true)]
	public CJRNormaRegional CJRNormaRegional
	{
		get
		{
			return _CJRNormaRegional.Entity;
		}
		set
		{
			CJRNormaRegional previousValue = _CJRNormaRegional.Entity;
			if (!object.Equals(previousValue, value) || !_CJRNormaRegional.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRNormaRegional.Entity = null;
					previousValue.CJRNotificacionNorma.Remove(this);
				}
				_CJRNormaRegional.Entity = value;
				if (value != null)
				{
					value.CJRNotificacionNorma.Add(this);
					_NumOrdenanza = value.NumOrdenanza;
					_idTipoNorma = value.idTipoNorma;
				}
				else
				{
					_NumOrdenanza = null;
					_idTipoNorma = null;
				}
				SendPropertyChanged("CJRNormaRegional");
			}
		}
	}

	[Association(Name = "CJROficio_CJRNotificacionNorma", Storage = "_CJROficio", ThisKey = "NumOficio", OtherKey = "NumOficio", IsForeignKey = true)]
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
					previousValue.CJRNotificacionNorma = null;
				}
				_CJROficio.Entity = value;
				if (value != null)
				{
					value.CJRNotificacionNorma = this;
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

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRNotificacionNorma()
	{
		_CJRNormaRegional = default(EntityRef<CJRNormaRegional>);
		_CJROficio = default(EntityRef<CJROficio>);
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
