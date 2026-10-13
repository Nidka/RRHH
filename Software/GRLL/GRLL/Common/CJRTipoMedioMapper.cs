using System.Diagnostics;

namespace GRLL.Common;

public class CJRTipoMedioMapper : GenericMapper<CJRTipoMedio, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public CJRTipoMedioMapper()
	{
	}

	public static GenericMapper<CJRTipoMedio, dcGRLLDataContext> Instance()
	{
		GenericMapper<CJRTipoMedio, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<CJRTipoMedio, dcGRLLDataContext>.InstanceBase();
	}
}
