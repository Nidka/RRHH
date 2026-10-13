using System.Diagnostics;

namespace GRLL.Common;

public class vs_ABA_ListarBieneMapper : GenericMapper<vs_ABA_ListarBienes, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_ABA_ListarBieneMapper()
	{
	}

	public static GenericMapper<vs_ABA_ListarBienes, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_ABA_ListarBienes, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_ABA_ListarBienes, dcGRLLDataContext>.InstanceBase();
	}
}
