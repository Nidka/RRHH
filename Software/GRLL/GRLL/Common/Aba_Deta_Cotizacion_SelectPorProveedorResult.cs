using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Deta_Cotizacion_SelectPorProveedorResult
{
	private string _idcotizacion;

	private DateTime? _fecha;

	private string _idproveedor;

	private decimal? _cantidad;

	private decimal? _precio;

	private decimal? _importe;

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

	[Column(Storage = "_cantidad", DbType = "Decimal(0,0)")]
	public decimal? cantidad
	{
		get
		{
			return _cantidad;
		}
		set
		{
			if (!_cantidad.Equals(value))
			{
				_cantidad = value;
			}
		}
	}

	[Column(Storage = "_precio", DbType = "Decimal(0,0)")]
	public decimal? precio
	{
		get
		{
			return _precio;
		}
		set
		{
			if (!_precio.Equals(value))
			{
				_precio = value;
			}
		}
	}

	[Column(Storage = "_importe", DbType = "Decimal(0,0)")]
	public decimal? importe
	{
		get
		{
			return _importe;
		}
		set
		{
			if (!_importe.Equals(value))
			{
				_importe = value;
			}
		}
	}
}
