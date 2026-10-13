using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Pedido_GetAllResult
{
	private string _IdPedido;

	private int? _IdAreaOrganiz;

	private DateTime? _Fecha;

	private string _Responsable;

	private string _Estado;

	private DateTime? _FechaAprobacion;

	private DateTime? _FechaDespacho;

	private char? _Tipo;

	private string _Anio;

	private string _IdTipoDoc;

	private decimal? _MontoPedido;

	private decimal? _MontoAprobado;

	private int? _IdAreaUbicacion;

	private string _Observaciones;

	private string _ObservacionesAprob;

	[Column(Storage = "_IdPedido", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string IdPedido
	{
		get
		{
			return _IdPedido;
		}
		set
		{
			if (!string.Equals(_IdPedido, value))
			{
				_IdPedido = value;
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

	[Column(Storage = "_Fecha", DbType = "DateTime")]
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
				_Fecha = value;
			}
		}
	}

	[Column(Storage = "_Responsable", DbType = "Char(8)")]
	public string Responsable
	{
		get
		{
			return _Responsable;
		}
		set
		{
			if (!string.Equals(_Responsable, value))
			{
				_Responsable = value;
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Char(2)")]
	public string Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!string.Equals(_Estado, value))
			{
				_Estado = value;
			}
		}
	}

	[Column(Storage = "_FechaAprobacion", DbType = "DateTime")]
	public DateTime? FechaAprobacion
	{
		get
		{
			return _FechaAprobacion;
		}
		set
		{
			if (!_FechaAprobacion.Equals(value))
			{
				_FechaAprobacion = value;
			}
		}
	}

	[Column(Storage = "_FechaDespacho", DbType = "DateTime")]
	public DateTime? FechaDespacho
	{
		get
		{
			return _FechaDespacho;
		}
		set
		{
			if (!_FechaDespacho.Equals(value))
			{
				_FechaDespacho = value;
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

	[Column(Storage = "_Anio", DbType = "Char(4)")]
	public string Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!string.Equals(_Anio, value))
			{
				_Anio = value;
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

	[Column(Storage = "_MontoPedido", DbType = "Decimal(0,0)")]
	public decimal? MontoPedido
	{
		get
		{
			return _MontoPedido;
		}
		set
		{
			if (!_MontoPedido.Equals(value))
			{
				_MontoPedido = value;
			}
		}
	}

	[Column(Storage = "_MontoAprobado", DbType = "Decimal(0,0)")]
	public decimal? MontoAprobado
	{
		get
		{
			return _MontoAprobado;
		}
		set
		{
			if (!_MontoAprobado.Equals(value))
			{
				_MontoAprobado = value;
			}
		}
	}

	[Column(Storage = "_IdAreaUbicacion", DbType = "Int")]
	public int? IdAreaUbicacion
	{
		get
		{
			return _IdAreaUbicacion;
		}
		set
		{
			if (!_IdAreaUbicacion.Equals(value))
			{
				_IdAreaUbicacion = value;
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(120)")]
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

	[Column(Storage = "_ObservacionesAprob", DbType = "VarChar(120)")]
	public string ObservacionesAprob
	{
		get
		{
			return _ObservacionesAprob;
		}
		set
		{
			if (!string.Equals(_ObservacionesAprob, value))
			{
				_ObservacionesAprob = value;
			}
		}
	}
}
