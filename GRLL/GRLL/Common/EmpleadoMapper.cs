using System.Diagnostics;

namespace GRLL.Common;

public class EmpleadoMapper : GenericMapper<Empleado, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public EmpleadoMapper()
	{
	}

	public static GenericMapper<Empleado, dcGRLLDataContext> Instance()
	{
		GenericMapper<Empleado, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Empleado, dcGRLLDataContext>.InstanceBase();
	}
}
