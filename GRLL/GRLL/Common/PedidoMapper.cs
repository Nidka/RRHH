using System.Diagnostics;

namespace GRLL.Common;

public class PedidoMapper : GenericMapper<Pedido, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public PedidoMapper()
	{
	}

	public static GenericMapper<Pedido, dcGRLLDataContext> Instance()
	{
		GenericMapper<Pedido, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Pedido, dcGRLLDataContext>.InstanceBase();
	}
}
