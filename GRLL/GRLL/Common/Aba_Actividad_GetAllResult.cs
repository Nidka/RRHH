using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class Aba_Actividad_GetAllResult
{
	private string _IdActividad;

	private string _Descripcion;

	private string _IdSubPrograma;

	private string _IdPrograma;

	private string _IdFuncion;

	private string _Anio;

	[Column(Storage = "_IdActividad", DbType = "Char(8) NOT NULL", CanBeNull = false)]
	public string IdActividad
	{
		get
		{
			return _IdActividad;
		}
		set
		{
			if (!string.Equals(_IdActividad, value))
			{
				_IdActividad = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(255)")]
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

	[Column(Storage = "_IdSubPrograma", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string IdSubPrograma
	{
		get
		{
			return _IdSubPrograma;
		}
		set
		{
			if (!string.Equals(_IdSubPrograma, value))
			{
				_IdSubPrograma = value;
			}
		}
	}

	[Column(Storage = "_IdPrograma", DbType = "Char(3) NOT NULL", CanBeNull = false)]
	public string IdPrograma
	{
		get
		{
			return _IdPrograma;
		}
		set
		{
			if (!string.Equals(_IdPrograma, value))
			{
				_IdPrograma = value;
			}
		}
	}

	[Column(Storage = "_IdFuncion", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string IdFuncion
	{
		get
		{
			return _IdFuncion;
		}
		set
		{
			if (!string.Equals(_IdFuncion, value))
			{
				_IdFuncion = value;
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
}
