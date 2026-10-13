using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_CJR_OficioSol")]
public class vs_CJR_OficioSol
{
	private string _NumOficioIniciativa;

	private int? _idoperador;

	private DateTime? _FechaEmision;

	private string _temadescrip;

	private int _numtema;

	private string _NombreResponsable;

	private string _Operador;

	private string _OficioSolTec;

	private string _DestinoSolTEc;

	private DateTime? _FechaSolTec;

	private string _tipo;

	private string _RespSolTec;

	private string _OrigenResSolTec;

	private DateTime? _FechaResSolTec;

	[Column(Storage = "_NumOficioIniciativa", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string NumOficioIniciativa
	{
		get
		{
			return _NumOficioIniciativa;
		}
		set
		{
			if (!string.Equals(_NumOficioIniciativa, value))
			{
				_NumOficioIniciativa = value;
			}
		}
	}

	[Column(Storage = "_idoperador", DbType = "Int")]
	public int? idoperador
	{
		get
		{
			return _idoperador;
		}
		set
		{
			if (!_idoperador.Equals(value))
			{
				_idoperador = value;
			}
		}
	}

	[Column(Storage = "_FechaEmision", DbType = "DateTime")]
	public DateTime? FechaEmision
	{
		get
		{
			return _FechaEmision;
		}
		set
		{
			if (!_FechaEmision.Equals(value))
			{
				_FechaEmision = value;
			}
		}
	}

	[Column(Storage = "_temadescrip", DbType = "VarChar(2000)")]
	public string temadescrip
	{
		get
		{
			return _temadescrip;
		}
		set
		{
			if (!string.Equals(_temadescrip, value))
			{
				_temadescrip = value;
			}
		}
	}

	[Column(Storage = "_numtema", DbType = "Int NOT NULL")]
	public int numtema
	{
		get
		{
			return _numtema;
		}
		set
		{
			if (_numtema != value)
			{
				_numtema = value;
			}
		}
	}

	[Column(Storage = "_NombreResponsable", DbType = "VarChar(200)")]
	public string NombreResponsable
	{
		get
		{
			return _NombreResponsable;
		}
		set
		{
			if (!string.Equals(_NombreResponsable, value))
			{
				_NombreResponsable = value;
			}
		}
	}

	[Column(Storage = "_Operador", DbType = "VarChar(162)")]
	public string Operador
	{
		get
		{
			return _Operador;
		}
		set
		{
			if (!string.Equals(_Operador, value))
			{
				_Operador = value;
			}
		}
	}

	[Column(Storage = "_OficioSolTec", DbType = "VarChar(120)")]
	public string OficioSolTec
	{
		get
		{
			return _OficioSolTec;
		}
		set
		{
			if (!string.Equals(_OficioSolTec, value))
			{
				_OficioSolTec = value;
			}
		}
	}

	[Column(Storage = "_DestinoSolTEc", DbType = "VarChar(200)")]
	public string DestinoSolTEc
	{
		get
		{
			return _DestinoSolTEc;
		}
		set
		{
			if (!string.Equals(_DestinoSolTEc, value))
			{
				_DestinoSolTEc = value;
			}
		}
	}

	[Column(Storage = "_FechaSolTec", DbType = "DateTime")]
	public DateTime? FechaSolTec
	{
		get
		{
			return _FechaSolTec;
		}
		set
		{
			if (!_FechaSolTec.Equals(value))
			{
				_FechaSolTec = value;
			}
		}
	}

	[Column(Storage = "_tipo", DbType = "VarChar(7)")]
	public string tipo
	{
		get
		{
			return _tipo;
		}
		set
		{
			if (!string.Equals(_tipo, value))
			{
				_tipo = value;
			}
		}
	}

	[Column(Storage = "_RespSolTec", DbType = "VarChar(120)")]
	public string RespSolTec
	{
		get
		{
			return _RespSolTec;
		}
		set
		{
			if (!string.Equals(_RespSolTec, value))
			{
				_RespSolTec = value;
			}
		}
	}

	[Column(Storage = "_OrigenResSolTec", DbType = "VarChar(200)")]
	public string OrigenResSolTec
	{
		get
		{
			return _OrigenResSolTec;
		}
		set
		{
			if (!string.Equals(_OrigenResSolTec, value))
			{
				_OrigenResSolTec = value;
			}
		}
	}

	[Column(Storage = "_FechaResSolTec", DbType = "DateTime")]
	public DateTime? FechaResSolTec
	{
		get
		{
			return _FechaResSolTec;
		}
		set
		{
			if (!_FechaResSolTec.Equals(value))
			{
				_FechaResSolTec = value;
			}
		}
	}
}
