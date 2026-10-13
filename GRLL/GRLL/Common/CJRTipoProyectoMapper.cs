using System.Diagnostics;

namespace GRLL.Common;

public class CJRTipoProyectoMapper : GenericMapper<CJRTipoProyecto, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRTipoProyectoMapper()
	{
	}

	public static GenericMapper<CJRTipoProyecto, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRTipoProyecto, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRTipoProyecto, dcGRLLDataContext>.InstanceBase();
	}
}
