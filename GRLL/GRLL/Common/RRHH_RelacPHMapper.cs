using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_RelacPHMapper : GenericMapper<RRHH_RelacPH, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_RelacPHMapper()
	{
	}

	public static GenericMapper<RRHH_RelacPH, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_RelacPH, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_RelacPH, dcGRLLDataContext>.InstanceBase();
	}
}
