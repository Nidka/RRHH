using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.vs_ABA_ListarMetas")]
public class vs_ABA_ListarMetas
{
	private string _Codigo;

	private string _CorreMeta;

	private string _IdMeta;

	private string _Localizacion;

	private string _DescMeta;

	private string _Anio;

	private string _IdFinalidad;

	private string _DescFina;

	[Column(Storage = "_Codigo", DbType = "VarChar(36)")]
	public string Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			if (!string.Equals(_Codigo, value))
			{
				_Codigo = value;
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

	[Column(Storage = "_IdMeta", DbType = "Char(6) NOT NULL", CanBeNull = false)]
	public string IdMeta
	{
		get
		{
			return _IdMeta;
		}
		set
		{
			if (!string.Equals(_IdMeta, value))
			{
				_IdMeta = value;
			}
		}
	}

	[Column(Storage = "_Localizacion", DbType = "VarChar(120)")]
	public string Localizacion
	{
		get
		{
			return _Localizacion;
		}
		set
		{
			if (!string.Equals(_Localizacion, value))
			{
				_Localizacion = value;
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

	[Column(Storage = "_IdFinalidad", DbType = "Char(5) NOT NULL", CanBeNull = false)]
	public string IdFinalidad
	{
		get
		{
			return _IdFinalidad;
		}
		set
		{
			if (!string.Equals(_IdFinalidad, value))
			{
				_IdFinalidad = value;
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
}
