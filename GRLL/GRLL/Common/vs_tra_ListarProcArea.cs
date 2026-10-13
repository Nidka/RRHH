using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_tra_ListarProcArea")]
public class vs_tra_ListarProcArea
{
	private string _IdProcedimiento;

	private string _Descripcion;

	private char? _Ambito;

	private int? _areatramite;

	private int? _areainicio;

	private int _tiempodias;

	private int _tiempohrs;

	private int _tiempomin;

	private char? _Tipo;

	private string _TraCodigo;

	private char? _Estado;

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

	[Column(Storage = "_areatramite", DbType = "Int")]
	public int? areatramite
	{
		get
		{
			return _areatramite;
		}
		set
		{
			if (!_areatramite.Equals(value))
			{
				_areatramite = value;
			}
		}
	}

	[Column(Storage = "_areainicio", DbType = "Int")]
	public int? areainicio
	{
		get
		{
			return _areainicio;
		}
		set
		{
			if (!_areainicio.Equals(value))
			{
				_areainicio = value;
			}
		}
	}

	[Column(Storage = "_tiempodias", DbType = "Int NOT NULL")]
	public int tiempodias
	{
		get
		{
			return _tiempodias;
		}
		set
		{
			if (_tiempodias != value)
			{
				_tiempodias = value;
			}
		}
	}

	[Column(Storage = "_tiempohrs", DbType = "Int NOT NULL")]
	public int tiempohrs
	{
		get
		{
			return _tiempohrs;
		}
		set
		{
			if (_tiempohrs != value)
			{
				_tiempohrs = value;
			}
		}
	}

	[Column(Storage = "_tiempomin", DbType = "Int NOT NULL")]
	public int tiempomin
	{
		get
		{
			return _tiempomin;
		}
		set
		{
			if (_tiempomin != value)
			{
				_tiempomin = value;
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

	[Column(Storage = "_TraCodigo", DbType = "Char(20) NOT NULL", CanBeNull = false)]
	public string TraCodigo
	{
		get
		{
			return _TraCodigo;
		}
		set
		{
			if (!string.Equals(_TraCodigo, value))
			{
				_TraCodigo = value;
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
}
