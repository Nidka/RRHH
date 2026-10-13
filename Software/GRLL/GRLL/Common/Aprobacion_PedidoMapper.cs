using System.Diagnostics;

namespace GRLL.Common;

public class Aprobacion_PedidoMapper : GenericMapper<Aprobacion_Pedido, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public Aprobacion_PedidoMapper()
	{
	}

	public static GenericMapper<Aprobacion_Pedido, dcGRLLDataContext> Instance()
	{
		GenericMapper<Aprobacion_Pedido, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Aprobacion_Pedido, dcGRLLDataContext>.InstanceBase();
	}
}
