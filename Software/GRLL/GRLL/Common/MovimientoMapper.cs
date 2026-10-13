using System.Diagnostics;

namespace GRLL.Common;

public class MovimientoMapper : GenericMapper<Movimiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public MovimientoMapper()
	{
	}

	public static GenericMapper<Movimiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<Movimiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Movimiento, dcGRLLDataContext>.InstanceBase();
	}
}
