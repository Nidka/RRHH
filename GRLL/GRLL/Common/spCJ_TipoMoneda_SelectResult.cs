using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_TipoMoneda_SelectResult
{
	private int _IdTipoMoneda;

	private string _Descripcion;

	private string _Abreviatura;

	[Column(Storage = "_IdTipoMoneda", DbType = "Int NOT NULL")]
	public int IdTipoMoneda
	{
		get
		{
			return _IdTipoMoneda;
		}
		set
		{
			if (_IdTipoMoneda != value)
			{
				_IdTipoMoneda = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
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

	[Column(Storage = "_Abreviatura", DbType = "VarChar(5) NOT NULL", CanBeNull = false)]
	public string Abreviatura
	{
		get
		{
			return _Abreviatura;
		}
		set
		{
			if (!string.Equals(_Abreviatura, value))
			{
				_Abreviatura = value;
			}
		}
	}
}
