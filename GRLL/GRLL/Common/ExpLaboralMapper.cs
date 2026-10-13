using System.Diagnostics;

namespace GRLL.Common;

public class ExpLaboralMapper : GenericMapper<ExpLaboral, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ExpLaboralMapper()
	{
	}

	public static GenericMapper<ExpLaboral, dcGRLLDataContext> Instance()
	{
		GenericMapper<ExpLaboral, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<ExpLaboral, dcGRLLDataContext>.InstanceBase();
	}
}
