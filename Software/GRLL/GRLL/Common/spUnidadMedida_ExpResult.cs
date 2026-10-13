using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spUnidadMedida_ExpResult
{
	private string _IdUnidadMedida;

	private string _Descripcion;

	private string _Abreviado;

	[Column(Storage = "_IdUnidadMedida", DbType = "Char(4) NOT NULL", CanBeNull = false)]
	public string IdUnidadMedida
	{
		get
		{
			return _IdUnidadMedida;
		}
		set
		{
			if (!string.Equals(_IdUnidadMedida, value))
			{
				_IdUnidadMedida = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(30)")]
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

	[Column(Storage = "_Abreviado", DbType = "Char(4)")]
	public string Abreviado
	{
		get
		{
			return _Abreviado;
		}
		set
		{
			if (!string.Equals(_Abreviado, value))
			{
				_Abreviado = value;
			}
		}
	}
}
