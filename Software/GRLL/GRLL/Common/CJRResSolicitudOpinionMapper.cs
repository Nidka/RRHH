using System.Diagnostics;

namespace GRLL.Common;

public class CJRResSolicitudOpinionMapper : GenericMapper<CJRResSolicitudOpinion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRResSolicitudOpinionMapper()
	{
	}

	public static GenericMapper<CJRResSolicitudOpinion, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRResSolicitudOpinion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRResSolicitudOpinion, dcGRLLDataContext>.InstanceBase();
	}
}
