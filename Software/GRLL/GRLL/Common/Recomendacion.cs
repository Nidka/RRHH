using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Recomendacion")]
public class Recomendacion : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _Year;

	private int _idAreaOrganiz;

	private short _Trimestre;

	private int _IdRecomend;

	private int? _IdLimitacion;

	private string _Limitacion;

	private string _Descripcion;

	private EntityRef<Limitacion> _Limitacion1;

	private EntityRef<EstructOrganiz> _EstructOrganiz;

	[Column(Storage = "_Year", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (_Year != value)
			{
				if (_EstructOrganiz.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Year = value;
				SendPropertyChanged("Year");
			}
		}
	}

	[Column(Storage = "_idAreaOrganiz", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (_idAreaOrganiz != value)
			{
				if (_EstructOrganiz.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idAreaOrganiz = value;
				SendPropertyChanged("idAreaOrganiz");
			}
		}
	}

	[Column(Storage = "_Trimestre", DbType = "SmallInt NOT NULL", IsPrimaryKey = true)]
	public short Trimestre
	{
		get
		{
			return _Trimestre;
		}
		set
		{
			if (_Trimestre != value)
			{
				SendPropertyChanging();
				_Trimestre = value;
				SendPropertyChanged("Trimestre");
			}
		}
	}

	[Column(Storage = "_IdRecomend", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdRecomend
	{
		get
		{
			return _IdRecomend;
		}
		set
		{
			if (_IdRecomend != value)
			{
				SendPropertyChanging();
				_IdRecomend = value;
				SendPropertyChanged("IdRecomend");
			}
		}
	}

	[Column(Storage = "_IdLimitacion", DbType = "Int")]
	public int? IdLimitacion
	{
		get
		{
			return _IdLimitacion;
		}
		set
		{
			if (!_IdLimitacion.Equals(value))
			{
				if (_Limitacion1.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdLimitacion = value;
				SendPropertyChanged("IdLimitacion");
			}
		}
	}

	[Column(Storage = "_Limitacion", DbType = "VarChar(500)")]
	public string Limitacion
	{
		get
		{
			return _Limitacion;
		}
		set
		{
			if (!string.Equals(_Limitacion, value))
			{
				SendPropertyChanging();
				_Limitacion = value;
				SendPropertyChanged("Limitacion");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(500)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				SendPropertyChanging();
				_Descripcion = value;
				SendPropertyChanged("Descripcion");
			}
		}
	}

	[Association(Name = "Limitacion_Recomendacion", Storage = "_Limitacion1", ThisKey = "IdLimitacion", OtherKey = "IdLimitacion", IsForeignKey = true)]
	public Limitacion Limitacion1
	{
		get
		{
			return _Limitacion1.Entity;
		}
		set
		{
			Limitacion previousValue = _Limitacion1.Entity;
			if (!object.Equals(previousValue, value) || !_Limitacion1.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Limitacion1.Entity = null;
					previousValue.Recomendacion.Remove(this);
				}
				_Limitacion1.Entity = value;
				if (value != null)
				{
					value.Recomendacion.Add(this);
					_IdLimitacion = value.IdLimitacion;
				}
				else
				{
					_IdLimitacion = null;
				}
				SendPropertyChanged("Limitacion1");
			}
		}
	}

	[Association(Name = "EstructOrganiz_Recomendacion", Storage = "_EstructOrganiz", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz", IsForeignKey = true)]
	public EstructOrganiz EstructOrganiz
	{
		get
		{
			return _EstructOrganiz.Entity;
		}
		set
		{
			EstructOrganiz previousValue = _EstructOrganiz.Entity;
			if (!object.Equals(previousValue, value) || !_EstructOrganiz.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_EstructOrganiz.Entity = null;
					previousValue.Recomendacion.Remove(this);
				}
				_EstructOrganiz.Entity = value;
				if (value != null)
				{
					value.Recomendacion.Add(this);
					_Year = value.Year;
					_idAreaOrganiz = value.idAreaOrganiz;
				}
				else
				{
					_Year = 0;
					_idAreaOrganiz = 0;
				}
				SendPropertyChanged("EstructOrganiz");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Recomendacion()
	{
		_Limitacion1 = default(EntityRef<Limitacion>);
		_EstructOrganiz = default(EntityRef<EstructOrganiz>);
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
