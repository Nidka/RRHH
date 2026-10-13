using System.Diagnostics;

namespace GRLL.Common;

public class vs_ABA_GastoPublicoMapper : GenericMapper<vs_ABA_GastoPublico, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_ABA_GastoPublicoMapper()
	{
	}

	public static GenericMapper<vs_ABA_GastoPublico, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_ABA_GastoPublico, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_ABA_GastoPublico, dcGRLLDataContext>.InstanceBase();
	}
}
