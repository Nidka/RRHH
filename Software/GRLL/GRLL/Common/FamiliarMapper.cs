using System.Diagnostics;

namespace GRLL.Common;

public class FamiliarMapper : GenericMapper<Familiar, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public FamiliarMapper()
	{
	}

	public static GenericMapper<Familiar, dcGRLLDataContext> Instance()
	{
		GenericMapper<Familiar, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Familiar, dcGRLLDataContext>.InstanceBase();
	}
}
