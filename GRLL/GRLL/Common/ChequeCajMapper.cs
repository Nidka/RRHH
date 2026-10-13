using System.Diagnostics;

namespace GRLL.Common;

public class ChequeCajMapper : GenericMapper<ChequeCaj, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ChequeCajMapper()
	{
	}

	public static GenericMapper<ChequeCaj, dcGRLLDataContext> Instance()
	{
		GenericMapper<ChequeCaj, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<ChequeCaj, dcGRLLDataContext>.InstanceBase();
	}
}
