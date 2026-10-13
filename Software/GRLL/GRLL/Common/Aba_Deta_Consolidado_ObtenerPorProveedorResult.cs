using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Deta_Consolidado_ObtenerPorProveedorResult
{
	private string _idconsolidado;

	private DateTime? _fecha;

	private DateTime? _fechaadjudicacion;

	private string _destipoadjudica;

	private decimal? _Monto;

	[Column(Storage = "_idconsolidado", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string idconsolidado
	{
		get
		{
			return _idconsolidado;
		}
		set
		{
			if (!string.Equals(_idconsolidado, value))
			{
				_idconsolidado = value;
			}
		}
	}

	[Column(Storage = "_fecha", DbType = "DateTime")]
	public DateTime? fecha
	{
		get
		{
			return _fecha;
		}
		set
		{
			if (!_fecha.Equals(value))
			{
				_fecha = value;
			}
		}
	}

	[Column(Storage = "_fechaadjudicacion", DbType = "DateTime")]
	public DateTime? fechaadjudicacion
	{
		get
		{
			return _fechaadjudicacion;
		}
		set
		{
			if (!_fechaadjudicacion.Equals(value))
			{
				_fechaadjudicacion = value;
			}
		}
	}

	[Column(Storage = "_destipoadjudica", DbType = "VarChar(50)")]
	public string destipoadjudica
	{
		get
		{
			return _destipoadjudica;
		}
		set
		{
			if (!string.Equals(_destipoadjudica, value))
			{
				_destipoadjudica = value;
			}
		}
	}

	[Column(Storage = "_Monto", DbType = "Decimal(0,0)")]
	public decimal? Monto
	{
		get
		{
			return _Monto;
		}
		set
		{
			if (!_Monto.Equals(value))
			{
				_Monto = value;
			}
		}
	}
}
