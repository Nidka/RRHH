using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Bien_StockPorAlmacenResult
{
	private string _idbien;

	private string _descripcion;

	private char? _estado;

	private string _idunidadmedida;

	private string _desunidad;

	private decimal _precioref;

	private char? _tipo;

	private decimal? _stock;

	private string _idalmacen;

	private string _desalmacen;

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

	[Column(Storage = "_descripcion", DbType = "VarChar(120)")]
	public string descripcion
	{
		get
		{
			return _descripcion;
		}
		set
		{
			if (!string.Equals(_descripcion, value))
			{
				_descripcion = value;
			}
		}
	}

	[Column(Storage = "_estado", DbType = "Char(1)")]
	public char? estado
	{
		get
		{
			return _estado;
		}
		set
		{
			if (!_estado.Equals(value))
			{
				_estado = value;
			}
		}
	}

	[Column(Storage = "_idunidadmedida", DbType = "Char(4) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_precioref", DbType = "Decimal(0,0) NOT NULL")]
	public decimal precioref
	{
		get
		{
			return _precioref;
		}
		set
		{
			if (decimal.Compare(_precioref, value) != 0)
			{
				_precioref = value;
			}
		}
	}

	[Column(Storage = "_tipo", DbType = "Char(1)")]
	public char? tipo
	{
		get
		{
			return _tipo;
		}
		set
		{
			if (!_tipo.Equals(value))
			{
				_tipo = value;
			}
		}
	}

	[Column(Storage = "_stock", DbType = "Decimal(0,0)")]
	public decimal? stock
	{
		get
		{
			return _stock;
		}
		set
		{
			if (!_stock.Equals(value))
			{
				_stock = value;
			}
		}
	}

	[Column(Storage = "_idalmacen", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string idalmacen
	{
		get
		{
			return _idalmacen;
		}
		set
		{
			if (!string.Equals(_idalmacen, value))
			{
				_idalmacen = value;
			}
		}
	}

	[Column(Storage = "_desalmacen", DbType = "VarChar(120)")]
	public string desalmacen
	{
		get
		{
			return _desalmacen;
		}
		set
		{
			if (!string.Equals(_desalmacen, value))
			{
				_desalmacen = value;
			}
		}
	}
}
