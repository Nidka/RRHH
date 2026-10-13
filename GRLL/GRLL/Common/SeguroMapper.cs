using System.Diagnostics;

namespace GRLL.Common;

public class SeguroMapper : GenericMapper<Seguro, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public SeguroMapper()
	{
	}

	public static GenericMapper<Seguro, dcGRLLDataContext> Instance()
	{
		GenericMapper<Seguro, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Seguro, dcGRLLDataContext>.InstanceBase();
	}
}
