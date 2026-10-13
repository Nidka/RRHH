using System.Diagnostics;

namespace GRLL.Common;

public class CJRNormaRegionalMapper : GenericMapper<CJRNormaRegional, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRNormaRegionalMapper()
	{
	}

	public static GenericMapper<CJRNormaRegional, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRNormaRegional, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRNormaRegional, dcGRLLDataContext>.InstanceBase();
	}
}
