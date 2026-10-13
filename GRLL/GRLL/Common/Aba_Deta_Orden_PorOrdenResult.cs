using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Deta_Orden_PorOrdenResult
{
	private int _item;

	private string _idbien;

	private decimal? _cantidad;

	private decimal? _precio;

	private decimal? _Importe;

	private string _desbien;

	private string _idunidadmedida;

	private string _desunidad;

	private decimal? _saldo;

	[Column(Storage = "_item", DbType = "Int NOT NULL")]
	public int item
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

	[Column(Storage = "_saldo", DbType = "Decimal(0,0)")]
	public decimal? saldo
	{
		get
		{
			return _saldo;
		}
		set
		{
			if (!_saldo.Equals(value))
			{
				_saldo = value;
			}
		}
	}
}
