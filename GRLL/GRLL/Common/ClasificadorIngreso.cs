using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.ClasificadorIngreso")]
public class ClasificadorIngreso : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _Years;

	private int _Codigo;

	private string _CodigoClasif;

	private string _Nombre;

	private char? _Estado;

	private char? _EsPresupuesto;

	private int? _YearsDe;

	private int? _CodigoDe;

	private EntitySet<ClasificadorIngreso> _ClasificadorIngreso1;

	private EntitySet<IngresoCaj> _IngresoCaj;

	private EntityRef<ClasificadorIngreso> _ClasificadorIngreso;

	[Column(Storage = "_Years", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int Years
	{
		get
		{
			return _Years;
		}
		set
		{
			if (_Years != value)
			{
				SendPropertyChanging();
				_Years = value;
				SendPropertyChanged("Years");
			}
		}
	}

	[Column(Storage = "_Codigo", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			if (_Codigo != value)
			{
				SendPropertyChanging();
				_Codigo = value;
				SendPropertyChanged("Codigo");
			}
		}
	}

	[Column(Storage = "_CodigoClasif", DbType = "VarChar(3)")]
	public string CodigoClasif
	{
		get
		{
			return _CodigoClasif;
		}
		set
		{
			if (!string.Equals(_CodigoClasif, value))
			{
				SendPropertyChanging();
				_CodigoClasif = value;
				SendPropertyChanged("CodigoClasif");
			}
		}
	}

	[Column(Storage = "_Nombre", DbType = "VarChar(200)")]
	public string Nombre
	{
		get
		{
			return _Nombre;
		}
		set
		{
			if (!string.Equals(_Nombre, value))
			{
				SendPropertyChanging();
				_Nombre = value;
				SendPropertyChanged("Nombre");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "VarChar(1)")]
	public char? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				SendPropertyChanging();
				_Estado = value;
				SendPropertyChanged("Estado");
			}
		}
	}

	[Column(Storage = "_EsPresupuesto", DbType = "VarChar(1)")]
	public char? EsPresupuesto
	{
		get
		{
			return _EsPresupuesto;
		}
		set
		{
			if (!_EsPresupuesto.Equals(value))
			{
				SendPropertyChanging();
				_EsPresupuesto = value;
				SendPropertyChanged("EsPresupuesto");
			}
		}
	}

	[Column(Storage = "_YearsDe", DbType = "Int")]
	public int? YearsDe
	{
		get
		{
			return _YearsDe;
		}
		set
		{
			if (!_YearsDe.Equals(value))
			{
				if (_ClasificadorIngreso.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_YearsDe = value;
				SendPropertyChanged("YearsDe");
			}
		}
	}

	[Column(Storage = "_CodigoDe", DbType = "Int")]
	public int? CodigoDe
	{
		get
		{
			return _CodigoDe;
		}
		set
		{
			if (!_CodigoDe.Equals(value))
			{
				if (_ClasificadorIngreso.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_CodigoDe = value;
				SendPropertyChanged("CodigoDe");
			}
		}
	}

	[Association(Name = "ClasificadorIngreso_ClasificadorIngreso", Storage = "_ClasificadorIngreso1", ThisKey = "Years,Codigo", OtherKey = "YearsDe,CodigoDe")]
	public EntitySet<ClasificadorIngreso> ClasificadorIngreso1
	{
		get
		{
			return _ClasificadorIngreso1;
		}
		set
		{
			_ClasificadorIngreso1.Assign(value);
		}
	}

	[Association(Name = "ClasificadorIngreso_IngresoCaj", Storage = "_IngresoCaj", ThisKey = "Years,Codigo", OtherKey = "Years,Codigo")]
	public EntitySet<IngresoCaj> IngresoCaj
	{
		get
		{
			return _IngresoCaj;
		}
		set
		{
			_IngresoCaj.Assign(value);
		}
	}

	[Association(Name = "ClasificadorIngreso_ClasificadorIngreso", Storage = "_ClasificadorIngreso", ThisKey = "YearsDe,CodigoDe", OtherKey = "Years,Codigo", IsForeignKey = true)]
	public ClasificadorIngreso ParentClasificadorIngreso
	{
		get
		{
			return _ClasificadorIngreso.Entity;
		}
		set
		{
			ClasificadorIngreso previousValue = _ClasificadorIngreso.Entity;
			if (!object.Equals(previousValue, value) || !_ClasificadorIngreso.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_ClasificadorIngreso.Entity = null;
					previousValue.ClasificadorIngreso1.Remove(this);
				}
				_ClasificadorIngreso.Entity = value;
				if (value != null)
				{
					value.ClasificadorIngreso1.Add(this);
					_YearsDe = value.Years;
					_CodigoDe = value.Codigo;
				}
				else
				{
					_YearsDe = null;
					_CodigoDe = null;
				}
				SendPropertyChanged("ClasificadorIngreso");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public ClasificadorIngreso()
	{
		_ClasificadorIngreso1 = new EntitySet<ClasificadorIngreso>(attach_ClasificadorIngreso1, detach_ClasificadorIngreso1);
		_IngresoCaj = new EntitySet<IngresoCaj>(attach_IngresoCaj, detach_IngresoCaj);
		_ClasificadorIngreso = default(EntityRef<ClasificadorIngreso>);
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

	private void attach_ClasificadorIngreso1(ClasificadorIngreso entity)
	{
		SendPropertyChanging();
		entity.ParentClasificadorIngreso = this;
	}

	private void detach_ClasificadorIngreso1(ClasificadorIngreso entity)
	{
		SendPropertyChanging();
		entity.ParentClasificadorIngreso = null;
	}

	private void attach_IngresoCaj(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.ClasificadorIngreso = this;
	}

	private void detach_IngresoCaj(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.ClasificadorIngreso = null;
	}
}
