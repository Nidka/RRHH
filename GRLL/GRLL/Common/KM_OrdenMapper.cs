using System.Diagnostics;

namespace GRLL.Common;

public class KM_OrdenMapper : GenericMapper<KM_Orden, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public KM_OrdenMapper()
	{
	}

	public static GenericMapper<KM_Orden, dcGRLLDataContext> Instance()
	{
		GenericMapper<KM_Orden, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<KM_Orden, dcGRLLDataContext>.InstanceBase();
	}
}
