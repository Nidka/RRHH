using System.Diagnostics;

namespace GRLL.Common;

public class Deta_ConsolidadoMapper : GenericMapper<Deta_Consolidado, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Deta_ConsolidadoMapper()
	{
	}

	public static GenericMapper<Deta_Consolidado, dcGRLLDataContext> Instance()
	{
		GenericMapper<Deta_Consolidado, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Deta_Consolidado, dcGRLLDataContext>.InstanceBase();
	}
}
