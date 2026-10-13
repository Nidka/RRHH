using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Contrato_ObtenerDetalladoResult
{
	private string _idcontrato;

	private DateTime? _fecha;

	private string _idproveedor;

	private string _razonsocial;

	private int? _plazodias;

	private decimal? _monto;

	private string _concepto;

	private string _estado;

	private string _idbien;

	private string _desbien;

	private string _desunidad;

	private decimal? _cantidad;

	private string _idseleccion;

	private DateTime? _fechaadjudicacion;

	private string _tipoadjudicacion;

	private string _idconsolidado;

	[Column(Storage = "_idcontrato", DbType = "Char(8) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_fecha", DbType = "DateTime")]
	public DateTime? fecha
	{
		get
		{
			return _fecha;
		}
		set
		{
			if (!_fecha.Equals(value))
			{
				_fecha = value;
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

	[Column(Storage = "_razonsocial", DbType = "VarChar(100)")]
	public string razonsocial
	{
		get
		{
			return _razonsocial;
		}
		set
		{
			if (!string.Equals(_razonsocial, value))
			{
				_razonsocial = value;
			}
		}
	}

	[Column(Storage = "_plazodias", DbType = "Int")]
	public int? plazodias
	{
		get
		{
			return _plazodias;
		}
		set
		{
			if (!_plazodias.Equals(value))
			{
				_plazodias = value;
			}
		}
	}

	[Column(Storage = "_monto", DbType = "Decimal(0,0)")]
	public decimal? monto
	{
		get
		{
			return _monto;
		}
		set
		{
			if (!_monto.Equals(value))
			{
				_monto = value;
			}
		}
	}

	[Column(Storage = "_concepto", DbType = "VarChar(120)")]
	public string concepto
	{
		get
		{
			return _concepto;
		}
		set
		{
			if (!string.Equals(_concepto, value))
			{
				_concepto = value;
			}
		}
	}

	[Column(Storage = "_estado", DbType = "Char(2)")]
	public string estado
	{
		get
		{
			return _estado;
		}
		set
		{
			if (!string.Equals(_estado, value))
			{
				_estado = value;
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

	[Column(Storage = "_idseleccion", DbType = "Char(8)")]
	public string idseleccion
	{
		get
		{
			return _idseleccion;
		}
		set
		{
			if (!string.Equals(_idseleccion, value))
			{
				_idseleccion = value;
			}
		}
	}

	[Column(Storage = "_fechaadjudicacion", DbType = "DateTime")]
	public DateTime? fechaadjudicacion
	{
		get
		{
			return _fechaadjudicacion;
		}
		set
		{
			if (!_fechaadjudicacion.Equals(value))
			{
				_fechaadjudicacion = value;
			}
		}
	}

	[Column(Storage = "_tipoadjudicacion", DbType = "Char(6)")]
	public string tipoadjudicacion
	{
		get
		{
			return _tipoadjudicacion;
		}
		set
		{
			if (!string.Equals(_tipoadjudicacion, value))
			{
				_tipoadjudicacion = value;
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
}
