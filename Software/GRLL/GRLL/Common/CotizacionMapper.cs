using System.Diagnostics;

namespace GRLL.Common;

public class CotizacionMapper : GenericMapper<Cotizacion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CotizacionMapper()
	{
	}

	public static GenericMapper<Cotizacion, dcGRLLDataContext> Instance()
	{
		GenericMapper<Cotizacion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Cotizacion, dcGRLLDataContext>.InstanceBase();
	}
}
