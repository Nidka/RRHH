using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_AseguradoMapper : GenericMapper<RRHH_Asegurado, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_AseguradoMapper()
	{
	}

	public static GenericMapper<RRHH_Asegurado, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_Asegurado, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_Asegurado, dcGRLLDataContext>.InstanceBase();
	}
}
