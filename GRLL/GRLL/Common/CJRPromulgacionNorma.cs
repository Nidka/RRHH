using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRPromulgacionNorma")]
public class CJRPromulgacionNorma : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _NumOficio;

	private string _NumProyecto;

	private int? _idTipoProyec;

	private EntityRef<CJROficio> _CJROficio;

	private EntityRef<CJRProyectoNormativo> _CJRProyectoNormativo;

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

	[Association(Name = "CJROficio_CJRPromulgacionNorma", Storage = "_CJROficio", ThisKey = "NumOficio", OtherKey = "NumOficio", IsForeignKey = true)]
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
					previousValue.CJRPromulgacionNorma = null;
				}
				_CJROficio.Entity = value;
				if (value != null)
				{
					value.CJRPromulgacionNorma = this;
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

	[Association(Name = "CJRProyectoNormativo_CJRPromulgacionNorma", Storage = "_CJRProyectoNormativo", ThisKey = "NumProyecto,idTipoProyec", OtherKey = "NumProyecto,idTipoProyec", IsForeignKey = true)]
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
					previousValue.CJRPromulgacionNorma.Remove(this);
				}
				_CJRProyectoNormativo.Entity = value;
				if (value != null)
				{
					value.CJRPromulgacionNorma.Add(this);
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

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRPromulgacionNorma()
	{
		_CJROficio = default(EntityRef<CJROficio>);
		_CJRProyectoNormativo = default(EntityRef<CJRProyectoNormativo>);
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
