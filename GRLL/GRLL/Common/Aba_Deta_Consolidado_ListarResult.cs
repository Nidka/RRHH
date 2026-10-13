using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Deta_Consolidado_ListarResult
{
	private byte _item;

	private string _idconsolidado;

	private string _idbien;

	private decimal? _cantidad;

	private decimal? _precio;

	private decimal? _importe;

	private string _idproveedor;

	private string _desproveedor;

	private string _desbien;

	private string _idunidadmedida;

	private string _desunidad;

	private string _idcontrato;

	private int _asignado;

	private decimal? _cantidadpro;

	private decimal? _preciopro;

	private decimal? _importepro;

	[Column(Storage = "_item", DbType = "TinyInt NOT NULL")]
	public byte item
	{
		get
		{
			return _item;
		}
		set
		{
			if (_item != value)
			{
				_item = value;
			}
		}
	}

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

	[Column(Storage = "_idunidadmedida", DbType = "Char(4)")]
	public string idunidadmedida
	{
		get
		{
			return _idunidadmedida;
		}
		set
		{
			if (!string.Equals(_idunidadmedida, value))
			{
				_idunidadmedida = value;
			}
		}
	}

	[Column(Storage = "_desunidad", DbType = "VarChar(30)")]
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

	[Column(Storage = "_idcontrato", DbType = "Char(8)")]
	public string idcontrato
	{
		get
		{
			return _idcontrato;
		}
		set
		{
			if (!string.Equals(_idcontrato, value))
			{
				_idcontrato = value;
			}
		}
	}

	[Column(Storage = "_asignado", DbType = "Int NOT NULL")]
	public int asignado
	{
		get
		{
			return _asignado;
		}
		set
		{
			if (_asignado != value)
			{
				_asignado = value;
			}
		}
	}

	[Column(Storage = "_cantidadpro", DbType = "Decimal(0,0)")]
	public decimal? cantidadpro
	{
		get
		{
			return _cantidadpro;
		}
		set
		{
			if (!_cantidadpro.Equals(value))
			{
				_cantidadpro = value;
			}
		}
	}

	[Column(Storage = "_preciopro", DbType = "Decimal(0,0)")]
	public decimal? preciopro
	{
		get
		{
			return _preciopro;
		}
		set
		{
			if (!_preciopro.Equals(value))
			{
				_preciopro = value;
			}
		}
	}

	[Column(Storage = "_importepro", DbType = "Decimal(0,0)")]
	public decimal? importepro
	{
		get
		{
			return _importepro;
		}
		set
		{
			if (!_importepro.Equals(value))
			{
				_importepro = value;
			}
		}
	}
}
