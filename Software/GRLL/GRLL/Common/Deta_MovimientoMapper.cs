using System.Diagnostics;

namespace GRLL.Common;

public class Deta_MovimientoMapper : GenericMapper<Deta_Movimiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Deta_MovimientoMapper()
	{
	}

	public static GenericMapper<Deta_Movimiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<Deta_Movimiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Deta_Movimiento, dcGRLLDataContext>.InstanceBase();
	}
}
