using System.Diagnostics;

namespace GRLL.Common;

public class AlumbradoVivMapper : GenericMapper<AlumbradoViv, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public AlumbradoVivMapper()
	{
	}

	public static GenericMapper<AlumbradoViv, dcGRLLDataContext> Instance()
	{
		GenericMapper<AlumbradoViv, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<AlumbradoViv, dcGRLLDataContext>.InstanceBase();
	}
}
