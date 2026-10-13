using System.Diagnostics;

namespace GRLL.Common;

public class ConsolidadoMapper : GenericMapper<Consolidado, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ConsolidadoMapper()
	{
	}

	public static GenericMapper<Consolidado, dcGRLLDataContext> Instance()
	{
		GenericMapper<Consolidado, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Consolidado, dcGRLLDataContext>.InstanceBase();
	}
}
