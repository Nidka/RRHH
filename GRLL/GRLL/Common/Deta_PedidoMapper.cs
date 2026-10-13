using System.Diagnostics;

namespace GRLL.Common;

public class Deta_PedidoMapper : GenericMapper<Deta_Pedido, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Deta_PedidoMapper()
	{
	}

	public static GenericMapper<Deta_Pedido, dcGRLLDataContext> Instance()
	{
		GenericMapper<Deta_Pedido, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Deta_Pedido, dcGRLLDataContext>.InstanceBase();
	}
}
