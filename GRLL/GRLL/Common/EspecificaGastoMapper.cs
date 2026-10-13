using System.Diagnostics;

namespace GRLL.Common;

public class EspecificaGastoMapper : GenericMapper<EspecificaGasto, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public EspecificaGastoMapper()
	{
	}

	public static GenericMapper<EspecificaGasto, dcGRLLDataContext> Instance()
	{
		GenericMapper<EspecificaGasto, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<EspecificaGasto, dcGRLLDataContext>.InstanceBase();
	}
}
