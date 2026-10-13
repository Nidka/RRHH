using System.Diagnostics;

namespace GRLL.Common;

public class Parametro_PeriodoMapper : GenericMapper<Parametro_Periodo, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Parametro_PeriodoMapper()
	{
	}

	public static GenericMapper<Parametro_Periodo, dcGRLLDataContext> Instance()
	{
		GenericMapper<Parametro_Periodo, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Parametro_Periodo, dcGRLLDataContext>.InstanceBase();
	}
}
