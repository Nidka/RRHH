using System.Diagnostics;

namespace GRLL.Common;

public class ClasificadorIngresoMapper : GenericMapper<ClasificadorIngreso, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ClasificadorIngresoMapper()
	{
	}

	public static GenericMapper<ClasificadorIngreso, dcGRLLDataContext> Instance()
	{
		GenericMapper<ClasificadorIngreso, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<ClasificadorIngreso, dcGRLLDataContext>.InstanceBase();
	}
}
