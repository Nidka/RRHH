using System.Diagnostics;

namespace GRLL.Common;

public class TRAMovimientoMapper : GenericMapper<TRAMovimiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TRAMovimientoMapper()
	{
	}

	public static GenericMapper<TRAMovimiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<TRAMovimiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TRAMovimiento, dcGRLLDataContext>.InstanceBase();
	}
}
