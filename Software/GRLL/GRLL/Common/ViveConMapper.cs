using System.Diagnostics;

namespace GRLL.Common;

public class ViveConMapper : GenericMapper<ViveCon, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ViveConMapper()
	{
	}

	public static GenericMapper<ViveCon, dcGRLLDataContext> Instance()
	{
		GenericMapper<ViveCon, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<ViveCon, dcGRLLDataContext>.InstanceBase();
	}
}
