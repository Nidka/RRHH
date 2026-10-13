using System.Diagnostics;

namespace GRLL.Common;

public class CJRProyectoNormativoMapper : GenericMapper<CJRProyectoNormativo, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRProyectoNormativoMapper()
	{
	}

	public static GenericMapper<CJRProyectoNormativo, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRProyectoNormativo, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRProyectoNormativo, dcGRLLDataContext>.InstanceBase();
	}
}
