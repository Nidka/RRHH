using System.Diagnostics;

namespace GRLL.Common;

public class CJROperadorMapper : GenericMapper<CJROperador, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJROperadorMapper()
	{
	}

	public static GenericMapper<CJROperador, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJROperador, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJROperador, dcGRLLDataContext>.InstanceBase();
	}
}
