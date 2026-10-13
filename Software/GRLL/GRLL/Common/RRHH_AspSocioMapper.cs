using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_AspSocioMapper : GenericMapper<RRHH_AspSocio, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_AspSocioMapper()
	{
	}

	public static GenericMapper<RRHH_AspSocio, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_AspSocio, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_AspSocio, dcGRLLDataContext>.InstanceBase();
	}
}
