using System.Diagnostics;

namespace GRLL.Common;

public class Deta_DistribucionMapper : GenericMapper<Deta_Distribucion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Deta_DistribucionMapper()
	{
	}

	public static GenericMapper<Deta_Distribucion, dcGRLLDataContext> Instance()
	{
		GenericMapper<Deta_Distribucion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Deta_Distribucion, dcGRLLDataContext>.InstanceBase();
	}
}
