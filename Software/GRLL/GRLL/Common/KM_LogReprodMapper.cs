using System.Diagnostics;

namespace GRLL.Common;

public class KM_LogReprodMapper : GenericMapper<KM_LogReprod, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public KM_LogReprodMapper()
	{
	}

	public static GenericMapper<KM_LogReprod, dcGRLLDataContext> Instance()
	{
		GenericMapper<KM_LogReprod, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<KM_LogReprod, dcGRLLDataContext>.InstanceBase();
	}
}
