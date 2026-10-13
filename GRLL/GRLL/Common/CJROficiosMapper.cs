using System.Diagnostics;

namespace GRLL.Common;

public class CJROficiosMapper : GenericMapper<CJROficio, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJROficiosMapper()
	{
	}

	public static GenericMapper<CJROficio, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJROficio, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJROficio, dcGRLLDataContext>.InstanceBase();
	}
}
