using System.Diagnostics;

namespace GRLL.Common;

public class TitulosEmpleadoMapper : GenericMapper<TitulosEmpleado, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TitulosEmpleadoMapper()
	{
	}

	public static GenericMapper<TitulosEmpleado, dcGRLLDataContext> Instance()
	{
		GenericMapper<TitulosEmpleado, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TitulosEmpleado, dcGRLLDataContext>.InstanceBase();
	}
}
