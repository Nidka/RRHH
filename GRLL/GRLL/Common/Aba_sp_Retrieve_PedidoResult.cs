using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_sp_Retrieve_PedidoResult
{
	private string _IdPedido;

	private int? _IdAreaOrganiz;

	private DateTime? _Fecha;

	private string _Responsable;

	private string _Estado;

	private DateTime? _FechaAprobacion;

	private DateTime? _FechaAutorizacion;

	private DateTime? _FechaDespacho;

	private char? _Tipo;

	private string _Anio;

	private string _IdTipoDoc;

	private decimal? _MontoPedido;

	private decimal? _MontoAprobado;

	private int? _IdAreaUbicacion;

	private int? _IdAreaAutorizacion;

	private string _IdFinanciamiento;

	private string _IdTipoRecurso;

	private string _Observaciones;

	private string _ObservacionesAprob;

	private string _ObservacionesAuto;

	private string _Especificaciones;

	private string _areaorganizacional;

	private string _financiamiento;

	private string _tiporecurso;

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

	[Column(Storage = "_FechaAutorizacion", DbType = "DateTime")]
	public DateTime? FechaAutorizacion
	{
		get
		{
			return _FechaAutorizacion;
		}
		set
		{
			if (!_FechaAutorizacion.Equals(value))
			{
				_FechaAutorizacion = value;
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

	[Column(Storage = "_IdAreaAutorizacion", DbType = "Int")]
	public int? IdAreaAutorizacion
	{
		get
		{
			return _IdAreaAutorizacion;
		}
		set
		{
			if (!_IdAreaAutorizacion.Equals(value))
			{
				_IdAreaAutorizacion = value;
			}
		}
	}

	[Column(Storage = "_IdFinanciamiento", DbType = "Char(2)")]
	public string IdFinanciamiento
	{
		get
		{
			return _IdFinanciamiento;
		}
		set
		{
			if (!string.Equals(_IdFinanciamiento, value))
			{
				_IdFinanciamiento = value;
			}
		}
	}

	[Column(Storage = "_IdTipoRecurso", DbType = "Char(3)")]
	public string IdTipoRecurso
	{
		get
		{
			return _IdTipoRecurso;
		}
		set
		{
			if (!string.Equals(_IdTipoRecurso, value))
			{
				_IdTipoRecurso = value;
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

	[Column(Storage = "_ObservacionesAuto", DbType = "VarChar(120)")]
	public string ObservacionesAuto
	{
		get
		{
			return _ObservacionesAuto;
		}
		set
		{
			if (!string.Equals(_ObservacionesAuto, value))
			{
				_ObservacionesAuto = value;
			}
		}
	}

	[Column(Storage = "_Especificaciones", DbType = "VarChar(80)")]
	public string Especificaciones
	{
		get
		{
			return _Especificaciones;
		}
		set
		{
			if (!string.Equals(_Especificaciones, value))
			{
				_Especificaciones = value;
			}
		}
	}

	[Column(Storage = "_areaorganizacional", DbType = "VarChar(200) NOT NULL", CanBeNull = false)]
	public string areaorganizacional
	{
		get
		{
			return _areaorganizacional;
		}
		set
		{
			if (!string.Equals(_areaorganizacional, value))
			{
				_areaorganizacional = value;
			}
		}
	}

	[Column(Storage = "_financiamiento", DbType = "VarChar(120)")]
	public string financiamiento
	{
		get
		{
			return _financiamiento;
		}
		set
		{
			if (!string.Equals(_financiamiento, value))
			{
				_financiamiento = value;
			}
		}
	}

	[Column(Storage = "_tiporecurso", DbType = "VarChar(120)")]
	public string tiporecurso
	{
		get
		{
			return _tiporecurso;
		}
		set
		{
			if (!string.Equals(_tiporecurso, value))
			{
				_tiporecurso = value;
			}
		}
	}
}
