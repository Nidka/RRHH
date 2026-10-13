using System.Diagnostics;

namespace GRLL.Common;

public class MaterialVivMapper : GenericMapper<MaterialViv, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public MaterialVivMapper()
	{
	}

	public static GenericMapper<MaterialViv, dcGRLLDataContext> Instance()
	{
		GenericMapper<MaterialViv, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<MaterialViv, dcGRLLDataContext>.InstanceBase();
	}
}
