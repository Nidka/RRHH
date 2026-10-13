using System.Diagnostics;

namespace GRLL.Common;

public class ProveedorMapper : GenericMapper<Proveedor, dcGRLLDataContext>
{
	[DebuggerNonUserCode]
	public ProveedorMapper()
	{
	}

	public static GenericMapper<Proveedor, dcGRLLDataContext> Instance()
	{
		GenericMapper<Proveedor, dcGRLLDataContext>.DataContext = new dcGRLLDataContext(clsConexion.Conexion);
		return GenericMapper<Proveedor, dcGRLLDataContext>.InstanceBase();
	}
}
