using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_TRA_ListarInicioArea")]
public class vs_TRA_ListarInicioArea
{
	private string _idprocedimiento;

	private string _descripcion;

	private char? _ambito;

	private int? _areatramite;

	private int? _areainicio;

	private int _tiempodias;

	private decimal _tiempohrs;

	private char? _tipo;

	private string _tracodigo;

	[Column(Storage = "_idprocedimiento", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string idprocedimiento
	{
		get
		{
			return _idprocedimiento;
		}
		set
		{
			if (!string.Equals(_idprocedimiento, value))
			{
				_idprocedimiento = value;
			}
		}
	}

	[Column(Storage = "_descripcion", DbType = "VarChar(300)")]
	public string descripcion
	{
		get
		{
			return _descripcion;
		}
		set
		{
			if (!string.Equals(_descripcion, value))
			{
				_descripcion = value;
			}
		}
	}

	[Column(Storage = "_ambito", DbType = "Char(1)")]
	public char? ambito
	{
		get
		{
			return _ambito;
		}
		set
		{
			if (!_ambito.Equals(value))
			{
				_ambito = value;
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

	[Column(Storage = "_tiempohrs", DbType = "Decimal(13,2) NOT NULL")]
	public decimal tiempohrs
	{
		get
		{
			return _tiempohrs;
		}
		set
		{
			if (decimal.Compare(_tiempohrs, value) != 0)
			{
				_tiempohrs = value;
			}
		}
	}

	[Column(Storage = "_tipo", DbType = "Char(1)")]
	public char? tipo
	{
		get
		{
			return _tipo;
		}
		set
		{
			if (!_tipo.Equals(value))
			{
				_tipo = value;
			}
		}
	}

	[Column(Storage = "_tracodigo", DbType = "Char(20) NOT NULL", CanBeNull = false)]
	public string tracodigo
	{
		get
		{
			return _tracodigo;
		}
		set
		{
			if (!string.Equals(_tracodigo, value))
			{
				_tracodigo = value;
			}
		}
	}
}
