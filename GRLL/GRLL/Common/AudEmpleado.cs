using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.AudEmpleado")]
public class AudEmpleado : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdAudEmplead;

	private int? _IdEmpleado;

	private int? _Year;

	private int? _idAreaOrganiz;

	private int? _IdPersona;

	private DateTime? _FechaIngreso;

	private int? _IdAFP;

	private string _Brevete;

	private int? _IdEstadoCivil;

	private char? _Sexo;

	private string _CtaCorriente;

	private string _NroAFP;

	private DateTime? _FechaAFP;

	private int? _IdSeguro;

	private string _NroSeguro;

	private int? _IdTipoSangre;

	private string _DecLey;

	private string _Estacion;

	private Binary _Foto;

	private string _User1;

	private int? _IdTipoTrabajador;

	private DateTime? _Fecha;

	private char? _Estado;

	private string _Operacion;

	private int? _IdCargo;

	[Column(Storage = "_IdAudEmplead", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdAudEmplead
	{
		get
		{
			return _IdAudEmplead;
		}
		set
		{
			if (_IdAudEmplead != value)
			{
				SendPropertyChanging();
				_IdAudEmplead = value;
				SendPropertyChanged("IdAudEmplead");
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
				SendPropertyChanging();
				_idAreaOrganiz = value;
				SendPropertyChanged("idAreaOrganiz");
			}
		}
	}

	[Column(Storage = "_IdPersona", DbType = "Int")]
	public int? IdPersona
	{
		get
		{
			return _IdPersona;
		}
		set
		{
			if (!_IdPersona.Equals(value))
			{
				SendPropertyChanging();
				_IdPersona = value;
				SendPropertyChanged("IdPersona");
			}
		}
	}

	[Column(Storage = "_FechaIngreso", DbType = "SmallDateTime")]
	public DateTime? FechaIngreso
	{
		get
		{
			return _FechaIngreso;
		}
		set
		{
			if (!_FechaIngreso.Equals(value))
			{
				SendPropertyChanging();
				_FechaIngreso = value;
				SendPropertyChanged("FechaIngreso");
			}
		}
	}

	[Column(Storage = "_IdAFP", DbType = "Int")]
	public int? IdAFP
	{
		get
		{
			return _IdAFP;
		}
		set
		{
			if (!_IdAFP.Equals(value))
			{
				SendPropertyChanging();
				_IdAFP = value;
				SendPropertyChanged("IdAFP");
			}
		}
	}

	[Column(Storage = "_Brevete", DbType = "VarChar(12)")]
	public string Brevete
	{
		get
		{
			return _Brevete;
		}
		set
		{
			if (!string.Equals(_Brevete, value))
			{
				SendPropertyChanging();
				_Brevete = value;
				SendPropertyChanged("Brevete");
			}
		}
	}

	[Column(Storage = "_IdEstadoCivil", DbType = "Int")]
	public int? IdEstadoCivil
	{
		get
		{
			return _IdEstadoCivil;
		}
		set
		{
			if (!_IdEstadoCivil.Equals(value))
			{
				SendPropertyChanging();
				_IdEstadoCivil = value;
				SendPropertyChanged("IdEstadoCivil");
			}
		}
	}

	[Column(Storage = "_Sexo", DbType = "Char(1)")]
	public char? Sexo
	{
		get
		{
			return _Sexo;
		}
		set
		{
			if (!_Sexo.Equals(value))
			{
				SendPropertyChanging();
				_Sexo = value;
				SendPropertyChanged("Sexo");
			}
		}
	}

	[Column(Storage = "_CtaCorriente", DbType = "VarChar(16)")]
	public string CtaCorriente
	{
		get
		{
			return _CtaCorriente;
		}
		set
		{
			if (!string.Equals(_CtaCorriente, value))
			{
				SendPropertyChanging();
				_CtaCorriente = value;
				SendPropertyChanged("CtaCorriente");
			}
		}
	}

	[Column(Storage = "_NroAFP", DbType = "VarChar(20)")]
	public string NroAFP
	{
		get
		{
			return _NroAFP;
		}
		set
		{
			if (!string.Equals(_NroAFP, value))
			{
				SendPropertyChanging();
				_NroAFP = value;
				SendPropertyChanged("NroAFP");
			}
		}
	}

	[Column(Storage = "_FechaAFP", DbType = "DateTime")]
	public DateTime? FechaAFP
	{
		get
		{
			return _FechaAFP;
		}
		set
		{
			if (!_FechaAFP.Equals(value))
			{
				SendPropertyChanging();
				_FechaAFP = value;
				SendPropertyChanged("FechaAFP");
			}
		}
	}

	[Column(Storage = "_IdSeguro", DbType = "Int")]
	public int? IdSeguro
	{
		get
		{
			return _IdSeguro;
		}
		set
		{
			if (!_IdSeguro.Equals(value))
			{
				SendPropertyChanging();
				_IdSeguro = value;
				SendPropertyChanged("IdSeguro");
			}
		}
	}

	[Column(Storage = "_NroSeguro", DbType = "VarChar(20)")]
	public string NroSeguro
	{
		get
		{
			return _NroSeguro;
		}
		set
		{
			if (!string.Equals(_NroSeguro, value))
			{
				SendPropertyChanging();
				_NroSeguro = value;
				SendPropertyChanged("NroSeguro");
			}
		}
	}

	[Column(Storage = "_IdTipoSangre", DbType = "Int")]
	public int? IdTipoSangre
	{
		get
		{
			return _IdTipoSangre;
		}
		set
		{
			if (!_IdTipoSangre.Equals(value))
			{
				SendPropertyChanging();
				_IdTipoSangre = value;
				SendPropertyChanged("IdTipoSangre");
			}
		}
	}

	[Column(Storage = "_DecLey", DbType = "VarChar(10)")]
	public string DecLey
	{
		get
		{
			return _DecLey;
		}
		set
		{
			if (!string.Equals(_DecLey, value))
			{
				SendPropertyChanging();
				_DecLey = value;
				SendPropertyChanged("DecLey");
			}
		}
	}

	[Column(Storage = "_Estacion", DbType = "VarChar(100)")]
	public string Estacion
	{
		get
		{
			return _Estacion;
		}
		set
		{
			if (!string.Equals(_Estacion, value))
			{
				SendPropertyChanging();
				_Estacion = value;
				SendPropertyChanged("Estacion");
			}
		}
	}

	[Column(Storage = "_Foto", DbType = "Image", UpdateCheck = UpdateCheck.Never)]
	public Binary Foto
	{
		get
		{
			return _Foto;
		}
		set
		{
			if (!object.Equals(_Foto, value))
			{
				SendPropertyChanging();
				_Foto = value;
				SendPropertyChanged("Foto");
			}
		}
	}

	[Column(Storage = "_User1", DbType = "VarChar(100)")]
	public string User1
	{
		get
		{
			return _User1;
		}
		set
		{
			if (!string.Equals(_User1, value))
			{
				SendPropertyChanging();
				_User1 = value;
				SendPropertyChanged("User1");
			}
		}
	}

	[Column(Storage = "_IdTipoTrabajador", DbType = "Int")]
	public int? IdTipoTrabajador
	{
		get
		{
			return _IdTipoTrabajador;
		}
		set
		{
			if (!_IdTipoTrabajador.Equals(value))
			{
				SendPropertyChanging();
				_IdTipoTrabajador = value;
				SendPropertyChanged("IdTipoTrabajador");
			}
		}
	}

	[Column(Storage = "_Fecha", DbType = "SmallDateTime")]
	public DateTime? Fecha
	{
		get
		{
			return _Fecha;
		}
		set
		{
			if (!_Fecha.Equals(value))
			{
				SendPropertyChanging();
				_Fecha = value;
				SendPropertyChanged("Fecha");
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Char(1)")]
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

	[Column(Storage = "_Operacion", DbType = "VarChar(2)")]
	public string Operacion
	{
		get
		{
			return _Operacion;
		}
		set
		{
			if (!string.Equals(_Operacion, value))
			{
				SendPropertyChanging();
				_Operacion = value;
				SendPropertyChanged("Operacion");
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

	[method: DebuggerNonUserCode]
	public event PropertyChangingEventHandler PropertyChanging;

	[method: DebuggerNonUserCode]
	public event PropertyChangedEventHandler PropertyChanged;

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
