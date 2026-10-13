using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_RelacHermanoMapper : GenericMapper<RRHH_RelacHermano, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_RelacHermanoMapper()
	{
	}

	public static GenericMapper<RRHH_RelacHermano, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_RelacHermano, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_RelacHermano, dcGRLLDataContext>.InstanceBase();
	}
}
