using System.Diagnostics;

namespace GRLL.Common;

public class VS_ABA_NROMAXPERJMapper : GenericMapper<VS_ABA_NROMAXPERJ, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public VS_ABA_NROMAXPERJMapper()
	{
	}

	public static GenericMapper<VS_ABA_NROMAXPERJ, dcGRLLDataContext> Instance()
	{
		GenericMapper<VS_ABA_NROMAXPERJ, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<VS_ABA_NROMAXPERJ, dcGRLLDataContext>.InstanceBase();
	}
}
