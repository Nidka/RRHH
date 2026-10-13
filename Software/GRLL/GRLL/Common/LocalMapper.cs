using System.Diagnostics;

namespace GRLL.Common;

public class LocalMapper : GenericMapper<Local, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public LocalMapper()
	{
	}

	public static GenericMapper<Local, dcGRLLDataContext> Instance()
	{
		GenericMapper<Local, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Local, dcGRLLDataContext>.InstanceBase();
	}
}
