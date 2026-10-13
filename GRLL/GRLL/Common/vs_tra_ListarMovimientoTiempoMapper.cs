using System.Diagnostics;

namespace GRLL.Common;

public class vs_tra_ListarMovimientoTiempoMapper : GenericMapper<vs_tra_ListarMovimientoTiempo, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_tra_ListarMovimientoTiempoMapper()
	{
	}

	public static GenericMapper<vs_tra_ListarMovimientoTiempo, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_tra_ListarMovimientoTiempo, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_tra_ListarMovimientoTiempo, dcGRLLDataContext>.InstanceBase();
	}
}
