using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.TRAEtapa_Procedimiento")]
public class TRAEtapa_Procedimiento : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private string _IdEtapaProc;

	private string _Descripcion;

	private int? _TiempoHrs;

	private int? _TiempoMin;

	private int? _TiempoDias;

	private string _IdTipoDoc;

	private string _Observaciones;

	private int? _Year;

	private int? _idAreaOrganiz;

	private string _IdProcedimiento;

	private byte? _Item;

	private string _EtapaAnterior;

	private decimal? _AvisoHrs;

	private int? _IdCargo;

	private string _SecStandard;

	private string _SecAlterna;

	private char? _TipoEtapa;

	private bool? _Estado;

	private EntitySet<TRAEtapa_Cargo> _TRAEtapa_Cargo;

	private EntitySet<TRAMovimiento> _TRAMovimiento;

	private EntityRef<EstructOrganiz> _EstructOrganiz;

	private EntityRef<TRAProcedimiento> _TRAProcedimiento;

	[Column(Storage = "_IdEtapaProc", DbType = "Char(8) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
	public string IdEtapaProc
	{
		get
		{
			return _IdEtapaProc;
		}
		set
		{
			if (!string.Equals(_IdEtapaProc, value))
			{
				SendPropertyChanging();
				_IdEtapaProc = value;
				SendPropertyChanged("IdEtapaProc");
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(400)")]
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

	[Column(Storage = "_TiempoHrs", DbType = "Int")]
	public int? TiempoHrs
	{
		get
		{
			return _TiempoHrs;
		}
		set
		{
			if (!_TiempoHrs.Equals(value))
			{
				SendPropertyChanging();
				_TiempoHrs = value;
				SendPropertyChanged("TiempoHrs");
			}
		}
	}

	[Column(Storage = "_TiempoMin", DbType = "Int")]
	public int? TiempoMin
	{
		get
		{
			return _TiempoMin;
		}
		set
		{
			if (!_TiempoMin.Equals(value))
			{
				SendPropertyChanging();
				_TiempoMin = value;
				SendPropertyChanged("TiempoMin");
			}
		}
	}

	[Column(Storage = "_TiempoDias", DbType = "Int")]
	public int? TiempoDias
	{
		get
		{
			return _TiempoDias;
		}
		set
		{
			if (!_TiempoDias.Equals(value))
			{
				SendPropertyChanging();
				_TiempoDias = value;
				SendPropertyChanged("TiempoDias");
			}
		}
	}

	[Column(Storage = "_IdTipoDoc", DbType = "Char(2)")]
	public string IdTipoDoc
	{
		get
		{
			return _IdTipoDoc;
		}
		set
		{
			if (!string.Equals(_IdTipoDoc, value))
			{
				SendPropertyChanging();
				_IdTipoDoc = value;
				SendPropertyChanged("IdTipoDoc");
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(400)")]
	public string Observaciones
	{
		get
		{
			return _Observaciones;
		}
		set
		{
			if (!string.Equals(_Observaciones, value))
			{
				SendPropertyChanging();
				_Observaciones = value;
				SendPropertyChanged("Observaciones");
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

	[Column(Storage = "_IdProcedimiento", DbType = "Char(6)")]
	public string IdProcedimiento
	{
		get
		{
			return _IdProcedimiento;
		}
		set
		{
			if (!string.Equals(_IdProcedimiento, value))
			{
				if (_TRAProcedimiento.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_IdProcedimiento = value;
				SendPropertyChanged("IdProcedimiento");
			}
		}
	}

	[Column(Storage = "_Item", DbType = "TinyInt")]
	public byte? Item
	{
		get
		{
			return _Item;
		}
		set
		{
			if (!_Item.Equals(value))
			{
				SendPropertyChanging();
				_Item = value;
				SendPropertyChanged("Item");
			}
		}
	}

	[Column(Storage = "_EtapaAnterior", DbType = "Char(8)")]
	public string EtapaAnterior
	{
		get
		{
			return _EtapaAnterior;
		}
		set
		{
			if (!string.Equals(_EtapaAnterior, value))
			{
				SendPropertyChanging();
				_EtapaAnterior = value;
				SendPropertyChanged("EtapaAnterior");
			}
		}
	}

	[Column(Storage = "_AvisoHrs", DbType = "Decimal(9,2)")]
	public decimal? AvisoHrs
	{
		get
		{
			return _AvisoHrs;
		}
		set
		{
			if (!_AvisoHrs.Equals(value))
			{
				SendPropertyChanging();
				_AvisoHrs = value;
				SendPropertyChanged("AvisoHrs");
			}
		}
	}

	[Column(Storage = "_IdCargo", DbType = "Int")]
	public int? IdCargo
	{
		get
		{
			return _IdCargo;
		}
		set
		{
			if (!_IdCargo.Equals(value))
			{
				SendPropertyChanging();
				_IdCargo = value;
				SendPropertyChanged("IdCargo");
			}
		}
	}

	[Column(Storage = "_SecStandard", DbType = "Char(8)")]
	public string SecStandard
	{
		get
		{
			return _SecStandard;
		}
		set
		{
			if (!string.Equals(_SecStandard, value))
			{
				SendPropertyChanging();
				_SecStandard = value;
				SendPropertyChanged("SecStandard");
			}
		}
	}

	[Column(Storage = "_SecAlterna", DbType = "Char(8)")]
	public string SecAlterna
	{
		get
		{
			return _SecAlterna;
		}
		set
		{
			if (!string.Equals(_SecAlterna, value))
			{
				SendPropertyChanging();
				_SecAlterna = value;
				SendPropertyChanged("SecAlterna");
			}
		}
	}

	[Column(Storage = "_TipoEtapa", DbType = "Char(1)")]
	public char? TipoEtapa
	{
		get
		{
			return _TipoEtapa;
		}
		set
		{
			if (!_TipoEtapa.Equals(value))
			{
				SendPropertyChanging();
				_TipoEtapa = value;
				SendPropertyChanged("TipoEtapa");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Bit")]
	public bool? Estado
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

	[Association(Name = "TRAEtapa_Procedimiento_TRAEtapa_Cargo", Storage = "_TRAEtapa_Cargo", ThisKey = "IdEtapaProc", OtherKey = "IdEtapaProc")]
	public EntitySet<TRAEtapa_Cargo> TRAEtapa_Cargo
	{
		get
		{
			return _TRAEtapa_Cargo;
		}
		set
		{
			_TRAEtapa_Cargo.Assign(value);
		}
	}

	[Association(Name = "TRAEtapa_Procedimiento_TRAMovimiento", Storage = "_TRAMovimiento", ThisKey = "IdEtapaProc", OtherKey = "IdEtapaProc")]
	public EntitySet<TRAMovimiento> TRAMovimiento
	{
		get
		{
			return _TRAMovimiento;
		}
		set
		{
			_TRAMovimiento.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_TRAEtapa_Procedimiento", Storage = "_EstructOrganiz", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz", IsForeignKey = true)]
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
					previousValue.TRAEtapa_Procedimiento.Remove(this);
				}
				_EstructOrganiz.Entity = value;
				if (value != null)
				{
					value.TRAEtapa_Procedimiento.Add(this);
					_Year = value.Year;
					_idAreaOrganiz = value.idAreaOrganiz;
				}
				else
				{
					_Year = null;
					_idAreaOrganiz = null;
				}
				SendPropertyChanged("EstructOrganiz");
			}
		}
	}

	[Association(Name = "TRAProcedimiento_TRAEtapa_Procedimiento", Storage = "_TRAProcedimiento", ThisKey = "IdProcedimiento", OtherKey = "IdProcedimiento", IsForeignKey = true)]
	public TRAProcedimiento TRAProcedimiento
	{
		get
		{
			return _TRAProcedimiento.Entity;
		}
		set
		{
			TRAProcedimiento previousValue = _TRAProcedimiento.Entity;
			if (!object.Equals(previousValue, value) || !_TRAProcedimiento.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_TRAProcedimiento.Entity = null;
					previousValue.TRAEtapa_Procedimiento.Remove(this);
				}
				_TRAProcedimiento.Entity = value;
				if (value != null)
				{
					value.TRAEtapa_Procedimiento.Add(this);
					_IdProcedimiento = value.IdProcedimiento;
				}
				else
				{
					_IdProcedimiento = null;
				}
				SendPropertyChanged("TRAProcedimiento");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public TRAEtapa_Procedimiento()
	{
		_TRAEtapa_Cargo = new EntitySet<TRAEtapa_Cargo>(attach_TRAEtapa_Cargo, detach_TRAEtapa_Cargo);
		_TRAMovimiento = new EntitySet<TRAMovimiento>(attach_TRAMovimiento, detach_TRAMovimiento);
		_EstructOrganiz = default(EntityRef<EstructOrganiz>);
		_TRAProcedimiento = default(EntityRef<TRAProcedimiento>);
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

	private void attach_TRAEtapa_Cargo(TRAEtapa_Cargo entity)
	{
		SendPropertyChanging();
		entity.TRAEtapa_Procedimiento = this;
	}

	private void detach_TRAEtapa_Cargo(TRAEtapa_Cargo entity)
	{
		SendPropertyChanging();
		entity.TRAEtapa_Procedimiento = null;
	}

	private void attach_TRAMovimiento(TRAMovimiento entity)
	{
		SendPropertyChanging();
		entity.TRAEtapa_Procedimiento = this;
	}

	private void detach_TRAMovimiento(TRAMovimiento entity)
	{
		SendPropertyChanging();
		entity.TRAEtapa_Procedimiento = null;
	}
}
