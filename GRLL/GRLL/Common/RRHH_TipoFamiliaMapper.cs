using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_TipoFamiliaMapper : GenericMapper<RRHH_TipoFamilia, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_TipoFamiliaMapper()
	{
	}

	public static GenericMapper<RRHH_TipoFamilia, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_TipoFamilia, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_TipoFamilia, dcGRLLDataContext>.InstanceBase();
	}
}
