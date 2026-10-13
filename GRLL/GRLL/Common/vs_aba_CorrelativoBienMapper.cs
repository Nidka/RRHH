using System.Diagnostics;

namespace GRLL.Common;

public class vs_aba_CorrelativoBienMapper : GenericMapper<vs_aba_CorrelativoBien, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_aba_CorrelativoBienMapper()
	{
	}

	public static GenericMapper<vs_aba_CorrelativoBien, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_aba_CorrelativoBien, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_aba_CorrelativoBien, dcGRLLDataContext>.InstanceBase();
	}
}
