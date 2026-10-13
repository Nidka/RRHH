using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_ListarCotizacion")]
public class vs_ABA_ListarCotizacion
{
	private string _idcotizacion;

	private DateTime? _fecha;

	private string _idproveedor;

	private string _desproveedor;

	private string _idconsolidado;

	private decimal? _monto;

	[Column(Storage = "_idcotizacion", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string idcotizacion
	{
		get
		{
			return _idcotizacion;
		}
		set
		{
			if (!string.Equals(_idcotizacion, value))
			{
				_idcotizacion = value;
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

	[Column(Storage = "_idproveedor", DbType = "Char(11)")]
	public string idproveedor
	{
		get
		{
			return _idproveedor;
		}
		set
		{
			if (!string.Equals(_idproveedor, value))
			{
				_idproveedor = value;
			}
		}
	}

	[Column(Storage = "_desproveedor", DbType = "VarChar(100)")]
	public string desproveedor
	{
		get
		{
			return _desproveedor;
		}
		set
		{
			if (!string.Equals(_desproveedor, value))
			{
				_desproveedor = value;
			}
		}
	}

	[Column(Storage = "_idconsolidado", DbType = "Char(6)")]
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

	[Column(Storage = "_monto", DbType = "Decimal(38,2)")]
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
}
