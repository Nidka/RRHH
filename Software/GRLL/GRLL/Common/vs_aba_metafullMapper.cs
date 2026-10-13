using System.Diagnostics;

namespace GRLL.Common;

public class vs_aba_metafullMapper : GenericMapper<vs_aba_MetaFull, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_aba_metafullMapper()
	{
	}

	public static GenericMapper<vs_aba_MetaFull, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_aba_MetaFull, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_aba_MetaFull, dcGRLLDataContext>.InstanceBase();
	}
}
