using System.Diagnostics;

namespace GRLL.Common;

public class ParametrosMapper : GenericMapper<Parametros, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ParametrosMapper()
	{
	}

	public static GenericMapper<Parametros, dcGRLLDataContext> Instance()
	{
		GenericMapper<Parametros, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Parametros, dcGRLLDataContext>.InstanceBase();
	}
}
