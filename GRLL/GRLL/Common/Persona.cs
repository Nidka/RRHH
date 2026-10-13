using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.Persona")]
public class Persona : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdPersona;

	private string _Nombres;

	private string _Apellido_Paterno;

	private string _Apellido_Materno;

	private int? _TipoDocID;

	private string _NumDocID;

	private string _Direccion;

	private string _Telefono;

	private string _Fax;

	private string _Email;

	private string _IdUbigeo;

	private string _UbigeoDireccion;

	private char? _TipoPersona;

	private DateTime? _FechaNacimiento;

	private DateTime? _FechaRegistro;

	private string _NumCelular;

	private string _FonoCentroLab;

	private EntitySet<Familiar> _Familiar;

	private EntitySet<IngresoCaj> _IngresoCaj;

	private EntitySet<Proveedor> _Proveedor;

	private EntitySet<RRHH_Asegurado> _RRHH_Asegurados;

	private EntitySet<Empleado> _Empleados;

	[Column(Storage = "_IdPersona", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdPersona
	{
		get
		{
			return _IdPersona;
		}
		set
		{
			if (_IdPersona != value)
			{
				SendPropertyChanging();
				_IdPersona = value;
				SendPropertyChanged("IdPersona");
			}
		}
	}

	[Column(Storage = "_Nombres", DbType = "VarChar(100)")]
	public string Nombres
	{
		get
		{
			return _Nombres;
		}
		set
		{
			if (!string.Equals(_Nombres, value))
			{
				SendPropertyChanging();
				_Nombres = value;
				SendPropertyChanged("Nombres");
			}
		}
	}

	[Column(Storage = "_Apellido_Paterno", DbType = "VarChar(30)")]
	public string Apellido_Paterno
	{
		get
		{
			return _Apellido_Paterno;
		}
		set
		{
			if (!string.Equals(_Apellido_Paterno, value))
			{
				SendPropertyChanging();
				_Apellido_Paterno = value;
				SendPropertyChanged("Apellido_Paterno");
			}
		}
	}

	[Column(Storage = "_Apellido_Materno", DbType = "VarChar(30)")]
	public string Apellido_Materno
	{
		get
		{
			return _Apellido_Materno;
		}
		set
		{
			if (!string.Equals(_Apellido_Materno, value))
			{
				SendPropertyChanging();
				_Apellido_Materno = value;
				SendPropertyChanged("Apellido_Materno");
			}
		}
	}

	[Column(Storage = "_TipoDocID", DbType = "Int")]
	public int? TipoDocID
	{
		get
		{
			return _TipoDocID;
		}
		set
		{
			if (!_TipoDocID.Equals(value))
			{
				SendPropertyChanging();
				_TipoDocID = value;
				SendPropertyChanged("TipoDocID");
			}
		}
	}

	[Column(Storage = "_NumDocID", DbType = "Char(12)")]
	public string NumDocID
	{
		get
		{
			return _NumDocID;
		}
		set
		{
			if (!string.Equals(_NumDocID, value))
			{
				SendPropertyChanging();
				_NumDocID = value;
				SendPropertyChanged("NumDocID");
			}
		}
	}

	[Column(Storage = "_Direccion", DbType = "VarChar(100)")]
	public string Direccion
	{
		get
		{
			return _Direccion;
		}
		set
		{
			if (!string.Equals(_Direccion, value))
			{
				SendPropertyChanging();
				_Direccion = value;
				SendPropertyChanged("Direccion");
			}
		}
	}

	[Column(Storage = "_Telefono", DbType = "VarChar(15)")]
	public string Telefono
	{
		get
		{
			return _Telefono;
		}
		set
		{
			if (!string.Equals(_Telefono, value))
			{
				SendPropertyChanging();
				_Telefono = value;
				SendPropertyChanged("Telefono");
			}
		}
	}

	[Column(Storage = "_Fax", DbType = "VarChar(15)")]
	public string Fax
	{
		get
		{
			return _Fax;
		}
		set
		{
			if (!string.Equals(_Fax, value))
			{
				SendPropertyChanging();
				_Fax = value;
				SendPropertyChanged("Fax");
			}
		}
	}

	[Column(Storage = "_Email", DbType = "VarChar(50)")]
	public string Email
	{
		get
		{
			return _Email;
		}
		set
		{
			if (!string.Equals(_Email, value))
			{
				SendPropertyChanging();
				_Email = value;
				SendPropertyChanged("Email");
			}
		}
	}

	[Column(Storage = "_IdUbigeo", DbType = "Char(6)")]
	public string IdUbigeo
	{
		get
		{
			return _IdUbigeo;
		}
		set
		{
			if (!string.Equals(_IdUbigeo, value))
			{
				SendPropertyChanging();
				_IdUbigeo = value;
				SendPropertyChanged("IdUbigeo");
			}
		}
	}

	[Column(Storage = "_UbigeoDireccion", DbType = "Char(6)")]
	public string UbigeoDireccion
	{
		get
		{
			return _UbigeoDireccion;
		}
		set
		{
			if (!string.Equals(_UbigeoDireccion, value))
			{
				SendPropertyChanging();
				_UbigeoDireccion = value;
				SendPropertyChanged("UbigeoDireccion");
			}
		}
	}

	[Column(Storage = "_TipoPersona", DbType = "Char(1)")]
	public char? TipoPersona
	{
		get
		{
			return _TipoPersona;
		}
		set
		{
			if (!_TipoPersona.Equals(value))
			{
				SendPropertyChanging();
				_TipoPersona = value;
				SendPropertyChanged("TipoPersona");
			}
		}
	}

	[Column(Storage = "_FechaNacimiento", DbType = "DateTime")]
	public DateTime? FechaNacimiento
	{
		get
		{
			return _FechaNacimiento;
		}
		set
		{
			if (!_FechaNacimiento.Equals(value))
			{
				SendPropertyChanging();
				_FechaNacimiento = value;
				SendPropertyChanged("FechaNacimiento");
			}
		}
	}

	[Column(Storage = "_FechaRegistro", DbType = "DateTime")]
	public DateTime? FechaRegistro
	{
		get
		{
			return _FechaRegistro;
		}
		set
		{
			if (!_FechaRegistro.Equals(value))
			{
				SendPropertyChanging();
				_FechaRegistro = value;
				SendPropertyChanged("FechaRegistro");
			}
		}
	}

	[Column(Storage = "_NumCelular", DbType = "VarChar(15)")]
	public string NumCelular
	{
		get
		{
			return _NumCelular;
		}
		set
		{
			if (!string.Equals(_NumCelular, value))
			{
				SendPropertyChanging();
				_NumCelular = value;
				SendPropertyChanged("NumCelular");
			}
		}
	}

	[Column(Storage = "_FonoCentroLab", DbType = "VarChar(15)")]
	public string FonoCentroLab
	{
		get
		{
			return _FonoCentroLab;
		}
		set
		{
			if (!string.Equals(_FonoCentroLab, value))
			{
				SendPropertyChanging();
				_FonoCentroLab = value;
				SendPropertyChanged("FonoCentroLab");
			}
		}
	}

	[Association(Name = "Persona_Familiar", Storage = "_Familiar", ThisKey = "IdPersona", OtherKey = "IdPersona")]
	public EntitySet<Familiar> Familiar
	{
		get
		{
			return _Familiar;
		}
		set
		{
			_Familiar.Assign(value);
		}
	}

	[Association(Name = "Persona_IngresoCaj", Storage = "_IngresoCaj", ThisKey = "IdPersona", OtherKey = "IdPersona")]
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

	[Association(Name = "Persona_Proveedor", Storage = "_Proveedor", ThisKey = "IdPersona", OtherKey = "IdPersona")]
	public EntitySet<Proveedor> Proveedor
	{
		get
		{
			return _Proveedor;
		}
		set
		{
			_Proveedor.Assign(value);
		}
	}

	[Association(Name = "Persona_RRHH_Asegurado", Storage = "_RRHH_Asegurados", ThisKey = "IdPersona", OtherKey = "idPersona")]
	public EntitySet<RRHH_Asegurado> RRHH_Asegurados
	{
		get
		{
			return _RRHH_Asegurados;
		}
		set
		{
			_RRHH_Asegurados.Assign(value);
		}
	}

	[Association(Name = "Persona_Empleado", Storage = "_Empleados", ThisKey = "IdPersona", OtherKey = "IdPersona")]
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

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

	public Persona()
	{
		_Familiar = new EntitySet<Familiar>(attach_Familiar, detach_Familiar);
		_IngresoCaj = new EntitySet<IngresoCaj>(attach_IngresoCaj, detach_IngresoCaj);
		_Proveedor = new EntitySet<Proveedor>(attach_Proveedor, detach_Proveedor);
		_RRHH_Asegurados = new EntitySet<RRHH_Asegurado>(attach_RRHH_Asegurados, detach_RRHH_Asegurados);
		_Empleados = new EntitySet<Empleado>(attach_Empleados, detach_Empleados);
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

	private void attach_Familiar(Familiar entity)
	{
		SendPropertyChanging();
		entity.Persona = this;
	}

	private void detach_Familiar(Familiar entity)
	{
		SendPropertyChanging();
		entity.Persona = null;
	}

	private void attach_IngresoCaj(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.Persona = this;
	}

	private void detach_IngresoCaj(IngresoCaj entity)
	{
		SendPropertyChanging();
		entity.Persona = null;
	}

	private void attach_Proveedor(Proveedor entity)
	{
		SendPropertyChanging();
		entity.Persona = this;
	}

	private void detach_Proveedor(Proveedor entity)
	{
		SendPropertyChanging();
		entity.Persona = null;
	}

	private void attach_RRHH_Asegurados(RRHH_Asegurado entity)
	{
		SendPropertyChanging();
		entity.Persona = this;
	}

	private void detach_RRHH_Asegurados(RRHH_Asegurado entity)
	{
		SendPropertyChanging();
		entity.Persona = null;
	}

	private void attach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.Persona = this;
	}

	private void detach_Empleados(Empleado entity)
	{
		SendPropertyChanging();
		entity.Persona = null;
	}
}
