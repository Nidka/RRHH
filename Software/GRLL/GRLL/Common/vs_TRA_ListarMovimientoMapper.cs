using System.Diagnostics;

namespace GRLL.Common;

public class vs_TRA_ListarMovimientoMapper : GenericMapper<vs_TRA_ListarMovimiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_TRA_ListarMovimientoMapper()
	{
	}

	public static GenericMapper<vs_TRA_ListarMovimiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_TRA_ListarMovimiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_TRA_ListarMovimiento, dcGRLLDataContext>.InstanceBase();
	}
}
