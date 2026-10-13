using System.Diagnostics;

namespace GRLL.Common;

public class ConservacionVivMapper : GenericMapper<ConservacionViv, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ConservacionVivMapper()
	{
	}

	public static GenericMapper<ConservacionViv, dcGRLLDataContext> Instance()
	{
		GenericMapper<ConservacionViv, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<ConservacionViv, dcGRLLDataContext>.InstanceBase();
	}
}
