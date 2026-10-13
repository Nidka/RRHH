using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_Tra_vs_TRA_ListarMovimientoResult
{
	private string _idmovimiento;

	private string _nummovimiento;

	private string _numtramite;

	private string _idtramite;

	private DateTime? _fechatramite;

	private string _asunto;

	private int? _idareaorganiz;

	private string _desareatramite;

	private DateTime? _fechaingreso;

	private decimal? _numrecepcion;

	private int? _areaingreso;

	private string _desareaingreso;

	private int? _idempleado;

	private string _desempleado;

	private string _estado;

	private DateTime? _fechasalida;

	private int? _areadestino;

	private string _desareadestino;

	private int? _tiempodias;

	private decimal? _tiempohrs;

	private string _desetapa;

	private string _idetapaproc;

	private byte? _idtiposilencio;

	private string _destiposilencio;

	private string _movimientodestino;

	private string _estadotramite;

	private string _atrasado;

	private DateTime? _fechaenvio;

	private char? _ambito;

	private string _idprocedimiento;

	[Column(Storage = "_idmovimiento", DbType = "Char(10) NOT NULL", CanBeNull = false)]
	public string idmovimiento
	{
		get
		{
			return _idmovimiento;
		}
		set
		{
			if (!string.Equals(_idmovimiento, value))
			{
				_idmovimiento = value;
			}
		}
	}

	[Column(Storage = "_nummovimiento", DbType = "VarChar(6)")]
	public string nummovimiento
	{
		get
		{
			return _nummovimiento;
		}
		set
		{
			if (!string.Equals(_nummovimiento, value))
			{
				_nummovimiento = value;
			}
		}
	}

	[Column(Storage = "_numtramite", DbType = "VarChar(6)")]
	public string numtramite
	{
		get
		{
			return _numtramite;
		}
		set
		{
			if (!string.Equals(_numtramite, value))
			{
				_numtramite = value;
			}
		}
	}

	[Column(Storage = "_idtramite", DbType = "Char(10)")]
	public string idtramite
	{
		get
		{
			return _idtramite;
		}
		set
		{
			if (!string.Equals(_idtramite, value))
			{
				_idtramite = value;
			}
		}
	}

	[Column(Storage = "_fechatramite", DbType = "DateTime")]
	public DateTime? fechatramite
	{
		get
		{
			return _fechatramite;
		}
		set
		{
			if (!_fechatramite.Equals(value))
			{
				_fechatramite = value;
			}
		}
	}

	[Column(Storage = "_asunto", DbType = "VarChar(250)")]
	public string asunto
	{
		get
		{
			return _asunto;
		}
		set
		{
			if (!string.Equals(_asunto, value))
			{
				_asunto = value;
			}
		}
	}

	[Column(Storage = "_idareaorganiz", DbType = "Int")]
	public int? idareaorganiz
	{
		get
		{
			return _idareaorganiz;
		}
		set
		{
			if (!_idareaorganiz.Equals(value))
			{
				_idareaorganiz = value;
			}
		}
	}

	[Column(Storage = "_desareatramite", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string desareatramite
	{
		get
		{
			return _desareatramite;
		}
		set
		{
			if (!string.Equals(_desareatramite, value))
			{
				_desareatramite = value;
			}
		}
	}

	[Column(Storage = "_fechaingreso", DbType = "DateTime")]
	public DateTime? fechaingreso
	{
		get
		{
			return _fechaingreso;
		}
		set
		{
			if (!_fechaingreso.Equals(value))
			{
				_fechaingreso = value;
			}
		}
	}

	[Column(Storage = "_numrecepcion", DbType = "Decimal(0,0)")]
	public decimal? numrecepcion
	{
		get
		{
			return _numrecepcion;
		}
		set
		{
			if (!_numrecepcion.Equals(value))
			{
				_numrecepcion = value;
			}
		}
	}

	[Column(Storage = "_areaingreso", DbType = "Int")]
	public int? areaingreso
	{
		get
		{
			return _areaingreso;
		}
		set
		{
			if (!_areaingreso.Equals(value))
			{
				_areaingreso = value;
			}
		}
	}

	[Column(Storage = "_desareaingreso", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string desareaingreso
	{
		get
		{
			return _desareaingreso;
		}
		set
		{
			if (!string.Equals(_desareaingreso, value))
			{
				_desareaingreso = value;
			}
		}
	}

	[Column(Storage = "_idempleado", DbType = "Int")]
	public int? idempleado
	{
		get
		{
			return _idempleado;
		}
		set
		{
			if (!_idempleado.Equals(value))
			{
				_idempleado = value;
			}
		}
	}

	[Column(Storage = "_desempleado", DbType = "VarChar(162)")]
	public string desempleado
	{
		get
		{
			return _desempleado;
		}
		set
		{
			if (!string.Equals(_desempleado, value))
			{
				_desempleado = value;
			}
		}
	}

	[Column(Storage = "_estado", DbType = "Char(2)")]
	public string estado
	{
		get
		{
			return _estado;
		}
		set
		{
			if (!string.Equals(_estado, value))
			{
				_estado = value;
			}
		}
	}

	[Column(Storage = "_fechasalida", DbType = "DateTime")]
	public DateTime? fechasalida
	{
		get
		{
			return _fechasalida;
		}
		set
		{
			if (!_fechasalida.Equals(value))
			{
				_fechasalida = value;
			}
		}
	}

	[Column(Storage = "_areadestino", DbType = "Int")]
	public int? areadestino
	{
		get
		{
			return _areadestino;
		}
		set
		{
			if (!_areadestino.Equals(value))
			{
				_areadestino = value;
			}
		}
	}

	[Column(Storage = "_desareadestino", DbType = "VarChar(200)")]
	public string desareadestino
	{
		get
		{
			return _desareadestino;
		}
		set
		{
			if (!string.Equals(_desareadestino, value))
			{
				_desareadestino = value;
			}
		}
	}

	[Column(Storage = "_tiempodias", DbType = "Int")]
	public int? tiempodias
	{
		get
		{
			return _tiempodias;
		}
		set
		{
			if (!_tiempodias.Equals(value))
			{
				_tiempodias = value;
			}
		}
	}

	[Column(Storage = "_tiempohrs", DbType = "Decimal(0,0)")]
	public decimal? tiempohrs
	{
		get
		{
			return _tiempohrs;
		}
		set
		{
			if (!_tiempohrs.Equals(value))
			{
				_tiempohrs = value;
			}
		}
	}

	[Column(Storage = "_desetapa", DbType = "VarChar(400)")]
	public string desetapa
	{
		get
		{
			return _desetapa;
		}
		set
		{
			if (!string.Equals(_desetapa, value))
			{
				_desetapa = value;
			}
		}
	}

	[Column(Storage = "_idetapaproc", DbType = "Char(8)")]
	public string idetapaproc
	{
		get
		{
			return _idetapaproc;
		}
		set
		{
			if (!string.Equals(_idetapaproc, value))
			{
				_idetapaproc = value;
			}
		}
	}

	[Column(Storage = "_idtiposilencio", DbType = "TinyInt")]
	public byte? idtiposilencio
	{
		get
		{
			return _idtiposilencio;
		}
		set
		{
			if (!_idtiposilencio.Equals(value))
			{
				_idtiposilencio = value;
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

	[Column(Storage = "_movimientodestino", DbType = "Char(10)")]
	public string movimientodestino
	{
		get
		{
			return _movimientodestino;
		}
		set
		{
			if (!string.Equals(_movimientodestino, value))
			{
				_movimientodestino = value;
			}
		}
	}

	[Column(Storage = "_estadotramite", DbType = "Char(2)")]
	public string estadotramite
	{
		get
		{
			return _estadotramite;
		}
		set
		{
			if (!string.Equals(_estadotramite, value))
			{
				_estadotramite = value;
			}
		}
	}

	[Column(Storage = "_atrasado", DbType = "VarChar(2) NOT NULL", CanBeNull = false)]
	public string atrasado
	{
		get
		{
			return _atrasado;
		}
		set
		{
			if (!string.Equals(_atrasado, value))
			{
				_atrasado = value;
			}
		}
	}

	[Column(Storage = "_fechaenvio", DbType = "DateTime")]
	public DateTime? fechaenvio
	{
		get
		{
			return _fechaenvio;
		}
		set
		{
			if (!_fechaenvio.Equals(value))
			{
				_fechaenvio = value;
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

	[Column(Storage = "_idprocedimiento", DbType = "Char(6)")]
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
}
