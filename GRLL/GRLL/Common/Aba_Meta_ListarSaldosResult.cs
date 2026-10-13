using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Meta_ListarSaldosResult
{
	private string _idorden;

	private string _idmeta;

	private string _descripcion;

	private string _desbien;

	private decimal? _cantidad;

	private decimal? _importe;

	[Column(Storage = "_idorden", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string idorden
	{
		get
		{
			return _idorden;
		}
		set
		{
			if (!string.Equals(_idorden, value))
			{
				_idorden = value;
			}
		}
	}

	[Column(Storage = "_idmeta", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string idmeta
	{
		get
		{
			return _idmeta;
		}
		set
		{
			if (!string.Equals(_idmeta, value))
			{
				_idmeta = value;
			}
		}
	}

	[Column(Storage = "_descripcion", DbType = "VarChar(255)")]
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
