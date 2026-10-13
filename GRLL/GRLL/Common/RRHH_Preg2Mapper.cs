using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_Preg2Mapper : GenericMapper<RRHH_Preg2, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_Preg2Mapper()
	{
	}

	public static GenericMapper<RRHH_Preg2, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_Preg2, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_Preg2, dcGRLLDataContext>.InstanceBase();
	}
}
