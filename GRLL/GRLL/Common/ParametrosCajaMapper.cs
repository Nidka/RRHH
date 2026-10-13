using System.Diagnostics;

namespace GRLL.Common;

public class ParametrosCajaMapper : GenericMapper<ParametrosCaja, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ParametrosCajaMapper()
	{
	}

	public static GenericMapper<ParametrosCaja, dcGRLLDataContext> Instance()
	{
		GenericMapper<ParametrosCaja, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<ParametrosCaja, dcGRLLDataContext>.InstanceBase();
	}
}
