using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_aba_OrdenDetalleResult
{
	private int _Item;

	private string _Codigo;

	private string _Descripcion;

	private decimal? _Cantidad;

	private decimal? _Precio;

	private string _Detalle;

	private string _CodMeta;

	private string _Meta;

	private string _CodGasto;

	private string _GastoP;

	private string _Metaanio;

	private decimal? _Monto;

	private string _U_Medida;

	private string _IDMEDIDA;

	[Column(Storage = "_Item", DbType = "Int NOT NULL")]
	public int Item
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

	[Column(Storage = "_Detalle", DbType = "VarChar(400)")]
	public string Detalle
	{
		get
		{
			return _Detalle;
		}
		set
		{
			if (!string.Equals(_Detalle, value))
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

	[Column(Storage = "_CodGasto", DbType = "VarChar(17)")]
	public string CodGasto
	{
		get
		{
			return _CodGasto;
		}
		set
		{
			if (!string.Equals(_CodGasto, value))
			{
				_CodGasto = value;
			}
		}
	}

	[Column(Storage = "_GastoP", DbType = "VarChar(100)")]
	public string GastoP
	{
		get
		{
			return _GastoP;
		}
		set
		{
			if (!string.Equals(_GastoP, value))
			{
				_GastoP = value;
			}
		}
	}

	[Column(Storage = "_Metaanio", DbType = "Char(4)")]
	public string Metaanio
	{
		get
		{
			return _Metaanio;
		}
		set
		{
			if (!string.Equals(_Metaanio, value))
			{
				_Metaanio = value;
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

	[Column(Name = "[U Medida]", Storage = "_U_Medida", DbType = "VarChar(30)")]
	public string U_Medida
	{
		get
		{
			return _U_Medida;
		}
		set
		{
			if (!string.Equals(_U_Medida, value))
			{
				_U_Medida = value;
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
}
