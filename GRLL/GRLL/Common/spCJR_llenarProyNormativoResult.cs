using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_llenarProyNormativoResult
{
	private string _descripTipoProyec;

	private int _IdTipoProyec;

	private string _NumProyecto;

	private string _NumOficioIniciativa;

	private int _numtema;

	private string _tema;

	private string _NumOrdenanza;

	private string _descriptiponorma;

	[Column(Storage = "_descripTipoProyec", DbType = "VarChar(50)")]
	public string descripTipoProyec
	{
		get
		{
			return _descripTipoProyec;
		}
		set
		{
			if (!string.Equals(_descripTipoProyec, value))
			{
				_descripTipoProyec = value;
			}
		}
	}

	[Column(Storage = "_IdTipoProyec", DbType = "Int NOT NULL")]
	public int IdTipoProyec
	{
		get
		{
			return _IdTipoProyec;
		}
		set
		{
			if (_IdTipoProyec != value)
			{
				_IdTipoProyec = value;
			}
		}
	}

	[Column(Storage = "_NumProyecto", DbType = "VarChar(120) NOT NULL", CanBeNull = false)]
	public string NumProyecto
	{
		get
		{
			return _NumProyecto;
		}
		set
		{
			if (!string.Equals(_NumProyecto, value))
			{
				_NumProyecto = value;
			}
		}
	}

	[Column(Storage = "_NumOficioIniciativa", DbType = "VarChar(120)")]
	public string NumOficioIniciativa
	{
		get
		{
			return _NumOficioIniciativa;
		}
		set
		{
			if (!string.Equals(_NumOficioIniciativa, value))
			{
				_NumOficioIniciativa = value;
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

	[Column(Storage = "_NumOrdenanza", DbType = "VarChar(120)")]
	public string NumOrdenanza
	{
		get
		{
			return _NumOrdenanza;
		}
		set
		{
			if (!string.Equals(_NumOrdenanza, value))
			{
				_NumOrdenanza = value;
			}
		}
	}

	[Column(Storage = "_descriptiponorma", DbType = "VarChar(50)")]
	public string descriptiponorma
	{
		get
		{
			return _descriptiponorma;
		}
		set
		{
			if (!string.Equals(_descriptiponorma, value))
			{
				_descriptiponorma = value;
			}
		}
	}
}
