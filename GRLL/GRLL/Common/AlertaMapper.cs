using System.Diagnostics;

namespace GRLL.Common;

public class AlertaMapper : GenericMapper<Alerta, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public AlertaMapper()
	{
	}

	public static GenericMapper<Alerta, dcGRLLDataContext> Instance()
	{
		GenericMapper<Alerta, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Alerta, dcGRLLDataContext>.InstanceBase();
	}
}
