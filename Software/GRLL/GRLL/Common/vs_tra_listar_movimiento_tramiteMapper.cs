using System.Diagnostics;

namespace GRLL.Common;

public class vs_tra_listar_movimiento_tramiteMapper : GenericMapper<vs_tra_listar_movimiento_tramite, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_tra_listar_movimiento_tramiteMapper()
	{
	}

	public static GenericMapper<vs_tra_listar_movimiento_tramite, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_tra_listar_movimiento_tramite, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_tra_listar_movimiento_tramite, dcGRLLDataContext>.InstanceBase();
	}
}
