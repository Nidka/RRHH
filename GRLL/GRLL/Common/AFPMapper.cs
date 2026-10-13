using System.Diagnostics;

namespace GRLL.Common;

public class AFPMapper : GenericMapper<AFP, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public AFPMapper()
	{
	}

	public static GenericMapper<AFP, dcGRLLDataContext> Instance()
	{
		GenericMapper<AFP, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<AFP, dcGRLLDataContext>.InstanceBase();
	}
}
