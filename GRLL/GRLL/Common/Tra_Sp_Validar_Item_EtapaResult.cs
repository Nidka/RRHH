using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Tra_Sp_Validar_Item_EtapaResult
{
	private string _IdEtapaProc;

	private string _Descripcion;

	private decimal? _TiempoHrs;

	private byte? _TiempoDias;

	private string _IdTipoDoc;

	private string _Observaciones;

	private int? _Year;

	private int? _idAreaOrganiz;

	private string _IdProcedimiento;

	private byte? _Item;

	private string _EtapaAnterior;

	private decimal? _AvisoHrs;

	private int? _IdCargo;

	private string _SecStandard;

	private string _SecAlterna;

	private char? _TipoEtapa;

	private bool? _Estado;

	[Column(Storage = "_IdEtapaProc", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string IdEtapaProc
	{
		get
		{
			return _IdEtapaProc;
		}
		set
		{
			if (!string.Equals(_IdEtapaProc, value))
			{
				_IdEtapaProc = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(400)")]
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

	[Column(Storage = "_TiempoHrs", DbType = "Decimal(0,0)")]
	public decimal? TiempoHrs
	{
		get
		{
			return _TiempoHrs;
		}
		set
		{
			if (!_TiempoHrs.Equals(value))
			{
				_TiempoHrs = value;
			}
		}
	}

	[Column(Storage = "_TiempoDias", DbType = "TinyInt")]
	public byte? TiempoDias
	{
		get
		{
			return _TiempoDias;
		}
		set
		{
			if (!_TiempoDias.Equals(value))
			{
				_TiempoDias = value;
			}
		}
	}

	[Column(Storage = "_IdTipoDoc", DbType = "Char(2)")]
	public string IdTipoDoc
	{
		get
		{
			return _IdTipoDoc;
		}
		set
		{
			if (!string.Equals(_IdTipoDoc, value))
			{
				_IdTipoDoc = value;
			}
		}
	}

	[Column(Storage = "_Observaciones", DbType = "VarChar(400)")]
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

	[Column(Storage = "_Year", DbType = "Int")]
	public int? Year
	{
		get
		{
			return _Year;
		}
		set
		{
			if (!_Year.Equals(value))
			{
				_Year = value;
			}
		}
	}

	[Column(Storage = "_idAreaOrganiz", DbType = "Int")]
	public int? idAreaOrganiz
	{
		get
		{
			return _idAreaOrganiz;
		}
		set
		{
			if (!_idAreaOrganiz.Equals(value))
			{
				_idAreaOrganiz = value;
			}
		}
	}

	[Column(Storage = "_IdProcedimiento", DbType = "Char(6)")]
	public string IdProcedimiento
	{
		get
		{
			return _IdProcedimiento;
		}
		set
		{
			if (!string.Equals(_IdProcedimiento, value))
			{
				_IdProcedimiento = value;
			}
		}
	}

	[Column(Storage = "_Item", DbType = "TinyInt")]
	public byte? Item
	{
		get
		{
			return _Item;
		}
		set
		{
			if (!_Item.Equals(value))
			{
				_Item = value;
			}
		}
	}

	[Column(Storage = "_EtapaAnterior", DbType = "Char(8)")]
	public string EtapaAnterior
	{
		get
		{
			return _EtapaAnterior;
		}
		set
		{
			if (!string.Equals(_EtapaAnterior, value))
			{
				_EtapaAnterior = value;
			}
		}
	}

	[Column(Storage = "_AvisoHrs", DbType = "Decimal(0,0)")]
	public decimal? AvisoHrs
	{
		get
		{
			return _AvisoHrs;
		}
		set
		{
			if (!_AvisoHrs.Equals(value))
			{
				_AvisoHrs = value;
			}
		}
	}

	[Column(Storage = "_IdCargo", DbType = "Int")]
	public int? IdCargo
	{
		get
		{
			return _IdCargo;
		}
		set
		{
			if (!_IdCargo.Equals(value))
			{
				_IdCargo = value;
			}
		}
	}

	[Column(Storage = "_SecStandard", DbType = "Char(8)")]
	public string SecStandard
	{
		get
		{
			return _SecStandard;
		}
		set
		{
			if (!string.Equals(_SecStandard, value))
			{
				_SecStandard = value;
			}
		}
	}

	[Column(Storage = "_SecAlterna", DbType = "Char(8)")]
	public string SecAlterna
	{
		get
		{
			return _SecAlterna;
		}
		set
		{
			if (!string.Equals(_SecAlterna, value))
			{
				_SecAlterna = value;
			}
		}
	}

	[Column(Storage = "_TipoEtapa", DbType = "Char(1)")]
	public char? TipoEtapa
	{
		get
		{
			return _TipoEtapa;
		}
		set
		{
			if (!_TipoEtapa.Equals(value))
			{
				_TipoEtapa = value;
			}
		}
	}

	[Column(Storage = "_Estado", DbType = "Bit")]
	public bool? Estado
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
}
