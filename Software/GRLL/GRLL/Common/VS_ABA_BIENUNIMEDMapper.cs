using System.Diagnostics;

namespace GRLL.Common;

public class VS_ABA_BIENUNIMEDMapper : GenericMapper<VS_ABA_BIENUNIMED, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public VS_ABA_BIENUNIMEDMapper()
	{
	}

	public static GenericMapper<VS_ABA_BIENUNIMED, dcGRLLDataContext> Instance()
	{
		GenericMapper<VS_ABA_BIENUNIMED, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<VS_ABA_BIENUNIMED, dcGRLLDataContext>.InstanceBase();
	}
}
