using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class tra_sp_vs_tra_ListarProcedimientoEtapaResult
{
	private long? _Codigo;

	private string _IdEtapaProc;

	private string _Descripcion;

	private int _Minutos;

	private int _Horas;

	private int _Dias;

	private string _Tiempo;

	private string _IdTipoDoc;

	private string _Observaciones;

	private int? _anio;

	private int? _idAreaOrganiz;

	private string _desarea;

	private int? _IdCargo;

	private string _Cargo;

	private string _IdProcedimiento;

	private byte? _Item;

	private string _EtapaAnterior;

	private bool? _Estado;

	private string _SecStandard;

	private string _SecAlterna;

	private int _SECSTD;

	private int _SECALT;

	[Column(Storage = "_Codigo", DbType = "BigInt")]
	public long? Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			if (!_Codigo.Equals(value))
			{
				_Codigo = value;
			}
		}
	}

	[Column(Storage = "_IdEtapaProc", DbType = "Char(8) NOT NULL", CanBeNull = false)]
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
				_IdEtapaProc = value;
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
				_Descripcion = value;
			}
		}
	}

	[Column(Storage = "_Minutos", DbType = "Int NOT NULL")]
	public int Minutos
	{
		get
		{
			return _Minutos;
		}
		set
		{
			if (_Minutos != value)
			{
				_Minutos = value;
			}
		}
	}

	[Column(Storage = "_Horas", DbType = "Int NOT NULL")]
	public int Horas
	{
		get
		{
			return _Horas;
		}
		set
		{
			if (_Horas != value)
			{
				_Horas = value;
			}
		}
	}

	[Column(Storage = "_Dias", DbType = "Int NOT NULL")]
	public int Dias
	{
		get
		{
			return _Dias;
		}
		set
		{
			if (_Dias != value)
			{
				_Dias = value;
			}
		}
	}

	[Column(Storage = "_Tiempo", DbType = "VarChar(34)")]
	public string Tiempo
	{
		get
		{
			return _Tiempo;
		}
		set
		{
			if (!string.Equals(_Tiempo, value))
			{
				_Tiempo = value;
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
				_IdTipoDoc = value;
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
				_Observaciones = value;
			}
		}
	}

	[Column(Storage = "_anio", DbType = "Int")]
	public int? anio
	{
		get
		{
			return _anio;
		}
		set
		{
			if (!_anio.Equals(value))
			{
				_anio = value;
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
				_idAreaOrganiz = value;
			}
		}
	}

	[Column(Storage = "_desarea", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string desarea
	{
		get
		{
			return _desarea;
		}
		set
		{
			if (!string.Equals(_desarea, value))
			{
				_desarea = value;
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
				_IdCargo = value;
			}
		}
	}

	[Column(Storage = "_Cargo", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string Cargo
	{
		get
		{
			return _Cargo;
		}
		set
		{
			if (!string.Equals(_Cargo, value))
			{
				_Cargo = value;
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
				_IdProcedimiento = value;
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
				_Item = value;
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
				_EtapaAnterior = value;
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
				_Estado = value;
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
				_SecStandard = value;
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
				_SecAlterna = value;
			}
		}
	}

	[Column(Storage = "_SECSTD", DbType = "Int NOT NULL")]
	public int SECSTD
	{
		get
		{
			return _SECSTD;
		}
		set
		{
			if (_SECSTD != value)
			{
				_SECSTD = value;
			}
		}
	}

	[Column(Storage = "_SECALT", DbType = "Int NOT NULL")]
	public int SECALT
	{
		get
		{
			return _SECALT;
		}
		set
		{
			if (_SECALT != value)
			{
				_SECALT = value;
			}
		}
	}
}
