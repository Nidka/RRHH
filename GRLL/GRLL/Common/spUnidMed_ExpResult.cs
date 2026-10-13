using System.Data.Linq.Mapping;

namespace GRLL.Common;

public class spUnidMed_ExpResult
{
	private int _IdUnidMed;

	private string _Descripcion;

	private string _Abreviatura;

	[Column(Storage = "_IdUnidMed", DbType = "Int NOT NULL")]
	public int IdUnidMed
	{
		get
		{
			return _IdUnidMed;
		}
		set
		{
			if (_IdUnidMed != value)
			{
				_IdUnidMed = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(100)")]
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

	[Column(Storage = "_Abreviatura", DbType = "VarChar(6)")]
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
