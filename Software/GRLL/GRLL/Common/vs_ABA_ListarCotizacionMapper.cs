using System.Diagnostics;

namespace GRLL.Common;

public class vs_ABA_ListarCotizacionMapper : GenericMapper<vs_ABA_ListarCotizacion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_ABA_ListarCotizacionMapper()
	{
	}

	public static GenericMapper<vs_ABA_ListarCotizacion, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_ABA_ListarCotizacion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_ABA_ListarCotizacion, dcGRLLDataContext>.InstanceBase();
	}
}
