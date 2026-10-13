using System.Diagnostics;

namespace GRLL.Common;

public class KM_PlayListAvisoMapper : GenericMapper<KM_PlayListAviso, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public KM_PlayListAvisoMapper()
	{
	}

	public static GenericMapper<KM_PlayListAviso, dcGRLLDataContext> Instance()
	{
		GenericMapper<KM_PlayListAviso, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<KM_PlayListAviso, dcGRLLDataContext>.InstanceBase();
	}
}
