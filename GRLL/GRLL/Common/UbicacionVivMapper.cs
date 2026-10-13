using System.Diagnostics;

namespace GRLL.Common;

public class UbicacionVivMapper : GenericMapper<UbicacionViv, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public UbicacionVivMapper()
	{
	}

	public static GenericMapper<UbicacionViv, dcGRLLDataContext> Instance()
	{
		GenericMapper<UbicacionViv, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<UbicacionViv, dcGRLLDataContext>.InstanceBase();
	}
}
