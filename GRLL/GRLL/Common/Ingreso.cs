using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Ingreso")]
public class Ingreso : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdIngreso;

	private int? _IdEmpleado;

	private decimal? _Remuneracion;

	private decimal? _Honorarios;

	private decimal? _AlqPredio;

	private decimal? _AlqBienes;

	private decimal? _CapitalesColocados;

	private decimal? _Dietas;

	private decimal? _Negocios;

	private decimal? _Otros;

	private decimal? _IngresoMiembros;

	private string _NumPersonaAportan;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_IdIngreso", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdIngreso
	{
		get
		{
			return _IdIngreso;
		}
		set
		{
			if (_IdIngreso != value)
			{
				SendPropertyChanging();
				_IdIngreso = value;
				SendPropertyChanged("IdIngreso");
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

	[Column(Storage = "_Remuneracion", DbType = "Decimal(8,2)")]
	public decimal? Remuneracion
	{
		get
		{
			return _Remuneracion;
		}
		set
		{
			if (!_Remuneracion.Equals(value))
			{
				SendPropertyChanging();
				_Remuneracion = value;
				SendPropertyChanged("Remuneracion");
			}
		}
	}

	[Column(Storage = "_Honorarios", DbType = "Decimal(8,2)")]
	public decimal? Honorarios
	{
		get
		{
			return _Honorarios;
		}
		set
		{
			if (!_Honorarios.Equals(value))
			{
				SendPropertyChanging();
				_Honorarios = value;
				SendPropertyChanged("Honorarios");
			}
		}
	}

	[Column(Storage = "_AlqPredio", DbType = "Decimal(8,2)")]
	public decimal? AlqPredio
	{
		get
		{
			return _AlqPredio;
		}
		set
		{
			if (!_AlqPredio.Equals(value))
			{
				SendPropertyChanging();
				_AlqPredio = value;
				SendPropertyChanged("AlqPredio");
			}
		}
	}

	[Column(Storage = "_AlqBienes", DbType = "Decimal(8,2)")]
	public decimal? AlqBienes
	{
		get
		{
			return _AlqBienes;
		}
		set
		{
			if (!_AlqBienes.Equals(value))
			{
				SendPropertyChanging();
				_AlqBienes = value;
				SendPropertyChanged("AlqBienes");
			}
		}
	}

	[Column(Storage = "_CapitalesColocados", DbType = "Decimal(8,2)")]
	public decimal? CapitalesColocados
	{
		get
		{
			return _CapitalesColocados;
		}
		set
		{
			if (!_CapitalesColocados.Equals(value))
			{
				SendPropertyChanging();
				_CapitalesColocados = value;
				SendPropertyChanged("CapitalesColocados");
			}
		}
	}

	[Column(Storage = "_Dietas", DbType = "Decimal(8,2)")]
	public decimal? Dietas
	{
		get
		{
			return _Dietas;
		}
		set
		{
			if (!_Dietas.Equals(value))
			{
				SendPropertyChanging();
				_Dietas = value;
				SendPropertyChanged("Dietas");
			}
		}
	}

	[Column(Storage = "_Negocios", DbType = "Decimal(8,2)")]
	public decimal? Negocios
	{
		get
		{
			return _Negocios;
		}
		set
		{
			if (!_Negocios.Equals(value))
			{
				SendPropertyChanging();
				_Negocios = value;
				SendPropertyChanged("Negocios");
			}
		}
	}

	[Column(Storage = "_Otros", DbType = "Decimal(8,2)")]
	public decimal? Otros
	{
		get
		{
			return _Otros;
		}
		set
		{
			if (!_Otros.Equals(value))
			{
				SendPropertyChanging();
				_Otros = value;
				SendPropertyChanged("Otros");
			}
		}
	}

	[Column(Storage = "_IngresoMiembros", DbType = "Decimal(8,2)")]
	public decimal? IngresoMiembros
	{
		get
		{
			return _IngresoMiembros;
		}
		set
		{
			if (!_IngresoMiembros.Equals(value))
			{
				SendPropertyChanging();
				_IngresoMiembros = value;
				SendPropertyChanged("IngresoMiembros");
			}
		}
	}

	[Column(Storage = "_NumPersonaAportan", DbType = "VarChar(2)")]
	public string NumPersonaAportan
	{
		get
		{
			return _NumPersonaAportan;
		}
		set
		{
			if (!string.Equals(_NumPersonaAportan, value))
			{
				SendPropertyChanging();
				_NumPersonaAportan = value;
				SendPropertyChanged("NumPersonaAportan");
			}
		}
	}

	[Association(Name = "Empleado_Ingreso", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.Ingresos.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Ingresos.Add(this);
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

	public Ingreso()
	{
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
