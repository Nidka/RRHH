using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Deta_Consolidado_PorContratoResult
{
	private string _idconsolidado;

	private byte _Item;

	private string _Codigo;

	private string _Descripcion;

	private decimal? _Cantidad;

	private decimal? _Precio;

	private char _Detalle;

	private string _CodMeta;

	private string _Meta;

	private char _CodGasto;

	private char _GastoP;

	private string _MetaAnio;

	private decimal? _Monto;

	private string _U_MEDIDA;

	private string _IDMEDIDA;

	private decimal? _IGV;

	private decimal? _PrecioSIGV;

	private decimal? _Importe;

	private decimal? _CantidadSaldo;

	private decimal? _PrecioPro;

	private decimal? _ImportePro;

	private string _idproveedor;

	private string _desproveedor;

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

	[Column(Storage = "_Item", DbType = "TinyInt NOT NULL")]
	public byte Item
	{
		get
		{
			return _Item;
		}
		set
		{
			if (_Item != value)
			{
				_Item = value;
			}
		}
	}

	[Column(Storage = "_Codigo", DbType = "Char(13) NOT NULL", CanBeNull = false)]
	public string Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			if (!string.Equals(_Codigo, value))
			{
				_Codigo = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(120)")]
	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			if (!string.Equals(_Descripcion, value))
			{
				_Descripcion = value;
			}
		}
	}

	[Column(Storage = "_Cantidad", DbType = "Decimal(0,0)")]
	public decimal? Cantidad
	{
		get
		{
			return _Cantidad;
		}
		set
		{
			if (!_Cantidad.Equals(value))
			{
				_Cantidad = value;
			}
		}
	}

	[Column(Storage = "_Precio", DbType = "Decimal(0,0)")]
	public decimal? Precio
	{
		get
		{
			return _Precio;
		}
		set
		{
			if (!_Precio.Equals(value))
			{
				_Precio = value;
			}
		}
	}

	[Column(Storage = "_Detalle", DbType = "VarChar(1) NOT NULL")]
	public char Detalle
	{
		get
		{
			return _Detalle;
		}
		set
		{
			if (_Detalle != value)
			{
				_Detalle = value;
			}
		}
	}

	[Column(Storage = "_CodMeta", DbType = "Char(6)")]
	public string CodMeta
	{
		get
		{
			return _CodMeta;
		}
		set
		{
			if (!string.Equals(_CodMeta, value))
			{
				_CodMeta = value;
			}
		}
	}

	[Column(Storage = "_Meta", DbType = "VarChar(255)")]
	public string Meta
	{
		get
		{
			return _Meta;
		}
		set
		{
			if (!string.Equals(_Meta, value))
			{
				_Meta = value;
			}
		}
	}

	[Column(Storage = "_CodGasto", DbType = "VarChar(1) NOT NULL")]
	public char CodGasto
	{
		get
		{
			return _CodGasto;
		}
		set
		{
			if (_CodGasto != value)
			{
				_CodGasto = value;
			}
		}
	}

	[Column(Storage = "_GastoP", DbType = "VarChar(1) NOT NULL")]
	public char GastoP
	{
		get
		{
			return _GastoP;
		}
		set
		{
			if (_GastoP != value)
			{
				_GastoP = value;
			}
		}
	}

	[Column(Storage = "_MetaAnio", DbType = "VarChar(4)")]
	public string MetaAnio
	{
		get
		{
			return _MetaAnio;
		}
		set
		{
			if (!string.Equals(_MetaAnio, value))
			{
				_MetaAnio = value;
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

	[Column(Storage = "_U_MEDIDA", DbType = "VarChar(30)")]
	public string U_MEDIDA
	{
		get
		{
			return _U_MEDIDA;
		}
		set
		{
			if (!string.Equals(_U_MEDIDA, value))
			{
				_U_MEDIDA = value;
			}
		}
	}

	[Column(Storage = "_IDMEDIDA", DbType = "Char(4)")]
	public string IDMEDIDA
	{
		get
		{
			return _IDMEDIDA;
		}
		set
		{
			if (!string.Equals(_IDMEDIDA, value))
			{
				_IDMEDIDA = value;
			}
		}
	}

	[Column(Storage = "_IGV", DbType = "Decimal(0,0)")]
	public decimal? IGV
	{
		get
		{
			return _IGV;
		}
		set
		{
			if (!_IGV.Equals(value))
			{
				_IGV = value;
			}
		}
	}

	[Column(Storage = "_PrecioSIGV", DbType = "Decimal(0,0)")]
	public decimal? PrecioSIGV
	{
		get
		{
			return _PrecioSIGV;
		}
		set
		{
			if (!_PrecioSIGV.Equals(value))
			{
				_PrecioSIGV = value;
			}
		}
	}

	[Column(Storage = "_Importe", DbType = "Decimal(0,0)")]
	public decimal? Importe
	{
		get
		{
			return _Importe;
		}
		set
		{
			if (!_Importe.Equals(value))
			{
				_Importe = value;
			}
		}
	}

	[Column(Storage = "_CantidadSaldo", DbType = "Decimal(0,0)")]
	public decimal? CantidadSaldo
	{
		get
		{
			return _CantidadSaldo;
		}
		set
		{
			if (!_CantidadSaldo.Equals(value))
			{
				_CantidadSaldo = value;
			}
		}
	}

	[Column(Storage = "_PrecioPro", DbType = "Decimal(0,0)")]
	public decimal? PrecioPro
	{
		get
		{
			return _PrecioPro;
		}
		set
		{
			if (!_PrecioPro.Equals(value))
			{
				_PrecioPro = value;
			}
		}
	}

	[Column(Storage = "_ImportePro", DbType = "Decimal(0,0)")]
	public decimal? ImportePro
	{
		get
		{
			return _ImportePro;
		}
		set
		{
			if (!_ImportePro.Equals(value))
			{
				_ImportePro = value;
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
}
