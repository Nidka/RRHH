using System.Diagnostics;

namespace GRLL.Common;

public class UnidadMedidaMapper : GenericMapper<UnidadMedida, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public UnidadMedidaMapper()
	{
	}

	public static GenericMapper<UnidadMedida, dcGRLLDataContext> Instance()
	{
		GenericMapper<UnidadMedida, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<UnidadMedida, dcGRLLDataContext>.InstanceBase();
	}
}
