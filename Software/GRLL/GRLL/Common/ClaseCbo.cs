using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GRLL.Common;

public class ClaseCbo
{
	private object _Codigo;

	private string _Descripcion;

	public object Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			_Codigo = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public string Descripcion
	{
		get
		{
			return _Descripcion;
		}
		set
		{
			_Descripcion = value;
		}
	}

	[DebuggerNonUserCode]
	public ClaseCbo()
	{
	}
}
