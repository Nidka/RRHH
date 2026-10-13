using System.Diagnostics;

namespace GRLL.Common;

public class VS_ABA_METAMapper : GenericMapper<VS_ABA_META, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public VS_ABA_METAMapper()
	{
	}

	public static GenericMapper<VS_ABA_META, dcGRLLDataContext> Instance()
	{
		GenericMapper<VS_ABA_META, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<VS_ABA_META, dcGRLLDataContext>.InstanceBase();
	}
}
