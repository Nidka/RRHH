using System.Diagnostics;

namespace GRLL.Common;

public class CJRSesionMapper : GenericMapper<CJRSesion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRSesionMapper()
	{
	}

	public static GenericMapper<CJRSesion, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRSesion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRSesion, dcGRLLDataContext>.InstanceBase();
	}
}
