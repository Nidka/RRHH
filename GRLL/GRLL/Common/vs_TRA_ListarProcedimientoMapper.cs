using System.Diagnostics;

namespace GRLL.Common;

public class vs_TRA_ListarProcedimientoMapper : GenericMapper<vs_TRA_ListarProcedimiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_TRA_ListarProcedimientoMapper()
	{
	}

	public static GenericMapper<vs_TRA_ListarProcedimiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_TRA_ListarProcedimiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_TRA_ListarProcedimiento, dcGRLLDataContext>.InstanceBase();
	}
}
