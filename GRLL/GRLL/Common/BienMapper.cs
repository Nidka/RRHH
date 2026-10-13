using System.Diagnostics;

namespace GRLL.Common;

public class BienMapper : GenericMapper<Bien, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public BienMapper()
	{
	}

	public static GenericMapper<Bien, dcGRLLDataContext> Instance()
	{
		GenericMapper<Bien, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Bien, dcGRLLDataContext>.InstanceBase();
	}
}
