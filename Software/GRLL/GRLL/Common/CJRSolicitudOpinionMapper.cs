using System.Diagnostics;

namespace GRLL.Common;

public class CJRSolicitudOpinionMapper : GenericMapper<CJRSolicitudOpinion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRSolicitudOpinionMapper()
	{
	}

	public static GenericMapper<CJRSolicitudOpinion, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRSolicitudOpinion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRSolicitudOpinion, dcGRLLDataContext>.InstanceBase();
	}
}
