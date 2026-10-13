using System.Diagnostics;

namespace GRLL.Common;

public class CJRDictamenComisionMapper : GenericMapper<CJRDictamenComision, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRDictamenComisionMapper()
	{
	}

	public static GenericMapper<CJRDictamenComision, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRDictamenComision, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRDictamenComision, dcGRLLDataContext>.InstanceBase();
	}
}
