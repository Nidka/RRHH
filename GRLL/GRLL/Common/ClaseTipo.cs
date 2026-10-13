using System.Diagnostics;

namespace GRLL.Common;

public class ClaseTipo
{
	private string _Codigo;

	private string _Descripcion;

	public string Codigo
	{
		get
		{
			return _Codigo;
		}
		set
		{
			_Codigo = value;
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
	public ClaseTipo()
	{
	}
}
