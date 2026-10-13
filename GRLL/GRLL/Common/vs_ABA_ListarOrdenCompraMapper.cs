using System.Diagnostics;

namespace GRLL.Common;

public class vs_ABA_ListarOrdenCompraMapper : GenericMapper<vs_ABA_ListarOrdenCompra, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public vs_ABA_ListarOrdenCompraMapper()
	{
	}

	public static GenericMapper<vs_ABA_ListarOrdenCompra, dcGRLLDataContext> Instance()
	{
		GenericMapper<vs_ABA_ListarOrdenCompra, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<vs_ABA_ListarOrdenCompra, dcGRLLDataContext>.InstanceBase();
	}
}
