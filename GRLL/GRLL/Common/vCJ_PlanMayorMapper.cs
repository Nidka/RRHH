using System.Diagnostics;

namespace GRLL.Common;

public class vCJ_PlanMayorMapper : GenericMapper<vCJ_PlanMayor, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vCJ_PlanMayorMapper()
	{
	}

	public static GenericMapper<vCJ_PlanMayor, dcGRLLDataContext> Instance()
	{
		GenericMapper<vCJ_PlanMayor, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vCJ_PlanMayor, dcGRLLDataContext>.InstanceBase();
	}
}
