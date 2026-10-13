using System.Data.Linq.Mapping;

namespace GRLL.Common;

[Table(Name = "dbo.aba_vs_financiamiento")]
public class aba_vs_financiamiento
{
	private string _codigo;

	private string _descripcion;

	[Column(Storage = "_codigo", DbType = "Char(2) NOT NULL", CanBeNull = false)]
	public string codigo
	{
		get
		{
			return _codigo;
		}
		set
		{
			if (!string.Equals(_codigo, value))
			{
				_codigo = value;
			}
		}
	}

	[Column(Storage = "_descripcion", DbType = "VarChar(120)")]
	public string descripcion
	{
		get
		{
			return _descripcion;
		}
		set
		{
			if (!string.Equals(_descripcion, value))
			{
				_descripcion = value;
			}
		}
	}
}
