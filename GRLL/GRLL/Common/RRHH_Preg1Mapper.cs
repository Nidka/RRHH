using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_Preg1Mapper : GenericMapper<RRHH_Preg1, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_Preg1Mapper()
	{
	}

	public static GenericMapper<RRHH_Preg1, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_Preg1, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_Preg1, dcGRLLDataContext>.InstanceBase();
	}
}
