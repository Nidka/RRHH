using System.Diagnostics;

namespace GRLL.Common;

public class vs_ABA_ListarDetallePedidoMapper : GenericMapper<vs_ABA_ListarDetallePedido, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_ABA_ListarDetallePedidoMapper()
	{
	}

	public static GenericMapper<vs_ABA_ListarDetallePedido, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_ABA_ListarDetallePedido, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_ABA_ListarDetallePedido, dcGRLLDataContext>.InstanceBase();
	}
}
