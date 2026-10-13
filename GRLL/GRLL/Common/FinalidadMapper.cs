using System.Diagnostics;

namespace GRLL.Common;

public class FinalidadMapper : GenericMapper<finalidad, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public FinalidadMapper()
	{
	}

	public static GenericMapper<finalidad, dcGRLLDataContext> Instance()
	{
		GenericMapper<finalidad, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<finalidad, dcGRLLDataContext>.InstanceBase();
	}
}
