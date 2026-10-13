using System.Diagnostics;

namespace GRLL.Common;

public class KM_TipoOperacionMapper : GenericMapper<KM_TipoOperacion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public KM_TipoOperacionMapper()
	{
	}

	public static GenericMapper<KM_TipoOperacion, dcGRLLDataContext> Instance()
	{
		GenericMapper<KM_TipoOperacion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<KM_TipoOperacion, dcGRLLDataContext>.InstanceBase();
	}
}
