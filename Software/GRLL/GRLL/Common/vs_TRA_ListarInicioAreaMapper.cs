using System.Diagnostics;

namespace GRLL.Common;

public class vs_TRA_ListarInicioAreaMapper : GenericMapper<vs_TRA_ListarInicioArea, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_TRA_ListarInicioAreaMapper()
	{
	}

	public static GenericMapper<vs_TRA_ListarInicioArea, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_TRA_ListarInicioArea, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_TRA_ListarInicioArea, dcGRLLDataContext>.InstanceBase();
	}
}
