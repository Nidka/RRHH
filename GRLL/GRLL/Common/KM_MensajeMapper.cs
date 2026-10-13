using System.Diagnostics;

namespace GRLL.Common;

public class KM_MensajeMapper : GenericMapper<KM_Mensaje, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public KM_MensajeMapper()
	{
	}

	public static GenericMapper<KM_Mensaje, dcGRLLDataContext> Instance()
	{
		GenericMapper<KM_Mensaje, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<KM_Mensaje, dcGRLLDataContext>.InstanceBase();
	}
}
