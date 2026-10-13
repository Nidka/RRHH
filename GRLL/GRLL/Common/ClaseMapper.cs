using System.Diagnostics;

namespace GRLL.Common;

public class ClaseMapper : GenericMapper<Clase, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ClaseMapper()
	{
	}

	public static GenericMapper<Clase, dcGRLLDataContext> Instance()
	{
		GenericMapper<Clase, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Clase, dcGRLLDataContext>.InstanceBase();
	}
}
