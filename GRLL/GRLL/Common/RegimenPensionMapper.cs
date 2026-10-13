using System.Diagnostics;

namespace GRLL.Common;

public class RegimenPensionMapper : GenericMapper<RegimenPension, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RegimenPensionMapper()
	{
	}

	public static GenericMapper<RegimenPension, dcGRLLDataContext> Instance()
	{
		GenericMapper<RegimenPension, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RegimenPension, dcGRLLDataContext>.InstanceBase();
	}
}
