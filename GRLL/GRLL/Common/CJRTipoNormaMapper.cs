using System.Diagnostics;

namespace GRLL.Common;

public class CJRTipoNormaMapper : GenericMapper<CJRTipoNorma, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRTipoNormaMapper()
	{
	}

	public static GenericMapper<CJRTipoNorma, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRTipoNorma, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRTipoNorma, dcGRLLDataContext>.InstanceBase();
	}
}
