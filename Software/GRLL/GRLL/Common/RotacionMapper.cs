using System.Diagnostics;

namespace GRLL.Common;

public class RotacionMapper : GenericMapper<Rotacion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public RotacionMapper()
	{
	}

	public static GenericMapper<Rotacion, dcGRLLDataContext> Instance()
	{
		GenericMapper<Rotacion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Rotacion, dcGRLLDataContext>.InstanceBase();
	}
}
