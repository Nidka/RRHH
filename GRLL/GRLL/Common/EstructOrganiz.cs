using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.EstructOrganiz")]
public class EstructOrganiz : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _Year;

	private int _idAreaOrganiz;

	private string _AreaOrganizacional;

	private string _Abrev;

	private string _Sigla;

	private decimal? _PresupAnual;

	private decimal? _PromedMensSueld;

	private int? _NroTrabajaUO;

	private string _Mision;

	private string _Vision;

	private int? _IdPresupuesto;

	private int? _YearDe;

	private int? _idDependeDe;

	private int? _IdEmpleado;

	private decimal? _InversPublic;

	private char? _ApruebaPedido;

	private decimal? _MontoAprobacion;

	private decimal? _PresupCompra;

	private decimal? _PresupUtilizado;

	private EntitySet<Alerta> _Alerta;

	private EntitySet<Empleado_Area> _Empleado_Area;

	private EntitySet<Estrategia> _Estrategia;

	private EntitySet<EstructOrganiz> _EstructOrganiz1;

	private EntitySet<EvaluacionGestion> _EvaluacionGestion;

	private EntitySet<InversPublica> _InversPublica;

	private EntitySet<Logros> _Logros;

	private EntitySet<Meta_Area> _Meta_Area;

	private EntitySet<Recomendacion> _Recomendacion;

	private EntitySet<TRANumeracion> _TRANumeracion;

	private EntitySet<TRAEtapa_Procedimiento> _TRAEtapa_Procedimiento;

	private EntitySet<Empleado> _Empleados;

	private EntitySet<Rotacion> _Rotacions;

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
				SendPropertyChanging();
				_idAreaOrganiz = value;
				SendPropertyChanged("idAreaOrganiz");
			}
		}
	}

	[Column(Storage = "_AreaOrganizacional", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string AreaOrganizacional
	{
		get
		{
			return _AreaOrganizacional;
		}
		set
		{
			if (!string.Equals(_AreaOrganizacional, value))
			{
				SendPropertyChanging();
				_AreaOrganizacional = value;
				SendPropertyChanged("AreaOrganizacional");
			}
		}
	}

	[Column(Storage = "_Abrev", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
	public string Abrev
	{
		get
		{
			return _Abrev;
		}
		set
		{
			if (!string.Equals(_Abrev, value))
			{
				SendPropertyChanging();
				_Abrev = value;
				SendPropertyChanged("Abrev");
			}
		}
	}

	[Column(Storage = "_Sigla", DbType = "VarChar(6) NOT NULL", CanBeNull = false)]
	public string Sigla
	{
		get
		{
			return _Sigla;
		}
		set
		{
			if (!string.Equals(_Sigla, value))
			{
				SendPropertyChanging();
				_Sigla = value;
				SendPropertyChanged("Sigla");
			}
		}
	}

	[Column(Storage = "_PresupAnual", DbType = "Decimal(11,2)")]
	public decimal? PresupAnual
	{
		get
		{
			return _PresupAnual;
		}
		set
		{
			if (!_PresupAnual.Equals(value))
			{
				SendPropertyChanging();
				_PresupAnual = value;
				SendPropertyChanged("PresupAnual");
			}
		}
	}

	[Column(Storage = "_PromedMensSueld", DbType = "Decimal(11,2)")]
	public decimal? PromedMensSueld
	{
		get
		{
			return _PromedMensSueld;
		}
		set
		{
			if (!_PromedMensSueld.Equals(value))
			{
				SendPropertyChanging();
				_PromedMensSueld = value;
				SendPropertyChanged("PromedMensSueld");
			}
		}
	}

	[Column(Storage = "_NroTrabajaUO", DbType = "Int")]
	public int? NroTrabajaUO
	{
		get
		{
			return _NroTrabajaUO;
		}
		set
		{
			if (!_NroTrabajaUO.Equals(value))
			{
				SendPropertyChanging();
				_NroTrabajaUO = value;
				SendPropertyChanged("NroTrabajaUO");
			}
		}
	}

	[Column(Storage = "_Mision", DbType = "VarChar(1000)")]
	public string Mision
	{
		get
		{
			return _Mision;
		}
		set
		{
			if (!string.Equals(_Mision, value))
			{
				SendPropertyChanging();
				_Mision = value;
				SendPropertyChanged("Mision");
			}
		}
	}

	[Column(Storage = "_Vision", DbType = "VarChar(1000)")]
	public string Vision
	{
		get
		{
			return _Vision;
		}
		set
		{
			if (!string.Equals(_Vision, value))
			{
				SendPropertyChanging();
				_Vision = value;
				SendPropertyChanged("Vision");
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

	[Column(Storage = "_YearDe", DbType = "Int")]
	public int? YearDe
	{
		get
		{
			return _YearDe;
		}
		set
		{
			if (!_YearDe.Equals(value))
			{
				if (_EstructOrganiz.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_YearDe = value;
				SendPropertyChanged("YearDe");
			}
		}
	}

	[Column(Storage = "_idDependeDe", DbType = "Int")]
	public int? idDependeDe
	{
		get
		{
			return _idDependeDe;
		}
		set
		{
			if (!_idDependeDe.Equals(value))
			{
				if (_EstructOrganiz.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idDependeDe = value;
				SendPropertyChanged("idDependeDe");
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
				SendPropertyChanging();
				_IdEmpleado = value;
				SendPropertyChanged("IdEmpleado");
			}
		}
	}

	[Column(Storage = "_InversPublic", DbType = "Decimal(11,2)")]
	public decimal? InversPublic
	{
		get
		{
			return _InversPublic;
		}
		set
		{
			if (!_InversPublic.Equals(value))
			{
				SendPropertyChanging();
				_InversPublic = value;
				SendPropertyChanged("InversPublic");
			}
		}
	}

	[Column(Storage = "_ApruebaPedido", DbType = "Char(1)")]
	public char? ApruebaPedido
	{
		get
		{
			return _ApruebaPedido;
		}
		set
		{
			if (!_ApruebaPedido.Equals(value))
			{
				SendPropertyChanging();
				_ApruebaPedido = value;
				SendPropertyChanged("ApruebaPedido");
			}
		}
	}

	[Column(Storage = "_MontoAprobacion", DbType = "Decimal(18,2)")]
	public decimal? MontoAprobacion
	{
		get
		{
			return _MontoAprobacion;
		}
		set
		{
			if (!_MontoAprobacion.Equals(value))
			{
				SendPropertyChanging();
				_MontoAprobacion = value;
				SendPropertyChanged("MontoAprobacion");
			}
		}
	}

	[Column(Storage = "_PresupCompra", DbType = "Decimal(11,2)")]
	public decimal? PresupCompra
	{
		get
		{
			return _PresupCompra;
		}
		set
		{
			if (!_PresupCompra.Equals(value))
			{
				SendPropertyChanging();
				_PresupCompra = value;
				SendPropertyChanged("PresupCompra");
			}
		}
	}

	[Column(Storage = "_PresupUtilizado", DbType = "Decimal(11,2)")]
	public decimal? PresupUtilizado
	{
		get
		{
			return _PresupUtilizado;
		}
		set
		{
			if (!_PresupUtilizado.Equals(value))
			{
				SendPropertyChanging();
				_PresupUtilizado = value;
				SendPropertyChanged("PresupUtilizado");
			}
		}
	}

	[Association(Name = "EstructOrganiz_Alerta", Storage = "_Alerta", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz")]
	public EntitySet<Alerta> Alerta
	{
		get
		{
			return _Alerta;
		}
		set
		{
			_Alerta.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_Empleado_Area", Storage = "_Empleado_Area", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz")]
	public EntitySet<Empleado_Area> Empleado_Area
	{
		get
		{
			return _Empleado_Area;
		}
		set
		{
			_Empleado_Area.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_Estrategia", Storage = "_Estrategia", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz")]
	public EntitySet<Estrategia> Estrategia
	{
		get
		{
			return _Estrategia;
		}
		set
		{
			_Estrategia.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_EstructOrganiz", Storage = "_EstructOrganiz1", ThisKey = "Year,idAreaOrganiz", OtherKey = "YearDe,idDependeDe")]
	public EntitySet<EstructOrganiz> EstructOrganiz1
	{
		get
		{
			return _EstructOrganiz1;
		}
		set
		{
			_EstructOrganiz1.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_EvaluacionGestion", Storage = "_EvaluacionGestion", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz")]
	public EntitySet<EvaluacionGestion> EvaluacionGestion
	{
		get
		{
			return _EvaluacionGestion;
		}
		set
		{
			_EvaluacionGestion.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_InversPublica", Storage = "_InversPublica", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz")]
	public EntitySet<InversPublica> InversPublica
	{
		get
		{
			return _InversPublica;
		}
		set
		{
			_InversPublica.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_Logros", Storage = "_Logros", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz")]
	public EntitySet<Logros> Logros
	{
		get
		{
			return _Logros;
		}
		set
		{
			_Logros.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_Meta_Area", Storage = "_Meta_Area", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,IdAreaOrganiz")]
	public EntitySet<Meta_Area> Meta_Area
	{
		get
		{
			return _Meta_Area;
		}
		set
		{
			_Meta_Area.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_Recomendacion", Storage = "_Recomendacion", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz")]
	public EntitySet<Recomendacion> Recomendacion
	{
		get
		{
			return _Recomendacion;
		}
		set
		{
			_Recomendacion.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_TRANumeracion", Storage = "_TRANumeracion", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,IdAreaOrganiz")]
	public EntitySet<TRANumeracion> TRANumeracion
	{
		get
		{
			return _TRANumeracion;
		}
		set
		{
			_TRANumeracion.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_TRAEtapa_Procedimiento", Storage = "_TRAEtapa_Procedimiento", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz")]
	public EntitySet<TRAEtapa_Procedimiento> TRAEtapa_Procedimiento
	{
		get
		{
			return _TRAEtapa_Procedimiento;
		}
		set
		{
			_TRAEtapa_Procedimiento.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_Empleado", Storage = "_Empleados", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz")]
	public EntitySet<Empleado> Empleados
	{
		get
		{
			return _Empleados;
		}
		set
		{
			_Empleados.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_Rotacion", Storage = "_Rotacions", ThisKey = "Year,idAreaOrganiz", OtherKey = "Year,idAreaOrganiz")]
	public EntitySet<Rotacion> Rotacions
	{
		get
		{
			return _Rotacions;
		}
		set
		{
			_Rotacions.Assign(value);
		}
	}

	[Association(Name = "EstructOrganiz_EstructOrganiz", Storage = "_EstructOrganiz", ThisKey = "YearDe,idDependeDe", OtherKey = "Year,idAreaOrganiz", IsForeignKey = true)]
	public EstructOrganiz ParentEstructOrganiz
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
					previousValue.EstructOrganiz1.Remove(this);
				}
				_EstructOrganiz.Entity = value;
				if (value != null)
				{
					value.EstructOrganiz1.Add(this);
					_YearDe = value.Year;
					_idDependeDe = value.idAreaOrganiz;
				}
				else
				{
					_YearDe = null;
					_idDependeDe = null;
				}
				SendPropertyChanged("EstructOrganiz");
			}
		}
	}

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public EstructOrganiz()
	{
		_Alerta = new EntitySet<Alerta>(attach_Alerta, detach_Alerta);
		_Empleado_Area = new EntitySet<Empleado_Area>(attach_Empleado_Area, detach_Empleado_Area);
		_Estrategia = new EntitySet<Estrategia>(attach_Estrategia, detach_Estrategia);
		_EstructOrganiz1 = new EntitySet<EstructOrganiz>(attach_EstructOrganiz1, detach_EstructOrganiz1);
		_EvaluacionGestion = new EntitySet<EvaluacionGestion>(attach_EvaluacionGestion, detach_EvaluacionGestion);
		_InversPublica = new EntitySet<InversPublica>(attach_InversPublica, detach_InversPublica);
		_Logros = new EntitySet<Logros>(attach_Logros, detach_Logros);
		_Meta_Area = new EntitySet<Meta_Area>(attach_Meta_Area, detach_Meta_Area);
		_Recomendacion = new EntitySet<Recomendacion>(attach_Recomendacion, detach_Recomendacion);
		_TRANumeracion = new EntitySet<TRANumeracion>(attach_TRANumeracion, detach_TRANumeracion);
		_TRAEtapa_Procedimiento = new EntitySet<TRAEtapa_Procedimiento>(attach_TRAEtapa_Procedimiento, detach_TRAEtapa_Procedimiento);
		_Empleados = new EntitySet<Empleado>(attach_Empleados, detach_Empleados);
		_Rotacions = new EntitySet<Rotacion>(attach_Rotacions, detach_Rotacions);
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

	private void attach_Alerta(Alerta entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = this;
	}

	private void detach_Alerta(Alerta entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = null;
	}

	private void attach_Empleado_Area(Empleado_Area entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = this;
	}

	private void detach_Empleado_Area(Empleado_Area entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = null;
	}

	private void attach_Estrategia(Estrategia entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = this;
	}

	private void detach_Estrategia(Estrategia entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = null;
	}

	private void attach_EstructOrganiz1(EstructOrganiz entity)
	{
		SendPropertyChanging();
		entity.ParentEstructOrganiz = this;
	}

	private void detach_EstructOrganiz1(EstructOrganiz entity)
	{
		SendPropertyChanging();
		entity.ParentEstructOrganiz = null;
	}

	private void attach_EvaluacionGestion(EvaluacionGestion entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = this;
	}

	private void detach_EvaluacionGestion(EvaluacionGestion entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = null;
	}

	private void attach_InversPublica(InversPublica entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = this;
	}

	private void detach_InversPublica(InversPublica entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = null;
	}

	private void attach_Logros(Logros entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = this;
	}

	private void detach_Logros(Logros entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = null;
	}

	private void attach_Meta_Area(Meta_Area entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = this;
	}

	private void detach_Meta_Area(Meta_Area entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = null;
	}

	private void attach_Recomendacion(Recomendacion entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = this;
	}

	private void detach_Recomendacion(Recomendacion entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = null;
	}

	private void attach_TRANumeracion(TRANumeracion entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = this;
	}

	private void detach_TRANumeracion(TRANumeracion entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = null;
	}

	private void attach_TRAEtapa_Procedimiento(TRAEtapa_Procedimiento entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = this;
	}

	private void detach_TRAEtapa_Procedimiento(TRAEtapa_Procedimiento entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = null;
	}

	private void attach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = null;
	}

	private void attach_Rotacions(Rotacion entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = this;
	}

	private void detach_Rotacions(Rotacion entity)
	{
		SendPropertyChanging();
		entity.EstructOrganiz = null;
	}
}
