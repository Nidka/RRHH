using System;
using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_ABA_ImpOrdenCBienResult
{
	private string _idorden;

	private char _tipoorden;

	private string _FIdOrden;

	private string _idproveedor;

	private string _RazonSocial;

	private string _direccion;

	private string _RUC;

	private string _idfinanciamiento;

	private string _financiamiento;

	private string _SIAF;

	private string _DocReferencia;

	private string _Almacen;

	private string _AlmDirec;

	private string _uso;

	private string _asunto;

	private string _observaciones;

	private DateTime? _fecha;

	private decimal? _TotalTotal;

	private int? _Año;

	private int? _mes;

	private int? _dia;

	private string _TIPODOCADJ;

	private string _NRODOCADJ;

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

	[Column(Storage = "_tipoorden", DbType = "Char(1) NOT NULL")]
	public char tipoorden
	{
		get
		{
			return _tipoorden;
		}
		set
		{
			if (_tipoorden != value)
			{
				_tipoorden = value;
			}
		}
	}

	[Column(Storage = "_FIdOrden", DbType = "VarChar(6)")]
	public string FIdOrden
	{
		get
		{
			return _FIdOrden;
		}
		set
		{
			if (!string.Equals(_FIdOrden, value))
			{
				_FIdOrden = value;
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

	[Column(Storage = "_RazonSocial", DbType = "VarChar(100)")]
	public string RazonSocial
	{
		get
		{
			return _RazonSocial;
		}
		set
		{
			if (!string.Equals(_RazonSocial, value))
			{
				_RazonSocial = value;
			}
		}
	}

	[Column(Storage = "_direccion", DbType = "VarChar(100)")]
	public string direccion
	{
		get
		{
			return _direccion;
		}
		set
		{
			if (!string.Equals(_direccion, value))
			{
				_direccion = value;
			}
		}
	}

	[Column(Storage = "_RUC", DbType = "Char(12)")]
	public string RUC
	{
		get
		{
			return _RUC;
		}
		set
		{
			if (!string.Equals(_RUC, value))
			{
				_RUC = value;
			}
		}
	}

	[Column(Storage = "_idfinanciamiento", DbType = "Char(2)")]
	public string idfinanciamiento
	{
		get
		{
			return _idfinanciamiento;
		}
		set
		{
			if (!string.Equals(_idfinanciamiento, value))
			{
				_idfinanciamiento = value;
			}
		}
	}

	[Column(Storage = "_financiamiento", DbType = "VarChar(120)")]
	public string financiamiento
	{
		get
		{
			return _financiamiento;
		}
		set
		{
			if (!string.Equals(_financiamiento, value))
			{
				_financiamiento = value;
			}
		}
	}

	[Column(Storage = "_SIAF", DbType = "Char(6)")]
	public string SIAF
	{
		get
		{
			return _SIAF;
		}
		set
		{
			if (!string.Equals(_SIAF, value))
			{
				_SIAF = value;
			}
		}
	}

	[Column(Storage = "_DocReferencia", DbType = "VarChar(150)")]
	public string DocReferencia
	{
		get
		{
			return _DocReferencia;
		}
		set
		{
			if (!string.Equals(_DocReferencia, value))
			{
				_DocReferencia = value;
			}
		}
	}

	[Column(Storage = "_Almacen", DbType = "VarChar(120)")]
	public string Almacen
	{
		get
		{
			return _Almacen;
		}
		set
		{
			if (!string.Equals(_Almacen, value))
			{
				_Almacen = value;
			}
		}
	}

	[Column(Storage = "_AlmDirec", DbType = "VarChar(80)")]
	public string AlmDirec
	{
		get
		{
			return _AlmDirec;
		}
		set
		{
			if (!string.Equals(_AlmDirec, value))
			{
				_AlmDirec = value;
			}
		}
	}

	[Column(Storage = "_uso", DbType = "VarChar(180)")]
	public string uso
	{
		get
		{
			return _uso;
		}
		set
		{
			if (!string.Equals(_uso, value))
			{
				_uso = value;
			}
		}
	}

	[Column(Storage = "_asunto", DbType = "VarChar(120)")]
	public string asunto
	{
		get
		{
			return _asunto;
		}
		set
		{
			if (!string.Equals(_asunto, value))
			{
				_asunto = value;
			}
		}
	}

	[Column(Storage = "_observaciones", DbType = "VarChar(600)")]
	public string observaciones
	{
		get
		{
			return _observaciones;
		}
		set
		{
			if (!string.Equals(_observaciones, value))
			{
				_observaciones = value;
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

	[Column(Storage = "_TotalTotal", DbType = "Decimal(0,0)")]
	public decimal? TotalTotal
	{
		get
		{
			return _TotalTotal;
		}
		set
		{
			if (!_TotalTotal.Equals(value))
			{
				_TotalTotal = value;
			}
		}
	}

	[Column(Storage = "_Año", DbType = "Int")]
	public int? Año
	{
		get
		{
			return _Año;
		}
		set
		{
			if (!_Año.Equals(value))
			{
				_Año = value;
			}
		}
	}

	[Column(Storage = "_mes", DbType = "Int")]
	public int? mes
	{
		get
		{
			return _mes;
		}
		set
		{
			if (!_mes.Equals(value))
			{
				_mes = value;
			}
		}
	}

	[Column(Storage = "_dia", DbType = "Int")]
	public int? dia
	{
		get
		{
			return _dia;
		}
		set
		{
			if (!_dia.Equals(value))
			{
				_dia = value;
			}
		}
	}

	[Column(Storage = "_TIPODOCADJ", DbType = "VarChar(20)")]
	public string TIPODOCADJ
	{
		get
		{
			return _TIPODOCADJ;
		}
		set
		{
			if (!string.Equals(_TIPODOCADJ, value))
			{
				_TIPODOCADJ = value;
			}
		}
	}

	[Column(Storage = "_NRODOCADJ", DbType = "VarChar(20)")]
	public string NRODOCADJ
	{
		get
		{
			return _NRODOCADJ;
		}
		set
		{
			if (!string.Equals(_NRODOCADJ, value))
			{
				_NRODOCADJ = value;
			}
		}
	}
}
