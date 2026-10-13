using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_TRA_ListarProcedimiento")]
public class vs_TRA_ListarProcedimiento
{
	private string _IdProcedimiento;

	private string _codigoid;

	private string _codigo;

	private string _Descripcion;

	private byte? _IdTipoSilencio;

	private int _Dias;

	private int _Horas;

	private int _Minutos;

	private string _Tiempo;

	private string _destiposilencio;

	private string _Observaciones;

	private int? _Anio;

	private char? _Estado;

	private int? _IdAreaOrganiz;

	private string _desarea;

	private char? _Tipo;

	private char? _Ambito;

	[Column(Storage = "_IdProcedimiento", DbType = "Char(6) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_codigoid", DbType = "VarChar(4)")]
	public string codigoid
	{
		get
		{
			return _codigoid;
		}
		set
		{
			if (!string.Equals(_codigoid, value))
			{
				_codigoid = value;
			}
		}
	}

	[Column(Storage = "_codigo", DbType = "Char(20) NOT NULL", CanBeNull = false)]
	public string codigo
	{
		get
		{
			return _codigo;
		}
		set
		{
			if (!string.Equals(_codigo, value))
			{
				_codigo = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(300)")]
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

	[Column(Storage = "_IdTipoSilencio", DbType = "TinyInt")]
	public byte? IdTipoSilencio
	{
		get
		{
			return _IdTipoSilencio;
		}
		set
		{
			if (!_IdTipoSilencio.Equals(value))
			{
				_IdTipoSilencio = value;
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

	[Column(Storage = "_destiposilencio", DbType = "VarChar(200)")]
	public string destiposilencio
	{
		get
		{
			return _destiposilencio;
		}
		set
		{
			if (!string.Equals(_destiposilencio, value))
			{
				_destiposilencio = value;
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

	[Column(Storage = "_Anio", DbType = "Int")]
	public int? Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!_Anio.Equals(value))
			{
				_Anio = value;
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "VarChar(1)")]
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
				_Estado = value;
			}
		}
	}

	[Column(Storage = "_IdAreaOrganiz", DbType = "Int")]
	public int? IdAreaOrganiz
	{
		get
		{
			return _IdAreaOrganiz;
		}
		set
		{
			if (!_IdAreaOrganiz.Equals(value))
			{
				_IdAreaOrganiz = value;
			}
		}
	}

	[Column(Storage = "_desarea", DbType = "VarChar(200)")]
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

	[Column(Storage = "_Tipo", DbType = "Char(1)")]
	public char? Tipo
	{
		get
		{
			return _Tipo;
		}
		set
		{
			if (!_Tipo.Equals(value))
			{
				_Tipo = value;
			}
		}
	}

	[Column(Storage = "_Ambito", DbType = "Char(1)")]
	public char? Ambito
	{
		get
		{
			return _Ambito;
		}
		set
		{
			if (!_Ambito.Equals(value))
			{
				_Ambito = value;
			}
		}
	}
}
