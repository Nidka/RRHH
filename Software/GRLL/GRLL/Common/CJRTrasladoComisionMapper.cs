using System.Diagnostics;

namespace GRLL.Common;

public class CJRTrasladoComisionMapper : GenericMapper<CJRTrasladoComision, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRTrasladoComisionMapper()
	{
	}

	public static GenericMapper<CJRTrasladoComision, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRTrasladoComision, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRTrasladoComision, dcGRLLDataContext>.InstanceBase();
	}
}
