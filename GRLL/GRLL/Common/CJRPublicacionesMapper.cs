using System.Diagnostics;

namespace GRLL.Common;

public class CJRPublicacionesMapper : GenericMapper<CJRPublicacion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRPublicacionesMapper()
	{
	}

	public static GenericMapper<CJRPublicacion, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRPublicacion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRPublicacion, dcGRLLDataContext>.InstanceBase();
	}
}
