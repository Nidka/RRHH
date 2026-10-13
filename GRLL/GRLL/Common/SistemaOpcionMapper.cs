using System.Diagnostics;

namespace GRLL.Common;

public class SistemaOpcionMapper : GenericMapper<SistemaOpcion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public SistemaOpcionMapper()
	{
	}

	public static GenericMapper<SistemaOpcion, dcGRLLDataContext> Instance()
	{
		GenericMapper<SistemaOpcion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<SistemaOpcion, dcGRLLDataContext>.InstanceBase();
	}
}
