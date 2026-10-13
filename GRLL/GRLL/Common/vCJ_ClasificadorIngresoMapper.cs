using System.Diagnostics;

namespace GRLL.Common;

public class vCJ_ClasificadorIngresoMapper : GenericMapper<vCJ_ClasificadorIngreso, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vCJ_ClasificadorIngresoMapper()
	{
	}

	public static GenericMapper<vCJ_ClasificadorIngreso, dcGRLLDataContext> Instance()
	{
		GenericMapper<vCJ_ClasificadorIngreso, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vCJ_ClasificadorIngreso, dcGRLLDataContext>.InstanceBase();
	}
}
