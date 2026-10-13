using System.Diagnostics;

namespace GRLL.Common;

public class CapacitacionMapper : GenericMapper<Capacitacion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CapacitacionMapper()
	{
	}

	public static GenericMapper<Capacitacion, dcGRLLDataContext> Instance()
	{
		GenericMapper<Capacitacion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Capacitacion, dcGRLLDataContext>.InstanceBase();
	}
}
