using System.Diagnostics;

namespace GRLL.Common;

public class ResolucionMapper : GenericMapper<Resolucion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ResolucionMapper()
	{
	}

	public static GenericMapper<Resolucion, dcGRLLDataContext> Instance()
	{
		GenericMapper<Resolucion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Resolucion, dcGRLLDataContext>.InstanceBase();
	}
}
