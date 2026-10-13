using System.Diagnostics;

namespace GRLL.Common;

public class OperacionMapper : GenericMapper<Operacion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public OperacionMapper()
	{
	}

	public static GenericMapper<Operacion, dcGRLLDataContext> Instance()
	{
		GenericMapper<Operacion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Operacion, dcGRLLDataContext>.InstanceBase();
	}
}
