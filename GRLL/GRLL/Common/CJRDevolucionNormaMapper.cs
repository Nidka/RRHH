using System.Diagnostics;

namespace GRLL.Common;

public class CJRDevolucionNormaMapper : GenericMapper<CJRDevolucionNorma, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRDevolucionNormaMapper()
	{
	}

	public static GenericMapper<CJRDevolucionNorma, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRDevolucionNorma, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRDevolucionNorma, dcGRLLDataContext>.InstanceBase();
	}
}
