using System.Diagnostics;

namespace GRLL.Common;

public class PeriodoLaboralMapper : GenericMapper<PeriodoLaboral, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public PeriodoLaboralMapper()
	{
	}

	public static GenericMapper<PeriodoLaboral, dcGRLLDataContext> Instance()
	{
		GenericMapper<PeriodoLaboral, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<PeriodoLaboral, dcGRLLDataContext>.InstanceBase();
	}
}
