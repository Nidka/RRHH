using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class sp_Rep_PrincipalResult
{
	private string _NOficioPresetIniciativa;

	private int _numtema;

	private string _Iniciativa;

	private string _tema;

	private string _autor;

	private string _Operador;

	private string _ProyecNormativo;

	private string _NormaReg;

	[Column(Storage = "_NOficioPresetIniciativa", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string NOficioPresetIniciativa
	{
		get
		{
			return _NOficioPresetIniciativa;
		}
		set
		{
			if (!string.Equals(_NOficioPresetIniciativa, value))
			{
				_NOficioPresetIniciativa = value;
			}
		}
	}

	[Column(Storage = "_numtema", DbType = "Int NOT NULL")]
	public int numtema
	{
		get
		{
			return _numtema;
		}
		set
		{
			if (_numtema != value)
			{
				_numtema = value;
			}
		}
	}

	[Column(Storage = "_Iniciativa", DbType = "VarChar(135)")]
	public string Iniciativa
	{
		get
		{
			return _Iniciativa;
		}
		set
		{
			if (!string.Equals(_Iniciativa, value))
			{
				_Iniciativa = value;
			}
		}
	}

	[Column(Storage = "_tema", DbType = "VarChar(2000)")]
	public string tema
	{
		get
		{
			return _tema;
		}
		set
		{
			if (!string.Equals(_tema, value))
			{
				_tema = value;
			}
		}
	}

	[Column(Storage = "_autor", DbType = "VarChar(200)")]
	public string autor
	{
		get
		{
			return _autor;
		}
		set
		{
			if (!string.Equals(_autor, value))
			{
				_autor = value;
			}
		}
	}

	[Column(Storage = "_Operador", DbType = "VarChar(162)")]
	public string Operador
	{
		get
		{
			return _Operador;
		}
		set
		{
			if (!string.Equals(_Operador, value))
			{
				_Operador = value;
			}
		}
	}

	[Column(Storage = "_ProyecNormativo", DbType = "VarChar(174)")]
	public string ProyecNormativo
	{
		get
		{
			return _ProyecNormativo;
		}
		set
		{
			if (!string.Equals(_ProyecNormativo, value))
			{
				_ProyecNormativo = value;
			}
		}
	}

	[Column(Storage = "_NormaReg", DbType = "VarChar(174)")]
	public string NormaReg
	{
		get
		{
			return _NormaReg;
		}
		set
		{
			if (!string.Equals(_NormaReg, value))
			{
				_NormaReg = value;
			}
		}
	}
}
