using System.Diagnostics;

namespace GRLL.Common;

public class vs_TRA_ListarTramiteMapper : GenericMapper<vs_TRA_ListarTramite, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_TRA_ListarTramiteMapper()
	{
	}

	public static GenericMapper<vs_TRA_ListarTramite, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_TRA_ListarTramite, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_TRA_ListarTramite, dcGRLLDataContext>.InstanceBase();
	}
}
