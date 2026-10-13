using System.Diagnostics;

namespace GRLL.Common;

public class CJRTipoAprobacionMapper : GenericMapper<CJRTipoAprobacion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRTipoAprobacionMapper()
	{
	}

	public static GenericMapper<CJRTipoAprobacion, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRTipoAprobacion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRTipoAprobacion, dcGRLLDataContext>.InstanceBase();
	}
}
