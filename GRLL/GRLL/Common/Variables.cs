using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.Variables")]
public class Variables
{
	private short? _idVariable;

	private string _Variable;

	private string _Descripcion;

	private char? _EsConstante;

	private char? _TipoDato;

	private decimal? _ValorN;

	private string _ValorC;

	private string _ExprSELECT;

	private string _ExprFROM;

	private string _ExprWHERE;

	[Column(Storage = "_idVariable", DbType = "SmallInt")]
	public short? idVariable
	{
		get
		{
			return _idVariable;
		}
		set
		{
			if (!_idVariable.Equals(value))
			{
				_idVariable = value;
			}
		}
	}

	[Column(Storage = "_Variable", DbType = "VarChar(15)")]
	public string Variable
	{
		get
		{
			return _Variable;
		}
		set
		{
			if (!string.Equals(_Variable, value))
			{
				_Variable = value;
			}
		}
	}

	[Column(Storage = "_Descripcion", DbType = "VarChar(250)")]
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

	[Column(Storage = "_EsConstante", DbType = "Char(1)")]
	public char? EsConstante
	{
		get
		{
			return _EsConstante;
		}
		set
		{
			if (!_EsConstante.Equals(value))
			{
				_EsConstante = value;
			}
		}
	}

	[Column(Storage = "_TipoDato", DbType = "Char(1)")]
	public char? TipoDato
	{
		get
		{
			return _TipoDato;
		}
		set
		{
			if (!_TipoDato.Equals(value))
			{
				_TipoDato = value;
			}
		}
	}

	[Column(Storage = "_ValorN", DbType = "Decimal(16,4)")]
	public decimal? ValorN
	{
		get
		{
			return _ValorN;
		}
		set
		{
			if (!_ValorN.Equals(value))
			{
				_ValorN = value;
			}
		}
	}

	[Column(Storage = "_ValorC", DbType = "VarChar(250)")]
	public string ValorC
	{
		get
		{
			return _ValorC;
		}
		set
		{
			if (!string.Equals(_ValorC, value))
			{
				_ValorC = value;
			}
		}
	}

	[Column(Storage = "_ExprSELECT", DbType = "VarChar(250)")]
	public string ExprSELECT
	{
		get
		{
			return _ExprSELECT;
		}
		set
		{
			if (!string.Equals(_ExprSELECT, value))
			{
				_ExprSELECT = value;
			}
		}
	}

	[Column(Storage = "_ExprFROM", DbType = "VarChar(128)")]
	public string ExprFROM
	{
		get
		{
			return _ExprFROM;
		}
		set
		{
			if (!string.Equals(_ExprFROM, value))
			{
				_ExprFROM = value;
			}
		}
	}

	[Column(Storage = "_ExprWHERE", DbType = "VarChar(250)")]
	public string ExprWHERE
	{
		get
		{
			return _ExprWHERE;
		}
		set
		{
			if (!string.Equals(_ExprWHERE, value))
			{
				_ExprWHERE = value;
			}
		}
	}
}
