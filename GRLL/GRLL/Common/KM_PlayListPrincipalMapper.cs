using System.Diagnostics;

namespace GRLL.Common;

public class KM_PlayListPrincipalMapper : GenericMapper<KM_PlayListPrincipal, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public KM_PlayListPrincipalMapper()
	{
	}

	public static GenericMapper<KM_PlayListPrincipal, dcGRLLDataContext> Instance()
	{
		GenericMapper<KM_PlayListPrincipal, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<KM_PlayListPrincipal, dcGRLLDataContext>.InstanceBase();
	}
}
