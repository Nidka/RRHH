using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRSesion")]
public class CJRSesion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _NumSesion;

	private DateTime? _FechaSesion;

	private int? _idTipoSesion;

	private string _NumProyecto;

	private int _idTipoProyec;

	private EntityRef<CJRProyectoNormativo> _CJRProyectoNormativo;

	private EntityRef<CJRTipoSesion> _CJRTipoSesion;

	[Column(Storage = "_NumSesion", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int NumSesion
	{
		get
		{
			return _NumSesion;
		}
		set
		{
			if (_NumSesion != value)
			{
				SendPropertyChanging();
				_NumSesion = value;
				SendPropertyChanged("NumSesion");
			}
		}
	}

	[Column(Storage = "_FechaSesion", DbType = "DateTime")]
	public DateTime? FechaSesion
	{
		get
		{
			return _FechaSesion;
		}
		set
		{
			if (!_FechaSesion.Equals(value))
			{
				SendPropertyChanging();
				_FechaSesion = value;
				SendPropertyChanged("FechaSesion");
			}
		}
	}

	[Column(Storage = "_idTipoSesion", DbType = "Int")]
	public int? idTipoSesion
	{
		get
		{
			return _idTipoSesion;
		}
		set
		{
			if (!_idTipoSesion.Equals(value))
			{
				if (_CJRTipoSesion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idTipoSesion = value;
				SendPropertyChanged("idTipoSesion");
			}
		}
	}

	[Column(Storage = "_NumProyecto", DbType = "VarChar(120) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
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

	[Column(Storage = "_idTipoProyec", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoProyec
	{
		get
		{
			return _idTipoProyec;
		}
		set
		{
			if (_idTipoProyec != value)
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

	[Association(Name = "CJRProyectoNormativo_CJRSesion", Storage = "_CJRProyectoNormativo", ThisKey = "NumProyecto,idTipoProyec", OtherKey = "NumProyecto,idTipoProyec", IsForeignKey = true)]
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
					previousValue.CJRSesion.Remove(this);
				}
				_CJRProyectoNormativo.Entity = value;
				if (value != null)
				{
					value.CJRSesion.Add(this);
					_NumProyecto = value.NumProyecto;
					_idTipoProyec = value.idTipoProyec;
				}
				else
				{
					_NumProyecto = null;
					_idTipoProyec = 0;
				}
				SendPropertyChanged("CJRProyectoNormativo");
			}
		}
	}

	[Association(Name = "CJRTipoSesion_CJRSesion", Storage = "_CJRTipoSesion", ThisKey = "idTipoSesion", OtherKey = "idTipoSesion", IsForeignKey = true)]
	public CJRTipoSesion CJRTipoSesion
	{
		get
		{
			return _CJRTipoSesion.Entity;
		}
		set
		{
			CJRTipoSesion previousValue = _CJRTipoSesion.Entity;
			if (!object.Equals(previousValue, value) || !_CJRTipoSesion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRTipoSesion.Entity = null;
					previousValue.CJRSesion.Remove(this);
				}
				_CJRTipoSesion.Entity = value;
				if (value != null)
				{
					value.CJRSesion.Add(this);
					_idTipoSesion = value.idTipoSesion;
				}
				else
				{
					_idTipoSesion = null;
				}
				SendPropertyChanged("CJRTipoSesion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRSesion()
	{
		_CJRProyectoNormativo = default(EntityRef<CJRProyectoNormativo>);
		_CJRTipoSesion = default(EntityRef<CJRTipoSesion>);
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
