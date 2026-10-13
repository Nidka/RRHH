using System.Diagnostics;

namespace GRLL.Common;

public class PlanMayorMapper : GenericMapper<PlanMayor, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public PlanMayorMapper()
	{
	}

	public static GenericMapper<PlanMayor, dcGRLLDataContext> Instance()
	{
		GenericMapper<PlanMayor, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<PlanMayor, dcGRLLDataContext>.InstanceBase();
	}
}
