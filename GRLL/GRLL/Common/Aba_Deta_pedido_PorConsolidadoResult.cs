using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Deta_pedido_PorConsolidadoResult
{
	private string _idbien;

	private string _descripcion;

	private decimal? _cantidad;

	private string _meta;

	private string _desmeta;

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

	[Column(Storage = "_meta", DbType = "VarChar(4)")]
	public string meta
	{
		get
		{
			return _meta;
		}
		set
		{
			if (!string.Equals(_meta, value))
			{
				_meta = value;
			}
		}
	}

	[Column(Storage = "_desmeta", DbType = "VarChar(255)")]
	public string desmeta
	{
		get
		{
			return _desmeta;
		}
		set
		{
			if (!string.Equals(_desmeta, value))
			{
				_desmeta = value;
			}
		}
	}
}
