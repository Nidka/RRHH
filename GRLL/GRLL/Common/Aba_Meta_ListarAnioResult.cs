using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Meta_ListarAnioResult
{
	private string _codigo;

	private string _CorreMeta;

	private string _idMeta;

	private string _localizacion;

	private string _DescMeta;

	private string _Anio;

	private string _idFinalidad;

	private string _DescFina;

	private string _idUbigeo;

	private string _DescUbi;

	private string _idUnidadMed;

	private string _DescUniMed;

	[Column(Storage = "_codigo", DbType = "VarChar(29)")]
	public string codigo
	{
		get
		{
			return _codigo;
		}
		set
		{
			if (!string.Equals(_codigo, value))
			{
				_codigo = value;
			}
		}
	}

	[Column(Storage = "_CorreMeta", DbType = "Char(6)")]
	public string CorreMeta
	{
		get
		{
			return _CorreMeta;
		}
		set
		{
			if (!string.Equals(_CorreMeta, value))
			{
				_CorreMeta = value;
			}
		}
	}

	[Column(Storage = "_idMeta", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string idMeta
	{
		get
		{
			return _idMeta;
		}
		set
		{
			if (!string.Equals(_idMeta, value))
			{
				_idMeta = value;
			}
		}
	}

	[Column(Storage = "_localizacion", DbType = "VarChar(120)")]
	public string localizacion
	{
		get
		{
			return _localizacion;
		}
		set
		{
			if (!string.Equals(_localizacion, value))
			{
				_localizacion = value;
			}
		}
	}

	[Column(Storage = "_DescMeta", DbType = "VarChar(255)")]
	public string DescMeta
	{
		get
		{
			return _DescMeta;
		}
		set
		{
			if (!string.Equals(_DescMeta, value))
			{
				_DescMeta = value;
			}
		}
	}

	[Column(Storage = "_Anio", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string Anio
	{
		get
		{
			return _Anio;
		}
		set
		{
			if (!string.Equals(_Anio, value))
			{
				_Anio = value;
			}
		}
	}

	[Column(Storage = "_idFinalidad", DbType = "Char(5) NOT NULL", CanBeNull = false)]
	public string idFinalidad
	{
		get
		{
			return _idFinalidad;
		}
		set
		{
			if (!string.Equals(_idFinalidad, value))
			{
				_idFinalidad = value;
			}
		}
	}

	[Column(Storage = "_DescFina", DbType = "VarChar(255)")]
	public string DescFina
	{
		get
		{
			return _DescFina;
		}
		set
		{
			if (!string.Equals(_DescFina, value))
			{
				_DescFina = value;
			}
		}
	}

	[Column(Storage = "_idUbigeo", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string idUbigeo
	{
		get
		{
			return _idUbigeo;
		}
		set
		{
			if (!string.Equals(_idUbigeo, value))
			{
				_idUbigeo = value;
			}
		}
	}

	[Column(Storage = "_DescUbi", DbType = "VarChar(120)")]
	public string DescUbi
	{
		get
		{
			return _DescUbi;
		}
		set
		{
			if (!string.Equals(_DescUbi, value))
			{
				_DescUbi = value;
			}
		}
	}

	[Column(Storage = "_idUnidadMed", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string idUnidadMed
	{
		get
		{
			return _idUnidadMed;
		}
		set
		{
			if (!string.Equals(_idUnidadMed, value))
			{
				_idUnidadMed = value;
			}
		}
	}

	[Column(Storage = "_DescUniMed", DbType = "VarChar(30)")]
	public string DescUniMed
	{
		get
		{
			return _DescUniMed;
		}
		set
		{
			if (!string.Equals(_DescUniMed, value))
			{
				_DescUniMed = value;
			}
		}
	}
}
