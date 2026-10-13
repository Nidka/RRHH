using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.CJRPublicacion")]
public class CJRPublicacion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _NumOrdenanza;

	private DateTime? _FechaPublicacion;

	private string _Paginas;

	private string _NombreMedio;

	private int _idTipoMedio;

	private int _idTipoNorma;

	private EntityRef<CJRNormaRegional> _CJRNormaRegional;

	private EntityRef<CJRTipoMedio> _CJRTipoMedio;

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

	[Column(Storage = "_FechaPublicacion", DbType = "DateTime")]
	public DateTime? FechaPublicacion
	{
		get
		{
			return _FechaPublicacion;
		}
		set
		{
			if (!_FechaPublicacion.Equals(value))
			{
				SendPropertyChanging();
				_FechaPublicacion = value;
				SendPropertyChanged("FechaPublicacion");
			}
		}
	}

	[Column(Storage = "_Paginas", DbType = "VarChar(30)")]
	public string Paginas
	{
		get
		{
			return _Paginas;
		}
		set
		{
			if (!string.Equals(_Paginas, value))
			{
				SendPropertyChanging();
				_Paginas = value;
				SendPropertyChanged("Paginas");
			}
		}
	}

	[Column(Storage = "_NombreMedio", DbType = "VarChar(80)")]
	public string NombreMedio
	{
		get
		{
			return _NombreMedio;
		}
		set
		{
			if (!string.Equals(_NombreMedio, value))
			{
				SendPropertyChanging();
				_NombreMedio = value;
				SendPropertyChanged("NombreMedio");
			}
		}
	}

	[Column(Storage = "_idTipoMedio", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idTipoMedio
	{
		get
		{
			return _idTipoMedio;
		}
		set
		{
			if (_idTipoMedio != value)
			{
				if (_CJRTipoMedio.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idTipoMedio = value;
				SendPropertyChanged("idTipoMedio");
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

	[Association(Name = "CJRNormaRegional_CJRPublicacion", Storage = "_CJRNormaRegional", ThisKey = "NumOrdenanza,idTipoNorma", OtherKey = "NumOrdenanza,idTipoNorma", IsForeignKey = true)]
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
					previousValue.CJRPublicacion.Remove(this);
				}
				_CJRNormaRegional.Entity = value;
				if (value != null)
				{
					value.CJRPublicacion.Add(this);
					_NumOrdenanza = value.NumOrdenanza;
					_idTipoNorma = value.idTipoNorma;
				}
				else
				{
					_NumOrdenanza = null;
					_idTipoNorma = 0;
				}
				SendPropertyChanged("CJRNormaRegional");
			}
		}
	}

	[Association(Name = "CJRTipoMedio_CJRPublicacion", Storage = "_CJRTipoMedio", ThisKey = "idTipoMedio", OtherKey = "idTipoMedio", IsForeignKey = true)]
	public CJRTipoMedio CJRTipoMedio
	{
		get
		{
			return _CJRTipoMedio.Entity;
		}
		set
		{
			CJRTipoMedio previousValue = _CJRTipoMedio.Entity;
			if (!object.Equals(previousValue, value) || !_CJRTipoMedio.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_CJRTipoMedio.Entity = null;
					previousValue.CJRPublicacion.Remove(this);
				}
				_CJRTipoMedio.Entity = value;
				if (value != null)
				{
					value.CJRPublicacion.Add(this);
					_idTipoMedio = value.idTipoMedio;
				}
				else
				{
					_idTipoMedio = 0;
				}
				SendPropertyChanged("CJRTipoMedio");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public CJRPublicacion()
	{
		_CJRNormaRegional = default(EntityRef<CJRNormaRegional>);
		_CJRTipoMedio = default(EntityRef<CJRTipoMedio>);
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
