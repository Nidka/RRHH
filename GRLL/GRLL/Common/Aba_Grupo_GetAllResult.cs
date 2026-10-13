using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Grupo_GetAllResult
{
	private string _IdGrupo;

	private string _Descripcion;

	private string _Observaciones;

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

	[Column(Storage = "_Descripcion", DbType = "VarChar(120)")]
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
}
