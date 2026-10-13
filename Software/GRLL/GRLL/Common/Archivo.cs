using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Archivo")]
public class Archivo : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idDocumento;

	private int _IdEmpleado;

	private DateTime? _FechaIngreDoc;

	private DateTime? _FechaVenDoc;

	private string _NumRef;

	private string _Obs;

	private EntityRef<Documento> _Documento;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_idDocumento", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idDocumento
	{
		get
		{
			return _idDocumento;
		}
		set
		{
			if (_idDocumento != value)
			{
				if (_Documento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idDocumento = value;
				SendPropertyChanged("idDocumento");
			}
		}
	}

	[Column(Storage = "_IdEmpleado", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (_IdEmpleado != value)
			{
				if (_Empleado.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdEmpleado = value;
				SendPropertyChanged("IdEmpleado");
			}
		}
	}

	[Column(Storage = "_FechaIngreDoc", DbType = "DateTime")]
	public DateTime? FechaIngreDoc
	{
		get
		{
			return _FechaIngreDoc;
		}
		set
		{
			if (!_FechaIngreDoc.Equals(value))
			{
				SendPropertyChanging();
				_FechaIngreDoc = value;
				SendPropertyChanged("FechaIngreDoc");
			}
		}
	}

	[Column(Storage = "_FechaVenDoc", DbType = "DateTime")]
	public DateTime? FechaVenDoc
	{
		get
		{
			return _FechaVenDoc;
		}
		set
		{
			if (!_FechaVenDoc.Equals(value))
			{
				SendPropertyChanging();
				_FechaVenDoc = value;
				SendPropertyChanged("FechaVenDoc");
			}
		}
	}

	[Column(Storage = "_NumRef", DbType = "VarChar(20)")]
	public string NumRef
	{
		get
		{
			return _NumRef;
		}
		set
		{
			if (!string.Equals(_NumRef, value))
			{
				SendPropertyChanging();
				_NumRef = value;
				SendPropertyChanged("NumRef");
			}
		}
	}

	[Column(Storage = "_Obs", DbType = "VarChar(120)")]
	public string Obs
	{
		get
		{
			return _Obs;
		}
		set
		{
			if (!string.Equals(_Obs, value))
			{
				SendPropertyChanging();
				_Obs = value;
				SendPropertyChanged("Obs");
			}
		}
	}

	[Association(Name = "Documento_Archivo", Storage = "_Documento", ThisKey = "idDocumento", OtherKey = "idDocumento", IsForeignKey = true)]
	public Documento Documento
	{
		get
		{
			return _Documento.Entity;
		}
		set
		{
			Documento previousValue = _Documento.Entity;
			if (!object.Equals(previousValue, value) || !_Documento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Documento.Entity = null;
					previousValue.Archivo.Remove(this);
				}
				_Documento.Entity = value;
				if (value != null)
				{
					value.Archivo.Add(this);
					_idDocumento = value.idDocumento;
				}
				else
				{
					_idDocumento = 0;
				}
				SendPropertyChanged("Documento");
			}
		}
	}

	[Association(Name = "Empleado_Archivo", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
	public Empleado Empleado
	{
		get
		{
			return _Empleado.Entity;
		}
		set
		{
			Empleado previousValue = _Empleado.Entity;
			if (!object.Equals(previousValue, value) || !_Empleado.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Empleado.Entity = null;
					previousValue.Archivos.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Archivos.Add(this);
					_IdEmpleado = value.IdEmpleado;
				}
				else
				{
					_IdEmpleado = 0;
				}
				SendPropertyChanged("Empleado");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Archivo()
	{
		_Documento = default(EntityRef<Documento>);
		_Empleado = default(EntityRef<Empleado>);
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
