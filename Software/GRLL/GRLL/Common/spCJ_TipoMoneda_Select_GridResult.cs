using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spCJ_TipoMoneda_Select_GridResult
{
	private int _IdTipoMoneda;

	private string _Tipo_de_Moneda;

	private string _Abreviatura;

	private string _Descripcion;

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

	[Column(Name = "[Tipo de Moneda]", Storage = "_Tipo_de_Moneda", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
	public string Tipo_de_Moneda
	{
		get
		{
			return _Tipo_de_Moneda;
		}
		set
		{
			if (!string.Equals(_Tipo_de_Moneda, value))
			{
				_Tipo_de_Moneda = value;
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
}
