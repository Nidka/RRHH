using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_FeriadoMapper : GenericMapper<RRHH_Feriado, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_FeriadoMapper()
	{
	}

	public static GenericMapper<RRHH_Feriado, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_Feriado, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_Feriado, dcGRLLDataContext>.InstanceBase();
	}
}
