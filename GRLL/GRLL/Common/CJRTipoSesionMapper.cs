using System.Diagnostics;

namespace GRLL.Common;

public class CJRTipoSesionMapper : GenericMapper<CJRTipoSesion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRTipoSesionMapper()
	{
	}

	public static GenericMapper<CJRTipoSesion, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRTipoSesion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRTipoSesion, dcGRLLDataContext>.InstanceBase();
	}
}
