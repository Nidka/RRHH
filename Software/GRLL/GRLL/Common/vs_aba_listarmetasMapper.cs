using System.Diagnostics;

namespace GRLL.Common;

public class vs_aba_listarmetasMapper : GenericMapper<vs_ABA_ListarMetas, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_aba_listarmetasMapper()
	{
	}

	public static GenericMapper<vs_ABA_ListarMetas, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_ABA_ListarMetas, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_ABA_ListarMetas, dcGRLLDataContext>.InstanceBase();
	}
}
