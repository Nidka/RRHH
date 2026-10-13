using System.Diagnostics;

namespace GRLL.Common;

public class vs_ABA_ListarPedidoMapper : GenericMapper<vs_ABA_ListarPedidos, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_ABA_ListarPedidoMapper()
	{
	}

	public static GenericMapper<vs_ABA_ListarPedidos, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_ABA_ListarPedidos, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_ABA_ListarPedidos, dcGRLLDataContext>.InstanceBase();
	}
}
