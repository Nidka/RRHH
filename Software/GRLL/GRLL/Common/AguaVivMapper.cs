using System.Diagnostics;

namespace GRLL.Common;

public class AguaVivMapper : GenericMapper<AguaViv, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public AguaVivMapper()
	{
	}

	public static GenericMapper<AguaViv, dcGRLLDataContext> Instance()
	{
		GenericMapper<AguaViv, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<AguaViv, dcGRLLDataContext>.InstanceBase();
	}
}
