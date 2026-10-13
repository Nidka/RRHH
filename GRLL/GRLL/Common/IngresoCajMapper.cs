using System.Diagnostics;

namespace GRLL.Common;

public class IngresoCajMapper : GenericMapper<IngresoCaj, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public IngresoCajMapper()
	{
	}

	public static GenericMapper<IngresoCaj, dcGRLLDataContext> Instance()
	{
		GenericMapper<IngresoCaj, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<IngresoCaj, dcGRLLDataContext>.InstanceBase();
	}
}
