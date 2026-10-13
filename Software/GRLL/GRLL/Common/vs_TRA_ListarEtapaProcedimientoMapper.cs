using System.Diagnostics;

namespace GRLL.Common;

public class vs_TRA_ListarEtapaProcedimientoMapper : GenericMapper<vs_TRA_ListarEtapaProcedimiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_TRA_ListarEtapaProcedimientoMapper()
	{
	}

	public static GenericMapper<vs_TRA_ListarEtapaProcedimiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_TRA_ListarEtapaProcedimiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_TRA_ListarEtapaProcedimiento, dcGRLLDataContext>.InstanceBase();
	}
}
