using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Familia_GetByClaseResult
{
	private string _IdFamilia;

	private string _Descripcion;

	private string _Observaciones;

	private string _IdClase;

	private string _IdGrupo;

	[Column(Storage = "_IdFamilia", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string IdFamilia
	{
		get
		{
			return _IdFamilia;
		}
		set
		{
			if (!string.Equals(_IdFamilia, value))
			{
				_IdFamilia = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(140)")]
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

	[Column(Storage = "_Observaciones", DbType = "VarChar(120)")]
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

	[Column(Storage = "_IdClase", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string IdClase
	{
		get
		{
			return _IdClase;
		}
		set
		{
			if (!string.Equals(_IdClase, value))
			{
				_IdClase = value;
			}
		}
	}

	[Column(Storage = "_IdGrupo", DbType = "Char(3) NOT NULL", CanBeNull = false)]
	public string IdGrupo
	{
		get
		{
			return _IdGrupo;
		}
		set
		{
			if (!string.Equals(_IdGrupo, value))
			{
				_IdGrupo = value;
			}
		}
	}
}
