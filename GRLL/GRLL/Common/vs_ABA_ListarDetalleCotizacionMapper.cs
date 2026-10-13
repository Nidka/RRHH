using System.Diagnostics;

namespace GRLL.Common;

public class vs_ABA_ListarDetalleCotizacionMapper : GenericMapper<vs_ABA_ListarDetalleCotizacion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_ABA_ListarDetalleCotizacionMapper()
	{
	}

	public static GenericMapper<vs_ABA_ListarDetalleCotizacion, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_ABA_ListarDetalleCotizacion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_ABA_ListarDetalleCotizacion, dcGRLLDataContext>.InstanceBase();
	}
}
