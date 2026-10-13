using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Deta_Pedido_GetAllResult
{
	private string _IdMeta;

	private string _IdBien;

	private string _IdPedido;

	private decimal? _Cantidad;

	private string _Observaciones;

	private string _MotivoRechazo;

	private char? _Estado;

	private decimal? _CantidadAprobada;

	private int _Item;

	private decimal? _Precio;

	private decimal? _Importe;

	[Column(Storage = "_IdMeta", DbType = "Char(6)")]
	public string IdMeta
	{
		get
		{
			return _IdMeta;
		}
		set
		{
			if (!string.Equals(_IdMeta, value))
			{
				_IdMeta = value;
			}
		}
	}

	[Column(Storage = "_IdBien", DbType = "Char(13) NOT NULL", CanBeNull = false)]
	public string IdBien
	{
		get
		{
			return _IdBien;
		}
		set
		{
			if (!string.Equals(_IdBien, value))
			{
				_IdBien = value;
			}
		}
	}

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

	[Column(Storage = "_MotivoRechazo", DbType = "VarChar(120)")]
	public string MotivoRechazo
	{
		get
		{
			return _MotivoRechazo;
		}
		set
		{
			if (!string.Equals(_MotivoRechazo, value))
			{
				_MotivoRechazo = value;
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Char(1)")]
	public char? Estado
	{
		get
		{
			return _Estado;
		}
		set
		{
			if (!_Estado.Equals(value))
			{
				_Estado = value;
			}
		}
	}

	[Column(Storage = "_CantidadAprobada", DbType = "Decimal(0,0)")]
	public decimal? CantidadAprobada
	{
		get
		{
			return _CantidadAprobada;
		}
		set
		{
			if (!_CantidadAprobada.Equals(value))
			{
				_CantidadAprobada = value;
			}
		}
	}

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
}
