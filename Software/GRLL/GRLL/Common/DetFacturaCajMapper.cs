using System.Diagnostics;

namespace GRLL.Common;

public class DetFacturaCajMapper : GenericMapper<DetFacturaCaj, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public DetFacturaCajMapper()
	{
	}

	public static GenericMapper<DetFacturaCaj, dcGRLLDataContext> Instance()
	{
		GenericMapper<DetFacturaCaj, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<DetFacturaCaj, dcGRLLDataContext>.InstanceBase();
	}
}
