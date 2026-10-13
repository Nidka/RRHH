using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_ListarDetalleCotizacion")]
public class vs_ABA_ListarDetalleCotizacion
{
	private string _idcotizacion;

	private string _idconsolidado;

	private string _idbien;

	private string _desbien;

	private decimal? _cantidad;

	private decimal? _precio;

	private decimal? _importe;

	private string _observaciones;

	private string _desunidad;

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

	[Column(Storage = "_idbien", DbType = "Char(13) NOT NULL", CanBeNull = false)]
	public string idbien
	{
		get
		{
			return _idbien;
		}
		set
		{
			if (!string.Equals(_idbien, value))
			{
				_idbien = value;
			}
		}
	}

	[Column(Storage = "_desbien", DbType = "VarChar(120)")]
	public string desbien
	{
		get
		{
			return _desbien;
		}
		set
		{
			if (!string.Equals(_desbien, value))
			{
				_desbien = value;
			}
		}
	}

	[Column(Storage = "_cantidad", DbType = "Decimal(18,2)")]
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

	[Column(Storage = "_precio", DbType = "Decimal(18,2)")]
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

	[Column(Storage = "_importe", DbType = "Decimal(18,2)")]
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

	[Column(Storage = "_observaciones", DbType = "VarChar(50)")]
	public string observaciones
	{
		get
		{
			return _observaciones;
		}
		set
		{
			if (!string.Equals(_observaciones, value))
			{
				_observaciones = value;
			}
		}
	}

	[Column(Storage = "_desunidad", DbType = "Char(4)")]
	public string desunidad
	{
		get
		{
			return _desunidad;
		}
		set
		{
			if (!string.Equals(_desunidad, value))
			{
				_desunidad = value;
			}
		}
	}
}
