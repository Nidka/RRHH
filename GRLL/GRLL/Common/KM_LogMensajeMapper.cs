using System.Diagnostics;

namespace GRLL.Common;

public class KM_LogMensajeMapper : GenericMapper<KM_LogMensaje, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public KM_LogMensajeMapper()
	{
	}

	public static GenericMapper<KM_LogMensaje, dcGRLLDataContext> Instance()
	{
		GenericMapper<KM_LogMensaje, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<KM_LogMensaje, dcGRLLDataContext>.InstanceBase();
	}
}
