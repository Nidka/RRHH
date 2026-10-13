using System.Diagnostics;

namespace GRLL.Common;

public class CJRNotificacionNormaMapper : GenericMapper<CJRNotificacionNorma, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRNotificacionNormaMapper()
	{
	}

	public static GenericMapper<CJRNotificacionNorma, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRNotificacionNorma, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRNotificacionNorma, dcGRLLDataContext>.InstanceBase();
	}
}
