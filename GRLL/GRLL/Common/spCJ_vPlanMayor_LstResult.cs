using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_vPlanMayor_LstResult
{
	private int _Years;

	private int _Codigo;

	private string _CodigoCtb;

	private string _Descripcion;

	private int _YearsDe;

	private int _CodigoDe;

	private string _CodigoNombre;

	private string _DivisionariaDe;

	private int? _Divisionarias;

	[Column(Storage = "_Years", DbType = "Int NOT NULL")]
	public int Years
	{
		get
		{
			return _Years;
		}
		set
		{
			if (_Years != value)
			{
				_Years = value;
			}
		}
	}

	[Column(Storage = "_Codigo", DbType = "Int NOT NULL")]
	public int Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			if (_Codigo != value)
			{
				_Codigo = value;
			}
		}
	}

	[Column(Storage = "_CodigoCtb", DbType = "VarChar(2)")]
	public string CodigoCtb
	{
		get
		{
			return _CodigoCtb;
		}
		set
		{
			if (!string.Equals(_CodigoCtb, value))
			{
				_CodigoCtb = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(250)")]
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

	[Column(Storage = "_YearsDe", DbType = "Int NOT NULL")]
	public int YearsDe
	{
		get
		{
			return _YearsDe;
		}
		set
		{
			if (_YearsDe != value)
			{
				_YearsDe = value;
			}
		}
	}

	[Column(Storage = "_CodigoDe", DbType = "Int NOT NULL")]
	public int CodigoDe
	{
		get
		{
			return _CodigoDe;
		}
		set
		{
			if (_CodigoDe != value)
			{
				_CodigoDe = value;
			}
		}
	}

	[Column(Storage = "_CodigoNombre", DbType = "VarChar(264)")]
	public string CodigoNombre
	{
		get
		{
			return _CodigoNombre;
		}
		set
		{
			if (!string.Equals(_CodigoNombre, value))
			{
				_CodigoNombre = value;
			}
		}
	}

	[Column(Storage = "_DivisionariaDe", DbType = "VarChar(250)")]
	public string DivisionariaDe
	{
		get
		{
			return _DivisionariaDe;
		}
		set
		{
			if (!string.Equals(_DivisionariaDe, value))
			{
				_DivisionariaDe = value;
			}
		}
	}

	[Column(Storage = "_Divisionarias", DbType = "Int")]
	public int? Divisionarias
	{
		get
		{
			return _Divisionarias;
		}
		set
		{
			if (!_Divisionarias.Equals(value))
			{
				_Divisionarias = value;
			}
		}
	}
}
