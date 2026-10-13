using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Egreso")]
public class Egreso : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int? _IdEmpleado;

	private int _IdEgreso;

	private decimal? _Alimentacion;

	private decimal? _Vivienda;

	private decimal? _Educacion;

	private decimal? _Salud;

	private decimal? _Vestido;

	private decimal? _Recreacion;

	private decimal? _Prestamos;

	private decimal? _Otros;

	private decimal? _Transporte;

	private decimal? _EnergiaElec;

	private decimal? _Agua;

	private decimal? _BajaPolicia;

	private decimal? _Telefono;

	private decimal? _SeguroPriv;

	private decimal? _TarjCredito;

	private EntityRef<Empleado> _Empleado;

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

	[Column(Storage = "_IdEgreso", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdEgreso
	{
		get
		{
			return _IdEgreso;
		}
		set
		{
			if (_IdEgreso != value)
			{
				SendPropertyChanging();
				_IdEgreso = value;
				SendPropertyChanged("IdEgreso");
			}
		}
	}

	[Column(Storage = "_Alimentacion", DbType = "Decimal(8,2)")]
	public decimal? Alimentacion
	{
		get
		{
			return _Alimentacion;
		}
		set
		{
			if (!_Alimentacion.Equals(value))
			{
				SendPropertyChanging();
				_Alimentacion = value;
				SendPropertyChanged("Alimentacion");
			}
		}
	}

	[Column(Storage = "_Vivienda", DbType = "Decimal(8,2)")]
	public decimal? Vivienda
	{
		get
		{
			return _Vivienda;
		}
		set
		{
			if (!_Vivienda.Equals(value))
			{
				SendPropertyChanging();
				_Vivienda = value;
				SendPropertyChanged("Vivienda");
			}
		}
	}

	[Column(Storage = "_Educacion", DbType = "Decimal(8,2)")]
	public decimal? Educacion
	{
		get
		{
			return _Educacion;
		}
		set
		{
			if (!_Educacion.Equals(value))
			{
				SendPropertyChanging();
				_Educacion = value;
				SendPropertyChanged("Educacion");
			}
		}
	}

	[Column(Storage = "_Salud", DbType = "Decimal(8,2)")]
	public decimal? Salud
	{
		get
		{
			return _Salud;
		}
		set
		{
			if (!_Salud.Equals(value))
			{
				SendPropertyChanging();
				_Salud = value;
				SendPropertyChanged("Salud");
			}
		}
	}

	[Column(Storage = "_Vestido", DbType = "Decimal(8,2)")]
	public decimal? Vestido
	{
		get
		{
			return _Vestido;
		}
		set
		{
			if (!_Vestido.Equals(value))
			{
				SendPropertyChanging();
				_Vestido = value;
				SendPropertyChanged("Vestido");
			}
		}
	}

	[Column(Storage = "_Recreacion", DbType = "Decimal(8,2)")]
	public decimal? Recreacion
	{
		get
		{
			return _Recreacion;
		}
		set
		{
			if (!_Recreacion.Equals(value))
			{
				SendPropertyChanging();
				_Recreacion = value;
				SendPropertyChanged("Recreacion");
			}
		}
	}

	[Column(Storage = "_Prestamos", DbType = "Decimal(8,2)")]
	public decimal? Prestamos
	{
		get
		{
			return _Prestamos;
		}
		set
		{
			if (!_Prestamos.Equals(value))
			{
				SendPropertyChanging();
				_Prestamos = value;
				SendPropertyChanged("Prestamos");
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

	[Column(Storage = "_Transporte", DbType = "Decimal(8,2)")]
	public decimal? Transporte
	{
		get
		{
			return _Transporte;
		}
		set
		{
			if (!_Transporte.Equals(value))
			{
				SendPropertyChanging();
				_Transporte = value;
				SendPropertyChanged("Transporte");
			}
		}
	}

	[Column(Storage = "_EnergiaElec", DbType = "Decimal(8,2)")]
	public decimal? EnergiaElec
	{
		get
		{
			return _EnergiaElec;
		}
		set
		{
			if (!_EnergiaElec.Equals(value))
			{
				SendPropertyChanging();
				_EnergiaElec = value;
				SendPropertyChanged("EnergiaElec");
			}
		}
	}

	[Column(Storage = "_Agua", DbType = "Decimal(8,2)")]
	public decimal? Agua
	{
		get
		{
			return _Agua;
		}
		set
		{
			if (!_Agua.Equals(value))
			{
				SendPropertyChanging();
				_Agua = value;
				SendPropertyChanged("Agua");
			}
		}
	}

	[Column(Storage = "_BajaPolicia", DbType = "Decimal(8,2)")]
	public decimal? BajaPolicia
	{
		get
		{
			return _BajaPolicia;
		}
		set
		{
			if (!_BajaPolicia.Equals(value))
			{
				SendPropertyChanging();
				_BajaPolicia = value;
				SendPropertyChanged("BajaPolicia");
			}
		}
	}

	[Column(Storage = "_Telefono", DbType = "Decimal(8,2)")]
	public decimal? Telefono
	{
		get
		{
			return _Telefono;
		}
		set
		{
			if (!_Telefono.Equals(value))
			{
				SendPropertyChanging();
				_Telefono = value;
				SendPropertyChanged("Telefono");
			}
		}
	}

	[Column(Storage = "_SeguroPriv", DbType = "Decimal(8,2)")]
	public decimal? SeguroPriv
	{
		get
		{
			return _SeguroPriv;
		}
		set
		{
			if (!_SeguroPriv.Equals(value))
			{
				SendPropertyChanging();
				_SeguroPriv = value;
				SendPropertyChanged("SeguroPriv");
			}
		}
	}

	[Column(Storage = "_TarjCredito", DbType = "Decimal(8,2)")]
	public decimal? TarjCredito
	{
		get
		{
			return _TarjCredito;
		}
		set
		{
			if (!_TarjCredito.Equals(value))
			{
				SendPropertyChanging();
				_TarjCredito = value;
				SendPropertyChanged("TarjCredito");
			}
		}
	}

	[Association(Name = "Empleado_Egreso", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.Egresos.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.Egresos.Add(this);
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

	public Egreso()
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
