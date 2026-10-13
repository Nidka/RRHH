using System.Diagnostics;

namespace GRLL.Common;

public class CJRPublicacionNormaMapper : GenericMapper<CJRPublicacionNorma, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRPublicacionNormaMapper()
	{
	}

	public static GenericMapper<CJRPublicacionNorma, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRPublicacionNorma, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRPublicacionNorma, dcGRLLDataContext>.InstanceBase();
	}
}
