using System.Diagnostics;

namespace GRLL.Common;

public class aba_vs_Deta_Consolidado_ContratoMapper : GenericMapper<aba_vs_Deta_Consolidado_Contrato, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public aba_vs_Deta_Consolidado_ContratoMapper()
	{
	}

	public static GenericMapper<aba_vs_Deta_Consolidado_Contrato, dcGRLLDataContext> Instance()
	{
		GenericMapper<aba_vs_Deta_Consolidado_Contrato, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<aba_vs_Deta_Consolidado_Contrato, dcGRLLDataContext>.InstanceBase();
	}
}
