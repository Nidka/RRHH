using System.Diagnostics;

namespace GRLL.Common;

public class GenericaGastoMapper : GenericMapper<GenericaGasto, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public GenericaGastoMapper()
	{
	}

	public static GenericMapper<GenericaGasto, dcGRLLDataContext> Instance()
	{
		GenericMapper<GenericaGasto, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<GenericaGasto, dcGRLLDataContext>.InstanceBase();
	}
}
