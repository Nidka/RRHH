using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Actividad")]
public class Actividad : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdObjetivo;

	private int _IdActividad;

	private int? _NroActividad;

	private string _Actividad;

	private int? _IdEmpleado;

	private int? _IdUnidMed;

	private decimal _Meta;

	private char? _IsMeta;

	private decimal? _MetaMin;

	private int? _TrabXActiv;

	private decimal? _HH;

	private decimal? _BienServ;

	private int _Importancia;

	private decimal? _Avance;

	private decimal? _AvanceAnual;

	private DateTime _FechaInicio;

	private DateTime _FechaFin;

	private string _UnidsOrgs;

	private int? _IdPresupuesto;

	private string _Observacion;

	private EntitySet<Inconveniente> _Inconveniente;

	private EntitySet<ProgramMes> _ProgramMes;

	private EntityRef<UnidMed> _UnidMed;

	private EntityRef<Empleado> _Empleado;

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

	[Column(Storage = "_IdActividad", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdActividad
	{
		get
		{
			return _IdActividad;
		}
		set
		{
			if (_IdActividad != value)
			{
				SendPropertyChanging();
				_IdActividad = value;
				SendPropertyChanged("IdActividad");
			}
		}
	}

	[Column(Storage = "_NroActividad", DbType = "Int")]
	public int? NroActividad
	{
		get
		{
			return _NroActividad;
		}
		set
		{
			if (!_NroActividad.Equals(value))
			{
				SendPropertyChanging();
				_NroActividad = value;
				SendPropertyChanged("NroActividad");
			}
		}
	}

	[Column(Name = "Actividad", Storage = "_Actividad", DbType = "VarChar(300) NOT NULL", CanBeNull = false)]
	public string ActividadValue
	{
		get
		{
			return _Actividad;
		}
		set
		{
			if (!string.Equals(_Actividad, value))
			{
				SendPropertyChanging();
				_Actividad = value;
				SendPropertyChanged("Actividad");
			}
		}
	}

	[Column(Storage = "_IdEmpleado", DbType = "Int")]
	public int? IdEmpleado
	{
		get
		{
			return _IdEmpleado;
		}
		set
		{
			if (!_IdEmpleado.Equals(value))
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

	[Column(Storage = "_IsMeta", DbType = "VarChar(1)")]
	public char? IsMeta
	{
		get
		{
			return _IsMeta;
		}
		set
		{
			if (!_IsMeta.Equals(value))
			{
				SendPropertyChanging();
				_IsMeta = value;
				SendPropertyChanged("IsMeta");
			}
		}
	}

	[Column(Storage = "_MetaMin", DbType = "Decimal(11,2)")]
	public decimal? MetaMin
	{
		get
		{
			return _MetaMin;
		}
		set
		{
			if (!_MetaMin.Equals(value))
			{
				SendPropertyChanging();
				_MetaMin = value;
				SendPropertyChanged("MetaMin");
			}
		}
	}

	[Column(Storage = "_TrabXActiv", DbType = "Int")]
	public int? TrabXActiv
	{
		get
		{
			return _TrabXActiv;
		}
		set
		{
			if (!_TrabXActiv.Equals(value))
			{
				SendPropertyChanging();
				_TrabXActiv = value;
				SendPropertyChanged("TrabXActiv");
			}
		}
	}

	[Column(Storage = "_HH", DbType = "Decimal(9,2)")]
	public decimal? HH
	{
		get
		{
			return _HH;
		}
		set
		{
			if (!_HH.Equals(value))
			{
				SendPropertyChanging();
				_HH = value;
				SendPropertyChanged("HH");
			}
		}
	}

	[Column(Storage = "_BienServ", DbType = "Decimal(9,2)")]
	public decimal? BienServ
	{
		get
		{
			return _BienServ;
		}
		set
		{
			if (!_BienServ.Equals(value))
			{
				SendPropertyChanging();
				_BienServ = value;
				SendPropertyChanged("BienServ");
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

	[Column(Storage = "_Avance", DbType = "Decimal(11,2)")]
	public decimal? Avance
	{
		get
		{
			return _Avance;
		}
		set
		{
			if (!_Avance.Equals(value))
			{
				SendPropertyChanging();
				_Avance = value;
				SendPropertyChanged("Avance");
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

	[Column(Storage = "_UnidsOrgs", DbType = "VarChar(20)")]
	public string UnidsOrgs
	{
		get
		{
			return _UnidsOrgs;
		}
		set
		{
			if (!string.Equals(_UnidsOrgs, value))
			{
				SendPropertyChanging();
				_UnidsOrgs = value;
				SendPropertyChanged("UnidsOrgs");
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

	[Column(Storage = "_Observacion", DbType = "VarChar(500)")]
	public string Observacion
	{
		get
		{
			return _Observacion;
		}
		set
		{
			if (!string.Equals(_Observacion, value))
			{
				SendPropertyChanging();
				_Observacion = value;
				SendPropertyChanged("Observacion");
			}
		}
	}

	[Association(Name = "Actividad_Inconveniente", Storage = "_Inconveniente", ThisKey = "IdObjetivo,IdActividad", OtherKey = "IdObjetivo,Id_Actividad")]
	public EntitySet<Inconveniente> Inconveniente
	{
		get
		{
			return _Inconveniente;
		}
		set
		{
			_Inconveniente.Assign(value);
		}
	}

	[Association(Name = "Actividad_ProgramMes", Storage = "_ProgramMes", ThisKey = "IdObjetivo,IdActividad", OtherKey = "IdObjetivo,IdActividad")]
	public EntitySet<ProgramMes> ProgramMes
	{
		get
		{
			return _ProgramMes;
		}
		set
		{
			_ProgramMes.Assign(value);
		}
	}

	[Association(Name = "UnidMed_Actividad", Storage = "_UnidMed", ThisKey = "IdUnidMed", OtherKey = "IdUnidMed", IsForeignKey = true)]
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
					previousValue.Actividad.Remove(this);
				}
				_UnidMed.Entity = value;
				if (value != null)
				{
					value.Actividad.Add(this);
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

	[Association(Name = "Empleado_Actividad", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.Actividads.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Actividads.Add(this);
					_IdEmpleado = value.IdEmpleado;
				}
				else
				{
					_IdEmpleado = null;
				}
				SendPropertyChanged("Empleado");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Actividad()
	{
		_Inconveniente = new EntitySet<Inconveniente>(attach_Inconveniente, detach_Inconveniente);
		_ProgramMes = new EntitySet<ProgramMes>(attach_ProgramMes, detach_ProgramMes);
		_UnidMed = default(EntityRef<UnidMed>);
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

	private void attach_Inconveniente(Inconveniente entity)
	{
		SendPropertyChanging();
		entity.Actividad = this;
	}

	private void detach_Inconveniente(Inconveniente entity)
	{
		SendPropertyChanging();
		entity.Actividad = null;
	}

	private void attach_ProgramMes(ProgramMes entity)
	{
		SendPropertyChanging();
		entity.Actividad = this;
	}

	private void detach_ProgramMes(ProgramMes entity)
	{
		SendPropertyChanging();
		entity.Actividad = null;
	}
}
