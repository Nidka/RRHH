using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJR_Rep_AcuerdosResult
{
	private string _Tiponorma;

	private string _Norma;

	private string _Aprobado_en_Sesion;

	private string _Publicacion;

	[Column(Storage = "_Tiponorma", DbType = "VarChar(50)")]
	public string Tiponorma
	{
		get
		{
			return _Tiponorma;
		}
		set
		{
			if (!string.Equals(_Tiponorma, value))
			{
				_Tiponorma = value;
			}
		}
	}

	[Column(Storage = "_Norma", DbType = "VarChar(135)")]
	public string Norma
	{
		get
		{
			return _Norma;
		}
		set
		{
			if (!string.Equals(_Norma, value))
			{
				_Norma = value;
			}
		}
	}

	[Column(Storage = "_Aprobado_en_Sesion", DbType = "VarChar(39)")]
	public string Aprobado_en_Sesion
	{
		get
		{
			return _Aprobado_en_Sesion;
		}
		set
		{
			if (!string.Equals(_Aprobado_en_Sesion, value))
			{
				_Aprobado_en_Sesion = value;
			}
		}
	}

	[Column(Storage = "_Publicacion", DbType = "VarChar(151)")]
	public string Publicacion
	{
		get
		{
			return _Publicacion;
		}
		set
		{
			if (!string.Equals(_Publicacion, value))
			{
				_Publicacion = value;
			}
		}
	}
}
