using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Objetivo")]
public class Objetivo : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdObjetivo;

	private int? _Year;

	private int? _idAreaOrganiz;

	private int? _IdEstrategia;

	private string _Objetivo;

	private DateTime _FechaInicio;

	private DateTime _FechaFin;

	private int? _IdPresupuesto;

	private decimal? _AvanceAnual;

	private decimal? _AvanceGlobal;

	private decimal _Meta;

	private int _Importancia;

	private int? _IdUnidMed;

	private EntityRef<Estrategia> _Estrategia;

	private EntityRef<UnidMed> _UnidMed;

	[Column(Storage = "_IdObjetivo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdObjetivo
	{
		get
		{
			return _IdObjetivo;
		}
		set
		{
			if (_IdObjetivo != value)
			{
				SendPropertyChanging();
				_IdObjetivo = value;
				SendPropertyChanged("IdObjetivo");
			}
		}
	}

	[Column(Storage = "_Year", DbType = "Int")]
	public int? Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (!_Year.Equals(value))
			{
				if (_Estrategia.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Year = value;
				SendPropertyChanged("Year");
			}
		}
	}

	[Column(Storage = "_idAreaOrganiz", DbType = "Int")]
	public int? idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (!_idAreaOrganiz.Equals(value))
			{
				if (_Estrategia.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idAreaOrganiz = value;
				SendPropertyChanged("idAreaOrganiz");
			}
		}
	}

	[Column(Storage = "_IdEstrategia", DbType = "Int")]
	public int? IdEstrategia
	{
		get
		{
			return _IdEstrategia;
		}
		set
		{
			if (!_IdEstrategia.Equals(value))
			{
				if (_Estrategia.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdEstrategia = value;
				SendPropertyChanged("IdEstrategia");
			}
		}
	}

	[Column(Name = "Objetivo", Storage = "_Objetivo", DbType = "VarChar(500) NOT NULL", CanBeNull = false)]
	public string ObjetivoValue
	{
		get
		{
			return _Objetivo;
		}
		set
		{
			if (!string.Equals(_Objetivo, value))
			{
				SendPropertyChanging();
				_Objetivo = value;
				SendPropertyChanged("Objetivo");
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

	[Column(Storage = "_FechaFin", DbType = "SmallDateTime NOT NULL")]
	public DateTime FechaFin
	{
		get
		{
			return _FechaFin;
		}
		set
		{
			if (DateTime.Compare(_FechaFin, value) != 0)
			{
				SendPropertyChanging();
				_FechaFin = value;
				SendPropertyChanged("FechaFin");
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

	[Column(Storage = "_AvanceAnual", DbType = "Decimal(11,2)")]
	public decimal? AvanceAnual
	{
		get
		{
			return _AvanceAnual;
		}
		set
		{
			if (!_AvanceAnual.Equals(value))
			{
				SendPropertyChanging();
				_AvanceAnual = value;
				SendPropertyChanged("AvanceAnual");
			}
		}
	}

	[Column(Storage = "_AvanceGlobal", DbType = "Decimal(11,2)")]
	public decimal? AvanceGlobal
	{
		get
		{
			return _AvanceGlobal;
		}
		set
		{
			if (!_AvanceGlobal.Equals(value))
			{
				SendPropertyChanging();
				_AvanceGlobal = value;
				SendPropertyChanged("AvanceGlobal");
			}
		}
	}

	[Column(Storage = "_Meta", DbType = "Decimal(11,2) NOT NULL")]
	public decimal Meta
	{
		get
		{
			return _Meta;
		}
		set
		{
			if (decimal.Compare(_Meta, value) != 0)
			{
				SendPropertyChanging();
				_Meta = value;
				SendPropertyChanged("Meta");
			}
		}
	}

	[Column(Storage = "_Importancia", DbType = "Int NOT NULL")]
	public int Importancia
	{
		get
		{
			return _Importancia;
		}
		set
		{
			if (_Importancia != value)
			{
				SendPropertyChanging();
				_Importancia = value;
				SendPropertyChanged("Importancia");
			}
		}
	}

	[Column(Storage = "_IdUnidMed", DbType = "Int")]
	public int? IdUnidMed
	{
		get
		{
			return _IdUnidMed;
		}
		set
		{
			if (!_IdUnidMed.Equals(value))
			{
				if (_UnidMed.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdUnidMed = value;
				SendPropertyChanged("IdUnidMed");
			}
		}
	}

	[Association(Name = "Estrategia_Objetivo", Storage = "_Estrategia", ThisKey = "Year,idAreaOrganiz,IdEstrategia", OtherKey = "Year,idAreaOrganiz,IdEstrategia", IsForeignKey = true)]
	public Estrategia Estrategia
	{
		get
		{
			return _Estrategia.Entity;
		}
		set
		{
			Estrategia previousValue = _Estrategia.Entity;
			if (!object.Equals(previousValue, value) || !_Estrategia.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_Estrategia.Entity = null;
					previousValue.Objetivo.Remove(this);
				}
				_Estrategia.Entity = value;
				if (value != null)
				{
					value.Objetivo.Add(this);
					_Year = value.Year;
					_idAreaOrganiz = value.idAreaOrganiz;
					_IdEstrategia = value.IdEstrategia;
				}
				else
				{
					_Year = null;
					_idAreaOrganiz = null;
					_IdEstrategia = null;
				}
				SendPropertyChanged("Estrategia");
			}
		}
	}

	[Association(Name = "UnidMed_Objetivo", Storage = "_UnidMed", ThisKey = "IdUnidMed", OtherKey = "IdUnidMed", IsForeignKey = true)]
	public UnidMed UnidMed
	{
		get
		{
			return _UnidMed.Entity;
		}
		set
		{
			UnidMed previousValue = _UnidMed.Entity;
			if (!object.Equals(previousValue, value) || !_UnidMed.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_UnidMed.Entity = null;
					previousValue.Objetivo.Remove(this);
				}
				_UnidMed.Entity = value;
				if (value != null)
				{
					value.Objetivo.Add(this);
					_IdUnidMed = value.IdUnidMed;
				}
				else
				{
					_IdUnidMed = null;
				}
				SendPropertyChanged("UnidMed");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Objetivo()
	{
		_Estrategia = default(EntityRef<Estrategia>);
		_UnidMed = default(EntityRef<UnidMed>);
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
