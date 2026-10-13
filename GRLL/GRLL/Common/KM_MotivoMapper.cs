using System.Diagnostics;

namespace GRLL.Common;

public class KM_MotivoMapper : GenericMapper<KM_Motivo, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public KM_MotivoMapper()
	{
	}

	public static GenericMapper<KM_Motivo, dcGRLLDataContext> Instance()
	{
		GenericMapper<KM_Motivo, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<KM_Motivo, dcGRLLDataContext>.InstanceBase();
	}
}
