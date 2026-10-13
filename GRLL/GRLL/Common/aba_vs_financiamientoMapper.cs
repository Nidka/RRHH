using System.Diagnostics;

namespace GRLL.Common;

public class aba_vs_financiamientoMapper : GenericMapper<aba_vs_financiamiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public aba_vs_financiamientoMapper()
	{
	}

	public static GenericMapper<aba_vs_financiamiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<aba_vs_financiamiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<aba_vs_financiamiento, dcGRLLDataContext>.InstanceBase();
	}
}
