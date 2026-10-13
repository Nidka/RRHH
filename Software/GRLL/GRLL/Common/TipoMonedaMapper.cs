using System.Diagnostics;

namespace GRLL.Common;

public class TipoMonedaMapper : GenericMapper<TipoMoneda, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoMonedaMapper()
	{
	}

	public static GenericMapper<TipoMoneda, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoMoneda, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoMoneda, dcGRLLDataContext>.InstanceBase();
	}
}
