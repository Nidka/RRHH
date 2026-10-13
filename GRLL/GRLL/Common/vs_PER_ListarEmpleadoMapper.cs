using System.Diagnostics;

namespace GRLL.Common;

public class vs_PER_ListarEmpleadoMapper : GenericMapper<vs_PER_ListarEmpleados, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_PER_ListarEmpleadoMapper()
	{
	}

	public static GenericMapper<vs_PER_ListarEmpleados, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_PER_ListarEmpleados, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_PER_ListarEmpleados, dcGRLLDataContext>.InstanceBase();
	}
}
