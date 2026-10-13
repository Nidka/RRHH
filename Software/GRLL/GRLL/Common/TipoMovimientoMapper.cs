using System.Diagnostics;

namespace GRLL.Common;

public class TipoMovimientoMapper : GenericMapper<TipoMovimiento, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public TipoMovimientoMapper()
	{
	}

	public static GenericMapper<TipoMovimiento, dcGRLLDataContext> Instance()
	{
		GenericMapper<TipoMovimiento, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<TipoMovimiento, dcGRLLDataContext>.InstanceBase();
	}
}
