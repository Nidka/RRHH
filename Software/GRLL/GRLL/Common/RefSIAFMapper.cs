using System.Diagnostics;

namespace GRLL.Common;

public class RefSIAFMapper : GenericMapper<RefSIAF, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RefSIAFMapper()
	{
	}

	public static GenericMapper<RefSIAF, dcGRLLDataContext> Instance()
	{
		GenericMapper<RefSIAF, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RefSIAF, dcGRLLDataContext>.InstanceBase();
	}
}
