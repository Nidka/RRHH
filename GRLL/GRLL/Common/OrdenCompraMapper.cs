using System.Diagnostics;

namespace GRLL.Common;

public class OrdenCompraMapper : GenericMapper<OrdenCompra, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public OrdenCompraMapper()
	{
	}

	public static GenericMapper<OrdenCompra, dcGRLLDataContext> Instance()
	{
		GenericMapper<OrdenCompra, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<OrdenCompra, dcGRLLDataContext>.InstanceBase();
	}
}
