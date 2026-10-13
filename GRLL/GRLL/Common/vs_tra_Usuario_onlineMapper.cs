using System.Diagnostics;

namespace GRLL.Common;

public class vs_tra_Usuario_onlineMapper : GenericMapper<vs_tra_Usuario_online, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_tra_Usuario_onlineMapper()
	{
	}

	public static GenericMapper<vs_tra_Usuario_online, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_tra_Usuario_online, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_tra_Usuario_online, dcGRLLDataContext>.InstanceBase();
	}
}
