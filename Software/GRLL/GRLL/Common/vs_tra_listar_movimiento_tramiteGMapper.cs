using System.Diagnostics;

namespace GRLL.Common;

public class vs_tra_listar_movimiento_tramiteGMapper : GenericMapper<vs_tra_listar_movimiento_tramite_G, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_tra_listar_movimiento_tramiteGMapper()
	{
	}

	public static GenericMapper<vs_tra_listar_movimiento_tramite_G, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_tra_listar_movimiento_tramite_G, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_tra_listar_movimiento_tramite_G, dcGRLLDataContext>.InstanceBase();
	}
}
