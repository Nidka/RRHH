using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.PlanMayor")]
public class PlanMayor : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _Years;

	private int _Codigo;

	private string _CodigoCtb;

	private string _Descripcion;

	private int? _YearsDe;

	private int? _CodigoDe;

	private EntitySet<IngresoCaj> _IngresoCaj;

	private EntitySet<IngresoCaj> _IngresoCaj1;

	private EntitySet<PlanMayor> _PlanMayor1;

	private EntityRef<PlanMayor> _PlanMayor;

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

	[Column(Storage = "_CodigoCtb", DbType = "VarChar(2)")]
	public string CodigoCtb
	{
		get
		{
			return _CodigoCtb;
		}
		set
		{
			if (!string.Equals(_CodigoCtb, value))
			{
				SendPropertyChanging();
				_CodigoCtb = value;
				SendPropertyChanged("CodigoCtb");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(250)")]
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
				if (_PlanMayor.HasLoadedOrAssignedValue)
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
				if (_PlanMayor.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_CodigoDe = value;
				SendPropertyChanged("CodigoDe");
			}
		}
	}

	[Association(Name = "PlanMayor_IngresoCaj", Storage = "_IngresoCaj", ThisKey = "Years,Codigo", OtherKey = "Years,Debe")]
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

	[Association(Name = "PlanMayor_IngresoCaj1", Storage = "_IngresoCaj1", ThisKey = "Years,Codigo", OtherKey = "Years,Haber")]
	public EntitySet<IngresoCaj> IngresoCaj1
	{
		get
		{
			return _IngresoCaj1;
		}
		set
		{
			_IngresoCaj1.Assign(value);
		}
	}

	[Association(Name = "PlanMayor_PlanMayor", Storage = "_PlanMayor1", ThisKey = "Years,Codigo", OtherKey = "YearsDe,CodigoDe")]
	public EntitySet<PlanMayor> PlanMayor1
	{
		get
		{
			return _PlanMayor1;
		}
		set
		{
			_PlanMayor1.Assign(value);
		}
	}

	[Association(Name = "PlanMayor_PlanMayor", Storage = "_PlanMayor", ThisKey = "YearsDe,CodigoDe", OtherKey = "Years,Codigo", IsForeignKey = true)]
	public PlanMayor ParentPlanMayor
	{
		get
		{
			return _PlanMayor.Entity;
		}
		set
		{
			PlanMayor previousValue = _PlanMayor.Entity;
			if (!object.Equals(previousValue, value) || !_PlanMayor.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_PlanMayor.Entity = null;
					previousValue.PlanMayor1.Remove(this);
				}
				_PlanMayor.Entity = value;
				if (value != null)
				{
					value.PlanMayor1.Add(this);
					_YearsDe = value.Years;
					_CodigoDe = value.Codigo;
				}
				else
				{
					_YearsDe = null;
					_CodigoDe = null;
				}
				SendPropertyChanged("PlanMayor");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public PlanMayor()
	{
		_IngresoCaj = new EntitySet<IngresoCaj>(attach_IngresoCaj, detach_IngresoCaj);
		_IngresoCaj1 = new EntitySet<IngresoCaj>(attach_IngresoCaj1, detach_IngresoCaj1);
		_PlanMayor1 = new EntitySet<PlanMayor>(attach_PlanMayor1, detach_PlanMayor1);
		_PlanMayor = default(EntityRef<PlanMayor>);
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

	private void attach_IngresoCaj(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.PlanMayor = this;
	}

	private void detach_IngresoCaj(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.PlanMayor = null;
	}

	private void attach_IngresoCaj1(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.PlanMayor1 = this;
	}

	private void detach_IngresoCaj1(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.PlanMayor1 = null;
	}

	private void attach_PlanMayor1(PlanMayor entity)
	{
		SendPropertyChanging();
		entity.ParentPlanMayor = this;
	}

	private void detach_PlanMayor1(PlanMayor entity)
	{
		SendPropertyChanging();
		entity.ParentPlanMayor = null;
	}
}
