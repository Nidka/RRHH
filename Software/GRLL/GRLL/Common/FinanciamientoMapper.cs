using System.Diagnostics;

namespace GRLL.Common;

public class FinanciamientoMapper : GenericMapper<Financiamiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public FinanciamientoMapper()
	{
	}

	public static GenericMapper<Financiamiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<Financiamiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Financiamiento, dcGRLLDataContext>.InstanceBase();
	}
}
