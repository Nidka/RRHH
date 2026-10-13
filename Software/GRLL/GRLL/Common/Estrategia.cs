using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Estrategia")]
public class Estrategia : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _Year;

	private int _idAreaOrganiz;

	private int _IdEstrategia;

	private string _Estrategia;

	private DateTime _FechaInicio;

	private DateTime _FechaCulminacion;

	private int? _IdPresupuesto;

	private EntitySet<Objetivo> _Objetivo;

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

	[Column(Storage = "_IdEstrategia", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdEstrategia
	{
		get
		{
			return _IdEstrategia;
		}
		set
		{
			if (_IdEstrategia != value)
			{
				SendPropertyChanging();
				_IdEstrategia = value;
				SendPropertyChanged("IdEstrategia");
			}
		}
	}

	[Column(Name = "Estrategia", Storage = "_Estrategia", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
	public string EstrategiaValue
	{
		get
		{
			return _Estrategia;
		}
		set
		{
			if (!string.Equals(_Estrategia, value))
			{
				SendPropertyChanging();
				_Estrategia = value;
				SendPropertyChanged("Estrategia");
			}
		}
	}

	[Column(Storage = "_FechaInicio", DbType = "SmallDateTime NOT NULL")]
	public DateTime FechaInicio
	{
		get
		{
			return _FechaInicio;
		}
		set
		{
			if (DateTime.Compare(_FechaInicio, value) != 0)
			{
				SendPropertyChanging();
				_FechaInicio = value;
				SendPropertyChanged("FechaInicio");
			}
		}
	}

	[Column(Storage = "_FechaCulminacion", DbType = "SmallDateTime NOT NULL")]
	public DateTime FechaCulminacion
	{
		get
		{
			return _FechaCulminacion;
		}
		set
		{
			if (DateTime.Compare(_FechaCulminacion, value) != 0)
			{
				SendPropertyChanging();
				_FechaCulminacion = value;
				SendPropertyChanged("FechaCulminacion");
			}
		}
	}

	[Column(Storage = "_IdPresupuesto", DbType = "Int")]
	public int? IdPresupuesto
	{
		get
		{
			return _IdPresupuesto;
		}
		set
		{
			if (!_IdPresupuesto.Equals(value))
			{
				SendPropertyChanging();
				_IdPresupuesto = value;
				SendPropertyChanged("IdPresupuesto");
			}
		}
	}

	[Association(Name = "Estrategia_Objetivo", Storage = "_Objetivo", ThisKey = "Year,idAreaOrganiz,IdEstrategia", OtherKey = "Year,idAreaOrganiz,IdEstrategia")]
	public EntitySet<Objetivo> Objetivo
	{
		get
		{
			return _Objetivo;
		}
		set
		{
			_Objetivo.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_Estrategia", Storage = "_EstructOrganiz", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz", IsForeignKey = true)]
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
					previousValue.Estrategia.Remove(this);
				}
				_EstructOrganiz.Entity = value;
				if (value != null)
				{
					value.Estrategia.Add(this);
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

	public Estrategia()
	{
		_Objetivo = new EntitySet<Objetivo>(attach_Objetivo, detach_Objetivo);
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

	private void attach_Objetivo(Objetivo entity)
	{
		SendPropertyChanging();
		entity.Estrategia = this;
	}

	private void detach_Objetivo(Objetivo entity)
	{
		SendPropertyChanging();
		entity.Estrategia = null;
	}
}
