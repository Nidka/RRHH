using System.Diagnostics;

namespace GRLL.Common;

public class CJRIniciativaMapper : GenericMapper<CJRIniciativa, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRIniciativaMapper()
	{
	}

	public static GenericMapper<CJRIniciativa, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRIniciativa, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRIniciativa, dcGRLLDataContext>.InstanceBase();
	}
}
