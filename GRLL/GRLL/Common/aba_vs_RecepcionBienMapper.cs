using System.Diagnostics;

namespace GRLL.Common;

public class aba_vs_RecepcionBienMapper : GenericMapper<aba_vs_RecepcionBien, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public aba_vs_RecepcionBienMapper()
	{
	}

	public static GenericMapper<aba_vs_RecepcionBien, dcGRLLDataContext> Instance()
	{
		GenericMapper<aba_vs_RecepcionBien, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<aba_vs_RecepcionBien, dcGRLLDataContext>.InstanceBase();
	}
}
