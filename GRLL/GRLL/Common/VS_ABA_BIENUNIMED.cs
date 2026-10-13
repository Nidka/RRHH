using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.VS_ABA_BIENUNIMED")]
public class VS_ABA_BIENUNIMED
{
	private string _Codigo;

	private string _DescripcionS;

	private char? _tipo;

	private string _DescripcionU;

	private decimal? _PRECIOREF;

	private string _IdUMedida;

	[Column(Storage = "_Codigo", DbType = "VarChar(12)")]
	public string Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			if (!string.Equals(_Codigo, value))
			{
				_Codigo = value;
			}
		}
	}

	[Column(Storage = "_DescripcionS", DbType = "VarChar(120)")]
	public string DescripcionS
	{
		get
		{
			return _DescripcionS;
		}
		set
		{
			if (!string.Equals(_DescripcionS, value))
			{
				_DescripcionS = value;
			}
		}
	}

	[Column(Storage = "_tipo", DbType = "Char(1)")]
	public char? tipo
	{
		get
		{
			return _tipo;
		}
		set
		{
			if (!_tipo.Equals(value))
			{
				_tipo = value;
			}
		}
	}

	[Column(Storage = "_DescripcionU", DbType = "VarChar(30)")]
	public string DescripcionU
	{
		get
		{
			return _DescripcionU;
		}
		set
		{
			if (!string.Equals(_DescripcionU, value))
			{
				_DescripcionU = value;
			}
		}
	}

	[Column(Storage = "_PRECIOREF", DbType = "Decimal(9,2)")]
	public decimal? PRECIOREF
	{
		get
		{
			return _PRECIOREF;
		}
		set
		{
			if (!_PRECIOREF.Equals(value))
			{
				_PRECIOREF = value;
			}
		}
	}

	[Column(Storage = "_IdUMedida", DbType = "Char(4)")]
	public string IdUMedida
	{
		get
		{
			return _IdUMedida;
		}
		set
		{
			if (!string.Equals(_IdUMedida, value))
			{
				_IdUMedida = value;
			}
		}
	}
}
