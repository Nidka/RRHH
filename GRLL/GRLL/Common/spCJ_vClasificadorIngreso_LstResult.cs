using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_vClasificadorIngreso_LstResult
{
	private int _Years;

	private int _Codigo;

	private string _CodigoClasif;

	private string _Nombre;

	private char? _Estado;

	private char? _EsPresupuesto;

	private string _CodigoNombre;

	private int _YearsDe;

	private int _CodigoDe;

	private string _ClasificadorDe;

	private int? _SubClasificadores;

	[Column(Storage = "_Years", DbType = "Int NOT NULL")]
	public int Years
	{
		get
		{
			return _Years;
		}
		set
		{
			if (_Years != value)
			{
				_Years = value;
			}
		}
	}

	[Column(Storage = "_Codigo", DbType = "Int NOT NULL")]
	public int Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			if (_Codigo != value)
			{
				_Codigo = value;
			}
		}
	}

	[Column(Storage = "_CodigoClasif", DbType = "VarChar(3)")]
	public string CodigoClasif
	{
		get
		{
			return _CodigoClasif;
		}
		set
		{
			if (!string.Equals(_CodigoClasif, value))
			{
				_CodigoClasif = value;
			}
		}
	}

	[Column(Storage = "_Nombre", DbType = "VarChar(200)")]
	public string Nombre
	{
		get
		{
			return _Nombre;
		}
		set
		{
			if (!string.Equals(_Nombre, value))
			{
				_Nombre = value;
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

	[Column(Storage = "_EsPresupuesto", DbType = "VarChar(1)")]
	public char? EsPresupuesto
	{
		get
		{
			return _EsPresupuesto;
		}
		set
		{
			if (!_EsPresupuesto.Equals(value))
			{
				_EsPresupuesto = value;
			}
		}
	}

	[Column(Storage = "_CodigoNombre", DbType = "VarChar(212)")]
	public string CodigoNombre
	{
		get
		{
			return _CodigoNombre;
		}
		set
		{
			if (!string.Equals(_CodigoNombre, value))
			{
				_CodigoNombre = value;
			}
		}
	}

	[Column(Storage = "_YearsDe", DbType = "Int NOT NULL")]
	public int YearsDe
	{
		get
		{
			return _YearsDe;
		}
		set
		{
			if (_YearsDe != value)
			{
				_YearsDe = value;
			}
		}
	}

	[Column(Storage = "_CodigoDe", DbType = "Int NOT NULL")]
	public int CodigoDe
	{
		get
		{
			return _CodigoDe;
		}
		set
		{
			if (_CodigoDe != value)
			{
				_CodigoDe = value;
			}
		}
	}

	[Column(Storage = "_ClasificadorDe", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string ClasificadorDe
	{
		get
		{
			return _ClasificadorDe;
		}
		set
		{
			if (!string.Equals(_ClasificadorDe, value))
			{
				_ClasificadorDe = value;
			}
		}
	}

	[Column(Storage = "_SubClasificadores", DbType = "Int")]
	public int? SubClasificadores
	{
		get
		{
			return _SubClasificadores;
		}
		set
		{
			if (!_SubClasificadores.Equals(value))
			{
				_SubClasificadores = value;
			}
		}
	}
}
