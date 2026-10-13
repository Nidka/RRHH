using System.Diagnostics;

namespace GRLL.Common;

public class vs_aba_DetalleMapper : GenericMapper<vs_aba_Detalle, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_aba_DetalleMapper()
	{
	}

	public static GenericMapper<vs_aba_Detalle, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_aba_Detalle, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_aba_Detalle, dcGRLLDataContext>.InstanceBase();
	}
}
