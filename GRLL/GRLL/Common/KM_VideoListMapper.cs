using System.Diagnostics;

namespace GRLL.Common;

public class KM_VideoListMapper : GenericMapper<KM_VideoList, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public KM_VideoListMapper()
	{
	}

	public static GenericMapper<KM_VideoList, dcGRLLDataContext> Instance()
	{
		GenericMapper<KM_VideoList, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<KM_VideoList, dcGRLLDataContext>.InstanceBase();
	}
}
