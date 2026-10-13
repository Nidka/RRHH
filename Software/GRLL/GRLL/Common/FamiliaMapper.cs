using System.Diagnostics;

namespace GRLL.Common;

public class FamiliaMapper : GenericMapper<Familia, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public FamiliaMapper()
	{
	}

	public static GenericMapper<Familia, dcGRLLDataContext> Instance()
	{
		GenericMapper<Familia, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Familia, dcGRLLDataContext>.InstanceBase();
	}
}
