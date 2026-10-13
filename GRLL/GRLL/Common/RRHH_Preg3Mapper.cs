using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_Preg3Mapper : GenericMapper<RRHH_Preg3, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_Preg3Mapper()
	{
	}

	public static GenericMapper<RRHH_Preg3, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_Preg3, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_Preg3, dcGRLLDataContext>.InstanceBase();
	}
}
