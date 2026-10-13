using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace GRLL.Common;

[Table(Name = "dbo.AudEstructOrg")]
public class AudEstructOrg : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private int _IdAudEstrucOrg;

	private int? _Year;

	private int? _idAreaOrganiz;

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

	private int? _IdDependeDe;

	private int? _IdEmpleado;

	private string _Estacion;

	private string _User1;

	private DateTime? _Fecha;

	private string _Operacion;

	[Column(Storage = "_IdAudEstrucOrg", DbType = "Int NOT NULL", IsPrimaryKey = true)]
	public int IdAudEstrucOrg
	{
		get
		{
			return _IdAudEstrucOrg;
		}
		set
		{
			if (_IdAudEstrucOrg != value)
			{
				SendPropertyChanging();
				_IdAudEstrucOrg = value;
				SendPropertyChanged("IdAudEstrucOrg");
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
				SendPropertyChanging();
				_YearDe = value;
				SendPropertyChanged("YearDe");
			}
		}
	}

	[Column(Storage = "_IdDependeDe", DbType = "Int")]
	public int? IdDependeDe
	{
		get
		{
			return _IdDependeDe;
		}
		set
		{
			if (!_IdDependeDe.Equals(value))
			{
				SendPropertyChanging();
				_IdDependeDe = value;
				SendPropertyChanged("IdDependeDe");
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
