using System.Diagnostics;

namespace GRLL.Common;

public class CJRPromulgacionNormaMapper : GenericMapper<CJRPromulgacionNorma, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRPromulgacionNormaMapper()
	{
	}

	public static GenericMapper<CJRPromulgacionNorma, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRPromulgacionNorma, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRPromulgacionNorma, dcGRLLDataContext>.InstanceBase();
	}
}
