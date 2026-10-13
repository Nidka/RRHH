using System.Diagnostics;

namespace GRLL.Common;

public class GastoPublicoMapper : GenericMapper<GastoPublico, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public GastoPublicoMapper()
	{
	}

	public static GenericMapper<GastoPublico, dcGRLLDataContext> Instance()
	{
		GenericMapper<GastoPublico, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<GastoPublico, dcGRLLDataContext>.InstanceBase();
	}
}
