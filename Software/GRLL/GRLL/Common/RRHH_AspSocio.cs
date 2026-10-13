using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_AspSocio")]
public class RRHH_AspSocio : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idAspSocio;

	private int? _IdEmpleado;

	private int? _idPregunta1;

	private int? _idPregunta2;

	private int? _idPregunta3;

	private string _PrincipProblemas;

	private string _PropMejoraInstitu;

	private string _hobby;

	private string _ActRecreaInstitu;

	private EntityRef<RRHH_Preg1> _RRHH_Preg1;

	private EntityRef<RRHH_Preg2> _RRHH_Preg2;

	private EntityRef<RRHH_Preg3> _RRHH_Preg3;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_idAspSocio", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idAspSocio
	{
		get
		{
			return _idAspSocio;
		}
		set
		{
			if (_idAspSocio != value)
			{
				SendPropertyChanging();
				_idAspSocio = value;
				SendPropertyChanged("idAspSocio");
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

	[Column(Storage = "_idPregunta1", DbType = "Int")]
	public int? idPregunta1
	{
		get
		{
			return _idPregunta1;
		}
		set
		{
			if (!_idPregunta1.Equals(value))
			{
				if (_RRHH_Preg1.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idPregunta1 = value;
				SendPropertyChanged("idPregunta1");
			}
		}
	}

	[Column(Storage = "_idPregunta2", DbType = "Int")]
	public int? idPregunta2
	{
		get
		{
			return _idPregunta2;
		}
		set
		{
			if (!_idPregunta2.Equals(value))
			{
				if (_RRHH_Preg2.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idPregunta2 = value;
				SendPropertyChanged("idPregunta2");
			}
		}
	}

	[Column(Storage = "_idPregunta3", DbType = "Int")]
	public int? idPregunta3
	{
		get
		{
			return _idPregunta3;
		}
		set
		{
			if (!_idPregunta3.Equals(value))
			{
				if (_RRHH_Preg3.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idPregunta3 = value;
				SendPropertyChanged("idPregunta3");
			}
		}
	}

	[Column(Storage = "_PrincipProblemas", DbType = "VarChar(400)")]
	public string PrincipProblemas
	{
		get
		{
			return _PrincipProblemas;
		}
		set
		{
			if (!string.Equals(_PrincipProblemas, value))
			{
				SendPropertyChanging();
				_PrincipProblemas = value;
				SendPropertyChanged("PrincipProblemas");
			}
		}
	}

	[Column(Storage = "_PropMejoraInstitu", DbType = "VarChar(400)")]
	public string PropMejoraInstitu
	{
		get
		{
			return _PropMejoraInstitu;
		}
		set
		{
			if (!string.Equals(_PropMejoraInstitu, value))
			{
				SendPropertyChanging();
				_PropMejoraInstitu = value;
				SendPropertyChanged("PropMejoraInstitu");
			}
		}
	}

	[Column(Storage = "_hobby", DbType = "VarChar(400)")]
	public string hobby
	{
		get
		{
			return _hobby;
		}
		set
		{
			if (!string.Equals(_hobby, value))
			{
				SendPropertyChanging();
				_hobby = value;
				SendPropertyChanged("hobby");
			}
		}
	}

	[Column(Storage = "_ActRecreaInstitu", DbType = "VarChar(400)")]
	public string ActRecreaInstitu
	{
		get
		{
			return _ActRecreaInstitu;
		}
		set
		{
			if (!string.Equals(_ActRecreaInstitu, value))
			{
				SendPropertyChanging();
				_ActRecreaInstitu = value;
				SendPropertyChanged("ActRecreaInstitu");
			}
		}
	}

	[Association(Name = "RRHH_Preg1_RRHH_AspSocio", Storage = "_RRHH_Preg1", ThisKey = "idPregunta1", OtherKey = "idPregunta1", IsForeignKey = true)]
	public RRHH_Preg1 RRHH_Preg1
	{
		get
		{
			return _RRHH_Preg1.Entity;
		}
		set
		{
			RRHH_Preg1 previousValue = _RRHH_Preg1.Entity;
			if (!object.Equals(previousValue, value) || !_RRHH_Preg1.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_RRHH_Preg1.Entity = null;
					previousValue.RRHH_AspSocio.Remove(this);
				}
				_RRHH_Preg1.Entity = value;
				if (value != null)
				{
					value.RRHH_AspSocio.Add(this);
					_idPregunta1 = value.idPregunta1;
				}
				else
				{
					_idPregunta1 = null;
				}
				SendPropertyChanged("RRHH_Preg1");
			}
		}
	}

	[Association(Name = "RRHH_Preg2_RRHH_AspSocio", Storage = "_RRHH_Preg2", ThisKey = "idPregunta2", OtherKey = "idPregunta2", IsForeignKey = true)]
	public RRHH_Preg2 RRHH_Preg2
	{
		get
		{
			return _RRHH_Preg2.Entity;
		}
		set
		{
			RRHH_Preg2 previousValue = _RRHH_Preg2.Entity;
			if (!object.Equals(previousValue, value) || !_RRHH_Preg2.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_RRHH_Preg2.Entity = null;
					previousValue.RRHH_AspSocio.Remove(this);
				}
				_RRHH_Preg2.Entity = value;
				if (value != null)
				{
					value.RRHH_AspSocio.Add(this);
					_idPregunta2 = value.idPregunta2;
				}
				else
				{
					_idPregunta2 = null;
				}
				SendPropertyChanged("RRHH_Preg2");
			}
		}
	}

	[Association(Name = "RRHH_Preg3_RRHH_AspSocio", Storage = "_RRHH_Preg3", ThisKey = "idPregunta3", OtherKey = "idPregunta3", IsForeignKey = true)]
	public RRHH_Preg3 RRHH_Preg3
	{
		get
		{
			return _RRHH_Preg3.Entity;
		}
		set
		{
			RRHH_Preg3 previousValue = _RRHH_Preg3.Entity;
			if (!object.Equals(previousValue, value) || !_RRHH_Preg3.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_RRHH_Preg3.Entity = null;
					previousValue.RRHH_AspSocio.Remove(this);
				}
				_RRHH_Preg3.Entity = value;
				if (value != null)
				{
					value.RRHH_AspSocio.Add(this);
					_idPregunta3 = value.idPregunta3;
				}
				else
				{
					_idPregunta3 = null;
				}
				SendPropertyChanged("RRHH_Preg3");
			}
		}
	}

	[Association(Name = "Empleado_RRHH_AspSocio", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.RRHH_AspSocios.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.RRHH_AspSocios.Add(this);
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

	public RRHH_AspSocio()
	{
		_RRHH_Preg1 = default(EntityRef<RRHH_Preg1>);
		_RRHH_Preg2 = default(EntityRef<RRHH_Preg2>);
		_RRHH_Preg3 = default(EntityRef<RRHH_Preg3>);
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
