using System.Diagnostics;

namespace GRLL.Common;

public class EstadoPedidoMapper : GenericMapper<EstadoPedido, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public EstadoPedidoMapper()
	{
	}

	public static GenericMapper<EstadoPedido, dcGRLLDataContext> Instance()
	{
		GenericMapper<EstadoPedido, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<EstadoPedido, dcGRLLDataContext>.InstanceBase();
	}
}
