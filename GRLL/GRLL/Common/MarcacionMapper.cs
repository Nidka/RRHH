using System.Diagnostics;

namespace GRLL.Common;

public class MarcacionMapper : GenericMapper<Marcacion, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public MarcacionMapper()
	{
	}

	public static GenericMapper<Marcacion, dcGRLLDataContext> Instance()
	{
		GenericMapper<Marcacion, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Marcacion, dcGRLLDataContext>.InstanceBase();
	}
}
