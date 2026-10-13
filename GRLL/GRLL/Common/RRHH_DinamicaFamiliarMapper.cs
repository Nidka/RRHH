using System.Diagnostics;

namespace GRLL.Common;

public class RRHH_DinamicaFamiliarMapper : GenericMapper<RRHH_DinamicaFamiliar, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RRHH_DinamicaFamiliarMapper()
	{
	}

	public static GenericMapper<RRHH_DinamicaFamiliar, dcGRLLDataContext> Instance()
	{
		GenericMapper<RRHH_DinamicaFamiliar, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<RRHH_DinamicaFamiliar, dcGRLLDataContext>.InstanceBase();
	}
}
