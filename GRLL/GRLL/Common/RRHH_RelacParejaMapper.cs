using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_RelacParejaMapper : GenericMapper<RRHH_RelacPareja, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_RelacParejaMapper()
	{
	}

	public static GenericMapper<RRHH_RelacPareja, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_RelacPareja, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_RelacPareja, dcGRLLDataContext>.InstanceBase();
	}
}
