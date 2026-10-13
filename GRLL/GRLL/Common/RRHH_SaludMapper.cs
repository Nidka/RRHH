using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_SaludMapper : GenericMapper<RRHH_Salud, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_SaludMapper()
	{
	}

	public static GenericMapper<RRHH_Salud, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_Salud, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_Salud, dcGRLLDataContext>.InstanceBase();
	}
}
