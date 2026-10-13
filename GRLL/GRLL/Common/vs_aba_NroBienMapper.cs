using System.Diagnostics;

namespace GRLL.Common;

public class vs_aba_NroBienMapper : GenericMapper<vs_aba_NroBien, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_aba_NroBienMapper()
	{
	}

	public static GenericMapper<vs_aba_NroBien, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_aba_NroBien, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_aba_NroBien, dcGRLLDataContext>.InstanceBase();
	}
}
