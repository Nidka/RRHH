using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRDictamenComision")]
public class CJRDictamenComision : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _NumDictamen;

	private bool? _Aprobado;

	private DateTime? _FechaDictamen;

	private int? _idAprobacion;

	private string _NumProyecto;

	private int? _idTipoProyec;

	private EntityRef<CJRProyectoNormativo> _CJRProyectoNormativo;

	private EntityRef<CJRTipoAprobacion> _CJRTipoAprobacion;

	[Column(Storage = "_NumDictamen", DbType = "VarChar(120) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string NumDictamen
	{
		get
		{
			return _NumDictamen;
		}
		set
		{
			if (!string.Equals(_NumDictamen, value))
			{
				SendPropertyChanging();
				_NumDictamen = value;
				SendPropertyChanged("NumDictamen");
			}
		}
	}

	[Column(Storage = "_Aprobado", DbType = "Bit")]
	public bool? Aprobado
	{
		get
		{
			return _Aprobado;
		}
		set
		{
			if (!_Aprobado.Equals(value))
			{
				SendPropertyChanging();
				_Aprobado = value;
				SendPropertyChanged("Aprobado");
			}
		}
	}

	[Column(Storage = "_FechaDictamen", DbType = "DateTime")]
	public DateTime? FechaDictamen
	{
		get
		{
			return _FechaDictamen;
		}
		set
		{
			if (!_FechaDictamen.Equals(value))
			{
				SendPropertyChanging();
				_FechaDictamen = value;
				SendPropertyChanged("FechaDictamen");
			}
		}
	}

	[Column(Storage = "_idAprobacion", DbType = "Int")]
	public int? idAprobacion
	{
		get
		{
			return _idAprobacion;
		}
		set
		{
			if (!_idAprobacion.Equals(value))
			{
				if (_CJRTipoAprobacion.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idAprobacion = value;
				SendPropertyChanged("idAprobacion");
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

	[Association(Name = "CJRProyectoNormativo_CJRDictamenComision", Storage = "_CJRProyectoNormativo", ThisKey = "NumProyecto,idTipoProyec", OtherKey = "NumProyecto,idTipoProyec", IsForeignKey = true)]
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
					previousValue.CJRDictamenComision.Remove(this);
				}
				_CJRProyectoNormativo.Entity = value;
				if (value != null)
				{
					value.CJRDictamenComision.Add(this);
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

	[Association(Name = "CJRTipoAprobacion_CJRDictamenComision", Storage = "_CJRTipoAprobacion", ThisKey = "idAprobacion", OtherKey = "idAprobacion", IsForeignKey = true)]
	public CJRTipoAprobacion CJRTipoAprobacion
	{
		get
		{
			return _CJRTipoAprobacion.Entity;
		}
		set
		{
			CJRTipoAprobacion previousValue = _CJRTipoAprobacion.Entity;
			if (!object.Equals(previousValue, value) || !_CJRTipoAprobacion.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRTipoAprobacion.Entity = null;
					previousValue.CJRDictamenComision.Remove(this);
				}
				_CJRTipoAprobacion.Entity = value;
				if (value != null)
				{
					value.CJRDictamenComision.Add(this);
					_idAprobacion = value.idAprobacion;
				}
				else
				{
					_idAprobacion = null;
				}
				SendPropertyChanged("CJRTipoAprobacion");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRDictamenComision()
	{
		_CJRProyectoNormativo = default(EntityRef<CJRProyectoNormativo>);
		_CJRTipoAprobacion = default(EntityRef<CJRTipoAprobacion>);
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
