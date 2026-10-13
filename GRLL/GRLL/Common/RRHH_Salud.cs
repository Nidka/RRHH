using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.RRHH_Salud")]
public class RRHH_Salud : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _idSalud;

	private int? _IdEmpleado;

	private bool? _EnferCronica;

	private string _EnferCronicaDescrip;

	private bool? _FamDiscapacidad;

	private string _FamDiscapDescrip;

	private bool? _Alergico;

	private string _AlergicoDescrip;

	private int? _idAcudeEnferm;

	private EntityRef<RRHH_AcudeEnferm> _RRHH_AcudeEnferm;

	private EntityRef<Empleado> _Empleado;

	[Column(Storage = "_idSalud", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int idSalud
	{
		get
		{
			return _idSalud;
		}
		set
		{
			if (_idSalud != value)
			{
				SendPropertyChanging();
				_idSalud = value;
				SendPropertyChanged("idSalud");
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

	[Column(Storage = "_EnferCronica", DbType = "Bit")]
	public bool? EnferCronica
	{
		get
		{
			return _EnferCronica;
		}
		set
		{
			if (!_EnferCronica.Equals(value))
			{
				SendPropertyChanging();
				_EnferCronica = value;
				SendPropertyChanged("EnferCronica");
			}
		}
	}

	[Column(Storage = "_EnferCronicaDescrip", DbType = "VarChar(200)")]
	public string EnferCronicaDescrip
	{
		get
		{
			return _EnferCronicaDescrip;
		}
		set
		{
			if (!string.Equals(_EnferCronicaDescrip, value))
			{
				SendPropertyChanging();
				_EnferCronicaDescrip = value;
				SendPropertyChanged("EnferCronicaDescrip");
			}
		}
	}

	[Column(Storage = "_FamDiscapacidad", DbType = "Bit")]
	public bool? FamDiscapacidad
	{
		get
		{
			return _FamDiscapacidad;
		}
		set
		{
			if (!_FamDiscapacidad.Equals(value))
			{
				SendPropertyChanging();
				_FamDiscapacidad = value;
				SendPropertyChanged("FamDiscapacidad");
			}
		}
	}

	[Column(Storage = "_FamDiscapDescrip", DbType = "VarChar(200)")]
	public string FamDiscapDescrip
	{
		get
		{
			return _FamDiscapDescrip;
		}
		set
		{
			if (!string.Equals(_FamDiscapDescrip, value))
			{
				SendPropertyChanging();
				_FamDiscapDescrip = value;
				SendPropertyChanged("FamDiscapDescrip");
			}
		}
	}

	[Column(Storage = "_Alergico", DbType = "Bit")]
	public bool? Alergico
	{
		get
		{
			return _Alergico;
		}
		set
		{
			if (!_Alergico.Equals(value))
			{
				SendPropertyChanging();
				_Alergico = value;
				SendPropertyChanged("Alergico");
			}
		}
	}

	[Column(Storage = "_AlergicoDescrip", DbType = "VarChar(200)")]
	public string AlergicoDescrip
	{
		get
		{
			return _AlergicoDescrip;
		}
		set
		{
			if (!string.Equals(_AlergicoDescrip, value))
			{
				SendPropertyChanging();
				_AlergicoDescrip = value;
				SendPropertyChanged("AlergicoDescrip");
			}
		}
	}

	[Column(Storage = "_idAcudeEnferm", DbType = "Int")]
	public int? idAcudeEnferm
	{
		get
		{
			return _idAcudeEnferm;
		}
		set
		{
			if (!_idAcudeEnferm.Equals(value))
			{
				if (_RRHH_AcudeEnferm.HasLoadedOrAssignedValue)
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_idAcudeEnferm = value;
				SendPropertyChanged("idAcudeEnferm");
			}
		}
	}

	[Association(Name = "RRHH_AcudeEnferm_RRHH_Salud", Storage = "_RRHH_AcudeEnferm", ThisKey = "idAcudeEnferm", OtherKey = "idAcudeEnferm", IsForeignKey = true)]
	public RRHH_AcudeEnferm RRHH_AcudeEnferm
	{
		get
		{
			return _RRHH_AcudeEnferm.Entity;
		}
		set
		{
			RRHH_AcudeEnferm previousValue = _RRHH_AcudeEnferm.Entity;
			if (!object.Equals(previousValue, value) || !_RRHH_AcudeEnferm.HasLoadedOrAssignedValue)
			{
				SendPropertyChanging();
				if (previousValue != null)
				{
					_RRHH_AcudeEnferm.Entity = null;
					previousValue.RRHH_Salud.Remove(this);
				}
				_RRHH_AcudeEnferm.Entity = value;
				if (value != null)
				{
					value.RRHH_Salud.Add(this);
					_idAcudeEnferm = value.idAcudeEnferm;
				}
				else
				{
					_idAcudeEnferm = null;
				}
				SendPropertyChanged("RRHH_AcudeEnferm");
			}
		}
	}

	[Association(Name = "Empleado_RRHH_Salud", Storage = "_Empleado", ThisKey = "IdEmpleado", OtherKey = "IdEmpleado", IsForeignKey = true)]
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
					previousValue.RRHH_Saluds.Remove(this);
				}
				_Empleado.Entity = value;
				if (value != null)
				{
					value.RRHH_Saluds.Add(this);
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

	public RRHH_Salud()
	{
		_RRHH_AcudeEnferm = default(EntityRef<RRHH_AcudeEnferm>);
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
