using System.Diagnostics;

namespace GRLL.Common;

public class KM_ParametroMapper : GenericMapper<KM_Parametro, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public KM_ParametroMapper()
	{
	}

	public static GenericMapper<KM_Parametro, dcGRLLDataContext> Instance()
	{
		GenericMapper<KM_Parametro, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<KM_Parametro, dcGRLLDataContext>.InstanceBase();
	}
}
