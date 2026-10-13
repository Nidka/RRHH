using System.Diagnostics;

namespace GRLL.Common;

public class CJRTemaIniciativaMapper : GenericMapper<CJRTemaIniciativa, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRTemaIniciativaMapper()
	{
	}

	public static GenericMapper<CJRTemaIniciativa, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRTemaIniciativa, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRTemaIniciativa, dcGRLLDataContext>.InstanceBase();
	}
}
