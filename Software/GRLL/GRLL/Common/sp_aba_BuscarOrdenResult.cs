using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_aba_BuscarOrdenResult
{
	private string _IDORDEN;

	private DateTime? _FECHA;

	private string _IDFINANCIAMIENTO;

	private string _FINANCIAMIENTO;

	private string _CODIGOSIAF;

	private string _IDPROVEEDOR;

	private string _PROVEEDOR;

	private string _ASUNTO;

	private string _USO;

	private string _OBSERVACIONES;

	private string _REFERENCIA;

	private decimal? _MONTO;

	private char? _almacen;

	[Column(Storage = "_IDORDEN", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string IDORDEN
	{
		get
		{
			return _IDORDEN;
		}
		set
		{
			if (!string.Equals(_IDORDEN, value))
			{
				_IDORDEN = value;
			}
		}
	}

	[Column(Storage = "_FECHA", DbType = "DateTime")]
	public DateTime? FECHA
	{
		get
		{
			return _FECHA;
		}
		set
		{
			if (!_FECHA.Equals(value))
			{
				_FECHA = value;
			}
		}
	}

	[Column(Storage = "_IDFINANCIAMIENTO", DbType = "Char(2)")]
	public string IDFINANCIAMIENTO
	{
		get
		{
			return _IDFINANCIAMIENTO;
		}
		set
		{
			if (!string.Equals(_IDFINANCIAMIENTO, value))
			{
				_IDFINANCIAMIENTO = value;
			}
		}
	}

	[Column(Storage = "_FINANCIAMIENTO", DbType = "VarChar(120)")]
	public string FINANCIAMIENTO
	{
		get
		{
			return _FINANCIAMIENTO;
		}
		set
		{
			if (!string.Equals(_FINANCIAMIENTO, value))
			{
				_FINANCIAMIENTO = value;
			}
		}
	}

	[Column(Storage = "_CODIGOSIAF", DbType = "Char(6)")]
	public string CODIGOSIAF
	{
		get
		{
			return _CODIGOSIAF;
		}
		set
		{
			if (!string.Equals(_CODIGOSIAF, value))
			{
				_CODIGOSIAF = value;
			}
		}
	}

	[Column(Storage = "_IDPROVEEDOR", DbType = "Char(11)")]
	public string IDPROVEEDOR
	{
		get
		{
			return _IDPROVEEDOR;
		}
		set
		{
			if (!string.Equals(_IDPROVEEDOR, value))
			{
				_IDPROVEEDOR = value;
			}
		}
	}

	[Column(Storage = "_PROVEEDOR", DbType = "VarChar(100)")]
	public string PROVEEDOR
	{
		get
		{
			return _PROVEEDOR;
		}
		set
		{
			if (!string.Equals(_PROVEEDOR, value))
			{
				_PROVEEDOR = value;
			}
		}
	}

	[Column(Storage = "_ASUNTO", DbType = "VarChar(120)")]
	public string ASUNTO
	{
		get
		{
			return _ASUNTO;
		}
		set
		{
			if (!string.Equals(_ASUNTO, value))
			{
				_ASUNTO = value;
			}
		}
	}

	[Column(Storage = "_USO", DbType = "VarChar(180)")]
	public string USO
	{
		get
		{
			return _USO;
		}
		set
		{
			if (!string.Equals(_USO, value))
			{
				_USO = value;
			}
		}
	}

	[Column(Storage = "_OBSERVACIONES", DbType = "VarChar(600)")]
	public string OBSERVACIONES
	{
		get
		{
			return _OBSERVACIONES;
		}
		set
		{
			if (!string.Equals(_OBSERVACIONES, value))
			{
				_OBSERVACIONES = value;
			}
		}
	}

	[Column(Storage = "_REFERENCIA", DbType = "VarChar(150)")]
	public string REFERENCIA
	{
		get
		{
			return _REFERENCIA;
		}
		set
		{
			if (!string.Equals(_REFERENCIA, value))
			{
				_REFERENCIA = value;
			}
		}
	}

	[Column(Storage = "_MONTO", DbType = "Decimal(0,0)")]
	public decimal? MONTO
	{
		get
		{
			return _MONTO;
		}
		set
		{
			if (!_MONTO.Equals(value))
			{
				_MONTO = value;
			}
		}
	}

	[Column(Storage = "_almacen", DbType = "Char(1)")]
	public char? almacen
	{
		get
		{
			return _almacen;
		}
		set
		{
			if (!_almacen.Equals(value))
			{
				_almacen = value;
			}
		}
	}
}
