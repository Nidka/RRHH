using System.Diagnostics;

namespace GRLL.Common;

public class Deta_CotizacionMapper : GenericMapper<Deta_Cotizacion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Deta_CotizacionMapper()
	{
	}

	public static GenericMapper<Deta_Cotizacion, dcGRLLDataContext> Instance()
	{
		GenericMapper<Deta_Cotizacion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Deta_Cotizacion, dcGRLLDataContext>.InstanceBase();
	}
}
