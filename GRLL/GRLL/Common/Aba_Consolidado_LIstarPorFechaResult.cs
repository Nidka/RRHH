using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Consolidado_LIstarPorFechaResult
{
	private string _IdConsolidado;

	private DateTime? _Fecha;

	private DateTime? _FechaAdjudicacion;

	private string _destipoadjudicacion;

	private string _TipoAdjudicacion;

	private string _Estado;

	private decimal? _monto;

	private string _desestado;

	[Column(Storage = "_IdConsolidado", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string IdConsolidado
	{
		get
		{
			return _IdConsolidado;
		}
		set
		{
			if (!string.Equals(_IdConsolidado, value))
			{
				_IdConsolidado = value;
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

	[Column(Storage = "_FechaAdjudicacion", DbType = "DateTime")]
	public DateTime? FechaAdjudicacion
	{
		get
		{
			return _FechaAdjudicacion;
		}
		set
		{
			if (!_FechaAdjudicacion.Equals(value))
			{
				_FechaAdjudicacion = value;
			}
		}
	}

	[Column(Storage = "_destipoadjudicacion", DbType = "VarChar(50)")]
	public string destipoadjudicacion
	{
		get
		{
			return _destipoadjudicacion;
		}
		set
		{
			if (!string.Equals(_destipoadjudicacion, value))
			{
				_destipoadjudicacion = value;
			}
		}
	}

	[Column(Storage = "_TipoAdjudicacion", DbType = "Char(6)")]
	public string TipoAdjudicacion
	{
		get
		{
			return _TipoAdjudicacion;
		}
		set
		{
			if (!string.Equals(_TipoAdjudicacion, value))
			{
				_TipoAdjudicacion = value;
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

	[Column(Storage = "_monto", DbType = "Decimal(0,0)")]
	public decimal? monto
	{
		get
		{
			return _monto;
		}
		set
		{
			if (!_monto.Equals(value))
			{
				_monto = value;
			}
		}
	}

	[Column(Storage = "_desestado", DbType = "VarChar(20)")]
	public string desestado
	{
		get
		{
			return _desestado;
		}
		set
		{
			if (!string.Equals(_desestado, value))
			{
				_desestado = value;
			}
		}
	}
}
