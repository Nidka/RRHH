using System.Diagnostics;

namespace GRLL.Common;

public class ExcretasVivMapper : GenericMapper<ExcretasViv, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ExcretasVivMapper()
	{
	}

	public static GenericMapper<ExcretasViv, dcGRLLDataContext> Instance()
	{
		GenericMapper<ExcretasViv, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<ExcretasViv, dcGRLLDataContext>.InstanceBase();
	}
}
