using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Contrato_ObtenerListadoResult
{
	private string _idcontrato;

	private DateTime? _fecha;

	private string _idproveedor;

	private string _razonsocial;

	private int? _plazodias;

	private decimal? _monto;

	private string _concepto;

	private string _estado;

	[Column(Storage = "_idcontrato", DbType = "VarChar(8) NOT NULL", CanBeNull = false)]
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
}
